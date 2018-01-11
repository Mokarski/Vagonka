using System;
using System.Collections.Generic;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Fonts
{
    public class TextRender : ITextRender
    {
        private IntPtr mFont;

        private class Adjustments
        {
            public readonly float mX;
            public readonly float mY;

            public Adjustments(float x, float y)
            {
                mX = x;
                mY = y;
            }
        }

        private readonly Dictionary<uint, Adjustments> mAdjustmentses = new Dictionary<uint, Adjustments>();
        private readonly Dictionary<uint, Adjustments> mEscapements = new Dictionary<uint, Adjustments>();
        private readonly IFontInfo mFontInfo;
        private readonly Dictionary<uint, Glyph> mGlyphDictionary = new Dictionary<uint, Glyph>();

        public TextRender(IFontInfo aFontInfo)
        {
            mFontInfo = aFontInfo;

            Init();
        }

        private Adjustments LoadGlyph(uint index)
        {
            Adjustments adjustments;
            mEscapements.TryGetValue(index, out adjustments);
            if (adjustments != null)
                return adjustments;

            //Application.GetInstance().DebugTimeToConsole("--> LoadGlyph (" + index + "):");
            {
                Glyph rv;
                mGlyphDictionary.TryGetValue(index, out rv);

                if (rv == null)
                    return null;

                adjustments = new Adjustments(rv.escapement[0], rv.escapement[1]);
                mEscapements.Add(rv.glyphIndex, adjustments);

                var glyphPath = VG.vgCreatePath(0, VGPathDatatype.VG_PATH_DATATYPE_F, 1.0f, 0.0f, 0, 0, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);
                VG.vgAppendPathData(glyphPath, rv.commands.Length, rv.commands, rv.coordinates);
                VG.vgSetGlyphToPath(mFont, rv.glyphIndex, glyphPath, VGboolean.VG_TRUE, rv.origin, rv.escapement);
                VG.vgDestroyPath(glyphPath);
            }

            return adjustments;
            //Application.GetInstance().DebugTimeToConsole("<-- LoadGlyph (" + index + "):");
        }

        private void Init()
        {
            if (mFont != IntPtr.Zero)
                return;

            mFont = VG.vgCreateFont(mFontInfo.Glyphs.Length);

            foreach (var kerning in mFontInfo.Kernings)
            {
                mAdjustmentses.Add(kerning.key, new Adjustments(kerning.x, kerning.y));
            }

            foreach (var glyph in mFontInfo.Glyphs)
            {
                mGlyphDictionary.Add(glyph.glyphIndex, glyph);
            }
        }

        private Adjustments GetKerning(char leftChar, char rightChar)
        {
            var key = ((uint)leftChar << 16) + rightChar;

            Adjustments rv;
            return mAdjustmentses.TryGetValue(key, out rv) ? rv : null;
        }

        public void RenderText(string text)
        {
            //Application.GetInstance().DebugTimeToConsole("--> RenderText: " + text);

            // set paint
            //VG.vgSetPaint(mFont, VGPaintMode.VG_FILL_PATH);
            //VG.vgSetPaint(mFont, VGPaintMode.VG_STROKE_PATH | VGPaintMode.VG_FILL_PATH);

            // build kerning information
            var glyphIndices = new uint[text.Length];

            var adjustmentsX = new float[text.Length];
            var adjustmentsY = new float[text.Length];

            for (var i = 0; i < text.Length; ++i)
            {

                // find kerning relative to the characters couple
                var kerning = GetKerning(text[i], i < text.Length - 1 ? text[i + 1] : text[i]);

                // fill adjustments
                glyphIndices[i] = text[i];
                if (kerning != null)
                {
                    adjustmentsX[i] = kerning.mX;
                    adjustmentsY[i] = kerning.mY;
                }
                else
                {
                    adjustmentsX[i] = 0.0f;
                    adjustmentsY[i] = 0.0f;
                }
            }

            //Application.GetInstance().DebugTimeToConsole("RenderText:LoadGlyph");

            // draw glyphs
            VG.vgSeti(VGParamType.VG_RENDERING_QUALITY, (int)VGRenderingQuality.VG_RENDERING_QUALITY_BETTER);

            //VG.vgDrawGlyphs(mFont, text.Length, glyphIndices, adjustmentsX, adjustmentsY, VGPaintMode.VG_FILL_PATH, VGboolean.VG_FALSE);
            VG.vgDrawGlyphs(mFont, text.Length, glyphIndices, adjustmentsX, adjustmentsY, VGPaintMode.VG_FILL_PATH, VGboolean.VG_TRUE);
            //VG.vgDrawGlyphs(mFont, text.Length, glyphIndices, adjustmentsX, adjustmentsY, VGPaintMode.VG_FILL_PATH, VGboolean.VG_TRUE);

            //Application.GetInstance().DebugTimeToConsole("<-- RenderText");

            //float[] origin = { 0.0f, 0.0f };
            //VG.vgGetfv(VGParamType.VG_GLYPH_ORIGIN, 2, origin);
        }

        public float[] GetEscapement(string text)
        {
            var offset = new float[2];

            foreach (var t in text)
            {
                var rv = LoadGlyph(t);
                if (rv == null) continue;

                offset[0] += rv.mX;
                offset[1] += rv.mY;
            }
            return offset;
        }

        public void Dispose()
        {
            if (mFont != new IntPtr())
                VG.vgDestroyFont(mFont);

            mAdjustmentses.Clear();
            mEscapements.Clear();
        }
    }
}

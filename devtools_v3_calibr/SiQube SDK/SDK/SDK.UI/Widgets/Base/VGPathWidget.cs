using System.Collections.Generic;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Widgets.Base
{
    public class VGPathWidget : Widget
    {
        private readonly List<VGPath> mPath = new List<VGPath>();

        public VGPathWidget(int width, int height) : base(null, width, height) { }

        public void AddPath(VGPath path)
        {
            mPath.Add(path);

            var w = Width > path.Width ? Width : path.Width;
            var h = Height > path.Height ? Height : path.Height;

            Resize(w, h);
        }

        protected override void Draw()
        {
            foreach (var vgPath in mPath)
            {
                vgPath.Update();
            }
        }

        public override void Update(GfxRect updateArea)
        {
            mRenderBuffer.ToSurface();
        }
    }
}
#define RENDERING_ON_VGIMAGE

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace SDK.UI
{
    public enum VGboolean
    {
        VG_FALSE = 0,
        VG_TRUE = 1
    };

    public enum VGUArcType
    {
        VGU_ARC_OPEN = 0xF100,
        VGU_ARC_CHORD = 0xF101,
        VGU_ARC_PIE = 0xF102
    };

    public enum VGUErrorCode
    {
        VGU_NO_ERROR = 0,
        VGU_BAD_HANDLE_ERROR = 0xF000,
        VGU_ILLEGAL_ARGUMENT_ERROR = 0xF001,
        VGU_OUT_OF_MEMORY_ERROR = 0xF002,
        VGU_PATH_CAPABILITY_ERROR = 0xF003,
        VGU_BAD_WARP_ERROR = 0xF004
    };

    public enum VGErrorCode
    {
        VG_NO_ERROR = 0,
        VG_BAD_HANDLE_ERROR = 0x1000,
        VG_ILLEGAL_ARGUMENT_ERROR = 0x1001,
        VG_OUT_OF_MEMORY_ERROR = 0x1002,
        VG_PATH_CAPABILITY_ERROR = 0x1003,
        VG_UNSUPPORTED_IMAGE_FORMAT_ERROR = 0x1004,
        VG_UNSUPPORTED_PATH_FORMAT_ERROR = 0x1005,
        VG_IMAGE_IN_USE_ERROR = 0x1006,
        VG_NO_CONTEXT_ERROR = 0x1007
    };

    public enum VGParamType
    {
        /* Mode settings */
        VG_MATRIX_MODE = 0x1100,
        VG_FILL_RULE = 0x1101,
        VG_IMAGE_QUALITY = 0x1102,
        VG_RENDERING_QUALITY = 0x1103,
        VG_BLEND_MODE = 0x1104,
        VG_IMAGE_MODE = 0x1105,

        /* Scissoring rectangles */
        VG_SCISSOR_RECTS = 0x1106,

        /* Stroke parameters */
        VG_STROKE_LINE_WIDTH = 0x1110,
        VG_STROKE_CAP_STYLE = 0x1111,
        VG_STROKE_JOIN_STYLE = 0x1112,
        VG_STROKE_MITER_LIMIT = 0x1113,
        VG_STROKE_DASH_PATTERN = 0x1114,
        VG_STROKE_DASH_PHASE = 0x1115,
        VG_STROKE_DASH_PHASE_RESET = 0x1116,

        /* Edge fill color for VG_TILE_FILL tiling mode */
        VG_TILE_FILL_COLOR = 0x1120,

        /* Color for vgClear */
        VG_CLEAR_COLOR = 0x1121,

        /* Glyph origin */
        VG_GLYPH_ORIGIN = 0x1122,

        /* Enable/disable alpha masking and scissoring */
        VG_MASKING = 0x1130,
        VG_SCISSORING = 0x1131,

        /* Pixel layout information */
        VG_PIXEL_LAYOUT = 0x1140,
        VG_SCREEN_LAYOUT = 0x1141,

        /* Source format selection for image filters */
        VG_FILTER_FORMAT_LINEAR = 0x1150,
        VG_FILTER_FORMAT_PREMULTIPLIED = 0x1151,

        /* Destination write enable mask for image filters */
        VG_FILTER_CHANNEL_MASK = 0x1152,

        /* Implementation limits (read-only) */
        VG_MAX_SCISSOR_RECTS = 0x1160,
        VG_MAX_DASH_COUNT = 0x1161,
        VG_MAX_KERNEL_SIZE = 0x1162,
        VG_MAX_SEPARABLE_KERNEL_SIZE = 0x1163,
        VG_MAX_COLOR_RAMP_STOPS = 0x1164,
        VG_MAX_IMAGE_WIDTH = 0x1165,
        VG_MAX_IMAGE_HEIGHT = 0x1166,
        VG_MAX_IMAGE_PIXELS = 0x1167,
        VG_MAX_IMAGE_BYTES = 0x1168,
        VG_MAX_FLOAT = 0x1169,
        VG_MAX_GAUSSIAN_STD_DEVIATION = 0x116A
    };

    public enum VGRenderingQuality
    {
        VG_RENDERING_QUALITY_NONANTIALIASED = 0x1200,
        VG_RENDERING_QUALITY_FASTER = 0x1201,
        VG_RENDERING_QUALITY_BETTER = 0x1202  /* Default */
    };

    public enum VGPixelLayout
    {
        VG_PIXEL_LAYOUT_UNKNOWN = 0x1300,
        VG_PIXEL_LAYOUT_RGB_VERTICAL = 0x1301,
        VG_PIXEL_LAYOUT_BGR_VERTICAL = 0x1302,
        VG_PIXEL_LAYOUT_RGB_HORIZONTAL = 0x1303,
        VG_PIXEL_LAYOUT_BGR_HORIZONTAL = 0x1304
    };

    public enum VGMatrixMode
    {
        VG_MATRIX_PATH_USER_TO_SURFACE = 0x1400,
        VG_MATRIX_IMAGE_USER_TO_SURFACE = 0x1401,
        VG_MATRIX_FILL_PAINT_TO_USER = 0x1402,
        VG_MATRIX_STROKE_PAINT_TO_USER = 0x1403,
        VG_MATRIX_GLYPH_USER_TO_SURFACE = 0x1404
    };

    public enum VGMaskOperation
    {
        VG_CLEAR_MASK = 0x1500,
        VG_FILL_MASK = 0x1501,
        VG_SET_MASK = 0x1502,
        VG_UNION_MASK = 0x1503,
        VG_INTERSECT_MASK = 0x1504,
        VG_SUBTRACT_MASK = 0x1505
    };

    public enum VGPathDatatype
    {
        VG_PATH_DATATYPE_S_8 = 0,
        VG_PATH_DATATYPE_S_16 = 1,
        VG_PATH_DATATYPE_S_32 = 2,
        VG_PATH_DATATYPE_F = 3
    };

    public enum VGPathAbsRel
    {
        VG_ABSOLUTE = 0,
        VG_RELATIVE = 1
    };

    public enum VGPathSegment
    {
        VG_CLOSE_PATH = (0 << 1),
        VG_MOVE_TO = (1 << 1),
        VG_LINE_TO = (2 << 1),
        VG_HLINE_TO = (3 << 1),
        VG_VLINE_TO = (4 << 1),
        VG_QUAD_TO = (5 << 1),
        VG_CUBIC_TO = (6 << 1),
        VG_SQUAD_TO = (7 << 1),
        VG_SCUBIC_TO = (8 << 1),
        VG_SCCWARC_TO = (9 << 1),
        VG_SCWARC_TO = (10 << 1),
        VG_LCCWARC_TO = (11 << 1),
        VG_LCWARC_TO = (12 << 1)
    };

    public enum VGPathCommand
    {
        VG_MOVE_TO_ABS = VGPathSegment.VG_MOVE_TO | VGPathAbsRel.VG_ABSOLUTE,
        VG_MOVE_TO_REL = VGPathSegment.VG_MOVE_TO | VGPathAbsRel.VG_RELATIVE,
        VG_LINE_TO_ABS = VGPathSegment.VG_LINE_TO | VGPathAbsRel.VG_ABSOLUTE,
        VG_LINE_TO_REL = VGPathSegment.VG_LINE_TO | VGPathAbsRel.VG_RELATIVE,
        VG_HLINE_TO_ABS = VGPathSegment.VG_HLINE_TO | VGPathAbsRel.VG_ABSOLUTE,
        VG_HLINE_TO_REL = VGPathSegment.VG_HLINE_TO | VGPathAbsRel.VG_RELATIVE,
        VG_VLINE_TO_ABS = VGPathSegment.VG_VLINE_TO | VGPathAbsRel.VG_ABSOLUTE,
        VG_VLINE_TO_REL = VGPathSegment.VG_VLINE_TO | VGPathAbsRel.VG_RELATIVE,
        VG_QUAD_TO_ABS = VGPathSegment.VG_QUAD_TO | VGPathAbsRel.VG_ABSOLUTE,
        VG_QUAD_TO_REL = VGPathSegment.VG_QUAD_TO | VGPathAbsRel.VG_RELATIVE,
        VG_CUBIC_TO_ABS = VGPathSegment.VG_CUBIC_TO | VGPathAbsRel.VG_ABSOLUTE,
        VG_CUBIC_TO_REL = VGPathSegment.VG_CUBIC_TO | VGPathAbsRel.VG_RELATIVE,
        VG_SQUAD_TO_ABS = VGPathSegment.VG_SQUAD_TO | VGPathAbsRel.VG_ABSOLUTE,
        VG_SQUAD_TO_REL = VGPathSegment.VG_SQUAD_TO | VGPathAbsRel.VG_RELATIVE,
        VG_SCUBIC_TO_ABS = VGPathSegment.VG_SCUBIC_TO | VGPathAbsRel.VG_ABSOLUTE,
        VG_SCUBIC_TO_REL = VGPathSegment.VG_SCUBIC_TO | VGPathAbsRel.VG_RELATIVE,
        VG_SCCWARC_TO_ABS = VGPathSegment.VG_SCCWARC_TO | VGPathAbsRel.VG_ABSOLUTE,
        VG_SCCWARC_TO_REL = VGPathSegment.VG_SCCWARC_TO | VGPathAbsRel.VG_RELATIVE,
        VG_SCWARC_TO_ABS = VGPathSegment.VG_SCWARC_TO | VGPathAbsRel.VG_ABSOLUTE,
        VG_SCWARC_TO_REL = VGPathSegment.VG_SCWARC_TO | VGPathAbsRel.VG_RELATIVE,
        VG_LCCWARC_TO_ABS = VGPathSegment.VG_LCCWARC_TO | VGPathAbsRel.VG_ABSOLUTE,
        VG_LCCWARC_TO_REL = VGPathSegment.VG_LCCWARC_TO | VGPathAbsRel.VG_RELATIVE,
        VG_LCWARC_TO_ABS = VGPathSegment.VG_LCWARC_TO | VGPathAbsRel.VG_ABSOLUTE,
        VG_LCWARC_TO_REL = VGPathSegment.VG_LCWARC_TO | VGPathAbsRel.VG_RELATIVE
    };

    public enum VGPathCapabilities
    {
        VG_PATH_CAPABILITY_APPEND_FROM = (1 << 0),
        VG_PATH_CAPABILITY_APPEND_TO = (1 << 1),
        VG_PATH_CAPABILITY_MODIFY = (1 << 2),
        VG_PATH_CAPABILITY_TRANSFORM_FROM = (1 << 3),
        VG_PATH_CAPABILITY_TRANSFORM_TO = (1 << 4),
        VG_PATH_CAPABILITY_INTERPOLATE_FROM = (1 << 5),
        VG_PATH_CAPABILITY_INTERPOLATE_TO = (1 << 6),
        VG_PATH_CAPABILITY_PATH_LENGTH = (1 << 7),
        VG_PATH_CAPABILITY_POINT_ALONG_PATH = (1 << 8),
        VG_PATH_CAPABILITY_TANGENT_ALONG_PATH = (1 << 9),
        VG_PATH_CAPABILITY_PATH_BOUNDS = (1 << 10),
        VG_PATH_CAPABILITY_PATH_TRANSFORMED_BOUNDS = (1 << 11),
        VG_PATH_CAPABILITY_ALL = (1 << 12) - 1
    };

    public enum VGPathParamType
    {
        VG_PATH_FORMAT = 0x1600,
        VG_PATH_DATATYPE = 0x1601,
        VG_PATH_SCALE = 0x1602,
        VG_PATH_BIAS = 0x1603,
        VG_PATH_NUM_SEGMENTS = 0x1604,
        VG_PATH_NUM_COORDS = 0x1605
    };

    public enum VGCapStyle
    {
        VG_CAP_BUTT = 0x1700,
        VG_CAP_ROUND = 0x1701,
        VG_CAP_SQUARE = 0x1702
    };

    public enum VGJoinStyle
    {
        VG_JOIN_MITER = 0x1800,
        VG_JOIN_ROUND = 0x1801,
        VG_JOIN_BEVEL = 0x1802
    };

    public enum VGFillRule
    {
        VG_EVEN_ODD = 0x1900,
        VG_NON_ZERO = 0x1901
    };

    [Flags]
    public enum VGPaintMode
    {
        VG_STROKE_PATH = (1 << 0),
        VG_FILL_PATH = (1 << 1)
    };

    public enum VGPaintParamType
    {
        /* Color paint parameters */
        VG_PAINT_TYPE = 0x1A00,
        VG_PAINT_COLOR = 0x1A01,
        VG_PAINT_COLOR_RAMP_SPREAD_MODE = 0x1A02,
        VG_PAINT_COLOR_RAMP_PREMULTIPLIED = 0x1A07,
        VG_PAINT_COLOR_RAMP_STOPS = 0x1A03,

        /* Linear gradient paint parameters */
        VG_PAINT_LINEAR_GRADIENT = 0x1A04,

        /* Radial gradient paint parameters */
        VG_PAINT_RADIAL_GRADIENT = 0x1A05,

        /* Pattern paint parameters */
        VG_PAINT_PATTERN_TILING_MODE = 0x1A06
    };

    public enum VGPaintType
    {
        VG_PAINT_TYPE_COLOR = 0x1B00,
        VG_PAINT_TYPE_LINEAR_GRADIENT = 0x1B01,
        VG_PAINT_TYPE_RADIAL_GRADIENT = 0x1B02,
        VG_PAINT_TYPE_PATTERN = 0x1B03
    };

    public enum VGColorRampSpreadMode
    {
        VG_COLOR_RAMP_SPREAD_PAD = 0x1C00,
        VG_COLOR_RAMP_SPREAD_REPEAT = 0x1C01,
        VG_COLOR_RAMP_SPREAD_REFLECT = 0x1C02
    };

    public enum VGTilingMode
    {
        VG_TILE_FILL = 0x1D00,
        VG_TILE_PAD = 0x1D01,
        VG_TILE_REPEAT = 0x1D02,
        VG_TILE_REFLECT = 0x1D03
    };

    public enum VGImageFormat
    {
        /* RGB{A,X} channel ordering */
        VG_sRGBX_8888 = 0,
        VG_sRGBA_8888 = 1,
        VG_sRGBA_8888_PRE = 2,
        VG_sRGB_565 = 3,
        VG_sRGBA_5551 = 4,
        VG_sRGBA_4444 = 5,
        VG_sL_8 = 6,
        VG_lRGBX_8888 = 7,
        VG_lRGBA_8888 = 8,
        VG_lRGBA_8888_PRE = 9,
        VG_lL_8 = 10,
        VG_A_8 = 11,
        VG_BW_1 = 12,

        /* {A,X}RGB channel ordering */
        VG_sXRGB_8888 = 0 | (1 << 6),
        VG_sARGB_8888 = 1 | (1 << 6),
        VG_sARGB_8888_PRE = 2 | (1 << 6),
        VG_sARGB_1555 = 4 | (1 << 6),
        VG_sARGB_4444 = 5 | (1 << 6),
        VG_lXRGB_8888 = 7 | (1 << 6),
        VG_lARGB_8888 = 8 | (1 << 6),
        VG_lARGB_8888_PRE = 9 | (1 << 6),

        /* BGR{A,X} channel ordering */
        VG_sBGRX_8888 = 0 | (1 << 7),
        VG_sBGRA_8888 = 1 | (1 << 7),
        VG_sBGRA_8888_PRE = 2 | (1 << 7),
        VG_sBGR_565 = 3 | (1 << 7),
        VG_sBGRA_5551 = 4 | (1 << 7),
        VG_sBGRA_4444 = 5 | (1 << 7),
        VG_lBGRX_8888 = 7 | (1 << 7),
        VG_lBGRA_8888 = 8 | (1 << 7),
        VG_lBGRA_8888_PRE = 9 | (1 << 7),

        /* {A,X}BGR channel ordering */
        VG_sXBGR_8888 = 0 | (1 << 6) | (1 << 7),
        VG_sABGR_8888 = 1 | (1 << 6) | (1 << 7),
        VG_sABGR_8888_PRE = 2 | (1 << 6) | (1 << 7),
        VG_sABGR_1555 = 4 | (1 << 6) | (1 << 7),
        VG_sABGR_4444 = 5 | (1 << 6) | (1 << 7),
        VG_lXBGR_8888 = 7 | (1 << 6) | (1 << 7),
        VG_lABGR_8888 = 8 | (1 << 6) | (1 << 7),
        VG_lABGR_8888_PRE = 9 | (1 << 6) | (1 << 7)
    };


    public enum VGImageQuality
    {
        VG_IMAGE_QUALITY_NONANTIALIASED = (1 << 0),
        VG_IMAGE_QUALITY_FASTER = (1 << 1),
        VG_IMAGE_QUALITY_BETTER = (1 << 2)
    };

    public enum VGImageParamType
    {
        VG_IMAGE_FORMAT = 0x1E00,
        VG_IMAGE_WIDTH = 0x1E01,
        VG_IMAGE_HEIGHT = 0x1E02
    };

    public enum VGImageMode
    {
        VG_DRAW_IMAGE_NORMAL = 0x1F00,
        VG_DRAW_IMAGE_MULTIPLY = 0x1F01,
        VG_DRAW_IMAGE_STENCIL = 0x1F02
    };

    public enum VGImageChannel
    {
        VG_RED = (1 << 3),
        VG_GREEN = (1 << 2),
        VG_BLUE = (1 << 1),
        VG_ALPHA = (1 << 0)
    };

    public enum VGBlendMode
    {
        VG_BLEND_SRC = 0x2000,
        VG_BLEND_SRC_OVER = 0x2001,
        VG_BLEND_DST_OVER = 0x2002,
        VG_BLEND_SRC_IN = 0x2003,
        VG_BLEND_DST_IN = 0x2004,
        VG_BLEND_MULTIPLY = 0x2005,
        VG_BLEND_SCREEN = 0x2006,
        VG_BLEND_DARKEN = 0x2007,
        VG_BLEND_LIGHTEN = 0x2008,
        VG_BLEND_ADDITIVE = 0x2009,
        VG_BLEND_SRC_OUT_SH = 0x200A,
        VG_BLEND_DST_OUT_SH = 0x200B,
        VG_BLEND_SRC_ATOP_SH = 0x200C,
        VG_BLEND_DST_ATOP_SH = 0x200D
    };

    public enum VGHardwareQueryType
    {
        VG_IMAGE_FORMAT_QUERY = 0x2100,
        VG_PATH_DATATYPE_QUERY = 0x2101
    };

    public enum VGHardwareQueryResult
    {
        VG_HARDWARE_ACCELERATED = 0x2200,
        VG_HARDWARE_UNACCELERATED = 0x2201
    };

    public enum VGStringID
    {
        VG_VENDOR = 0x2300,
        VG_RENDERER = 0x2301,
        VG_VERSION = 0x2302,
        VG_EXTENSIONS = 0x2303
    };


    public enum VGFontParamType
    {
        VG_FONT_NUM_GLYPHS = 0x2F00
    };

    public class VG
    {
        [DllImport("libOpenVG.dll")]
        public static extern VGErrorCode vgGetError();

        [DllImport("libOpenVG.dll")]
        public static extern void vgFlush();
        [DllImport("libOpenVG.dll")]
        public static extern void vgFinish();

        /* Getters and Setters */
        [DllImport("libOpenVG.dll")]
        public static extern void vgSetf(VGParamType type, float value);
        [DllImport("libOpenVG.dll")]
        public static extern void vgSeti(VGParamType type, int value);
        [DllImport("libOpenVG.dll")]
        public static extern void vgSetfv(VGParamType type, int count,
                                           float[] values);
        [DllImport("libOpenVG.dll")]
        public static extern void vgSetiv(VGParamType type, int count,
                                           int[] values);
        [DllImport("libOpenVG.dll")]
        public static extern float vgGetf(VGParamType type);
        [DllImport("libOpenVG.dll")]
        public static extern int vgGeti(VGParamType type);
        [DllImport("libOpenVG.dll")]
        public static extern int vgGetVectorSize(VGParamType type);
        [DllImport("libOpenVG.dll")]
        public static extern void vgGetfv(VGParamType type, int count, float[] values);
        [DllImport("libOpenVG.dll")]
        public static extern void vgGetiv(VGParamType type, int count, int[] values);
        [DllImport("libOpenVG.dll")]
        public static extern void vgSetParameterf(IntPtr obj,
                                                    int paramType,
                                                    float value);
        [DllImport("libOpenVG.dll")]
        public static extern void vgSetParameteri(IntPtr obj,
                                                    int paramType,
                                                    int value);
        [DllImport("libOpenVG.dll")]
        public static extern void vgSetParameterfv(IntPtr obj,
                                                    int paramType,
                                                    int count, float[] values);
        [DllImport("libOpenVG.dll")]
        public static extern void vgSetParameteriv(IntPtr obj,
                                                    int paramType,
                                                    int count, int[] values);

        [DllImport("libOpenVG.dll")]
        public static extern float vgGetParameterf(IntPtr obj,
                                                    int paramType);
        [DllImport("libOpenVG.dll")]
        public static extern int vgGetParameteri(IntPtr obj,
                                                    int paramType);
        [DllImport("libOpenVG.dll")]
        public static extern int vgGetParameterVectorSize(IntPtr obj,
                                                            int paramType);
        [DllImport("libOpenVG.dll")]
        public static extern void vgGetParameterfv(IntPtr obj,
                                                    int paramType,
                                                    int count, ref float[] values);
        [DllImport("libOpenVG.dll")]
        public static extern void vgGetParameteriv(IntPtr obj,
                                                      int paramType,
                                                      int count, ref int[] values);


        /* Matrix Manipulation */
        [DllImport("libOpenVG.dll")]
        public static extern void vgLoadIdentity();
        [DllImport("libOpenVG.dll")]
        public static extern void vgLoadMatrix(float[] m);
        [DllImport("libOpenVG.dll")]
        public static extern void vgGetMatrix(ref float[] m);
        [DllImport("libOpenVG.dll")]
        public static extern void vgMultMatrix(float[] m);
        [DllImport("libOpenVG.dll")]
        public static extern void vgTranslate(float tx, float ty);
        [DllImport("libOpenVG.dll")]
        public static extern void vgScale(float sx, float sy);
        [DllImport("libOpenVG.dll")]
        public static extern void vgShear(float shx, float shy);
        [DllImport("libOpenVG.dll")]
        public static extern void vgRotate(float angle);

        /* Masking and Clearing */
        [DllImport("libOpenVG.dll")]
        public static extern void vgMask(IntPtr mask, VGMaskOperation operation,
                                            int x, int y, int width, int height);
        [DllImport("libOpenVG.dll")]
        public static extern void vgRenderToMask(IntPtr path, VGPaintMode paintModes, VGMaskOperation operation);

        [DllImport("libOpenVG.dll")]
        public static extern IntPtr vgCreateMaskLayer(int width, int height);

        [DllImport("libOpenVG.dll")]
        public static extern void vgDestroyMaskLayer(IntPtr maskLayer);

        [DllImport("libOpenVG.dll")]
        public static extern void vgFillMaskLayer(IntPtr maskLayer, int x, int y, int width, int height, float value);

        [DllImport("libOpenVG.dll")]
        public static extern void vgCopyMask(IntPtr maskLayer, int dx, int dy, int sx, int sy, int width, int height);

        [DllImport("libOpenVG.dll")]
        public static extern void vgClear(int x, int y, int width, int height);

        /* Paths */
        [DllImport("libOpenVG.dll")]
        public static extern IntPtr vgCreatePath(int pathFormat,
                                                    VGPathDatatype datatype,
                                                    float scale, float bias,
                                                    int segmentCapacityHint,
                                                    int coordCapacityHint,
                                                    VGPathCapabilities capabilities);
        [DllImport("libOpenVG.dll")]
        public static extern void vgClearPath(IntPtr path, VGPathCapabilities capabilities);
        [DllImport("libOpenVG.dll")]
        public static extern void vgDestroyPath(IntPtr path);
        [DllImport("libOpenVG.dll")]
        public static extern void vgRemovePathCapabilities(IntPtr path,
                                                            VGPathCapabilities capabilities);
        [DllImport("libOpenVG.dll")]
        public static extern uint vgGetPathCapabilities(IntPtr path);
        [DllImport("libOpenVG.dll")]
        public static extern void vgAppendPath(IntPtr dstPath, IntPtr srcPath);
        [DllImport("libOpenVG.dll")]
        public static extern void vgAppendPathData(IntPtr dstPath,
                                                    int numSegments,
                                                    byte[] pathSegments,
                                                    float[] pathData);
        [DllImport("libOpenVG.dll")]
        public static extern void vgModifyPathCoords(IntPtr dstPath, int startIndex,
                                                        int numSegments,
                                                        IntPtr pathData);
        [DllImport("libOpenVG.dll")]
        public static extern void vgTransformPath(IntPtr dstPath, IntPtr srcPath);
        [DllImport("libOpenVG.dll")]
        public static extern VGboolean vgInterpolatePath(IntPtr dstPath,
                                                            IntPtr startPath,
                                                            IntPtr endPath,
                                                            float amount);
        [DllImport("libOpenVG.dll")]
        public static extern float vgPathLength(IntPtr path,
                                                    int startSegment, int numSegments);
        [DllImport("libOpenVG.dll")]
        public static extern void vgPointAlongPath(IntPtr path,
                                                    int startSegment, int numSegments,
                                                    float distance,
                                                    ref float[] x, ref float[] y,
                                                    ref float[] tangentX, ref float[] tangentY);
        [DllImport("libOpenVG.dll")]
        public static extern void vgPathBounds(IntPtr path,
                                        out float minX, out float minY,
                                        out float width, out float height);

        [DllImport("libOpenVG.dll")]
        public static extern void vgPathTransformedBounds(IntPtr path,
                                                 out float minX, out float minY,
                                                 out float width, out float height);
        [DllImport("libOpenVG.dll")]
        public static extern void vgDrawPath(IntPtr path, VGPaintMode paintModes);

        /* Paint */
        [DllImport("libOpenVG.dll")]
        public static extern IntPtr vgCreatePaint();
        [DllImport("libOpenVG.dll")]
        public static extern void vgDestroyPaint(IntPtr paint);
        [DllImport("libOpenVG.dll")]
        public static extern void vgSetPaint(IntPtr paint, VGPaintMode paintModes);
        [DllImport("libOpenVG.dll")]
        public static extern IntPtr vgGetPaint(VGPaintMode paintMode);
        [DllImport("libOpenVG.dll")]
        public static extern void vgSetColor(IntPtr paint, uint rgba);
        [DllImport("libOpenVG.dll")]
        public static extern uint vgGetColor(IntPtr paint);
        [DllImport("libOpenVG.dll")]
        public static extern void vgPaintPattern(IntPtr paint, IntPtr pattern);


        /* Images */
        [DllImport("libOpenVG.dll")]
        public static extern IntPtr vgCreateImage(VGImageFormat format,
                                                    int width, int height,
                                                    VGImageQuality allowedQuality);
        [DllImport("libOpenVG.dll")]
        public static extern void vgDestroyImage(IntPtr image);
        [DllImport("libOpenVG.dll")]
        public static extern void vgClearImage(IntPtr image,
                                                int x, int y, int width, int height);
        [DllImport("libOpenVG.dll")]
        public static extern void vgImageSubData(IntPtr image,
                                                    IntPtr data, int dataStride,
                                                    VGImageFormat dataFormat,
                                                    int x, int y, int width, int height);
        [DllImport("libOpenVG.dll")]
        public static extern void vgGetImageSubData(IntPtr image,
                                                        IntPtr data, int dataStride,
                                                        VGImageFormat dataFormat,
                                                        int x, int y,
                                                        int width, int height);
        [DllImport("libOpenVG.dll")]
        public static extern IntPtr vgChildImage(IntPtr parent,
                                                    int x, int y, int width, int height);
        [DllImport("libOpenVG.dll")]
        public static extern IntPtr vgGetParent(IntPtr image);
        [DllImport("libOpenVG.dll")]
        public static extern void vgCopyImage(IntPtr dst, int dx, int dy,
                                                IntPtr src, int sx, int sy,
                                                int width, int height,
                                                VGboolean dither);
        [DllImport("libOpenVG.dll")]
        public static extern void vgDrawImage(IntPtr image);
        [DllImport("libOpenVG.dll")]
        public static extern void vgSetPixels(int dx, int dy,
                                                IntPtr src, int sx, int sy,
                                                int width, int height);
        [DllImport("libOpenVG.dll")]
        public static extern void vgWritePixels(IntPtr data, int dataStride,
                                                    VGImageFormat dataFormat,
                                                    int dx, int dy,
                                                    int width, int height);
        [DllImport("libOpenVG.dll")]
        public static extern void vgGetPixels(IntPtr dst, int dx, int dy,
                                                int sx, int sy,
                                                int width, int height);
        [DllImport("libOpenVG.dll")]
        public static extern void vgReadPixels(IntPtr data, int dataStride,
                                                VGImageFormat dataFormat,
                                                int sx, int sy,
                                                int width, int height);
        [DllImport("libOpenVG.dll")]
        public static extern void vgCopyPixels(int dx, int dy,
                                                int sx, int sy,
                                                int width, int height);


        #region vgFont
        /* Text */
        [DllImport("libOpenVG.dll")]
        public static extern IntPtr vgCreateFont(int glyphCapacityHint);
        [DllImport("libOpenVG.dll")]
        public static extern void vgDestroyFont(IntPtr font);
        [DllImport("libOpenVG.dll")]
        public static extern void vgSetGlyphToPath(IntPtr font, uint glyphIndex, IntPtr path, VGboolean isHinted, float[] glyphOrigin, float[] escapement);
        [DllImport("libOpenVG.dll")]
        public static extern void vgSetGlyphToImage(IntPtr font, uint glyphIndex, IntPtr image, float[] glyphOrigin, float[] escapement);
        [DllImport("libOpenVG.dll")]
        public static extern void vgClearGlyph(IntPtr font, uint glyphIndex);
        [DllImport("libOpenVG.dll")]
        public static extern void vgDrawGlyph(IntPtr font, uint glyphIndex, VGPaintMode paintModes, VGboolean allowAutoHinting);
        [DllImport("libOpenVG.dll")]
        public static extern void vgDrawGlyphs(IntPtr font, int glyphCount, uint[] glyphIndices, float[] adjustments_x, float[] adjustments_y, VGPaintMode paintModes, VGboolean allowAutoHinting);
        #endregion


        /* Image Filters */
        [DllImport("libOpenVG.dll")]
        public static extern void vgColorMatrix(IntPtr dst, IntPtr src,
                                                    float[] matrix);
        [DllImport("libOpenVG.dll")]
        public static extern void vgConvolve(IntPtr dst, IntPtr src,
                                                int kernelWidth, int kernelHeight,
                                                int shiftX, int shiftY,
                                                short[] kernel,
                                                float scale,
                                                float bias,
                                                VGTilingMode tilingMode);
        [DllImport("libOpenVG.dll")]
        public static extern void vgSeparableConvolve(IntPtr dst, IntPtr src,
                                                        int kernelWidth,
                                                        int kernelHeight,
                                                        int shiftX, int shiftY,
                                                        short[] kernelX,
                                                        short[] kernelY,
                                                        float scale,
                                                        float bias,
                                                        VGTilingMode tilingMode);
        [DllImport("libOpenVG.dll")]
        public static extern void vgGaussianBlur(IntPtr dst, IntPtr src,
                                                    float stdDeviationX,
                                                    float stdDeviationY,
                                                    VGTilingMode tilingMode);
        [DllImport("libOpenVG.dll")]
        public static extern void vgLookup(IntPtr dst, IntPtr src,
                                            byte[] redLUT,
                                            byte[] greenLUT,
                                            byte[] blueLUT,
                                            byte[] alphaLUT,
                                            VGboolean outputLinear,
                                            VGboolean outputPremultiplied);
        [DllImport("libOpenVG.dll")]
        public static extern void vgLookupSingle(IntPtr dst, IntPtr src,
                                                    uint[] lookupTable,
                                                    VGImageChannel sourceChannel,
                                                    VGboolean outputLinear,
                                                    VGboolean outputPremultiplied);


        /* Hardware Queries */
        [DllImport("libOpenVG.dll")]
        public static extern VGHardwareQueryResult vgHardwareQuery(VGHardwareQueryType key,
                                                                    int setting);

        /* Renderer and Extension Information */
        [DllImport("libOpenVG.dll")]
        public static extern byte[] vgGetString(VGStringID name);
    }

    public class VGU
    {
        [DllImport("libOpenVG.dll")]
        public static extern VGUErrorCode vguLine(IntPtr path,
                                                    float x0, float y0,
                                                    float x1, float y1);

        [DllImport("libOpenVG.dll")]
        public static extern VGUErrorCode vguPolygon(IntPtr path,
                                                        float[] points, int count,
                                                        VGboolean closed);

        [DllImport("libOpenVG.dll")]
        public static extern VGUErrorCode vguRect(IntPtr path,
                                                    float x, float y,
                                                    float width, float height);

        [DllImport("libOpenVG.dll")]
        public static extern VGUErrorCode vguRoundRect(IntPtr path,
                                                        float x, float y,
                                                        float width, float height,
                                                        float arcWidth, float arcHeight);

        [DllImport("libOpenVG.dll")]
        public static extern VGUErrorCode vguEllipse(IntPtr path,
                                                        float cx, float cy,
                                                        float width, float height);

        [DllImport("libOpenVG.dll")]
        public static extern VGUErrorCode vguArc(IntPtr path,
                                                    float x, float y,
                                                    float width, float height,
                                                    float startAngle, float angleExtent,
                                                    VGUArcType arcType);
        [DllImport("libOpenVG.dll")]
        public static extern VGUErrorCode vguComputeWarpQuadToSquare(float sx0, float sy0,
                                                                        float sx1, float sy1,
                                                                        float sx2, float sy2,
                                                                        float sx3, float sy3,
                                                                        ref float[] matrix);
        [DllImport("libOpenVG.dll")]
        public static extern VGUErrorCode vguComputeWarpSquareToQuad(float dx0, float dy0,
                                                                        float dx1, float dy1,
                                                                        float dx2, float dy2,
                                                                        float dx3, float dy3,
                                                                        ref float[] matrix);
        [DllImport("libOpenVG.dll")]
        public static extern VGUErrorCode vguComputeWarpQuadToQuad(float dx0, float dy0,
                                                                        float dx1, float dy1,
                                                                        float dx2, float dy2,
                                                                        float dx3, float dy3,
                                                                        float sx0, float sy0,
                                                                        float sx1, float sy1,
                                                                        float sx2, float sy2,
                                                                        float sx3, float sy3,
                                                                        ref float[] matrix);

    }

    public class VgContext
    {

        #region ShivaVG
        [DllImport("libOpenVG.dll")]
        public static extern VGboolean vgCreateContextSH(int width, int height);

        [DllImport("libOpenVG.dll")]
        public static extern void vgResizeSurfaceSH(int width, int height);

        [DllImport("libOpenVG.dll")]
        public static extern void vgDestroyContextSH();
        #endregion

        #region AmanithVG
        [DllImport("libOpenVG.dll")]
        public static extern VGboolean vgInitContextAM(int width, int height, VGboolean surfaceLinearColorSpace);

        [DllImport("libOpenVG.dll")]
        public static extern void vgDestroyContextAM();


        // Update the dimensions of the drawing surface, since the last call of vgInitContextAM or vgResizeSurfaceAM 
        [DllImport("libOpenVG.dll")]
        public static extern void vgResizeSurfaceAM(int surfaceWidth, int surfaceHeight);


        // Get the drawing surface width, in pixels 
        [DllImport("libOpenVG.dll")]
        public static extern int vgGetSurfaceWidthAM();


        // Get the drawing surface height, in pixels 
        [DllImport("libOpenVG.dll")]
        public static extern int vgGetSurfaceHeightAM();


        // Get the drawing surface format 
        [DllImport("libOpenVG.dll")]
        public static extern VGImageFormat vgGetSurfaceFormatAM();


        // Get the direct access to the drawing surface pixels (AmanithVG SRE). It must be used only to blit the surface on the screen,
        // according to the platform graphic subsystem. 
        [DllImport("libOpenVG.dll")]
        public static extern IntPtr vgGetSurfacePixelsAM();
        #endregion

        #region MiniEglWrapper

        [DllImport("libEglWrapper.so")]
        public static extern uint vgInit();
        //public static extern VGboolean vgInit();


        [DllImport("libEglWrapper.so")]
        public static extern void vgDestroy();


        [DllImport("libEglWrapper.so")]
        public static extern void vgSwapBuffers();

        #endregion
    }


    #region EglWrapper
    // Errors / GetError return values 
    public enum EGLError
    {
        EGL_SUCCESS = 0x3000,
        EGL_NOT_INITIALIZED = 0x3001,
        EGL_BAD_ACCESS = 0x3002,
        EGL_BAD_ALLOC = 0x3003,
        EGL_BAD_ATTRIBUTE = 0x3004,
        EGL_BAD_CONFIG = 0x3005,
        EGL_BAD_CONTEXT = 0x3006,
        EGL_BAD_CURRENT_SURFACE = 0x3007,
        EGL_BAD_DISPLAY = 0x3008,
        EGL_BAD_MATCH = 0x3009,
        EGL_BAD_NATIVE_PIXMAP = 0x300A,
        EGL_BAD_NATIVE_WINDOW = 0x300B,
        EGL_BAD_PARAMETER = 0x300C,
        EGL_BAD_SURFACE = 0x300D,
        EGL_CONTEXT_LOST = 0x300E // EGL 1.1 - IMG_power_management 

        // Reserved 0x300F-0x301F for additional errors 
    }

    /* Config attribute mask bits */
    public enum EGLSurfaceType
    {
        EGL_PBUFFER_BIT = 0x0001, /* EGL_SURFACE_TYPE mask bits */
        EGL_PIXMAP_BIT = 0x0002, /* EGL_SURFACE_TYPE mask bits */
        EGL_WINDOW_BIT = 0x0004, /* EGL_SURFACE_TYPE mask bits */
        EGL_VG_COLORSPACE_LINEAR_BIT = 0x0020, /* EGL_SURFACE_TYPE mask bits */
        EGL_VG_ALPHA_FORMAT_PRE_BIT = 0x0040, /* EGL_SURFACE_TYPE mask bits */
        EGL_MULTISAMPLE_RESOLVE_BOX_BIT = 0x0200, /* EGL_SURFACE_TYPE mask bits */
        EGL_SWAP_BEHAVIOR_PRESERVED_BIT = 0x0400 /* EGL_SURFACE_TYPE mask bits */
    }

    public enum EGLRenderableType
    {
        EGL_OPENGL_ES_BIT = 0x0001, /* EGL_RENDERABLE_TYPE mask bits */
        EGL_OPENVG_BIT = 0x0002, /* EGL_RENDERABLE_TYPE mask bits */
        EGL_OPENGL_ES2_BIT = 0x0004, /* EGL_RENDERABLE_TYPE mask bits */
        EGL_OPENGL_BIT = 0x0008 /* EGL_RENDERABLE_TYPE mask bits */
    }

    // Config attributes 
    public enum EGLConfig
    {
        EGL_BUFFER_SIZE = 0x3020,
        EGL_ALPHA_SIZE = 0x3021,
        EGL_BLUE_SIZE = 0x3022,
        EGL_GREEN_SIZE = 0x3023,
        EGL_RED_SIZE = 0x3024,
        EGL_DEPTH_SIZE = 0x3025,
        EGL_STENCIL_SIZE = 0x3026,
        EGL_CONFIG_CAVEAT = 0x3027,
        EGL_CONFIG_ID = 0x3028,
        EGL_LEVEL = 0x3029,
        EGL_MAX_PBUFFER_HEIGHT = 0x302A,
        EGL_MAX_PBUFFER_PIXELS = 0x302B,
        EGL_MAX_PBUFFER_WIDTH = 0x302C,
        EGL_NATIVE_RENDERABLE = 0x302D,
        EGL_NATIVE_VISUAL_ID = 0x302E,
        EGL_NATIVE_VISUAL_TYPE = 0x302F,
        EGL_SAMPLES = 0x3031,
        EGL_SAMPLE_BUFFERS = 0x3032,
        EGL_SURFACE_TYPE = 0x3033,
        EGL_TRANSPARENT_TYPE = 0x3034,
        EGL_TRANSPARENT_BLUE_VALUE = 0x3035,
        EGL_TRANSPARENT_GREEN_VALUE = 0x3036,
        EGL_TRANSPARENT_RED_VALUE = 0x3037,
        EGL_NONE = 0x3038,	// Attrib list terminator 
        EGL_BIND_TO_TEXTURE_RGB = 0x3039,
        EGL_BIND_TO_TEXTURE_RGBA = 0x303A,
        EGL_MIN_SWAP_INTERVAL = 0x303B,
        EGL_MAX_SWAP_INTERVAL = 0x303C,
        EGL_LUMINANCE_SIZE = 0x303D,
        EGL_ALPHA_MASK_SIZE = 0x303E,
        EGL_COLOR_BUFFER_TYPE = 0x303F,
        EGL_RENDERABLE_TYPE = 0x3040,
        EGL_MATCH_NATIVE_PIXMAP = 0x3041,	// Pseudo-attribute (not queryable) 
        EGL_CONFORMANT = 0x3042,

        /* Reserved 0x3041-0x304F for additional config attributes */

        /* Config attribute values */
        EGL_SLOW_CONFIG = 0x3050,	/* EGL_CONFIG_CAVEAT value */
        EGL_NON_CONFORMANT_CONFIG = 0x3051,	/* EGL_CONFIG_CAVEAT value */
        EGL_TRANSPARENT_RGB = 0x3052,	/* EGL_TRANSPARENT_TYPE value */
        EGL_RGB_BUFFER = 0x308E,	/* EGL_COLOR_BUFFER_TYPE value */
        EGL_LUMINANCE_BUFFER = 0x308F,	/* EGL_COLOR_BUFFER_TYPE value */

        /* More config attribute values, for EGL_TEXTURE_FORMAT */
        EGL_NO_TEXTURE = 0x305C,
        EGL_TEXTURE_RGB = 0x305D,
        EGL_TEXTURE_RGBA = 0x305E,
        EGL_TEXTURE_2D = 0x305F,

        /* QueryString targets */
        EGL_VENDOR = 0x3053,
        EGL_VERSION = 0x3054,
        EGL_EXTENSIONS = 0x3055,
        EGL_CLIENT_APIS = 0x308D,

        /* QuerySurface / SurfaceAttrib / CreatePbufferSurface targets */
        EGL_HEIGHT = 0x3056,
        EGL_WIDTH = 0x3057,
        EGL_LARGEST_PBUFFER = 0x3058,
        EGL_TEXTURE_FORMAT = 0x3080,
        EGL_TEXTURE_TARGET = 0x3081,
        EGL_MIPMAP_TEXTURE = 0x3082,
        EGL_MIPMAP_LEVEL = 0x3083,
        EGL_RENDER_BUFFER = 0x3086,
        EGL_VG_COLORSPACE = 0x3087,
        EGL_VG_ALPHA_FORMAT = 0x3088,
        EGL_HORIZONTAL_RESOLUTION = 0x3090,
        EGL_VERTICAL_RESOLUTION = 0x3091,
        EGL_PIXEL_ASPECT_RATIO = 0x3092,
        EGL_SWAP_BEHAVIOR = 0x3093,
        EGL_MULTISAMPLE_RESOLVE = 0x3099,

        /* EGL_RENDER_BUFFER values / BindTexImage / ReleaseTexImage buffer targets */
        EGL_BACK_BUFFER = 0x3084,
        EGL_SINGLE_BUFFER = 0x3085,

        /* OpenVG color spaces */
        EGL_VG_COLORSPACE_sRGB = 0x3089,	/* EGL_VG_COLORSPACE value */
        EGL_VG_COLORSPACE_LINEAR = 0x308A,	/* EGL_VG_COLORSPACE value */

        /* OpenVG alpha formats */
        EGL_VG_ALPHA_FORMAT_NONPRE = 0x308B,	/* EGL_ALPHA_FORMAT value */
        EGL_VG_ALPHA_FORMAT_PRE = 0x308C,	/* EGL_ALPHA_FORMAT value */

        /* Constant scale factor by which fractional display resolutions &
         * aspect ratio are scaled when queried as integer values.
         */
        EGL_DISPLAY_SCALING = 10000,

        /* Unknown display resolution/aspect ratio */
        EGL_UNKNOWN = int.MaxValue - 1,// ((EGLint)-1),

        /* Back buffer swap behaviors */
        EGL_BUFFER_PRESERVED = 0x3094,	/* EGL_SWAP_BEHAVIOR value */
        EGL_BUFFER_DESTROYED = 0x3095,	/* EGL_SWAP_BEHAVIOR value */

        /* CreatePbufferFromClientBuffer buffer types */
        EGL_OPENVG_IMAGE = 0x3096,

        /* QueryContext targets */
        EGL_CONTEXT_CLIENT_TYPE = 0x3097,

        /* CreateContext attributes */
        EGL_CONTEXT_CLIENT_VERSION = 0x3098,

        /* Multisample resolution behaviors */
        EGL_MULTISAMPLE_RESOLVE_DEFAULT = 0x309A,	/* EGL_MULTISAMPLE_RESOLVE value */
        EGL_MULTISAMPLE_RESOLVE_BOX = 0x309B,	/* EGL_MULTISAMPLE_RESOLVE value */

        /* BindAPI/QueryAPI targets */
        EGL_OPENGL_ES_API = 0x30A0,
        EGL_OPENVG_API = 0x30A1,
        EGL_OPENGL_API = 0x30A2,

        /* GetCurrentSurface targets */
        EGL_DRAW = 0x3059,
        EGL_READ = 0x305A,

        /* WaitNative engines */
        EGL_CORE_NATIVE_ENGINE = 0x305B,

        /* EGL 1.2 tokens renamed for consistency in EGL 1.3 */
        EGL_COLORSPACE = EGL_VG_COLORSPACE,
        EGL_ALPHA_FORMAT = EGL_VG_ALPHA_FORMAT,
        EGL_COLORSPACE_sRGB = EGL_VG_COLORSPACE_sRGB,
        EGL_COLORSPACE_LINEAR = EGL_VG_COLORSPACE_LINEAR,
        EGL_ALPHA_FORMAT_NONPRE = EGL_VG_ALPHA_FORMAT_NONPRE,
        EGL_ALPHA_FORMAT_PRE = EGL_VG_ALPHA_FORMAT_PRE
    }

    public enum EGLboolean
    {
        EGL_FALSE = 0,
        EGL_TRUE = 1
    };

    static public class EGLAliases
    {
        public static IntPtr EGL_DEFAULT_DISPLAY = IntPtr.Zero;
        public static IntPtr EGL_NO_CONTEXT = IntPtr.Zero;
        public static IntPtr EGL_NO_DISPLAY = IntPtr.Zero;
        public static IntPtr EGL_NO_SURFACE = IntPtr.Zero;
    };

    public class EGLContext
    {
        /*
        typedef unsigned int EGLBoolean;
        typedef unsigned int EGLenum;
        typedef void *EGLConfig;
        typedef void *EGLContext;
        typedef void *EGLDisplay;
        typedef void *EGLSurface;
        typedef void *EGLClientBuffer;
         
        [DllImport("libOpenVG.dll")]
        public static extern IntPtr vgGetParent(IntPtr image);
         */


        /* EGL Functions */
        [DllImport("libEGL.dll")]
        public static extern IntPtr fbGetDisplayByIndex(int displayIndex);

        [DllImport("libEGL.dll")]
        public static extern IntPtr fbCreateWindow(IntPtr eglNativeDisplayType, int x, int y, int width, int height);

        /*
        EGLNativeDisplayType fsl_getNativeDisplay();
        EGLNativeWindowType fsl_createwindow(EGLDisplay egldisplay, EGLNativeDisplayType eglNativeDisplayType);
        void fsl_destroywindow(EGLNativeWindowType eglNativeWindowType,EGLNativeDisplayType eglNativeDisplayType);
        */

        [DllImport("libEGL.dll")]
        public static extern EGLError eglGetError();

        [DllImport("libEGL.dll")]
        public static extern IntPtr eglGetDisplay(IntPtr display_id);

        [DllImport("libEGL.dll")]
        public static extern bool eglInitialize(IntPtr dpy, out int major, out int minor);

        [DllImport("libEGL.dll")]
        public static extern bool eglTerminate(IntPtr dpy);

        [DllImport("libEGL.dll")]
        public static extern byte[] eglQueryString(IntPtr dpy, int name);

        [DllImport("libEGL.dll")]
        public static extern bool eglGetConfigs(IntPtr dpy, IntPtr configs, int config_size, int num_config);

        [DllImport("libEGL.dll")]
        public static extern bool eglChooseConfig(IntPtr dpy, int[] attrib_list, out IntPtr configs, int config_size, out int num_config);

        [DllImport("libEGL.dll")]
        //public static extern bool eglGetConfigAttrib(IntPtr dpy, EGLConfig config, int attribute, IntPtr value);
        public static extern bool eglGetConfigAttrib(IntPtr dpy, IntPtr config, int attribute, out int value);

        [DllImport("libEGL.dll")]
        public static extern IntPtr eglCreateWindowSurface(IntPtr dpy, IntPtr config, IntPtr win, int[] attrib_list);

        [DllImport("libEGL.dll")]
        public static extern IntPtr eglCreatePbufferSurface(IntPtr dpy, EGLConfig config, int[] attrib_list);

        [DllImport("libEGL.dll")]
        public static extern IntPtr eglCreatePixmapSurface(IntPtr dpy, EGLConfig config, IntPtr pixmap, int[] attrib_list);

        [DllImport("libEGL.dll")]
        public static extern bool eglDestroySurface(IntPtr dpy, IntPtr surface);

        [DllImport("libEGL.dll")]
        public static extern bool eglQuerySurface(IntPtr dpy, IntPtr surface, int attribute, IntPtr value);

        [DllImport("libEGL.dll")]
        public static extern bool eglBindAPI(EGLConfig api);

        [DllImport("libEGL.dll")]
        public static extern int eglQueryAPI();

        [DllImport("libEGL.dll")]
        public static extern bool eglWaitClient();

        [DllImport("libEGL.dll")]
        public static extern bool eglReleaseThread();

        [DllImport("libEGL.dll")]
        public static extern IntPtr eglCreatePbufferFromClientBuffer(IntPtr dpy, int buftype, IntPtr buffer, IntPtr config, IntPtr attrib_list);

        [DllImport("libEGL.dll")]
        public static extern bool eglSurfaceAttrib(IntPtr dpy, IntPtr surface, int attribute, int value);

        [DllImport("libEGL.dll")]
        public static extern bool eglBindTexImage(IntPtr dpy, IntPtr surface, int buffer);

        [DllImport("libEGL.dll")]
        public static extern bool eglReleaseTexImage(IntPtr dpy, IntPtr surface, int buffer);

        [DllImport("libEGL.dll")]
        public static extern bool eglSwapInterval(IntPtr dpy, int interval);

        [DllImport("libEGL.dll")]
        public static extern IntPtr eglCreateContext(IntPtr dpy, IntPtr config, IntPtr share_context, IntPtr attrib_list);

        [DllImport("libEGL.dll")]
        public static extern bool eglDestroyContext(IntPtr dpy, IntPtr ctx);

        [DllImport("libEGL.dll")]
        public static extern bool eglMakeCurrent(IntPtr dpy, IntPtr draw, IntPtr read, IntPtr ctx);

        [DllImport("libEGL.dll")]
        public static extern IntPtr eglGetCurrentContext();

        [DllImport("libEGL.dll")]
        public static extern IntPtr eglGetCurrentSurface(int readdraw);

        [DllImport("libEGL.dll")]
        public static extern IntPtr eglGetCurrentDisplay();

        [DllImport("libEGL.dll")]
        public static extern bool eglQueryContext(IntPtr dpy, IntPtr ctx, int attribute, IntPtr value);

        [DllImport("libEGL.dll")]
        public static extern bool eglWaitGL();

        [DllImport("libEGL.dll")]
        public static extern bool eglWaitNative(int engine);

        [DllImport("libEGL.dll")]
        public static extern bool eglSwapBuffers(IntPtr dpy, IntPtr surface);

        [DllImport("libEGL.dll")]
        public static extern bool eglCopyBuffers(IntPtr dpy, IntPtr surface, IntPtr target);

        /* Now, define eglGetProcAddress using the generic function ptr. type */
        [DllImport("libEGL.dll")]
        public static extern IntPtr eglGetProcAddress(string procname);


        #region vg_wrapper
        private static IntPtr mEglDisplay;
        private static IntPtr mEglConfigWindow;
        private static IntPtr mEglWindowSurface;
        private static IntPtr mEglContext;

        /// <summary>
        /// Инициализация EGL
        /// </summary>
        /// <param name="hwnd">EGLNativeWindowType</param>
        /// <param name="dpy">EGLNativeDisplayType</param>
        /// <returns></returns>
        static private bool Init(IntPtr hwnd, IntPtr dpy)
        {
            int majorVersion, minorVersion, numConfig;


            var attribListWindow = new[]
            {
		        (int)EGLConfig.EGL_SURFACE_TYPE, (int)EGLSurfaceType.EGL_WINDOW_BIT,
		        //(int)EGLConfig.EGL_RED_SIZE, 5,
                //(int)EGLConfig.EGL_GREEN_SIZE, 6,
		        //(int)EGLConfig.EGL_BLUE_SIZE, 5,
                (int)EGLConfig.EGL_RED_SIZE, 8,
		        (int)EGLConfig.EGL_GREEN_SIZE, 8,
		        (int)EGLConfig.EGL_BLUE_SIZE, 8,
		        (int)EGLConfig.EGL_ALPHA_MASK_SIZE, 0,
		        (int)EGLConfig.EGL_RENDERABLE_TYPE, (int)EGLRenderableType.EGL_OPENVG_BIT,
		        (int)EGLConfig.EGL_NONE
	        };

            var surfAttribs = new[]
            {
		        (int)EGLConfig.EGL_COLORSPACE, (int)EGLConfig.EGL_COLORSPACE_sRGB,
		        (int)EGLConfig.EGL_ALPHA_FORMAT, (int)EGLConfig.EGL_ALPHA_FORMAT_PRE,
		        (int)EGLConfig.EGL_NONE
	        };


            // get the display
            mEglDisplay = eglGetDisplay(dpy);
            if (mEglDisplay == IntPtr.Zero)
            {
                Console.WriteLine("EGL error: eglGetDisplay failed.");
                return false;
            }

            // initialize EGL
            if (!eglInitialize(mEglDisplay, out majorVersion, out minorVersion))
            {
                Console.WriteLine("EGL error: eglInitialize failed.");
                return false;
            }

            // make OpenVG the current API
            eglBindAPI(EGLConfig.EGL_OPENVG_API);

            // find a config that matches all requirements for the window surface
            mEglConfigWindow = IntPtr.Zero;
            if (!eglChooseConfig(mEglDisplay, attribListWindow, out mEglConfigWindow, 1, out numConfig))// || (numConfig < 1))
            {
                Console.WriteLine("EGL error: eglChooseConfig failed for window.");
                return false;
            }

            // create a window surface
            mEglWindowSurface = eglCreateWindowSurface(mEglDisplay, mEglConfigWindow, hwnd, surfAttribs);
            if (eglGetError() != EGLError.EGL_SUCCESS)
            {
                Console.WriteLine("eglCreateWindowSurface failed.");
                return false;
            }

            // create a context
            mEglContext = eglCreateContext(mEglDisplay, mEglConfigWindow, EGLAliases.EGL_NO_CONTEXT, IntPtr.Zero);
            if (eglGetError() != EGLError.EGL_SUCCESS)
            {
                Console.WriteLine("eglCreateContext failed.");
                return false;
            }

            // bind the context to the current thread and use our window surface for drawing and reading
            eglMakeCurrent(mEglDisplay, mEglWindowSurface, mEglWindowSurface, mEglContext);
            if (eglGetError() != EGLError.EGL_SUCCESS)
            {
                Console.WriteLine("eglMakeCurrent failed.");
                return false;
            }

            // dump available EGL configurations
            // eglConfigurationsInfo("egl_configs.txt", eglDisplay);

            return true;
        }

        static public bool InitAmanith()
        {
            var dpy = EGLAliases.EGL_DEFAULT_DISPLAY;
            var win = EGLAliases.EGL_NO_SURFACE;
            return Init(win, dpy);
        }

        static public bool InitWindows(IntPtr hwnd, IntPtr dpy)
        {
            return Init(hwnd, dpy);
        }

        static public bool InitVivante()
        {
            int majorVersion, minorVersion, numConfig;

            var attribListWindow = new[]
            {
                (int)EGLConfig.EGL_SURFACE_TYPE, (int)EGLSurfaceType.EGL_WINDOW_BIT,
                (int)EGLConfig.EGL_RED_SIZE, 8,
		        (int)EGLConfig.EGL_GREEN_SIZE, 8,
		        (int)EGLConfig.EGL_BLUE_SIZE, 8,
                (int)EGLConfig.EGL_ALPHA_MASK_SIZE, 0,
		        (int)EGLConfig.EGL_SAMPLES, 4,
		        (int)EGLConfig.EGL_RENDERABLE_TYPE, (int)EGLRenderableType.EGL_OPENVG_BIT,
		        (int)EGLConfig.EGL_NONE
	        };

            var surfAttribs = new[]
            {
		        (int)EGLConfig.EGL_COLORSPACE, (int)EGLConfig.EGL_COLORSPACE_sRGB,
		        (int)EGLConfig.EGL_ALPHA_FORMAT, (int)EGLConfig.EGL_ALPHA_FORMAT_PRE,
		        (int)EGLConfig.EGL_NONE
	        };


            var dpyFsl = fbGetDisplayByIndex(0);

            // get the display
            mEglDisplay = eglGetDisplay(dpyFsl);
            //mEglDisplay = eglGetDisplay(new System.IntPtr(0));
            if (mEglDisplay == IntPtr.Zero)
            {
                Console.WriteLine("EGL error: eglGetDisplay failed.");
                return false;
            }

            // initialize EGL
            if (!eglInitialize(mEglDisplay, out majorVersion, out minorVersion))
            {
                Console.WriteLine("EGL error: eglInitialize failed.");
                return false;
            }
            Console.WriteLine("EGL v{0}.{1} init successufully", majorVersion, minorVersion);

            // make OpenVG the current API
            eglBindAPI(EGLConfig.EGL_OPENVG_API);

            // find a config that matches all requirements for the window surface
            mEglConfigWindow = IntPtr.Zero;
            eglChooseConfig(mEglDisplay, attribListWindow, out mEglConfigWindow, 1, out numConfig);// || (numConfig < 1))
            var rv = eglGetError();
            if (eglGetError() != EGLError.EGL_SUCCESS)
            {
                Console.WriteLine("EGL error: eglChooseConfig failed for window: {0}", rv);
                return false;
            }

            Console.WriteLine("Configuration: {0}", numConfig);
            for (var i = 0; i < numConfig; i++)
            {

                int redSize = 0;
                int greenSize = 0;
                int blueSize = 0;
                int alphaSize = 0;
                int depthSize = 0;
                int stencilSize = 0;
                int samples = 0;
                int samples_buffers = 0;
                int id = 0;

                int openglbit = 0;
                int surfacebit = 0;

                eglGetConfigAttrib(mEglDisplay, mEglConfigWindow, (int)EGLConfig.EGL_RED_SIZE, out redSize);
                eglGetConfigAttrib(mEglDisplay, mEglConfigWindow, (int)EGLConfig.EGL_GREEN_SIZE, out greenSize);
                eglGetConfigAttrib(mEglDisplay, mEglConfigWindow, (int)EGLConfig.EGL_BLUE_SIZE, out blueSize);
                eglGetConfigAttrib(mEglDisplay, mEglConfigWindow, (int)EGLConfig.EGL_ALPHA_SIZE, out alphaSize);
                eglGetConfigAttrib(mEglDisplay, mEglConfigWindow, (int)EGLConfig.EGL_DEPTH_SIZE, out depthSize);
                eglGetConfigAttrib(mEglDisplay, mEglConfigWindow, (int)EGLConfig.EGL_STENCIL_SIZE, out stencilSize);
                eglGetConfigAttrib(mEglDisplay, mEglConfigWindow, (int)EGLConfig.EGL_SAMPLES, out samples);
                eglGetConfigAttrib(mEglDisplay, mEglConfigWindow, (int)EGLConfig.EGL_SAMPLE_BUFFERS, out samples_buffers);
                eglGetConfigAttrib(mEglDisplay, mEglConfigWindow, (int)EGLConfig.EGL_RENDERABLE_TYPE, out openglbit);
                eglGetConfigAttrib(mEglDisplay, mEglConfigWindow, (int)EGLConfig.EGL_CONFIG_ID, out id);
                eglGetConfigAttrib(mEglDisplay, mEglConfigWindow, (int)EGLConfig.EGL_SURFACE_TYPE, out surfacebit);

                    //Console.WriteLine("config {0} no match\n", i);
                Console.WriteLine("id={0}, a,b,g,r={1},{2},{3},{4}, d,s={5},{6}, AA={7},openglbit={8}, surfacebit={9}\n",
                           id, alphaSize, blueSize, greenSize, redSize, depthSize, stencilSize,
                           samples, openglbit, surfacebit);
            }


            //var vendor = eglQueryString(mEglDisplay, (int)EGLConfig.EGL_VENDOR);
            //Console.WriteLine("vendor: {0}", vendor.Length);
            //Console.WriteLine(Encoding.ASCII.GetString(vendor));

            
            var winFsl = fbCreateWindow(dpyFsl, 0, 0, 0, 0);
            
            // create a window surface
            mEglWindowSurface = eglCreateWindowSurface(mEglDisplay, mEglConfigWindow, winFsl, surfAttribs);
            if (eglGetError() != EGLError.EGL_SUCCESS)
            {
                Console.WriteLine("eglCreateWindowSurface failed.");
                return false;
            }
            

            // create a context
            mEglContext = eglCreateContext(mEglDisplay, mEglConfigWindow, EGLAliases.EGL_NO_CONTEXT, IntPtr.Zero);
            rv = eglGetError();
            if (eglGetError() != EGLError.EGL_SUCCESS)
            {
                Console.WriteLine("eglCreateContext failed: {0}", rv);
                return false;
            }

            // bind the context to the current thread and use our window surface for drawing and reading
            eglMakeCurrent(mEglDisplay, mEglWindowSurface, mEglWindowSurface, mEglContext);
            if (eglGetError() != EGLError.EGL_SUCCESS)
            {
                Console.WriteLine("eglMakeCurrent failed.");
                return false;
            }

            // dump available EGL configurations
            // eglConfigurationsInfo("egl_configs.txt", eglDisplay);

            return true;
        }

        static public void Dispose()
        {
            eglMakeCurrent(mEglDisplay, EGLAliases.EGL_NO_SURFACE, EGLAliases.EGL_NO_SURFACE, EGLAliases.EGL_NO_CONTEXT);
            if (mEglWindowSurface != EGLAliases.EGL_NO_SURFACE)
                eglDestroySurface(mEglDisplay, mEglWindowSurface);

            // TODO: 
            //if (win != IntPtr.Zero && dpy != IntPtr.Zero)
            //    fsl_destroywindow(win, dpy);

            if (mEglContext != EGLAliases.EGL_NO_CONTEXT)
                eglDestroyContext(mEglDisplay, mEglContext);

            eglTerminate(mEglDisplay);
        }

        static public void SwapBuffers()
        {
            eglSwapBuffers(mEglDisplay, mEglWindowSurface);
        }
        #endregion

        static public void ActivateWindow()
        {
            eglMakeCurrent(mEglDisplay, mEglWindowSurface, mEglWindowSurface, mEglContext);
        }

        public static IntPtr GetContext()
        {
            return mEglContext;
        }

        public static IntPtr GetDisplay()
        {
            return mEglDisplay;
        }
    }

    public class RenderBuffer : IDisposable
    {
        private readonly IntPtr mImage;
        //private readonly IntPtr mBuffer;

        public void ToSurface()
        {
            // make the window surface current
            //EGLContext.ActivateWindow();
            
            VG.vgSeti(VGParamType.VG_IMAGE_MODE, (int)VGImageMode.VG_DRAW_IMAGE_NORMAL);
            VG.vgDrawImage(mImage);
            VG.vgFinish();
        }

        public void Copy()
        {
            VG.vgGetPixels(mImage, 0, 0, 0, 0, Width, Height);
        }

        public int Height { get; private set; }
        public int Width { get; private set; }

        /// <summary>
        /// Make the pbuffer surface current
        /// </summary>
        /*
        public void Activate()
        {
            EGLContext.eglMakeCurrent(mEglDisplay, mBuffer, mBuffer, mEglContext);
        }
        */

        private static IntPtr mEglConfigPbuffer;
        private static IntPtr mEglDisplay;
        //private static IntPtr mEglContext;

        public RenderBuffer(int width, int height, VGImageFormat format)
        {
            
            
            Width = width;
            Height = height;

            //mEglContext = EGLContext.GetContext();
            mEglDisplay = EGLContext.GetDisplay();

            var attribListPbuffer = new[]
            {
		        (int)EGLConfig.EGL_SURFACE_TYPE, (int)EGLSurfaceType.EGL_PBUFFER_BIT,
                (int)EGLConfig.EGL_RED_SIZE, 8,
		        (int)EGLConfig.EGL_GREEN_SIZE, 8,
		        (int)EGLConfig.EGL_BLUE_SIZE, 8,
		        (int)EGLConfig.EGL_ALPHA_MASK_SIZE, 0,
                
                //(int)EGLConfig.EGL_MULTISAMPLE_RESOLVE, (int)EGLSurfaceType.EGL_MULTISAMPLE_RESOLVE_BOX_BIT,
                //(int)EGLConfig.EGL_SAMPLES, 4,
                //(int)EGLConfig.EGL_SAMPLE_BUFFERS, 1,
                    
		        (int)EGLConfig.EGL_RENDERABLE_TYPE, (int)EGLRenderableType.EGL_OPENVG_BIT,
		        (int)EGLConfig.EGL_NONE
	        };

            // find a config that matches all requirements for the pbuffer surface
            mEglConfigPbuffer = EGLAliases.EGL_NO_SURFACE;
            int numConfig;
            if (!EGLContext.eglChooseConfig(mEglDisplay, attribListPbuffer, out mEglConfigPbuffer, 1, out numConfig))// || (numConfig < 1))
            {
                //var rv = EGLContext.eglGetError();
                throw new ArgumentException("EGL error: eglChooseConfig failed for pbuffer");
            }


            // query surface dimension
            //eglQuerySurface(mEglDisplay, mEglWindowSurface, EGL_WIDTH, &surfaceWidth);
            //eglQuerySurface(mEglDisplay, mEglWindowSurface, EGL_HEIGHT, &surfaceHeight);
            // choose the best image format:
            // - same colorSpace and alphaFormat of the window surface, in order to get the best performance out of vgSetPixels (see main loop)
            // - same color buffer depth of the pbuffer config, in order to avoid the EGL_BAD_MATCH from eglCreatePbufferFromClientBuffer 
            //imgFormat = eglChoseBestImageFormat(eglDisplay, eglWindowSurface, mEglConfigPbuffer);
            // create the image


            mImage = VG.vgCreateImage(format, Width, Height, VGImageQuality.VG_IMAGE_QUALITY_BETTER);
            //mImage = VG.vgCreateImage(VGImageFormat.VG_sABGR_8888, Width, Height, VGImageQuality.VG_IMAGE_QUALITY_NONANTIALIASED);
            if (mImage == IntPtr.Zero)
                throw new ArgumentException("bad vgImage");

            // create the pbuffer surface from image
            /*
            mBuffer = EGLContext.eglCreatePbufferFromClientBuffer(mEglDisplay, (int)EGLConfig.EGL_OPENVG_IMAGE, mImage, mEglConfigPbuffer, IntPtr.Zero);
            {
                var rv = EGLContext.eglGetError();

                if (rv != EGLError.EGL_SUCCESS)
                    throw new ArgumentException("bad Pbuffer");
            }
            */
        }

        public void Dispose()
        {
            /*
            if (mBuffer != EGLAliases.EGL_NO_SURFACE)
                EGLContext.eglDestroySurface(mEglDisplay, mBuffer);
            */
            if (mImage != IntPtr.Zero)
                VG.vgDestroyImage(mImage);
        }
    }

    #endregion
}
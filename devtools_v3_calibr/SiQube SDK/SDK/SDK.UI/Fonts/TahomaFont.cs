using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Fonts
{
    public class TahomaFont : IFontInfo
    {
        #region glyphs_description

        private static readonly byte[] TahomaGlyph33Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph33Coordinates =
            {
                0.220703f, 0.727051f, 0.207031f, 0.200195f,
                0.125977f, 0.200195f, 0.111328f, 0.727051f,
                0.220703f, 0.727051f, 0.215820f, 0.000000f,
                0.116211f, 0.000000f, 0.116211f, 0.103027f,
                0.215820f, 0.103027f, 0.215820f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph34Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph34Coordinates =
            {
                0.345703f, 0.759766f, 0.324707f, 0.477051f,
                0.260254f, 0.477051f, 0.239258f, 0.759766f,
                0.345703f, 0.759766f, 0.162109f, 0.759766f,
                0.141113f, 0.477051f, 0.076660f, 0.477051f,
                0.055664f, 0.759766f, 0.162109f, 0.759766f
            };

        private static readonly byte[] TahomaGlyph35Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph35Coordinates =
            {
                0.658203f, 0.455078f, 0.515137f, 0.455078f,
                0.470215f, 0.271484f, 0.601074f, 0.271484f,
                0.601074f, 0.205566f, 0.453125f, 0.205566f,
                0.401855f, 0.000000f, 0.338867f, 0.000000f,
                0.390137f, 0.205566f, 0.258301f, 0.205566f,
                0.207031f, 0.000000f, 0.144043f, 0.000000f,
                0.195313f, 0.205566f, 0.069336f, 0.205566f,
                0.069336f, 0.271484f, 0.212402f, 0.271484f,
                0.257324f, 0.455078f, 0.126465f, 0.455078f,
                0.126465f, 0.520996f, 0.274414f, 0.520996f,
                0.325684f, 0.727051f, 0.388672f, 0.727051f,
                0.337402f, 0.520996f, 0.469238f, 0.520996f,
                0.520508f, 0.727051f, 0.583496f, 0.727051f,
                0.532227f, 0.520996f, 0.658203f, 0.520996f,
                0.658203f, 0.455078f, 0.453613f, 0.456055f,
                0.319824f, 0.456055f, 0.273926f, 0.270508f,
                0.407715f, 0.270508f, 0.453613f, 0.456055f
            };

        private static readonly byte[] TahomaGlyph36Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph36Coordinates =
            {
                0.500000f, 0.185547f, 0.500000f, 0.113770f,
                0.445068f, 0.062256f, 0.390137f, 0.010742f,
                0.306641f, 0.000488f, 0.306641f, -0.176270f,
                0.250977f, -0.176270f, 0.250977f, -0.001953f,
                0.198242f, -0.001465f, 0.144775f, 0.010254f,
                0.091309f, 0.021973f, 0.051758f, 0.041504f,
                0.051758f, 0.140137f, 0.059082f, 0.140137f,
                0.097656f, 0.111328f, 0.145996f, 0.093262f,
                0.194336f, 0.075195f, 0.250977f, 0.070313f,
                0.250977f, 0.281250f, 0.238770f, 0.284180f,
                0.221191f, 0.288330f, 0.203613f, 0.292480f,
                0.191406f, 0.296387f, 0.118164f, 0.316406f,
                0.086670f, 0.356934f, 0.055176f, 0.397461f,
                0.055176f, 0.456543f, 0.055176f, 0.525879f,
                0.109375f, 0.577148f, 0.163574f, 0.628418f,
                0.250977f, 0.636719f, 0.250977f, 0.769531f,
                0.306641f, 0.769531f, 0.306641f, 0.637695f,
                0.351074f, 0.636230f, 0.398682f, 0.625244f,
                0.446289f, 0.614258f, 0.476563f, 0.601074f,
                0.476563f, 0.504395f, 0.469238f, 0.504395f,
                0.435059f, 0.527832f, 0.394287f, 0.545410f,
                0.353516f, 0.562988f, 0.306641f, 0.566895f,
                0.306641f, 0.356934f, 0.322754f, 0.353516f,
                0.336670f, 0.349854f, 0.350586f, 0.346191f,
                0.360840f, 0.343750f, 0.427246f, 0.328125f,
                0.463623f, 0.289551f, 0.500000f, 0.250977f,
                0.500000f, 0.185547f, 0.250977f, 0.364258f,
                0.250977f, 0.566406f, 0.207031f, 0.562500f,
                0.177246f, 0.537842f, 0.147461f, 0.513184f,
                0.147461f, 0.469238f, 0.147461f, 0.425781f,
                0.169189f, 0.402100f, 0.190918f, 0.378418f,
                0.250977f, 0.364258f, 0.407715f, 0.172852f,
                0.407715f, 0.218750f, 0.384277f, 0.240723f,
                0.360840f, 0.262695f, 0.306641f, 0.273926f,
                0.306641f, 0.071289f, 0.356445f, 0.077148f,
                0.382080f, 0.101318f, 0.407715f, 0.125488f,
                0.407715f, 0.172852f
            };

        private static readonly byte[] TahomaGlyph37Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph37Coordinates =
            {
                0.394043f, 0.525391f, 0.394043f, 0.415527f,
                0.349854f, 0.362549f, 0.305664f, 0.309570f,
                0.222168f, 0.309570f, 0.137207f, 0.309570f,
                0.093506f, 0.363281f, 0.049805f, 0.416992f,
                0.049805f, 0.524902f, 0.049805f, 0.634277f,
                0.094238f, 0.687500f, 0.138672f, 0.740723f,
                0.222168f, 0.740723f, 0.307129f, 0.740723f,
                0.350586f, 0.687012f, 0.394043f, 0.633301f,
                0.394043f, 0.525391f, 0.719238f, 0.727051f,
                0.338379f, 0.000000f, 0.257813f, 0.000000f,
                0.638672f, 0.727051f, 0.719238f, 0.727051f,
                0.926270f, 0.201660f, 0.926270f, 0.091797f,
                0.882080f, 0.038818f, 0.837891f, -0.014160f,
                0.754395f, -0.014160f, 0.669434f, -0.014160f,
                0.625732f, 0.039551f, 0.582031f, 0.093262f,
                0.582031f, 0.201172f, 0.582031f, 0.310547f,
                0.626465f, 0.363770f, 0.670898f, 0.416992f,
                0.754395f, 0.416992f, 0.839355f, 0.416992f,
                0.882813f, 0.363281f, 0.926270f, 0.309570f,
                0.926270f, 0.201660f, 0.307129f, 0.525391f,
                0.307129f, 0.599609f, 0.289795f, 0.637695f,
                0.272461f, 0.675781f, 0.222168f, 0.675781f,
                0.171875f, 0.675781f, 0.154297f, 0.637207f,
                0.136719f, 0.598633f, 0.136719f, 0.524902f,
                0.136719f, 0.451660f, 0.153320f, 0.413086f,
                0.169922f, 0.374512f, 0.222168f, 0.374512f,
                0.272461f, 0.374512f, 0.289795f, 0.413086f,
                0.307129f, 0.451660f, 0.307129f, 0.525391f,
                0.839355f, 0.201660f, 0.839355f, 0.275879f,
                0.822021f, 0.313965f, 0.804688f, 0.352051f,
                0.754395f, 0.352051f, 0.704102f, 0.352051f,
                0.686523f, 0.313477f, 0.668945f, 0.274902f,
                0.668945f, 0.201172f, 0.668945f, 0.127930f,
                0.685547f, 0.089355f, 0.702148f, 0.050781f,
                0.754395f, 0.050781f, 0.804688f, 0.050781f,
                0.822021f, 0.089355f, 0.839355f, 0.127930f,
                0.839355f, 0.201660f
            };

        private static readonly byte[] TahomaGlyph38Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph38Coordinates =
            {
                0.705566f, 0.000000f, 0.580566f, 0.000000f,
                0.480957f, 0.104004f, 0.431152f, 0.040527f,
                0.378662f, 0.012695f, 0.326172f, -0.015137f,
                0.259766f, -0.015137f, 0.161133f, -0.015137f,
                0.096924f, 0.044189f, 0.032715f, 0.103516f,
                0.032715f, 0.199707f, 0.032715f, 0.241699f,
                0.044434f, 0.274414f, 0.056152f, 0.307129f,
                0.075684f, 0.333496f, 0.094727f, 0.358887f,
                0.119629f, 0.378174f, 0.144531f, 0.397461f,
                0.167480f, 0.411621f, 0.118164f, 0.444824f,
                0.093750f, 0.481445f, 0.069336f, 0.518066f,
                0.069336f, 0.573730f, 0.069336f, 0.608398f,
                0.083252f, 0.637939f, 0.097168f, 0.667480f,
                0.119629f, 0.689941f, 0.143066f, 0.712891f,
                0.180420f, 0.727539f, 0.217773f, 0.742188f,
                0.262207f, 0.742188f, 0.343262f, 0.742188f,
                0.394531f, 0.699463f, 0.445801f, 0.656738f,
                0.445801f, 0.591309f, 0.445801f, 0.567383f,
                0.439697f, 0.541748f, 0.433594f, 0.516113f,
                0.417480f, 0.492188f, 0.401367f, 0.468262f,
                0.375244f, 0.447266f, 0.349121f, 0.426270f,
                0.305664f, 0.410645f, 0.477539f, 0.233887f,
                0.484375f, 0.273926f, 0.485840f, 0.321045f,
                0.487305f, 0.368164f, 0.487305f, 0.443848f,
                0.582520f, 0.443848f, 0.582520f, 0.396973f,
                0.582520f, 0.350098f, 0.570557f, 0.291260f,
                0.558594f, 0.232422f, 0.531250f, 0.179688f,
                0.705566f, 0.000000f, 0.438477f, 0.146973f,
                0.213867f, 0.376953f, 0.201660f, 0.369141f,
                0.189453f, 0.358398f, 0.177246f, 0.347656f,
                0.162598f, 0.326172f, 0.150879f, 0.309082f,
                0.141846f, 0.281494f, 0.132813f, 0.253906f,
                0.132813f, 0.223145f, 0.132813f, 0.153809f,
                0.174072f, 0.109131f, 0.215332f, 0.064453f,
                0.285645f, 0.064453f, 0.332520f, 0.064453f,
                0.370117f, 0.084229f, 0.407715f, 0.104004f,
                0.438477f, 0.146973f, 0.259766f, 0.445313f,
                0.287109f, 0.454590f, 0.304932f, 0.470215f,
                0.322754f, 0.485840f, 0.332520f, 0.504395f,
                0.341309f, 0.521484f, 0.345703f, 0.540527f,
                0.350098f, 0.559570f, 0.350098f, 0.581543f,
                0.350098f, 0.628906f, 0.322510f, 0.654785f,
                0.294922f, 0.680664f, 0.258301f, 0.680664f,
                0.214844f, 0.680664f, 0.189941f, 0.651367f,
                0.165039f, 0.622070f, 0.165039f, 0.578125f,
                0.165039f, 0.558594f, 0.168701f, 0.544678f,
                0.172363f, 0.530762f, 0.184082f, 0.512207f,
                0.194336f, 0.497070f, 0.212646f, 0.479980f,
                0.230957f, 0.462891f, 0.259766f, 0.445313f
            };

        private static readonly byte[] TahomaGlyph39Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph39Coordinates =
            {
                0.159668f, 0.759766f, 0.138672f, 0.477051f,
                0.072266f, 0.477051f, 0.051270f, 0.759766f,
                0.159668f, 0.759766f
            };

        private static readonly byte[] TahomaGlyph40Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph40Coordinates =
            {
                0.346680f, -0.201172f, 0.234863f, -0.201172f,
                0.149902f, -0.100098f, 0.101318f, 0.012695f,
                0.052734f, 0.125488f, 0.052734f, 0.279297f,
                0.052734f, 0.429688f, 0.100830f, 0.544189f,
                0.148926f, 0.658691f, 0.234863f, 0.759766f,
                0.346680f, 0.759766f, 0.346680f, 0.754883f,
                0.307129f, 0.719238f, 0.271240f, 0.672607f,
                0.235352f, 0.625977f, 0.204590f, 0.563965f,
                0.175293f, 0.503906f, 0.156982f, 0.431641f,
                0.138672f, 0.359375f, 0.138672f, 0.279297f,
                0.138672f, 0.195801f, 0.156494f, 0.126465f,
                0.174316f, 0.057129f, 0.204590f, -0.005371f,
                0.233887f, -0.065430f, 0.271484f, -0.114014f,
                0.309082f, -0.162598f, 0.346680f, -0.196289f,
                0.346680f, -0.201172f
            };

        private static readonly byte[] TahomaGlyph41Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph41Coordinates =
            {
                0.330078f, 0.279297f, 0.330078f, 0.128418f,
                0.281738f, 0.014160f, 0.233398f, -0.100098f,
                0.147949f, -0.201172f, 0.036133f, -0.201172f,
                0.036133f, -0.196289f, 0.073730f, -0.162598f,
                0.111816f, -0.113525f, 0.149902f, -0.064453f,
                0.178223f, -0.005371f, 0.208496f, 0.057617f,
                0.226318f, 0.127686f, 0.244141f, 0.197754f,
                0.244141f, 0.279297f, 0.244141f, 0.359863f,
                0.226074f, 0.431641f, 0.208008f, 0.503418f,
                0.178223f, 0.563965f, 0.148438f, 0.624512f,
                0.110840f, 0.672852f, 0.073242f, 0.721191f,
                0.036133f, 0.754883f, 0.036133f, 0.759766f,
                0.147949f, 0.759766f, 0.232910f, 0.658691f,
                0.281494f, 0.544922f, 0.330078f, 0.431152f,
                0.330078f, 0.279297f
            };

        private static readonly byte[] TahomaGlyph42Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph42Coordinates =
            {
                0.491699f, 0.433105f, 0.459961f, 0.379395f,
                0.300293f, 0.485352f, 0.303711f, 0.307617f,
                0.242676f, 0.307617f, 0.245605f, 0.485352f,
                0.086914f, 0.378906f, 0.054688f, 0.432617f,
                0.227539f, 0.533691f, 0.054688f, 0.634766f,
                0.086914f, 0.688477f, 0.246094f, 0.581543f,
                0.242676f, 0.759766f, 0.303711f, 0.759766f,
                0.299805f, 0.581543f, 0.459961f, 0.687988f,
                0.491699f, 0.634277f, 0.318848f, 0.534180f,
                0.491699f, 0.433105f
            };

        private static readonly byte[] TahomaGlyph43Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph43Coordinates =
            {
                0.650879f, 0.279297f, 0.404297f, 0.279297f,
                0.404297f, 0.032715f, 0.323242f, 0.032715f,
                0.323242f, 0.279297f, 0.076660f, 0.279297f,
                0.076660f, 0.357422f, 0.323242f, 0.357422f,
                0.323242f, 0.604004f, 0.404297f, 0.604004f,
                0.404297f, 0.357422f, 0.650879f, 0.357422f,
                0.650879f, 0.279297f
            };

        private static readonly byte[] TahomaGlyph44Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph44Coordinates =
            {
                0.244141f, 0.139160f, 0.107422f, -0.180664f,
                0.036133f, -0.180664f, 0.122070f, 0.139160f,
                0.244141f, 0.139160f
            };

        private static readonly byte[] TahomaGlyph45Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph45Coordinates =
            {
                0.319336f, 0.273926f, 0.043945f, 0.273926f,
                0.043945f, 0.362305f, 0.319336f, 0.362305f,
                0.319336f, 0.273926f
            };

        private static readonly byte[] TahomaGlyph46Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph46Coordinates =
            {
                0.209473f, 0.000000f, 0.092773f, 0.000000f,
                0.092773f, 0.139160f, 0.209473f, 0.139160f,
                0.209473f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph47Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph47Coordinates =
            {
                0.355469f, 0.759766f, 0.070801f, -0.158203f,
                -0.011719f, -0.158203f, 0.271484f, 0.759766f,
                0.355469f, 0.759766f
            };

        private static readonly byte[] TahomaGlyph48Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph48Coordinates =
            {
                0.505371f, 0.363770f, 0.505371f, 0.167969f,
                0.448486f, 0.076416f, 0.391602f, -0.015137f,
                0.272949f, -0.015137f, 0.152832f, -0.015137f,
                0.096680f, 0.078125f, 0.040527f, 0.171387f,
                0.040527f, 0.362793f, 0.040527f, 0.559570f,
                0.097412f, 0.650635f, 0.154297f, 0.741699f,
                0.272949f, 0.741699f, 0.393066f, 0.741699f,
                0.449219f, 0.647461f, 0.505371f, 0.553223f,
                0.505371f, 0.363770f, 0.380371f, 0.142090f,
                0.394531f, 0.178223f, 0.400391f, 0.233398f,
                0.406250f, 0.288574f, 0.406250f, 0.363770f,
                0.406250f, 0.438477f, 0.400391f, 0.493652f,
                0.394531f, 0.548828f, 0.379883f, 0.585449f,
                0.365234f, 0.622559f, 0.339600f, 0.641846f,
                0.313965f, 0.661133f, 0.272949f, 0.661133f,
                0.232422f, 0.661133f, 0.206299f, 0.641846f,
                0.180176f, 0.622559f, 0.165039f, 0.584473f,
                0.150391f, 0.547363f, 0.145020f, 0.490723f,
                0.139648f, 0.434082f, 0.139648f, 0.362793f,
                0.139648f, 0.286621f, 0.144287f, 0.235352f,
                0.148926f, 0.184082f, 0.164551f, 0.143555f,
                0.178711f, 0.105957f, 0.204834f, 0.085693f,
                0.230957f, 0.065430f, 0.272949f, 0.065430f,
                0.313477f, 0.065430f, 0.339600f, 0.084717f,
                0.365723f, 0.104004f, 0.380371f, 0.142090f
            };

        private static readonly byte[] TahomaGlyph49Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph49Coordinates =
            {
                0.464844f, 0.000000f, 0.110352f, 0.000000f,
                0.110352f, 0.074219f, 0.242188f, 0.074219f,
                0.242188f, 0.561523f, 0.110352f, 0.561523f,
                0.110352f, 0.627930f, 0.185059f, 0.627930f,
                0.220459f, 0.649170f, 0.255859f, 0.670410f,
                0.260254f, 0.729492f, 0.335938f, 0.729492f,
                0.335938f, 0.074219f, 0.464844f, 0.074219f,
                0.464844f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph50Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph50Coordinates =
            {
                0.501953f, 0.000000f, 0.053223f, 0.000000f,
                0.053223f, 0.102051f, 0.101563f, 0.147949f,
                0.144531f, 0.189941f, 0.187500f, 0.231934f,
                0.228516f, 0.277344f, 0.311523f, 0.368652f,
                0.341797f, 0.423584f, 0.372070f, 0.478516f,
                0.372070f, 0.537109f, 0.372070f, 0.567383f,
                0.362549f, 0.590332f, 0.353027f, 0.613281f,
                0.336426f, 0.628418f, 0.319336f, 0.643066f,
                0.296875f, 0.650391f, 0.274414f, 0.657715f,
                0.247559f, 0.657715f, 0.221680f, 0.657715f,
                0.195068f, 0.651123f, 0.168457f, 0.644531f,
                0.144043f, 0.634766f, 0.123535f, 0.626465f,
                0.104492f, 0.614746f, 0.085449f, 0.603027f,
                0.073730f, 0.594727f, 0.068359f, 0.594727f,
                0.068359f, 0.698242f, 0.098633f, 0.713379f,
                0.152588f, 0.727783f, 0.206543f, 0.742188f,
                0.254883f, 0.742188f, 0.356445f, 0.742188f,
                0.414063f, 0.688232f, 0.471680f, 0.634277f,
                0.471680f, 0.541992f, 0.471680f, 0.499512f,
                0.461670f, 0.463379f, 0.451660f, 0.427246f,
                0.434082f, 0.396484f, 0.416016f, 0.364746f,
                0.390625f, 0.333496f, 0.365234f, 0.302246f,
                0.336914f, 0.271973f, 0.291016f, 0.222168f,
                0.234619f, 0.168457f, 0.178223f, 0.114746f,
                0.144531f, 0.083496f, 0.501953f, 0.083496f,
                0.501953f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph51Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph51Coordinates =
            {
                0.249512f, 0.657715f, 0.223145f, 0.657715f,
                0.196777f, 0.651367f, 0.170410f, 0.645020f,
                0.145020f, 0.634766f, 0.121582f, 0.625000f,
                0.104248f, 0.614258f, 0.086914f, 0.603516f,
                0.073242f, 0.594238f, 0.067383f, 0.594238f,
                0.067383f, 0.697266f, 0.099121f, 0.714355f,
                0.153564f, 0.728271f, 0.208008f, 0.742188f,
                0.257324f, 0.742188f, 0.306641f, 0.742188f,
                0.343506f, 0.732178f, 0.380371f, 0.722168f,
                0.410156f, 0.701172f, 0.442383f, 0.677734f,
                0.458740f, 0.644531f, 0.475098f, 0.611328f,
                0.475098f, 0.566895f, 0.475098f, 0.506836f,
                0.435547f, 0.461426f, 0.395996f, 0.416016f,
                0.340820f, 0.403809f, 0.340820f, 0.396973f,
                0.363770f, 0.392578f, 0.389893f, 0.381836f,
                0.416016f, 0.371094f, 0.438477f, 0.350098f,
                0.460938f, 0.329102f, 0.475098f, 0.296143f,
                0.489258f, 0.263184f, 0.489258f, 0.215820f,
                0.489258f, 0.166504f, 0.472412f, 0.125244f,
                0.455566f, 0.083984f, 0.424805f, 0.052246f,
                0.393066f, 0.019043f, 0.348145f, 0.001953f,
                0.303223f, -0.015137f, 0.246094f, -0.015137f,
                0.191406f, -0.015137f, 0.137695f, -0.001953f,
                0.083984f, 0.011230f, 0.047363f, 0.029785f,
                0.047363f, 0.132813f, 0.054199f, 0.132813f,
                0.084961f, 0.110352f, 0.136719f, 0.089844f,
                0.188477f, 0.069336f, 0.240234f, 0.069336f,
                0.270020f, 0.069336f, 0.300049f, 0.078857f,
                0.330078f, 0.088379f, 0.350098f, 0.109863f,
                0.369629f, 0.131348f, 0.379883f, 0.157227f,
                0.390137f, 0.183105f, 0.390137f, 0.222656f,
                0.390137f, 0.262207f, 0.378662f, 0.287598f,
                0.367188f, 0.312988f, 0.346680f, 0.327637f,
                0.326172f, 0.342285f, 0.298096f, 0.347900f,
                0.270020f, 0.353516f, 0.237305f, 0.353516f,
                0.195801f, 0.353516f, 0.195801f, 0.434570f,
                0.228027f, 0.434570f, 0.293945f, 0.434570f,
                0.335205f, 0.465820f, 0.376465f, 0.497070f,
                0.376465f, 0.556641f, 0.376465f, 0.583984f,
                0.365723f, 0.603760f, 0.354980f, 0.623535f,
                0.338379f, 0.635254f, 0.319824f, 0.647949f,
                0.297363f, 0.652832f, 0.274902f, 0.657715f,
                0.249512f, 0.657715f
            };

        private static readonly byte[] TahomaGlyph52Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph52Coordinates =
            {
                0.520996f, 0.250000f, 0.434570f, 0.250000f,
                0.434570f, 0.000000f, 0.340820f, 0.000000f,
                0.340820f, 0.250000f, 0.019531f, 0.250000f,
                0.019531f, 0.352539f, 0.344727f, 0.727051f,
                0.434570f, 0.727051f, 0.434570f, 0.328125f,
                0.520996f, 0.328125f, 0.520996f, 0.250000f,
                0.340820f, 0.328125f, 0.340820f, 0.612305f,
                0.095703f, 0.328125f, 0.340820f, 0.328125f
            };

        private static readonly byte[] TahomaGlyph53Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph53Coordinates =
            {
                0.493652f, 0.231445f, 0.493652f, 0.178711f,
                0.476807f, 0.133789f, 0.459961f, 0.088867f,
                0.429688f, 0.056152f, 0.398926f, 0.022949f,
                0.353271f, 0.003906f, 0.307617f, -0.015137f,
                0.250977f, -0.015137f, 0.198730f, -0.015137f,
                0.148193f, -0.003662f, 0.097656f, 0.007813f,
                0.060547f, 0.026367f, 0.060547f, 0.129395f,
                0.067383f, 0.129395f, 0.078613f, 0.121094f,
                0.099609f, 0.110596f, 0.120605f, 0.100098f,
                0.145996f, 0.090820f, 0.174805f, 0.080566f,
                0.198730f, 0.074951f, 0.222656f, 0.069336f,
                0.252441f, 0.069336f, 0.281738f, 0.069336f,
                0.309570f, 0.079834f, 0.337402f, 0.090332f,
                0.357422f, 0.113770f, 0.375488f, 0.135254f,
                0.385010f, 0.164063f, 0.394531f, 0.192871f,
                0.394531f, 0.231934f, 0.394531f, 0.270508f,
                0.384033f, 0.295410f, 0.373535f, 0.320313f,
                0.353516f, 0.336426f, 0.332520f, 0.354980f,
                0.302002f, 0.362549f, 0.271484f, 0.370117f,
                0.233887f, 0.370117f, 0.194336f, 0.370117f,
                0.154297f, 0.364014f, 0.114258f, 0.357910f,
                0.090332f, 0.352539f, 0.090332f, 0.727051f,
                0.489258f, 0.727051f, 0.489258f, 0.641602f,
                0.184570f, 0.641602f, 0.184570f, 0.448242f,
                0.202148f, 0.450195f, 0.219238f, 0.451172f,
                0.236328f, 0.452148f, 0.250488f, 0.452148f,
                0.306152f, 0.452148f, 0.344727f, 0.442871f,
                0.383301f, 0.433594f, 0.418945f, 0.406738f,
                0.455078f, 0.379395f, 0.474365f, 0.338379f,
                0.493652f, 0.297363f, 0.493652f, 0.231445f
            };

        private static readonly byte[] TahomaGlyph54Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph54Coordinates =
            {
                0.513184f, 0.235840f, 0.513184f, 0.179688f,
                0.494629f, 0.132324f, 0.476074f, 0.084961f,
                0.444824f, 0.053223f, 0.412109f, 0.019531f,
                0.371582f, 0.002197f, 0.331055f, -0.015137f,
                0.282227f, -0.015137f, 0.232910f, -0.015137f,
                0.192627f, 0.001465f, 0.152344f, 0.018066f,
                0.121582f, 0.050781f, 0.083984f, 0.090332f,
                0.062744f, 0.156494f, 0.041504f, 0.222656f,
                0.041504f, 0.319336f, 0.041504f, 0.414063f,
                0.061035f, 0.490479f, 0.080566f, 0.566895f,
                0.121094f, 0.623535f, 0.160645f, 0.678711f,
                0.223145f, 0.709717f, 0.285645f, 0.740723f,
                0.367676f, 0.740723f, 0.392090f, 0.740723f,
                0.413086f, 0.738281f, 0.434082f, 0.735840f,
                0.450195f, 0.730469f, 0.450195f, 0.637207f,
                0.445801f, 0.637207f, 0.432617f, 0.644531f,
                0.407715f, 0.650635f, 0.382813f, 0.656738f,
                0.354492f, 0.656738f, 0.263672f, 0.656738f,
                0.207764f, 0.595459f, 0.151855f, 0.534180f,
                0.141602f, 0.413574f, 0.176270f, 0.437988f,
                0.212891f, 0.451172f, 0.249512f, 0.464355f,
                0.292969f, 0.464355f, 0.335449f, 0.464355f,
                0.367432f, 0.455811f, 0.399414f, 0.447266f,
                0.434082f, 0.421387f, 0.474121f, 0.391113f,
                0.493652f, 0.344727f, 0.513184f, 0.298340f,
                0.513184f, 0.235840f, 0.414063f, 0.231934f,
                0.414063f, 0.276855f, 0.402344f, 0.307129f,
                0.390625f, 0.337402f, 0.364258f, 0.358887f,
                0.345215f, 0.374512f, 0.321045f, 0.379395f,
                0.296875f, 0.384277f, 0.271484f, 0.384277f,
                0.237305f, 0.384277f, 0.205078f, 0.374023f,
                0.172852f, 0.363770f, 0.141602f, 0.344238f,
                0.140625f, 0.333496f, 0.140137f, 0.323486f,
                0.139648f, 0.313477f, 0.139648f, 0.298340f,
                0.139648f, 0.222656f, 0.154541f, 0.176270f,
                0.169434f, 0.129883f, 0.191406f, 0.105957f,
                0.212402f, 0.083008f, 0.234619f, 0.073730f,
                0.256836f, 0.064453f, 0.282715f, 0.064453f,
                0.341309f, 0.064453f, 0.377686f, 0.106445f,
                0.414063f, 0.148438f, 0.414063f, 0.231934f
            };

        private static readonly byte[] TahomaGlyph55Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph55Coordinates =
            {
                0.509766f, 0.618164f, 0.195313f, 0.000000f,
                0.091309f, 0.000000f, 0.424316f, 0.641602f,
                0.048340f, 0.641602f, 0.048340f, 0.727051f,
                0.509766f, 0.727051f, 0.509766f, 0.618164f
            };

        private static readonly byte[] TahomaGlyph56Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph56Coordinates =
            {
                0.395996f, 0.557617f, 0.395996f, 0.606445f,
                0.363281f, 0.639160f, 0.330566f, 0.671875f,
                0.272461f, 0.671875f, 0.219238f, 0.671875f,
                0.185303f, 0.642578f, 0.151367f, 0.613281f,
                0.151367f, 0.563477f, 0.151367f, 0.527344f,
                0.168701f, 0.502441f, 0.186035f, 0.477539f,
                0.220703f, 0.457520f, 0.235840f, 0.449219f,
                0.266846f, 0.434570f, 0.297852f, 0.419922f,
                0.323242f, 0.411621f, 0.365723f, 0.444336f,
                0.380859f, 0.478760f, 0.395996f, 0.513184f,
                0.395996f, 0.557617f, 0.409668f, 0.193359f,
                0.409668f, 0.238281f, 0.392090f, 0.264648f,
                0.374512f, 0.291016f, 0.324219f, 0.318359f,
                0.307617f, 0.327637f, 0.280029f, 0.338379f,
                0.252441f, 0.349121f, 0.217773f, 0.363770f,
                0.177246f, 0.336914f, 0.155762f, 0.297607f,
                0.134277f, 0.258301f, 0.134277f, 0.208008f,
                0.134277f, 0.142090f, 0.174072f, 0.099121f,
                0.213867f, 0.056152f, 0.273926f, 0.056152f,
                0.335449f, 0.056152f, 0.372559f, 0.093018f,
                0.409668f, 0.129883f, 0.409668f, 0.193359f,
                0.272949f, -0.016602f, 0.218750f, -0.016602f,
                0.174316f, -0.000488f, 0.129883f, 0.015625f,
                0.098633f, 0.045898f, 0.067871f, 0.075195f,
                0.052002f, 0.115479f, 0.036133f, 0.155762f,
                0.036133f, 0.200684f, 0.036133f, 0.259766f,
                0.067627f, 0.309326f, 0.099121f, 0.358887f,
                0.159180f, 0.388184f, 0.159180f, 0.391113f,
                0.105469f, 0.422363f, 0.079590f, 0.459473f,
                0.053711f, 0.496582f, 0.053711f, 0.552246f,
                0.053711f, 0.634277f, 0.115723f, 0.688965f,
                0.177734f, 0.743652f, 0.272949f, 0.743652f,
                0.372070f, 0.743652f, 0.431885f, 0.691650f,
                0.491699f, 0.639648f, 0.491699f, 0.558594f,
                0.491699f, 0.509766f, 0.463135f, 0.461914f,
                0.434570f, 0.414063f, 0.380859f, 0.387207f,
                0.380859f, 0.384277f, 0.444336f, 0.354492f,
                0.477051f, 0.312012f, 0.509766f, 0.269531f,
                0.509766f, 0.202637f, 0.509766f, 0.109375f,
                0.442139f, 0.046387f, 0.374512f, -0.016602f,
                0.272949f, -0.016602f
            };

        private static readonly byte[] TahomaGlyph57Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph57Coordinates =
            {
                0.406250f, 0.428223f, 0.406250f, 0.502441f,
                0.392578f, 0.549072f, 0.378906f, 0.595703f,
                0.354980f, 0.621094f, 0.333496f, 0.644531f,
                0.311523f, 0.653320f, 0.289551f, 0.662109f,
                0.263184f, 0.662109f, 0.203125f, 0.662109f,
                0.167480f, 0.619141f, 0.131836f, 0.576172f,
                0.131836f, 0.494629f, 0.131836f, 0.448730f,
                0.143555f, 0.418945f, 0.155273f, 0.389160f,
                0.181641f, 0.367676f, 0.200195f, 0.352539f,
                0.223633f, 0.347412f, 0.247070f, 0.342285f,
                0.273926f, 0.342285f, 0.305176f, 0.342285f,
                0.341309f, 0.353271f, 0.377441f, 0.364258f,
                0.404297f, 0.382324f, 0.404785f, 0.389648f,
                0.405518f, 0.401611f, 0.406250f, 0.413574f,
                0.406250f, 0.428223f, 0.032715f, 0.490723f,
                0.032715f, 0.546875f, 0.051025f, 0.593262f,
                0.069336f, 0.639648f, 0.101074f, 0.673340f,
                0.131348f, 0.705566f, 0.175049f, 0.723633f,
                0.218750f, 0.741699f, 0.263672f, 0.741699f,
                0.313965f, 0.741699f, 0.354736f, 0.724854f,
                0.395508f, 0.708008f, 0.425293f, 0.676270f,
                0.462891f, 0.636230f, 0.483643f, 0.571289f,
                0.504395f, 0.506348f, 0.504395f, 0.407227f,
                0.504395f, 0.316895f, 0.484131f, 0.236084f,
                0.463867f, 0.155273f, 0.424316f, 0.102051f,
                0.382324f, 0.045410f, 0.323486f, 0.015625f,
                0.264648f, -0.014160f, 0.178223f, -0.014160f,
                0.158691f, -0.014160f, 0.136719f, -0.011963f,
                0.114746f, -0.009766f, 0.095703f, -0.003906f,
                0.095703f, 0.089355f, 0.100586f, 0.089355f,
                0.112793f, 0.082520f, 0.138672f, 0.076172f,
                0.164551f, 0.069824f, 0.191406f, 0.069824f,
                0.287109f, 0.069824f, 0.341797f, 0.132813f,
                0.396484f, 0.195801f, 0.403809f, 0.312988f,
                0.364746f, 0.286621f, 0.329346f, 0.274414f,
                0.293945f, 0.262207f, 0.252441f, 0.262207f,
                0.211914f, 0.262207f, 0.178711f, 0.270996f,
                0.145508f, 0.279785f, 0.111816f, 0.305176f,
                0.072754f, 0.334961f, 0.052734f, 0.380615f,
                0.032715f, 0.426270f, 0.032715f, 0.490723f
            };

        private static readonly byte[] TahomaGlyph58Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph58Coordinates =
            {
                0.235352f, 0.406250f, 0.118652f, 0.406250f,
                0.118652f, 0.545410f, 0.235352f, 0.545410f,
                0.235352f, 0.406250f, 0.235352f, 0.000000f,
                0.118652f, 0.000000f, 0.118652f, 0.139160f,
                0.235352f, 0.139160f, 0.235352f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph59Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph59Coordinates =
            {
                0.235352f, 0.406250f, 0.118652f, 0.406250f,
                0.118652f, 0.545410f, 0.235352f, 0.545410f,
                0.235352f, 0.406250f, 0.267578f, 0.139160f,
                0.130859f, -0.180664f, 0.059570f, -0.180664f,
                0.145508f, 0.139160f, 0.267578f, 0.139160f
            };

        private static readonly byte[] TahomaGlyph60Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph60Coordinates =
            {
                0.622559f, 0.038574f, 0.098145f, 0.289063f,
                0.098145f, 0.347656f, 0.622559f, 0.598145f,
                0.622559f, 0.511230f, 0.215820f, 0.318359f,
                0.622559f, 0.125488f, 0.622559f, 0.038574f
            };

        private static readonly byte[] TahomaGlyph61Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph61Coordinates =
            {
                0.633789f, 0.381836f, 0.093750f, 0.381836f,
                0.093750f, 0.459961f, 0.633789f, 0.459961f,
                0.633789f, 0.381836f, 0.633789f, 0.176758f,
                0.093750f, 0.176758f, 0.093750f, 0.254883f,
                0.633789f, 0.254883f, 0.633789f, 0.176758f
            };

        private static readonly byte[] TahomaGlyph62Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph62Coordinates =
            {
                0.629395f, 0.289063f, 0.104980f, 0.038574f,
                0.104980f, 0.125488f, 0.511719f, 0.318359f,
                0.104980f, 0.511230f, 0.104980f, 0.598145f,
                0.629395f, 0.347656f, 0.629395f, 0.289063f
            };

        private static readonly byte[] TahomaGlyph63Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph63Coordinates =
            {
                0.445313f, 0.556152f, 0.445313f, 0.508301f,
                0.429443f, 0.470947f, 0.413574f, 0.433594f,
                0.387207f, 0.405273f, 0.360840f, 0.376953f,
                0.327393f, 0.353027f, 0.293945f, 0.329102f,
                0.256836f, 0.306641f, 0.256836f, 0.195313f,
                0.169434f, 0.195313f, 0.169434f, 0.344238f,
                0.196777f, 0.360840f, 0.233154f, 0.384033f,
                0.269531f, 0.407227f, 0.290039f, 0.427246f,
                0.316406f, 0.452148f, 0.331055f, 0.481689f,
                0.345703f, 0.511230f, 0.345703f, 0.548828f,
                0.345703f, 0.604004f, 0.311035f, 0.631104f,
                0.276367f, 0.658203f, 0.220703f, 0.658203f,
                0.171875f, 0.658203f, 0.128662f, 0.641846f,
                0.085449f, 0.625488f, 0.058594f, 0.607910f,
                0.053223f, 0.607910f, 0.053223f, 0.707520f,
                0.085938f, 0.720703f, 0.135742f, 0.731201f,
                0.185547f, 0.741699f, 0.229980f, 0.741699f,
                0.330078f, 0.741699f, 0.387695f, 0.690674f,
                0.445313f, 0.639648f, 0.445313f, 0.556152f,
                0.264648f, 0.000000f, 0.165039f, 0.000000f,
                0.165039f, 0.103027f, 0.264648f, 0.103027f,
                0.264648f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph64Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph64Coordinates =
            {
                0.849121f, 0.323730f, 0.849121f, 0.255859f,
                0.830566f, 0.192627f, 0.812012f, 0.129395f,
                0.777344f, 0.076660f, 0.571777f, 0.076660f,
                0.559570f, 0.133301f, 0.526855f, 0.105469f,
                0.499268f, 0.089111f, 0.471680f, 0.072754f,
                0.424316f, 0.072754f, 0.349121f, 0.072754f,
                0.301270f, 0.133057f, 0.253418f, 0.193359f,
                0.253418f, 0.308105f, 0.253418f, 0.422852f,
                0.312256f, 0.486816f, 0.371094f, 0.550781f,
                0.446777f, 0.550781f, 0.481934f, 0.550781f,
                0.507324f, 0.541992f, 0.532715f, 0.533203f,
                0.558594f, 0.518555f, 0.558594f, 0.541992f,
                0.636230f, 0.541992f, 0.636230f, 0.130859f,
                0.747070f, 0.130859f, 0.765625f, 0.165527f,
                0.773682f, 0.220703f, 0.781738f, 0.275879f,
                0.781738f, 0.320801f, 0.781738f, 0.480469f,
                0.700439f, 0.577881f, 0.619141f, 0.675293f,
                0.466797f, 0.675293f, 0.322266f, 0.675293f,
                0.228271f, 0.570068f, 0.134277f, 0.464844f,
                0.134277f, 0.314941f, 0.134277f, 0.153809f,
                0.225586f, 0.053955f, 0.316895f, -0.045898f,
                0.464355f, -0.045898f, 0.503906f, -0.045898f,
                0.547607f, -0.040527f, 0.591309f, -0.035156f,
                0.630371f, -0.023438f, 0.630371f, -0.092773f,
                0.589355f, -0.102539f, 0.547119f, -0.106445f,
                0.504883f, -0.110352f, 0.463867f, -0.110352f,
                0.291016f, -0.110352f, 0.177734f, 0.008301f,
                0.064453f, 0.126953f, 0.064453f, 0.315918f,
                0.064453f, 0.495117f, 0.181396f, 0.618164f,
                0.298340f, 0.741211f, 0.466309f, 0.741211f,
                0.645996f, 0.741211f, 0.747559f, 0.625244f,
                0.849121f, 0.509277f, 0.849121f, 0.323730f,
                0.557617f, 0.199219f, 0.557617f, 0.452148f,
                0.530273f, 0.466309f, 0.507324f, 0.472412f,
                0.484375f, 0.478516f, 0.459473f, 0.478516f,
                0.404297f, 0.478516f, 0.370605f, 0.437256f,
                0.336914f, 0.395996f, 0.336914f, 0.309570f,
                0.336914f, 0.231445f, 0.362305f, 0.189941f,
                0.387695f, 0.148438f, 0.443359f, 0.148438f,
                0.473145f, 0.148438f, 0.502197f, 0.162598f,
                0.531250f, 0.176758f, 0.557617f, 0.199219f
            };

        private static readonly byte[] TahomaGlyph65Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph65Coordinates =
            {
                -0.004883f, 0.000000f, 0.240234f, 0.727051f,
                0.359375f, 0.727051f, 0.604492f, 0.000000f,
                0.502441f, 0.000000f, 0.436523f, 0.203125f,
                0.158691f, 0.203125f, 0.092773f, 0.000000f,
                -0.004883f, 0.000000f, 0.409668f, 0.285645f,
                0.297363f, 0.628418f, 0.185547f, 0.285645f,
                0.409668f, 0.285645f
            };

        private static readonly byte[] TahomaGlyph66Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph66Coordinates =
            {
                0.566895f, 0.223145f, 0.566895f, 0.168945f,
                0.546387f, 0.127441f, 0.525879f, 0.085938f,
                0.491211f, 0.059082f, 0.450195f, 0.026855f,
                0.403320f, 0.013428f, 0.356445f, 0.000000f,
                0.282227f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.266602f, 0.727051f,
                0.344238f, 0.727051f, 0.383057f, 0.721924f,
                0.421875f, 0.716797f, 0.457520f, 0.697754f,
                0.496582f, 0.676758f, 0.514648f, 0.642822f,
                0.532715f, 0.608887f, 0.532715f, 0.562988f,
                0.532715f, 0.511719f, 0.505615f, 0.471191f,
                0.478516f, 0.430664f, 0.430664f, 0.407715f,
                0.430664f, 0.403809f, 0.495605f, 0.386230f,
                0.531250f, 0.339600f, 0.566895f, 0.292969f,
                0.566895f, 0.223145f, 0.432129f, 0.549316f,
                0.432129f, 0.575684f, 0.423340f, 0.594971f,
                0.414551f, 0.614258f, 0.395020f, 0.625488f,
                0.371582f, 0.638672f, 0.342773f, 0.641602f,
                0.313965f, 0.644531f, 0.263184f, 0.644531f,
                0.170410f, 0.644531f, 0.170410f, 0.431641f,
                0.280273f, 0.431641f, 0.325684f, 0.431641f,
                0.347168f, 0.436279f, 0.368652f, 0.440918f,
                0.391602f, 0.455566f, 0.413574f, 0.469727f,
                0.422852f, 0.492676f, 0.432129f, 0.515625f,
                0.432129f, 0.549316f, 0.466309f, 0.219238f,
                0.466309f, 0.260254f, 0.454590f, 0.286865f,
                0.442871f, 0.313477f, 0.407227f, 0.332031f,
                0.384277f, 0.344238f, 0.357178f, 0.347656f,
                0.330078f, 0.351074f, 0.280273f, 0.351074f,
                0.170410f, 0.351074f, 0.170410f, 0.082520f,
                0.249023f, 0.082520f, 0.312500f, 0.082520f,
                0.349121f, 0.088379f, 0.385742f, 0.094238f,
                0.413574f, 0.113281f, 0.440918f, 0.132324f,
                0.453613f, 0.156494f, 0.466309f, 0.180664f,
                0.466309f, 0.219238f
            };

        private static readonly byte[] TahomaGlyph67Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph67Coordinates =
            {
                0.357910f, -0.013184f, 0.286621f, -0.013184f,
                0.226807f, 0.010742f, 0.166992f, 0.034668f,
                0.123535f, 0.082031f, 0.080078f, 0.129395f,
                0.056152f, 0.200195f, 0.032227f, 0.270996f,
                0.032227f, 0.362793f, 0.032227f, 0.454102f,
                0.055420f, 0.521973f, 0.078613f, 0.589844f,
                0.123047f, 0.640137f, 0.166504f, 0.688965f,
                0.226074f, 0.714600f, 0.285645f, 0.740234f,
                0.359375f, 0.740234f, 0.395996f, 0.740234f,
                0.427979f, 0.734863f, 0.459961f, 0.729492f,
                0.487305f, 0.721191f, 0.510742f, 0.713867f,
                0.535400f, 0.702881f, 0.560059f, 0.691895f,
                0.583984f, 0.678711f, 0.583984f, 0.562012f,
                0.576172f, 0.562012f, 0.563477f, 0.573730f,
                0.543457f, 0.590332f, 0.523438f, 0.606934f,
                0.494629f, 0.623047f, 0.466797f, 0.638184f,
                0.434082f, 0.647949f, 0.401367f, 0.657715f,
                0.358398f, 0.657715f, 0.312012f, 0.657715f,
                0.270508f, 0.638672f, 0.229004f, 0.619629f,
                0.197754f, 0.582520f, 0.166992f, 0.545410f,
                0.149902f, 0.489258f, 0.132813f, 0.433105f,
                0.132813f, 0.362793f, 0.132813f, 0.288086f,
                0.150879f, 0.234131f, 0.168945f, 0.180176f,
                0.200195f, 0.143066f, 0.230469f, 0.106934f,
                0.271484f, 0.088623f, 0.312500f, 0.070313f,
                0.358398f, 0.070313f, 0.400391f, 0.070313f,
                0.436035f, 0.080566f, 0.471680f, 0.090820f,
                0.499512f, 0.106445f, 0.526367f, 0.121582f,
                0.545898f, 0.137451f, 0.565430f, 0.153320f,
                0.576660f, 0.164551f, 0.583984f, 0.164551f,
                0.583984f, 0.049316f, 0.560059f, 0.038086f,
                0.538818f, 0.027832f, 0.517578f, 0.017578f,
                0.487305f, 0.007813f, 0.455566f, -0.002441f,
                0.428467f, -0.007813f, 0.401367f, -0.013184f,
                0.357910f, -0.013184f
            };

        private static readonly byte[] TahomaGlyph68Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph68Coordinates =
            {
                0.646973f, 0.362793f, 0.646973f, 0.263184f,
                0.606689f, 0.183105f, 0.566406f, 0.103027f,
                0.498535f, 0.058105f, 0.443359f, 0.023438f,
                0.386475f, 0.011719f, 0.329590f, 0.000000f,
                0.241211f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.239258f, 0.727051f,
                0.341797f, 0.727051f, 0.400146f, 0.711670f,
                0.458496f, 0.696289f, 0.499512f, 0.669434f,
                0.569824f, 0.623047f, 0.608398f, 0.546143f,
                0.646973f, 0.469238f, 0.646973f, 0.362793f,
                0.546387f, 0.364258f, 0.546387f, 0.448242f,
                0.518555f, 0.507568f, 0.490723f, 0.566895f,
                0.436035f, 0.600098f, 0.397461f, 0.623535f,
                0.353516f, 0.633789f, 0.309570f, 0.644043f,
                0.244141f, 0.644043f, 0.170410f, 0.644043f,
                0.170410f, 0.083008f, 0.244141f, 0.083008f,
                0.308594f, 0.083008f, 0.356934f, 0.093262f,
                0.405273f, 0.103516f, 0.445313f, 0.131348f,
                0.495605f, 0.165527f, 0.520996f, 0.222412f,
                0.546387f, 0.279297f, 0.546387f, 0.364258f
            };

        private static readonly byte[] TahomaGlyph69Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph69Coordinates =
            {
                0.073730f, 0.000000f, 0.073730f, 0.727051f,
                0.528320f, 0.727051f, 0.528320f, 0.641113f,
                0.170410f, 0.641113f, 0.170410f, 0.441895f,
                0.503906f, 0.441895f, 0.503906f, 0.355957f,
                0.170410f, 0.355957f, 0.170410f, 0.085938f,
                0.528320f, 0.085938f, 0.528320f, 0.000000f,
                0.073730f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph70Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph70Coordinates =
            {
                0.508789f, 0.641113f, 0.170410f, 0.641113f,
                0.170410f, 0.436035f, 0.494629f, 0.436035f,
                0.494629f, 0.350098f, 0.170410f, 0.350098f,
                0.170410f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.508789f, 0.727051f,
                0.508789f, 0.641113f
            };

        private static readonly byte[] TahomaGlyph71Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph71Coordinates =
            {
                0.377930f, -0.014160f, 0.300781f, -0.014160f,
                0.236816f, 0.009277f, 0.172852f, 0.032715f,
                0.126953f, 0.080566f, 0.081055f, 0.128906f,
                0.056641f, 0.200195f, 0.032227f, 0.271484f,
                0.032227f, 0.364258f, 0.032227f, 0.452148f,
                0.056885f, 0.521729f, 0.081543f, 0.591309f,
                0.127441f, 0.640625f, 0.171875f, 0.688477f,
                0.236816f, 0.714355f, 0.301758f, 0.740234f,
                0.378906f, 0.740234f, 0.415527f, 0.740234f,
                0.449219f, 0.734863f, 0.482910f, 0.729492f,
                0.513672f, 0.720215f, 0.538086f, 0.712891f,
                0.568115f, 0.699951f, 0.598145f, 0.687012f,
                0.616699f, 0.677734f, 0.616699f, 0.561035f,
                0.608398f, 0.561035f, 0.590332f, 0.577148f,
                0.571045f, 0.591553f, 0.551758f, 0.605957f,
                0.516602f, 0.622559f, 0.487305f, 0.637207f,
                0.449219f, 0.646973f, 0.411133f, 0.656738f,
                0.367188f, 0.656738f, 0.262207f, 0.656738f,
                0.197510f, 0.577637f, 0.132813f, 0.498535f,
                0.132813f, 0.367188f, 0.132813f, 0.293945f,
                0.149902f, 0.239258f, 0.166992f, 0.184570f,
                0.199219f, 0.146484f, 0.230469f, 0.108887f,
                0.274658f, 0.089111f, 0.318848f, 0.069336f,
                0.374023f, 0.069336f, 0.415039f, 0.069336f,
                0.455566f, 0.075195f, 0.496094f, 0.081055f,
                0.523926f, 0.092773f, 0.523926f, 0.280762f,
                0.355957f, 0.280762f, 0.355957f, 0.365723f,
                0.619629f, 0.365723f, 0.619629f, 0.048340f,
                0.601074f, 0.040039f, 0.570068f, 0.027344f,
                0.539063f, 0.014648f, 0.512207f, 0.007324f,
                0.476563f, -0.003418f, 0.447754f, -0.008789f,
                0.418945f, -0.014160f, 0.377930f, -0.014160f
            };

        private static readonly byte[] TahomaGlyph72Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph72Coordinates =
            {
                0.601563f, 0.000000f, 0.504883f, 0.000000f,
                0.504883f, 0.355957f, 0.170410f, 0.355957f,
                0.170410f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.170410f, 0.727051f,
                0.170410f, 0.441895f, 0.504883f, 0.441895f,
                0.504883f, 0.727051f, 0.601563f, 0.727051f,
                0.601563f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph73Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph73Coordinates =
            {
                0.327637f, 0.000000f, 0.045410f, 0.000000f,
                0.045410f, 0.074219f, 0.138184f, 0.074219f,
                0.138184f, 0.652832f, 0.045410f, 0.652832f,
                0.045410f, 0.727051f, 0.327637f, 0.727051f,
                0.327637f, 0.652832f, 0.234863f, 0.652832f,
                0.234863f, 0.074219f, 0.327637f, 0.074219f,
                0.327637f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph74Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph74Coordinates =
            {
                0.347656f, 0.188965f, 0.347656f, 0.093262f,
                0.289307f, 0.041504f, 0.230957f, -0.010254f,
                0.132813f, -0.010254f, 0.109375f, -0.010254f,
                0.070068f, -0.006104f, 0.030762f, -0.001953f,
                0.004395f, 0.003906f, 0.004395f, 0.096191f,
                0.009766f, 0.096191f, 0.029785f, 0.089355f,
                0.059326f, 0.081055f, 0.088867f, 0.072754f,
                0.119629f, 0.072754f, 0.164551f, 0.072754f,
                0.191162f, 0.083008f, 0.217773f, 0.093262f,
                0.230469f, 0.112305f, 0.243652f, 0.131836f,
                0.247314f, 0.160156f, 0.250977f, 0.188477f,
                0.250977f, 0.225586f, 0.250977f, 0.649902f,
                0.097168f, 0.649902f, 0.097168f, 0.727051f,
                0.347656f, 0.727051f, 0.347656f, 0.188965f
            };

        private static readonly byte[] TahomaGlyph75Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph75Coordinates =
            {
                0.603516f, 0.000000f, 0.478027f, 0.000000f,
                0.212891f, 0.338379f, 0.170410f, 0.290527f,
                0.170410f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.170410f, 0.727051f,
                0.170410f, 0.392578f, 0.468262f, 0.727051f,
                0.585938f, 0.727051f, 0.285156f, 0.402344f,
                0.603516f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph76Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph76Coordinates =
            {
                0.495117f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.170410f, 0.727051f,
                0.170410f, 0.085938f, 0.495117f, 0.085938f,
                0.495117f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph77Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph77Coordinates =
            {
                0.696777f, 0.000000f, 0.600098f, 0.000000f,
                0.600098f, 0.626465f, 0.410645f, 0.200195f,
                0.352051f, 0.200195f, 0.164063f, 0.626465f,
                0.164063f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.205566f, 0.727051f,
                0.387207f, 0.322266f, 0.562500f, 0.727051f,
                0.696777f, 0.727051f, 0.696777f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph78Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph78Coordinates =
            {
                0.593750f, 0.000000f, 0.485352f, 0.000000f,
                0.164063f, 0.626953f, 0.164063f, 0.000000f,
                0.073730f, 0.000000f, 0.073730f, 0.727051f,
                0.210938f, 0.727051f, 0.503418f, 0.151367f,
                0.503418f, 0.727051f, 0.593750f, 0.727051f,
                0.593750f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph79Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph79Coordinates =
            {
                0.587891f, 0.643555f, 0.629395f, 0.595703f,
                0.652344f, 0.524902f, 0.675293f, 0.454102f,
                0.675293f, 0.363281f, 0.675293f, 0.274902f,
                0.652832f, 0.203613f, 0.630371f, 0.132324f,
                0.587891f, 0.083984f, 0.543457f, 0.033203f,
                0.484131f, 0.009033f, 0.424805f, -0.015137f,
                0.353516f, -0.015137f, 0.279785f, -0.015137f,
                0.220703f, 0.009766f, 0.161621f, 0.034668f,
                0.119141f, 0.083984f, 0.077148f, 0.132324f,
                0.054688f, 0.203125f, 0.032227f, 0.273926f,
                0.032227f, 0.363281f, 0.032227f, 0.455078f,
                0.054932f, 0.524414f, 0.077637f, 0.593750f,
                0.119629f, 0.643555f, 0.161621f, 0.691895f,
                0.220947f, 0.717041f, 0.280273f, 0.742188f,
                0.353516f, 0.742188f, 0.427734f, 0.742188f,
                0.487305f, 0.716309f, 0.546875f, 0.690430f,
                0.587891f, 0.643555f, 0.574707f, 0.363281f,
                0.574707f, 0.435547f, 0.559082f, 0.491211f,
                0.543457f, 0.546875f, 0.515137f, 0.583496f,
                0.486328f, 0.621094f, 0.445557f, 0.639893f,
                0.404785f, 0.658691f, 0.354004f, 0.658691f,
                0.301270f, 0.658691f, 0.261963f, 0.640381f,
                0.222656f, 0.622070f, 0.192383f, 0.583496f,
                0.163574f, 0.546387f, 0.148193f, 0.490234f,
                0.132813f, 0.434082f, 0.132813f, 0.363281f,
                0.132813f, 0.220215f, 0.192871f, 0.144287f,
                0.252930f, 0.068359f, 0.354004f, 0.068359f,
                0.455078f, 0.068359f, 0.514893f, 0.144287f,
                0.574707f, 0.220215f, 0.574707f, 0.363281f
            };

        private static readonly byte[] TahomaGlyph80Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph80Coordinates =
            {
                0.532715f, 0.507813f, 0.532715f, 0.460449f,
                0.515869f, 0.418213f, 0.499023f, 0.375977f,
                0.469238f, 0.346191f, 0.431641f, 0.309082f,
                0.380859f, 0.290039f, 0.330078f, 0.270996f,
                0.252441f, 0.270996f, 0.170410f, 0.270996f,
                0.170410f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.256348f, 0.727051f,
                0.320801f, 0.727051f, 0.366211f, 0.716309f,
                0.411621f, 0.705566f, 0.446289f, 0.681641f,
                0.486816f, 0.653809f, 0.509766f, 0.611084f,
                0.532715f, 0.568359f, 0.532715f, 0.507813f,
                0.432129f, 0.505371f, 0.432129f, 0.542969f,
                0.419189f, 0.570801f, 0.406250f, 0.598633f,
                0.379883f, 0.616211f, 0.356934f, 0.631348f,
                0.326416f, 0.637695f, 0.295898f, 0.644043f,
                0.250488f, 0.644043f, 0.170410f, 0.644043f,
                0.170410f, 0.353516f, 0.236328f, 0.353516f,
                0.294922f, 0.353516f, 0.331055f, 0.363037f,
                0.367188f, 0.372559f, 0.391113f, 0.396973f,
                0.412598f, 0.418945f, 0.422363f, 0.444824f,
                0.432129f, 0.470703f, 0.432129f, 0.505371f
            };

        private static readonly byte[] TahomaGlyph81Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph81Coordinates =
            {
                0.677734f, -0.177734f, 0.651367f, -0.184570f,
                0.622314f, -0.187988f, 0.593262f, -0.191406f,
                0.564453f, -0.191406f, 0.482910f, -0.191406f,
                0.431885f, -0.145508f, 0.380859f, -0.099609f,
                0.375977f, -0.014648f, 0.369629f, -0.014648f,
                0.363770f, -0.014648f, 0.357910f, -0.014648f,
                0.353516f, -0.014648f, 0.279785f, -0.014648f,
                0.220459f, 0.010498f, 0.161133f, 0.035645f,
                0.119141f, 0.083984f, 0.077148f, 0.132324f,
                0.054688f, 0.203125f, 0.032227f, 0.273926f,
                0.032227f, 0.363281f, 0.032227f, 0.455078f,
                0.054932f, 0.524414f, 0.077637f, 0.593750f,
                0.119629f, 0.643555f, 0.161621f, 0.691895f,
                0.220947f, 0.717041f, 0.280273f, 0.742188f,
                0.353516f, 0.742188f, 0.427734f, 0.742188f,
                0.487305f, 0.716309f, 0.546875f, 0.690430f,
                0.587891f, 0.643555f, 0.629395f, 0.595703f,
                0.652344f, 0.524902f, 0.675293f, 0.454102f,
                0.675293f, 0.363281f, 0.675293f, 0.222168f,
                0.620117f, 0.130371f, 0.564941f, 0.038574f,
                0.469238f, 0.005859f, 0.471680f, -0.021484f,
                0.478760f, -0.043213f, 0.485840f, -0.064941f,
                0.497070f, -0.077637f, 0.510254f, -0.092773f,
                0.529053f, -0.099854f, 0.547852f, -0.106934f,
                0.580566f, -0.106934f, 0.600098f, -0.106934f,
                0.626465f, -0.100830f, 0.652832f, -0.094727f,
                0.664551f, -0.089844f, 0.677734f, -0.089844f,
                0.677734f, -0.177734f, 0.574707f, 0.363281f,
                0.574707f, 0.435547f, 0.559082f, 0.491211f,
                0.543457f, 0.546875f, 0.515137f, 0.583496f,
                0.486328f, 0.621094f, 0.445557f, 0.639893f,
                0.404785f, 0.658691f, 0.354004f, 0.658691f,
                0.301270f, 0.658691f, 0.261963f, 0.640381f,
                0.222656f, 0.622070f, 0.192383f, 0.583496f,
                0.163574f, 0.546387f, 0.148193f, 0.490234f,
                0.132813f, 0.434082f, 0.132813f, 0.363281f,
                0.132813f, 0.220215f, 0.192871f, 0.144043f,
                0.252930f, 0.067871f, 0.354004f, 0.067871f,
                0.455078f, 0.067871f, 0.514893f, 0.144043f,
                0.574707f, 0.220215f, 0.574707f, 0.363281f
            };

        private static readonly byte[] TahomaGlyph82Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph82Coordinates =
            {
                0.636719f, 0.000000f, 0.511230f, 0.000000f,
                0.280762f, 0.289063f, 0.170410f, 0.289063f,
                0.170410f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.261230f, 0.727051f,
                0.323730f, 0.727051f, 0.365967f, 0.720215f,
                0.408203f, 0.713379f, 0.446289f, 0.688477f,
                0.484375f, 0.664063f, 0.506592f, 0.625488f,
                0.528809f, 0.586914f, 0.528809f, 0.529785f,
                0.528809f, 0.449707f, 0.488281f, 0.395996f,
                0.447754f, 0.342285f, 0.377930f, 0.316406f,
                0.636719f, 0.000000f, 0.427734f, 0.522461f,
                0.427734f, 0.554199f, 0.416504f, 0.578857f,
                0.405273f, 0.603516f, 0.381836f, 0.619141f,
                0.361328f, 0.632813f, 0.333984f, 0.638428f,
                0.306641f, 0.644043f, 0.266113f, 0.644043f,
                0.170410f, 0.644043f, 0.170410f, 0.369629f,
                0.255371f, 0.369629f, 0.296875f, 0.369629f,
                0.330078f, 0.376953f, 0.363281f, 0.384277f,
                0.386719f, 0.407227f, 0.407715f, 0.427734f,
                0.417725f, 0.456055f, 0.427734f, 0.484375f,
                0.427734f, 0.522461f
            };

        private static readonly byte[] TahomaGlyph83Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph83Coordinates =
            {
                0.276367f, -0.013184f, 0.197266f, -0.013184f,
                0.141846f, 0.003174f, 0.086426f, 0.019531f,
                0.037598f, 0.043457f, 0.037598f, 0.164551f,
                0.044434f, 0.164551f, 0.092285f, 0.119629f,
                0.152832f, 0.094971f, 0.213379f, 0.070313f,
                0.269531f, 0.070313f, 0.349609f, 0.070313f,
                0.390625f, 0.103760f, 0.431641f, 0.137207f,
                0.431641f, 0.191895f, 0.431641f, 0.235352f,
                0.410156f, 0.262695f, 0.388672f, 0.290039f,
                0.341797f, 0.303223f, 0.308105f, 0.312988f,
                0.280273f, 0.319336f, 0.252441f, 0.325684f,
                0.210449f, 0.336426f, 0.172852f, 0.346191f,
                0.143066f, 0.361328f, 0.113281f, 0.376465f,
                0.090332f, 0.400879f, 0.067871f, 0.424805f,
                0.055420f, 0.457275f, 0.042969f, 0.489746f,
                0.042969f, 0.532227f, 0.042969f, 0.620605f,
                0.111816f, 0.680420f, 0.180664f, 0.740234f,
                0.287598f, 0.740234f, 0.348633f, 0.740234f,
                0.403076f, 0.728027f, 0.457520f, 0.715820f,
                0.503906f, 0.693359f, 0.503906f, 0.577637f,
                0.496582f, 0.577637f, 0.461914f, 0.609375f,
                0.407715f, 0.633057f, 0.353516f, 0.656738f,
                0.293945f, 0.656738f, 0.226563f, 0.656738f,
                0.185059f, 0.625244f, 0.143555f, 0.593750f,
                0.143555f, 0.542480f, 0.143555f, 0.496094f,
                0.167969f, 0.468750f, 0.192383f, 0.441406f,
                0.238770f, 0.428711f, 0.269531f, 0.420410f,
                0.313965f, 0.409912f, 0.358398f, 0.399414f,
                0.387695f, 0.390625f, 0.462891f, 0.367676f,
                0.497559f, 0.321289f, 0.532227f, 0.274902f,
                0.532227f, 0.207031f, 0.532227f, 0.164551f,
                0.514893f, 0.123047f, 0.497559f, 0.081543f,
                0.466309f, 0.052734f, 0.431152f, 0.020996f,
                0.386963f, 0.003906f, 0.342773f, -0.013184f,
                0.276367f, -0.013184f
            };

        private static readonly byte[] TahomaGlyph84Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph84Coordinates =
            {
                0.243652f, 0.000000f, 0.243652f, 0.641113f,
                -0.000488f, 0.641113f, -0.000488f, 0.727051f,
                0.584473f, 0.727051f, 0.584473f, 0.641113f,
                0.340332f, 0.641113f, 0.340332f, 0.000000f,
                0.243652f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph85Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph85Coordinates =
            {
                0.327637f, -0.015137f, 0.263672f, -0.015137f,
                0.215820f, 0.001709f, 0.167969f, 0.018555f,
                0.134277f, 0.051758f, 0.096191f, 0.089844f,
                0.080566f, 0.142822f, 0.064941f, 0.195801f,
                0.064941f, 0.273438f, 0.064941f, 0.727051f,
                0.161621f, 0.727051f, 0.161621f, 0.273438f,
                0.161621f, 0.223145f, 0.167969f, 0.188721f,
                0.174316f, 0.154297f, 0.192871f, 0.126953f,
                0.212402f, 0.097656f, 0.245850f, 0.082520f,
                0.279297f, 0.067383f, 0.327637f, 0.067383f,
                0.373047f, 0.067383f, 0.408203f, 0.082520f,
                0.443359f, 0.097656f, 0.462891f, 0.126953f,
                0.480957f, 0.154785f, 0.487549f, 0.188477f,
                0.494141f, 0.222168f, 0.494141f, 0.270996f,
                0.494141f, 0.727051f, 0.590820f, 0.727051f,
                0.590820f, 0.273438f, 0.590820f, 0.197754f,
                0.575439f, 0.143555f, 0.560059f, 0.089355f,
                0.521484f, 0.051758f, 0.486816f, 0.018066f,
                0.440674f, 0.001465f, 0.394531f, -0.015137f,
                0.327637f, -0.015137f
            };

        private static readonly byte[] TahomaGlyph86Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph86Coordinates =
            {
                0.600586f, 0.727051f, 0.350586f, 0.000000f,
                0.246094f, 0.000000f, -0.003906f, 0.727051f,
                0.099609f, 0.727051f, 0.300781f, 0.123535f,
                0.501953f, 0.727051f, 0.600586f, 0.727051f
            };

        private static readonly byte[] TahomaGlyph87Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph87Coordinates =
            {
                0.889160f, 0.727051f, 0.706543f, 0.000000f,
                0.597656f, 0.000000f, 0.449707f, 0.603516f,
                0.305176f, 0.000000f, 0.198730f, 0.000000f,
                0.012695f, 0.727051f, 0.111816f, 0.727051f,
                0.258301f, 0.122559f, 0.403809f, 0.727051f,
                0.501953f, 0.727051f, 0.648926f, 0.116699f,
                0.794434f, 0.727051f, 0.889160f, 0.727051f
            };

        private static readonly byte[] TahomaGlyph88Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph88Coordinates =
            {
                0.576660f, 0.000000f, 0.465820f, 0.000000f,
                0.288574f, 0.291016f, 0.108398f, 0.000000f,
                0.003906f, 0.000000f, 0.234863f, 0.363770f,
                0.010742f, 0.727051f, 0.121094f, 0.727051f,
                0.294922f, 0.441406f, 0.471191f, 0.727051f,
                0.576172f, 0.727051f, 0.348633f, 0.368652f,
                0.576660f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph89Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph89Coordinates =
            {
                0.582520f, 0.727051f, 0.336914f, 0.321777f,
                0.336914f, 0.000000f, 0.240234f, 0.000000f,
                0.240234f, 0.311523f, -0.005371f, 0.727051f,
                0.102051f, 0.727051f, 0.289551f, 0.406250f,
                0.479980f, 0.727051f, 0.582520f, 0.727051f
            };

        private static readonly byte[] TahomaGlyph90Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph90Coordinates =
            {
                0.537109f, 0.000000f, 0.029297f, 0.000000f,
                0.029297f, 0.089844f, 0.418457f, 0.641113f,
                0.046875f, 0.641113f, 0.046875f, 0.727051f,
                0.527344f, 0.727051f, 0.527344f, 0.639648f,
                0.133789f, 0.085938f, 0.537109f, 0.085938f,
                0.537109f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph91Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph91Coordinates =
            {
                0.334961f, -0.191406f, 0.081055f, -0.191406f,
                0.081055f, 0.759766f, 0.334961f, 0.759766f,
                0.334961f, 0.689941f, 0.166504f, 0.689941f,
                0.166504f, -0.121582f, 0.334961f, -0.121582f,
                0.334961f, -0.191406f
            };

        private static readonly byte[] TahomaGlyph92Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph92Coordinates =
            {
                0.392578f, -0.158203f, 0.310059f, -0.158203f,
                0.025391f, 0.759766f, 0.109375f, 0.759766f,
                0.392578f, -0.158203f
            };

        private static readonly byte[] TahomaGlyph93Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph93Coordinates =
            {
                0.301758f, -0.191406f, 0.047852f, -0.191406f,
                0.047852f, -0.121582f, 0.216309f, -0.121582f,
                0.216309f, 0.689941f, 0.047852f, 0.689941f,
                0.047852f, 0.759766f, 0.301758f, 0.759766f,
                0.301758f, -0.191406f
            };

        private static readonly byte[] TahomaGlyph94Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph94Coordinates =
            {
                0.662598f, 0.333984f, 0.565918f, 0.333984f,
                0.363281f, 0.639160f, 0.161133f, 0.333008f,
                0.064941f, 0.333008f, 0.333008f, 0.727051f,
                0.394531f, 0.727051f, 0.662598f, 0.333984f
            };

        private static readonly byte[] TahomaGlyph95Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph95Coordinates =
            {
                0.553711f, -0.146484f, -0.007813f, -0.146484f,
                -0.007813f, -0.083008f, 0.553711f, -0.083008f,
                0.553711f, -0.146484f
            };

        private static readonly byte[] TahomaGlyph96Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph96Coordinates =
            {
                0.327148f, 0.635742f, 0.254395f, 0.635742f,
                0.121094f, 0.818359f, 0.239746f, 0.818359f,
                0.327148f, 0.635742f
            };

        private static readonly byte[] TahomaGlyph97Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph97Coordinates =
            {
                0.371094f, 0.134277f, 0.371094f, 0.285645f,
                0.338379f, 0.282715f, 0.288330f, 0.277588f,
                0.238281f, 0.272461f, 0.207520f, 0.263184f,
                0.170898f, 0.251953f, 0.146973f, 0.228760f,
                0.123047f, 0.205566f, 0.123047f, 0.164063f,
                0.123047f, 0.117188f, 0.149414f, 0.093262f,
                0.175781f, 0.069336f, 0.226563f, 0.069336f,
                0.270020f, 0.069336f, 0.305176f, 0.088135f,
                0.340332f, 0.106934f, 0.371094f, 0.134277f,
                0.371094f, 0.058105f, 0.359863f, 0.049805f,
                0.341064f, 0.034912f, 0.322266f, 0.020020f,
                0.304688f, 0.011230f, 0.280273f, -0.001465f,
                0.257568f, -0.008301f, 0.234863f, -0.015137f,
                0.193848f, -0.015137f, 0.160156f, -0.015137f,
                0.129883f, -0.002441f, 0.099609f, 0.010254f,
                0.076660f, 0.033203f, 0.054688f, 0.055664f,
                0.041504f, 0.088623f, 0.028320f, 0.121582f,
                0.028320f, 0.158203f, 0.028320f, 0.214844f,
                0.052246f, 0.254639f, 0.076172f, 0.294434f,
                0.127930f, 0.317871f, 0.173828f, 0.338867f,
                0.236328f, 0.346924f, 0.298828f, 0.354980f,
                0.371094f, 0.358887f, 0.371094f, 0.376465f,
                0.371094f, 0.408691f, 0.361328f, 0.428467f,
                0.351563f, 0.448242f, 0.333984f, 0.458984f,
                0.316406f, 0.470215f, 0.291016f, 0.473877f,
                0.265625f, 0.477539f, 0.238770f, 0.477539f,
                0.207031f, 0.477539f, 0.164063f, 0.468018f,
                0.121094f, 0.458496f, 0.078125f, 0.440430f,
                0.072754f, 0.440430f, 0.072754f, 0.533691f,
                0.098145f, 0.541016f, 0.145508f, 0.549805f,
                0.192871f, 0.558594f, 0.239258f, 0.558594f,
                0.295410f, 0.558594f, 0.333984f, 0.549805f,
                0.372559f, 0.541016f, 0.403320f, 0.518066f,
                0.433105f, 0.495605f, 0.447754f, 0.459961f,
                0.462402f, 0.424316f, 0.462402f, 0.373047f,
                0.462402f, 0.000000f, 0.371094f, 0.000000f,
                0.371094f, 0.058105f
            };

        private static readonly byte[] TahomaGlyph98Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph98Coordinates =
            {
                0.429199f, 0.274414f, 0.429199f, 0.372070f,
                0.399414f, 0.422607f, 0.369629f, 0.473145f,
                0.303711f, 0.473145f, 0.266113f, 0.473145f,
                0.227783f, 0.455566f, 0.189453f, 0.437988f,
                0.158203f, 0.411133f, 0.158203f, 0.098633f,
                0.192871f, 0.081543f, 0.219727f, 0.074463f,
                0.246582f, 0.067383f, 0.278809f, 0.067383f,
                0.349121f, 0.067383f, 0.389160f, 0.117188f,
                0.429199f, 0.166992f, 0.429199f, 0.274414f,
                0.523926f, 0.281738f, 0.523926f, 0.147949f,
                0.458984f, 0.066406f, 0.394043f, -0.015137f,
                0.296387f, -0.015137f, 0.251953f, -0.015137f,
                0.220459f, -0.004150f, 0.188965f, 0.006836f,
                0.158203f, 0.025391f, 0.152344f, 0.000000f,
                0.066406f, 0.000000f, 0.066406f, 0.759766f,
                0.158203f, 0.759766f, 0.158203f, 0.488281f,
                0.192871f, 0.519531f, 0.233398f, 0.540039f,
                0.273926f, 0.560547f, 0.325195f, 0.560547f,
                0.417480f, 0.560547f, 0.470703f, 0.486572f,
                0.523926f, 0.412598f, 0.523926f, 0.281738f
            };

        private static readonly byte[] TahomaGlyph99Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph99Coordinates =
            {
                0.283203f, -0.012207f, 0.227051f, -0.012207f,
                0.180176f, 0.005127f, 0.133301f, 0.022461f,
                0.099609f, 0.057617f, 0.065918f, 0.092773f,
                0.047363f, 0.146240f, 0.028809f, 0.199707f,
                0.028809f, 0.271973f, 0.028809f, 0.343750f,
                0.048096f, 0.395996f, 0.067383f, 0.448242f,
                0.099609f, 0.483887f, 0.131836f, 0.519531f,
                0.179932f, 0.538818f, 0.228027f, 0.558105f,
                0.283203f, 0.558105f, 0.328125f, 0.558105f,
                0.369873f, 0.545410f, 0.411621f, 0.532715f,
                0.444336f, 0.516113f, 0.444336f, 0.413086f,
                0.438965f, 0.413086f, 0.429199f, 0.421387f,
                0.413818f, 0.432129f, 0.398438f, 0.442871f,
                0.376465f, 0.454102f, 0.357422f, 0.463867f,
                0.331543f, 0.471191f, 0.305664f, 0.478516f,
                0.281738f, 0.478516f, 0.210449f, 0.478516f,
                0.167236f, 0.424561f, 0.124023f, 0.370605f,
                0.124023f, 0.271973f, 0.124023f, 0.175293f,
                0.165771f, 0.121338f, 0.207520f, 0.067383f,
                0.281738f, 0.067383f, 0.326660f, 0.067383f,
                0.367188f, 0.085938f, 0.407715f, 0.104492f,
                0.438965f, 0.133789f, 0.444336f, 0.133789f,
                0.444336f, 0.030762f, 0.430664f, 0.024414f,
                0.410156f, 0.015381f, 0.389648f, 0.006348f,
                0.373047f, 0.001953f, 0.349609f, -0.004883f,
                0.331055f, -0.008545f, 0.312500f, -0.012207f,
                0.283203f, -0.012207f
            };

        private static readonly byte[] TahomaGlyph100Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph100Coordinates =
            {
                0.486328f, 0.000000f, 0.394531f, 0.000000f,
                0.394531f, 0.055664f, 0.373047f, 0.037598f,
                0.357422f, 0.025879f, 0.341797f, 0.014160f,
                0.320801f, 0.004395f, 0.301270f, -0.004883f,
                0.280273f, -0.010010f, 0.259277f, -0.015137f,
                0.231445f, -0.015137f, 0.187012f, -0.015137f,
                0.149170f, 0.003418f, 0.111328f, 0.021973f,
                0.084961f, 0.057617f, 0.058105f, 0.093750f,
                0.043457f, 0.146729f, 0.028809f, 0.199707f,
                0.028809f, 0.268555f, 0.028809f, 0.340332f,
                0.047363f, 0.392822f, 0.065918f, 0.445313f,
                0.098633f, 0.484375f, 0.128418f, 0.520020f,
                0.170654f, 0.540283f, 0.212891f, 0.560547f,
                0.259277f, 0.560547f, 0.300293f, 0.560547f,
                0.330566f, 0.551514f, 0.360840f, 0.542480f,
                0.394531f, 0.523438f, 0.394531f, 0.759766f,
                0.486328f, 0.759766f, 0.486328f, 0.000000f,
                0.394531f, 0.132813f, 0.394531f, 0.447266f,
                0.360352f, 0.463867f, 0.333252f, 0.470215f,
                0.306152f, 0.476563f, 0.274414f, 0.476563f,
                0.203613f, 0.476563f, 0.163574f, 0.423584f,
                0.123535f, 0.370605f, 0.123535f, 0.270508f,
                0.123535f, 0.174316f, 0.154297f, 0.123291f,
                0.185059f, 0.072266f, 0.252930f, 0.072266f,
                0.289063f, 0.072266f, 0.325684f, 0.088623f,
                0.362305f, 0.104980f, 0.394531f, 0.132813f
            };

        private static readonly byte[] TahomaGlyph101Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph101Coordinates =
            {
                0.303223f, -0.012695f, 0.172852f, -0.012695f,
                0.100830f, 0.060791f, 0.028809f, 0.134277f,
                0.028809f, 0.269531f, 0.028809f, 0.402832f,
                0.098633f, 0.481689f, 0.168457f, 0.560547f,
                0.281250f, 0.560547f, 0.332031f, 0.560547f,
                0.371094f, 0.545898f, 0.410156f, 0.531250f,
                0.439453f, 0.500000f, 0.468750f, 0.468750f,
                0.484375f, 0.423584f, 0.500000f, 0.378418f,
                0.500000f, 0.312988f, 0.500000f, 0.263184f,
                0.122070f, 0.263184f, 0.122070f, 0.167969f,
                0.169922f, 0.117676f, 0.217773f, 0.067383f,
                0.302246f, 0.067383f, 0.332520f, 0.067383f,
                0.361572f, 0.074219f, 0.390625f, 0.081055f,
                0.414063f, 0.091797f, 0.438965f, 0.103027f,
                0.456055f, 0.113525f, 0.473145f, 0.124023f,
                0.484375f, 0.133301f, 0.489746f, 0.133301f,
                0.489746f, 0.033203f, 0.473633f, 0.026855f,
                0.449707f, 0.017334f, 0.425781f, 0.007813f,
                0.406738f, 0.002441f, 0.379883f, -0.004883f,
                0.358154f, -0.008789f, 0.336426f, -0.012695f,
                0.303223f, -0.012695f, 0.410645f, 0.333496f,
                0.409668f, 0.370605f, 0.401855f, 0.397461f,
                0.394043f, 0.424316f, 0.379395f, 0.442871f,
                0.363281f, 0.463379f, 0.338135f, 0.474121f,
                0.312988f, 0.484863f, 0.275879f, 0.484863f,
                0.239258f, 0.484863f, 0.213623f, 0.473877f,
                0.187988f, 0.462891f, 0.166992f, 0.441895f,
                0.146484f, 0.420410f, 0.135742f, 0.394287f,
                0.125000f, 0.368164f, 0.122070f, 0.333496f,
                0.410645f, 0.333496f
            };

        private static readonly byte[] TahomaGlyph102Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph102Coordinates =
            {
                0.353516f, 0.671875f, 0.348633f, 0.671875f,
                0.336426f, 0.676270f, 0.313477f, 0.680420f,
                0.290527f, 0.684570f, 0.272461f, 0.684570f,
                0.214355f, 0.684570f, 0.189697f, 0.658447f,
                0.165039f, 0.632324f, 0.165039f, 0.563965f,
                0.165039f, 0.545410f, 0.316895f, 0.545410f,
                0.316895f, 0.469238f, 0.167969f, 0.469238f,
                0.167969f, 0.000000f, 0.076172f, 0.000000f,
                0.076172f, 0.469238f, 0.014160f, 0.469238f,
                0.014160f, 0.545410f, 0.076172f, 0.545410f,
                0.076172f, 0.563477f, 0.076172f, 0.662109f,
                0.123535f, 0.713379f, 0.170898f, 0.764648f,
                0.259277f, 0.764648f, 0.284668f, 0.764648f,
                0.309082f, 0.761963f, 0.333496f, 0.759277f,
                0.353516f, 0.755859f, 0.353516f, 0.671875f
            };

        private static readonly byte[] TahomaGlyph103Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph103Coordinates =
            {
                0.394531f, 0.147949f, 0.394531f, 0.447266f,
                0.360352f, 0.463867f, 0.331299f, 0.470947f,
                0.302246f, 0.478027f, 0.273438f, 0.478027f,
                0.203613f, 0.478027f, 0.163574f, 0.426758f,
                0.123535f, 0.375488f, 0.123535f, 0.279785f,
                0.123535f, 0.188965f, 0.154053f, 0.141602f,
                0.184570f, 0.094238f, 0.252930f, 0.094238f,
                0.288574f, 0.094238f, 0.326416f, 0.108398f,
                0.364258f, 0.122559f, 0.394531f, 0.147949f,
                0.085938f, -0.087402f, 0.095215f, -0.091309f,
                0.113281f, -0.097900f, 0.131348f, -0.104492f,
                0.154297f, -0.110352f, 0.179688f, -0.116699f,
                0.201172f, -0.120605f, 0.222656f, -0.124512f,
                0.248047f, -0.124512f, 0.290527f, -0.124512f,
                0.320068f, -0.113281f, 0.349609f, -0.102051f,
                0.366211f, -0.082031f, 0.381836f, -0.062012f,
                0.388184f, -0.035645f, 0.394531f, -0.009277f,
                0.394531f, 0.024414f, 0.394531f, 0.072266f,
                0.357422f, 0.040039f, 0.321777f, 0.024658f,
                0.286133f, 0.009277f, 0.232422f, 0.009277f,
                0.139160f, 0.009277f, 0.083984f, 0.078613f,
                0.028809f, 0.147949f, 0.028809f, 0.277832f,
                0.028809f, 0.345703f, 0.047852f, 0.398193f,
                0.066895f, 0.450684f, 0.099121f, 0.487305f,
                0.129883f, 0.522461f, 0.171875f, 0.541504f,
                0.213867f, 0.560547f, 0.258789f, 0.560547f,
                0.301270f, 0.560547f, 0.332275f, 0.550537f,
                0.363281f, 0.540527f, 0.394531f, 0.521973f,
                0.399902f, 0.545410f, 0.486328f, 0.545410f,
                0.486328f, 0.062012f, 0.486328f, -0.076660f,
                0.425781f, -0.141602f, 0.365234f, -0.206543f,
                0.240723f, -0.206543f, 0.200684f, -0.206543f,
                0.158936f, -0.200195f, 0.117188f, -0.193848f,
                0.081055f, -0.183105f, 0.081055f, -0.087402f,
                0.085938f, -0.087402f
            };

        private static readonly byte[] TahomaGlyph104Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph104Coordinates =
            {
                0.495117f, 0.000000f, 0.403320f, 0.000000f,
                0.403320f, 0.310547f, 0.403320f, 0.348145f,
                0.399658f, 0.380615f, 0.395996f, 0.413086f,
                0.385742f, 0.432617f, 0.374512f, 0.453125f,
                0.354492f, 0.463135f, 0.334473f, 0.473145f,
                0.299805f, 0.473145f, 0.265625f, 0.473145f,
                0.229248f, 0.454834f, 0.192871f, 0.436523f,
                0.158203f, 0.407227f, 0.158203f, 0.000000f,
                0.066406f, 0.000000f, 0.066406f, 0.759766f,
                0.158203f, 0.759766f, 0.158203f, 0.484863f,
                0.199219f, 0.521484f, 0.239258f, 0.541016f,
                0.279297f, 0.560547f, 0.323730f, 0.560547f,
                0.404297f, 0.560547f, 0.449707f, 0.507568f,
                0.495117f, 0.454590f, 0.495117f, 0.354004f,
                0.495117f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph105Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph105Coordinates =
            {
                0.160156f, 0.000000f, 0.068359f, 0.000000f,
                0.068359f, 0.545410f, 0.160156f, 0.545410f,
                0.160156f, 0.000000f, 0.166504f, 0.636719f,
                0.062012f, 0.636719f, 0.062012f, 0.731934f,
                0.166504f, 0.731934f, 0.166504f, 0.636719f
            };

        private static readonly byte[] TahomaGlyph106Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph106Coordinates =
            {
                0.215332f, -0.015625f, 0.215332f, -0.108887f,
                0.165283f, -0.157715f, 0.115234f, -0.206543f,
                0.027344f, -0.206543f, 0.012207f, -0.206543f,
                -0.006592f, -0.205078f, -0.025391f, -0.203613f,
                -0.043945f, -0.200684f, -0.043945f, -0.118652f,
                -0.038574f, -0.118652f, -0.027832f, -0.121094f,
                -0.014893f, -0.123291f, -0.001953f, -0.125488f,
                0.009766f, -0.125488f, 0.046387f, -0.125488f,
                0.070068f, -0.116455f, 0.093750f, -0.107422f,
                0.105469f, -0.087891f, 0.116211f, -0.070313f,
                0.119873f, -0.043457f, 0.123535f, -0.016602f,
                0.123535f, 0.021973f, 0.123535f, 0.469238f,
                0.024902f, 0.469238f, 0.024902f, 0.545410f,
                0.215332f, 0.545410f, 0.215332f, -0.015625f,
                0.215820f, 0.636719f, 0.111328f, 0.636719f,
                0.111328f, 0.731934f, 0.215820f, 0.731934f,
                0.215820f, 0.636719f
            };

        private static readonly byte[] TahomaGlyph107Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph107Coordinates =
            {
                0.518555f, 0.000000f, 0.397949f, 0.000000f,
                0.194336f, 0.263184f, 0.158203f, 0.228027f,
                0.158203f, 0.000000f, 0.066406f, 0.000000f,
                0.066406f, 0.759766f, 0.158203f, 0.759766f,
                0.158203f, 0.314941f, 0.374023f, 0.545410f,
                0.488281f, 0.545410f, 0.264160f, 0.317383f,
                0.518555f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph108Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph108Coordinates =
            {
                0.160156f, 0.000000f, 0.068359f, 0.000000f,
                0.068359f, 0.759766f, 0.160156f, 0.759766f,
                0.160156f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph109Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph109Coordinates =
            {
                0.685547f, 0.000000f, 0.685547f, 0.315430f,
                0.685547f, 0.353027f, 0.682617f, 0.385010f,
                0.679688f, 0.416992f, 0.670410f, 0.435059f,
                0.660645f, 0.454590f, 0.642578f, 0.463867f,
                0.624512f, 0.473145f, 0.593750f, 0.473145f,
                0.565430f, 0.473145f, 0.532959f, 0.455811f,
                0.500488f, 0.438477f, 0.465820f, 0.405762f,
                0.466309f, 0.397461f, 0.467041f, 0.385986f,
                0.467773f, 0.374512f, 0.467773f, 0.358887f,
                0.467773f, 0.000000f, 0.375977f, 0.000000f,
                0.375977f, 0.315430f, 0.375977f, 0.353027f,
                0.373047f, 0.385010f, 0.370117f, 0.416992f,
                0.360840f, 0.435059f, 0.351074f, 0.454590f,
                0.333008f, 0.463867f, 0.314941f, 0.473145f,
                0.284180f, 0.473145f, 0.254395f, 0.473145f,
                0.221680f, 0.454590f, 0.188965f, 0.436035f,
                0.158203f, 0.407227f, 0.158203f, 0.000000f,
                0.066406f, 0.000000f, 0.066406f, 0.545410f,
                0.158203f, 0.545410f, 0.158203f, 0.484863f,
                0.194336f, 0.520996f, 0.229736f, 0.540771f,
                0.265137f, 0.560547f, 0.307617f, 0.560547f,
                0.355957f, 0.560547f, 0.393311f, 0.538574f,
                0.430664f, 0.516602f, 0.450195f, 0.466309f,
                0.491699f, 0.512695f, 0.531250f, 0.536621f,
                0.570801f, 0.560547f, 0.617188f, 0.560547f,
                0.652344f, 0.560547f, 0.681152f, 0.549561f,
                0.709961f, 0.538574f, 0.731445f, 0.514160f,
                0.753418f, 0.489258f, 0.765381f, 0.452148f,
                0.777344f, 0.415039f, 0.777344f, 0.358887f,
                0.777344f, 0.000000f, 0.685547f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph110Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph110Coordinates =
            {
                0.495117f, 0.000000f, 0.403320f, 0.000000f,
                0.403320f, 0.310547f, 0.403320f, 0.348145f,
                0.399658f, 0.380615f, 0.395996f, 0.413086f,
                0.385742f, 0.432617f, 0.374512f, 0.453125f,
                0.354492f, 0.463135f, 0.334473f, 0.473145f,
                0.299805f, 0.473145f, 0.265625f, 0.473145f,
                0.229248f, 0.454834f, 0.192871f, 0.436523f,
                0.158203f, 0.407227f, 0.158203f, 0.000000f,
                0.066406f, 0.000000f, 0.066406f, 0.545410f,
                0.158203f, 0.545410f, 0.158203f, 0.484863f,
                0.199219f, 0.521484f, 0.239258f, 0.541016f,
                0.279297f, 0.560547f, 0.323730f, 0.560547f,
                0.404297f, 0.560547f, 0.449707f, 0.507568f,
                0.495117f, 0.454590f, 0.495117f, 0.354004f,
                0.495117f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph111Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph111Coordinates =
            {
                0.515137f, 0.272461f, 0.515137f, 0.134766f,
                0.448730f, 0.059814f, 0.382324f, -0.015137f,
                0.271973f, -0.015137f, 0.158203f, -0.015137f,
                0.093018f, 0.062256f, 0.027832f, 0.139648f,
                0.027832f, 0.272461f, 0.027832f, 0.409180f,
                0.094971f, 0.484863f, 0.162109f, 0.560547f,
                0.271973f, 0.560547f, 0.382324f, 0.560547f,
                0.448730f, 0.485107f, 0.515137f, 0.409668f,
                0.515137f, 0.272461f, 0.420410f, 0.272461f,
                0.420410f, 0.378418f, 0.381836f, 0.429932f,
                0.343262f, 0.481445f, 0.271973f, 0.481445f,
                0.200195f, 0.481445f, 0.161377f, 0.429932f,
                0.122559f, 0.378418f, 0.122559f, 0.272461f,
                0.122559f, 0.169922f, 0.161377f, 0.116943f,
                0.200195f, 0.063965f, 0.271973f, 0.063965f,
                0.342773f, 0.063965f, 0.381592f, 0.115967f,
                0.420410f, 0.167969f, 0.420410f, 0.272461f
            };

        private static readonly byte[] TahomaGlyph112Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph112Coordinates =
            {
                0.523926f, 0.287109f, 0.523926f, 0.150879f,
                0.458740f, 0.070068f, 0.393555f, -0.010742f,
                0.293945f, -0.010742f, 0.253418f, -0.010742f,
                0.222168f, -0.001465f, 0.190918f, 0.007813f,
                0.158203f, 0.027344f, 0.158203f, -0.201172f,
                0.066406f, -0.201172f, 0.066406f, 0.545410f,
                0.158203f, 0.545410f, 0.158203f, 0.488281f,
                0.192383f, 0.519043f, 0.234131f, 0.539795f,
                0.275879f, 0.560547f, 0.325195f, 0.560547f,
                0.418945f, 0.560547f, 0.471436f, 0.486328f,
                0.523926f, 0.412109f, 0.523926f, 0.287109f,
                0.429199f, 0.276855f, 0.429199f, 0.370117f,
                0.399414f, 0.421631f, 0.369629f, 0.473145f,
                0.302734f, 0.473145f, 0.263672f, 0.473145f,
                0.227295f, 0.455811f, 0.190918f, 0.438477f,
                0.158203f, 0.411133f, 0.158203f, 0.102051f,
                0.194336f, 0.084473f, 0.219971f, 0.078125f,
                0.245605f, 0.071777f, 0.278809f, 0.071777f,
                0.350098f, 0.071777f, 0.389648f, 0.124023f,
                0.429199f, 0.176270f, 0.429199f, 0.276855f
            };

        private static readonly byte[] TahomaGlyph113Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph113Coordinates =
            {
                0.486328f, -0.201172f, 0.394531f, -0.201172f,
                0.394531f, 0.059570f, 0.354492f, 0.022949f,
                0.316406f, 0.006104f, 0.278320f, -0.010742f,
                0.231934f, -0.010742f, 0.139160f, -0.010742f,
                0.083984f, 0.063721f, 0.028809f, 0.138184f,
                0.028809f, 0.270996f, 0.028809f, 0.341309f,
                0.048096f, 0.395264f, 0.067383f, 0.449219f,
                0.099121f, 0.485840f, 0.129395f, 0.521484f,
                0.171387f, 0.541016f, 0.213379f, 0.560547f,
                0.258789f, 0.560547f, 0.300781f, 0.560547f,
                0.331543f, 0.550781f, 0.362305f, 0.541016f,
                0.394531f, 0.521973f, 0.400391f, 0.545410f,
                0.486328f, 0.545410f, 0.486328f, -0.201172f,
                0.394531f, 0.136719f, 0.394531f, 0.447266f,
                0.359863f, 0.464355f, 0.332520f, 0.471191f,
                0.305176f, 0.478027f, 0.273926f, 0.478027f,
                0.201660f, 0.478027f, 0.162598f, 0.425781f,
                0.123535f, 0.373535f, 0.123535f, 0.275391f,
                0.123535f, 0.179688f, 0.154785f, 0.128174f,
                0.186035f, 0.076660f, 0.251953f, 0.076660f,
                0.290527f, 0.076660f, 0.327148f, 0.093262f,
                0.363770f, 0.109863f, 0.394531f, 0.136719f
            };

        private static readonly byte[] TahomaGlyph114Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph114Coordinates =
            {
                0.355469f, 0.446777f, 0.350586f, 0.446777f,
                0.340332f, 0.449707f, 0.328857f, 0.450439f,
                0.317383f, 0.451172f, 0.301270f, 0.451172f,
                0.264160f, 0.451172f, 0.227539f, 0.435059f,
                0.190918f, 0.418945f, 0.158203f, 0.387207f,
                0.158203f, 0.000000f, 0.066406f, 0.000000f,
                0.066406f, 0.545410f, 0.158203f, 0.545410f,
                0.158203f, 0.464355f, 0.208496f, 0.508789f,
                0.245850f, 0.527100f, 0.283203f, 0.545410f,
                0.318359f, 0.545410f, 0.332520f, 0.545410f,
                0.339600f, 0.544678f, 0.346680f, 0.543945f,
                0.355469f, 0.542480f, 0.355469f, 0.446777f
            };

        private static readonly byte[] TahomaGlyph115Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph115Coordinates =
            {
                0.213867f, -0.013184f, 0.159180f, -0.013184f,
                0.111572f, 0.001465f, 0.063965f, 0.016113f,
                0.032715f, 0.032715f, 0.032715f, 0.135742f,
                0.037598f, 0.135742f, 0.049316f, 0.126465f,
                0.065186f, 0.115234f, 0.081055f, 0.104004f,
                0.107422f, 0.091797f, 0.130859f, 0.081055f,
                0.158936f, 0.072754f, 0.187012f, 0.064453f,
                0.217285f, 0.064453f, 0.239258f, 0.064453f,
                0.264160f, 0.069580f, 0.289063f, 0.074707f,
                0.301270f, 0.082520f, 0.318359f, 0.093750f,
                0.325928f, 0.106445f, 0.333496f, 0.119141f,
                0.333496f, 0.144531f, 0.333496f, 0.177246f,
                0.315674f, 0.193848f, 0.297852f, 0.210449f,
                0.252441f, 0.221680f, 0.234863f, 0.226074f,
                0.206543f, 0.231934f, 0.178223f, 0.237793f,
                0.154297f, 0.244629f, 0.091797f, 0.262695f,
                0.063477f, 0.300537f, 0.035156f, 0.338379f,
                0.035156f, 0.392090f, 0.035156f, 0.465820f,
                0.090820f, 0.512207f, 0.146484f, 0.558594f,
                0.238770f, 0.558594f, 0.284180f, 0.558594f,
                0.330078f, 0.547363f, 0.375977f, 0.536133f,
                0.407227f, 0.519043f, 0.407227f, 0.420898f,
                0.402344f, 0.420898f, 0.367188f, 0.448730f,
                0.323975f, 0.464844f, 0.280762f, 0.480957f,
                0.236816f, 0.480957f, 0.191406f, 0.480957f,
                0.160156f, 0.461914f, 0.128906f, 0.442871f,
                0.128906f, 0.404297f, 0.128906f, 0.370117f,
                0.147461f, 0.353271f, 0.166016f, 0.336426f,
                0.207031f, 0.325684f, 0.227539f, 0.320313f,
                0.252686f, 0.315186f, 0.277832f, 0.310059f,
                0.305664f, 0.303223f, 0.366211f, 0.288086f,
                0.396729f, 0.252930f, 0.427246f, 0.217773f,
                0.427246f, 0.157227f, 0.427246f, 0.122070f,
                0.413330f, 0.090576f, 0.399414f, 0.059082f,
                0.372559f, 0.036621f, 0.343262f, 0.012207f,
                0.306396f, -0.000488f, 0.269531f, -0.013184f,
                0.213867f, -0.013184f
            };

        private static readonly byte[] TahomaGlyph116Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph116Coordinates =
            {
                0.231445f, -0.010742f, 0.156250f, -0.010742f,
                0.114258f, 0.031982f, 0.072266f, 0.074707f,
                0.072266f, 0.166992f, 0.072266f, 0.469238f,
                0.010254f, 0.469238f, 0.010254f, 0.545410f,
                0.072266f, 0.545410f, 0.072266f, 0.702148f,
                0.164063f, 0.702148f, 0.164063f, 0.545410f,
                0.333008f, 0.545410f, 0.333008f, 0.469238f,
                0.164063f, 0.469238f, 0.164063f, 0.209961f,
                0.164063f, 0.168457f, 0.165527f, 0.145996f,
                0.166992f, 0.123535f, 0.176758f, 0.104004f,
                0.185059f, 0.086914f, 0.203613f, 0.078369f,
                0.222168f, 0.069824f, 0.253906f, 0.069824f,
                0.276367f, 0.069824f, 0.297363f, 0.076416f,
                0.318359f, 0.083008f, 0.327637f, 0.087402f,
                0.333008f, 0.087402f, 0.333008f, 0.004883f,
                0.307129f, -0.002441f, 0.280518f, -0.006592f,
                0.253906f, -0.010742f, 0.231445f, -0.010742f
            };

        private static readonly byte[] TahomaGlyph117Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph117Coordinates =
            {
                0.491211f, 0.000000f, 0.399414f, 0.000000f,
                0.399414f, 0.060547f, 0.356934f, 0.023438f,
                0.318848f, 0.004150f, 0.280762f, -0.015137f,
                0.233887f, -0.015137f, 0.198242f, -0.015137f,
                0.166748f, -0.003418f, 0.135254f, 0.008301f,
                0.111816f, 0.033691f, 0.088379f, 0.059082f,
                0.075439f, 0.097656f, 0.062500f, 0.136230f,
                0.062500f, 0.191406f, 0.062500f, 0.545410f,
                0.154297f, 0.545410f, 0.154297f, 0.234863f,
                0.154297f, 0.191406f, 0.157471f, 0.162842f,
                0.160645f, 0.134277f, 0.171875f, 0.112793f,
                0.183105f, 0.091797f, 0.202393f, 0.082031f,
                0.221680f, 0.072266f, 0.257813f, 0.072266f,
                0.291504f, 0.072266f, 0.329590f, 0.091309f,
                0.367676f, 0.110352f, 0.399414f, 0.138184f,
                0.399414f, 0.545410f, 0.491211f, 0.545410f,
                0.491211f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph118Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph118Coordinates =
            {
                0.495117f, 0.545410f, 0.289551f, 0.000000f,
                0.207031f, 0.000000f, 0.002930f, 0.545410f,
                0.102051f, 0.545410f, 0.251465f, 0.124512f,
                0.399414f, 0.545410f, 0.495117f, 0.545410f
            };

        private static readonly byte[] TahomaGlyph119Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph119Coordinates =
            {
                0.727539f, 0.545410f, 0.589355f, 0.000000f,
                0.504395f, 0.000000f, 0.371094f, 0.420410f,
                0.238770f, 0.000000f, 0.154297f, 0.000000f,
                0.014648f, 0.545410f, 0.110352f, 0.545410f,
                0.206543f, 0.123047f, 0.335938f, 0.545410f,
                0.411621f, 0.545410f, 0.544434f, 0.123047f,
                0.635254f, 0.545410f, 0.727539f, 0.545410f
            };

        private static readonly byte[] TahomaGlyph120Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph120Coordinates =
            {
                0.490234f, 0.000000f, 0.377441f, 0.000000f,
                0.245117f, 0.206055f, 0.108887f, 0.000000f,
                0.004883f, 0.000000f, 0.194336f, 0.270508f,
                0.006836f, 0.545410f, 0.119629f, 0.545410f,
                0.250977f, 0.341309f, 0.385742f, 0.545410f,
                0.490234f, 0.545410f, 0.301758f, 0.276855f,
                0.490234f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph121Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph121Coordinates =
            {
                0.495117f, 0.545410f, 0.201660f, -0.201172f,
                0.103516f, -0.201172f, 0.201172f, 0.026367f,
                0.002930f, 0.545410f, 0.102051f, 0.545410f,
                0.250977f, 0.141602f, 0.399414f, 0.545410f,
                0.495117f, 0.545410f
            };

        private static readonly byte[] TahomaGlyph122Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph122Coordinates =
            {
                0.424805f, 0.000000f, 0.023926f, 0.000000f,
                0.023926f, 0.067871f, 0.309082f, 0.469727f,
                0.035645f, 0.469727f, 0.035645f, 0.545410f,
                0.419434f, 0.545410f, 0.419434f, 0.479980f,
                0.132813f, 0.076660f, 0.424805f, 0.076660f,
                0.424805f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph123Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph123Coordinates =
            {
                0.432617f, -0.191406f, 0.375977f, -0.191406f,
                0.288574f, -0.191406f, 0.239014f, -0.143311f,
                0.189453f, -0.095215f, 0.189453f, -0.002441f,
                0.189453f, 0.070313f, 0.189453f, 0.104004f,
                0.183105f, 0.138184f, 0.176758f, 0.172363f,
                0.158691f, 0.196777f, 0.140625f, 0.221191f,
                0.111572f, 0.233643f, 0.082520f, 0.246094f,
                0.039551f, 0.246094f, 0.029297f, 0.246094f,
                0.029297f, 0.322266f, 0.039551f, 0.322266f,
                0.082520f, 0.322266f, 0.111572f, 0.334717f,
                0.140625f, 0.347168f, 0.158691f, 0.371582f,
                0.176758f, 0.395996f, 0.183105f, 0.430176f,
                0.189453f, 0.464355f, 0.189453f, 0.498047f,
                0.189453f, 0.570801f, 0.189453f, 0.663574f,
                0.239014f, 0.711670f, 0.288574f, 0.759766f,
                0.375977f, 0.759766f, 0.432617f, 0.759766f,
                0.432617f, 0.692383f, 0.393555f, 0.692383f,
                0.364746f, 0.692383f, 0.343750f, 0.686523f,
                0.322754f, 0.680664f, 0.307617f, 0.666504f,
                0.291992f, 0.651855f, 0.284424f, 0.625977f,
                0.276855f, 0.600098f, 0.276855f, 0.562500f,
                0.276855f, 0.477051f, 0.276855f, 0.437012f,
                0.267578f, 0.409668f, 0.258301f, 0.382324f,
                0.240234f, 0.358398f, 0.224121f, 0.336914f,
                0.198242f, 0.319092f, 0.172363f, 0.301270f,
                0.144531f, 0.290039f, 0.144531f, 0.278320f,
                0.172363f, 0.267090f, 0.197998f, 0.249268f,
                0.223633f, 0.231445f, 0.240234f, 0.209961f,
                0.258301f, 0.186035f, 0.267578f, 0.158691f,
                0.276855f, 0.131348f, 0.276855f, 0.091309f,
                0.276855f, 0.005859f, 0.276855f, -0.031738f,
                0.284424f, -0.057617f, 0.291992f, -0.083496f,
                0.307617f, -0.098145f, 0.322266f, -0.112305f,
                0.343506f, -0.118164f, 0.364746f, -0.124023f,
                0.393555f, -0.124023f, 0.432617f, -0.124023f,
                0.432617f, -0.191406f
            };

        private static readonly byte[] TahomaGlyph124Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph124Coordinates =
            {
                0.231934f, -0.191406f, 0.150391f, -0.191406f,
                0.150391f, 0.759766f, 0.231934f, 0.759766f,
                0.231934f, -0.191406f
            };

        private static readonly byte[] TahomaGlyph125Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph125Coordinates =
            {
                0.451172f, 0.246094f, 0.440918f, 0.246094f,
                0.397949f, 0.246094f, 0.368896f, 0.233643f,
                0.339844f, 0.221191f, 0.321777f, 0.196777f,
                0.303711f, 0.172363f, 0.297363f, 0.138184f,
                0.291016f, 0.104004f, 0.291016f, 0.070313f,
                0.291016f, -0.002441f, 0.291016f, -0.095215f,
                0.241455f, -0.143311f, 0.191895f, -0.191406f,
                0.104492f, -0.191406f, 0.047852f, -0.191406f,
                0.047852f, -0.124023f, 0.086914f, -0.124023f,
                0.115723f, -0.124023f, 0.136719f, -0.118164f,
                0.157715f, -0.112305f, 0.172852f, -0.098145f,
                0.188477f, -0.083496f, 0.196045f, -0.057617f,
                0.203613f, -0.031738f, 0.203613f, 0.005859f,
                0.203613f, 0.091309f, 0.203613f, 0.131348f,
                0.212891f, 0.158691f, 0.222168f, 0.186035f,
                0.240234f, 0.209961f, 0.256348f, 0.231445f,
                0.282227f, 0.249268f, 0.308105f, 0.267090f,
                0.335938f, 0.278320f, 0.335938f, 0.290039f,
                0.308105f, 0.301270f, 0.282227f, 0.319092f,
                0.256348f, 0.336914f, 0.240234f, 0.358398f,
                0.222168f, 0.382324f, 0.212891f, 0.409668f,
                0.203613f, 0.437012f, 0.203613f, 0.477051f,
                0.203613f, 0.562500f, 0.203613f, 0.600098f,
                0.196045f, 0.625977f, 0.188477f, 0.651855f,
                0.172852f, 0.666504f, 0.157715f, 0.680664f,
                0.136719f, 0.686523f, 0.115723f, 0.692383f,
                0.086914f, 0.692383f, 0.047852f, 0.692383f,
                0.047852f, 0.759766f, 0.104492f, 0.759766f,
                0.191895f, 0.759766f, 0.241455f, 0.711670f,
                0.291016f, 0.663574f, 0.291016f, 0.570801f,
                0.291016f, 0.498047f, 0.291016f, 0.464355f,
                0.297363f, 0.430176f, 0.303711f, 0.395996f,
                0.321777f, 0.371582f, 0.339844f, 0.347168f,
                0.368896f, 0.334717f, 0.397949f, 0.322266f,
                0.440918f, 0.322266f, 0.451172f, 0.322266f,
                0.451172f, 0.246094f
            };

        private static readonly byte[] TahomaGlyph126Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph126Coordinates =
            {
                0.662109f, 0.452637f, 0.661133f, 0.402832f,
                0.651855f, 0.356689f, 0.642578f, 0.310547f,
                0.622559f, 0.273926f, 0.602539f, 0.238281f,
                0.572754f, 0.215820f, 0.542969f, 0.193359f,
                0.495117f, 0.193359f, 0.467285f, 0.193359f,
                0.445068f, 0.200928f, 0.422852f, 0.208496f,
                0.405762f, 0.220703f, 0.388672f, 0.232910f,
                0.373047f, 0.250000f, 0.357422f, 0.267090f,
                0.345215f, 0.281738f, 0.332031f, 0.297852f,
                0.319336f, 0.314453f, 0.306641f, 0.331055f,
                0.294434f, 0.343750f, 0.281250f, 0.357422f,
                0.267090f, 0.365723f, 0.252930f, 0.374023f,
                0.234863f, 0.374023f, 0.210449f, 0.374023f,
                0.194336f, 0.361084f, 0.178223f, 0.348145f,
                0.167480f, 0.322754f, 0.157227f, 0.298340f,
                0.153076f, 0.264160f, 0.148926f, 0.229980f,
                0.147461f, 0.192871f, 0.065430f, 0.192871f,
                0.066406f, 0.243652f, 0.075928f, 0.290039f,
                0.085449f, 0.336426f, 0.104492f, 0.371582f,
                0.124023f, 0.408691f, 0.156250f, 0.430420f,
                0.188477f, 0.452148f, 0.232422f, 0.452148f,
                0.261719f, 0.452148f, 0.283936f, 0.444336f,
                0.306152f, 0.436523f, 0.323242f, 0.424316f,
                0.340332f, 0.412109f, 0.354736f, 0.396484f,
                0.369141f, 0.380859f, 0.382813f, 0.363770f,
                0.393555f, 0.350586f, 0.408447f, 0.331543f,
                0.423340f, 0.312500f, 0.433594f, 0.301758f,
                0.447754f, 0.287109f, 0.462158f, 0.279297f,
                0.476563f, 0.271484f, 0.492676f, 0.271484f,
                0.517090f, 0.271484f, 0.533936f, 0.285156f,
                0.550781f, 0.298828f, 0.560059f, 0.322266f,
                0.569824f, 0.346680f, 0.574463f, 0.379639f,
                0.579102f, 0.412598f, 0.580078f, 0.452637f,
                0.662109f, 0.452637f
            };

        private static readonly byte[] TahomaGlyph161Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph161Coordinates =
            {
                0.215820f, 0.624023f, 0.116211f, 0.624023f,
                0.116211f, 0.727051f, 0.215820f, 0.727051f,
                0.215820f, 0.624023f, 0.220703f, 0.000000f,
                0.111328f, 0.000000f, 0.125000f, 0.526855f,
                0.206055f, 0.526855f, 0.220703f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph162Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph162Coordinates =
            {
                0.271973f, 0.000977f, 0.166992f, 0.013184f,
                0.111328f, 0.083496f, 0.055664f, 0.153809f,
                0.055664f, 0.271973f, 0.055664f, 0.388184f,
                0.113281f, 0.460449f, 0.170898f, 0.532715f,
                0.271973f, 0.544434f, 0.271973f, 0.720215f,
                0.327637f, 0.720215f, 0.327637f, 0.544922f,
                0.370117f, 0.543457f, 0.409424f, 0.531982f,
                0.448730f, 0.520508f, 0.476074f, 0.506348f,
                0.476074f, 0.408691f, 0.471191f, 0.408691f,
                0.440918f, 0.433594f, 0.406738f, 0.452148f,
                0.372559f, 0.470703f, 0.327637f, 0.477051f,
                0.327637f, 0.068848f, 0.351563f, 0.071289f,
                0.375732f, 0.080078f, 0.399902f, 0.088867f,
                0.416504f, 0.098633f, 0.434082f, 0.108887f,
                0.447754f, 0.118896f, 0.461426f, 0.128906f,
                0.471191f, 0.137207f, 0.476074f, 0.137207f,
                0.476074f, 0.040527f, 0.444336f, 0.025879f,
                0.409912f, 0.014404f, 0.375488f, 0.002930f,
                0.327637f, 0.000488f, 0.327637f, -0.176270f,
                0.271973f, -0.176270f, 0.271973f, 0.000977f,
                0.271973f, 0.071289f, 0.271973f, 0.474121f,
                0.215332f, 0.463867f, 0.182617f, 0.412842f,
                0.149902f, 0.361816f, 0.149902f, 0.271973f,
                0.149902f, 0.180176f, 0.183350f, 0.130615f,
                0.216797f, 0.081055f, 0.271973f, 0.071289f
            };

        private static readonly byte[] TahomaGlyph163Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph163Coordinates =
            {
                0.503418f, 0.000000f, 0.043457f, 0.000000f,
                0.043457f, 0.101074f, 0.097656f, 0.117188f,
                0.119873f, 0.163574f, 0.142090f, 0.209961f,
                0.142090f, 0.299316f, 0.063477f, 0.299316f,
                0.063477f, 0.366699f, 0.142090f, 0.366699f,
                0.142090f, 0.522949f, 0.142090f, 0.621094f,
                0.198730f, 0.681152f, 0.255371f, 0.741211f,
                0.345703f, 0.741211f, 0.393066f, 0.741211f,
                0.426758f, 0.733643f, 0.460449f, 0.726074f,
                0.488770f, 0.717773f, 0.488770f, 0.617188f,
                0.483887f, 0.617188f, 0.455566f, 0.637207f,
                0.420898f, 0.648438f, 0.386230f, 0.659668f,
                0.354980f, 0.659668f, 0.294922f, 0.659668f,
                0.265381f, 0.622070f, 0.235840f, 0.584473f,
                0.235840f, 0.513672f, 0.235840f, 0.366699f,
                0.413574f, 0.366699f, 0.413574f, 0.299316f,
                0.235840f, 0.299316f, 0.235840f, 0.269531f,
                0.235840f, 0.212402f, 0.207275f, 0.165771f,
                0.178711f, 0.119141f, 0.127441f, 0.088867f,
                0.127441f, 0.083496f, 0.503418f, 0.083496f,
                0.503418f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph164Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph164Coordinates =
            {
                0.516113f, 0.132813f, 0.464355f, 0.081055f,
                0.359863f, 0.184570f, 0.337891f, 0.171387f,
                0.318848f, 0.165283f, 0.299805f, 0.159180f,
                0.273438f, 0.159180f, 0.250977f, 0.159180f,
                0.228271f, 0.166504f, 0.205566f, 0.173828f,
                0.187988f, 0.185059f, 0.083008f, 0.080078f,
                0.031738f, 0.133301f, 0.135254f, 0.237305f,
                0.123047f, 0.256836f, 0.116455f, 0.279541f,
                0.109863f, 0.302246f, 0.109863f, 0.322754f,
                0.109863f, 0.344238f, 0.116455f, 0.365967f,
                0.123047f, 0.387695f, 0.135742f, 0.407715f,
                0.031738f, 0.513184f, 0.083984f, 0.564941f,
                0.188477f, 0.460938f, 0.206543f, 0.472656f,
                0.229004f, 0.479492f, 0.251465f, 0.486328f,
                0.273438f, 0.486328f, 0.298828f, 0.486328f,
                0.321045f, 0.478760f, 0.343262f, 0.471191f,
                0.359375f, 0.461426f, 0.462891f, 0.564941f,
                0.516113f, 0.513672f, 0.411621f, 0.408203f,
                0.424805f, 0.387207f, 0.431152f, 0.367676f,
                0.437500f, 0.348145f, 0.437500f, 0.322754f,
                0.437500f, 0.300781f, 0.430420f, 0.278076f,
                0.423340f, 0.255371f, 0.411621f, 0.237305f,
                0.516113f, 0.132813f, 0.367188f, 0.322754f,
                0.367188f, 0.361816f, 0.339600f, 0.390381f,
                0.312012f, 0.418945f, 0.273438f, 0.418945f,
                0.235840f, 0.418945f, 0.207764f, 0.390869f,
                0.179688f, 0.362793f, 0.179688f, 0.322754f,
                0.179688f, 0.283691f, 0.207275f, 0.255127f,
                0.234863f, 0.226563f, 0.273438f, 0.226563f,
                0.311035f, 0.226563f, 0.339111f, 0.254639f,
                0.367188f, 0.282715f, 0.367188f, 0.322754f
            };

        private static readonly byte[] TahomaGlyph165Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph165Coordinates =
            {
                0.517090f, 0.727051f, 0.317871f, 0.331055f,
                0.317871f, 0.282227f, 0.484863f, 0.282227f,
                0.484863f, 0.214844f, 0.318848f, 0.214844f,
                0.318848f, 0.000000f, 0.227051f, 0.000000f,
                0.227051f, 0.214844f, 0.061035f, 0.214844f,
                0.061035f, 0.282227f, 0.228027f, 0.282227f,
                0.228027f, 0.320801f, 0.027344f, 0.727051f,
                0.129883f, 0.727051f, 0.273438f, 0.415039f,
                0.418945f, 0.727051f, 0.517090f, 0.727051f
            };

        private static readonly byte[] TahomaGlyph166Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph166Coordinates =
            {
                0.231934f, 0.370117f, 0.150391f, 0.370117f,
                0.150391f, 0.759766f, 0.231934f, 0.759766f,
                0.231934f, 0.370117f, 0.231934f, -0.191406f,
                0.150391f, -0.191406f, 0.150391f, 0.198242f,
                0.231934f, 0.198242f, 0.231934f, -0.191406f
            };

        private static readonly byte[] TahomaGlyph167Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph167Coordinates =
            {
                0.370605f, 0.195801f, 0.382324f, 0.212891f,
                0.388916f, 0.228760f, 0.395508f, 0.244629f,
                0.395508f, 0.270996f, 0.395508f, 0.294922f,
                0.388428f, 0.312500f, 0.381348f, 0.330078f,
                0.369141f, 0.341309f, 0.357422f, 0.352539f,
                0.341797f, 0.360107f, 0.326172f, 0.367676f,
                0.305664f, 0.374023f, 0.289551f, 0.378906f,
                0.268066f, 0.385010f, 0.246582f, 0.391113f,
                0.219727f, 0.399902f, 0.209961f, 0.394043f,
                0.199463f, 0.385254f, 0.188965f, 0.376465f,
                0.176270f, 0.360352f, 0.166504f, 0.347656f,
                0.158447f, 0.326172f, 0.150391f, 0.304688f,
                0.150391f, 0.282715f, 0.150391f, 0.243164f,
                0.168945f, 0.219727f, 0.187500f, 0.196289f,
                0.240234f, 0.180176f, 0.256836f, 0.175293f,
                0.278076f, 0.168701f, 0.299316f, 0.162109f,
                0.325684f, 0.153809f, 0.334961f, 0.159668f,
                0.347168f, 0.169922f, 0.359375f, 0.180176f,
                0.370605f, 0.195801f, 0.088867f, -0.064941f,
                0.101563f, -0.071289f, 0.120361f, -0.079102f,
                0.139160f, -0.086914f, 0.156738f, -0.092773f,
                0.179688f, -0.100098f, 0.199219f, -0.103760f,
                0.218750f, -0.107422f, 0.248535f, -0.107422f,
                0.304199f, -0.107422f, 0.341553f, -0.084717f,
                0.378906f, -0.062012f, 0.378906f, -0.017578f,
                0.378906f, 0.008789f, 0.369873f, 0.025146f,
                0.360840f, 0.041504f, 0.340820f, 0.054199f,
                0.320313f, 0.066406f, 0.290283f, 0.074951f,
                0.260254f, 0.083496f, 0.224609f, 0.093750f,
                0.181641f, 0.105957f, 0.153076f, 0.118652f,
                0.124512f, 0.131348f, 0.101563f, 0.152344f,
                0.079590f, 0.172363f, 0.068848f, 0.198730f,
                0.058105f, 0.225098f, 0.058105f, 0.260254f,
                0.058105f, 0.306152f, 0.082031f, 0.347412f,
                0.105957f, 0.388672f, 0.155273f, 0.418945f,
                0.155273f, 0.422363f, 0.110840f, 0.446777f,
                0.091553f, 0.481445f, 0.072266f, 0.516113f,
                0.072266f, 0.560059f, 0.072266f, 0.642090f,
                0.134766f, 0.691895f, 0.197266f, 0.741699f,
                0.306641f, 0.741699f, 0.348145f, 0.741699f,
                0.383301f, 0.735352f, 0.418457f, 0.729004f,
                0.461914f, 0.713867f, 0.461914f, 0.619141f,
                0.457031f, 0.619141f, 0.413086f, 0.641113f,
                0.375244f, 0.651367f, 0.337402f, 0.661621f,
                0.296387f, 0.661621f, 0.241699f, 0.661621f,
                0.203857f, 0.639404f, 0.166016f, 0.617188f,
                0.166016f, 0.574219f, 0.166016f, 0.546387f,
                0.176025f, 0.528809f, 0.186035f, 0.511230f,
                0.205078f, 0.500000f, 0.224121f, 0.488281f,
                0.253662f, 0.479004f, 0.283203f, 0.469727f,
                0.320801f, 0.459961f, 0.410645f, 0.435547f,
                0.448975f, 0.397217f, 0.487305f, 0.358887f,
                0.487305f, 0.293457f, 0.487305f, 0.240723f,
                0.460693f, 0.201172f, 0.434082f, 0.161621f,
                0.390137f, 0.135254f, 0.390137f, 0.131836f,
                0.432617f, 0.109375f, 0.452881f, 0.075195f,
                0.473145f, 0.041016f, 0.473145f, -0.004883f,
                0.473145f, -0.041016f, 0.457764f, -0.075684f,
                0.442383f, -0.110352f, 0.414063f, -0.133789f,
                0.383789f, -0.159668f, 0.341553f, -0.173828f,
                0.299316f, -0.187988f, 0.239258f, -0.187988f,
                0.200684f, -0.187988f, 0.162598f, -0.181152f,
                0.124512f, -0.174316f, 0.083984f, -0.159668f,
                0.083984f, -0.064941f, 0.088867f, -0.064941f
            };

        private static readonly byte[] TahomaGlyph168Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph168Coordinates =
            {
                0.423340f, 0.636719f, 0.325195f, 0.636719f,
                0.325195f, 0.731934f, 0.423340f, 0.731934f,
                0.423340f, 0.636719f, 0.221680f, 0.636719f,
                0.123535f, 0.636719f, 0.123535f, 0.731934f,
                0.221680f, 0.731934f, 0.221680f, 0.636719f
            };

        private static readonly byte[] TahomaGlyph169Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph169Coordinates =
            {
                0.886719f, 0.319824f, 0.886719f, 0.145020f,
                0.762939f, 0.021240f, 0.639160f, -0.102539f,
                0.464355f, -0.102539f, 0.289551f, -0.102539f,
                0.165771f, 0.021240f, 0.041992f, 0.145020f,
                0.041992f, 0.319824f, 0.041992f, 0.494629f,
                0.165771f, 0.618164f, 0.289551f, 0.741699f,
                0.464355f, 0.741699f, 0.639160f, 0.741699f,
                0.762939f, 0.618164f, 0.886719f, 0.494629f,
                0.886719f, 0.319824f, 0.830566f, 0.319824f,
                0.830566f, 0.472656f, 0.723389f, 0.580322f,
                0.616211f, 0.687988f, 0.464844f, 0.687988f,
                0.313477f, 0.687988f, 0.206299f, 0.580322f,
                0.099121f, 0.472656f, 0.099121f, 0.319824f,
                0.099121f, 0.166992f, 0.206299f, 0.059082f,
                0.313477f, -0.048828f, 0.464844f, -0.048828f,
                0.616211f, -0.048828f, 0.723389f, 0.059082f,
                0.830566f, 0.166992f, 0.830566f, 0.319824f,
                0.622070f, 0.124512f, 0.589355f, 0.109863f,
                0.556641f, 0.098877f, 0.523926f, 0.087891f,
                0.479492f, 0.087891f, 0.377441f, 0.087891f,
                0.318359f, 0.148193f, 0.259277f, 0.208496f,
                0.259277f, 0.322266f, 0.259277f, 0.434570f,
                0.320313f, 0.496338f, 0.381348f, 0.558105f,
                0.479492f, 0.558105f, 0.520020f, 0.558105f,
                0.557129f, 0.547363f, 0.594238f, 0.536621f,
                0.622070f, 0.522461f, 0.622070f, 0.434082f,
                0.614258f, 0.434082f, 0.593262f, 0.452637f,
                0.556152f, 0.469482f, 0.519043f, 0.486328f,
                0.481445f, 0.486328f, 0.421387f, 0.486328f,
                0.385498f, 0.446289f, 0.349609f, 0.406250f,
                0.349609f, 0.322266f, 0.349609f, 0.243164f,
                0.383789f, 0.201416f, 0.417969f, 0.159668f,
                0.481445f, 0.159668f, 0.522461f, 0.159668f,
                0.559082f, 0.177490f, 0.595703f, 0.195313f,
                0.614258f, 0.211914f, 0.622070f, 0.211914f,
                0.622070f, 0.124512f
            };

        private static readonly byte[] TahomaGlyph170Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph170Coordinates =
            {
                0.426758f, 0.276367f, 0.345703f, 0.276367f,
                0.345703f, 0.320801f, 0.336426f, 0.313477f,
                0.320801f, 0.302002f, 0.305176f, 0.290527f,
                0.290039f, 0.283691f, 0.270020f, 0.274414f,
                0.250732f, 0.269287f, 0.231445f, 0.264160f,
                0.197266f, 0.264160f, 0.136719f, 0.264160f,
                0.096191f, 0.304932f, 0.055664f, 0.345703f,
                0.055664f, 0.409668f, 0.055664f, 0.460449f,
                0.076660f, 0.492432f, 0.097656f, 0.524414f,
                0.136719f, 0.542969f, 0.173340f, 0.560547f,
                0.229004f, 0.567871f, 0.284668f, 0.575195f,
                0.345703f, 0.578125f, 0.345703f, 0.587402f,
                0.345703f, 0.612793f, 0.337646f, 0.628418f,
                0.329590f, 0.644043f, 0.313965f, 0.652832f,
                0.299805f, 0.661133f, 0.278809f, 0.663818f,
                0.257813f, 0.666504f, 0.235352f, 0.666504f,
                0.197266f, 0.666504f, 0.157959f, 0.655029f,
                0.118652f, 0.643555f, 0.099609f, 0.636719f,
                0.092285f, 0.636719f, 0.092285f, 0.719727f,
                0.113770f, 0.726074f, 0.156494f, 0.733887f,
                0.199219f, 0.741699f, 0.235840f, 0.741699f,
                0.329590f, 0.741699f, 0.378174f, 0.704346f,
                0.426758f, 0.666992f, 0.426758f, 0.583008f,
                0.426758f, 0.276367f, 0.345703f, 0.391602f,
                0.345703f, 0.510254f, 0.313965f, 0.508301f,
                0.271973f, 0.504395f, 0.229980f, 0.500488f,
                0.205078f, 0.493164f, 0.175781f, 0.484863f,
                0.157715f, 0.466064f, 0.139648f, 0.447266f,
                0.139648f, 0.414551f, 0.139648f, 0.377930f,
                0.161133f, 0.358887f, 0.182617f, 0.339844f,
                0.225098f, 0.339844f, 0.262207f, 0.339844f,
                0.291748f, 0.355957f, 0.321289f, 0.372070f,
                0.345703f, 0.391602f
            };

        private static readonly byte[] TahomaGlyph171Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph171Coordinates =
            {
                0.509277f, 0.093262f, 0.270996f, 0.297852f,
                0.270996f, 0.339355f, 0.509277f, 0.543457f,
                0.509277f, 0.451660f, 0.354492f, 0.318359f,
                0.509277f, 0.185059f, 0.509277f, 0.093262f,
                0.299316f, 0.079102f, 0.050293f, 0.296875f,
                0.050293f, 0.340332f, 0.299316f, 0.557617f,
                0.299316f, 0.461914f, 0.137695f, 0.318359f,
                0.299316f, 0.174805f, 0.299316f, 0.079102f
            };

        private static readonly byte[] TahomaGlyph172Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph172Coordinates =
            {
                0.645996f, 0.027832f, 0.562500f, 0.027832f,
                0.562500f, 0.293945f, 0.076660f, 0.293945f,
                0.076660f, 0.372070f, 0.645996f, 0.372070f,
                0.645996f, 0.027832f
            };

        private static readonly byte[] TahomaGlyph173Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph173Coordinates =
            {
                0.319336f, 0.273926f, 0.043945f, 0.273926f,
                0.043945f, 0.362305f, 0.319336f, 0.362305f,
                0.319336f, 0.273926f
            };

        private static readonly byte[] TahomaGlyph174Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph174Coordinates =
            {
                0.886719f, 0.319824f, 0.886719f, 0.145020f,
                0.762939f, 0.021240f, 0.639160f, -0.102539f,
                0.464355f, -0.102539f, 0.289551f, -0.102539f,
                0.165771f, 0.021240f, 0.041992f, 0.145020f,
                0.041992f, 0.319824f, 0.041992f, 0.494629f,
                0.165771f, 0.618164f, 0.289551f, 0.741699f,
                0.464355f, 0.741699f, 0.639160f, 0.741699f,
                0.762939f, 0.618164f, 0.886719f, 0.494629f,
                0.886719f, 0.319824f, 0.830566f, 0.319824f,
                0.830566f, 0.472656f, 0.723389f, 0.580322f,
                0.616211f, 0.687988f, 0.464844f, 0.687988f,
                0.313477f, 0.687988f, 0.206299f, 0.580322f,
                0.099121f, 0.472656f, 0.099121f, 0.319824f,
                0.099121f, 0.166992f, 0.206299f, 0.059082f,
                0.313477f, -0.048828f, 0.464844f, -0.048828f,
                0.616211f, -0.048828f, 0.723389f, 0.059082f,
                0.830566f, 0.166992f, 0.830566f, 0.319824f,
                0.707031f, 0.104980f, 0.596191f, 0.104980f,
                0.458008f, 0.278320f, 0.397949f, 0.278320f,
                0.397949f, 0.104980f, 0.317383f, 0.104980f,
                0.317383f, 0.551758f, 0.453613f, 0.551758f,
                0.499512f, 0.551758f, 0.526123f, 0.548340f,
                0.552734f, 0.544922f, 0.580078f, 0.529297f,
                0.609375f, 0.512695f, 0.622559f, 0.489258f,
                0.635742f, 0.465820f, 0.635742f, 0.429199f,
                0.635742f, 0.380371f, 0.608643f, 0.349121f,
                0.581543f, 0.317871f, 0.538086f, 0.300293f,
                0.707031f, 0.104980f, 0.546875f, 0.423828f,
                0.546875f, 0.441895f, 0.541016f, 0.455078f,
                0.535156f, 0.468262f, 0.520508f, 0.477539f,
                0.508301f, 0.485352f, 0.493164f, 0.488037f,
                0.478027f, 0.490723f, 0.454102f, 0.490723f,
                0.397949f, 0.490723f, 0.397949f, 0.339844f,
                0.445801f, 0.339844f, 0.469238f, 0.339844f,
                0.489746f, 0.344482f, 0.510254f, 0.349121f,
                0.522949f, 0.360352f, 0.535645f, 0.371582f,
                0.541260f, 0.386230f, 0.546875f, 0.400879f,
                0.546875f, 0.423828f
            };

        private static readonly byte[] TahomaGlyph175Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph175Coordinates =
            {
                0.553711f, 0.810059f, -0.007813f, 0.810059f,
                -0.007813f, 0.873535f, 0.553711f, 0.873535f,
                0.553711f, 0.810059f
            };

        private static readonly byte[] TahomaGlyph176Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph176Coordinates =
            {
                0.421387f, 0.554199f, 0.421387f, 0.476074f,
                0.367676f, 0.422363f, 0.313965f, 0.368652f,
                0.235352f, 0.368652f, 0.157715f, 0.368652f,
                0.103516f, 0.421875f, 0.049316f, 0.475098f,
                0.049316f, 0.554199f, 0.049316f, 0.632324f,
                0.103027f, 0.686035f, 0.156738f, 0.739746f,
                0.235352f, 0.739746f, 0.313965f, 0.739746f,
                0.367676f, 0.686035f, 0.421387f, 0.632324f,
                0.421387f, 0.554199f, 0.344727f, 0.554199f,
                0.344727f, 0.601074f, 0.313477f, 0.633301f,
                0.282227f, 0.665527f, 0.235352f, 0.665527f,
                0.188477f, 0.665527f, 0.157227f, 0.633301f,
                0.125977f, 0.601074f, 0.125977f, 0.554199f,
                0.125977f, 0.506348f, 0.157959f, 0.474609f,
                0.189941f, 0.442871f, 0.235352f, 0.442871f,
                0.282227f, 0.442871f, 0.313477f, 0.475342f,
                0.344727f, 0.507813f, 0.344727f, 0.554199f
            };

        private static readonly byte[] TahomaGlyph177Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph177Coordinates =
            {
                0.648438f, 0.077637f, 0.079102f, 0.077637f,
                0.079102f, 0.154785f, 0.323242f, 0.154785f,
                0.323242f, 0.360840f, 0.079102f, 0.360840f,
                0.079102f, 0.437988f, 0.323242f, 0.437988f,
                0.323242f, 0.684570f, 0.404297f, 0.684570f,
                0.404297f, 0.437988f, 0.648438f, 0.437988f,
                0.648438f, 0.360840f, 0.404297f, 0.360840f,
                0.404297f, 0.154785f, 0.648438f, 0.154785f,
                0.648438f, 0.077637f
            };

        private static readonly byte[] TahomaGlyph178Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph178Coordinates =
            {
                0.422852f, 0.276367f, 0.090332f, 0.276367f,
                0.090332f, 0.350586f, 0.127930f, 0.379395f,
                0.162354f, 0.406006f, 0.196777f, 0.432617f,
                0.218262f, 0.453613f, 0.270020f, 0.503418f,
                0.286133f, 0.531494f, 0.302246f, 0.559570f,
                0.302246f, 0.599121f, 0.302246f, 0.632813f,
                0.281250f, 0.651123f, 0.260254f, 0.669434f,
                0.223145f, 0.669434f, 0.189453f, 0.669434f,
                0.155029f, 0.654785f, 0.120605f, 0.640137f,
                0.100586f, 0.624512f, 0.093262f, 0.624512f,
                0.093262f, 0.711914f, 0.124023f, 0.725098f,
                0.161377f, 0.733398f, 0.198730f, 0.741699f,
                0.234863f, 0.741699f, 0.311035f, 0.741699f,
                0.351807f, 0.703369f, 0.392578f, 0.665039f,
                0.392578f, 0.604980f, 0.392578f, 0.563477f,
                0.373291f, 0.525146f, 0.354004f, 0.486816f,
                0.301270f, 0.439453f, 0.275879f, 0.416992f,
                0.242188f, 0.391846f, 0.208496f, 0.366699f,
                0.182129f, 0.346680f, 0.422852f, 0.346680f,
                0.422852f, 0.276367f
            };

        private static readonly byte[] TahomaGlyph179Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph179Coordinates =
            {
                0.408691f, 0.404297f, 0.408691f, 0.369629f,
                0.394043f, 0.342041f, 0.379395f, 0.314453f,
                0.355957f, 0.298340f, 0.330078f, 0.280273f,
                0.300049f, 0.272461f, 0.270020f, 0.264648f,
                0.231445f, 0.264648f, 0.191406f, 0.264648f,
                0.156494f, 0.271973f, 0.121582f, 0.279297f,
                0.089844f, 0.292969f, 0.089844f, 0.378418f,
                0.098145f, 0.378418f, 0.116211f, 0.361328f,
                0.153809f, 0.346924f, 0.191406f, 0.332520f,
                0.229980f, 0.332520f, 0.270996f, 0.332520f,
                0.297852f, 0.350342f, 0.324707f, 0.368164f,
                0.324707f, 0.403320f, 0.324707f, 0.438477f,
                0.303467f, 0.455566f, 0.282227f, 0.472656f,
                0.231445f, 0.472656f, 0.163086f, 0.472656f,
                0.163086f, 0.540527f, 0.224121f, 0.540527f,
                0.266602f, 0.540527f, 0.289795f, 0.559082f,
                0.312988f, 0.577637f, 0.312988f, 0.609863f,
                0.312988f, 0.639160f, 0.292969f, 0.656494f,
                0.272949f, 0.673828f, 0.230469f, 0.673828f,
                0.198242f, 0.673828f, 0.160889f, 0.658691f,
                0.123535f, 0.643555f, 0.105469f, 0.626465f,
                0.097168f, 0.626465f, 0.097168f, 0.711914f,
                0.128418f, 0.725098f, 0.165039f, 0.733398f,
                0.201660f, 0.741699f, 0.240234f, 0.741699f,
                0.314453f, 0.741699f, 0.355957f, 0.707520f,
                0.397461f, 0.673340f, 0.397461f, 0.625488f,
                0.397461f, 0.583008f, 0.373779f, 0.555420f,
                0.350098f, 0.527832f, 0.312500f, 0.515137f,
                0.312500f, 0.511230f, 0.351563f, 0.503418f,
                0.380127f, 0.476807f, 0.408691f, 0.450195f,
                0.408691f, 0.404297f
            };

        private static readonly byte[] TahomaGlyph180Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph180Coordinates =
            {
                0.425293f, 0.818359f, 0.291992f, 0.635742f,
                0.219238f, 0.635742f, 0.306641f, 0.818359f,
                0.425293f, 0.818359f
            };

        private static readonly byte[] TahomaGlyph181Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph181Coordinates =
            {
                0.501465f, 0.000000f, 0.417480f, 0.000000f,
                0.417480f, 0.056641f, 0.414551f, 0.056641f,
                0.385254f, 0.025879f, 0.355713f, 0.008789f,
                0.326172f, -0.008301f, 0.282227f, -0.008301f,
                0.237305f, -0.008301f, 0.211426f, 0.008789f,
                0.185547f, 0.025879f, 0.158203f, 0.056152f,
                0.158203f, -0.201172f, 0.066406f, -0.201172f,
                0.066406f, 0.545410f, 0.158203f, 0.545410f,
                0.158203f, 0.134277f, 0.178711f, 0.109863f,
                0.209473f, 0.094971f, 0.240234f, 0.080078f,
                0.282227f, 0.080078f, 0.326172f, 0.080078f,
                0.356201f, 0.094238f, 0.386230f, 0.108398f,
                0.409668f, 0.134277f, 0.409668f, 0.545410f,
                0.501465f, 0.545410f, 0.501465f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph182Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph182Coordinates =
            {
                0.479492f, -0.177246f, 0.411133f, -0.177246f,
                0.411133f, 0.663574f, 0.319824f, 0.663574f,
                0.319824f, -0.177246f, 0.251465f, -0.177246f,
                0.251465f, 0.289551f, 0.150879f, 0.291992f,
                0.089355f, 0.352539f, 0.027832f, 0.413086f,
                0.027832f, 0.512695f, 0.027832f, 0.613770f,
                0.091309f, 0.670410f, 0.154785f, 0.727051f,
                0.273438f, 0.727051f, 0.479492f, 0.727051f,
                0.479492f, -0.177246f
            };

        private static readonly byte[] TahomaGlyph183Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph183Coordinates =
            {
                0.235352f, 0.406250f, 0.118652f, 0.406250f,
                0.118652f, 0.545410f, 0.235352f, 0.545410f,
                0.235352f, 0.406250f
            };

        private static readonly byte[] TahomaGlyph184Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph184Coordinates =
            {
                0.374512f, 0.009766f, 0.375000f, 0.000977f,
                0.376221f, -0.012451f, 0.377441f, -0.025879f,
                0.377441f, -0.043457f, 0.377441f, -0.122559f,
                0.334961f, -0.164551f, 0.292480f, -0.206543f,
                0.227539f, -0.206543f, 0.209473f, -0.206543f,
                0.185059f, -0.203613f, 0.160645f, -0.200684f,
                0.141113f, -0.194824f, 0.141113f, -0.116699f,
                0.145508f, -0.116699f, 0.157227f, -0.122070f,
                0.176270f, -0.127686f, 0.195313f, -0.133301f,
                0.214844f, -0.133301f, 0.260742f, -0.133301f,
                0.280273f, -0.114014f, 0.299805f, -0.094727f,
                0.299805f, -0.052246f, 0.299805f, -0.039551f,
                0.299316f, -0.024414f, 0.298828f, -0.009277f,
                0.297852f, 0.009766f, 0.374512f, 0.009766f
            };

        private static readonly byte[] TahomaGlyph185Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph185Coordinates =
            {
                0.395996f, 0.276367f, 0.125000f, 0.276367f,
                0.125000f, 0.335938f, 0.224609f, 0.335938f,
                0.224609f, 0.613281f, 0.121094f, 0.613281f,
                0.121094f, 0.667969f, 0.143066f, 0.667969f,
                0.166992f, 0.670898f, 0.190918f, 0.673828f,
                0.203125f, 0.680176f, 0.218262f, 0.687988f,
                0.226807f, 0.698730f, 0.235352f, 0.709473f,
                0.236816f, 0.729004f, 0.302734f, 0.729004f,
                0.302734f, 0.335938f, 0.395996f, 0.335938f,
                0.395996f, 0.276367f
            };

        private static readonly byte[] TahomaGlyph186Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph186Coordinates =
            {
                0.452148f, 0.502930f, 0.452148f, 0.388672f,
                0.395020f, 0.326172f, 0.337891f, 0.263672f,
                0.247070f, 0.263672f, 0.152832f, 0.263672f,
                0.097168f, 0.327881f, 0.041504f, 0.392090f,
                0.041504f, 0.502930f, 0.041504f, 0.616699f,
                0.098633f, 0.679443f, 0.155762f, 0.742188f,
                0.247070f, 0.742188f, 0.338379f, 0.742188f,
                0.395264f, 0.680176f, 0.452148f, 0.618164f,
                0.452148f, 0.502930f, 0.364258f, 0.502930f,
                0.364258f, 0.587402f, 0.332764f, 0.628174f,
                0.301270f, 0.668945f, 0.247070f, 0.668945f,
                0.192871f, 0.668945f, 0.161133f, 0.628662f,
                0.129395f, 0.588379f, 0.129395f, 0.502930f,
                0.129395f, 0.420410f, 0.160645f, 0.378662f,
                0.191895f, 0.336914f, 0.247070f, 0.336914f,
                0.301270f, 0.336914f, 0.332764f, 0.378662f,
                0.364258f, 0.420410f, 0.364258f, 0.502930f
            };

        private static readonly byte[] TahomaGlyph187Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph187Coordinates =
            {
                0.522949f, 0.296875f, 0.273926f, 0.079102f,
                0.273926f, 0.174805f, 0.435547f, 0.318359f,
                0.273926f, 0.461914f, 0.273926f, 0.557617f,
                0.522949f, 0.340332f, 0.522949f, 0.296875f,
                0.302246f, 0.297852f, 0.063965f, 0.093262f,
                0.063965f, 0.185059f, 0.218750f, 0.318359f,
                0.063965f, 0.451660f, 0.063965f, 0.543457f,
                0.302246f, 0.339355f, 0.302246f, 0.297852f
            };

        private static readonly byte[] TahomaGlyph188Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph188Coordinates =
            {
                0.266113f, 0.275879f, 0.185547f, 0.275879f,
                0.185547f, 0.608398f, 0.083496f, 0.608398f,
                0.083496f, 0.665527f, 0.133301f, 0.665527f,
                0.164063f, 0.676270f, 0.194824f, 0.687012f,
                0.199219f, 0.729004f, 0.266113f, 0.729004f,
                0.266113f, 0.275879f, 0.688477f, 0.727051f,
                0.307617f, 0.000000f, 0.227051f, 0.000000f,
                0.607910f, 0.727051f, 0.688477f, 0.727051f,
                0.901855f, 0.107422f, 0.822266f, 0.107422f,
                0.822266f, 0.000000f, 0.749023f, 0.000000f,
                0.749023f, 0.107422f, 0.526855f, 0.107422f,
                0.526855f, 0.197754f, 0.749512f, 0.460938f,
                0.822266f, 0.460938f, 0.822266f, 0.172363f,
                0.901855f, 0.172363f, 0.901855f, 0.107422f,
                0.750977f, 0.172363f, 0.750977f, 0.367676f,
                0.583496f, 0.172363f, 0.750977f, 0.172363f
            };

        private static readonly byte[] TahomaGlyph189Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph189Coordinates =
            {
                0.266113f, 0.275879f, 0.185547f, 0.275879f,
                0.185547f, 0.608398f, 0.083496f, 0.608398f,
                0.083496f, 0.665527f, 0.133301f, 0.665527f,
                0.164063f, 0.676270f, 0.194824f, 0.687012f,
                0.199219f, 0.729004f, 0.266113f, 0.729004f,
                0.266113f, 0.275879f, 0.688477f, 0.727051f,
                0.307617f, 0.000000f, 0.227051f, 0.000000f,
                0.607910f, 0.727051f, 0.688477f, 0.727051f,
                0.950195f, 0.000000f, 0.617676f, 0.000000f,
                0.617676f, 0.069824f, 0.655273f, 0.098633f,
                0.689697f, 0.125244f, 0.724121f, 0.151855f,
                0.745605f, 0.172852f, 0.797363f, 0.222656f,
                0.813477f, 0.250732f, 0.829590f, 0.278809f,
                0.829590f, 0.318359f, 0.829590f, 0.352051f,
                0.808594f, 0.370361f, 0.787598f, 0.388672f,
                0.750488f, 0.388672f, 0.716797f, 0.388672f,
                0.682373f, 0.374023f, 0.647949f, 0.359375f,
                0.627930f, 0.343750f, 0.620605f, 0.343750f,
                0.620605f, 0.431152f, 0.651367f, 0.444336f,
                0.688721f, 0.452637f, 0.726074f, 0.460938f,
                0.762207f, 0.460938f, 0.838379f, 0.460938f,
                0.879150f, 0.422607f, 0.919922f, 0.384277f,
                0.919922f, 0.324219f, 0.919922f, 0.268555f,
                0.892334f, 0.229736f, 0.864746f, 0.190918f,
                0.828613f, 0.158691f, 0.801270f, 0.134766f,
                0.768799f, 0.111084f, 0.736328f, 0.087402f,
                0.710449f, 0.067871f, 0.950195f, 0.067871f,
                0.950195f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph190Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph190Coordinates =
            {
                0.387207f, 0.403320f, 0.387207f, 0.368652f,
                0.372559f, 0.341064f, 0.357910f, 0.313477f,
                0.334473f, 0.297363f, 0.308594f, 0.279297f,
                0.278564f, 0.271484f, 0.248535f, 0.263672f,
                0.209961f, 0.263672f, 0.169922f, 0.263672f,
                0.135010f, 0.270996f, 0.100098f, 0.278320f,
                0.068359f, 0.291992f, 0.068359f, 0.377441f,
                0.076660f, 0.377441f, 0.094727f, 0.360352f,
                0.132324f, 0.345947f, 0.169922f, 0.331543f,
                0.208496f, 0.331543f, 0.249512f, 0.331543f,
                0.276367f, 0.349365f, 0.303223f, 0.367188f,
                0.303223f, 0.402344f, 0.303223f, 0.442871f,
                0.278809f, 0.457275f, 0.254395f, 0.471680f,
                0.209961f, 0.471680f, 0.141602f, 0.471680f,
                0.141602f, 0.539551f, 0.202637f, 0.539551f,
                0.245117f, 0.539551f, 0.268311f, 0.558105f,
                0.291504f, 0.576660f, 0.291504f, 0.608887f,
                0.291504f, 0.638184f, 0.271484f, 0.655518f,
                0.251465f, 0.672852f, 0.208984f, 0.672852f,
                0.176758f, 0.672852f, 0.139404f, 0.657715f,
                0.102051f, 0.642578f, 0.083984f, 0.625488f,
                0.075684f, 0.625488f, 0.075684f, 0.710938f,
                0.106934f, 0.724121f, 0.143555f, 0.732422f,
                0.180176f, 0.740723f, 0.218750f, 0.740723f,
                0.292969f, 0.740723f, 0.334473f, 0.706543f,
                0.375977f, 0.672363f, 0.375977f, 0.624512f,
                0.375977f, 0.582031f, 0.352295f, 0.554443f,
                0.328613f, 0.526855f, 0.291016f, 0.514160f,
                0.291016f, 0.510254f, 0.330078f, 0.502441f,
                0.358643f, 0.475830f, 0.387207f, 0.449219f,
                0.387207f, 0.403320f, 0.732422f, 0.727051f,
                0.351563f, 0.000000f, 0.270996f, 0.000000f,
                0.651855f, 0.727051f, 0.732422f, 0.727051f,
                0.929199f, 0.107422f, 0.849609f, 0.107422f,
                0.849609f, 0.000000f, 0.776367f, 0.000000f,
                0.776367f, 0.107422f, 0.554199f, 0.107422f,
                0.554199f, 0.197754f, 0.776855f, 0.460938f,
                0.849609f, 0.460938f, 0.849609f, 0.172363f,
                0.929199f, 0.172363f, 0.929199f, 0.107422f,
                0.778320f, 0.172363f, 0.778320f, 0.367676f,
                0.610840f, 0.172363f, 0.778320f, 0.172363f
            };

        private static readonly byte[] TahomaGlyph191Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph191Coordinates =
            {
                0.308594f, 0.624023f, 0.208984f, 0.624023f,
                0.208984f, 0.727051f, 0.308594f, 0.727051f,
                0.308594f, 0.624023f, 0.420410f, 0.019531f,
                0.381836f, 0.004883f, 0.338867f, -0.004883f,
                0.295898f, -0.014648f, 0.243652f, -0.014648f,
                0.143555f, -0.014648f, 0.085938f, 0.036377f,
                0.028320f, 0.087402f, 0.028320f, 0.170898f,
                0.028320f, 0.216797f, 0.042969f, 0.252930f,
                0.057617f, 0.289063f, 0.086426f, 0.321777f,
                0.112305f, 0.350586f, 0.146240f, 0.373779f,
                0.180176f, 0.396973f, 0.216797f, 0.420410f,
                0.216797f, 0.531738f, 0.304199f, 0.531738f,
                0.304199f, 0.382813f, 0.269531f, 0.361816f,
                0.239990f, 0.343262f, 0.210449f, 0.324707f,
                0.183594f, 0.299805f, 0.158691f, 0.276367f,
                0.143311f, 0.246582f, 0.127930f, 0.216797f,
                0.127930f, 0.178223f, 0.127930f, 0.123047f,
                0.162598f, 0.095947f, 0.197266f, 0.068848f,
                0.252930f, 0.068848f, 0.301270f, 0.068848f,
                0.346191f, 0.085693f, 0.391113f, 0.102539f,
                0.415039f, 0.119141f, 0.420410f, 0.119141f,
                0.420410f, 0.019531f
            };

        private static readonly byte[] TahomaGlyph1025Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1025Coordinates =
            {
                0.073730f, 0.000000f, 0.073730f, 0.727051f,
                0.528320f, 0.727051f, 0.528320f, 0.641113f,
                0.170410f, 0.641113f, 0.170410f, 0.441895f,
                0.503906f, 0.441895f, 0.503906f, 0.355957f,
                0.170410f, 0.355957f, 0.170410f, 0.085938f,
                0.528320f, 0.085938f, 0.528320f, 0.000000f,
                0.073730f, 0.000000f, 0.471680f, 0.818848f,
                0.373535f, 0.818848f, 0.373535f, 0.914063f,
                0.471680f, 0.914063f, 0.471680f, 0.818848f,
                0.270020f, 0.818848f, 0.171875f, 0.818848f,
                0.171875f, 0.914063f, 0.270020f, 0.914063f,
                0.270020f, 0.818848f
            };

        private static readonly byte[] TahomaGlyph1026Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1026Coordinates =
            {
                0.699707f, 0.224609f, 0.699707f, 0.171875f,
                0.679443f, 0.128662f, 0.659180f, 0.085449f,
                0.623535f, 0.057129f, 0.581055f, 0.023438f,
                0.538330f, 0.011719f, 0.495605f, 0.000000f,
                0.428223f, 0.000000f, 0.398926f, 0.000000f,
                0.398926f, 0.086426f, 0.419922f, 0.086426f,
                0.464355f, 0.086426f, 0.493652f, 0.090332f,
                0.522949f, 0.094238f, 0.545898f, 0.110840f,
                0.573242f, 0.130371f, 0.585938f, 0.157471f,
                0.598633f, 0.184570f, 0.598633f, 0.222656f,
                0.598633f, 0.259277f, 0.586670f, 0.287354f,
                0.574707f, 0.315430f, 0.548828f, 0.332520f,
                0.524414f, 0.349121f, 0.488037f, 0.353760f,
                0.451660f, 0.358398f, 0.387695f, 0.358398f,
                0.301270f, 0.358398f, 0.301270f, 0.000000f,
                0.204590f, 0.000000f, 0.204590f, 0.641113f,
                -0.000488f, 0.641113f, -0.000488f, 0.727051f,
                0.545410f, 0.727051f, 0.545410f, 0.641113f,
                0.301270f, 0.641113f, 0.301270f, 0.441895f,
                0.417969f, 0.441895f, 0.492188f, 0.441895f,
                0.538818f, 0.433105f, 0.585449f, 0.424316f,
                0.626953f, 0.392090f, 0.664063f, 0.363281f,
                0.681885f, 0.320801f, 0.699707f, 0.278320f,
                0.699707f, 0.224609f
            };

        private static readonly byte[] TahomaGlyph1027Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1027Coordinates =
            {
                0.504883f, 0.641113f, 0.170410f, 0.641113f,
                0.170410f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.504883f, 0.727051f,
                0.504883f, 0.641113f, 0.454102f, 1.000488f,
                0.320801f, 0.817871f, 0.248047f, 0.817871f,
                0.335449f, 1.000488f, 0.454102f, 1.000488f
            };

        private static readonly byte[] TahomaGlyph1028Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1028Coordinates =
            {
                0.577637f, 0.031738f, 0.533691f, 0.012695f,
                0.480957f, -0.000244f, 0.428223f, -0.013184f,
                0.363281f, -0.013184f, 0.212402f, -0.013184f,
                0.122314f, 0.085938f, 0.032227f, 0.185059f,
                0.032227f, 0.364258f, 0.032227f, 0.538086f,
                0.123291f, 0.639160f, 0.214355f, 0.740234f,
                0.362793f, 0.740234f, 0.428223f, 0.740234f,
                0.482666f, 0.727295f, 0.537109f, 0.714355f,
                0.577637f, 0.695801f, 0.577637f, 0.586914f,
                0.570313f, 0.586914f, 0.536133f, 0.618164f,
                0.482178f, 0.638184f, 0.428223f, 0.658203f,
                0.365723f, 0.658203f, 0.274902f, 0.658203f,
                0.211182f, 0.601807f, 0.147461f, 0.545410f,
                0.134766f, 0.432129f, 0.483887f, 0.432129f,
                0.483887f, 0.347656f, 0.129883f, 0.347656f,
                0.130371f, 0.278809f, 0.149170f, 0.226807f,
                0.167969f, 0.174805f, 0.199707f, 0.139648f,
                0.232422f, 0.104004f, 0.275635f, 0.086426f,
                0.318848f, 0.068848f, 0.367188f, 0.068848f,
                0.427734f, 0.068848f, 0.481934f, 0.087402f,
                0.536133f, 0.105957f, 0.570313f, 0.137695f,
                0.577637f, 0.137695f, 0.577637f, 0.031738f
            };

        private static readonly byte[] TahomaGlyph1029Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1029Coordinates =
            {
                0.276367f, -0.013184f, 0.197266f, -0.013184f,
                0.141846f, 0.003174f, 0.086426f, 0.019531f,
                0.037598f, 0.043457f, 0.037598f, 0.164551f,
                0.044434f, 0.164551f, 0.092285f, 0.119629f,
                0.152832f, 0.094971f, 0.213379f, 0.070313f,
                0.269531f, 0.070313f, 0.349609f, 0.070313f,
                0.390625f, 0.103760f, 0.431641f, 0.137207f,
                0.431641f, 0.191895f, 0.431641f, 0.235352f,
                0.410156f, 0.262695f, 0.388672f, 0.290039f,
                0.341797f, 0.303223f, 0.308105f, 0.312988f,
                0.280273f, 0.319336f, 0.252441f, 0.325684f,
                0.210449f, 0.336426f, 0.172852f, 0.346191f,
                0.143066f, 0.361328f, 0.113281f, 0.376465f,
                0.090332f, 0.400879f, 0.067871f, 0.424805f,
                0.055420f, 0.457275f, 0.042969f, 0.489746f,
                0.042969f, 0.532227f, 0.042969f, 0.620605f,
                0.111816f, 0.680420f, 0.180664f, 0.740234f,
                0.287598f, 0.740234f, 0.348633f, 0.740234f,
                0.403076f, 0.728027f, 0.457520f, 0.715820f,
                0.503906f, 0.693359f, 0.503906f, 0.577637f,
                0.496582f, 0.577637f, 0.461914f, 0.609375f,
                0.407715f, 0.633057f, 0.353516f, 0.656738f,
                0.293945f, 0.656738f, 0.226563f, 0.656738f,
                0.185059f, 0.625244f, 0.143555f, 0.593750f,
                0.143555f, 0.542480f, 0.143555f, 0.496094f,
                0.167969f, 0.468750f, 0.192383f, 0.441406f,
                0.238770f, 0.428711f, 0.269531f, 0.420410f,
                0.313965f, 0.409912f, 0.358398f, 0.399414f,
                0.387695f, 0.390625f, 0.462891f, 0.367676f,
                0.497559f, 0.321289f, 0.532227f, 0.274902f,
                0.532227f, 0.207031f, 0.532227f, 0.164551f,
                0.514893f, 0.123047f, 0.497559f, 0.081543f,
                0.466309f, 0.052734f, 0.431152f, 0.020996f,
                0.386963f, 0.003906f, 0.342773f, -0.013184f,
                0.276367f, -0.013184f
            };

        private static readonly byte[] TahomaGlyph1030Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1030Coordinates =
            {
                0.327637f, 0.000000f, 0.045410f, 0.000000f,
                0.045410f, 0.074219f, 0.138184f, 0.074219f,
                0.138184f, 0.652832f, 0.045410f, 0.652832f,
                0.045410f, 0.727051f, 0.327637f, 0.727051f,
                0.327637f, 0.652832f, 0.234863f, 0.652832f,
                0.234863f, 0.074219f, 0.327637f, 0.074219f,
                0.327637f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1031Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1031Coordinates =
            {
                0.327637f, 0.000000f, 0.045410f, 0.000000f,
                0.045410f, 0.074219f, 0.138184f, 0.074219f,
                0.138184f, 0.652832f, 0.045410f, 0.652832f,
                0.045410f, 0.727051f, 0.327637f, 0.727051f,
                0.327637f, 0.652832f, 0.234863f, 0.652832f,
                0.234863f, 0.074219f, 0.327637f, 0.074219f,
                0.327637f, 0.000000f, 0.336914f, 0.818848f,
                0.238770f, 0.818848f, 0.238770f, 0.914063f,
                0.336914f, 0.914063f, 0.336914f, 0.818848f,
                0.135254f, 0.818848f, 0.037109f, 0.818848f,
                0.037109f, 0.914063f, 0.135254f, 0.914063f,
                0.135254f, 0.818848f
            };

        private static readonly byte[] TahomaGlyph1032Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1032Coordinates =
            {
                0.347656f, 0.188965f, 0.347656f, 0.093262f,
                0.289307f, 0.041504f, 0.230957f, -0.010254f,
                0.132813f, -0.010254f, 0.109375f, -0.010254f,
                0.070068f, -0.006104f, 0.030762f, -0.001953f,
                0.004395f, 0.003906f, 0.004395f, 0.096191f,
                0.009766f, 0.096191f, 0.029785f, 0.089355f,
                0.059326f, 0.081055f, 0.088867f, 0.072754f,
                0.119629f, 0.072754f, 0.164551f, 0.072754f,
                0.191162f, 0.083008f, 0.217773f, 0.093262f,
                0.230469f, 0.112305f, 0.243652f, 0.131836f,
                0.247314f, 0.160156f, 0.250977f, 0.188477f,
                0.250977f, 0.225586f, 0.250977f, 0.649902f,
                0.097168f, 0.649902f, 0.097168f, 0.727051f,
                0.347656f, 0.727051f, 0.347656f, 0.188965f
            };

        private static readonly byte[] TahomaGlyph1033Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1033Coordinates =
            {
                0.982910f, 0.225098f, 0.982910f, 0.172363f,
                0.962402f, 0.129395f, 0.941895f, 0.086426f,
                0.907227f, 0.059570f, 0.866211f, 0.027344f,
                0.819336f, 0.013672f, 0.772461f, 0.000000f,
                0.698242f, 0.000000f, 0.492676f, 0.000000f,
                0.492676f, 0.641113f, 0.262207f, 0.641113f,
                0.260742f, 0.585938f, 0.258301f, 0.533447f,
                0.255859f, 0.480957f, 0.254395f, 0.439453f,
                0.250488f, 0.336426f, 0.241943f, 0.269043f,
                0.233398f, 0.201660f, 0.219727f, 0.156250f,
                0.206543f, 0.111816f, 0.188721f, 0.084473f,
                0.170898f, 0.057129f, 0.149902f, 0.038574f,
                0.127930f, 0.018555f, 0.102783f, 0.008545f,
                0.077637f, -0.001465f, 0.044434f, -0.001465f,
                0.034180f, -0.001465f, 0.023682f, -0.000732f,
                0.013184f, 0.000000f, 0.007324f, 0.000000f,
                0.007324f, 0.093750f, 0.014160f, 0.093750f,
                0.019043f, 0.093262f, 0.022461f, 0.092773f,
                0.025879f, 0.092285f, 0.032715f, 0.092285f,
                0.050293f, 0.092285f, 0.065430f, 0.097656f,
                0.080566f, 0.103027f, 0.091309f, 0.114258f,
                0.124512f, 0.146973f, 0.139893f, 0.230713f,
                0.155273f, 0.314453f, 0.161621f, 0.456055f,
                0.164063f, 0.503906f, 0.166504f, 0.582520f,
                0.168945f, 0.661133f, 0.170898f, 0.727051f,
                0.589355f, 0.727051f, 0.589355f, 0.441895f,
                0.701172f, 0.441895f, 0.775391f, 0.441895f,
                0.822266f, 0.433350f, 0.869141f, 0.424805f,
                0.910645f, 0.392578f, 0.947754f, 0.363770f,
                0.965332f, 0.321289f, 0.982910f, 0.278809f,
                0.982910f, 0.225098f, 0.881836f, 0.223145f,
                0.881836f, 0.259766f, 0.869873f, 0.287598f,
                0.857910f, 0.315430f, 0.832031f, 0.332520f,
                0.805176f, 0.350586f, 0.770020f, 0.354492f,
                0.734863f, 0.358398f, 0.670898f, 0.358398f,
                0.589355f, 0.358398f, 0.589355f, 0.082520f,
                0.668457f, 0.082520f, 0.733398f, 0.082520f,
                0.768311f, 0.088867f, 0.803223f, 0.095215f,
                0.829590f, 0.113281f, 0.856934f, 0.132324f,
                0.869385f, 0.157959f, 0.881836f, 0.183594f,
                0.881836f, 0.223145f
            };

        private static readonly byte[] TahomaGlyph1034Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1034Coordinates =
            {
                0.965332f, 0.225098f, 0.965332f, 0.172363f,
                0.944824f, 0.129395f, 0.924316f, 0.086426f,
                0.889648f, 0.059570f, 0.848633f, 0.027344f,
                0.801758f, 0.013672f, 0.754883f, 0.000000f,
                0.680664f, 0.000000f, 0.479980f, 0.000000f,
                0.479980f, 0.358398f, 0.170410f, 0.358398f,
                0.170410f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.170410f, 0.727051f,
                0.170410f, 0.441895f, 0.479980f, 0.441895f,
                0.479980f, 0.727051f, 0.576660f, 0.727051f,
                0.576660f, 0.441895f, 0.683594f, 0.441895f,
                0.757813f, 0.441895f, 0.804688f, 0.433350f,
                0.851563f, 0.424805f, 0.893066f, 0.392578f,
                0.930176f, 0.363770f, 0.947754f, 0.321289f,
                0.965332f, 0.278809f, 0.965332f, 0.225098f,
                0.864258f, 0.223145f, 0.864258f, 0.259766f,
                0.852295f, 0.287598f, 0.840332f, 0.315430f,
                0.814453f, 0.332520f, 0.787598f, 0.350586f,
                0.752441f, 0.354492f, 0.717285f, 0.358398f,
                0.653320f, 0.358398f, 0.576660f, 0.358398f,
                0.576660f, 0.082520f, 0.650879f, 0.082520f,
                0.715820f, 0.082520f, 0.750732f, 0.088867f,
                0.785645f, 0.095215f, 0.812012f, 0.113281f,
                0.839355f, 0.132324f, 0.851807f, 0.157959f,
                0.864258f, 0.183594f, 0.864258f, 0.223145f
            };

        private static readonly byte[] TahomaGlyph1035Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1035Coordinates =
            {
                0.672363f, 0.000000f, 0.575684f, 0.000000f,
                0.575684f, 0.201172f, 0.575684f, 0.237305f,
                0.572510f, 0.270264f, 0.569336f, 0.303223f,
                0.557617f, 0.322754f, 0.544922f, 0.343750f,
                0.518799f, 0.354492f, 0.492676f, 0.365234f,
                0.446289f, 0.365234f, 0.415527f, 0.365234f,
                0.376221f, 0.360352f, 0.336914f, 0.355469f,
                0.301270f, 0.346680f, 0.301270f, 0.000000f,
                0.204590f, 0.000000f, 0.204590f, 0.641113f,
                -0.000488f, 0.641113f, -0.000488f, 0.727051f,
                0.545410f, 0.727051f, 0.545410f, 0.641113f,
                0.301270f, 0.641113f, 0.301270f, 0.427246f,
                0.337891f, 0.437988f, 0.383057f, 0.445557f,
                0.428223f, 0.453125f, 0.465332f, 0.453125f,
                0.511719f, 0.453125f, 0.550049f, 0.442139f,
                0.588379f, 0.431152f, 0.615234f, 0.406738f,
                0.642578f, 0.382813f, 0.657471f, 0.343994f,
                0.672363f, 0.305176f, 0.672363f, 0.249512f,
                0.672363f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1036Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1036Coordinates =
            {
                0.611328f, 0.000000f, 0.488281f, 0.000000f,
                0.231445f, 0.333008f, 0.170410f, 0.333008f,
                0.170410f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.170410f, 0.727051f,
                0.170410f, 0.399414f, 0.227539f, 0.401367f,
                0.260986f, 0.428223f, 0.294434f, 0.455078f,
                0.315430f, 0.505371f, 0.324219f, 0.527344f,
                0.331299f, 0.547119f, 0.338379f, 0.566895f,
                0.342773f, 0.580566f, 0.372070f, 0.664063f,
                0.417480f, 0.695557f, 0.462891f, 0.727051f,
                0.543457f, 0.727051f, 0.573242f, 0.727051f,
                0.573242f, 0.640625f, 0.548828f, 0.640625f,
                0.489258f, 0.640625f, 0.465332f, 0.617432f,
                0.441406f, 0.594238f, 0.421387f, 0.529785f,
                0.401367f, 0.465332f, 0.376465f, 0.435303f,
                0.351563f, 0.405273f, 0.316406f, 0.382324f,
                0.611328f, 0.000000f, 0.455566f, 0.990723f,
                0.322266f, 0.808105f, 0.249512f, 0.808105f,
                0.336914f, 0.990723f, 0.455566f, 0.990723f
            };

        private static readonly byte[] TahomaGlyph1037Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1037Coordinates =
            {
                0.596191f, 0.000000f, 0.500000f, 0.000000f,
                0.500000f, 0.577148f, 0.171387f, 0.000000f,
                0.073730f, 0.000000f, 0.073730f, 0.727051f,
                0.169922f, 0.727051f, 0.169922f, 0.159180f,
                0.494141f, 0.727051f, 0.596191f, 0.727051f,
                0.596191f, 0.000000f, 0.389648f, 0.817871f,
                0.316895f, 0.817871f, 0.183594f, 1.000488f,
                0.302246f, 1.000488f, 0.389648f, 0.817871f
            };

        private static readonly byte[] TahomaGlyph1038Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1038Coordinates =
            {
                0.581543f, 0.727051f, 0.317871f, 0.114746f,
                0.301270f, 0.076172f, 0.280518f, 0.052734f,
                0.259766f, 0.029297f, 0.237305f, 0.017578f,
                0.214844f, 0.005371f, 0.193115f, 0.001465f,
                0.171387f, -0.002441f, 0.149414f, -0.002441f,
                0.129883f, -0.002441f, 0.103516f, -0.001465f,
                0.077148f, -0.000488f, 0.069824f, 0.000000f,
                0.069824f, 0.090332f, 0.076660f, 0.090332f,
                0.083984f, 0.089355f, 0.098877f, 0.088135f,
                0.113770f, 0.086914f, 0.136719f, 0.086914f,
                0.147461f, 0.086914f, 0.162109f, 0.088135f,
                0.176758f, 0.089355f, 0.188965f, 0.095215f,
                0.203125f, 0.102051f, 0.215576f, 0.113525f,
                0.228027f, 0.125000f, 0.238281f, 0.149902f,
                0.254883f, 0.188477f, -0.000488f, 0.727051f,
                0.106445f, 0.727051f, 0.303711f, 0.299316f,
                0.481934f, 0.727051f, 0.581543f, 0.727051f,
                0.477051f, 0.944824f, 0.475098f, 0.871582f,
                0.430664f, 0.826660f, 0.386230f, 0.781738f,
                0.296387f, 0.781738f, 0.206543f, 0.781738f,
                0.162109f, 0.826660f, 0.117676f, 0.871582f,
                0.115723f, 0.944824f, 0.202637f, 0.944824f,
                0.203613f, 0.890137f, 0.227051f, 0.865967f,
                0.250488f, 0.841797f, 0.296387f, 0.841797f,
                0.342773f, 0.841797f, 0.365967f, 0.865723f,
                0.389160f, 0.889648f, 0.390137f, 0.944824f,
                0.477051f, 0.944824f
            };

        private static readonly byte[] TahomaGlyph1039Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1039Coordinates =
            {
                0.601563f, 0.000000f, 0.383301f, 0.000000f,
                0.383301f, -0.164551f, 0.291992f, -0.164551f,
                0.291992f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.170410f, 0.727051f,
                0.170410f, 0.083984f, 0.504883f, 0.083984f,
                0.504883f, 0.727051f, 0.601563f, 0.727051f,
                0.601563f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1040Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1040Coordinates =
            {
                -0.004883f, 0.000000f, 0.240234f, 0.727051f,
                0.359375f, 0.727051f, 0.604492f, 0.000000f,
                0.502441f, 0.000000f, 0.436523f, 0.203125f,
                0.158691f, 0.203125f, 0.092773f, 0.000000f,
                -0.004883f, 0.000000f, 0.409668f, 0.285645f,
                0.297363f, 0.628418f, 0.185547f, 0.285645f,
                0.409668f, 0.285645f
            };

        private static readonly byte[] TahomaGlyph1041Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1041Coordinates =
            {
                0.568848f, 0.225098f, 0.568848f, 0.172363f,
                0.548340f, 0.129395f, 0.527832f, 0.086426f,
                0.493164f, 0.059570f, 0.452148f, 0.027344f,
                0.405273f, 0.013672f, 0.358398f, 0.000000f,
                0.284180f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.516602f, 0.727051f,
                0.516602f, 0.641113f, 0.170410f, 0.641113f,
                0.170410f, 0.441895f, 0.287109f, 0.441895f,
                0.361328f, 0.441895f, 0.408203f, 0.433350f,
                0.455078f, 0.424805f, 0.496582f, 0.392578f,
                0.533691f, 0.363770f, 0.551270f, 0.321289f,
                0.568848f, 0.278809f, 0.568848f, 0.225098f,
                0.467773f, 0.223145f, 0.467773f, 0.259766f,
                0.455811f, 0.287598f, 0.443848f, 0.315430f,
                0.417969f, 0.332520f, 0.391113f, 0.350586f,
                0.355957f, 0.354492f, 0.320801f, 0.358398f,
                0.256836f, 0.358398f, 0.170410f, 0.358398f,
                0.170410f, 0.082520f, 0.254395f, 0.082520f,
                0.319336f, 0.082520f, 0.354248f, 0.088867f,
                0.389160f, 0.095215f, 0.415527f, 0.113281f,
                0.442871f, 0.132324f, 0.455322f, 0.157959f,
                0.467773f, 0.183594f, 0.467773f, 0.223145f
            };

        private static readonly byte[] TahomaGlyph1042Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1042Coordinates =
            {
                0.566895f, 0.223145f, 0.566895f, 0.168945f,
                0.546387f, 0.127441f, 0.525879f, 0.085938f,
                0.491211f, 0.059082f, 0.450195f, 0.026855f,
                0.403320f, 0.013428f, 0.356445f, 0.000000f,
                0.282227f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.266602f, 0.727051f,
                0.344238f, 0.727051f, 0.383057f, 0.721924f,
                0.421875f, 0.716797f, 0.457520f, 0.697754f,
                0.496582f, 0.676758f, 0.514648f, 0.642822f,
                0.532715f, 0.608887f, 0.532715f, 0.562988f,
                0.532715f, 0.511719f, 0.505615f, 0.471191f,
                0.478516f, 0.430664f, 0.430664f, 0.407715f,
                0.430664f, 0.403809f, 0.495605f, 0.386230f,
                0.531250f, 0.339600f, 0.566895f, 0.292969f,
                0.566895f, 0.223145f, 0.432129f, 0.549316f,
                0.432129f, 0.575684f, 0.423340f, 0.594971f,
                0.414551f, 0.614258f, 0.395020f, 0.625488f,
                0.371582f, 0.638672f, 0.342773f, 0.641602f,
                0.313965f, 0.644531f, 0.263184f, 0.644531f,
                0.170410f, 0.644531f, 0.170410f, 0.431641f,
                0.280273f, 0.431641f, 0.325684f, 0.431641f,
                0.347168f, 0.436279f, 0.368652f, 0.440918f,
                0.391602f, 0.455566f, 0.413574f, 0.469727f,
                0.422852f, 0.492676f, 0.432129f, 0.515625f,
                0.432129f, 0.549316f, 0.466309f, 0.219238f,
                0.466309f, 0.260254f, 0.454590f, 0.286865f,
                0.442871f, 0.313477f, 0.407227f, 0.332031f,
                0.384277f, 0.344238f, 0.357178f, 0.347656f,
                0.330078f, 0.351074f, 0.280273f, 0.351074f,
                0.170410f, 0.351074f, 0.170410f, 0.082520f,
                0.249023f, 0.082520f, 0.312500f, 0.082520f,
                0.349121f, 0.088379f, 0.385742f, 0.094238f,
                0.413574f, 0.113281f, 0.440918f, 0.132324f,
                0.453613f, 0.156494f, 0.466309f, 0.180664f,
                0.466309f, 0.219238f
            };

        private static readonly byte[] TahomaGlyph1043Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1043Coordinates =
            {
                0.504883f, 0.641113f, 0.170410f, 0.641113f,
                0.170410f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.504883f, 0.727051f,
                0.504883f, 0.641113f
            };

        private static readonly byte[] TahomaGlyph1044Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1044Coordinates =
            {
                0.664063f, -0.164551f, 0.572266f, -0.164551f,
                0.572266f, 0.001953f, 0.100586f, 0.001953f,
                0.100586f, -0.164551f, 0.008789f, -0.164551f,
                0.008789f, 0.085938f, 0.048340f, 0.085938f,
                0.111816f, 0.189941f, 0.150635f, 0.358643f,
                0.189453f, 0.527344f, 0.189453f, 0.727051f,
                0.595215f, 0.727051f, 0.595215f, 0.085938f,
                0.664063f, 0.085938f, 0.664063f, -0.164551f,
                0.498535f, 0.085938f, 0.498535f, 0.643066f,
                0.280273f, 0.643066f, 0.273438f, 0.466797f,
                0.236328f, 0.323242f, 0.199219f, 0.179688f,
                0.141602f, 0.085938f, 0.498535f, 0.085938f
            };

        private static readonly byte[] TahomaGlyph1045Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1045Coordinates =
            {
                0.073730f, 0.000000f, 0.073730f, 0.727051f,
                0.528320f, 0.727051f, 0.528320f, 0.641113f,
                0.170410f, 0.641113f, 0.170410f, 0.441895f,
                0.503906f, 0.441895f, 0.503906f, 0.355957f,
                0.170410f, 0.355957f, 0.170410f, 0.085938f,
                0.528320f, 0.085938f, 0.528320f, 0.000000f,
                0.073730f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1046Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1046Coordinates =
            {
                0.900391f, 0.000000f, 0.781250f, 0.000000f,
                0.539063f, 0.334473f, 0.492188f, 0.334473f,
                0.492188f, 0.000000f, 0.396484f, 0.000000f,
                0.396484f, 0.334473f, 0.348633f, 0.334473f,
                0.106445f, 0.000000f, -0.006836f, 0.000000f,
                0.267578f, 0.375000f, 0.235840f, 0.395508f,
                0.212158f, 0.426758f, 0.188477f, 0.458008f,
                0.166016f, 0.529785f, 0.146484f, 0.592773f,
                0.124268f, 0.616699f, 0.102051f, 0.640625f,
                0.039551f, 0.640625f, 0.020020f, 0.640625f,
                0.020020f, 0.727051f, 0.044922f, 0.727051f,
                0.126465f, 0.727051f, 0.171143f, 0.695801f,
                0.215820f, 0.664551f, 0.245605f, 0.580566f,
                0.252930f, 0.559082f, 0.260254f, 0.538574f,
                0.267578f, 0.518066f, 0.272949f, 0.505371f,
                0.294434f, 0.453125f, 0.324463f, 0.427979f,
                0.354492f, 0.402832f, 0.396484f, 0.398926f,
                0.396484f, 0.727051f, 0.492188f, 0.727051f,
                0.492188f, 0.397949f, 0.537109f, 0.402344f,
                0.567627f, 0.426514f, 0.598145f, 0.450684f,
                0.620605f, 0.505371f, 0.629395f, 0.527344f,
                0.636475f, 0.547119f, 0.643555f, 0.566895f,
                0.647949f, 0.580566f, 0.677246f, 0.664063f,
                0.722656f, 0.695557f, 0.768066f, 0.727051f,
                0.848633f, 0.727051f, 0.873535f, 0.727051f,
                0.873535f, 0.640625f, 0.854004f, 0.640625f,
                0.791504f, 0.640625f, 0.768799f, 0.616455f,
                0.746094f, 0.592285f, 0.726563f, 0.529785f,
                0.706055f, 0.464844f, 0.679688f, 0.432617f,
                0.653320f, 0.400391f, 0.622559f, 0.380859f,
                0.900391f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1047Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1047Coordinates =
            {
                0.449707f, 0.350586f, 0.474121f, 0.329590f,
                0.489990f, 0.298096f, 0.505859f, 0.266602f,
                0.505859f, 0.216797f, 0.505859f, 0.167969f,
                0.486328f, 0.126221f, 0.466797f, 0.084473f,
                0.432617f, 0.053223f, 0.397461f, 0.020996f,
                0.345703f, 0.003906f, 0.293945f, -0.013184f,
                0.230469f, -0.013184f, 0.162598f, -0.013184f,
                0.105957f, 0.000244f, 0.049316f, 0.013672f,
                0.015137f, 0.028320f, 0.015137f, 0.136719f,
                0.021973f, 0.136719f, 0.061035f, 0.110840f,
                0.116943f, 0.091064f, 0.172852f, 0.071289f,
                0.229004f, 0.071289f, 0.264648f, 0.071289f,
                0.300049f, 0.080811f, 0.335449f, 0.090332f,
                0.359375f, 0.111816f, 0.383301f, 0.133301f,
                0.394531f, 0.158447f, 0.405762f, 0.183594f,
                0.405762f, 0.221680f, 0.405762f, 0.258789f,
                0.392334f, 0.284180f, 0.378906f, 0.309570f,
                0.354492f, 0.325195f, 0.330566f, 0.340820f,
                0.297119f, 0.347412f, 0.263672f, 0.354004f,
                0.225586f, 0.354004f, 0.149414f, 0.354004f,
                0.149414f, 0.435059f, 0.215820f, 0.435059f,
                0.292969f, 0.435059f, 0.339844f, 0.465820f,
                0.386719f, 0.496582f, 0.386719f, 0.555664f,
                0.386719f, 0.582520f, 0.375244f, 0.601807f,
                0.363770f, 0.621094f, 0.342773f, 0.633301f,
                0.319824f, 0.646484f, 0.294678f, 0.651123f,
                0.269531f, 0.655762f, 0.239746f, 0.655762f,
                0.208496f, 0.655762f, 0.178223f, 0.648682f,
                0.147949f, 0.641602f, 0.121094f, 0.631348f,
                0.095703f, 0.621094f, 0.076660f, 0.609863f,
                0.057617f, 0.598633f, 0.045410f, 0.591309f,
                0.039063f, 0.591309f, 0.039063f, 0.698242f,
                0.072266f, 0.713867f, 0.129395f, 0.727051f,
                0.186523f, 0.740234f, 0.242188f, 0.740234f,
                0.298340f, 0.740234f, 0.338867f, 0.730713f,
                0.379395f, 0.721191f, 0.413086f, 0.699707f,
                0.449707f, 0.675781f, 0.468018f, 0.643311f,
                0.486328f, 0.610840f, 0.486328f, 0.565918f,
                0.486328f, 0.506836f, 0.447021f, 0.462891f,
                0.407715f, 0.418945f, 0.344238f, 0.405273f,
                0.344238f, 0.397949f, 0.368652f, 0.393555f,
                0.397217f, 0.382324f, 0.425781f, 0.371094f,
                0.449707f, 0.350586f
            };

        private static readonly byte[] TahomaGlyph1048Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1048Coordinates =
            {
                0.596191f, 0.000000f, 0.500000f, 0.000000f,
                0.500000f, 0.577148f, 0.171387f, 0.000000f,
                0.073730f, 0.000000f, 0.073730f, 0.727051f,
                0.169922f, 0.727051f, 0.169922f, 0.159180f,
                0.494141f, 0.727051f, 0.596191f, 0.727051f,
                0.596191f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1049Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1049Coordinates =
            {
                0.596191f, 0.000000f, 0.500000f, 0.000000f,
                0.500000f, 0.577148f, 0.171387f, 0.000000f,
                0.073730f, 0.000000f, 0.073730f, 0.727051f,
                0.169922f, 0.727051f, 0.169922f, 0.159180f,
                0.494141f, 0.727051f, 0.596191f, 0.727051f,
                0.596191f, 0.000000f, 0.524902f, 0.944824f,
                0.522949f, 0.871582f, 0.478516f, 0.826660f,
                0.434082f, 0.781738f, 0.344238f, 0.781738f,
                0.254395f, 0.781738f, 0.209961f, 0.826660f,
                0.165527f, 0.871582f, 0.163574f, 0.944824f,
                0.250488f, 0.944824f, 0.251465f, 0.890137f,
                0.274902f, 0.865967f, 0.298340f, 0.841797f,
                0.344238f, 0.841797f, 0.390625f, 0.841797f,
                0.413818f, 0.865723f, 0.437012f, 0.889648f,
                0.437988f, 0.944824f, 0.524902f, 0.944824f
            };

        private static readonly byte[] TahomaGlyph1050Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1050Coordinates =
            {
                0.611328f, 0.000000f, 0.488281f, 0.000000f,
                0.231445f, 0.333008f, 0.170410f, 0.333008f,
                0.170410f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.170410f, 0.727051f,
                0.170410f, 0.399414f, 0.227539f, 0.401367f,
                0.260986f, 0.428223f, 0.294434f, 0.455078f,
                0.315430f, 0.505371f, 0.324219f, 0.527344f,
                0.331299f, 0.547119f, 0.338379f, 0.566895f,
                0.342773f, 0.580566f, 0.372070f, 0.664063f,
                0.417480f, 0.695557f, 0.462891f, 0.727051f,
                0.543457f, 0.727051f, 0.573242f, 0.727051f,
                0.573242f, 0.640625f, 0.548828f, 0.640625f,
                0.489258f, 0.640625f, 0.465332f, 0.617432f,
                0.441406f, 0.594238f, 0.421387f, 0.529785f,
                0.401367f, 0.465332f, 0.376465f, 0.435303f,
                0.351563f, 0.405273f, 0.316406f, 0.382324f,
                0.611328f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1051Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1051Coordinates =
            {
                0.604004f, 0.000000f, 0.507324f, 0.000000f,
                0.507324f, 0.641113f, 0.262207f, 0.641113f,
                0.260742f, 0.585938f, 0.258301f, 0.533447f,
                0.255859f, 0.480957f, 0.254395f, 0.439453f,
                0.250488f, 0.336426f, 0.241943f, 0.269043f,
                0.233398f, 0.201660f, 0.219727f, 0.156250f,
                0.206543f, 0.111816f, 0.188721f, 0.084473f,
                0.170898f, 0.057129f, 0.149902f, 0.038574f,
                0.127930f, 0.018555f, 0.102783f, 0.008545f,
                0.077637f, -0.001465f, 0.044434f, -0.001465f,
                0.034180f, -0.001465f, 0.023682f, -0.000732f,
                0.013184f, 0.000000f, 0.007324f, 0.000000f,
                0.007324f, 0.093750f, 0.014160f, 0.093750f,
                0.019043f, 0.093262f, 0.022461f, 0.092773f,
                0.025879f, 0.092285f, 0.032715f, 0.092285f,
                0.050293f, 0.092285f, 0.065430f, 0.097656f,
                0.080566f, 0.103027f, 0.091309f, 0.114258f,
                0.124512f, 0.146973f, 0.139893f, 0.230713f,
                0.155273f, 0.314453f, 0.161621f, 0.456055f,
                0.164063f, 0.503906f, 0.166504f, 0.582520f,
                0.168945f, 0.661133f, 0.170898f, 0.727051f,
                0.604004f, 0.727051f, 0.604004f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1052Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1052Coordinates =
            {
                0.696777f, 0.000000f, 0.600098f, 0.000000f,
                0.600098f, 0.626465f, 0.410645f, 0.200195f,
                0.352051f, 0.200195f, 0.164063f, 0.626465f,
                0.164063f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.205566f, 0.727051f,
                0.387207f, 0.322266f, 0.562500f, 0.727051f,
                0.696777f, 0.727051f, 0.696777f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1053Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1053Coordinates =
            {
                0.601563f, 0.000000f, 0.504883f, 0.000000f,
                0.504883f, 0.355957f, 0.170410f, 0.355957f,
                0.170410f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.170410f, 0.727051f,
                0.170410f, 0.441895f, 0.504883f, 0.441895f,
                0.504883f, 0.727051f, 0.601563f, 0.727051f,
                0.601563f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1054Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1054Coordinates =
            {
                0.587891f, 0.643555f, 0.629395f, 0.595703f,
                0.652344f, 0.524902f, 0.675293f, 0.454102f,
                0.675293f, 0.363281f, 0.675293f, 0.274902f,
                0.652832f, 0.203613f, 0.630371f, 0.132324f,
                0.587891f, 0.083984f, 0.543457f, 0.033203f,
                0.484131f, 0.009033f, 0.424805f, -0.015137f,
                0.353516f, -0.015137f, 0.279785f, -0.015137f,
                0.220703f, 0.009766f, 0.161621f, 0.034668f,
                0.119141f, 0.083984f, 0.077148f, 0.132324f,
                0.054688f, 0.203125f, 0.032227f, 0.273926f,
                0.032227f, 0.363281f, 0.032227f, 0.455078f,
                0.054932f, 0.524414f, 0.077637f, 0.593750f,
                0.119629f, 0.643555f, 0.161621f, 0.691895f,
                0.220947f, 0.717041f, 0.280273f, 0.742188f,
                0.353516f, 0.742188f, 0.427734f, 0.742188f,
                0.487305f, 0.716309f, 0.546875f, 0.690430f,
                0.587891f, 0.643555f, 0.574707f, 0.363281f,
                0.574707f, 0.435547f, 0.559082f, 0.491211f,
                0.543457f, 0.546875f, 0.515137f, 0.583496f,
                0.486328f, 0.621094f, 0.445557f, 0.639893f,
                0.404785f, 0.658691f, 0.354004f, 0.658691f,
                0.301270f, 0.658691f, 0.261963f, 0.640381f,
                0.222656f, 0.622070f, 0.192383f, 0.583496f,
                0.163574f, 0.546387f, 0.148193f, 0.490234f,
                0.132813f, 0.434082f, 0.132813f, 0.363281f,
                0.132813f, 0.220215f, 0.192871f, 0.144287f,
                0.252930f, 0.068359f, 0.354004f, 0.068359f,
                0.455078f, 0.068359f, 0.514893f, 0.144287f,
                0.574707f, 0.220215f, 0.574707f, 0.363281f
            };

        private static readonly byte[] TahomaGlyph1055Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1055Coordinates =
            {
                0.601563f, 0.000000f, 0.504883f, 0.000000f,
                0.504883f, 0.641113f, 0.170410f, 0.641113f,
                0.170410f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.601563f, 0.727051f,
                0.601563f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1056Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1056Coordinates =
            {
                0.532715f, 0.507813f, 0.532715f, 0.460449f,
                0.515869f, 0.418213f, 0.499023f, 0.375977f,
                0.469238f, 0.346191f, 0.431641f, 0.309082f,
                0.380859f, 0.290039f, 0.330078f, 0.270996f,
                0.252441f, 0.270996f, 0.170410f, 0.270996f,
                0.170410f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.256348f, 0.727051f,
                0.320801f, 0.727051f, 0.366211f, 0.716309f,
                0.411621f, 0.705566f, 0.446289f, 0.681641f,
                0.486816f, 0.653809f, 0.509766f, 0.611084f,
                0.532715f, 0.568359f, 0.532715f, 0.507813f,
                0.432129f, 0.505371f, 0.432129f, 0.542969f,
                0.419189f, 0.570801f, 0.406250f, 0.598633f,
                0.379883f, 0.616211f, 0.356934f, 0.631348f,
                0.326416f, 0.637695f, 0.295898f, 0.644043f,
                0.250488f, 0.644043f, 0.170410f, 0.644043f,
                0.170410f, 0.353516f, 0.236328f, 0.353516f,
                0.294922f, 0.353516f, 0.331055f, 0.363037f,
                0.367188f, 0.372559f, 0.391113f, 0.396973f,
                0.412598f, 0.418945f, 0.422363f, 0.444824f,
                0.432129f, 0.470703f, 0.432129f, 0.505371f
            };

        private static readonly byte[] TahomaGlyph1057Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1057Coordinates =
            {
                0.357910f, -0.013184f, 0.286621f, -0.013184f,
                0.226807f, 0.010742f, 0.166992f, 0.034668f,
                0.123535f, 0.082031f, 0.080078f, 0.129395f,
                0.056152f, 0.200195f, 0.032227f, 0.270996f,
                0.032227f, 0.362793f, 0.032227f, 0.454102f,
                0.055420f, 0.521973f, 0.078613f, 0.589844f,
                0.123047f, 0.640137f, 0.166504f, 0.688965f,
                0.226074f, 0.714600f, 0.285645f, 0.740234f,
                0.359375f, 0.740234f, 0.395996f, 0.740234f,
                0.427979f, 0.734863f, 0.459961f, 0.729492f,
                0.487305f, 0.721191f, 0.510742f, 0.713867f,
                0.535400f, 0.702881f, 0.560059f, 0.691895f,
                0.583984f, 0.678711f, 0.583984f, 0.562012f,
                0.576172f, 0.562012f, 0.563477f, 0.573730f,
                0.543457f, 0.590332f, 0.523438f, 0.606934f,
                0.494629f, 0.623047f, 0.466797f, 0.638184f,
                0.434082f, 0.647949f, 0.401367f, 0.657715f,
                0.358398f, 0.657715f, 0.312012f, 0.657715f,
                0.270508f, 0.638672f, 0.229004f, 0.619629f,
                0.197754f, 0.582520f, 0.166992f, 0.545410f,
                0.149902f, 0.489258f, 0.132813f, 0.433105f,
                0.132813f, 0.362793f, 0.132813f, 0.288086f,
                0.150879f, 0.234131f, 0.168945f, 0.180176f,
                0.200195f, 0.143066f, 0.230469f, 0.106934f,
                0.271484f, 0.088623f, 0.312500f, 0.070313f,
                0.358398f, 0.070313f, 0.400391f, 0.070313f,
                0.436035f, 0.080566f, 0.471680f, 0.090820f,
                0.499512f, 0.106445f, 0.526367f, 0.121582f,
                0.545898f, 0.137451f, 0.565430f, 0.153320f,
                0.576660f, 0.164551f, 0.583984f, 0.164551f,
                0.583984f, 0.049316f, 0.560059f, 0.038086f,
                0.538818f, 0.027832f, 0.517578f, 0.017578f,
                0.487305f, 0.007813f, 0.455566f, -0.002441f,
                0.428467f, -0.007813f, 0.401367f, -0.013184f,
                0.357910f, -0.013184f
            };

        private static readonly byte[] TahomaGlyph1058Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1058Coordinates =
            {
                0.243652f, 0.000000f, 0.243652f, 0.641113f,
                -0.000488f, 0.641113f, -0.000488f, 0.727051f,
                0.584473f, 0.727051f, 0.584473f, 0.641113f,
                0.340332f, 0.641113f, 0.340332f, 0.000000f,
                0.243652f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1059Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1059Coordinates =
            {
                0.581543f, 0.727051f, 0.317871f, 0.114746f,
                0.301270f, 0.076172f, 0.280518f, 0.052734f,
                0.259766f, 0.029297f, 0.237305f, 0.017578f,
                0.214844f, 0.005371f, 0.193115f, 0.001465f,
                0.171387f, -0.002441f, 0.149414f, -0.002441f,
                0.129883f, -0.002441f, 0.103516f, -0.001465f,
                0.077148f, -0.000488f, 0.069824f, 0.000000f,
                0.069824f, 0.090332f, 0.076660f, 0.090332f,
                0.083984f, 0.089355f, 0.098877f, 0.088135f,
                0.113770f, 0.086914f, 0.136719f, 0.086914f,
                0.147461f, 0.086914f, 0.162109f, 0.088135f,
                0.176758f, 0.089355f, 0.188965f, 0.095215f,
                0.203125f, 0.102051f, 0.215576f, 0.113525f,
                0.228027f, 0.125000f, 0.238281f, 0.149902f,
                0.254883f, 0.188477f, -0.000488f, 0.727051f,
                0.106445f, 0.727051f, 0.303711f, 0.299316f,
                0.481934f, 0.727051f, 0.581543f, 0.727051f
            };

        private static readonly byte[] TahomaGlyph1060Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1060Coordinates =
            {
                0.716309f, 0.371094f, 0.716309f, 0.303223f,
                0.695801f, 0.251221f, 0.675293f, 0.199219f,
                0.638672f, 0.163574f, 0.599121f, 0.124512f,
                0.541504f, 0.103271f, 0.483887f, 0.082031f,
                0.422363f, 0.080566f, 0.422363f, -0.007813f,
                0.326172f, -0.007813f, 0.326172f, 0.080566f,
                0.265137f, 0.082520f, 0.207520f, 0.102539f,
                0.149902f, 0.122559f, 0.109375f, 0.162598f,
                0.072754f, 0.198242f, 0.052490f, 0.250977f,
                0.032227f, 0.303711f, 0.032227f, 0.371094f,
                0.032227f, 0.434570f, 0.051758f, 0.485107f,
                0.071289f, 0.535645f, 0.106445f, 0.572266f,
                0.144043f, 0.611328f, 0.200684f, 0.633789f,
                0.257324f, 0.656250f, 0.326172f, 0.658203f,
                0.326172f, 0.738770f, 0.422363f, 0.738770f,
                0.422363f, 0.658203f, 0.491211f, 0.656738f,
                0.548340f, 0.634033f, 0.605469f, 0.611328f,
                0.643066f, 0.572754f, 0.678223f, 0.536621f,
                0.697266f, 0.486328f, 0.716309f, 0.436035f,
                0.716309f, 0.371094f, 0.615723f, 0.375000f,
                0.615723f, 0.423340f, 0.602051f, 0.463135f,
                0.588379f, 0.502930f, 0.561523f, 0.530762f,
                0.536133f, 0.557129f, 0.502441f, 0.569824f,
                0.468750f, 0.582520f, 0.422363f, 0.583496f,
                0.422363f, 0.153809f, 0.466309f, 0.154785f,
                0.500732f, 0.168213f, 0.535156f, 0.181641f,
                0.557617f, 0.204102f, 0.587402f, 0.233398f,
                0.601563f, 0.275391f, 0.615723f, 0.317383f,
                0.615723f, 0.375000f, 0.326172f, 0.153809f,
                0.326172f, 0.583496f, 0.279785f, 0.583008f,
                0.246094f, 0.569824f, 0.212402f, 0.556641f,
                0.187012f, 0.530762f, 0.160156f, 0.503418f,
                0.146484f, 0.462891f, 0.132813f, 0.422363f,
                0.132813f, 0.375000f, 0.132813f, 0.317383f,
                0.146973f, 0.275146f, 0.161133f, 0.232910f,
                0.190918f, 0.204102f, 0.213379f, 0.182617f,
                0.247803f, 0.168457f, 0.282227f, 0.154297f,
                0.326172f, 0.153809f
            };

        private static readonly byte[] TahomaGlyph1061Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1061Coordinates =
            {
                0.576660f, 0.000000f, 0.465820f, 0.000000f,
                0.288574f, 0.291016f, 0.108398f, 0.000000f,
                0.003906f, 0.000000f, 0.234863f, 0.363770f,
                0.010742f, 0.727051f, 0.121094f, 0.727051f,
                0.294922f, 0.441406f, 0.471191f, 0.727051f,
                0.576172f, 0.727051f, 0.348633f, 0.368652f,
                0.576660f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1062Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1062Coordinates =
            {
                0.665527f, -0.164551f, 0.573730f, -0.164551f,
                0.573730f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.170410f, 0.727051f,
                0.170410f, 0.084961f, 0.500000f, 0.084961f,
                0.500000f, 0.727051f, 0.596680f, 0.727051f,
                0.596680f, 0.084961f, 0.665527f, 0.084961f,
                0.665527f, -0.164551f
            };

        private static readonly byte[] TahomaGlyph1063Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1063Coordinates =
            {
                0.562012f, 0.000000f, 0.465332f, 0.000000f,
                0.465332f, 0.307617f, 0.405762f, 0.288086f,
                0.359375f, 0.278320f, 0.312988f, 0.268555f,
                0.262207f, 0.268555f, 0.215332f, 0.268555f,
                0.176270f, 0.280029f, 0.137207f, 0.291504f,
                0.107422f, 0.316895f, 0.078125f, 0.342285f,
                0.061768f, 0.382324f, 0.045410f, 0.422363f,
                0.045410f, 0.477051f, 0.045410f, 0.727051f,
                0.142090f, 0.727051f, 0.142090f, 0.525391f,
                0.142090f, 0.479492f, 0.145508f, 0.452881f,
                0.148926f, 0.426270f, 0.165039f, 0.401855f,
                0.179199f, 0.380371f, 0.207031f, 0.368896f,
                0.234863f, 0.357422f, 0.281250f, 0.357422f,
                0.322754f, 0.357422f, 0.375000f, 0.366943f,
                0.427246f, 0.376465f, 0.465332f, 0.390625f,
                0.465332f, 0.727051f, 0.562012f, 0.727051f,
                0.562012f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1064Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1064Coordinates =
            {
                0.869629f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.170410f, 0.727051f,
                0.170410f, 0.083984f, 0.423340f, 0.083984f,
                0.423340f, 0.727051f, 0.520020f, 0.727051f,
                0.520020f, 0.083984f, 0.772949f, 0.083984f,
                0.772949f, 0.727051f, 0.869629f, 0.727051f,
                0.869629f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1065Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1065Coordinates =
            {
                0.938477f, -0.164551f, 0.846680f, -0.164551f,
                0.846680f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.170410f, 0.727051f,
                0.170410f, 0.083984f, 0.423340f, 0.083984f,
                0.423340f, 0.727051f, 0.520020f, 0.727051f,
                0.520020f, 0.083984f, 0.772949f, 0.083984f,
                0.772949f, 0.727051f, 0.869629f, 0.727051f,
                0.869629f, 0.083984f, 0.938477f, 0.083984f,
                0.938477f, -0.164551f
            };

        private static readonly byte[] TahomaGlyph1066Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1066Coordinates =
            {
                0.670898f, 0.225098f, 0.670898f, 0.172363f,
                0.650391f, 0.129395f, 0.629883f, 0.086426f,
                0.595215f, 0.059570f, 0.554199f, 0.027344f,
                0.507324f, 0.013672f, 0.460449f, 0.000000f,
                0.386230f, 0.000000f, 0.188965f, 0.000000f,
                0.188965f, 0.641113f, -0.000488f, 0.641113f,
                -0.000488f, 0.727051f, 0.285645f, 0.727051f,
                0.285645f, 0.441895f, 0.389160f, 0.441895f,
                0.463379f, 0.441895f, 0.510254f, 0.433350f,
                0.557129f, 0.424805f, 0.598633f, 0.392578f,
                0.635742f, 0.363770f, 0.653320f, 0.321289f,
                0.670898f, 0.278809f, 0.670898f, 0.225098f,
                0.569824f, 0.223145f, 0.569824f, 0.259766f,
                0.557861f, 0.287598f, 0.545898f, 0.315430f,
                0.520020f, 0.332520f, 0.493164f, 0.350586f,
                0.458008f, 0.354492f, 0.422852f, 0.358398f,
                0.358887f, 0.358398f, 0.285645f, 0.358398f,
                0.285645f, 0.082520f, 0.356445f, 0.082520f,
                0.421387f, 0.082520f, 0.456299f, 0.088867f,
                0.491211f, 0.095215f, 0.517578f, 0.113281f,
                0.544922f, 0.132324f, 0.557373f, 0.157959f,
                0.569824f, 0.183594f, 0.569824f, 0.223145f
            };

        private static readonly byte[] TahomaGlyph1067Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1067Coordinates =
            {
                0.553223f, 0.225098f, 0.553223f, 0.172363f,
                0.532715f, 0.129395f, 0.512207f, 0.086426f,
                0.477539f, 0.059570f, 0.436523f, 0.027344f,
                0.389648f, 0.013672f, 0.342773f, 0.000000f,
                0.268555f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.170410f, 0.727051f,
                0.170410f, 0.441895f, 0.271484f, 0.441895f,
                0.345703f, 0.441895f, 0.392578f, 0.433350f,
                0.439453f, 0.424805f, 0.480957f, 0.392578f,
                0.518066f, 0.363770f, 0.535645f, 0.321289f,
                0.553223f, 0.278809f, 0.553223f, 0.225098f,
                0.452148f, 0.223145f, 0.452148f, 0.259766f,
                0.440186f, 0.287598f, 0.428223f, 0.315430f,
                0.402344f, 0.332520f, 0.375488f, 0.350586f,
                0.340332f, 0.354492f, 0.305176f, 0.358398f,
                0.241211f, 0.358398f, 0.170410f, 0.358398f,
                0.170410f, 0.082520f, 0.238770f, 0.082520f,
                0.303711f, 0.082520f, 0.338623f, 0.088867f,
                0.373535f, 0.095215f, 0.399902f, 0.113281f,
                0.427246f, 0.132324f, 0.439697f, 0.157959f,
                0.452148f, 0.183594f, 0.452148f, 0.223145f,
                0.714844f, 0.000000f, 0.618164f, 0.000000f,
                0.618164f, 0.727051f, 0.714844f, 0.727051f,
                0.714844f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1068Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1068Coordinates =
            {
                0.563965f, 0.225098f, 0.563965f, 0.172363f,
                0.543457f, 0.129395f, 0.522949f, 0.086426f,
                0.488281f, 0.059570f, 0.447266f, 0.027344f,
                0.400391f, 0.013672f, 0.353516f, 0.000000f,
                0.279297f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.170410f, 0.727051f,
                0.170410f, 0.441895f, 0.282227f, 0.441895f,
                0.356445f, 0.441895f, 0.403320f, 0.433350f,
                0.450195f, 0.424805f, 0.491699f, 0.392578f,
                0.528809f, 0.363770f, 0.546387f, 0.321289f,
                0.563965f, 0.278809f, 0.563965f, 0.225098f,
                0.462891f, 0.223145f, 0.462891f, 0.259766f,
                0.450928f, 0.287598f, 0.438965f, 0.315430f,
                0.413086f, 0.332520f, 0.386230f, 0.350586f,
                0.351074f, 0.354492f, 0.315918f, 0.358398f,
                0.251953f, 0.358398f, 0.170410f, 0.358398f,
                0.170410f, 0.082520f, 0.249512f, 0.082520f,
                0.314453f, 0.082520f, 0.349365f, 0.088867f,
                0.384277f, 0.095215f, 0.410645f, 0.113281f,
                0.437988f, 0.132324f, 0.450439f, 0.157959f,
                0.462891f, 0.183594f, 0.462891f, 0.223145f
            };

        private static readonly byte[] TahomaGlyph1069Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1069Coordinates =
            {
                0.567383f, 0.366211f, 0.567383f, 0.192871f,
                0.475830f, 0.089844f, 0.384277f, -0.013184f,
                0.236328f, -0.013184f, 0.173828f, -0.013184f,
                0.118408f, -0.000732f, 0.062988f, 0.011719f,
                0.020996f, 0.031250f, 0.020996f, 0.138184f,
                0.028320f, 0.138184f, 0.063477f, 0.106445f,
                0.117676f, 0.087646f, 0.171875f, 0.068848f,
                0.233398f, 0.068848f, 0.338379f, 0.068848f,
                0.404297f, 0.145508f, 0.470215f, 0.222168f,
                0.470215f, 0.347656f, 0.115723f, 0.347656f,
                0.115723f, 0.432129f, 0.465332f, 0.432129f,
                0.454102f, 0.537598f, 0.392334f, 0.597900f,
                0.330566f, 0.658203f, 0.233398f, 0.658203f,
                0.173340f, 0.658203f, 0.121094f, 0.639648f,
                0.068848f, 0.621094f, 0.030273f, 0.587891f,
                0.022949f, 0.587891f, 0.022949f, 0.695313f,
                0.062012f, 0.713379f, 0.118896f, 0.726807f,
                0.175781f, 0.740234f, 0.237305f, 0.740234f,
                0.394531f, 0.740234f, 0.480957f, 0.642822f,
                0.567383f, 0.545410f, 0.567383f, 0.366211f
            };

        private static readonly byte[] TahomaGlyph1070Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1070Coordinates =
            {
                0.918945f, 0.363281f, 0.918945f, 0.183594f,
                0.832031f, 0.084229f, 0.745117f, -0.015137f,
                0.600586f, -0.015137f, 0.456055f, -0.015137f,
                0.371826f, 0.081543f, 0.287598f, 0.178223f,
                0.284668f, 0.351563f, 0.170410f, 0.351563f,
                0.170410f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.170410f, 0.727051f,
                0.170410f, 0.436035f, 0.289551f, 0.436035f,
                0.307129f, 0.582520f, 0.389160f, 0.662354f,
                0.471191f, 0.742188f, 0.600586f, 0.742188f,
                0.745117f, 0.742188f, 0.832031f, 0.643311f,
                0.918945f, 0.544434f, 0.918945f, 0.363281f,
                0.818359f, 0.363281f, 0.818359f, 0.507813f,
                0.759521f, 0.583252f, 0.700684f, 0.658691f,
                0.601074f, 0.658691f, 0.500000f, 0.658691f,
                0.441162f, 0.583252f, 0.382324f, 0.507813f,
                0.382324f, 0.363281f, 0.382324f, 0.220215f,
                0.441406f, 0.144287f, 0.500488f, 0.068359f,
                0.601074f, 0.068359f, 0.700684f, 0.068359f,
                0.759521f, 0.144043f, 0.818359f, 0.219727f,
                0.818359f, 0.363281f
            };

        private static readonly byte[] TahomaGlyph1071Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1071Coordinates =
            {
                0.537598f, 0.000000f, 0.440918f, 0.000000f,
                0.440918f, 0.289063f, 0.331055f, 0.289063f,
                0.113770f, 0.000000f, -0.002441f, 0.000000f,
                0.230957f, 0.303711f, 0.157715f, 0.328613f,
                0.117432f, 0.380615f, 0.077148f, 0.432617f,
                0.077148f, 0.520020f, 0.077148f, 0.575684f,
                0.100342f, 0.615967f, 0.123535f, 0.656250f,
                0.161621f, 0.683105f, 0.196289f, 0.707520f,
                0.242676f, 0.717285f, 0.289063f, 0.727051f,
                0.345215f, 0.727051f, 0.537598f, 0.727051f,
                0.537598f, 0.000000f, 0.440918f, 0.369629f,
                0.440918f, 0.644043f, 0.340332f, 0.644043f,
                0.298340f, 0.644043f, 0.272949f, 0.638672f,
                0.247559f, 0.633301f, 0.226563f, 0.619141f,
                0.204102f, 0.604004f, 0.191406f, 0.576660f,
                0.178711f, 0.549316f, 0.178711f, 0.516602f,
                0.178711f, 0.477539f, 0.187744f, 0.451660f,
                0.196777f, 0.425781f, 0.216797f, 0.405762f,
                0.238770f, 0.384277f, 0.270508f, 0.376953f,
                0.302246f, 0.369629f, 0.344238f, 0.369629f,
                0.440918f, 0.369629f
            };

        private static readonly byte[] TahomaGlyph1072Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1072Coordinates =
            {
                0.371094f, 0.134277f, 0.371094f, 0.285645f,
                0.338379f, 0.282715f, 0.288330f, 0.277588f,
                0.238281f, 0.272461f, 0.207520f, 0.263184f,
                0.170898f, 0.251953f, 0.146973f, 0.228760f,
                0.123047f, 0.205566f, 0.123047f, 0.164063f,
                0.123047f, 0.117188f, 0.149414f, 0.093262f,
                0.175781f, 0.069336f, 0.226563f, 0.069336f,
                0.270020f, 0.069336f, 0.305176f, 0.088135f,
                0.340332f, 0.106934f, 0.371094f, 0.134277f,
                0.371094f, 0.058105f, 0.359863f, 0.049805f,
                0.341064f, 0.034912f, 0.322266f, 0.020020f,
                0.304688f, 0.011230f, 0.280273f, -0.001465f,
                0.257568f, -0.008301f, 0.234863f, -0.015137f,
                0.193848f, -0.015137f, 0.160156f, -0.015137f,
                0.129883f, -0.002441f, 0.099609f, 0.010254f,
                0.076660f, 0.033203f, 0.054688f, 0.055664f,
                0.041504f, 0.088623f, 0.028320f, 0.121582f,
                0.028320f, 0.158203f, 0.028320f, 0.214844f,
                0.052246f, 0.254639f, 0.076172f, 0.294434f,
                0.127930f, 0.317871f, 0.173828f, 0.338867f,
                0.236328f, 0.346924f, 0.298828f, 0.354980f,
                0.371094f, 0.358887f, 0.371094f, 0.376465f,
                0.371094f, 0.408691f, 0.361328f, 0.428467f,
                0.351563f, 0.448242f, 0.333984f, 0.458984f,
                0.316406f, 0.470215f, 0.291016f, 0.473877f,
                0.265625f, 0.477539f, 0.238770f, 0.477539f,
                0.207031f, 0.477539f, 0.164063f, 0.468018f,
                0.121094f, 0.458496f, 0.078125f, 0.440430f,
                0.072754f, 0.440430f, 0.072754f, 0.533691f,
                0.098145f, 0.541016f, 0.145508f, 0.549805f,
                0.192871f, 0.558594f, 0.239258f, 0.558594f,
                0.295410f, 0.558594f, 0.333984f, 0.549805f,
                0.372559f, 0.541016f, 0.403320f, 0.518066f,
                0.433105f, 0.495605f, 0.447754f, 0.459961f,
                0.462402f, 0.424316f, 0.462402f, 0.373047f,
                0.462402f, 0.000000f, 0.371094f, 0.000000f,
                0.371094f, 0.058105f
            };

        private static readonly byte[] TahomaGlyph1073Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1073Coordinates =
            {
                0.453125f, 0.464844f, 0.484863f, 0.432617f,
                0.502441f, 0.383057f, 0.520020f, 0.333496f,
                0.520020f, 0.268066f, 0.520020f, 0.205078f,
                0.500000f, 0.151611f, 0.479980f, 0.098145f,
                0.445801f, 0.061523f, 0.410645f, 0.023438f,
                0.367920f, 0.004150f, 0.325195f, -0.015137f,
                0.274902f, -0.015137f, 0.223633f, -0.015137f,
                0.180908f, 0.002686f, 0.138184f, 0.020508f,
                0.107910f, 0.057617f, 0.070313f, 0.104004f,
                0.051514f, 0.173828f, 0.032715f, 0.243652f,
                0.032715f, 0.346680f, 0.032715f, 0.383301f,
                0.035889f, 0.421143f, 0.039063f, 0.458984f,
                0.049805f, 0.511719f, 0.059570f, 0.558594f,
                0.076172f, 0.598877f, 0.092773f, 0.639160f,
                0.119629f, 0.666992f, 0.154297f, 0.703125f,
                0.210205f, 0.724609f, 0.266113f, 0.746094f,
                0.358398f, 0.754395f, 0.391113f, 0.757324f,
                0.428467f, 0.760010f, 0.465820f, 0.762695f,
                0.485352f, 0.764160f, 0.485352f, 0.679688f,
                0.459961f, 0.678223f, 0.431152f, 0.676025f,
                0.402344f, 0.673828f, 0.365234f, 0.670898f,
                0.315918f, 0.666992f, 0.262207f, 0.653564f,
                0.208496f, 0.640137f, 0.181152f, 0.611816f,
                0.160645f, 0.590820f, 0.148438f, 0.551758f,
                0.136230f, 0.512695f, 0.131348f, 0.464844f,
                0.167480f, 0.490723f, 0.208740f, 0.508545f,
                0.250000f, 0.526367f, 0.297852f, 0.526367f,
                0.342285f, 0.526367f, 0.382324f, 0.511475f,
                0.422363f, 0.496582f, 0.453125f, 0.464844f,
                0.426758f, 0.262695f, 0.426758f, 0.349609f,
                0.387695f, 0.395996f, 0.348633f, 0.442383f,
                0.276367f, 0.442383f, 0.236816f, 0.442383f,
                0.199707f, 0.429199f, 0.162598f, 0.416016f,
                0.129883f, 0.394043f, 0.128906f, 0.381836f,
                0.127930f, 0.364990f, 0.126953f, 0.348145f,
                0.126953f, 0.334473f, 0.126953f, 0.249512f,
                0.140625f, 0.196289f, 0.154297f, 0.143066f,
                0.178711f, 0.112793f, 0.200684f, 0.085449f,
                0.225098f, 0.074951f, 0.249512f, 0.064453f,
                0.278320f, 0.064453f, 0.348633f, 0.064453f,
                0.387695f, 0.117676f, 0.426758f, 0.170898f,
                0.426758f, 0.262695f
            };

        private static readonly byte[] TahomaGlyph1074Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1074Coordinates =
            {
                0.494141f, 0.165039f, 0.494141f, 0.125488f,
                0.479004f, 0.094971f, 0.463867f, 0.064453f,
                0.437500f, 0.043945f, 0.404297f, 0.018066f,
                0.367920f, 0.009033f, 0.331543f, 0.000000f,
                0.280762f, 0.000000f, 0.066406f, 0.000000f,
                0.066406f, 0.545410f, 0.266602f, 0.545410f,
                0.326660f, 0.545410f, 0.354492f, 0.541748f,
                0.382324f, 0.538086f, 0.409668f, 0.522949f,
                0.438477f, 0.507324f, 0.452148f, 0.481445f,
                0.465820f, 0.455566f, 0.465820f, 0.419922f,
                0.465820f, 0.380859f, 0.444336f, 0.349854f,
                0.422852f, 0.318848f, 0.387207f, 0.301758f,
                0.389648f, 0.298340f, 0.434082f, 0.287109f,
                0.464111f, 0.252930f, 0.494141f, 0.218750f,
                0.494141f, 0.165039f, 0.371582f, 0.405762f,
                0.371582f, 0.424316f, 0.365479f, 0.437988f,
                0.359375f, 0.451660f, 0.344238f, 0.459473f,
                0.326660f, 0.468750f, 0.304932f, 0.470459f,
                0.283203f, 0.472168f, 0.244629f, 0.472168f,
                0.157227f, 0.472168f, 0.157227f, 0.322754f,
                0.262695f, 0.322754f, 0.296387f, 0.322754f,
                0.310547f, 0.325928f, 0.324707f, 0.329102f,
                0.341797f, 0.339355f, 0.357910f, 0.349121f,
                0.364746f, 0.365723f, 0.371582f, 0.382324f,
                0.371582f, 0.405762f, 0.399414f, 0.164551f,
                0.399414f, 0.192383f, 0.391357f, 0.209229f,
                0.383301f, 0.226074f, 0.355957f, 0.239258f,
                0.338867f, 0.247559f, 0.319336f, 0.249512f,
                0.299805f, 0.251465f, 0.265137f, 0.251465f,
                0.157227f, 0.251465f, 0.157227f, 0.073242f,
                0.236816f, 0.073242f, 0.286133f, 0.073242f,
                0.313477f, 0.077148f, 0.340820f, 0.081055f,
                0.360352f, 0.092773f, 0.380859f, 0.105469f,
                0.390137f, 0.122070f, 0.399414f, 0.138672f,
                0.399414f, 0.164551f
            };

        private static readonly byte[] TahomaGlyph1075Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1075Coordinates =
            {
                0.413086f, 0.464844f, 0.158203f, 0.464844f,
                0.158203f, 0.000000f, 0.066406f, 0.000000f,
                0.066406f, 0.545410f, 0.413086f, 0.545410f,
                0.413086f, 0.464844f
            };

        private static readonly byte[] TahomaGlyph1076Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1076Coordinates =
            {
                0.534180f, -0.130859f, 0.448730f, -0.130859f,
                0.448730f, 0.001465f, 0.089355f, 0.001465f,
                0.089355f, -0.130859f, 0.003906f, -0.130859f,
                0.003906f, 0.078125f, 0.040039f, 0.078125f,
                0.086426f, 0.154297f, 0.115967f, 0.277100f,
                0.145508f, 0.399902f, 0.145508f, 0.545410f,
                0.479980f, 0.545410f, 0.479980f, 0.078125f,
                0.534180f, 0.078125f, 0.534180f, -0.130859f,
                0.388184f, 0.078125f, 0.388184f, 0.468262f,
                0.231934f, 0.468262f, 0.225586f, 0.346191f,
                0.198486f, 0.245361f, 0.171387f, 0.144531f,
                0.130371f, 0.078125f, 0.388184f, 0.078125f
            };

        private static readonly byte[] TahomaGlyph1077Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1077Coordinates =
            {
                0.303223f, -0.012695f, 0.172852f, -0.012695f,
                0.100830f, 0.060791f, 0.028809f, 0.134277f,
                0.028809f, 0.269531f, 0.028809f, 0.402832f,
                0.098633f, 0.481689f, 0.168457f, 0.560547f,
                0.281250f, 0.560547f, 0.332031f, 0.560547f,
                0.371094f, 0.545898f, 0.410156f, 0.531250f,
                0.439453f, 0.500000f, 0.468750f, 0.468750f,
                0.484375f, 0.423584f, 0.500000f, 0.378418f,
                0.500000f, 0.312988f, 0.500000f, 0.263184f,
                0.122070f, 0.263184f, 0.122070f, 0.167969f,
                0.169922f, 0.117676f, 0.217773f, 0.067383f,
                0.302246f, 0.067383f, 0.332520f, 0.067383f,
                0.361572f, 0.074219f, 0.390625f, 0.081055f,
                0.414063f, 0.091797f, 0.438965f, 0.103027f,
                0.456055f, 0.113525f, 0.473145f, 0.124023f,
                0.484375f, 0.133301f, 0.489746f, 0.133301f,
                0.489746f, 0.033203f, 0.473633f, 0.026855f,
                0.449707f, 0.017334f, 0.425781f, 0.007813f,
                0.406738f, 0.002441f, 0.379883f, -0.004883f,
                0.358154f, -0.008789f, 0.336426f, -0.012695f,
                0.303223f, -0.012695f, 0.410645f, 0.333496f,
                0.409668f, 0.370605f, 0.401855f, 0.397461f,
                0.394043f, 0.424316f, 0.379395f, 0.442871f,
                0.363281f, 0.463379f, 0.338135f, 0.474121f,
                0.312988f, 0.484863f, 0.275879f, 0.484863f,
                0.239258f, 0.484863f, 0.213623f, 0.473877f,
                0.187988f, 0.462891f, 0.166992f, 0.441895f,
                0.146484f, 0.420410f, 0.135742f, 0.394287f,
                0.125000f, 0.368164f, 0.122070f, 0.333496f,
                0.410645f, 0.333496f
            };

        private static readonly byte[] TahomaGlyph1078Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1078Coordinates =
            {
                0.728516f, 0.000000f, 0.617676f, 0.000000f,
                0.446289f, 0.250977f, 0.410645f, 0.250977f,
                0.410645f, 0.000000f, 0.319824f, 0.000000f,
                0.319824f, 0.250977f, 0.284180f, 0.250977f,
                0.109863f, 0.000000f, 0.003906f, 0.000000f,
                0.209473f, 0.285645f, 0.185547f, 0.298340f,
                0.166992f, 0.322510f, 0.148438f, 0.346680f,
                0.133789f, 0.392578f, 0.120605f, 0.434082f,
                0.102539f, 0.450195f, 0.084473f, 0.466309f,
                0.043457f, 0.466309f, 0.022461f, 0.466309f,
                0.022461f, 0.545410f, 0.047363f, 0.545410f,
                0.107422f, 0.545410f, 0.146240f, 0.520996f,
                0.185059f, 0.496582f, 0.207031f, 0.435547f,
                0.211426f, 0.422852f, 0.218018f, 0.406494f,
                0.224609f, 0.390137f, 0.229492f, 0.378906f,
                0.245605f, 0.341797f, 0.267090f, 0.325195f,
                0.288574f, 0.308594f, 0.319824f, 0.306641f,
                0.319824f, 0.545410f, 0.410645f, 0.545410f,
                0.410645f, 0.306641f, 0.441895f, 0.309082f,
                0.464111f, 0.325684f, 0.486328f, 0.342285f,
                0.501953f, 0.378906f, 0.507324f, 0.391113f,
                0.513916f, 0.407227f, 0.520508f, 0.423340f,
                0.524414f, 0.435547f, 0.545898f, 0.495605f,
                0.583984f, 0.520508f, 0.622070f, 0.545410f,
                0.683105f, 0.545410f, 0.708008f, 0.545410f,
                0.708008f, 0.466309f, 0.687012f, 0.466309f,
                0.648438f, 0.466309f, 0.629150f, 0.450439f,
                0.609863f, 0.434570f, 0.596680f, 0.392578f,
                0.583008f, 0.350098f, 0.564453f, 0.325684f,
                0.545898f, 0.301270f, 0.523438f, 0.288574f,
                0.728516f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1079Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1079Coordinates =
            {
                0.427734f, 0.150879f, 0.427734f, 0.104980f,
                0.407715f, 0.073242f, 0.387695f, 0.041504f,
                0.356445f, 0.022949f, 0.326660f, 0.004883f,
                0.288574f, -0.003906f, 0.250488f, -0.012695f,
                0.212402f, -0.012695f, 0.158691f, -0.012695f,
                0.110840f, -0.002197f, 0.062988f, 0.008301f,
                0.015625f, 0.031250f, 0.015625f, 0.132813f,
                0.021484f, 0.132813f, 0.054688f, 0.102051f,
                0.104736f, 0.084229f, 0.154785f, 0.066406f,
                0.204590f, 0.066406f, 0.226074f, 0.066406f,
                0.250732f, 0.071045f, 0.275391f, 0.075684f,
                0.292480f, 0.085449f, 0.314941f, 0.099121f,
                0.324463f, 0.114746f, 0.333984f, 0.130371f,
                0.333984f, 0.157715f, 0.333984f, 0.187012f,
                0.322998f, 0.204834f, 0.312012f, 0.222656f,
                0.292969f, 0.231445f, 0.273926f, 0.240234f,
                0.250244f, 0.242432f, 0.226563f, 0.244629f,
                0.200195f, 0.244629f, 0.135742f, 0.244629f,
                0.135742f, 0.323730f, 0.185059f, 0.323730f,
                0.203613f, 0.323730f, 0.231445f, 0.324951f,
                0.259277f, 0.326172f, 0.275879f, 0.332520f,
                0.296875f, 0.340332f, 0.309570f, 0.354736f,
                0.322266f, 0.369141f, 0.322266f, 0.403320f,
                0.322266f, 0.427246f, 0.311523f, 0.441895f,
                0.300781f, 0.456543f, 0.284668f, 0.464844f,
                0.268066f, 0.473633f, 0.248535f, 0.476807f,
                0.229004f, 0.479980f, 0.210938f, 0.479980f,
                0.164551f, 0.479980f, 0.121826f, 0.467041f,
                0.079102f, 0.454102f, 0.048340f, 0.428711f,
                0.042480f, 0.428711f, 0.042480f, 0.527832f,
                0.077637f, 0.540039f, 0.120361f, 0.549316f,
                0.163086f, 0.558594f, 0.206055f, 0.558594f,
                0.240723f, 0.558594f, 0.276611f, 0.551514f,
                0.312500f, 0.544434f, 0.344727f, 0.527344f,
                0.375000f, 0.510742f, 0.395508f, 0.481689f,
                0.416016f, 0.452637f, 0.416016f, 0.410645f,
                0.416016f, 0.366211f, 0.390869f, 0.332764f,
                0.365723f, 0.299316f, 0.324219f, 0.288574f,
                0.324219f, 0.285156f, 0.369629f, 0.269531f,
                0.398682f, 0.237305f, 0.427734f, 0.205078f,
                0.427734f, 0.150879f
            };

        private static readonly byte[] TahomaGlyph1080Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1080Coordinates =
            {
                0.497070f, 0.000000f, 0.406250f, 0.000000f,
                0.406250f, 0.406738f, 0.149414f, 0.000000f,
                0.066406f, 0.000000f, 0.066406f, 0.545410f,
                0.157227f, 0.545410f, 0.157227f, 0.145020f,
                0.411133f, 0.545410f, 0.497070f, 0.545410f,
                0.497070f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1081Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1081Coordinates =
            {
                0.497070f, 0.000000f, 0.406250f, 0.000000f,
                0.406250f, 0.406738f, 0.149414f, 0.000000f,
                0.066406f, 0.000000f, 0.066406f, 0.545410f,
                0.157227f, 0.545410f, 0.157227f, 0.145020f,
                0.411133f, 0.545410f, 0.497070f, 0.545410f,
                0.497070f, 0.000000f, 0.456055f, 0.798828f,
                0.456055f, 0.756836f, 0.445801f, 0.722412f,
                0.435547f, 0.687988f, 0.416504f, 0.664551f,
                0.394531f, 0.638672f, 0.366699f, 0.625732f,
                0.338867f, 0.612793f, 0.295410f, 0.612793f,
                0.255371f, 0.612793f, 0.225342f, 0.626221f,
                0.195313f, 0.639648f, 0.174805f, 0.664551f,
                0.154785f, 0.688965f, 0.144531f, 0.723145f,
                0.134277f, 0.757324f, 0.134277f, 0.798828f,
                0.213379f, 0.798828f, 0.213379f, 0.732910f,
                0.233887f, 0.703857f, 0.254395f, 0.674805f,
                0.295410f, 0.674805f, 0.333984f, 0.674805f,
                0.355469f, 0.703369f, 0.376953f, 0.731934f,
                0.376953f, 0.798828f, 0.456055f, 0.798828f
            };

        private static readonly byte[] TahomaGlyph1082Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1082Coordinates =
            {
                0.505371f, 0.000000f, 0.391113f, 0.000000f,
                0.204102f, 0.251465f, 0.158203f, 0.251465f,
                0.158203f, 0.000000f, 0.066406f, 0.000000f,
                0.066406f, 0.545410f, 0.158203f, 0.545410f,
                0.158203f, 0.308105f, 0.193848f, 0.308594f,
                0.218994f, 0.322998f, 0.244141f, 0.337402f,
                0.261719f, 0.378906f, 0.267090f, 0.391113f,
                0.273682f, 0.407227f, 0.280273f, 0.423340f,
                0.284180f, 0.435547f, 0.305664f, 0.495605f,
                0.343750f, 0.520508f, 0.381836f, 0.545410f,
                0.442871f, 0.545410f, 0.467773f, 0.545410f,
                0.467773f, 0.466309f, 0.446777f, 0.466309f,
                0.408203f, 0.466309f, 0.388916f, 0.450439f,
                0.369629f, 0.434570f, 0.356445f, 0.392578f,
                0.342773f, 0.350098f, 0.324219f, 0.326416f,
                0.305664f, 0.302734f, 0.283203f, 0.290039f,
                0.505371f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1083Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1083Coordinates =
            {
                0.488770f, 0.000000f, 0.396973f, 0.000000f,
                0.396973f, 0.468262f, 0.209473f, 0.468262f,
                0.208008f, 0.427734f, 0.206543f, 0.390381f,
                0.205078f, 0.353027f, 0.203613f, 0.322754f,
                0.200684f, 0.246094f, 0.193604f, 0.194336f,
                0.186523f, 0.142578f, 0.175781f, 0.111328f,
                0.165039f, 0.079102f, 0.152100f, 0.061035f,
                0.139160f, 0.042969f, 0.123047f, 0.028320f,
                0.106445f, 0.013672f, 0.087402f, 0.006348f,
                0.068359f, -0.000977f, 0.044434f, -0.000977f,
                0.036621f, -0.000977f, 0.024414f, -0.000488f,
                0.012207f, 0.000000f, 0.007324f, 0.000000f,
                0.007324f, 0.080078f, 0.012207f, 0.080078f,
                0.015625f, 0.080078f, 0.019287f, 0.079590f,
                0.022949f, 0.079102f, 0.027832f, 0.079102f,
                0.039551f, 0.079102f, 0.050781f, 0.082520f,
                0.062012f, 0.085938f, 0.070801f, 0.095215f,
                0.095215f, 0.119141f, 0.106445f, 0.178955f,
                0.117676f, 0.238770f, 0.122559f, 0.346191f,
                0.124512f, 0.386230f, 0.126221f, 0.440918f,
                0.127930f, 0.495605f, 0.129395f, 0.545410f,
                0.488770f, 0.545410f, 0.488770f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1084Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1084Coordinates =
            {
                0.572266f, 0.000000f, 0.481445f, 0.000000f,
                0.481445f, 0.428711f, 0.350586f, 0.150391f,
                0.282227f, 0.150391f, 0.152344f, 0.428711f,
                0.152344f, 0.000000f, 0.066406f, 0.000000f,
                0.066406f, 0.545410f, 0.177246f, 0.545410f,
                0.320801f, 0.242676f, 0.459473f, 0.545410f,
                0.572266f, 0.545410f, 0.572266f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1085Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1085Coordinates =
            {
                0.497070f, 0.000000f, 0.405273f, 0.000000f,
                0.405273f, 0.245605f, 0.158203f, 0.245605f,
                0.158203f, 0.000000f, 0.066406f, 0.000000f,
                0.066406f, 0.545410f, 0.158203f, 0.545410f,
                0.158203f, 0.324707f, 0.405273f, 0.324707f,
                0.405273f, 0.545410f, 0.497070f, 0.545410f,
                0.497070f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1086Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1086Coordinates =
            {
                0.515137f, 0.272461f, 0.515137f, 0.134766f,
                0.448730f, 0.059814f, 0.382324f, -0.015137f,
                0.271973f, -0.015137f, 0.158203f, -0.015137f,
                0.093018f, 0.062256f, 0.027832f, 0.139648f,
                0.027832f, 0.272461f, 0.027832f, 0.409180f,
                0.094971f, 0.484863f, 0.162109f, 0.560547f,
                0.271973f, 0.560547f, 0.382324f, 0.560547f,
                0.448730f, 0.485107f, 0.515137f, 0.409668f,
                0.515137f, 0.272461f, 0.420410f, 0.272461f,
                0.420410f, 0.378418f, 0.381836f, 0.429932f,
                0.343262f, 0.481445f, 0.271973f, 0.481445f,
                0.200195f, 0.481445f, 0.161377f, 0.429932f,
                0.122559f, 0.378418f, 0.122559f, 0.272461f,
                0.122559f, 0.169922f, 0.161377f, 0.116943f,
                0.200195f, 0.063965f, 0.271973f, 0.063965f,
                0.342773f, 0.063965f, 0.381592f, 0.115967f,
                0.420410f, 0.167969f, 0.420410f, 0.272461f
            };

        private static readonly byte[] TahomaGlyph1087Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1087Coordinates =
            {
                0.497070f, 0.000000f, 0.405273f, 0.000000f,
                0.405273f, 0.466309f, 0.158203f, 0.466309f,
                0.158203f, 0.000000f, 0.066406f, 0.000000f,
                0.066406f, 0.545410f, 0.497070f, 0.545410f,
                0.497070f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1088Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1088Coordinates =
            {
                0.523926f, 0.287109f, 0.523926f, 0.150879f,
                0.458740f, 0.070068f, 0.393555f, -0.010742f,
                0.293945f, -0.010742f, 0.253418f, -0.010742f,
                0.222168f, -0.001465f, 0.190918f, 0.007813f,
                0.158203f, 0.027344f, 0.158203f, -0.201172f,
                0.066406f, -0.201172f, 0.066406f, 0.545410f,
                0.158203f, 0.545410f, 0.158203f, 0.488281f,
                0.192383f, 0.519043f, 0.234131f, 0.539795f,
                0.275879f, 0.560547f, 0.325195f, 0.560547f,
                0.418945f, 0.560547f, 0.471436f, 0.486328f,
                0.523926f, 0.412109f, 0.523926f, 0.287109f,
                0.429199f, 0.276855f, 0.429199f, 0.370117f,
                0.399414f, 0.421631f, 0.369629f, 0.473145f,
                0.302734f, 0.473145f, 0.263672f, 0.473145f,
                0.227295f, 0.455811f, 0.190918f, 0.438477f,
                0.158203f, 0.411133f, 0.158203f, 0.102051f,
                0.194336f, 0.084473f, 0.219971f, 0.078125f,
                0.245605f, 0.071777f, 0.278809f, 0.071777f,
                0.350098f, 0.071777f, 0.389648f, 0.124023f,
                0.429199f, 0.176270f, 0.429199f, 0.276855f
            };

        private static readonly byte[] TahomaGlyph1089Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1089Coordinates =
            {
                0.283203f, -0.012207f, 0.227051f, -0.012207f,
                0.180176f, 0.005127f, 0.133301f, 0.022461f,
                0.099609f, 0.057617f, 0.065918f, 0.092773f,
                0.047363f, 0.146240f, 0.028809f, 0.199707f,
                0.028809f, 0.271973f, 0.028809f, 0.343750f,
                0.048096f, 0.395996f, 0.067383f, 0.448242f,
                0.099609f, 0.483887f, 0.131836f, 0.519531f,
                0.179932f, 0.538818f, 0.228027f, 0.558105f,
                0.283203f, 0.558105f, 0.328125f, 0.558105f,
                0.369873f, 0.545410f, 0.411621f, 0.532715f,
                0.444336f, 0.516113f, 0.444336f, 0.413086f,
                0.438965f, 0.413086f, 0.429199f, 0.421387f,
                0.413818f, 0.432129f, 0.398438f, 0.442871f,
                0.376465f, 0.454102f, 0.357422f, 0.463867f,
                0.331543f, 0.471191f, 0.305664f, 0.478516f,
                0.281738f, 0.478516f, 0.210449f, 0.478516f,
                0.167236f, 0.424561f, 0.124023f, 0.370605f,
                0.124023f, 0.271973f, 0.124023f, 0.175293f,
                0.165771f, 0.121338f, 0.207520f, 0.067383f,
                0.281738f, 0.067383f, 0.326660f, 0.067383f,
                0.367188f, 0.085938f, 0.407715f, 0.104492f,
                0.438965f, 0.133789f, 0.444336f, 0.133789f,
                0.444336f, 0.030762f, 0.430664f, 0.024414f,
                0.410156f, 0.015381f, 0.389648f, 0.006348f,
                0.373047f, 0.001953f, 0.349609f, -0.004883f,
                0.331055f, -0.008545f, 0.312500f, -0.012207f,
                0.283203f, -0.012207f
            };

        private static readonly byte[] TahomaGlyph1090Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1090Coordinates =
            {
                0.464844f, 0.464844f, 0.279297f, 0.464844f,
                0.279297f, 0.000000f, 0.187500f, 0.000000f,
                0.187500f, 0.464844f, 0.001953f, 0.464844f,
                0.001953f, 0.545410f, 0.464844f, 0.545410f,
                0.464844f, 0.464844f
            };

        private static readonly byte[] TahomaGlyph1091Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1091Coordinates =
            {
                0.495117f, 0.545410f, 0.201660f, -0.201172f,
                0.103516f, -0.201172f, 0.201172f, 0.026367f,
                0.002930f, 0.545410f, 0.102051f, 0.545410f,
                0.250977f, 0.141602f, 0.399414f, 0.545410f,
                0.495117f, 0.545410f
            };

        private static readonly byte[] TahomaGlyph1092Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1092Coordinates =
            {
                0.729492f, 0.287109f, 0.729492f, 0.214355f,
                0.711670f, 0.158447f, 0.693848f, 0.102539f,
                0.664551f, 0.066406f, 0.634766f, 0.029785f,
                0.597168f, 0.010986f, 0.559570f, -0.007813f,
                0.518555f, -0.007813f, 0.487793f, -0.007813f,
                0.464600f, 0.003906f, 0.441406f, 0.015625f,
                0.425293f, 0.023926f, 0.425293f, -0.201172f,
                0.334473f, -0.201172f, 0.334473f, 0.023926f,
                0.305664f, 0.008789f, 0.288574f, 0.000488f,
                0.271484f, -0.007813f, 0.232422f, -0.007813f,
                0.140625f, -0.007813f, 0.085449f, 0.066650f,
                0.030273f, 0.141113f, 0.030273f, 0.270996f,
                0.030273f, 0.339355f, 0.047852f, 0.393066f,
                0.065430f, 0.446777f, 0.096191f, 0.484375f,
                0.124512f, 0.519043f, 0.161865f, 0.538330f,
                0.199219f, 0.557617f, 0.239746f, 0.557617f,
                0.268555f, 0.557617f, 0.291748f, 0.547607f,
                0.314941f, 0.537598f, 0.334473f, 0.524902f,
                0.334473f, 0.759766f, 0.425293f, 0.759766f,
                0.425293f, 0.524902f, 0.446777f, 0.538086f,
                0.474609f, 0.547852f, 0.502441f, 0.557617f,
                0.531738f, 0.557617f, 0.623535f, 0.557617f,
                0.676514f, 0.484131f, 0.729492f, 0.410645f,
                0.729492f, 0.287109f, 0.635254f, 0.276855f,
                0.635254f, 0.370117f, 0.603760f, 0.424316f,
                0.572266f, 0.478516f, 0.510742f, 0.478516f,
                0.485352f, 0.478516f, 0.466064f, 0.471924f,
                0.446777f, 0.465332f, 0.425293f, 0.457520f,
                0.425293f, 0.093750f, 0.446777f, 0.083496f,
                0.460205f, 0.077148f, 0.473633f, 0.070801f,
                0.499512f, 0.070801f, 0.562988f, 0.070801f,
                0.599121f, 0.123047f, 0.635254f, 0.175293f,
                0.635254f, 0.276855f, 0.334473f, 0.093750f,
                0.334473f, 0.457520f, 0.316895f, 0.465820f,
                0.299316f, 0.472168f, 0.281738f, 0.478516f,
                0.260254f, 0.478516f, 0.197754f, 0.478516f,
                0.161133f, 0.429199f, 0.124512f, 0.379883f,
                0.124512f, 0.275391f, 0.124512f, 0.180176f,
                0.157471f, 0.125488f, 0.190430f, 0.070801f,
                0.251953f, 0.070801f, 0.276367f, 0.070801f,
                0.295898f, 0.078125f, 0.315430f, 0.085449f,
                0.334473f, 0.093750f
            };

        private static readonly byte[] TahomaGlyph1093Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1093Coordinates =
            {
                0.490234f, 0.000000f, 0.377441f, 0.000000f,
                0.245117f, 0.206055f, 0.108887f, 0.000000f,
                0.004883f, 0.000000f, 0.194336f, 0.270508f,
                0.006836f, 0.545410f, 0.119629f, 0.545410f,
                0.250977f, 0.341309f, 0.385742f, 0.545410f,
                0.490234f, 0.545410f, 0.301758f, 0.276855f,
                0.490234f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1094Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1094Coordinates =
            {
                0.547852f, -0.130859f, 0.462402f, -0.130859f,
                0.462402f, 0.000000f, 0.066406f, 0.000000f,
                0.066406f, 0.545410f, 0.158203f, 0.545410f,
                0.158203f, 0.079102f, 0.401855f, 0.079102f,
                0.401855f, 0.545410f, 0.493652f, 0.545410f,
                0.493652f, 0.079102f, 0.547852f, 0.079102f,
                0.547852f, -0.130859f
            };

        private static readonly byte[] TahomaGlyph1095Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1095Coordinates =
            {
                0.476563f, 0.000000f, 0.384766f, 0.000000f,
                0.384766f, 0.212891f, 0.341797f, 0.198730f,
                0.301270f, 0.190918f, 0.260742f, 0.183105f,
                0.221191f, 0.183105f, 0.186523f, 0.183105f,
                0.153564f, 0.192139f, 0.120605f, 0.201172f,
                0.096680f, 0.221680f, 0.072754f, 0.242188f,
                0.059814f, 0.274170f, 0.046875f, 0.306152f,
                0.046875f, 0.349609f, 0.046875f, 0.545410f,
                0.138672f, 0.545410f, 0.138672f, 0.397461f,
                0.138672f, 0.361328f, 0.141602f, 0.340088f,
                0.144531f, 0.318848f, 0.157715f, 0.298828f,
                0.168945f, 0.281738f, 0.191650f, 0.272461f,
                0.214355f, 0.263184f, 0.251465f, 0.263184f,
                0.283691f, 0.263184f, 0.320557f, 0.269531f,
                0.357422f, 0.275879f, 0.384766f, 0.284668f,
                0.384766f, 0.545410f, 0.476563f, 0.545410f,
                0.476563f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1096Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1096Coordinates =
            {
                0.711914f, 0.000000f, 0.066406f, 0.000000f,
                0.066406f, 0.545410f, 0.158203f, 0.545410f,
                0.158203f, 0.077637f, 0.343262f, 0.077637f,
                0.343262f, 0.545410f, 0.435059f, 0.545410f,
                0.435059f, 0.077637f, 0.620117f, 0.077637f,
                0.620117f, 0.545410f, 0.711914f, 0.545410f,
                0.711914f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1097Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1097Coordinates =
            {
                0.766113f, -0.130859f, 0.680664f, -0.130859f,
                0.680664f, 0.000000f, 0.066406f, 0.000000f,
                0.066406f, 0.545410f, 0.158203f, 0.545410f,
                0.158203f, 0.077637f, 0.343262f, 0.077637f,
                0.343262f, 0.545410f, 0.435059f, 0.545410f,
                0.435059f, 0.077637f, 0.620117f, 0.077637f,
                0.620117f, 0.545410f, 0.711914f, 0.545410f,
                0.711914f, 0.077637f, 0.766113f, 0.077637f,
                0.766113f, -0.130859f
            };

        private static readonly byte[] TahomaGlyph1098Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1098Coordinates =
            {
                0.547852f, 0.168945f, 0.547852f, 0.129395f,
                0.531982f, 0.097168f, 0.516113f, 0.064941f,
                0.488770f, 0.044922f, 0.456543f, 0.020508f,
                0.419922f, 0.010254f, 0.383301f, 0.000000f,
                0.325684f, 0.000000f, 0.140625f, 0.000000f,
                0.140625f, 0.464844f, 0.001953f, 0.464844f,
                0.001953f, 0.545410f, 0.232422f, 0.545410f,
                0.232422f, 0.333008f, 0.328125f, 0.333008f,
                0.389648f, 0.333008f, 0.423584f, 0.326660f,
                0.457520f, 0.320313f, 0.491211f, 0.295410f,
                0.519531f, 0.274414f, 0.533691f, 0.241699f,
                0.547852f, 0.208984f, 0.547852f, 0.168945f,
                0.453125f, 0.167480f, 0.453125f, 0.192383f,
                0.444580f, 0.211182f, 0.436035f, 0.229980f,
                0.416504f, 0.241699f, 0.395996f, 0.253906f,
                0.369873f, 0.256348f, 0.343750f, 0.258789f,
                0.294922f, 0.258789f, 0.232422f, 0.258789f,
                0.232422f, 0.073242f, 0.292969f, 0.073242f,
                0.341797f, 0.073242f, 0.368652f, 0.077393f,
                0.395508f, 0.081543f, 0.415039f, 0.093262f,
                0.435059f, 0.105957f, 0.444092f, 0.123291f,
                0.453125f, 0.140625f, 0.453125f, 0.167480f
            };

        private static readonly byte[] TahomaGlyph1099Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1099Coordinates =
            {
                0.471191f, 0.168945f, 0.471191f, 0.129395f,
                0.455322f, 0.097168f, 0.439453f, 0.064941f,
                0.412109f, 0.044922f, 0.379883f, 0.020508f,
                0.343262f, 0.010254f, 0.306641f, 0.000000f,
                0.249023f, 0.000000f, 0.066406f, 0.000000f,
                0.066406f, 0.545410f, 0.158203f, 0.545410f,
                0.158203f, 0.333008f, 0.251465f, 0.333008f,
                0.312988f, 0.333008f, 0.346924f, 0.326660f,
                0.380859f, 0.320313f, 0.414551f, 0.295410f,
                0.442871f, 0.274414f, 0.457031f, 0.241699f,
                0.471191f, 0.208984f, 0.471191f, 0.168945f,
                0.376465f, 0.167480f, 0.376465f, 0.192383f,
                0.367920f, 0.211182f, 0.359375f, 0.229980f,
                0.339844f, 0.241699f, 0.319336f, 0.253906f,
                0.293213f, 0.256348f, 0.267090f, 0.258789f,
                0.218262f, 0.258789f, 0.158203f, 0.258789f,
                0.158203f, 0.073242f, 0.216309f, 0.073242f,
                0.265137f, 0.073242f, 0.291992f, 0.077393f,
                0.318848f, 0.081543f, 0.338379f, 0.093262f,
                0.358398f, 0.105957f, 0.367432f, 0.123291f,
                0.376465f, 0.140625f, 0.376465f, 0.167480f,
                0.626465f, 0.000000f, 0.534668f, 0.000000f,
                0.534668f, 0.545410f, 0.626465f, 0.545410f,
                0.626465f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph1100Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1100Coordinates =
            {
                0.479492f, 0.168945f, 0.479492f, 0.129395f,
                0.463623f, 0.097168f, 0.447754f, 0.064941f,
                0.420410f, 0.044922f, 0.388184f, 0.020508f,
                0.351563f, 0.010254f, 0.314941f, 0.000000f,
                0.257324f, 0.000000f, 0.066406f, 0.000000f,
                0.066406f, 0.545410f, 0.158203f, 0.545410f,
                0.158203f, 0.333008f, 0.259766f, 0.333008f,
                0.321289f, 0.333008f, 0.355225f, 0.326660f,
                0.389160f, 0.320313f, 0.422852f, 0.295410f,
                0.451172f, 0.274414f, 0.465332f, 0.241699f,
                0.479492f, 0.208984f, 0.479492f, 0.168945f,
                0.384766f, 0.167480f, 0.384766f, 0.192383f,
                0.376221f, 0.211182f, 0.367676f, 0.229980f,
                0.348145f, 0.241699f, 0.327637f, 0.253906f,
                0.301514f, 0.256348f, 0.275391f, 0.258789f,
                0.226563f, 0.258789f, 0.158203f, 0.258789f,
                0.158203f, 0.073242f, 0.224609f, 0.073242f,
                0.273438f, 0.073242f, 0.300293f, 0.077393f,
                0.327148f, 0.081543f, 0.346680f, 0.093262f,
                0.366699f, 0.105957f, 0.375732f, 0.123291f,
                0.384766f, 0.140625f, 0.384766f, 0.167480f
            };

        private static readonly byte[] TahomaGlyph1101Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1101Coordinates =
            {
                0.020508f, 0.125000f, 0.026367f, 0.125000f,
                0.037109f, 0.115723f, 0.052979f, 0.105713f,
                0.068848f, 0.095703f, 0.090332f, 0.086914f,
                0.113770f, 0.077148f, 0.135254f, 0.071777f,
                0.156738f, 0.066406f, 0.187988f, 0.066406f,
                0.258301f, 0.066406f, 0.300781f, 0.113770f,
                0.343262f, 0.161133f, 0.349609f, 0.250977f,
                0.101563f, 0.250977f, 0.101563f, 0.324707f,
                0.349121f, 0.324707f, 0.340332f, 0.402344f,
                0.298096f, 0.440918f, 0.255859f, 0.479492f,
                0.193359f, 0.479492f, 0.165527f, 0.479492f,
                0.141602f, 0.473389f, 0.117676f, 0.467285f,
                0.095215f, 0.457031f, 0.076660f, 0.448242f,
                0.062256f, 0.437988f, 0.047852f, 0.427734f,
                0.034668f, 0.416992f, 0.028809f, 0.416992f,
                0.028809f, 0.517578f, 0.054688f, 0.528809f,
                0.101807f, 0.543457f, 0.148926f, 0.558105f,
                0.191406f, 0.558105f, 0.246582f, 0.558105f,
                0.292480f, 0.541504f, 0.338379f, 0.524902f,
                0.371582f, 0.490723f, 0.405273f, 0.455566f,
                0.423096f, 0.405518f, 0.440918f, 0.355469f,
                0.440918f, 0.283691f, 0.440918f, 0.146973f,
                0.370850f, 0.067383f, 0.300781f, -0.012207f,
                0.181641f, -0.012207f, 0.137207f, -0.012207f,
                0.094971f, -0.000732f, 0.052734f, 0.010742f,
                0.020508f, 0.024414f, 0.020508f, 0.125000f
            };

        private static readonly byte[] TahomaGlyph1102Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1102Coordinates =
            {
                0.733887f, 0.272461f, 0.733887f, 0.135254f,
                0.667725f, 0.060059f, 0.601563f, -0.015137f,
                0.492676f, -0.015137f, 0.385742f, -0.015137f,
                0.322998f, 0.055420f, 0.260254f, 0.125977f,
                0.254395f, 0.248047f, 0.158203f, 0.248047f,
                0.158203f, 0.000000f, 0.066406f, 0.000000f,
                0.066406f, 0.545410f, 0.158203f, 0.545410f,
                0.158203f, 0.323242f, 0.256348f, 0.323242f,
                0.267578f, 0.434570f, 0.330566f, 0.497559f,
                0.393555f, 0.560547f, 0.492676f, 0.560547f,
                0.607422f, 0.560547f, 0.670654f, 0.482422f,
                0.733887f, 0.404297f, 0.733887f, 0.272461f,
                0.639160f, 0.272461f, 0.639160f, 0.376953f,
                0.600830f, 0.429199f, 0.562500f, 0.481445f,
                0.492676f, 0.481445f, 0.421875f, 0.481445f,
                0.383545f, 0.428711f, 0.345215f, 0.375977f,
                0.345215f, 0.272461f, 0.345215f, 0.169922f,
                0.383789f, 0.116943f, 0.422363f, 0.063965f,
                0.492676f, 0.063965f, 0.562500f, 0.063965f,
                0.600830f, 0.115479f, 0.639160f, 0.166992f,
                0.639160f, 0.272461f
            };

        private static readonly byte[] TahomaGlyph1103Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1103Coordinates =
            {
                0.461426f, 0.000000f, 0.369629f, 0.000000f,
                0.369629f, 0.216309f, 0.278809f, 0.216309f,
                0.117188f, 0.000000f, 0.010254f, 0.000000f,
                0.185547f, 0.224609f, 0.117676f, 0.244629f,
                0.086182f, 0.284180f, 0.054688f, 0.323730f,
                0.054688f, 0.390137f, 0.054688f, 0.430664f,
                0.072510f, 0.461182f, 0.090332f, 0.491699f,
                0.120605f, 0.512695f, 0.145020f, 0.529297f,
                0.182129f, 0.537354f, 0.219238f, 0.545410f,
                0.265137f, 0.545410f, 0.461426f, 0.545410f,
                0.461426f, 0.000000f, 0.369629f, 0.288574f,
                0.369629f, 0.472168f, 0.270020f, 0.472168f,
                0.238281f, 0.472168f, 0.219971f, 0.468750f,
                0.201660f, 0.465332f, 0.184570f, 0.455566f,
                0.166992f, 0.444824f, 0.157959f, 0.426514f,
                0.148926f, 0.408203f, 0.148926f, 0.387207f,
                0.148926f, 0.360352f, 0.155029f, 0.343506f,
                0.161133f, 0.326660f, 0.177246f, 0.312500f,
                0.194336f, 0.297852f, 0.218994f, 0.293213f,
                0.243652f, 0.288574f, 0.272949f, 0.288574f,
                0.369629f, 0.288574f
            };

        private static readonly byte[] TahomaGlyph1104Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1104Coordinates =
            {
                0.303223f, -0.012695f, 0.172852f, -0.012695f,
                0.100830f, 0.060791f, 0.028809f, 0.134277f,
                0.028809f, 0.269531f, 0.028809f, 0.402832f,
                0.098633f, 0.481689f, 0.168457f, 0.560547f,
                0.281250f, 0.560547f, 0.332031f, 0.560547f,
                0.371094f, 0.545898f, 0.410156f, 0.531250f,
                0.439453f, 0.500000f, 0.468750f, 0.468750f,
                0.484375f, 0.423584f, 0.500000f, 0.378418f,
                0.500000f, 0.312988f, 0.500000f, 0.263184f,
                0.122070f, 0.263184f, 0.122070f, 0.167969f,
                0.169922f, 0.117676f, 0.217773f, 0.067383f,
                0.302246f, 0.067383f, 0.332520f, 0.067383f,
                0.361572f, 0.074219f, 0.390625f, 0.081055f,
                0.414063f, 0.091797f, 0.438965f, 0.103027f,
                0.456055f, 0.113525f, 0.473145f, 0.124023f,
                0.484375f, 0.133301f, 0.489746f, 0.133301f,
                0.489746f, 0.033203f, 0.473633f, 0.026855f,
                0.449707f, 0.017334f, 0.425781f, 0.007813f,
                0.406738f, 0.002441f, 0.379883f, -0.004883f,
                0.358154f, -0.008789f, 0.336426f, -0.012695f,
                0.303223f, -0.012695f, 0.410645f, 0.333496f,
                0.409668f, 0.370605f, 0.401855f, 0.397461f,
                0.394043f, 0.424316f, 0.379395f, 0.442871f,
                0.363281f, 0.463379f, 0.338135f, 0.474121f,
                0.312988f, 0.484863f, 0.275879f, 0.484863f,
                0.239258f, 0.484863f, 0.213623f, 0.473877f,
                0.187988f, 0.462891f, 0.166992f, 0.441895f,
                0.146484f, 0.420410f, 0.135742f, 0.394287f,
                0.125000f, 0.368164f, 0.122070f, 0.333496f,
                0.410645f, 0.333496f, 0.334473f, 0.635742f,
                0.261719f, 0.635742f, 0.128418f, 0.818359f,
                0.247070f, 0.818359f, 0.334473f, 0.635742f
            };

        private static readonly byte[] TahomaGlyph1105Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1105Coordinates =
            {
                0.303223f, -0.012695f, 0.172852f, -0.012695f,
                0.100830f, 0.060791f, 0.028809f, 0.134277f,
                0.028809f, 0.269531f, 0.028809f, 0.402832f,
                0.098633f, 0.481689f, 0.168457f, 0.560547f,
                0.281250f, 0.560547f, 0.332031f, 0.560547f,
                0.371094f, 0.545898f, 0.410156f, 0.531250f,
                0.439453f, 0.500000f, 0.468750f, 0.468750f,
                0.484375f, 0.423584f, 0.500000f, 0.378418f,
                0.500000f, 0.312988f, 0.500000f, 0.263184f,
                0.122070f, 0.263184f, 0.122070f, 0.167969f,
                0.169922f, 0.117676f, 0.217773f, 0.067383f,
                0.302246f, 0.067383f, 0.332520f, 0.067383f,
                0.361572f, 0.074219f, 0.390625f, 0.081055f,
                0.414063f, 0.091797f, 0.438965f, 0.103027f,
                0.456055f, 0.113525f, 0.473145f, 0.124023f,
                0.484375f, 0.133301f, 0.489746f, 0.133301f,
                0.489746f, 0.033203f, 0.473633f, 0.026855f,
                0.449707f, 0.017334f, 0.425781f, 0.007813f,
                0.406738f, 0.002441f, 0.379883f, -0.004883f,
                0.358154f, -0.008789f, 0.336426f, -0.012695f,
                0.303223f, -0.012695f, 0.410645f, 0.333496f,
                0.409668f, 0.370605f, 0.401855f, 0.397461f,
                0.394043f, 0.424316f, 0.379395f, 0.442871f,
                0.363281f, 0.463379f, 0.338135f, 0.474121f,
                0.312988f, 0.484863f, 0.275879f, 0.484863f,
                0.239258f, 0.484863f, 0.213623f, 0.473877f,
                0.187988f, 0.462891f, 0.166992f, 0.441895f,
                0.146484f, 0.420410f, 0.135742f, 0.394287f,
                0.125000f, 0.368164f, 0.122070f, 0.333496f,
                0.410645f, 0.333496f, 0.429688f, 0.636719f,
                0.331543f, 0.636719f, 0.331543f, 0.731934f,
                0.429688f, 0.731934f, 0.429688f, 0.636719f,
                0.228027f, 0.636719f, 0.129883f, 0.636719f,
                0.129883f, 0.731934f, 0.228027f, 0.731934f,
                0.228027f, 0.636719f
            };

        private static readonly byte[] TahomaGlyph1106Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph1106Coordinates =
            {
                0.516602f, 0.242188f, 0.516602f, 0.213867f,
                0.516113f, 0.186523f, 0.515625f, 0.159180f,
                0.515137f, 0.130859f, 0.514160f, 0.044434f,
                0.494873f, -0.017822f, 0.475586f, -0.080078f,
                0.442383f, -0.119629f, 0.408203f, -0.160645f,
                0.366455f, -0.178711f, 0.324707f, -0.196777f,
                0.274414f, -0.196777f, 0.264160f, -0.196777f,
                0.257568f, -0.196777f, 0.250977f, -0.196777f,
                0.232910f, -0.195801f, 0.232910f, -0.118652f,
                0.238281f, -0.118652f, 0.243652f, -0.118652f,
                0.250732f, -0.118652f, 0.257813f, -0.118652f,
                0.261719f, -0.118652f, 0.351563f, -0.118652f,
                0.385254f, -0.056885f, 0.418945f, 0.004883f,
                0.423828f, 0.165527f, 0.424316f, 0.182129f,
                0.424561f, 0.200439f, 0.424805f, 0.218750f,
                0.424805f, 0.241211f, 0.424805f, 0.252930f,
                0.424561f, 0.271240f, 0.424316f, 0.289551f,
                0.423828f, 0.310547f, 0.423340f, 0.350098f,
                0.419678f, 0.380615f, 0.416016f, 0.411133f,
                0.404785f, 0.432129f, 0.393555f, 0.452637f,
                0.374023f, 0.462891f, 0.354492f, 0.473145f,
                0.320313f, 0.473145f, 0.286133f, 0.473145f,
                0.249756f, 0.454834f, 0.213379f, 0.436523f,
                0.178711f, 0.407227f, 0.178711f, 0.000000f,
                0.086914f, 0.000000f, 0.086914f, 0.620117f,
                0.005859f, 0.620117f, 0.005859f, 0.684570f,
                0.086914f, 0.684570f, 0.086914f, 0.759766f,
                0.178711f, 0.759766f, 0.178711f, 0.684570f,
                0.359863f, 0.684570f, 0.359863f, 0.620117f,
                0.178711f, 0.620117f, 0.178711f, 0.484863f,
                0.216797f, 0.519531f, 0.258057f, 0.540039f,
                0.299316f, 0.560547f, 0.344238f, 0.560547f,
                0.382324f, 0.560547f, 0.413086f, 0.548096f,
                0.443848f, 0.535645f, 0.465820f, 0.511719f,
                0.487793f, 0.487305f, 0.501465f, 0.446777f,
                0.515137f, 0.406250f, 0.515137f, 0.354004f,
                0.515137f, 0.331055f, 0.515869f, 0.304932f,
                0.516602f, 0.278809f, 0.516602f, 0.242188f
            };

        private static readonly byte[] TahomaGlyph8352Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8352Coordinates =
            {
                0.552246f, 0.000000f, 0.243164f, 0.000000f,
                0.243164f, 0.242188f, 0.133301f, 0.243164f,
                0.076172f, 0.314453f, 0.024414f, 0.378906f,
                0.024414f, 0.488281f, 0.024414f, 0.600098f,
                0.080078f, 0.667480f, 0.139160f, 0.740234f,
                0.246582f, 0.740234f, 0.323242f, 0.740234f,
                0.399414f, 0.698242f, 0.399414f, 0.619141f,
                0.394043f, 0.619141f, 0.323730f, 0.684082f,
                0.246094f, 0.684082f, 0.167969f, 0.684082f,
                0.127441f, 0.621582f, 0.092773f, 0.568848f,
                0.092773f, 0.488281f, 0.092773f, 0.409180f,
                0.127930f, 0.358887f, 0.167969f, 0.302246f,
                0.243164f, 0.300781f, 0.243164f, 0.494629f,
                0.552246f, 0.494629f, 0.552246f, 0.436035f,
                0.308594f, 0.436035f, 0.308594f, 0.300781f,
                0.535645f, 0.300781f, 0.535645f, 0.242188f,
                0.308594f, 0.242188f, 0.308594f, 0.058594f,
                0.552246f, 0.058594f, 0.552246f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph8353Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8353Coordinates =
            {
                0.594727f, 0.789063f, 0.563965f, 0.689453f,
                0.570313f, 0.686035f, 0.583984f, 0.678711f,
                0.583984f, 0.562012f, 0.576172f, 0.562012f,
                0.553711f, 0.583008f, 0.535156f, 0.596680f,
                0.371582f, 0.070801f, 0.488281f, 0.076172f,
                0.576660f, 0.164551f, 0.583984f, 0.164551f,
                0.583984f, 0.049316f, 0.513672f, 0.016113f,
                0.474121f, 0.003906f, 0.417969f, -0.013184f,
                0.357910f, -0.013184f, 0.350586f, -0.013184f,
                0.345703f, -0.013184f, 0.330566f, -0.062012f,
                0.248047f, -0.062012f, 0.266602f, -0.002441f,
                0.225586f, 0.007813f, 0.191895f, 0.026855f,
                0.164551f, -0.062012f, 0.082031f, -0.062012f,
                0.125977f, 0.079590f, 0.032227f, 0.181641f,
                0.032227f, 0.362793f, 0.032227f, 0.519531f,
                0.106445f, 0.620117f, 0.186035f, 0.728516f,
                0.329102f, 0.739258f, 0.344727f, 0.789063f,
                0.428711f, 0.789063f, 0.412598f, 0.736816f,
                0.452637f, 0.731934f, 0.489258f, 0.720215f,
                0.510742f, 0.789063f, 0.594727f, 0.789063f,
                0.463867f, 0.637695f, 0.427734f, 0.652344f,
                0.387695f, 0.656250f, 0.221191f, 0.120605f,
                0.251953f, 0.092773f, 0.291992f, 0.080078f,
                0.463867f, 0.637695f, 0.302246f, 0.650879f,
                0.216309f, 0.628906f, 0.171387f, 0.541016f,
                0.132813f, 0.465332f, 0.132813f, 0.362793f,
                0.132813f, 0.272949f, 0.163574f, 0.203125f,
                0.302246f, 0.650879f
            };

        private static readonly byte[] TahomaGlyph8354Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8354Coordinates =
            {
                0.583984f, 0.049316f, 0.513672f, 0.016113f,
                0.474121f, 0.003906f, 0.417969f, -0.013184f,
                0.357910f, -0.013184f, 0.195801f, -0.013184f,
                0.109375f, 0.099121f, 0.032227f, 0.199219f,
                0.032227f, 0.362793f, 0.032227f, 0.527832f,
                0.114258f, 0.629883f, 0.202148f, 0.740234f,
                0.359375f, 0.740234f, 0.472168f, 0.740234f,
                0.583984f, 0.678711f, 0.583984f, 0.562012f,
                0.576172f, 0.562012f, 0.472656f, 0.657715f,
                0.358398f, 0.657715f, 0.244141f, 0.657715f,
                0.183594f, 0.562500f, 0.132813f, 0.482422f,
                0.132813f, 0.362793f, 0.132813f, 0.262695f,
                0.170898f, 0.187988f, 0.214355f, 0.103027f,
                0.294922f, 0.079102f, 0.294922f, 0.418457f,
                0.386719f, 0.418457f, 0.386719f, 0.337402f,
                0.478516f, 0.418457f, 0.546875f, 0.418457f,
                0.566406f, 0.418457f, 0.583984f, 0.415527f,
                0.583984f, 0.319824f, 0.579102f, 0.319824f,
                0.563965f, 0.324219f, 0.529785f, 0.324219f,
                0.452637f, 0.324219f, 0.386719f, 0.260254f,
                0.386719f, 0.071777f, 0.494629f, 0.082520f,
                0.576660f, 0.164551f, 0.583984f, 0.164551f,
                0.583984f, 0.049316f
            };

        private static readonly byte[] TahomaGlyph8355Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8355Coordinates =
            {
                0.509277f, 0.641113f, 0.200195f, 0.641113f,
                0.200195f, 0.436035f, 0.495117f, 0.436035f,
                0.495117f, 0.350098f, 0.200195f, 0.350098f,
                0.200195f, 0.218262f, 0.354980f, 0.218262f,
                0.354980f, 0.150391f, 0.200195f, 0.150391f,
                0.200195f, 0.000000f, 0.103516f, 0.000000f,
                0.103516f, 0.150391f, 0.016602f, 0.150391f,
                0.016602f, 0.218262f, 0.103516f, 0.218262f,
                0.103516f, 0.727051f, 0.509277f, 0.727051f,
                0.509277f, 0.641113f
            };

        private static readonly byte[] TahomaGlyph8356Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8356Coordinates =
            {
                0.503418f, 0.000000f, 0.043457f, 0.000000f,
                0.043457f, 0.101074f, 0.087402f, 0.114258f,
                0.111572f, 0.145752f, 0.135742f, 0.177246f,
                0.142090f, 0.237305f, 0.063477f, 0.237305f,
                0.063477f, 0.302734f, 0.143066f, 0.302734f,
                0.143066f, 0.371094f, 0.063477f, 0.371094f,
                0.063477f, 0.436523f, 0.142090f, 0.436523f,
                0.142090f, 0.522949f, 0.142090f, 0.621094f,
                0.198730f, 0.681152f, 0.255371f, 0.741211f,
                0.345703f, 0.741211f, 0.393066f, 0.741211f,
                0.426758f, 0.733643f, 0.460449f, 0.726074f,
                0.488770f, 0.717773f, 0.488770f, 0.617188f,
                0.483887f, 0.617188f, 0.465332f, 0.629395f,
                0.431641f, 0.644531f, 0.397949f, 0.659668f,
                0.354980f, 0.659668f, 0.294922f, 0.659668f,
                0.265381f, 0.622070f, 0.235840f, 0.584473f,
                0.235840f, 0.513672f, 0.235840f, 0.436523f,
                0.413574f, 0.436523f, 0.413574f, 0.371094f,
                0.234863f, 0.371094f, 0.234863f, 0.302734f,
                0.413574f, 0.302734f, 0.413574f, 0.237305f,
                0.233398f, 0.237305f, 0.226074f, 0.183105f,
                0.197266f, 0.147949f, 0.168457f, 0.112793f,
                0.127441f, 0.088867f, 0.127441f, 0.083496f,
                0.503418f, 0.083496f, 0.503418f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph8357Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8357Coordinates =
            {
                0.777344f, 0.000000f, 0.685547f, 0.000000f,
                0.685547f, 0.315430f, 0.685547f, 0.395996f,
                0.675781f, 0.422852f, 0.657227f, 0.473145f,
                0.593750f, 0.473145f, 0.562012f, 0.473145f,
                0.525391f, 0.451660f, 0.467773f, 0.319824f,
                0.467773f, 0.000000f, 0.375977f, 0.000000f,
                0.375977f, 0.109863f, 0.285156f, -0.097656f,
                0.202637f, -0.097656f, 0.375977f, 0.300293f,
                0.375977f, 0.315430f, 0.375977f, 0.395996f,
                0.366211f, 0.422852f, 0.347656f, 0.473145f,
                0.284180f, 0.473145f, 0.228516f, 0.473145f,
                0.158203f, 0.407227f, 0.158203f, 0.000000f,
                0.066406f, 0.000000f, 0.066406f, 0.545410f,
                0.158203f, 0.545410f, 0.158203f, 0.484863f,
                0.233887f, 0.560547f, 0.307617f, 0.560547f,
                0.412109f, 0.560547f, 0.449219f, 0.468750f,
                0.531738f, 0.658203f, 0.615723f, 0.658203f,
                0.570313f, 0.553711f, 0.593262f, 0.560547f,
                0.617188f, 0.560547f, 0.777344f, 0.560547f,
                0.777344f, 0.358887f, 0.777344f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph8358Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8358Coordinates =
            {
                0.667480f, 0.258789f, 0.593750f, 0.258789f,
                0.593750f, 0.000000f, 0.485352f, 0.000000f,
                0.352539f, 0.258789f, 0.164063f, 0.258789f,
                0.164063f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.258789f, 0.000000f, 0.258789f,
                0.000000f, 0.328613f, 0.073730f, 0.328613f,
                0.073730f, 0.398438f, 0.000000f, 0.398438f,
                0.000000f, 0.468262f, 0.073730f, 0.468262f,
                0.073730f, 0.727051f, 0.210938f, 0.727051f,
                0.342285f, 0.468262f, 0.503418f, 0.468262f,
                0.503418f, 0.727051f, 0.593750f, 0.727051f,
                0.593750f, 0.468262f, 0.667480f, 0.468262f,
                0.667480f, 0.398438f, 0.593750f, 0.398438f,
                0.593750f, 0.328613f, 0.667480f, 0.328613f,
                0.667480f, 0.258789f, 0.503418f, 0.328613f,
                0.503418f, 0.398438f, 0.377930f, 0.398438f,
                0.413574f, 0.328613f, 0.503418f, 0.328613f,
                0.245605f, 0.468262f, 0.164063f, 0.626953f,
                0.164063f, 0.468262f, 0.245605f, 0.468262f,
                0.503418f, 0.151367f, 0.503418f, 0.258789f,
                0.448730f, 0.258789f, 0.503418f, 0.151367f,
                0.316895f, 0.328613f, 0.281250f, 0.398438f,
                0.164063f, 0.398438f, 0.164063f, 0.328613f,
                0.316895f, 0.328613f
            };

        private static readonly byte[] TahomaGlyph8359Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8359Coordinates =
            {
                0.901855f, 0.133789f, 0.901855f, 0.105957f,
                0.891357f, 0.079102f, 0.880859f, 0.052246f,
                0.860352f, 0.032715f, 0.837891f, 0.011719f,
                0.808594f, 0.000244f, 0.779297f, -0.011230f,
                0.733398f, -0.011230f, 0.683594f, -0.011230f,
                0.647217f, 0.000732f, 0.610840f, 0.012695f,
                0.586914f, 0.026367f, 0.586914f, 0.117676f,
                0.593750f, 0.117676f, 0.624023f, 0.091309f,
                0.659668f, 0.075439f, 0.695313f, 0.059570f,
                0.729492f, 0.059570f, 0.769043f, 0.059570f,
                0.791260f, 0.074219f, 0.813477f, 0.088867f,
                0.813477f, 0.125977f, 0.813477f, 0.150391f,
                0.800049f, 0.164551f, 0.786621f, 0.178711f,
                0.750000f, 0.188477f, 0.736328f, 0.192383f,
                0.719971f, 0.197510f, 0.703613f, 0.202637f,
                0.684570f, 0.208984f, 0.635254f, 0.225098f,
                0.613770f, 0.257080f, 0.592285f, 0.289063f,
                0.592285f, 0.334473f, 0.592285f, 0.346680f,
                0.594482f, 0.356201f, 0.596680f, 0.365723f,
                0.599121f, 0.374512f, 0.503418f, 0.374512f,
                0.503418f, 0.000000f, 0.416992f, 0.000000f,
                0.416992f, 0.411621f, 0.386719f, 0.371582f,
                0.340088f, 0.348389f, 0.293457f, 0.325195f,
                0.220215f, 0.325195f, 0.173340f, 0.325195f,
                0.173340f, 0.000000f, 0.081543f, 0.000000f,
                0.081543f, 0.727051f, 0.223633f, 0.727051f,
                0.277832f, 0.727051f, 0.317383f, 0.716797f,
                0.356934f, 0.706543f, 0.383789f, 0.686523f,
                0.414063f, 0.665039f, 0.433105f, 0.631592f,
                0.452148f, 0.598145f, 0.455078f, 0.550293f,
                0.503418f, 0.550293f, 0.503418f, 0.449219f,
                0.651367f, 0.449219f, 0.668457f, 0.460938f,
                0.695068f, 0.468506f, 0.721680f, 0.476074f,
                0.749512f, 0.476074f, 0.783691f, 0.476074f,
                0.820068f, 0.467285f, 0.856445f, 0.458496f,
                0.879395f, 0.445313f, 0.879395f, 0.357422f,
                0.872070f, 0.357422f, 0.843750f, 0.381836f,
                0.815186f, 0.393799f, 0.786621f, 0.405762f,
                0.756348f, 0.405762f, 0.722168f, 0.405762f,
                0.700928f, 0.388184f, 0.679688f, 0.370605f,
                0.679688f, 0.342285f, 0.679688f, 0.314941f,
                0.694092f, 0.301758f, 0.708496f, 0.288574f,
                0.737305f, 0.279785f, 0.750000f, 0.275879f,
                0.765869f, 0.270752f, 0.781738f, 0.265625f,
                0.802734f, 0.259277f, 0.849609f, 0.245117f,
                0.875732f, 0.214355f, 0.901855f, 0.183594f,
                0.901855f, 0.133789f, 0.360840f, 0.531250f,
                0.360840f, 0.561523f, 0.350586f, 0.584473f,
                0.340332f, 0.607422f, 0.319824f, 0.621582f,
                0.301270f, 0.634277f, 0.275146f, 0.639160f,
                0.249023f, 0.644043f, 0.215820f, 0.644043f,
                0.173340f, 0.644043f, 0.173340f, 0.406738f,
                0.204102f, 0.406738f, 0.247559f, 0.406738f,
                0.278320f, 0.414307f, 0.309082f, 0.421875f,
                0.328125f, 0.441895f, 0.345703f, 0.460449f,
                0.353271f, 0.481445f, 0.360840f, 0.502441f,
                0.360840f, 0.531250f
            };

        private static readonly byte[] TahomaGlyph8360Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8360Coordinates =
            {
                0.636719f, 0.000000f, 0.511230f, 0.000000f,
                0.280762f, 0.289063f, 0.170410f, 0.289063f,
                0.170410f, 0.000000f, 0.073730f, 0.000000f,
                0.073730f, 0.727051f, 0.261230f, 0.727051f,
                0.323730f, 0.727051f, 0.365967f, 0.720215f,
                0.408203f, 0.713379f, 0.446289f, 0.688477f,
                0.484375f, 0.664063f, 0.506592f, 0.625488f,
                0.528809f, 0.586914f, 0.528809f, 0.529785f,
                0.528809f, 0.449707f, 0.488281f, 0.395996f,
                0.447754f, 0.342285f, 0.377930f, 0.316406f,
                0.636719f, 0.000000f, 0.427734f, 0.522461f,
                0.427734f, 0.554199f, 0.416504f, 0.578857f,
                0.405273f, 0.603516f, 0.381836f, 0.619141f,
                0.361328f, 0.632813f, 0.333984f, 0.638428f,
                0.306641f, 0.644043f, 0.266113f, 0.644043f,
                0.170410f, 0.644043f, 0.170410f, 0.369629f,
                0.255371f, 0.369629f, 0.296875f, 0.369629f,
                0.330078f, 0.376953f, 0.363281f, 0.384277f,
                0.386719f, 0.407227f, 0.407715f, 0.427734f,
                0.417725f, 0.456055f, 0.427734f, 0.484375f,
                0.427734f, 0.522461f, 0.906250f, -0.013184f,
                0.851563f, -0.013184f, 0.803955f, 0.001465f,
                0.756348f, 0.016113f, 0.725098f, 0.032715f,
                0.725098f, 0.135742f, 0.729980f, 0.135742f,
                0.741699f, 0.126465f, 0.757568f, 0.115234f,
                0.773438f, 0.104004f, 0.799805f, 0.091797f,
                0.823242f, 0.081055f, 0.851318f, 0.072754f,
                0.879395f, 0.064453f, 0.909668f, 0.064453f,
                0.931641f, 0.064453f, 0.956543f, 0.069580f,
                0.981445f, 0.074707f, 0.993652f, 0.082520f,
                1.010742f, 0.093750f, 1.018311f, 0.106445f,
                1.025879f, 0.119141f, 1.025879f, 0.144531f,
                1.025879f, 0.177246f, 1.008057f, 0.193848f,
                0.990234f, 0.210449f, 0.944824f, 0.221680f,
                0.927246f, 0.226074f, 0.898926f, 0.231934f,
                0.870605f, 0.237793f, 0.846680f, 0.244629f,
                0.784180f, 0.262695f, 0.755859f, 0.300537f,
                0.727539f, 0.338379f, 0.727539f, 0.392090f,
                0.727539f, 0.465820f, 0.783203f, 0.512207f,
                0.838867f, 0.558594f, 0.931152f, 0.558594f,
                0.976563f, 0.558594f, 1.022461f, 0.547363f,
                1.068359f, 0.536133f, 1.099609f, 0.519043f,
                1.099609f, 0.420898f, 1.094727f, 0.420898f,
                1.059570f, 0.448730f, 1.016357f, 0.464844f,
                0.973145f, 0.480957f, 0.929199f, 0.480957f,
                0.883789f, 0.480957f, 0.852539f, 0.461914f,
                0.821289f, 0.442871f, 0.821289f, 0.404297f,
                0.821289f, 0.370117f, 0.839844f, 0.353271f,
                0.858398f, 0.336426f, 0.899414f, 0.325684f,
                0.919922f, 0.320313f, 0.945068f, 0.315186f,
                0.970215f, 0.310059f, 0.998047f, 0.303223f,
                1.058594f, 0.288086f, 1.089111f, 0.252930f,
                1.119629f, 0.217773f, 1.119629f, 0.157227f,
                1.119629f, 0.122070f, 1.105713f, 0.090576f,
                1.091797f, 0.059082f, 1.064941f, 0.036621f,
                1.035645f, 0.012207f, 0.998779f, -0.000488f,
                0.961914f, -0.013184f, 0.906250f, -0.013184f
            };

        private static readonly byte[] TahomaGlyph8361Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8361Coordinates =
            {
                0.901855f, 0.258789f, 0.771484f, 0.258789f,
                0.706543f, 0.000000f, 0.597656f, 0.000000f,
                0.534180f, 0.258789f, 0.367188f, 0.258789f,
                0.305176f, 0.000000f, 0.198730f, 0.000000f,
                0.132324f, 0.258789f, 0.000000f, 0.258789f,
                0.000000f, 0.328613f, 0.114746f, 0.328613f,
                0.096680f, 0.398438f, 0.000000f, 0.398438f,
                0.000000f, 0.468262f, 0.079102f, 0.468262f,
                0.012695f, 0.727051f, 0.111816f, 0.727051f,
                0.174316f, 0.468262f, 0.341309f, 0.468262f,
                0.403809f, 0.727051f, 0.501953f, 0.727051f,
                0.564453f, 0.468262f, 0.732910f, 0.468262f,
                0.794434f, 0.727051f, 0.889160f, 0.727051f,
                0.824219f, 0.468262f, 0.901855f, 0.468262f,
                0.901855f, 0.398438f, 0.806641f, 0.398438f,
                0.789063f, 0.328613f, 0.901855f, 0.328613f,
                0.901855f, 0.258789f, 0.716309f, 0.398438f,
                0.581055f, 0.398438f, 0.597656f, 0.328613f,
                0.699219f, 0.328613f, 0.716309f, 0.398438f,
                0.482910f, 0.468262f, 0.449707f, 0.603516f,
                0.417480f, 0.468262f, 0.482910f, 0.468262f,
                0.682617f, 0.258789f, 0.614746f, 0.258789f,
                0.648926f, 0.116699f, 0.682617f, 0.258789f,
                0.517090f, 0.328613f, 0.500000f, 0.398438f,
                0.400391f, 0.398438f, 0.383789f, 0.328613f,
                0.517090f, 0.328613f, 0.324707f, 0.398438f,
                0.191406f, 0.398438f, 0.208496f, 0.328613f,
                0.308105f, 0.328613f, 0.324707f, 0.398438f,
                0.291016f, 0.258789f, 0.225098f, 0.258789f,
                0.258301f, 0.122559f, 0.291016f, 0.258789f
            };

        private static readonly byte[] TahomaGlyph8362Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8362Coordinates =
            {
                0.763184f, 0.218262f, 0.763184f, 0.156738f,
                0.749023f, 0.115234f, 0.734863f, 0.073730f,
                0.707520f, 0.048340f, 0.679688f, 0.022461f,
                0.638916f, 0.011230f, 0.598145f, 0.000000f,
                0.543945f, 0.000000f, 0.275391f, 0.000000f,
                0.275391f, 0.374023f, 0.359863f, 0.374023f,
                0.359863f, 0.095703f, 0.541992f, 0.095703f,
                0.582031f, 0.095703f, 0.608643f, 0.104004f,
                0.635254f, 0.112305f, 0.650391f, 0.128418f,
                0.666504f, 0.145508f, 0.672607f, 0.167236f,
                0.678711f, 0.188965f, 0.678711f, 0.221191f,
                0.678711f, 0.618164f, 0.763184f, 0.618164f,
                0.763184f, 0.218262f, 0.561523f, 0.244141f,
                0.477051f, 0.244141f, 0.477051f, 0.396973f,
                0.477051f, 0.427734f, 0.470947f, 0.450439f,
                0.464844f, 0.473145f, 0.448730f, 0.489746f,
                0.433594f, 0.505859f, 0.406250f, 0.514160f,
                0.378906f, 0.522461f, 0.340332f, 0.522461f,
                0.158203f, 0.522461f, 0.158203f, 0.000000f,
                0.073730f, 0.000000f, 0.073730f, 0.618164f,
                0.342285f, 0.618164f, 0.396484f, 0.618164f,
                0.437500f, 0.606689f, 0.478516f, 0.595215f,
                0.505859f, 0.569824f, 0.534180f, 0.543457f,
                0.547852f, 0.501221f, 0.561523f, 0.458984f,
                0.561523f, 0.399902f, 0.561523f, 0.244141f
            };

        private static readonly byte[] TahomaGlyph8363Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8363Coordinates =
            {
                0.486328f, 0.000000f, 0.394531f, 0.000000f,
                0.394531f, 0.055664f, 0.373047f, 0.037598f,
                0.357422f, 0.025879f, 0.341797f, 0.014160f,
                0.320801f, 0.004395f, 0.301270f, -0.004883f,
                0.280273f, -0.010010f, 0.259277f, -0.015137f,
                0.231445f, -0.015137f, 0.187012f, -0.015137f,
                0.149170f, 0.003418f, 0.111328f, 0.021973f,
                0.084961f, 0.057617f, 0.058105f, 0.093750f,
                0.043457f, 0.146729f, 0.028809f, 0.199707f,
                0.028809f, 0.268555f, 0.028809f, 0.340332f,
                0.047363f, 0.392822f, 0.065918f, 0.445313f,
                0.098633f, 0.484375f, 0.128418f, 0.520020f,
                0.170654f, 0.540283f, 0.212891f, 0.560547f,
                0.259277f, 0.560547f, 0.300293f, 0.560547f,
                0.330566f, 0.551514f, 0.360840f, 0.542480f,
                0.394531f, 0.523438f, 0.394531f, 0.619141f,
                0.247559f, 0.619141f, 0.247559f, 0.684570f,
                0.394531f, 0.684570f, 0.394531f, 0.759766f,
                0.486328f, 0.759766f, 0.486328f, 0.684570f,
                0.567383f, 0.684570f, 0.567383f, 0.619141f,
                0.486328f, 0.619141f, 0.486328f, 0.000000f,
                0.394531f, 0.132813f, 0.394531f, 0.447266f,
                0.360352f, 0.463867f, 0.333252f, 0.470215f,
                0.306152f, 0.476563f, 0.274414f, 0.476563f,
                0.203613f, 0.476563f, 0.163574f, 0.423584f,
                0.123535f, 0.370605f, 0.123535f, 0.270508f,
                0.123535f, 0.174316f, 0.154297f, 0.123291f,
                0.185059f, 0.072266f, 0.252930f, 0.072266f,
                0.289063f, 0.072266f, 0.325684f, 0.088623f,
                0.362305f, 0.104980f, 0.394531f, 0.132813f,
                0.466797f, -0.157715f, 0.098633f, -0.157715f,
                0.098633f, -0.092285f, 0.466797f, -0.092285f,
                0.466797f, -0.157715f
            };

        private static readonly byte[] TahomaGlyph8364Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8364Coordinates =
            {
                0.461426f, 0.323242f, 0.448242f, 0.255859f,
                0.145508f, 0.255859f, 0.166992f, 0.172852f,
                0.216797f, 0.125000f, 0.273438f, 0.070313f,
                0.358398f, 0.070313f, 0.449707f, 0.070313f,
                0.516602f, 0.115234f, 0.523438f, 0.115234f,
                0.523438f, 0.020996f, 0.440430f, -0.013184f,
                0.357910f, -0.013184f, 0.224121f, -0.013184f,
                0.141113f, 0.063965f, 0.065918f, 0.133789f,
                0.041992f, 0.255859f, -0.013672f, 0.255859f,
                0.000000f, 0.323242f, 0.033691f, 0.323242f,
                0.032227f, 0.342773f, 0.032227f, 0.362793f,
                0.032227f, 0.376953f, 0.032715f, 0.390625f,
                -0.013672f, 0.390625f, 0.000000f, 0.458008f,
                0.040527f, 0.458008f, 0.062988f, 0.585938f,
                0.141602f, 0.660156f, 0.226563f, 0.740234f,
                0.359375f, 0.740234f, 0.446289f, 0.740234f,
                0.523438f, 0.705566f, 0.523438f, 0.610352f,
                0.515625f, 0.610352f, 0.446777f, 0.657715f,
                0.358398f, 0.657715f, 0.268555f, 0.657715f,
                0.210938f, 0.597656f, 0.161621f, 0.545898f,
                0.142578f, 0.458008f, 0.488770f, 0.458008f,
                0.475586f, 0.390625f, 0.133789f, 0.390625f,
                0.132813f, 0.376953f, 0.132813f, 0.362793f,
                0.132813f, 0.342773f, 0.134277f, 0.323242f,
                0.461426f, 0.323242f
            };

        private static readonly byte[] TahomaGlyph8365Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8365Coordinates =
            {
                0.585938f, 0.000000f, 0.468262f, 0.000000f,
                0.170410f, 0.328613f, 0.170410f, 0.000000f,
                0.073730f, 0.000000f, 0.073730f, 0.328613f,
                0.000000f, 0.328613f, 0.000000f, 0.398438f,
                0.073730f, 0.398438f, 0.073730f, 0.727051f,
                0.170410f, 0.727051f, 0.170410f, 0.398438f,
                0.468262f, 0.727051f, 0.585938f, 0.727051f,
                0.278320f, 0.398438f, 0.585938f, 0.398438f,
                0.585938f, 0.328613f, 0.278809f, 0.328613f,
                0.585938f, 0.000000f
            };

        private static readonly byte[] TahomaGlyph8366Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8366Coordinates =
            {
                0.584473f, 0.641113f, 0.340332f, 0.641113f,
                0.340332f, 0.475586f, 0.462402f, 0.571289f,
                0.462402f, 0.492676f, 0.340332f, 0.396973f,
                0.340332f, 0.318848f, 0.462402f, 0.414551f,
                0.462402f, 0.335938f, 0.340332f, 0.240234f,
                0.340332f, 0.000000f, 0.243652f, 0.000000f,
                0.243652f, 0.164551f, 0.122070f, 0.069336f,
                0.122070f, 0.147949f, 0.243652f, 0.243164f,
                0.243652f, 0.321289f, 0.122070f, 0.226074f,
                0.122070f, 0.304688f, 0.243652f, 0.399902f,
                0.243652f, 0.641113f, -0.000488f, 0.641113f,
                -0.000488f, 0.727051f, 0.584473f, 0.727051f,
                0.584473f, 0.641113f
            };

        private static readonly byte[] TahomaGlyph8367Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8367Coordinates =
            {
                0.986816f, 0.140137f, 0.986816f, 0.070801f,
                0.940918f, 0.032227f, 0.899902f, -0.001953f,
                0.836426f, -0.001953f, 0.783691f, -0.001953f,
                0.741699f, 0.035645f, 0.705078f, -0.136230f,
                0.699219f, -0.164063f, 0.681152f, -0.198242f,
                0.584473f, -0.198242f, 0.595215f, -0.180176f,
                0.612793f, -0.132324f, 0.675293f, 0.134277f,
                0.688477f, 0.190430f, 0.728027f, 0.229004f,
                0.774414f, 0.274414f, 0.841309f, 0.274414f,
                0.905273f, 0.274414f, 0.946045f, 0.237061f,
                0.986816f, 0.199707f, 0.986816f, 0.140137f,
                0.713379f, 0.430176f, 0.713379f, 0.228516f,
                0.627441f, 0.112305f, 0.543945f, 0.000000f,
                0.406738f, 0.000000f, 0.351563f, 0.000000f,
                0.300781f, 0.034668f, 0.269043f, 0.061035f,
                0.237305f, 0.086914f, 0.192871f, 0.000000f,
                0.114258f, 0.000000f, 0.020020f, 0.000000f,
                0.020020f, 0.089844f, 0.020020f, 0.126465f,
                0.046875f, 0.153076f, 0.073730f, 0.179688f,
                0.112793f, 0.179688f, 0.151855f, 0.179688f,
                0.181641f, 0.161133f, 0.196777f, 0.244141f,
                0.210938f, 0.313477f, 0.245117f, 0.480469f,
                0.268066f, 0.551758f, 0.296387f, 0.640625f,
                0.341309f, 0.694336f, 0.202148f, 0.686523f,
                0.132813f, 0.647461f, 0.123535f, 0.676758f,
                0.152832f, 0.691406f, 0.187988f, 0.702148f,
                0.273438f, 0.727539f, 0.376953f, 0.728027f,
                0.411621f, 0.765625f, 0.517090f, 0.838867f,
                0.541504f, 0.825195f, 0.509277f, 0.792969f,
                0.457520f, 0.728027f, 0.713379f, 0.709961f,
                0.713379f, 0.430176f, 0.914063f, 0.133301f,
                0.914063f, 0.171387f, 0.894043f, 0.199707f,
                0.872559f, 0.230957f, 0.837402f, 0.230957f,
                0.801758f, 0.230957f, 0.777832f, 0.199707f,
                0.755371f, 0.170898f, 0.755371f, 0.133301f,
                0.755371f, 0.096680f, 0.779297f, 0.066895f,
                0.804199f, 0.035645f, 0.837402f, 0.035645f,
                0.870117f, 0.035645f, 0.892578f, 0.066895f,
                0.914063f, 0.096191f, 0.914063f, 0.133301f,
                0.616211f, 0.425781f, 0.616211f, 0.549316f,
                0.581543f, 0.611328f, 0.539063f, 0.687500f,
                0.434570f, 0.694336f, 0.405273f, 0.651855f,
                0.372070f, 0.553223f, 0.353027f, 0.496582f,
                0.317871f, 0.335938f, 0.287109f, 0.192383f,
                0.257324f, 0.121582f, 0.287109f, 0.097656f,
                0.316895f, 0.073730f, 0.356934f, 0.046387f,
                0.396973f, 0.046387f, 0.510254f, 0.046387f,
                0.569824f, 0.182617f, 0.616211f, 0.288086f,
                0.616211f, 0.425781f, 0.176270f, 0.120605f,
                0.144043f, 0.142090f, 0.112793f, 0.142090f,
                0.092285f, 0.142090f, 0.076660f, 0.128418f,
                0.059082f, 0.113770f, 0.059082f, 0.089844f,
                0.059082f, 0.041016f, 0.114258f, 0.041016f,
                0.149414f, 0.041016f, 0.164551f, 0.074707f,
                0.168457f, 0.083008f, 0.176270f, 0.120605f
            };

        private static readonly byte[] TahomaGlyph8368Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8368Coordinates =
            {
                0.493164f, -0.085938f, 0.492188f, -0.143066f,
                0.449219f, -0.176270f, 0.407715f, -0.206543f,
                0.341309f, -0.206543f, 0.293457f, -0.206543f,
                0.247070f, -0.197266f, 0.247070f, -0.110352f,
                0.251953f, -0.110352f, 0.297363f, -0.123535f,
                0.329102f, -0.123535f, 0.397461f, -0.123535f,
                0.397949f, -0.066895f, 0.397949f, -0.055664f,
                0.395020f, -0.044922f, 0.330078f, 0.185059f,
                0.273926f, 0.084473f, 0.214355f, -0.012207f,
                0.149414f, 0.096191f, 0.098145f, 0.000000f,
                0.002441f, 0.000000f, 0.144043f, 0.255371f,
                0.207031f, 0.137207f, 0.230469f, 0.177734f,
                0.296875f, 0.302246f, 0.215332f, 0.598633f,
                0.211914f, 0.611816f, 0.211914f, 0.634766f,
                0.212402f, 0.696289f, 0.254395f, 0.731445f,
                0.294434f, 0.764648f, 0.360352f, 0.764648f,
                0.493164f, 0.764648f, 0.493164f, 0.634277f,
                0.493164f, 0.577148f, 0.464111f, 0.483154f,
                0.435059f, 0.389160f, 0.392090f, 0.303223f,
                0.486816f, -0.045898f, 0.492676f, -0.067383f,
                0.493164f, -0.085938f, 0.405273f, 0.618652f,
                0.405273f, 0.681641f, 0.360352f, 0.681641f,
                0.305176f, 0.681641f, 0.304688f, 0.624023f,
                0.304688f, 0.606934f, 0.307129f, 0.597656f,
                0.354492f, 0.432617f, 0.405273f, 0.551758f,
                0.405273f, 0.618652f
            };

        private static readonly byte[] TahomaGlyph8369Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8369Coordinates =
            {
                0.550781f, 0.406250f, 0.512207f, 0.406250f,
                0.481445f, 0.338379f, 0.408203f, 0.303223f,
                0.341797f, 0.270996f, 0.252441f, 0.270996f,
                0.170410f, 0.270996f, 0.170410f, 0.000000f,
                0.073730f, 0.000000f, 0.073730f, 0.406250f,
                0.010742f, 0.406250f, 0.010742f, 0.464844f,
                0.073730f, 0.464844f, 0.073730f, 0.533203f,
                0.010742f, 0.533203f, 0.010742f, 0.591797f,
                0.073730f, 0.591797f, 0.073730f, 0.727051f,
                0.256348f, 0.727051f, 0.468750f, 0.727051f,
                0.519043f, 0.591797f, 0.550781f, 0.591797f,
                0.550781f, 0.533203f, 0.531738f, 0.533203f,
                0.532715f, 0.521973f, 0.532715f, 0.507813f,
                0.532715f, 0.486816f, 0.529297f, 0.464844f,
                0.550781f, 0.464844f, 0.550781f, 0.406250f,
                0.406738f, 0.591797f, 0.366211f, 0.644043f,
                0.250488f, 0.644043f, 0.170410f, 0.644043f,
                0.170410f, 0.591797f, 0.406738f, 0.591797f,
                0.432129f, 0.505371f, 0.432129f, 0.519531f,
                0.430176f, 0.533203f, 0.170410f, 0.533203f,
                0.170410f, 0.464844f, 0.428223f, 0.464844f,
                0.432129f, 0.484375f, 0.432129f, 0.505371f,
                0.400879f, 0.406250f, 0.170410f, 0.406250f,
                0.170410f, 0.353516f, 0.236328f, 0.353516f,
                0.355469f, 0.353516f, 0.400879f, 0.406250f
            };

        private static readonly byte[] TahomaGlyph8370Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8370Coordinates =
            {
                0.342285f, 0.823242f, 0.404785f, 0.823242f,
                0.388184f, 0.728516f, 0.416504f, 0.720215f,
                0.442627f, 0.707275f, 0.468750f, 0.694336f,
                0.495117f, 0.677734f, 0.495117f, 0.561035f,
                0.488770f, 0.561035f, 0.468262f, 0.587402f,
                0.438721f, 0.610107f, 0.409180f, 0.632813f,
                0.373535f, 0.645508f, 0.324219f, 0.365723f,
                0.498047f, 0.365723f, 0.498047f, 0.048340f,
                0.476074f, 0.035645f, 0.453857f, 0.024414f,
                0.431641f, 0.013184f, 0.407471f, 0.004639f,
                0.383301f, -0.003906f, 0.356934f, -0.009033f,
                0.330566f, -0.014160f, 0.300293f, -0.014160f,
                0.290039f, -0.014160f, 0.279541f, -0.013428f,
                0.269043f, -0.012695f, 0.258301f, -0.010742f,
                0.238770f, -0.122559f, 0.176270f, -0.122559f,
                0.198730f, 0.006836f, 0.173828f, 0.018066f,
                0.150635f, 0.035889f, 0.127441f, 0.053711f,
                0.107422f, 0.080566f, 0.070801f, 0.129395f,
                0.051514f, 0.200195f, 0.032227f, 0.270996f,
                0.032227f, 0.364258f, 0.032227f, 0.414063f,
                0.039307f, 0.461426f, 0.046387f, 0.508789f,
                0.061279f, 0.550537f, 0.076172f, 0.592285f,
                0.098389f, 0.627197f, 0.120605f, 0.662109f,
                0.151123f, 0.687256f, 0.181641f, 0.712402f,
                0.220459f, 0.726318f, 0.259277f, 0.740234f,
                0.306641f, 0.740234f, 0.312012f, 0.740234f,
                0.317139f, 0.739990f, 0.322266f, 0.739746f,
                0.327637f, 0.739258f, 0.342285f, 0.823242f,
                0.132813f, 0.367188f, 0.132813f, 0.332520f,
                0.136475f, 0.294434f, 0.140137f, 0.256348f,
                0.149414f, 0.219971f, 0.158691f, 0.183594f,
                0.174805f, 0.152100f, 0.190918f, 0.120605f,
                0.215332f, 0.099609f, 0.312988f, 0.656738f,
                0.308105f, 0.656738f, 0.264160f, 0.656738f,
                0.231201f, 0.633057f, 0.198242f, 0.609375f,
                0.176514f, 0.569336f, 0.154785f, 0.529297f,
                0.143799f, 0.476807f, 0.132813f, 0.424316f,
                0.132813f, 0.367188f, 0.300293f, 0.069336f,
                0.328125f, 0.069336f, 0.354004f, 0.074707f,
                0.379883f, 0.080078f, 0.402344f, 0.092773f,
                0.402344f, 0.280762f, 0.309570f, 0.280762f,
                0.272949f, 0.071777f, 0.286621f, 0.069336f,
                0.300293f, 0.069336f
            };

        private static readonly byte[] TahomaGlyph8371Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8371Coordinates =
            {
                0.545898f, 0.285645f, 0.545898f, 0.218262f,
                0.485352f, 0.218262f, 0.550781f, 0.000000f,
                0.448730f, 0.000000f, 0.386719f, 0.218262f,
                0.154297f, 0.218262f, 0.092773f, 0.000000f,
                -0.004883f, 0.000000f, 0.060547f, 0.218262f,
                0.000000f, 0.218262f, 0.000000f, 0.285645f,
                0.080566f, 0.285645f, 0.104004f, 0.362793f,
                0.000000f, 0.362793f, 0.000000f, 0.430176f,
                0.124023f, 0.430176f, 0.213379f, 0.727051f,
                0.332520f, 0.727051f, 0.421387f, 0.430176f,
                0.545898f, 0.430176f, 0.545898f, 0.362793f,
                0.441895f, 0.362793f, 0.464844f, 0.285645f,
                0.545898f, 0.285645f, 0.173340f, 0.285645f,
                0.367676f, 0.285645f, 0.345703f, 0.362793f,
                0.195313f, 0.362793f, 0.173340f, 0.285645f,
                0.214355f, 0.430176f, 0.326660f, 0.430176f,
                0.270508f, 0.628418f, 0.214355f, 0.430176f
            };

        private static readonly byte[] TahomaGlyph8372Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8372Coordinates =
            {
                0.000000f, 0.390625f, 0.000000f, 0.458008f,
                0.359375f, 0.458008f, 0.372559f, 0.466797f,
                0.378418f, 0.473633f, 0.402344f, 0.500977f,
                0.402344f, 0.542480f, 0.402344f, 0.593750f,
                0.362061f, 0.625244f, 0.321777f, 0.656738f,
                0.256836f, 0.656738f, 0.198730f, 0.656738f,
                0.146240f, 0.633057f, 0.093750f, 0.609375f,
                0.060547f, 0.577637f, 0.053223f, 0.577637f,
                0.053223f, 0.693359f, 0.098633f, 0.715820f,
                0.151611f, 0.728027f, 0.204590f, 0.740234f,
                0.264160f, 0.740234f, 0.368652f, 0.740234f,
                0.435791f, 0.680420f, 0.502930f, 0.620605f,
                0.502930f, 0.532227f, 0.502930f, 0.489258f,
                0.483887f, 0.458008f, 0.533203f, 0.458008f,
                0.533203f, 0.390625f, 0.403809f, 0.390625f,
                0.376465f, 0.375000f, 0.339844f, 0.359375f,
                0.292480f, 0.338379f, 0.258789f, 0.323242f,
                0.533203f, 0.323242f, 0.533203f, 0.255859f,
                0.144531f, 0.255859f, 0.125488f, 0.233398f,
                0.125488f, 0.187012f, 0.125488f, 0.132324f,
                0.165283f, 0.101318f, 0.205078f, 0.070313f,
                0.283203f, 0.070313f, 0.337402f, 0.070313f,
                0.396240f, 0.094971f, 0.455078f, 0.119629f,
                0.501465f, 0.164551f, 0.508301f, 0.164551f,
                0.508301f, 0.043457f, 0.460449f, 0.019531f,
                0.406250f, 0.003174f, 0.352051f, -0.013184f,
                0.274902f, -0.013184f, 0.209961f, -0.013184f,
                0.166748f, 0.003906f, 0.123535f, 0.020996f,
                0.089355f, 0.052734f, 0.058594f, 0.081543f,
                0.041748f, 0.118164f, 0.024902f, 0.154785f,
                0.024902f, 0.197266f, 0.024902f, 0.229492f,
                0.033691f, 0.255859f, 0.000000f, 0.255859f,
                0.000000f, 0.323242f, 0.081543f, 0.323242f,
                0.123047f, 0.354492f, 0.212891f, 0.390625f,
                0.000000f, 0.390625f
            };

        private static readonly byte[] TahomaGlyph8373Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8373Coordinates =
            {
                0.299805f, 0.823242f, 0.355469f, 0.823242f,
                0.355469f, 0.739258f, 0.372559f, 0.737793f,
                0.388672f, 0.734863f, 0.417480f, 0.729492f,
                0.442383f, 0.721191f, 0.463379f, 0.713867f,
                0.485596f, 0.702881f, 0.507813f, 0.691895f,
                0.529297f, 0.678711f, 0.529297f, 0.562012f,
                0.522461f, 0.562012f, 0.511230f, 0.573730f,
                0.493652f, 0.590332f, 0.476074f, 0.606934f,
                0.450684f, 0.623047f, 0.426270f, 0.638184f,
                0.397461f, 0.647949f, 0.378418f, 0.654297f,
                0.355469f, 0.656738f, 0.355469f, 0.071289f,
                0.378418f, 0.073730f, 0.399414f, 0.080566f,
                0.430664f, 0.090820f, 0.455078f, 0.106445f,
                0.478516f, 0.121582f, 0.495850f, 0.137451f,
                0.513184f, 0.153320f, 0.522949f, 0.164551f,
                0.529297f, 0.164551f, 0.529297f, 0.049316f,
                0.507813f, 0.038086f, 0.488525f, 0.027832f,
                0.469238f, 0.017578f, 0.442383f, 0.007813f,
                0.413574f, -0.002441f, 0.389160f, -0.007813f,
                0.374512f, -0.010742f, 0.355469f, -0.012207f,
                0.355469f, -0.122559f, 0.299805f, -0.122559f,
                0.299805f, -0.012207f, 0.250000f, -0.008301f,
                0.207520f, 0.010742f, 0.153809f, 0.034668f,
                0.114258f, 0.082031f, 0.075195f, 0.129395f,
                0.053711f, 0.200195f, 0.032227f, 0.270996f,
                0.032227f, 0.362793f, 0.032227f, 0.454102f,
                0.053223f, 0.521973f, 0.074219f, 0.589844f,
                0.114258f, 0.640137f, 0.153320f, 0.688965f,
                0.207031f, 0.714355f, 0.249512f, 0.734863f,
                0.299805f, 0.739258f, 0.299805f, 0.823242f,
                0.253906f, 0.638672f, 0.217285f, 0.619629f,
                0.189941f, 0.582520f, 0.163086f, 0.545410f,
                0.147949f, 0.489258f, 0.132813f, 0.433105f,
                0.132813f, 0.362793f, 0.132813f, 0.288086f,
                0.148682f, 0.234131f, 0.164551f, 0.180176f,
                0.191895f, 0.143066f, 0.218750f, 0.106934f,
                0.254395f, 0.088379f, 0.276367f, 0.077637f,
                0.299805f, 0.073242f, 0.299805f, 0.654785f,
                0.275879f, 0.649902f, 0.253906f, 0.638672f
            };

        private static readonly byte[] TahomaGlyph8376Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8376Coordinates =
            {
                0.502930f, 0.473145f, 0.321289f, 0.473145f,
                0.321289f, 0.000000f, 0.224609f, 0.000000f,
                0.224609f, 0.473145f, 0.042969f, 0.473145f,
                0.042969f, 0.556152f, 0.502930f, 0.556152f,
                0.502930f, 0.473145f, 0.042969f, 0.644043f,
                0.042969f, 0.727051f, 0.502930f, 0.727051f,
                0.502930f, 0.644043f, 0.042969f, 0.644043f
            };

        private static readonly byte[] TahomaGlyph8377Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8377Coordinates =
            {
                0.058594f, 0.465332f, 0.058594f, 0.548340f,
                0.296387f, 0.548340f, 0.291992f, 0.576172f,
                0.277832f, 0.594727f, 0.263672f, 0.613281f,
                0.243164f, 0.624268f, 0.222656f, 0.635254f,
                0.197021f, 0.639648f, 0.171387f, 0.644043f,
                0.143555f, 0.644043f, 0.058594f, 0.644043f,
                0.058594f, 0.727051f, 0.494141f, 0.727051f,
                0.494141f, 0.644043f, 0.350098f, 0.644043f,
                0.371582f, 0.628418f, 0.383057f, 0.602539f,
                0.394531f, 0.576660f, 0.397461f, 0.548340f,
                0.494141f, 0.548340f, 0.494141f, 0.465332f,
                0.391602f, 0.465332f, 0.378418f, 0.412109f,
                0.342285f, 0.375732f, 0.306152f, 0.339355f,
                0.250977f, 0.317871f, 0.485352f, 0.000000f,
                0.369629f, 0.000000f, 0.165527f, 0.289063f,
                0.058594f, 0.289063f, 0.058594f, 0.369629f,
                0.117188f, 0.369629f, 0.150391f, 0.369629f,
                0.178467f, 0.375000f, 0.206543f, 0.380371f,
                0.228760f, 0.391846f, 0.250977f, 0.403320f,
                0.266357f, 0.421387f, 0.281738f, 0.439453f,
                0.290039f, 0.465332f, 0.058594f, 0.465332f
            };

        private static readonly byte[] TahomaGlyph8319Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8319Coordinates =
            {
                0.434570f, 0.276367f, 0.350586f, 0.276367f,
                0.350586f, 0.531250f, 0.350586f, 0.565918f,
                0.348633f, 0.590820f, 0.346680f, 0.615723f,
                0.337402f, 0.633789f, 0.328613f, 0.651367f,
                0.311035f, 0.659668f, 0.293457f, 0.667969f,
                0.264160f, 0.667969f, 0.233398f, 0.667969f,
                0.203857f, 0.652100f, 0.174316f, 0.636230f,
                0.144531f, 0.612305f, 0.144531f, 0.276367f,
                0.061035f, 0.276367f, 0.061035f, 0.726563f,
                0.144531f, 0.726563f, 0.144531f, 0.677734f,
                0.180176f, 0.708496f, 0.213379f, 0.725098f,
                0.246582f, 0.741699f, 0.286133f, 0.741699f,
                0.356934f, 0.741699f, 0.395752f, 0.697510f,
                0.434570f, 0.653320f, 0.434570f, 0.567871f,
                0.434570f, 0.276367f
            };

        private static readonly byte[] TahomaGlyph8336Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8336Coordinates =
            {
                0.329590f, -0.181152f, 0.268555f, -0.181152f,
                0.268555f, -0.142578f, 0.253906f, -0.154297f,
                0.224121f, -0.173828f, 0.189941f, -0.191406f,
                0.149902f, -0.191406f, 0.075684f, -0.191406f,
                0.047852f, -0.122070f, 0.039063f, -0.100098f,
                0.039063f, -0.075195f, 0.039063f, 0.001465f,
                0.105469f, 0.031738f, 0.151855f, 0.052734f,
                0.268555f, 0.059082f, 0.268555f, 0.070801f,
                0.268555f, 0.093262f, 0.262451f, 0.105713f,
                0.256348f, 0.118164f, 0.243652f, 0.125977f,
                0.223145f, 0.138672f, 0.179688f, 0.138672f,
                0.131348f, 0.138672f, 0.072266f, 0.113770f,
                0.068848f, 0.113770f, 0.068848f, 0.176270f,
                0.126465f, 0.192871f, 0.180176f, 0.192871f,
                0.254395f, 0.192871f, 0.290039f, 0.166016f,
                0.329590f, 0.136230f, 0.329590f, 0.068848f,
                0.329590f, -0.181152f, 0.268555f, -0.091309f,
                0.268555f, 0.010254f, 0.242676f, 0.007813f,
                0.212891f, 0.004883f, 0.144531f, -0.001953f,
                0.118164f, -0.027832f, 0.102539f, -0.042969f,
                0.102539f, -0.071289f, 0.102539f, -0.134766f,
                0.171875f, -0.134766f, 0.219727f, -0.134766f,
                0.268555f, -0.091309f
            };

        private static readonly byte[] TahomaGlyph8337Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8337Coordinates =
            {
                0.354980f, -0.006836f, 0.101563f, -0.006836f,
                0.101563f, -0.067383f, 0.131348f, -0.101563f,
                0.163086f, -0.137695f, 0.222168f, -0.137695f,
                0.261719f, -0.137695f, 0.297363f, -0.121582f,
                0.326660f, -0.108398f, 0.344238f, -0.093750f,
                0.348145f, -0.093750f, 0.348145f, -0.160645f,
                0.329590f, -0.168457f, 0.292480f, -0.181641f,
                0.257324f, -0.191406f, 0.223145f, -0.191406f,
                0.134277f, -0.191406f, 0.086670f, -0.141602f,
                0.039063f, -0.091797f, 0.039063f, -0.002441f,
                0.039063f, 0.081055f, 0.081055f, 0.134277f,
                0.127441f, 0.192383f, 0.208496f, 0.192383f,
                0.276367f, 0.192383f, 0.314453f, 0.151855f,
                0.354980f, 0.108398f, 0.354980f, 0.026855f,
                0.354980f, -0.006836f, 0.294922f, 0.040527f,
                0.292969f, 0.114746f, 0.246582f, 0.134766f,
                0.230469f, 0.141602f, 0.204590f, 0.141602f,
                0.160156f, 0.141602f, 0.131836f, 0.112793f,
                0.105469f, 0.085938f, 0.101563f, 0.040527f,
                0.294922f, 0.040527f
            };

        private static readonly byte[] TahomaGlyph8338Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8338Coordinates =
            {
                0.365234f, 0.000977f, 0.365234f, -0.083008f,
                0.326660f, -0.134277f, 0.283691f, -0.191406f,
                0.202637f, -0.191406f, 0.121582f, -0.191406f,
                0.078125f, -0.134277f, 0.039063f, -0.083008f,
                0.039063f, 0.000977f, 0.039063f, 0.084961f,
                0.078125f, 0.136230f, 0.121582f, 0.193848f,
                0.202637f, 0.193848f, 0.283691f, 0.193848f,
                0.326660f, 0.136230f, 0.365234f, 0.084961f,
                0.365234f, 0.000977f, 0.301758f, 0.000977f,
                0.301758f, 0.141113f, 0.202637f, 0.141113f,
                0.102539f, 0.141113f, 0.102539f, 0.000977f,
                0.102539f, -0.138672f, 0.202637f, -0.138672f,
                0.301758f, -0.138672f, 0.301758f, 0.000977f
            };

        private static readonly byte[] TahomaGlyph8339Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8339Coordinates =
            {
                0.328613f, -0.181152f, 0.252930f, -0.181152f,
                0.164063f, -0.042969f, 0.072754f, -0.181152f,
                0.003418f, -0.181152f, 0.130371f, 0.000000f,
                0.004395f, 0.184082f, 0.080078f, 0.184082f,
                0.167969f, 0.047363f, 0.258301f, 0.184082f,
                0.328613f, 0.184082f, 0.202148f, 0.004395f,
                0.328613f, -0.181152f
            };

        private static readonly byte[] TahomaGlyph8340Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] TahomaGlyph8340Coordinates =
            {
                0.354980f, 0.003418f, 0.354980f, -0.080078f,
                0.312988f, -0.133301f, 0.266602f, -0.191406f,
                0.185547f, -0.191406f, 0.111816f, -0.191406f,
                0.074219f, -0.144531f, 0.039063f, -0.101563f,
                0.039063f, -0.025879f, 0.039063f, 0.007813f,
                0.292480f, 0.007813f, 0.292480f, 0.138672f,
                0.171875f, 0.138672f, 0.131836f, 0.138672f,
                0.096680f, 0.122559f, 0.067871f, 0.109375f,
                0.049805f, 0.094727f, 0.045898f, 0.094727f,
                0.045898f, 0.161621f, 0.061035f, 0.167969f,
                0.101563f, 0.182617f, 0.132813f, 0.192383f,
                0.170898f, 0.192383f, 0.260742f, 0.192383f,
                0.307861f, 0.143066f, 0.354980f, 0.093750f,
                0.354980f, 0.003418f, 0.292480f, -0.039551f,
                0.099121f, -0.039551f, 0.102051f, -0.140625f,
                0.189453f, -0.140625f, 0.234375f, -0.140625f,
                0.262207f, -0.112305f, 0.288574f, -0.084961f,
                0.292480f, -0.039551f
            };

        #endregion

        #region glyphs_description

        public Glyph[] Glyphs
        {
            get
            {
                return new[]
                           {
                               new Glyph
                                   {
                                       glyphIndex = 32,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.312500f, 0.000000f},
                                       commands = new byte[] {0},
                                       coordinates = new float[] {0}
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 33,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.332031f, 0.000000f},
                                       commands = TahomaGlyph33Commands,
                                       coordinates = TahomaGlyph33Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 34,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.401367f, 0.000000f},
                                       commands = TahomaGlyph34Commands,
                                       coordinates = TahomaGlyph34Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 35,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.727539f, 0.000000f},
                                       commands = TahomaGlyph35Commands,
                                       coordinates = TahomaGlyph35Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 36,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph36Commands,
                                       coordinates = TahomaGlyph36Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 37,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.976563f, 0.000000f},
                                       commands = TahomaGlyph37Commands,
                                       coordinates = TahomaGlyph37Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 38,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.673828f, 0.000000f},
                                       commands = TahomaGlyph38Commands,
                                       coordinates = TahomaGlyph38Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 39,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.210938f, 0.000000f},
                                       commands = TahomaGlyph39Commands,
                                       coordinates = TahomaGlyph39Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 40,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.382813f, 0.000000f},
                                       commands = TahomaGlyph40Commands,
                                       coordinates = TahomaGlyph40Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 41,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.382813f, 0.000000f},
                                       commands = TahomaGlyph41Commands,
                                       coordinates = TahomaGlyph41Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 42,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph42Commands,
                                       coordinates = TahomaGlyph42Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 43,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.727539f, 0.000000f},
                                       commands = TahomaGlyph43Commands,
                                       coordinates = TahomaGlyph43Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 44,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.302734f, 0.000000f},
                                       commands = TahomaGlyph44Commands,
                                       coordinates = TahomaGlyph44Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 45,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.363281f, 0.000000f},
                                       commands = TahomaGlyph45Commands,
                                       coordinates = TahomaGlyph45Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 46,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.302734f, 0.000000f},
                                       commands = TahomaGlyph46Commands,
                                       coordinates = TahomaGlyph46Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 47,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.382324f, 0.000000f},
                                       commands = TahomaGlyph47Commands,
                                       coordinates = TahomaGlyph47Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 48,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph48Commands,
                                       coordinates = TahomaGlyph48Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 49,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph49Commands,
                                       coordinates = TahomaGlyph49Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 50,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph50Commands,
                                       coordinates = TahomaGlyph50Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 51,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph51Commands,
                                       coordinates = TahomaGlyph51Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 52,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph52Commands,
                                       coordinates = TahomaGlyph52Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 53,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph53Commands,
                                       coordinates = TahomaGlyph53Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 54,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph54Commands,
                                       coordinates = TahomaGlyph54Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 55,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph55Commands,
                                       coordinates = TahomaGlyph55Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 56,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph56Commands,
                                       coordinates = TahomaGlyph56Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 57,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph57Commands,
                                       coordinates = TahomaGlyph57Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 58,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.353516f, 0.000000f},
                                       commands = TahomaGlyph58Commands,
                                       coordinates = TahomaGlyph58Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 59,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.353516f, 0.000000f},
                                       commands = TahomaGlyph59Commands,
                                       coordinates = TahomaGlyph59Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 60,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.727539f, 0.000000f},
                                       commands = TahomaGlyph60Commands,
                                       coordinates = TahomaGlyph60Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 61,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.727539f, 0.000000f},
                                       commands = TahomaGlyph61Commands,
                                       coordinates = TahomaGlyph61Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 62,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.727539f, 0.000000f},
                                       commands = TahomaGlyph62Commands,
                                       coordinates = TahomaGlyph62Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 63,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.473633f, 0.000000f},
                                       commands = TahomaGlyph63Commands,
                                       coordinates = TahomaGlyph63Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 64,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.909180f, 0.000000f},
                                       commands = TahomaGlyph64Commands,
                                       coordinates = TahomaGlyph64Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 65,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.599609f, 0.000000f},
                                       commands = TahomaGlyph65Commands,
                                       coordinates = TahomaGlyph65Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 66,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.589355f, 0.000000f},
                                       commands = TahomaGlyph66Commands,
                                       coordinates = TahomaGlyph66Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 67,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.600586f, 0.000000f},
                                       commands = TahomaGlyph67Commands,
                                       coordinates = TahomaGlyph67Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 68,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.678223f, 0.000000f},
                                       commands = TahomaGlyph68Commands,
                                       coordinates = TahomaGlyph68Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 69,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.561035f, 0.000000f},
                                       commands = TahomaGlyph69Commands,
                                       coordinates = TahomaGlyph69Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 70,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.521484f, 0.000000f},
                                       commands = TahomaGlyph70Commands,
                                       coordinates = TahomaGlyph70Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 71,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.667480f, 0.000000f},
                                       commands = TahomaGlyph71Commands,
                                       coordinates = TahomaGlyph71Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 72,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.675293f, 0.000000f},
                                       commands = TahomaGlyph72Commands,
                                       coordinates = TahomaGlyph72Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 73,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.373047f, 0.000000f},
                                       commands = TahomaGlyph73Commands,
                                       coordinates = TahomaGlyph73Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 74,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.416504f, 0.000000f},
                                       commands = TahomaGlyph74Commands,
                                       coordinates = TahomaGlyph74Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 75,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.587891f, 0.000000f},
                                       commands = TahomaGlyph75Commands,
                                       coordinates = TahomaGlyph75Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 76,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.497559f, 0.000000f},
                                       commands = TahomaGlyph76Commands,
                                       coordinates = TahomaGlyph76Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 77,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.770508f, 0.000000f},
                                       commands = TahomaGlyph77Commands,
                                       coordinates = TahomaGlyph77Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 78,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.667480f, 0.000000f},
                                       commands = TahomaGlyph78Commands,
                                       coordinates = TahomaGlyph78Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 79,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.707520f, 0.000000f},
                                       commands = TahomaGlyph79Commands,
                                       coordinates = TahomaGlyph79Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 80,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.551270f, 0.000000f},
                                       commands = TahomaGlyph80Commands,
                                       coordinates = TahomaGlyph80Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 81,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.707520f, 0.000000f},
                                       commands = TahomaGlyph81Commands,
                                       coordinates = TahomaGlyph81Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 82,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.620605f, 0.000000f},
                                       commands = TahomaGlyph82Commands,
                                       coordinates = TahomaGlyph82Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 83,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.557129f, 0.000000f},
                                       commands = TahomaGlyph83Commands,
                                       coordinates = TahomaGlyph83Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 84,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.583984f, 0.000000f},
                                       commands = TahomaGlyph84Commands,
                                       coordinates = TahomaGlyph84Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 85,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.655762f, 0.000000f},
                                       commands = TahomaGlyph85Commands,
                                       coordinates = TahomaGlyph85Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 86,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.596680f, 0.000000f},
                                       commands = TahomaGlyph86Commands,
                                       coordinates = TahomaGlyph86Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 87,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.901855f, 0.000000f},
                                       commands = TahomaGlyph87Commands,
                                       coordinates = TahomaGlyph87Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 88,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.580566f, 0.000000f},
                                       commands = TahomaGlyph88Commands,
                                       coordinates = TahomaGlyph88Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 89,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.576172f, 0.000000f},
                                       commands = TahomaGlyph89Commands,
                                       coordinates = TahomaGlyph89Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 90,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.559082f, 0.000000f},
                                       commands = TahomaGlyph90Commands,
                                       coordinates = TahomaGlyph90Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 91,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.382813f, 0.000000f},
                                       commands = TahomaGlyph91Commands,
                                       coordinates = TahomaGlyph91Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 92,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.382324f, 0.000000f},
                                       commands = TahomaGlyph92Commands,
                                       coordinates = TahomaGlyph92Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 93,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.382813f, 0.000000f},
                                       commands = TahomaGlyph93Commands,
                                       coordinates = TahomaGlyph93Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 94,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.727539f, 0.000000f},
                                       commands = TahomaGlyph94Commands,
                                       coordinates = TahomaGlyph94Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 95,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph95Commands,
                                       coordinates = TahomaGlyph95Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 96,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph96Commands,
                                       coordinates = TahomaGlyph96Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 97,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.524902f, 0.000000f},
                                       commands = TahomaGlyph97Commands,
                                       coordinates = TahomaGlyph97Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 98,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.552734f, 0.000000f},
                                       commands = TahomaGlyph98Commands,
                                       coordinates = TahomaGlyph98Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 99,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.461426f, 0.000000f},
                                       commands = TahomaGlyph99Commands,
                                       coordinates = TahomaGlyph99Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 100,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.552734f, 0.000000f},
                                       commands = TahomaGlyph100Commands,
                                       coordinates = TahomaGlyph100Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 101,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.526367f, 0.000000f},
                                       commands = TahomaGlyph101Commands,
                                       coordinates = TahomaGlyph101Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 102,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.318359f, 0.000000f},
                                       commands = TahomaGlyph102Commands,
                                       coordinates = TahomaGlyph102Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 103,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.552734f, 0.000000f},
                                       commands = TahomaGlyph103Commands,
                                       coordinates = TahomaGlyph103Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 104,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.557617f, 0.000000f},
                                       commands = TahomaGlyph104Commands,
                                       coordinates = TahomaGlyph104Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 105,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.228516f, 0.000000f},
                                       commands = TahomaGlyph105Commands,
                                       coordinates = TahomaGlyph105Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 106,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.281738f, 0.000000f},
                                       commands = TahomaGlyph106Commands,
                                       coordinates = TahomaGlyph106Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 107,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.498047f, 0.000000f},
                                       commands = TahomaGlyph107Commands,
                                       coordinates = TahomaGlyph107Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 108,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.228516f, 0.000000f},
                                       commands = TahomaGlyph108Commands,
                                       coordinates = TahomaGlyph108Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 109,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.839844f, 0.000000f},
                                       commands = TahomaGlyph109Commands,
                                       coordinates = TahomaGlyph109Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 110,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.557617f, 0.000000f},
                                       commands = TahomaGlyph110Commands,
                                       coordinates = TahomaGlyph110Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 111,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.542969f, 0.000000f},
                                       commands = TahomaGlyph111Commands,
                                       coordinates = TahomaGlyph111Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 112,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.552734f, 0.000000f},
                                       commands = TahomaGlyph112Commands,
                                       coordinates = TahomaGlyph112Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 113,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.552734f, 0.000000f},
                                       commands = TahomaGlyph113Commands,
                                       coordinates = TahomaGlyph113Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 114,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.360352f, 0.000000f},
                                       commands = TahomaGlyph114Commands,
                                       coordinates = TahomaGlyph114Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 115,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.446289f, 0.000000f},
                                       commands = TahomaGlyph115Commands,
                                       coordinates = TahomaGlyph115Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 116,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.334473f, 0.000000f},
                                       commands = TahomaGlyph116Commands,
                                       coordinates = TahomaGlyph116Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 117,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.557617f, 0.000000f},
                                       commands = TahomaGlyph117Commands,
                                       coordinates = TahomaGlyph117Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 118,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.498047f, 0.000000f},
                                       commands = TahomaGlyph118Commands,
                                       coordinates = TahomaGlyph118Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 119,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.742188f, 0.000000f},
                                       commands = TahomaGlyph119Commands,
                                       coordinates = TahomaGlyph119Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 120,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.495117f, 0.000000f},
                                       commands = TahomaGlyph120Commands,
                                       coordinates = TahomaGlyph120Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 121,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.498047f, 0.000000f},
                                       commands = TahomaGlyph121Commands,
                                       coordinates = TahomaGlyph121Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 122,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.444336f, 0.000000f},
                                       commands = TahomaGlyph122Commands,
                                       coordinates = TahomaGlyph122Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 123,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.480469f, 0.000000f},
                                       commands = TahomaGlyph123Commands,
                                       coordinates = TahomaGlyph123Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 124,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.382324f, 0.000000f},
                                       commands = TahomaGlyph124Commands,
                                       coordinates = TahomaGlyph124Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 125,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.480469f, 0.000000f},
                                       commands = TahomaGlyph125Commands,
                                       coordinates = TahomaGlyph125Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 126,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.727539f, 0.000000f},
                                       commands = TahomaGlyph126Commands,
                                       coordinates = TahomaGlyph126Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 160,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.312500f, 0.000000f},
                                       commands = new byte[] {0},
                                       coordinates = new float[] {0}
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 161,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.332031f, 0.000000f},
                                       commands = TahomaGlyph161Commands,
                                       coordinates = TahomaGlyph161Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 162,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph162Commands,
                                       coordinates = TahomaGlyph162Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 163,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph163Commands,
                                       coordinates = TahomaGlyph163Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 164,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph164Commands,
                                       coordinates = TahomaGlyph164Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 165,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph165Commands,
                                       coordinates = TahomaGlyph165Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 166,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.382324f, 0.000000f},
                                       commands = TahomaGlyph166Commands,
                                       coordinates = TahomaGlyph166Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 167,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph167Commands,
                                       coordinates = TahomaGlyph167Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 168,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph168Commands,
                                       coordinates = TahomaGlyph168Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 169,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.928711f, 0.000000f},
                                       commands = TahomaGlyph169Commands,
                                       coordinates = TahomaGlyph169Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 170,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.493164f, 0.000000f},
                                       commands = TahomaGlyph170Commands,
                                       coordinates = TahomaGlyph170Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 171,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.573242f, 0.000000f},
                                       commands = TahomaGlyph171Commands,
                                       coordinates = TahomaGlyph171Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 172,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.727539f, 0.000000f},
                                       commands = TahomaGlyph172Commands,
                                       coordinates = TahomaGlyph172Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 173,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.363281f, 0.000000f},
                                       commands = TahomaGlyph173Commands,
                                       coordinates = TahomaGlyph173Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 174,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.928711f, 0.000000f},
                                       commands = TahomaGlyph174Commands,
                                       coordinates = TahomaGlyph174Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 175,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph175Commands,
                                       coordinates = TahomaGlyph175Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 176,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.470703f, 0.000000f},
                                       commands = TahomaGlyph176Commands,
                                       coordinates = TahomaGlyph176Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 177,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.727539f, 0.000000f},
                                       commands = TahomaGlyph177Commands,
                                       coordinates = TahomaGlyph177Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 178,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.493164f, 0.000000f},
                                       commands = TahomaGlyph178Commands,
                                       coordinates = TahomaGlyph178Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 179,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.493164f, 0.000000f},
                                       commands = TahomaGlyph179Commands,
                                       coordinates = TahomaGlyph179Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 180,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph180Commands,
                                       coordinates = TahomaGlyph180Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 181,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.567871f, 0.000000f},
                                       commands = TahomaGlyph181Commands,
                                       coordinates = TahomaGlyph181Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 182,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph182Commands,
                                       coordinates = TahomaGlyph182Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 183,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.353516f, 0.000000f},
                                       commands = TahomaGlyph183Commands,
                                       coordinates = TahomaGlyph183Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 184,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph184Commands,
                                       coordinates = TahomaGlyph184Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 185,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.493164f, 0.000000f},
                                       commands = TahomaGlyph185Commands,
                                       coordinates = TahomaGlyph185Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 186,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.493164f, 0.000000f},
                                       commands = TahomaGlyph186Commands,
                                       coordinates = TahomaGlyph186Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 187,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.573242f, 0.000000f},
                                       commands = TahomaGlyph187Commands,
                                       coordinates = TahomaGlyph187Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 188,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {1.000000f, 0.000000f},
                                       commands = TahomaGlyph188Commands,
                                       coordinates = TahomaGlyph188Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 189,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {1.000000f, 0.000000f},
                                       commands = TahomaGlyph189Commands,
                                       coordinates = TahomaGlyph189Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 190,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {1.000000f, 0.000000f},
                                       commands = TahomaGlyph190Commands,
                                       coordinates = TahomaGlyph190Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 191,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.473633f, 0.000000f},
                                       commands = TahomaGlyph191Commands,
                                       coordinates = TahomaGlyph191Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1025,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.561035f, 0.000000f},
                                       commands = TahomaGlyph1025Commands,
                                       coordinates = TahomaGlyph1025Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1026,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.718262f, 0.000000f},
                                       commands = TahomaGlyph1026Commands,
                                       coordinates = TahomaGlyph1026Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1027,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.507324f, 0.000000f},
                                       commands = TahomaGlyph1027Commands,
                                       coordinates = TahomaGlyph1027Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1028,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.599609f, 0.000000f},
                                       commands = TahomaGlyph1028Commands,
                                       coordinates = TahomaGlyph1028Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1029,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.557129f, 0.000000f},
                                       commands = TahomaGlyph1029Commands,
                                       coordinates = TahomaGlyph1029Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1030,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.373047f, 0.000000f},
                                       commands = TahomaGlyph1030Commands,
                                       coordinates = TahomaGlyph1030Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1031,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.373047f, 0.000000f},
                                       commands = TahomaGlyph1031Commands,
                                       coordinates = TahomaGlyph1031Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1032,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.416504f, 0.000000f},
                                       commands = TahomaGlyph1032Commands,
                                       coordinates = TahomaGlyph1032Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1033,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {1.001465f, 0.000000f},
                                       commands = TahomaGlyph1033Commands,
                                       coordinates = TahomaGlyph1033Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1034,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.983887f, 0.000000f},
                                       commands = TahomaGlyph1034Commands,
                                       coordinates = TahomaGlyph1034Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1035,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.717773f, 0.000000f},
                                       commands = TahomaGlyph1035Commands,
                                       coordinates = TahomaGlyph1035Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1036,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.602539f, 0.000000f},
                                       commands = TahomaGlyph1036Commands,
                                       coordinates = TahomaGlyph1036Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1037,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.669922f, 0.000000f},
                                       commands = TahomaGlyph1037Commands,
                                       coordinates = TahomaGlyph1037Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1038,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.575195f, 0.000000f},
                                       commands = TahomaGlyph1038Commands,
                                       coordinates = TahomaGlyph1038Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1039,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.675293f, 0.000000f},
                                       commands = TahomaGlyph1039Commands,
                                       coordinates = TahomaGlyph1039Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1040,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.599609f, 0.000000f},
                                       commands = TahomaGlyph1040Commands,
                                       coordinates = TahomaGlyph1040Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1041,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.589355f, 0.000000f},
                                       commands = TahomaGlyph1041Commands,
                                       coordinates = TahomaGlyph1041Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1042,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.589355f, 0.000000f},
                                       commands = TahomaGlyph1042Commands,
                                       coordinates = TahomaGlyph1042Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1043,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.507324f, 0.000000f},
                                       commands = TahomaGlyph1043Commands,
                                       coordinates = TahomaGlyph1043Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1044,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.683594f, 0.000000f},
                                       commands = TahomaGlyph1044Commands,
                                       coordinates = TahomaGlyph1044Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1045,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.561035f, 0.000000f},
                                       commands = TahomaGlyph1045Commands,
                                       coordinates = TahomaGlyph1045Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1046,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.894043f, 0.000000f},
                                       commands = TahomaGlyph1046Commands,
                                       coordinates = TahomaGlyph1046Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1047,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.532715f, 0.000000f},
                                       commands = TahomaGlyph1047Commands,
                                       coordinates = TahomaGlyph1047Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1048,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.669922f, 0.000000f},
                                       commands = TahomaGlyph1048Commands,
                                       coordinates = TahomaGlyph1048Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1049,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.669922f, 0.000000f},
                                       commands = TahomaGlyph1049Commands,
                                       coordinates = TahomaGlyph1049Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1050,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.602539f, 0.000000f},
                                       commands = TahomaGlyph1050Commands,
                                       coordinates = TahomaGlyph1050Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1051,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.677734f, 0.000000f},
                                       commands = TahomaGlyph1051Commands,
                                       coordinates = TahomaGlyph1051Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1052,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.770508f, 0.000000f},
                                       commands = TahomaGlyph1052Commands,
                                       coordinates = TahomaGlyph1052Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1053,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.675293f, 0.000000f},
                                       commands = TahomaGlyph1053Commands,
                                       coordinates = TahomaGlyph1053Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1054,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.707520f, 0.000000f},
                                       commands = TahomaGlyph1054Commands,
                                       coordinates = TahomaGlyph1054Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1055,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.675293f, 0.000000f},
                                       commands = TahomaGlyph1055Commands,
                                       coordinates = TahomaGlyph1055Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1056,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.551270f, 0.000000f},
                                       commands = TahomaGlyph1056Commands,
                                       coordinates = TahomaGlyph1056Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1057,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.600586f, 0.000000f},
                                       commands = TahomaGlyph1057Commands,
                                       coordinates = TahomaGlyph1057Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1058,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.583984f, 0.000000f},
                                       commands = TahomaGlyph1058Commands,
                                       coordinates = TahomaGlyph1058Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1059,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.575195f, 0.000000f},
                                       commands = TahomaGlyph1059Commands,
                                       coordinates = TahomaGlyph1059Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1060,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.748535f, 0.000000f},
                                       commands = TahomaGlyph1060Commands,
                                       coordinates = TahomaGlyph1060Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1061,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.580566f, 0.000000f},
                                       commands = TahomaGlyph1061Commands,
                                       coordinates = TahomaGlyph1061Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1062,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.685059f, 0.000000f},
                                       commands = TahomaGlyph1062Commands,
                                       coordinates = TahomaGlyph1062Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1063,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.635742f, 0.000000f},
                                       commands = TahomaGlyph1063Commands,
                                       coordinates = TahomaGlyph1063Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1064,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.943359f, 0.000000f},
                                       commands = TahomaGlyph1064Commands,
                                       coordinates = TahomaGlyph1064Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1065,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.958008f, 0.000000f},
                                       commands = TahomaGlyph1065Commands,
                                       coordinates = TahomaGlyph1065Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1066,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.689453f, 0.000000f},
                                       commands = TahomaGlyph1066Commands,
                                       coordinates = TahomaGlyph1066Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1067,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.788574f, 0.000000f},
                                       commands = TahomaGlyph1067Commands,
                                       coordinates = TahomaGlyph1067Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1068,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.582520f, 0.000000f},
                                       commands = TahomaGlyph1068Commands,
                                       coordinates = TahomaGlyph1068Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1069,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.599609f, 0.000000f},
                                       commands = TahomaGlyph1069Commands,
                                       coordinates = TahomaGlyph1069Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1070,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.951172f, 0.000000f},
                                       commands = TahomaGlyph1070Commands,
                                       coordinates = TahomaGlyph1070Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1071,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.611328f, 0.000000f},
                                       commands = TahomaGlyph1071Commands,
                                       coordinates = TahomaGlyph1071Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1072,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.524902f, 0.000000f},
                                       commands = TahomaGlyph1072Commands,
                                       coordinates = TahomaGlyph1072Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1073,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.549805f, 0.000000f},
                                       commands = TahomaGlyph1073Commands,
                                       coordinates = TahomaGlyph1073Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1074,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.524414f, 0.000000f},
                                       commands = TahomaGlyph1074Commands,
                                       coordinates = TahomaGlyph1074Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1075,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.415039f, 0.000000f},
                                       commands = TahomaGlyph1075Commands,
                                       coordinates = TahomaGlyph1075Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1076,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.558105f, 0.000000f},
                                       commands = TahomaGlyph1076Commands,
                                       coordinates = TahomaGlyph1076Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1077,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.526367f, 0.000000f},
                                       commands = TahomaGlyph1077Commands,
                                       coordinates = TahomaGlyph1077Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1078,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.730469f, 0.000000f},
                                       commands = TahomaGlyph1078Commands,
                                       coordinates = TahomaGlyph1078Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1079,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.457520f, 0.000000f},
                                       commands = TahomaGlyph1079Commands,
                                       coordinates = TahomaGlyph1079Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1080,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.563477f, 0.000000f},
                                       commands = TahomaGlyph1080Commands,
                                       coordinates = TahomaGlyph1080Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1081,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.563477f, 0.000000f},
                                       commands = TahomaGlyph1081Commands,
                                       coordinates = TahomaGlyph1081Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1082,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.498047f, 0.000000f},
                                       commands = TahomaGlyph1082Commands,
                                       coordinates = TahomaGlyph1082Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1083,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.555176f, 0.000000f},
                                       commands = TahomaGlyph1083Commands,
                                       coordinates = TahomaGlyph1083Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1084,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.638672f, 0.000000f},
                                       commands = TahomaGlyph1084Commands,
                                       coordinates = TahomaGlyph1084Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1085,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.562988f, 0.000000f},
                                       commands = TahomaGlyph1085Commands,
                                       coordinates = TahomaGlyph1085Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1086,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.542969f, 0.000000f},
                                       commands = TahomaGlyph1086Commands,
                                       coordinates = TahomaGlyph1086Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1087,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.563477f, 0.000000f},
                                       commands = TahomaGlyph1087Commands,
                                       coordinates = TahomaGlyph1087Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1088,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.552734f, 0.000000f},
                                       commands = TahomaGlyph1088Commands,
                                       coordinates = TahomaGlyph1088Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1089,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.461426f, 0.000000f},
                                       commands = TahomaGlyph1089Commands,
                                       coordinates = TahomaGlyph1089Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1090,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.466797f, 0.000000f},
                                       commands = TahomaGlyph1090Commands,
                                       coordinates = TahomaGlyph1090Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1091,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.498047f, 0.000000f},
                                       commands = TahomaGlyph1091Commands,
                                       coordinates = TahomaGlyph1091Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1092,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.759766f, 0.000000f},
                                       commands = TahomaGlyph1092Commands,
                                       coordinates = TahomaGlyph1092Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1093,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.495117f, 0.000000f},
                                       commands = TahomaGlyph1093Commands,
                                       coordinates = TahomaGlyph1093Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1094,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.571777f, 0.000000f},
                                       commands = TahomaGlyph1094Commands,
                                       coordinates = TahomaGlyph1094Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1095,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.542969f, 0.000000f},
                                       commands = TahomaGlyph1095Commands,
                                       coordinates = TahomaGlyph1095Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1096,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.778320f, 0.000000f},
                                       commands = TahomaGlyph1096Commands,
                                       coordinates = TahomaGlyph1096Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1097,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.790039f, 0.000000f},
                                       commands = TahomaGlyph1097Commands,
                                       coordinates = TahomaGlyph1097Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1098,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.568359f, 0.000000f},
                                       commands = TahomaGlyph1098Commands,
                                       coordinates = TahomaGlyph1098Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1099,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.692871f, 0.000000f},
                                       commands = TahomaGlyph1099Commands,
                                       coordinates = TahomaGlyph1099Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1100,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.500488f, 0.000000f},
                                       commands = TahomaGlyph1100Commands,
                                       coordinates = TahomaGlyph1100Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1101,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.471191f, 0.000000f},
                                       commands = TahomaGlyph1101Commands,
                                       coordinates = TahomaGlyph1101Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1102,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.761719f, 0.000000f},
                                       commands = TahomaGlyph1102Commands,
                                       coordinates = TahomaGlyph1102Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1103,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.527832f, 0.000000f},
                                       commands = TahomaGlyph1103Commands,
                                       coordinates = TahomaGlyph1103Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1104,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.526367f, 0.000000f},
                                       commands = TahomaGlyph1104Commands,
                                       coordinates = TahomaGlyph1104Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1105,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.526367f, 0.000000f},
                                       commands = TahomaGlyph1105Commands,
                                       coordinates = TahomaGlyph1105Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1106,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.578125f, 0.000000f},
                                       commands = TahomaGlyph1106Commands,
                                       coordinates = TahomaGlyph1106Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8319,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.493164f, 0.000000f},
                                       commands = TahomaGlyph8319Commands,
                                       coordinates = TahomaGlyph8319Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8336,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.378418f, 0.000000f},
                                       commands = TahomaGlyph8336Commands,
                                       coordinates = TahomaGlyph8336Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8337,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.394043f, 0.000000f},
                                       commands = TahomaGlyph8337Commands,
                                       coordinates = TahomaGlyph8337Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8338,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.404297f, 0.000000f},
                                       commands = TahomaGlyph8338Commands,
                                       coordinates = TahomaGlyph8338Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8339,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.331543f, 0.000000f},
                                       commands = TahomaGlyph8339Commands,
                                       coordinates = TahomaGlyph8339Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8340,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.394043f, 0.000000f},
                                       commands = TahomaGlyph8340Commands,
                                       coordinates = TahomaGlyph8340Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8352,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.576660f, 0.000000f},
                                       commands = TahomaGlyph8352Commands,
                                       coordinates = TahomaGlyph8352Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8353,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.600586f, 0.000000f},
                                       commands = TahomaGlyph8353Commands,
                                       coordinates = TahomaGlyph8353Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8354,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.600586f, 0.000000f},
                                       commands = TahomaGlyph8354Commands,
                                       coordinates = TahomaGlyph8354Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8355,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph8355Commands,
                                       coordinates = TahomaGlyph8355Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8356,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph8356Commands,
                                       coordinates = TahomaGlyph8356Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8357,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.839844f, 0.000000f},
                                       commands = TahomaGlyph8357Commands,
                                       coordinates = TahomaGlyph8357Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8358,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.667480f, 0.000000f},
                                       commands = TahomaGlyph8358Commands,
                                       coordinates = TahomaGlyph8358Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8359,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.954102f, 0.000000f},
                                       commands = TahomaGlyph8359Commands,
                                       coordinates = TahomaGlyph8359Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8360,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {1.138672f, 0.000000f},
                                       commands = TahomaGlyph8360Commands,
                                       coordinates = TahomaGlyph8360Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8361,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.901855f, 0.000000f},
                                       commands = TahomaGlyph8361Commands,
                                       coordinates = TahomaGlyph8361Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8362,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.834961f, 0.000000f},
                                       commands = TahomaGlyph8362Commands,
                                       coordinates = TahomaGlyph8362Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8363,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.573242f, 0.000000f},
                                       commands = TahomaGlyph8363Commands,
                                       coordinates = TahomaGlyph8363Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8364,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph8364Commands,
                                       coordinates = TahomaGlyph8364Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8365,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.587891f, 0.000000f},
                                       commands = TahomaGlyph8365Commands,
                                       coordinates = TahomaGlyph8365Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8366,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.583984f, 0.000000f},
                                       commands = TahomaGlyph8366Commands,
                                       coordinates = TahomaGlyph8366Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8367,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {1.000000f, 0.000000f},
                                       commands = TahomaGlyph8367Commands,
                                       coordinates = TahomaGlyph8367Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8368,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.520996f, 0.000000f},
                                       commands = TahomaGlyph8368Commands,
                                       coordinates = TahomaGlyph8368Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8369,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.551270f, 0.000000f},
                                       commands = TahomaGlyph8369Commands,
                                       coordinates = TahomaGlyph8369Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8370,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph8370Commands,
                                       coordinates = TahomaGlyph8370Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8371,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph8371Commands,
                                       coordinates = TahomaGlyph8371Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8372,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph8372Commands,
                                       coordinates = TahomaGlyph8372Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8373,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph8373Commands,
                                       coordinates = TahomaGlyph8373Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8376,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph8376Commands,
                                       coordinates = TahomaGlyph8376Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8377,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.545898f, 0.000000f},
                                       commands = TahomaGlyph8377Commands,
                                       coordinates = TahomaGlyph8377Coordinates
                                   },
                           };
            }
        }

// public uint GlyphsCount = 239;

        #endregion

        #region kernings

        public Kerning[] Kernings
        {
            get
            {
                return new[]
                           {
                               new Kerning {key = 2170905, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 2170909, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 2555969, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 2556102, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 2621524, x = 0.009766f, y = 0.000000f},
                               new Kerning {key = 2621546, x = 0.023926f, y = 0.000000f},
                               new Kerning {key = 2883625, x = -0.043945f, y = 0.000000f},
                               new Kerning {key = 2883639, x = -0.023926f, y = 0.000000f},
                               new Kerning {key = 2883677, x = -0.043945f, y = 0.000000f},
                               new Kerning {key = 2883709, x = -0.043945f, y = 0.000000f},
                               new Kerning {key = 2891801, x = -0.098145f, y = 0.000000f},
                               new Kerning {key = 2891805, x = -0.098145f, y = 0.000000f},
                               new Kerning {key = 2949185, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 2949193, x = -0.014160f, y = 0.000000f},
                               new Kerning {key = 2949194, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 2949203, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 2949204, x = -0.069824f, y = 0.000000f},
                               new Kerning {key = 2949206, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 2949207, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 2949208, x = -0.037109f, y = 0.000000f},
                               new Kerning {key = 2949209, x = -0.063965f, y = 0.000000f},
                               new Kerning {key = 2949210, x = -0.014160f, y = 0.000000f},
                               new Kerning {key = 2949217, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 2949238, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 2949239, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 2949240, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 2949241, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 2949242, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 2949318, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 2949350, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 3014697, x = -0.048828f, y = 0.000000f},
                               new Kerning {key = 3014700, x = -0.064941f, y = 0.000000f},
                               new Kerning {key = 3014701, x = -0.079102f, y = 0.000000f},
                               new Kerning {key = 3014711, x = -0.023926f, y = 0.000000f},
                               new Kerning {key = 3014749, x = -0.048828f, y = 0.000000f},
                               new Kerning {key = 3014781, x = -0.048828f, y = 0.000000f},
                               new Kerning {key = 3014829, x = -0.079102f, y = 0.000000f},
                               new Kerning {key = 3022867, x = -0.056152f, y = 0.000000f},
                               new Kerning {key = 3022868, x = -0.056152f, y = 0.000000f},
                               new Kerning {key = 3022873, x = -0.098145f, y = 0.000000f},
                               new Kerning {key = 3022877, x = -0.098145f, y = 0.000000f},
                               new Kerning {key = 3407916, x = -0.009766f, y = 0.000000f},
                               new Kerning {key = 3407918, x = -0.009766f, y = 0.000000f},
                               new Kerning {key = 3604524, x = -0.073242f, y = 0.000000f},
                               new Kerning {key = 3604526, x = -0.073242f, y = 0.000000f},
                               new Kerning {key = 3809300, x = -0.063965f, y = 0.000000f},
                               new Kerning {key = 4259885, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 4259923, x = -0.001953f, y = 0.000000f},
                               new Kerning {key = 4259924, x = -0.056152f, y = 0.000000f},
                               new Kerning {key = 4259925, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 4259926, x = -0.026855f, y = 0.000000f},
                               new Kerning {key = 4259927, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 4259929, x = -0.037109f, y = 0.000000f},
                               new Kerning {key = 4259956, x = -0.006836f, y = 0.000000f},
                               new Kerning {key = 4259957, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 4259958, x = -0.013184f, y = 0.000000f},
                               new Kerning {key = 4259959, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 4259961, x = -0.013184f, y = 0.000000f},
                               new Kerning {key = 4260013, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 4268051, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 4268052, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 4268056, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 4268057, x = -0.056152f, y = 0.000000f},
                               new Kerning {key = 4268060, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 4268061, x = -0.056152f, y = 0.000000f},
                               new Kerning {key = 4325420, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 4325421, x = 0.004883f, y = 0.000000f},
                               new Kerning {key = 4325422, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 4325443, x = 0.004883f, y = 0.000000f},
                               new Kerning {key = 4325447, x = 0.004883f, y = 0.000000f},
                               new Kerning {key = 4325455, x = 0.004883f, y = 0.000000f},
                               new Kerning {key = 4325457, x = 0.004883f, y = 0.000000f},
                               new Kerning {key = 4325460, x = -0.026855f, y = 0.000000f},
                               new Kerning {key = 4325473, x = 0.004883f, y = 0.000000f},
                               new Kerning {key = 4325477, x = 0.004883f, y = 0.000000f},
                               new Kerning {key = 4325480, x = 0.005859f, y = 0.000000f},
                               new Kerning {key = 4325481, x = 0.004883f, y = 0.000000f},
                               new Kerning {key = 4325482, x = 0.004883f, y = 0.000000f},
                               new Kerning {key = 4325484, x = 0.005859f, y = 0.000000f},
                               new Kerning {key = 4325487, x = 0.004883f, y = 0.000000f},
                               new Kerning {key = 4325490, x = 0.004883f, y = 0.000000f},
                               new Kerning {key = 4325493, x = 0.004883f, y = 0.000000f},
                               new Kerning {key = 4325495, x = 0.004883f, y = 0.000000f},
                               new Kerning {key = 4325497, x = 0.000977f, y = 0.000000f},
                               new Kerning {key = 4325549, x = 0.004883f, y = 0.000000f},
                               new Kerning {key = 4333587, x = 0.004883f, y = 0.000000f},
                               new Kerning {key = 4333588, x = 0.004883f, y = 0.000000f},
                               new Kerning {key = 4333606, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 4390957, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 4391085, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 4391250, x = -0.012207f, y = 0.000000f},
                               new Kerning {key = 4399123, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 4399124, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 4456492, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 4456494, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 4456522, x = -0.009766f, y = 0.000000f},
                               new Kerning {key = 4456532, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 4456535, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 4456536, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 4456537, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 4456538, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 4464678, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 4587564, x = -0.139160f, y = 0.000000f},
                               new Kerning {key = 4587566, x = -0.139160f, y = 0.000000f},
                               new Kerning {key = 4587578, x = -0.026855f, y = 0.000000f},
                               new Kerning {key = 4587579, x = -0.026855f, y = 0.000000f},
                               new Kerning {key = 4587583, x = 0.026855f, y = 0.000000f},
                               new Kerning {key = 4587585, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 4587594, x = -0.028809f, y = 0.000000f},
                               new Kerning {key = 4587604, x = 0.014160f, y = 0.000000f},
                               new Kerning {key = 4587617, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 4587621, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 4587631, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 4587718, x = -0.050781f, y = 0.000000f},
                               new Kerning {key = 4587750, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 4587768, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 4587859, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 4588414, x = -0.026855f, y = 0.000000f},
                               new Kerning {key = 4595750, x = -0.139160f, y = 0.000000f},
                               new Kerning {key = 4784173, x = -0.014160f, y = 0.000000f},
                               new Kerning {key = 4784225, x = -0.009766f, y = 0.000000f},
                               new Kerning {key = 4784227, x = -0.012207f, y = 0.000000f},
                               new Kerning {key = 4784228, x = -0.009766f, y = 0.000000f},
                               new Kerning {key = 4784229, x = -0.012207f, y = 0.000000f},
                               new Kerning {key = 4784231, x = -0.009766f, y = 0.000000f},
                               new Kerning {key = 4784237, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 4784238, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 4784239, x = -0.012207f, y = 0.000000f},
                               new Kerning {key = 4784240, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 4784242, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 4784243, x = -0.009766f, y = 0.000000f},
                               new Kerning {key = 4784246, x = -0.015137f, y = 0.000000f},
                               new Kerning {key = 4784301, x = -0.014160f, y = 0.000000f},
                               new Kerning {key = 4792339, x = -0.014160f, y = 0.000000f},
                               new Kerning {key = 4792340, x = -0.014160f, y = 0.000000f},
                               new Kerning {key = 4849708, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 4849710, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 4849729, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 4849862, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 4857894, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 4915245, x = -0.050781f, y = 0.000000f},
                               new Kerning {key = 4915279, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 4915297, x = -0.021973f, y = 0.000000f},
                               new Kerning {key = 4915301, x = -0.027832f, y = 0.000000f},
                               new Kerning {key = 4915311, x = -0.027832f, y = 0.000000f},
                               new Kerning {key = 4915317, x = -0.020020f, y = 0.000000f},
                               new Kerning {key = 4915318, x = -0.026855f, y = 0.000000f},
                               new Kerning {key = 4915319, x = -0.027832f, y = 0.000000f},
                               new Kerning {key = 4915321, x = -0.026855f, y = 0.000000f},
                               new Kerning {key = 4915373, x = -0.050781f, y = 0.000000f},
                               new Kerning {key = 4915416, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 4915430, x = -0.026855f, y = 0.000000f},
                               new Kerning {key = 4915448, x = -0.033203f, y = 0.000000f},
                               new Kerning {key = 4915538, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 4915539, x = -0.033203f, y = 0.000000f},
                               new Kerning {key = 4923411, x = -0.050781f, y = 0.000000f},
                               new Kerning {key = 4923412, x = -0.050781f, y = 0.000000f},
                               new Kerning {key = 4980775, x = -0.056152f, y = 0.000000f},
                               new Kerning {key = 4980781, x = -0.074219f, y = 0.000000f},
                               new Kerning {key = 4980801, x = -0.020020f, y = 0.000000f},
                               new Kerning {key = 4980803, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 4980807, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 4980810, x = 0.045898f, y = 0.000000f},
                               new Kerning {key = 4980815, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 4980817, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 4980820, x = -0.079102f, y = 0.000000f},
                               new Kerning {key = 4980822, x = -0.050781f, y = 0.000000f},
                               new Kerning {key = 4980823, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 4980825, x = -0.074219f, y = 0.000000f},
                               new Kerning {key = 4980854, x = -0.050781f, y = 0.000000f},
                               new Kerning {key = 4980857, x = -0.050781f, y = 0.000000f},
                               new Kerning {key = 4980909, x = -0.074219f, y = 0.000000f},
                               new Kerning {key = 4980934, x = -0.020020f, y = 0.000000f},
                               new Kerning {key = 4980935, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 4980952, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 4981074, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 4988947, x = -0.074219f, y = 0.000000f},
                               new Kerning {key = 4988948, x = -0.074219f, y = 0.000000f},
                               new Kerning {key = 4988953, x = -0.074219f, y = 0.000000f},
                               new Kerning {key = 4988957, x = -0.074219f, y = 0.000000f},
                               new Kerning {key = 5177388, x = -0.014160f, y = 0.000000f},
                               new Kerning {key = 5177390, x = -0.014160f, y = 0.000000f},
                               new Kerning {key = 5177418, x = -0.003906f, y = 0.000000f},
                               new Kerning {key = 5177428, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5177432, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 5177433, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 5177434, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 5185574, x = -0.014160f, y = 0.000000f},
                               new Kerning {key = 5242924, x = -0.139160f, y = 0.000000f},
                               new Kerning {key = 5242926, x = -0.139160f, y = 0.000000f},
                               new Kerning {key = 5242945, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5242954, x = -0.034180f, y = 0.000000f},
                               new Kerning {key = 5242969, x = 0.008789f, y = 0.000000f},
                               new Kerning {key = 5242977, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5242981, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5242991, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5243078, x = -0.033203f, y = 0.000000f},
                               new Kerning {key = 5243110, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5243128, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5243219, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5251110, x = -0.139160f, y = 0.000000f},
                               new Kerning {key = 5308460, x = -0.014160f, y = 0.000000f},
                               new Kerning {key = 5308462, x = -0.014160f, y = 0.000000f},
                               new Kerning {key = 5316646, x = -0.014160f, y = 0.000000f},
                               new Kerning {key = 5373997, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 5374036, x = -0.026855f, y = 0.000000f},
                               new Kerning {key = 5374041, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 5374049, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 5374053, x = -0.018066f, y = 0.000000f},
                               new Kerning {key = 5374063, x = -0.018066f, y = 0.000000f},
                               new Kerning {key = 5374069, x = -0.005859f, y = 0.000000f},
                               new Kerning {key = 5374073, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5374125, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 5374182, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5374200, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5374291, x = -0.026855f, y = 0.000000f},
                               new Kerning {key = 5382163, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 5382164, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 5382169, x = -0.033203f, y = 0.000000f},
                               new Kerning {key = 5382173, x = -0.033203f, y = 0.000000f},
                               new Kerning {key = 5439532, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 5439534, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 5439553, x = -0.006836f, y = 0.000000f},
                               new Kerning {key = 5439571, x = -0.011230f, y = 0.000000f},
                               new Kerning {key = 5439587, x = 0.001953f, y = 0.000000f},
                               new Kerning {key = 5439589, x = 0.001953f, y = 0.000000f},
                               new Kerning {key = 5439599, x = 0.001953f, y = 0.000000f},
                               new Kerning {key = 5439601, x = 0.002930f, y = 0.000000f},
                               new Kerning {key = 5439606, x = -0.014160f, y = 0.000000f},
                               new Kerning {key = 5439607, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 5439609, x = -0.014160f, y = 0.000000f},
                               new Kerning {key = 5439686, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 5447718, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 5505065, x = 0.009766f, y = 0.000000f},
                               new Kerning {key = 5505068, x = -0.134766f, y = 0.000000f},
                               new Kerning {key = 5505069, x = -0.069824f, y = 0.000000f},
                               new Kerning {key = 5505070, x = -0.134766f, y = 0.000000f},
                               new Kerning {key = 5505082, x = -0.092773f, y = 0.000000f},
                               new Kerning {key = 5505083, x = -0.092773f, y = 0.000000f},
                               new Kerning {key = 5505087, x = 0.026855f, y = 0.000000f},
                               new Kerning {key = 5505089, x = -0.056152f, y = 0.000000f},
                               new Kerning {key = 5505091, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 5505095, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 5505098, x = -0.028809f, y = 0.000000f},
                               new Kerning {key = 5505103, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5505107, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 5505108, x = -0.048828f, y = 0.000000f},
                               new Kerning {key = 5505113, x = -0.034180f, y = 0.000000f},
                               new Kerning {key = 5505117, x = 0.009766f, y = 0.000000f},
                               new Kerning {key = 5505121, x = -0.110840f, y = 0.000000f},
                               new Kerning {key = 5505123, x = -0.102051f, y = 0.000000f},
                               new Kerning {key = 5505125, x = -0.102051f, y = 0.000000f},
                               new Kerning {key = 5505127, x = -0.098145f, y = 0.000000f},
                               new Kerning {key = 5505135, x = -0.102051f, y = 0.000000f},
                               new Kerning {key = 5505138, x = -0.092773f, y = 0.000000f},
                               new Kerning {key = 5505139, x = -0.083008f, y = 0.000000f},
                               new Kerning {key = 5505141, x = -0.092773f, y = 0.000000f},
                               new Kerning {key = 5505142, x = -0.092773f, y = 0.000000f},
                               new Kerning {key = 5505143, x = -0.092773f, y = 0.000000f},
                               new Kerning {key = 5505145, x = -0.092773f, y = 0.000000f},
                               new Kerning {key = 5505146, x = -0.079102f, y = 0.000000f},
                               new Kerning {key = 5505149, x = 0.009766f, y = 0.000000f},
                               new Kerning {key = 5505197, x = -0.069824f, y = 0.000000f},
                               new Kerning {key = 5505222, x = -0.060059f, y = 0.000000f},
                               new Kerning {key = 5505223, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 5505240, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5505254, x = -0.110840f, y = 0.000000f},
                               new Kerning {key = 5505272, x = -0.102051f, y = 0.000000f},
                               new Kerning {key = 5505362, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5505363, x = -0.102051f, y = 0.000000f},
                               new Kerning {key = 5505918, x = -0.092773f, y = 0.000000f},
                               new Kerning {key = 5513235, x = -0.069824f, y = 0.000000f},
                               new Kerning {key = 5513236, x = -0.069824f, y = 0.000000f},
                               new Kerning {key = 5513254, x = -0.134766f, y = 0.000000f},
                               new Kerning {key = 5570604, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 5570606, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 5570625, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 5570758, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 5578790, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 5636140, x = -0.134766f, y = 0.000000f},
                               new Kerning {key = 5636141, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5636142, x = -0.134766f, y = 0.000000f},
                               new Kerning {key = 5636154, x = -0.037109f, y = 0.000000f},
                               new Kerning {key = 5636155, x = -0.037109f, y = 0.000000f},
                               new Kerning {key = 5636161, x = -0.026855f, y = 0.000000f},
                               new Kerning {key = 5636193, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 5636197, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 5636207, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 5636213, x = -0.026855f, y = 0.000000f},
                               new Kerning {key = 5636217, x = -0.030762f, y = 0.000000f},
                               new Kerning {key = 5636269, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5636294, x = -0.033203f, y = 0.000000f},
                               new Kerning {key = 5636326, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 5636344, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 5636435, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 5636990, x = -0.037109f, y = 0.000000f},
                               new Kerning {key = 5644307, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5644308, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5644326, x = -0.134766f, y = 0.000000f},
                               new Kerning {key = 5701676, x = -0.134766f, y = 0.000000f},
                               new Kerning {key = 5701677, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5701678, x = -0.102051f, y = 0.000000f},
                               new Kerning {key = 5701690, x = -0.037109f, y = 0.000000f},
                               new Kerning {key = 5701691, x = -0.037109f, y = 0.000000f},
                               new Kerning {key = 5701697, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5701729, x = -0.037109f, y = 0.000000f},
                               new Kerning {key = 5701733, x = -0.037109f, y = 0.000000f},
                               new Kerning {key = 5701743, x = -0.037109f, y = 0.000000f},
                               new Kerning {key = 5701746, x = -0.018066f, y = 0.000000f},
                               new Kerning {key = 5701749, x = -0.018066f, y = 0.000000f},
                               new Kerning {key = 5701753, x = -0.025879f, y = 0.000000f},
                               new Kerning {key = 5701805, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5701830, x = -0.018066f, y = 0.000000f},
                               new Kerning {key = 5701862, x = -0.037109f, y = 0.000000f},
                               new Kerning {key = 5701880, x = -0.037109f, y = 0.000000f},
                               new Kerning {key = 5701971, x = -0.037109f, y = 0.000000f},
                               new Kerning {key = 5702526, x = -0.037109f, y = 0.000000f},
                               new Kerning {key = 5709843, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5709844, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5709862, x = -0.102051f, y = 0.000000f},
                               new Kerning {key = 5767213, x = -0.037109f, y = 0.000000f},
                               new Kerning {key = 5767235, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 5767239, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 5767247, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 5767265, x = -0.018066f, y = 0.000000f},
                               new Kerning {key = 5767269, x = -0.021973f, y = 0.000000f},
                               new Kerning {key = 5767279, x = -0.021973f, y = 0.000000f},
                               new Kerning {key = 5767285, x = -0.014160f, y = 0.000000f},
                               new Kerning {key = 5767289, x = -0.032227f, y = 0.000000f},
                               new Kerning {key = 5767341, x = -0.037109f, y = 0.000000f},
                               new Kerning {key = 5767367, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 5767384, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 5767398, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5767416, x = -0.026855f, y = 0.000000f},
                               new Kerning {key = 5767506, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 5767507, x = -0.026855f, y = 0.000000f},
                               new Kerning {key = 5775379, x = -0.037109f, y = 0.000000f},
                               new Kerning {key = 5775380, x = -0.037109f, y = 0.000000f},
                               new Kerning {key = 5832748, x = -0.134766f, y = 0.000000f},
                               new Kerning {key = 5832749, x = -0.063965f, y = 0.000000f},
                               new Kerning {key = 5832750, x = -0.134766f, y = 0.000000f},
                               new Kerning {key = 5832762, x = -0.092773f, y = 0.000000f},
                               new Kerning {key = 5832763, x = -0.092773f, y = 0.000000f},
                               new Kerning {key = 5832769, x = -0.037109f, y = 0.000000f},
                               new Kerning {key = 5832778, x = -0.028809f, y = 0.000000f},
                               new Kerning {key = 5832783, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 5832801, x = -0.063965f, y = 0.000000f},
                               new Kerning {key = 5832804, x = -0.056152f, y = 0.000000f},
                               new Kerning {key = 5832805, x = -0.060059f, y = 0.000000f},
                               new Kerning {key = 5832807, x = -0.060059f, y = 0.000000f},
                               new Kerning {key = 5832813, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 5832814, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 5832815, x = -0.060059f, y = 0.000000f},
                               new Kerning {key = 5832816, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 5832817, x = -0.060059f, y = 0.000000f},
                               new Kerning {key = 5832818, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 5832819, x = -0.050781f, y = 0.000000f},
                               new Kerning {key = 5832821, x = -0.050781f, y = 0.000000f},
                               new Kerning {key = 5832822, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 5832877, x = -0.063965f, y = 0.000000f},
                               new Kerning {key = 5832902, x = -0.037109f, y = 0.000000f},
                               new Kerning {key = 5832920, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 5832934, x = -0.063965f, y = 0.000000f},
                               new Kerning {key = 5832952, x = -0.060059f, y = 0.000000f},
                               new Kerning {key = 5833042, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 5833043, x = -0.060059f, y = 0.000000f},
                               new Kerning {key = 5833598, x = -0.092773f, y = 0.000000f},
                               new Kerning {key = 5840915, x = -0.063965f, y = 0.000000f},
                               new Kerning {key = 5840916, x = -0.063965f, y = 0.000000f},
                               new Kerning {key = 5840934, x = -0.134766f, y = 0.000000f},
                               new Kerning {key = 5898285, x = -0.026855f, y = 0.000000f},
                               new Kerning {key = 5898307, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 5898311, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 5898319, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 5898330, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 5898337, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5898341, x = -0.026855f, y = 0.000000f},
                               new Kerning {key = 5898351, x = -0.026855f, y = 0.000000f},
                               new Kerning {key = 5898359, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 5898361, x = -0.030762f, y = 0.000000f},
                               new Kerning {key = 5898413, x = -0.026855f, y = 0.000000f},
                               new Kerning {key = 5898439, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 5898456, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 5898470, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5898488, x = -0.026855f, y = 0.000000f},
                               new Kerning {key = 5898578, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 5898579, x = -0.026855f, y = 0.000000f},
                               new Kerning {key = 5906451, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5906452, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 5963860, x = 0.009766f, y = 0.000000f},
                               new Kerning {key = 5963882, x = 0.023926f, y = 0.000000f},
                               new Kerning {key = 6357110, x = -0.006836f, y = 0.000000f},
                               new Kerning {key = 6357111, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 6357113, x = -0.006836f, y = 0.000000f},
                               new Kerning {key = 6422572, x = -0.014160f, y = 0.000000f},
                               new Kerning {key = 6422574, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 6422649, x = -0.001953f, y = 0.000000f},
                               new Kerning {key = 6430758, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 6488109, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 6488148, x = -0.046875f, y = 0.000000f},
                               new Kerning {key = 6488163, x = -0.002930f, y = 0.000000f},
                               new Kerning {key = 6488237, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 6488295, x = -0.002930f, y = 0.000000f},
                               new Kerning {key = 6496275, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 6496276, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 6619220, x = -0.063965f, y = 0.000000f},
                               new Kerning {key = 6684706, x = 0.041992f, y = 0.000000f},
                               new Kerning {key = 6684711, x = 0.041992f, y = 0.000000f},
                               new Kerning {key = 6684713, x = 0.048828f, y = 0.000000f},
                               new Kerning {key = 6684714, x = 0.033203f, y = 0.000000f},
                               new Kerning {key = 6684716, x = -0.073242f, y = 0.000000f},
                               new Kerning {key = 6684717, x = -0.033203f, y = 0.000000f},
                               new Kerning {key = 6684718, x = -0.073242f, y = 0.000000f},
                               new Kerning {key = 6684735, x = 0.056152f, y = 0.000000f},
                               new Kerning {key = 6684764, x = 0.045898f, y = 0.000000f},
                               new Kerning {key = 6684765, x = 0.048828f, y = 0.000000f},
                               new Kerning {key = 6684769, x = -0.012207f, y = 0.000000f},
                               new Kerning {key = 6684771, x = -0.009766f, y = 0.000000f},
                               new Kerning {key = 6684773, x = -0.009766f, y = 0.000000f},
                               new Kerning {key = 6684774, x = -0.006836f, y = 0.000000f},
                               new Kerning {key = 6684775, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 6684778, x = -0.009766f, y = 0.000000f},
                               new Kerning {key = 6684781, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 6684782, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 6684783, x = -0.009766f, y = 0.000000f},
                               new Kerning {key = 6684784, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 6684785, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 6684786, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 6684787, x = -0.011230f, y = 0.000000f},
                               new Kerning {key = 6684789, x = -0.009766f, y = 0.000000f},
                               new Kerning {key = 6684793, x = -0.012207f, y = 0.000000f},
                               new Kerning {key = 6684797, x = 0.048828f, y = 0.000000f},
                               new Kerning {key = 6684845, x = -0.033203f, y = 0.000000f},
                               new Kerning {key = 6684902, x = -0.012207f, y = 0.000000f},
                               new Kerning {key = 6684905, x = -0.009766f, y = 0.000000f},
                               new Kerning {key = 6684910, x = 0.059082f, y = 0.000000f},
                               new Kerning {key = 6684920, x = -0.009766f, y = 0.000000f},
                               new Kerning {key = 6692883, x = -0.033203f, y = 0.000000f},
                               new Kerning {key = 6692884, x = -0.033203f, y = 0.000000f},
                               new Kerning {key = 6692889, x = 0.033203f, y = 0.000000f},
                               new Kerning {key = 6692893, x = 0.033203f, y = 0.000000f},
                               new Kerning {key = 6692902, x = -0.056152f, y = 0.000000f},
                               new Kerning {key = 6750314, x = 0.005859f, y = 0.000000f},
                               new Kerning {key = 6815862, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 6815863, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 6815865, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 6881382, x = 0.001953f, y = 0.000000f},
                               new Kerning {key = 6881385, x = 0.000977f, y = 0.000000f},
                               new Kerning {key = 6881388, x = 0.000977f, y = 0.000000f},
                               new Kerning {key = 6881396, x = 0.001953f, y = 0.000000f},
                               new Kerning {key = 7012397, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 7012453, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 7012463, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 7012525, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 7012600, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 7012691, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 7020563, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 7020564, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 7077990, x = 0.000977f, y = 0.000000f},
                               new Kerning {key = 7077993, x = 0.000977f, y = 0.000000f},
                               new Kerning {key = 7077996, x = 0.002930f, y = 0.000000f},
                               new Kerning {key = 7078004, x = 0.001953f, y = 0.000000f},
                               new Kerning {key = 7078126, x = 0.004883f, y = 0.000000f},
                               new Kerning {key = 7078127, x = 0.004883f, y = 0.000000f},
                               new Kerning {key = 7143542, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 7143543, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 7143545, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 7209078, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 7209079, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 7209081, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 7274540, x = -0.014160f, y = 0.000000f},
                               new Kerning {key = 7274542, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 7274614, x = -0.005859f, y = 0.000000f},
                               new Kerning {key = 7274616, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 7274617, x = -0.005859f, y = 0.000000f},
                               new Kerning {key = 7282726, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 7340076, x = -0.014160f, y = 0.000000f},
                               new Kerning {key = 7340078, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 7340153, x = -0.001953f, y = 0.000000f},
                               new Kerning {key = 7348262, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 7471148, x = -0.134766f, y = 0.000000f},
                               new Kerning {key = 7471149, x = -0.012207f, y = 0.000000f},
                               new Kerning {key = 7471150, x = -0.134766f, y = 0.000000f},
                               new Kerning {key = 7471201, x = -0.017090f, y = 0.000000f},
                               new Kerning {key = 7471203, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 7471204, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 7471205, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 7471207, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 7471215, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 7471217, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 7471277, x = -0.012207f, y = 0.000000f},
                               new Kerning {key = 7471334, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 7471335, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 7471337, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 7471352, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 7471443, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 7479315, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 7479316, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 7479321, x = 0.014160f, y = 0.000000f},
                               new Kerning {key = 7479325, x = 0.014160f, y = 0.000000f},
                               new Kerning {key = 7479334, x = -0.134766f, y = 0.000000f},
                               new Kerning {key = 7602221, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 7602292, x = -0.007813f, y = 0.000000f},
                               new Kerning {key = 7602294, x = -0.009766f, y = 0.000000f},
                               new Kerning {key = 7602297, x = -0.009766f, y = 0.000000f},
                               new Kerning {key = 7602349, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 7610387, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 7610388, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 7610393, x = 0.008789f, y = 0.000000f},
                               new Kerning {key = 7610397, x = 0.008789f, y = 0.000000f},
                               new Kerning {key = 7733292, x = -0.083008f, y = 0.000000f},
                               new Kerning {key = 7733293, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 7733294, x = -0.083008f, y = 0.000000f},
                               new Kerning {key = 7733345, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 7733349, x = -0.007813f, y = 0.000000f},
                               new Kerning {key = 7733359, x = -0.007813f, y = 0.000000f},
                               new Kerning {key = 7733421, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 7733478, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 7733496, x = -0.007813f, y = 0.000000f},
                               new Kerning {key = 7733587, x = -0.005859f, y = 0.000000f},
                               new Kerning {key = 7741459, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 7741460, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 7741465, x = 0.015137f, y = 0.000000f},
                               new Kerning {key = 7741478, x = -0.083008f, y = 0.000000f},
                               new Kerning {key = 7798828, x = -0.033203f, y = 0.000000f},
                               new Kerning {key = 7798829, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 7798830, x = -0.033203f, y = 0.000000f},
                               new Kerning {key = 7798881, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 7798957, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 7799014, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 7806995, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 7806996, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 7807001, x = 0.009766f, y = 0.000000f},
                               new Kerning {key = 7807014, x = -0.033203f, y = 0.000000f},
                               new Kerning {key = 7864365, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 7864419, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 7864420, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 7864421, x = -0.012207f, y = 0.000000f},
                               new Kerning {key = 7864423, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 7864431, x = -0.012207f, y = 0.000000f},
                               new Kerning {key = 7864493, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 7864551, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 7864568, x = -0.012207f, y = 0.000000f},
                               new Kerning {key = 7864659, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 7872531, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 7872532, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 7929900, x = -0.087891f, y = 0.000000f},
                               new Kerning {key = 7929901, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 7929902, x = -0.087891f, y = 0.000000f},
                               new Kerning {key = 7929953, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 7929955, x = -0.007813f, y = 0.000000f},
                               new Kerning {key = 7929956, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 7929957, x = -0.007813f, y = 0.000000f},
                               new Kerning {key = 7929959, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 7929967, x = -0.007813f, y = 0.000000f},
                               new Kerning {key = 7929969, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 7930029, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 7930086, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 7930087, x = -0.007813f, y = 0.000000f},
                               new Kerning {key = 7930104, x = -0.007813f, y = 0.000000f},
                               new Kerning {key = 7930195, x = -0.005859f, y = 0.000000f},
                               new Kerning {key = 7938067, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 7938068, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 7938073, x = 0.015137f, y = 0.000000f},
                               new Kerning {key = 7938086, x = -0.083008f, y = 0.000000f},
                               new Kerning {key = 7995437, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 7995491, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 7995492, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 7995493, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 7995495, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 7995503, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 7995505, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 7995565, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 7995623, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 7995640, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 8003603, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 8003604, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 8061012, x = 0.009766f, y = 0.000000f},
                               new Kerning {key = 8061034, x = 0.023926f, y = 0.000000f},
                               new Kerning {key = 11337793, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 11337801, x = -0.014160f, y = 0.000000f},
                               new Kerning {key = 11337802, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 11337811, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 11337812, x = -0.069824f, y = 0.000000f},
                               new Kerning {key = 11337814, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 11337815, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 11337816, x = -0.037109f, y = 0.000000f},
                               new Kerning {key = 11337817, x = -0.063965f, y = 0.000000f},
                               new Kerning {key = 11337818, x = -0.014160f, y = 0.000000f},
                               new Kerning {key = 11337825, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 11337846, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 11337847, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 11337848, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 11337849, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 11337850, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 11337926, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 11337958, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 12517450, x = 0.015137f, y = 0.000000f},
                               new Kerning {key = 13041709, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 13041837, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 13042002, x = -0.012207f, y = 0.000000f},
                               new Kerning {key = 13049875, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 13049876, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 14155820, x = -0.014160f, y = 0.000000f},
                               new Kerning {key = 14155822, x = -0.014160f, y = 0.000000f},
                               new Kerning {key = 14155860, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 14155864, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 14155865, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 14155866, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 14164006, x = -0.014160f, y = 0.000000f},
                               new Kerning {key = 15138861, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 15138989, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 15147027, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 15147028, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 15540249, x = 0.009766f, y = 0.000000f},
                               new Kerning {key = 15597676, x = 0.004883f, y = 0.000000f},
                               new Kerning {key = 15663206, x = 0.006836f, y = 0.000000f},
                               new Kerning {key = 15663212, x = 0.004883f, y = 0.000000f},
                               new Kerning {key = 16252972, x = -0.014160f, y = 0.000000f},
                               new Kerning {key = 16252974, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 16253046, x = -0.005859f, y = 0.000000f},
                               new Kerning {key = 16253048, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 16253049, x = -0.005859f, y = 0.000000f},
                               new Kerning {key = 16261158, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 538116161, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 538116169, x = -0.014160f, y = 0.000000f},
                               new Kerning {key = 538116170, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 538116179, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 538116180, x = -0.069824f, y = 0.000000f},
                               new Kerning {key = 538116182, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 538116183, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 538116184, x = -0.037109f, y = 0.000000f},
                               new Kerning {key = 538116185, x = -0.063965f, y = 0.000000f},
                               new Kerning {key = 538116186, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 538116193, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 538116214, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 538116215, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 538116216, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 538116217, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 538116218, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 538116294, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 538116326, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 538181697, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 538181705, x = -0.014160f, y = 0.000000f},
                               new Kerning {key = 538181706, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 538181715, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 538181716, x = -0.069824f, y = 0.000000f},
                               new Kerning {key = 538181718, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 538181719, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 538181720, x = -0.037109f, y = 0.000000f},
                               new Kerning {key = 538181721, x = -0.063965f, y = 0.000000f},
                               new Kerning {key = 538181722, x = -0.004883f, y = 0.000000f},
                               new Kerning {key = 538181729, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 538181750, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 538181751, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 538181752, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 538181753, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 538181754, x = -0.019043f, y = 0.000000f},
                               new Kerning {key = 538181830, x = -0.022949f, y = 0.000000f},
                               new Kerning {key = 538181862, x = -0.008789f, y = 0.000000f},
                               new Kerning {key = 538443841, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 538443974, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 538451996, x = 0.020020f, y = 0.000000f},
                               new Kerning {key = 538509356, x = -0.098145f, y = 0.000000f},
                               new Kerning {key = 538509358, x = -0.098145f, y = 0.000000f},
                               new Kerning {key = 538509362, x = 0.009766f, y = 0.000000f},
                               new Kerning {key = 538509363, x = 0.009766f, y = 0.000000f},
                               new Kerning {key = 538509364, x = -0.034180f, y = 0.000000f},
                               new Kerning {key = 538509365, x = 0.004883f, y = 0.000000f},
                               new Kerning {key = 538509367, x = 0.020020f, y = 0.000000f},
                               new Kerning {key = 538509368, x = 0.009766f, y = 0.000000f},
                               new Kerning {key = 538509369, x = 0.009766f, y = 0.000000f},
                               new Kerning {key = 538509377, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 538509395, x = 0.009766f, y = 0.000000f},
                               new Kerning {key = 538509396, x = 0.050781f, y = 0.000000f},
                               new Kerning {key = 538509398, x = 0.045898f, y = 0.000000f},
                               new Kerning {key = 538509399, x = 0.026855f, y = 0.000000f},
                               new Kerning {key = 538509401, x = 0.050781f, y = 0.000000f},
                               new Kerning {key = 538509416, x = 0.020020f, y = 0.000000f},
                               new Kerning {key = 538509417, x = 0.020020f, y = 0.000000f},
                               new Kerning {key = 538509420, x = 0.020020f, y = 0.000000f},
                               new Kerning {key = 538509427, x = -0.033203f, y = 0.000000f},
                               new Kerning {key = 538509428, x = 0.019043f, y = 0.000000f},
                               new Kerning {key = 538509510, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 538509548, x = 0.039063f, y = 0.000000f},
                               new Kerning {key = 538509550, x = 0.078125f, y = 0.000000f},
                               new Kerning {key = 538509551, x = 0.078125f, y = 0.000000f},
                               new Kerning {key = 538517528, x = 0.087891f, y = 0.000000f},
                               new Kerning {key = 538517532, x = 0.087891f, y = 0.000000f},
                               new Kerning {key = 538517533, x = 0.020020f, y = 0.000000f},
                               new Kerning {key = 538517542, x = -0.098145f, y = 0.000000f},
                               new Kerning {key = 538574932, x = -0.098145f, y = 0.000000f},
                               new Kerning {key = 538574934, x = -0.098145f, y = 0.000000f},
                               new Kerning {key = 538574935, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 538574937, x = -0.098145f, y = 0.000000f},
                               new Kerning {key = 538705985, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 538706118, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 538714136, x = 0.020020f, y = 0.000000f},
                               new Kerning {key = 538771500, x = -0.098145f, y = 0.000000f},
                               new Kerning {key = 538771502, x = -0.098145f, y = 0.000000f},
                               new Kerning {key = 538771521, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 538771540, x = 0.050781f, y = 0.000000f},
                               new Kerning {key = 538771542, x = 0.045898f, y = 0.000000f},
                               new Kerning {key = 538771543, x = 0.026855f, y = 0.000000f},
                               new Kerning {key = 538771545, x = 0.050781f, y = 0.000000f},
                               new Kerning {key = 538771571, x = -0.033203f, y = 0.000000f},
                               new Kerning {key = 538771572, x = 0.019043f, y = 0.000000f},
                               new Kerning {key = 538771654, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 538779673, x = 0.020020f, y = 0.000000f},
                               new Kerning {key = 538779686, x = -0.098145f, y = 0.000000f},
                               new Kerning {key = 538837076, x = -0.098145f, y = 0.000000f},
                               new Kerning {key = 538837078, x = -0.098145f, y = 0.000000f},
                               new Kerning {key = 538837079, x = -0.045898f, y = 0.000000f},
                               new Kerning {key = 538837081, x = -0.098145f, y = 0.000000f},
                               new Kerning {key = 539369497, x = -0.098145f, y = 0.000000f},
                               new Kerning {key = 539369501, x = -0.098145f, y = 0.000000f},
                           };
            }
        }

// public uint KerningsCount = 716;

        #endregion

    };
}



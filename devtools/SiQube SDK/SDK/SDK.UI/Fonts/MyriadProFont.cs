using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Fonts
{
    public class MyriadProFont : IFontInfo
    {
        #region glyphs_description

        private static readonly byte[] MyriadProGlyph33Commands =
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph33Coordinates =
            {
                0.065000f, 0.225000f, 0.054000f, 0.609000f,
                0.131000f, 0.609000f, 0.119000f, 0.225000f,
                0.065000f, 0.225000f, 0.045000f, 0.111000f,
                0.045000f, 0.161000f, 0.093000f, 0.161000f,
                0.139000f, 0.161000f, 0.139000f, 0.111000f,
                0.139000f, 0.061000f, 0.091000f, 0.061000f,
                0.045000f, 0.061000f, 0.045000f, 0.111000f
            };

        private static readonly byte[] MyriadProGlyph34Commands =
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

        private static readonly float[] MyriadProGlyph34Coordinates =
            {
                0.111000f, 0.624000f, 0.097000f, 0.432000f,
                0.054000f, 0.432000f, 0.041000f, 0.624000f,
                0.111000f, 0.624000f, 0.230000f, 0.624000f,
                0.216000f, 0.432000f, 0.174000f, 0.432000f,
                0.160000f, 0.624000f, 0.230000f, 0.624000f
            };

        private static readonly byte[] MyriadProGlyph35Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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

        private static readonly float[] MyriadProGlyph35Coordinates =
            {
                0.234000f, 0.274000f, 0.249000f, 0.390000f,
                0.166000f, 0.390000f, 0.151000f, 0.274000f,
                0.234000f, 0.274000f, 0.076000f, 0.070000f,
                0.096000f, 0.227000f, 0.030000f, 0.227000f,
                0.030000f, 0.274000f, 0.104000f, 0.274000f,
                0.119000f, 0.390000f, 0.049000f, 0.390000f,
                0.049000f, 0.437000f, 0.125000f, 0.437000f,
                0.146000f, 0.590000f, 0.193000f, 0.590000f,
                0.172000f, 0.437000f, 0.256000f, 0.437000f,
                0.276000f, 0.590000f, 0.324000f, 0.590000f,
                0.304000f, 0.437000f, 0.369000f, 0.437000f,
                0.369000f, 0.390000f, 0.296000f, 0.390000f,
                0.282000f, 0.274000f, 0.351000f, 0.274000f,
                0.351000f, 0.227000f, 0.275000f, 0.227000f,
                0.254000f, 0.070000f, 0.206000f, 0.070000f,
                0.227000f, 0.227000f, 0.144000f, 0.227000f,
                0.124000f, 0.070000f, 0.076000f, 0.070000f
            };

        private static readonly byte[] MyriadProGlyph36Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
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

        private static readonly float[] MyriadProGlyph36Coordinates =
            {
                0.175000f, 0.002000f, 0.175000f, 0.082000f,
                0.100000f, 0.083000f, 0.053000f, 0.117000f,
                0.072000f, 0.171000f, 0.095000f, 0.156000f,
                0.123000f, 0.147000f, 0.155000f, 0.137000f,
                0.187000f, 0.137000f, 0.282000f, 0.137000f,
                0.282000f, 0.215000f, 0.282000f, 0.274000f,
                0.191000f, 0.310000f, 0.125000f, 0.336000f,
                0.095000f, 0.366000f, 0.059000f, 0.400000f,
                0.059000f, 0.449000f, 0.059000f, 0.558000f,
                0.179000f, 0.578000f, 0.179000f, 0.658000f,
                0.230000f, 0.658000f, 0.230000f, 0.581000f,
                0.262000f, 0.579000f, 0.291000f, 0.571000f,
                0.313000f, 0.564000f, 0.334000f, 0.553000f,
                0.314000f, 0.500000f, 0.298000f, 0.508000f,
                0.287000f, 0.514000f, 0.276000f, 0.517000f,
                0.246000f, 0.528000f, 0.213000f, 0.528000f,
                0.170000f, 0.528000f, 0.148000f, 0.505000f,
                0.128000f, 0.486000f, 0.128000f, 0.458000f,
                0.128000f, 0.409000f, 0.227000f, 0.367000f,
                0.351000f, 0.316000f, 0.351000f, 0.221000f,
                0.351000f, 0.171000f, 0.319000f, 0.134000f,
                0.285000f, 0.095000f, 0.225000f, 0.085000f,
                0.225000f, 0.002000f, 0.175000f, 0.002000f
            };

        private static readonly byte[] MyriadProGlyph37Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph37Coordinates =
            {
                0.270000f, 0.445000f, 0.270000f, 0.366000f,
                0.233000f, 0.322000f, 0.199000f, 0.281000f,
                0.146000f, 0.281000f, 0.094000f, 0.281000f,
                0.061000f, 0.320000f, 0.025000f, 0.362000f,
                0.024000f, 0.437000f, 0.024000f, 0.512000f,
                0.061000f, 0.557000f, 0.096000f, 0.599000f,
                0.150000f, 0.599000f, 0.270000f, 0.599000f,
                0.270000f, 0.445000f, 0.097000f, 0.523000f,
                0.079000f, 0.490000f, 0.079000f, 0.440000f,
                0.078000f, 0.389000f, 0.096000f, 0.357000f,
                0.115000f, 0.323000f, 0.147000f, 0.323000f,
                0.214000f, 0.323000f, 0.214000f, 0.441000f,
                0.214000f, 0.493000f, 0.199000f, 0.523000f,
                0.182000f, 0.557000f, 0.146000f, 0.557000f,
                0.115000f, 0.557000f, 0.097000f, 0.523000f,
                0.140000f, 0.061000f, 0.446000f, 0.600000f,
                0.491000f, 0.600000f, 0.185000f, 0.061000f,
                0.140000f, 0.061000f, 0.609000f, 0.229000f,
                0.609000f, 0.150000f, 0.572000f, 0.106000f,
                0.538000f, 0.065000f, 0.485000f, 0.065000f,
                0.433000f, 0.065000f, 0.400000f, 0.104000f,
                0.364000f, 0.146000f, 0.363000f, 0.221000f,
                0.363000f, 0.297000f, 0.400000f, 0.342000f,
                0.435000f, 0.384000f, 0.490000f, 0.384000f,
                0.609000f, 0.384000f, 0.609000f, 0.229000f,
                0.436000f, 0.307000f, 0.418000f, 0.275000f,
                0.418000f, 0.224000f, 0.417000f, 0.173000f,
                0.435000f, 0.141000f, 0.454000f, 0.107000f,
                0.486000f, 0.107000f, 0.554000f, 0.107000f,
                0.554000f, 0.225000f, 0.554000f, 0.277000f,
                0.538000f, 0.307000f, 0.521000f, 0.341000f,
                0.486000f, 0.341000f, 0.454000f, 0.341000f,
                0.436000f, 0.307000f
            };

        private static readonly byte[] MyriadProGlyph38Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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

        private static readonly float[] MyriadProGlyph38Coordinates =
            {
                0.399000f, 0.070000f, 0.394000f, 0.075000f,
                0.387000f, 0.082000f, 0.348000f, 0.122000f,
                0.282000f, 0.061000f, 0.191000f, 0.061000f,
                0.115000f, 0.061000f, 0.069000f, 0.107000f,
                0.025000f, 0.149000f, 0.025000f, 0.213000f,
                0.025000f, 0.265000f, 0.055000f, 0.306000f,
                0.081000f, 0.343000f, 0.131000f, 0.370000f,
                0.131000f, 0.373000f, 0.086000f, 0.429000f,
                0.086000f, 0.485000f, 0.086000f, 0.539000f,
                0.121000f, 0.577000f, 0.159000f, 0.619000f,
                0.223000f, 0.619000f, 0.274000f, 0.619000f,
                0.307000f, 0.588000f, 0.342000f, 0.556000f,
                0.342000f, 0.505000f, 0.342000f, 0.419000f,
                0.223000f, 0.361000f, 0.223000f, 0.357000f,
                0.299000f, 0.270000f, 0.355000f, 0.208000f,
                0.391000f, 0.263000f, 0.407000f, 0.365000f,
                0.471000f, 0.365000f, 0.448000f, 0.231000f,
                0.393000f, 0.166000f, 0.482000f, 0.070000f,
                0.399000f, 0.070000f, 0.314000f, 0.163000f,
                0.248000f, 0.235000f, 0.162000f, 0.333000f,
                0.132000f, 0.314000f, 0.116000f, 0.293000f,
                0.092000f, 0.261000f, 0.092000f, 0.223000f,
                0.092000f, 0.176000f, 0.123000f, 0.146000f,
                0.155000f, 0.114000f, 0.203000f, 0.114000f,
                0.269000f, 0.114000f, 0.314000f, 0.163000f,
                0.167000f, 0.547000f, 0.150000f, 0.526000f,
                0.150000f, 0.493000f, 0.150000f, 0.466000f,
                0.162000f, 0.440000f, 0.171000f, 0.420000f,
                0.191000f, 0.395000f, 0.236000f, 0.421000f,
                0.256000f, 0.443000f, 0.280000f, 0.469000f,
                0.280000f, 0.501000f, 0.280000f, 0.529000f,
                0.265000f, 0.549000f, 0.248000f, 0.571000f,
                0.217000f, 0.571000f, 0.185000f, 0.571000f,
                0.167000f, 0.547000f
            };

        private static readonly byte[] MyriadProGlyph39Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph39Coordinates =
            {
                0.111000f, 0.624000f, 0.097000f, 0.432000f,
                0.054000f, 0.432000f, 0.041000f, 0.624000f,
                0.111000f, 0.624000f
            };

        private static readonly byte[] MyriadProGlyph40Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph40Coordinates =
            {
                0.210000f, 0.625000f, 0.163000f, 0.561000f,
                0.138000f, 0.486000f, 0.110000f, 0.401000f,
                0.110000f, 0.297000f, 0.110000f, 0.198000f,
                0.139000f, 0.112000f, 0.152000f, 0.074000f,
                0.171000f, 0.038000f, 0.188000f, 0.005000f,
                0.210000f, -0.027000f, 0.156000f, -0.027000f,
                0.135000f, 0.001000f, 0.118000f, 0.030000f,
                0.098000f, 0.065000f, 0.085000f, 0.102000f,
                0.069000f, 0.145000f, 0.060000f, 0.191000f,
                0.051000f, 0.242000f, 0.051000f, 0.298000f,
                0.051000f, 0.354000f, 0.061000f, 0.406000f,
                0.069000f, 0.453000f, 0.085000f, 0.495000f,
                0.099000f, 0.533000f, 0.118000f, 0.568000f,
                0.135000f, 0.597000f, 0.156000f, 0.625000f,
                0.210000f, 0.625000f
            };

        private static readonly byte[] MyriadProGlyph41Commands =
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph41Coordinates =
            {
                0.016000f, -0.027000f, 0.062000f, 0.039000f,
                0.087000f, 0.112000f, 0.116000f, 0.199000f,
                0.116000f, 0.300000f, 0.116000f, 0.401000f,
                0.087000f, 0.487000f, 0.063000f, 0.559000f,
                0.016000f, 0.625000f, 0.070000f, 0.625000f,
                0.091000f, 0.598000f, 0.108000f, 0.569000f,
                0.128000f, 0.534000f, 0.142000f, 0.497000f,
                0.158000f, 0.454000f, 0.166000f, 0.408000f,
                0.175000f, 0.356000f, 0.175000f, 0.300000f,
                0.175000f, 0.244000f, 0.166000f, 0.192000f,
                0.157000f, 0.146000f, 0.141000f, 0.103000f,
                0.128000f, 0.065000f, 0.108000f, 0.031000f,
                0.091000f, 0.001000f, 0.070000f, -0.027000f,
                0.016000f, -0.027000f
            };

        private static readonly byte[] MyriadProGlyph42Commands =
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

        private static readonly float[] MyriadProGlyph42Coordinates =
            {
                0.263000f, 0.591000f, 0.187000f, 0.491000f,
                0.187000f, 0.489000f, 0.308000f, 0.505000f,
                0.308000f, 0.451000f, 0.187000f, 0.466000f,
                0.187000f, 0.464000f, 0.264000f, 0.368000f,
                0.214000f, 0.339000f, 0.165000f, 0.451000f,
                0.163000f, 0.451000f, 0.112000f, 0.338000f,
                0.066000f, 0.367000f, 0.142000f, 0.465000f,
                0.142000f, 0.467000f, 0.024000f, 0.451000f,
                0.024000f, 0.505000f, 0.142000f, 0.490000f,
                0.142000f, 0.492000f, 0.066000f, 0.590000f,
                0.115000f, 0.618000f, 0.165000f, 0.506000f,
                0.166000f, 0.506000f, 0.215000f, 0.619000f,
                0.263000f, 0.591000f
            };

        private static readonly byte[] MyriadProGlyph43Commands =
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

        private static readonly float[] MyriadProGlyph43Coordinates =
            {
                0.264000f, 0.496000f, 0.264000f, 0.308000f,
                0.445000f, 0.308000f, 0.445000f, 0.260000f,
                0.264000f, 0.260000f, 0.264000f, 0.070000f,
                0.213000f, 0.070000f, 0.213000f, 0.260000f,
                0.032000f, 0.260000f, 0.032000f, 0.308000f,
                0.213000f, 0.308000f, 0.213000f, 0.496000f,
                0.264000f, 0.496000f
            };

        private static readonly byte[] MyriadProGlyph44Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph44Coordinates =
            {
                0.013000f, -0.029000f, 0.045000f, 0.059000f,
                0.061000f, 0.163000f, 0.139000f, 0.171000f,
                0.104000f, 0.047000f, 0.063000f, -0.023000f,
                0.013000f, -0.029000f
            };

        private static readonly byte[] MyriadProGlyph45Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph45Coordinates =
            {
                0.222000f, 0.312000f, 0.222000f, 0.261000f,
                0.024000f, 0.261000f, 0.024000f, 0.312000f,
                0.222000f, 0.312000f
            };

        private static readonly byte[] MyriadProGlyph46Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph46Coordinates =
            {
                0.042000f, 0.112000f, 0.042000f, 0.162000f,
                0.090000f, 0.162000f, 0.137000f, 0.162000f,
                0.137000f, 0.112000f, 0.137000f, 0.061000f,
                0.088000f, 0.061000f, 0.042000f, 0.061000f,
                0.042000f, 0.112000f
            };

        private static readonly byte[] MyriadProGlyph47Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph47Coordinates =
            {
                -0.001000f, 0.039000f, 0.221000f, 0.619000f,
                0.277000f, 0.619000f, 0.053000f, 0.039000f,
                -0.001000f, 0.039000f
            };

        private static readonly byte[] MyriadProGlyph48Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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

        private static readonly float[] MyriadProGlyph48Coordinates =
            {
                0.337000f, 0.530000f, 0.383000f, 0.460000f,
                0.383000f, 0.336000f, 0.383000f, 0.061000f,
                0.202000f, 0.061000f, 0.124000f, 0.061000f,
                0.078000f, 0.131000f, 0.030000f, 0.202000f,
                0.029000f, 0.329000f, 0.029000f, 0.457000f,
                0.080000f, 0.530000f, 0.129000f, 0.599000f,
                0.211000f, 0.599000f, 0.292000f, 0.599000f,
                0.337000f, 0.530000f, 0.100000f, 0.328000f,
                0.100000f, 0.116000f, 0.206000f, 0.116000f,
                0.258000f, 0.116000f, 0.285000f, 0.174000f,
                0.311000f, 0.230000f, 0.311000f, 0.333000f,
                0.311000f, 0.432000f, 0.286000f, 0.487000f,
                0.259000f, 0.545000f, 0.206000f, 0.545000f,
                0.100000f, 0.545000f, 0.100000f, 0.328000f
            };

        private static readonly byte[] MyriadProGlyph49Commands =
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

        private static readonly float[] MyriadProGlyph49Coordinates =
            {
                0.189000f, 0.525000f, 0.187000f, 0.525000f,
                0.097000f, 0.476000f, 0.083000f, 0.529000f,
                0.197000f, 0.590000f, 0.257000f, 0.590000f,
                0.257000f, 0.070000f, 0.189000f, 0.070000f,
                0.189000f, 0.525000f
            };

        private static readonly byte[] MyriadProGlyph50Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph50Coordinates =
            {
                0.036000f, 0.070000f, 0.036000f, 0.113000f,
                0.091000f, 0.167000f, 0.146000f, 0.219000f,
                0.177000f, 0.252000f, 0.216000f, 0.291000f,
                0.238000f, 0.321000f, 0.285000f, 0.384000f,
                0.285000f, 0.439000f, 0.285000f, 0.483000f,
                0.263000f, 0.510000f, 0.236000f, 0.541000f,
                0.182000f, 0.541000f, 0.150000f, 0.541000f,
                0.119000f, 0.526000f, 0.094000f, 0.515000f,
                0.072000f, 0.497000f, 0.050000f, 0.546000f,
                0.078000f, 0.570000f, 0.114000f, 0.584000f,
                0.154000f, 0.599000f, 0.196000f, 0.599000f,
                0.274000f, 0.599000f, 0.318000f, 0.551000f,
                0.355000f, 0.510000f, 0.355000f, 0.448000f,
                0.355000f, 0.381000f, 0.307000f, 0.312000f,
                0.285000f, 0.281000f, 0.250000f, 0.243000f,
                0.222000f, 0.213000f, 0.176000f, 0.169000f,
                0.135000f, 0.130000f, 0.135000f, 0.129000f,
                0.368000f, 0.129000f, 0.368000f, 0.070000f,
                0.036000f, 0.070000f
            };

        private static readonly byte[] MyriadProGlyph51Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph51Coordinates =
            {
                0.053000f, 0.150000f, 0.073000f, 0.138000f,
                0.100000f, 0.130000f, 0.135000f, 0.118000f,
                0.168000f, 0.118000f, 0.230000f, 0.118000f,
                0.261000f, 0.152000f, 0.287000f, 0.180000f,
                0.286000f, 0.219000f, 0.285000f, 0.270000f,
                0.244000f, 0.298000f, 0.207000f, 0.323000f,
                0.152000f, 0.323000f, 0.112000f, 0.323000f,
                0.112000f, 0.376000f, 0.152000f, 0.376000f,
                0.196000f, 0.376000f, 0.229000f, 0.397000f,
                0.268000f, 0.421000f, 0.268000f, 0.464000f,
                0.268000f, 0.498000f, 0.246000f, 0.519000f,
                0.222000f, 0.542000f, 0.176000f, 0.542000f,
                0.148000f, 0.542000f, 0.117000f, 0.531000f,
                0.092000f, 0.522000f, 0.072000f, 0.508000f,
                0.053000f, 0.559000f, 0.076000f, 0.575000f,
                0.111000f, 0.587000f, 0.151000f, 0.599000f,
                0.190000f, 0.599000f, 0.262000f, 0.599000f,
                0.303000f, 0.561000f, 0.339000f, 0.527000f,
                0.339000f, 0.475000f, 0.339000f, 0.387000f,
                0.243000f, 0.352000f, 0.243000f, 0.350000f,
                0.293000f, 0.341000f, 0.325000f, 0.307000f,
                0.358000f, 0.270000f, 0.359000f, 0.217000f,
                0.359000f, 0.152000f, 0.311000f, 0.108000f,
                0.258000f, 0.061000f, 0.169000f, 0.061000f,
                0.129000f, 0.061000f, 0.089000f, 0.073000f,
                0.056000f, 0.082000f, 0.034000f, 0.097000f,
                0.053000f, 0.150000f
            };

        private static readonly byte[] MyriadProGlyph52Commands =
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph52Coordinates =
            {
                0.254000f, 0.070000f, 0.254000f, 0.213000f,
                0.012000f, 0.213000f, 0.012000f, 0.258000f,
                0.244000f, 0.590000f, 0.320000f, 0.590000f,
                0.320000f, 0.267000f, 0.393000f, 0.267000f,
                0.393000f, 0.213000f, 0.320000f, 0.213000f,
                0.320000f, 0.070000f, 0.254000f, 0.070000f,
                0.254000f, 0.267000f, 0.254000f, 0.441000f,
                0.254000f, 0.481000f, 0.256000f, 0.522000f,
                0.254000f, 0.522000f, 0.233000f, 0.483000f,
                0.210000f, 0.445000f, 0.083000f, 0.269000f,
                0.083000f, 0.267000f, 0.254000f, 0.267000f
            };

        private static readonly byte[] MyriadProGlyph53Commands =
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph53Coordinates =
            {
                0.347000f, 0.531000f, 0.148000f, 0.531000f,
                0.128000f, 0.397000f, 0.146000f, 0.400000f,
                0.171000f, 0.400000f, 0.238000f, 0.400000f,
                0.283000f, 0.372000f, 0.316000f, 0.354000f,
                0.335000f, 0.321000f, 0.357000f, 0.285000f,
                0.357000f, 0.239000f, 0.357000f, 0.162000f,
                0.303000f, 0.112000f, 0.248000f, 0.061000f,
                0.164000f, 0.061000f, 0.124000f, 0.061000f,
                0.087000f, 0.071000f, 0.055000f, 0.080000f,
                0.034000f, 0.093000f, 0.052000f, 0.147000f,
                0.071000f, 0.136000f, 0.098000f, 0.128000f,
                0.131000f, 0.118000f, 0.164000f, 0.118000f,
                0.215000f, 0.118000f, 0.250000f, 0.149000f,
                0.287000f, 0.180000f, 0.286000f, 0.231000f,
                0.286000f, 0.345000f, 0.137000f, 0.345000f,
                0.117000f, 0.345000f, 0.097000f, 0.344000f,
                0.082000f, 0.343000f, 0.064000f, 0.341000f,
                0.098000f, 0.590000f, 0.347000f, 0.590000f,
                0.347000f, 0.531000f
            };

        private static readonly byte[] MyriadProGlyph54Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph54Coordinates =
            {
                0.333000f, 0.541000f, 0.312000f, 0.542000f,
                0.280000f, 0.537000f, 0.201000f, 0.524000f,
                0.152000f, 0.470000f, 0.109000f, 0.422000f,
                0.099000f, 0.353000f, 0.101000f, 0.353000f,
                0.121000f, 0.380000f, 0.152000f, 0.396000f,
                0.186000f, 0.413000f, 0.227000f, 0.413000f,
                0.296000f, 0.413000f, 0.340000f, 0.367000f,
                0.384000f, 0.321000f, 0.384000f, 0.245000f,
                0.384000f, 0.170000f, 0.338000f, 0.117000f,
                0.289000f, 0.061000f, 0.210000f, 0.061000f,
                0.127000f, 0.061000f, 0.077000f, 0.122000f,
                0.027000f, 0.182000f, 0.027000f, 0.283000f,
                0.027000f, 0.357000f, 0.052000f, 0.419000f,
                0.074000f, 0.477000f, 0.115000f, 0.517000f,
                0.181000f, 0.582000f, 0.281000f, 0.594000f,
                0.307000f, 0.598000f, 0.333000f, 0.598000f,
                0.333000f, 0.541000f, 0.285000f, 0.150000f,
                0.313000f, 0.185000f, 0.313000f, 0.241000f,
                0.313000f, 0.360000f, 0.205000f, 0.360000f,
                0.136000f, 0.360000f, 0.104000f, 0.296000f,
                0.097000f, 0.281000f, 0.097000f, 0.265000f,
                0.097000f, 0.199000f, 0.127000f, 0.159000f,
                0.158000f, 0.116000f, 0.212000f, 0.116000f,
                0.257000f, 0.116000f, 0.285000f, 0.150000f
            };

        private static readonly byte[] MyriadProGlyph55Commands =
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

        private static readonly float[] MyriadProGlyph55Coordinates =
            {
                0.374000f, 0.590000f, 0.374000f, 0.544000f,
                0.148000f, 0.070000f, 0.075000f, 0.070000f,
                0.300000f, 0.530000f, 0.300000f, 0.532000f,
                0.046000f, 0.532000f, 0.046000f, 0.590000f,
                0.374000f, 0.590000f
            };

        private static readonly byte[] MyriadProGlyph56Commands =
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

        private static readonly float[] MyriadProGlyph56Coordinates =
            {
                0.132000f, 0.344000f, 0.049000f, 0.383000f,
                0.049000f, 0.461000f, 0.049000f, 0.522000f,
                0.096000f, 0.561000f, 0.141000f, 0.599000f,
                0.211000f, 0.599000f, 0.283000f, 0.599000f,
                0.325000f, 0.560000f, 0.363000f, 0.524000f,
                0.363000f, 0.471000f, 0.363000f, 0.435000f,
                0.344000f, 0.405000f, 0.321000f, 0.370000f,
                0.276000f, 0.349000f, 0.276000f, 0.347000f,
                0.381000f, 0.306000f, 0.381000f, 0.213000f,
                0.381000f, 0.145000f, 0.330000f, 0.103000f,
                0.280000f, 0.061000f, 0.204000f, 0.061000f,
                0.125000f, 0.061000f, 0.076000f, 0.103000f,
                0.030000f, 0.142000f, 0.030000f, 0.201000f,
                0.030000f, 0.298000f, 0.133000f, 0.341000f,
                0.132000f, 0.344000f, 0.310000f, 0.205000f,
                0.310000f, 0.250000f, 0.279000f, 0.278000f,
                0.252000f, 0.303000f, 0.196000f, 0.319000f,
                0.102000f, 0.292000f, 0.102000f, 0.211000f,
                0.100000f, 0.171000f, 0.128000f, 0.142000f,
                0.158000f, 0.113000f, 0.206000f, 0.113000f,
                0.310000f, 0.113000f, 0.310000f, 0.205000f,
                0.140000f, 0.524000f, 0.116000f, 0.501000f,
                0.116000f, 0.465000f, 0.115000f, 0.396000f,
                0.216000f, 0.369000f, 0.295000f, 0.396000f,
                0.295000f, 0.464000f, 0.295000f, 0.499000f,
                0.275000f, 0.522000f, 0.251000f, 0.549000f,
                0.207000f, 0.549000f, 0.165000f, 0.549000f,
                0.140000f, 0.524000f
            };

        private static readonly byte[] MyriadProGlyph57Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph57Coordinates =
            {
                0.077000f, 0.120000f, 0.093000f, 0.118000f,
                0.134000f, 0.122000f, 0.200000f, 0.131000f,
                0.243000f, 0.173000f, 0.298000f, 0.222000f,
                0.311000f, 0.310000f, 0.309000f, 0.310000f,
                0.264000f, 0.255000f, 0.186000f, 0.255000f,
                0.118000f, 0.255000f, 0.075000f, 0.301000f,
                0.033000f, 0.346000f, 0.033000f, 0.414000f,
                0.033000f, 0.490000f, 0.082000f, 0.544000f,
                0.133000f, 0.599000f, 0.211000f, 0.599000f,
                0.290000f, 0.599000f, 0.337000f, 0.539000f,
                0.383000f, 0.480000f, 0.383000f, 0.379000f,
                0.383000f, 0.298000f, 0.357000f, 0.233000f,
                0.334000f, 0.176000f, 0.293000f, 0.136000f,
                0.233000f, 0.077000f, 0.142000f, 0.066000f,
                0.107000f, 0.061000f, 0.077000f, 0.062000f,
                0.077000f, 0.120000f, 0.131000f, 0.510000f,
                0.103000f, 0.474000f, 0.103000f, 0.418000f,
                0.103000f, 0.308000f, 0.203000f, 0.308000f,
                0.273000f, 0.308000f, 0.305000f, 0.362000f,
                0.311000f, 0.374000f, 0.311000f, 0.389000f,
                0.311000f, 0.459000f, 0.286000f, 0.500000f,
                0.258000f, 0.545000f, 0.204000f, 0.545000f,
                0.160000f, 0.545000f, 0.131000f, 0.510000f
            };

        private static readonly byte[] MyriadProGlyph58Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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

        private static readonly float[] MyriadProGlyph58Coordinates =
            {
                0.042000f, 0.393000f, 0.042000f, 0.444000f,
                0.089000f, 0.444000f, 0.136000f, 0.444000f,
                0.136000f, 0.393000f, 0.136000f, 0.344000f,
                0.088000f, 0.344000f, 0.042000f, 0.344000f,
                0.042000f, 0.393000f, 0.042000f, 0.111000f,
                0.042000f, 0.161000f, 0.089000f, 0.161000f,
                0.136000f, 0.161000f, 0.136000f, 0.111000f,
                0.136000f, 0.061000f, 0.088000f, 0.061000f,
                0.042000f, 0.061000f, 0.042000f, 0.111000f
            };

        private static readonly byte[] MyriadProGlyph59Commands =
            {
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph59Coordinates =
            {
                0.014000f, -0.028000f, 0.047000f, 0.061000f,
                0.062000f, 0.164000f, 0.140000f, 0.172000f,
                0.105000f, 0.049000f, 0.063000f, -0.023000f,
                0.014000f, -0.028000f, 0.048000f, 0.393000f,
                0.048000f, 0.444000f, 0.096000f, 0.444000f,
                0.143000f, 0.444000f, 0.143000f, 0.393000f,
                0.143000f, 0.344000f, 0.095000f, 0.344000f,
                0.048000f, 0.344000f, 0.048000f, 0.393000f
            };

        private static readonly byte[] MyriadProGlyph60Commands =
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

        private static readonly float[] MyriadProGlyph60Coordinates =
            {
                0.053000f, 0.305000f, 0.424000f, 0.496000f,
                0.424000f, 0.441000f, 0.111000f, 0.284000f,
                0.111000f, 0.282000f, 0.424000f, 0.125000f,
                0.424000f, 0.070000f, 0.053000f, 0.261000f,
                0.053000f, 0.305000f
            };

        private static readonly byte[] MyriadProGlyph61Commands =
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

        private static readonly float[] MyriadProGlyph61Coordinates =
            {
                0.032000f, 0.340000f, 0.032000f, 0.388000f,
                0.445000f, 0.388000f, 0.445000f, 0.340000f,
                0.032000f, 0.340000f, 0.032000f, 0.183000f,
                0.032000f, 0.231000f, 0.445000f, 0.231000f,
                0.445000f, 0.183000f, 0.032000f, 0.183000f
            };

        private static readonly byte[] MyriadProGlyph62Commands =
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

        private static readonly float[] MyriadProGlyph62Coordinates =
            {
                0.424000f, 0.261000f, 0.053000f, 0.070000f,
                0.053000f, 0.125000f, 0.368000f, 0.282000f,
                0.368000f, 0.284000f, 0.053000f, 0.441000f,
                0.053000f, 0.496000f, 0.424000f, 0.306000f,
                0.424000f, 0.261000f
            };

        private static readonly byte[] MyriadProGlyph63Commands =
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph63Coordinates =
            {
                0.113000f, 0.224000f, 0.111000f, 0.245000f,
                0.104000f, 0.314000f, 0.161000f, 0.383000f,
                0.217000f, 0.449000f, 0.217000f, 0.493000f,
                0.217000f, 0.560000f, 0.141000f, 0.561000f,
                0.093000f, 0.561000f, 0.060000f, 0.537000f,
                0.041000f, 0.587000f, 0.086000f, 0.619000f,
                0.155000f, 0.619000f, 0.221000f, 0.619000f,
                0.257000f, 0.583000f, 0.289000f, 0.551000f,
                0.289000f, 0.501000f, 0.289000f, 0.464000f,
                0.269000f, 0.429000f, 0.261000f, 0.413000f,
                0.247000f, 0.396000f, 0.237000f, 0.383000f,
                0.220000f, 0.362000f, 0.171000f, 0.304000f,
                0.175000f, 0.244000f, 0.176000f, 0.224000f,
                0.113000f, 0.224000f, 0.096000f, 0.111000f,
                0.096000f, 0.161000f, 0.143000f, 0.161000f,
                0.191000f, 0.161000f, 0.191000f, 0.111000f,
                0.191000f, 0.061000f, 0.143000f, 0.061000f,
                0.096000f, 0.061000f, 0.096000f, 0.111000f
            };

        private static readonly byte[] MyriadProGlyph64Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
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

        private static readonly float[] MyriadProGlyph64Coordinates =
            {
                0.375000f, 0.364000f, 0.359000f, 0.370000f,
                0.335000f, 0.370000f, 0.282000f, 0.370000f,
                0.245000f, 0.327000f, 0.208000f, 0.285000f,
                0.208000f, 0.226000f, 0.208000f, 0.165000f,
                0.260000f, 0.165000f, 0.293000f, 0.165000f,
                0.323000f, 0.201000f, 0.351000f, 0.234000f,
                0.358000f, 0.274000f, 0.375000f, 0.364000f,
                0.419000f, 0.018000f, 0.358000f, -0.014000f,
                0.276000f, -0.014000f, 0.175000f, -0.014000f,
                0.106000f, 0.054000f, 0.034000f, 0.124000f,
                0.034000f, 0.237000f, 0.034000f, 0.364000f,
                0.113000f, 0.452000f, 0.196000f, 0.545000f,
                0.326000f, 0.545000f, 0.429000f, 0.545000f,
                0.494000f, 0.479000f, 0.558000f, 0.414000f,
                0.558000f, 0.313000f, 0.558000f, 0.226000f,
                0.515000f, 0.172000f, 0.475000f, 0.122000f,
                0.416000f, 0.122000f, 0.354000f, 0.122000f,
                0.356000f, 0.193000f, 0.354000f, 0.193000f,
                0.312000f, 0.122000f, 0.241000f, 0.122000f,
                0.205000f, 0.122000f, 0.181000f, 0.149000f,
                0.155000f, 0.177000f, 0.155000f, 0.223000f,
                0.155000f, 0.300000f, 0.208000f, 0.355000f,
                0.263000f, 0.413000f, 0.344000f, 0.413000f,
                0.394000f, 0.413000f, 0.430000f, 0.396000f,
                0.403000f, 0.251000f, 0.385000f, 0.163000f,
                0.427000f, 0.161000f, 0.460000f, 0.160000f,
                0.485000f, 0.199000f, 0.513000f, 0.242000f,
                0.513000f, 0.307000f, 0.513000f, 0.397000f,
                0.463000f, 0.451000f, 0.411000f, 0.508000f,
                0.320000f, 0.508000f, 0.219000f, 0.508000f,
                0.151000f, 0.436000f, 0.080000f, 0.360000f,
                0.080000f, 0.241000f, 0.080000f, 0.143000f,
                0.138000f, 0.083000f, 0.195000f, 0.025000f,
                0.285000f, 0.025000f, 0.356000f, 0.025000f,
                0.406000f, 0.053000f, 0.419000f, 0.018000f
            };

        private static readonly byte[] MyriadProGlyph65Commands =
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph65Coordinates =
            {
                0.148000f, 0.240000f, 0.092000f, 0.070000f,
                0.020000f, 0.070000f, 0.204000f, 0.609000f,
                0.287000f, 0.609000f, 0.471000f, 0.070000f,
                0.397000f, 0.070000f, 0.339000f, 0.240000f,
                0.148000f, 0.240000f, 0.326000f, 0.294000f,
                0.272000f, 0.449000f, 0.264000f, 0.473000f,
                0.257000f, 0.500000f, 0.246000f, 0.542000f,
                0.244000f, 0.546000f, 0.244000f, 0.548000f,
                0.242000f, 0.548000f, 0.230000f, 0.500000f,
                0.222000f, 0.471000f, 0.215000f, 0.450000f,
                0.162000f, 0.294000f, 0.326000f, 0.294000f
            };

        private static readonly byte[] MyriadProGlyph66Commands =
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph66Coordinates =
            {
                0.061000f, 0.601000f, 0.112000f, 0.613000f,
                0.188000f, 0.613000f, 0.288000f, 0.613000f,
                0.335000f, 0.574000f, 0.381000f, 0.540000f,
                0.381000f, 0.479000f, 0.381000f, 0.393000f,
                0.290000f, 0.361000f, 0.290000f, 0.358000f,
                0.334000f, 0.348000f, 0.365000f, 0.317000f,
                0.401000f, 0.279000f, 0.401000f, 0.224000f,
                0.401000f, 0.158000f, 0.355000f, 0.116000f,
                0.301000f, 0.065000f, 0.169000f, 0.065000f,
                0.136000f, 0.065000f, 0.106000f, 0.067000f,
                0.081000f, 0.069000f, 0.061000f, 0.072000f,
                0.061000f, 0.601000f, 0.131000f, 0.381000f,
                0.194000f, 0.381000f, 0.310000f, 0.381000f,
                0.310000f, 0.472000f, 0.310000f, 0.560000f,
                0.192000f, 0.560000f, 0.170000f, 0.560000f,
                0.154000f, 0.558000f, 0.131000f, 0.555000f,
                0.131000f, 0.381000f, 0.131000f, 0.123000f,
                0.150000f, 0.120000f, 0.189000f, 0.120000f,
                0.249000f, 0.120000f, 0.285000f, 0.143000f,
                0.327000f, 0.170000f, 0.327000f, 0.225000f,
                0.327000f, 0.276000f, 0.286000f, 0.304000f,
                0.249000f, 0.329000f, 0.188000f, 0.329000f,
                0.131000f, 0.329000f, 0.131000f, 0.123000f
            };

        private static readonly byte[] MyriadProGlyph67Commands =
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph67Coordinates =
            {
                0.437000f, 0.087000f, 0.416000f, 0.076000f,
                0.381000f, 0.069000f, 0.341000f, 0.061000f,
                0.295000f, 0.061000f, 0.177000f, 0.061000f,
                0.105000f, 0.132000f, 0.029000f, 0.205000f,
                0.029000f, 0.335000f, 0.029000f, 0.462000f,
                0.107000f, 0.540000f, 0.185000f, 0.618000f,
                0.311000f, 0.618000f, 0.355000f, 0.618000f,
                0.393000f, 0.610000f, 0.421000f, 0.603000f,
                0.439000f, 0.594000f, 0.421000f, 0.537000f,
                0.376000f, 0.560000f, 0.313000f, 0.560000f,
                0.217000f, 0.560000f, 0.160000f, 0.502000f,
                0.103000f, 0.442000f, 0.103000f, 0.337000f,
                0.103000f, 0.237000f, 0.157000f, 0.179000f,
                0.212000f, 0.121000f, 0.309000f, 0.121000f,
                0.377000f, 0.121000f, 0.423000f, 0.143000f,
                0.437000f, 0.087000f
            };

        private static readonly byte[] MyriadProGlyph68Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph68Coordinates =
            {
                0.061000f, 0.601000f, 0.132000f, 0.613000f,
                0.209000f, 0.613000f, 0.354000f, 0.613000f,
                0.427000f, 0.546000f, 0.504000f, 0.477000f,
                0.504000f, 0.353000f, 0.504000f, 0.221000f,
                0.427000f, 0.143000f, 0.348000f, 0.065000f,
                0.187000f, 0.065000f, 0.117000f, 0.065000f,
                0.061000f, 0.072000f, 0.061000f, 0.601000f,
                0.131000f, 0.125000f, 0.154000f, 0.121000f,
                0.201000f, 0.121000f, 0.431000f, 0.121000f,
                0.431000f, 0.350000f, 0.431000f, 0.448000f,
                0.377000f, 0.502000f, 0.320000f, 0.558000f,
                0.212000f, 0.558000f, 0.164000f, 0.558000f,
                0.131000f, 0.551000f, 0.131000f, 0.125000f
            };

        private static readonly byte[] MyriadProGlyph69Commands =
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

        private static readonly float[] MyriadProGlyph69Coordinates =
            {
                0.339000f, 0.323000f, 0.130000f, 0.323000f,
                0.130000f, 0.129000f, 0.364000f, 0.129000f,
                0.364000f, 0.070000f, 0.060000f, 0.070000f,
                0.060000f, 0.609000f, 0.352000f, 0.609000f,
                0.352000f, 0.551000f, 0.130000f, 0.551000f,
                0.130000f, 0.381000f, 0.339000f, 0.381000f,
                0.339000f, 0.323000f
            };

        private static readonly byte[] MyriadProGlyph70Commands =
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

        private static readonly float[] MyriadProGlyph70Coordinates =
            {
                0.060000f, 0.609000f, 0.350000f, 0.609000f,
                0.350000f, 0.551000f, 0.130000f, 0.551000f,
                0.130000f, 0.372000f, 0.334000f, 0.372000f,
                0.334000f, 0.314000f, 0.130000f, 0.314000f,
                0.130000f, 0.070000f, 0.060000f, 0.070000f,
                0.060000f, 0.609000f
            };

        private static readonly byte[] MyriadProGlyph71Commands =
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph71Coordinates =
            {
                0.472000f, 0.094000f, 0.442000f, 0.083000f,
                0.405000f, 0.075000f, 0.355000f, 0.065000f,
                0.306000f, 0.065000f, 0.179000f, 0.065000f,
                0.104000f, 0.136000f, 0.029000f, 0.208000f,
                0.029000f, 0.337000f, 0.029000f, 0.459000f,
                0.107000f, 0.536000f, 0.188000f, 0.615000f,
                0.321000f, 0.615000f, 0.364000f, 0.615000f,
                0.403000f, 0.607000f, 0.436000f, 0.600000f,
                0.456000f, 0.590000f, 0.439000f, 0.533000f,
                0.415000f, 0.545000f, 0.389000f, 0.550000f,
                0.358000f, 0.557000f, 0.319000f, 0.557000f,
                0.220000f, 0.557000f, 0.162000f, 0.499000f,
                0.103000f, 0.440000f, 0.103000f, 0.340000f,
                0.103000f, 0.238000f, 0.159000f, 0.180000f,
                0.215000f, 0.122000f, 0.311000f, 0.122000f,
                0.375000f, 0.122000f, 0.403000f, 0.137000f,
                0.403000f, 0.297000f, 0.295000f, 0.297000f,
                0.295000f, 0.353000f, 0.472000f, 0.353000f,
                0.472000f, 0.094000f
            };

        private static readonly byte[] MyriadProGlyph72Commands =
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

        private static readonly float[] MyriadProGlyph72Coordinates =
            {
                0.130000f, 0.609000f, 0.130000f, 0.384000f,
                0.391000f, 0.384000f, 0.391000f, 0.609000f,
                0.462000f, 0.609000f, 0.462000f, 0.070000f,
                0.391000f, 0.070000f, 0.391000f, 0.323000f,
                0.130000f, 0.323000f, 0.130000f, 0.070000f,
                0.060000f, 0.070000f, 0.060000f, 0.609000f,
                0.130000f, 0.609000f
            };

        private static readonly byte[] MyriadProGlyph73Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph73Coordinates =
            {
                0.130000f, 0.609000f, 0.130000f, 0.070000f,
                0.060000f, 0.070000f, 0.060000f, 0.609000f,
                0.130000f, 0.609000f
            };

        private static readonly byte[] MyriadProGlyph74Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph74Coordinates =
            {
                0.170000f, 0.609000f, 0.241000f, 0.609000f,
                0.241000f, 0.249000f, 0.241000f, 0.148000f,
                0.194000f, 0.101000f, 0.153000f, 0.061000f,
                0.077000f, 0.061000f, 0.033000f, 0.061000f,
                0.003000f, 0.074000f, 0.013000f, 0.131000f,
                0.039000f, 0.121000f, 0.072000f, 0.121000f,
                0.122000f, 0.121000f, 0.144000f, 0.148000f,
                0.170000f, 0.179000f, 0.170000f, 0.254000f,
                0.170000f, 0.609000f
            };

        private static readonly byte[] MyriadProGlyph75Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph75Coordinates =
            {
                0.061000f, 0.609000f, 0.131000f, 0.609000f,
                0.131000f, 0.349000f, 0.133000f, 0.349000f,
                0.151000f, 0.376000f, 0.175000f, 0.407000f,
                0.340000f, 0.609000f, 0.427000f, 0.609000f,
                0.231000f, 0.381000f, 0.442000f, 0.070000f,
                0.359000f, 0.070000f, 0.183000f, 0.335000f,
                0.131000f, 0.276000f, 0.131000f, 0.070000f,
                0.061000f, 0.070000f, 0.061000f, 0.609000f
            };

        private static readonly byte[] MyriadProGlyph76Commands =
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

        private static readonly float[] MyriadProGlyph76Coordinates =
            {
                0.060000f, 0.609000f, 0.130000f, 0.609000f,
                0.130000f, 0.129000f, 0.361000f, 0.129000f,
                0.361000f, 0.070000f, 0.060000f, 0.070000f,
                0.060000f, 0.609000f
            };

        private static readonly byte[] MyriadProGlyph77Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph77Coordinates =
            {
                0.512000f, 0.366000f, 0.509000f, 0.427000f,
                0.506000f, 0.496000f, 0.506000f, 0.540000f,
                0.504000f, 0.540000f, 0.496000f, 0.514000f,
                0.490000f, 0.492000f, 0.481000f, 0.466000f,
                0.473000f, 0.442000f, 0.455000f, 0.386000f,
                0.436000f, 0.335000f, 0.341000f, 0.073000f,
                0.288000f, 0.073000f, 0.200000f, 0.330000f,
                0.180000f, 0.391000f, 0.166000f, 0.440000f,
                0.150000f, 0.494000f, 0.139000f, 0.540000f,
                0.137000f, 0.540000f, 0.135000f, 0.436000f,
                0.127000f, 0.301000f, 0.112000f, 0.070000f,
                0.046000f, 0.070000f, 0.084000f, 0.609000f,
                0.172000f, 0.609000f, 0.264000f, 0.349000f,
                0.297000f, 0.253000f, 0.319000f, 0.167000f,
                0.320000f, 0.167000f, 0.340000f, 0.241000f,
                0.378000f, 0.349000f, 0.474000f, 0.609000f,
                0.563000f, 0.609000f, 0.596000f, 0.070000f,
                0.528000f, 0.070000f, 0.512000f, 0.366000f
            };

        private static readonly byte[] MyriadProGlyph78Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph78Coordinates =
            {
                0.061000f, 0.070000f, 0.061000f, 0.609000f,
                0.138000f, 0.609000f, 0.310000f, 0.337000f,
                0.341000f, 0.287000f, 0.363000f, 0.246000f,
                0.388000f, 0.201000f, 0.406000f, 0.161000f,
                0.408000f, 0.162000f, 0.404000f, 0.214000f,
                0.402000f, 0.269000f, 0.400000f, 0.316000f,
                0.400000f, 0.384000f, 0.400000f, 0.609000f,
                0.466000f, 0.609000f, 0.466000f, 0.070000f,
                0.395000f, 0.070000f, 0.224000f, 0.344000f,
                0.193000f, 0.394000f, 0.170000f, 0.434000f,
                0.143000f, 0.483000f, 0.124000f, 0.524000f,
                0.122000f, 0.523000f, 0.125000f, 0.475000f,
                0.126000f, 0.420000f, 0.127000f, 0.374000f,
                0.127000f, 0.301000f, 0.127000f, 0.070000f,
                0.061000f, 0.070000f
            };

        private static readonly byte[] MyriadProGlyph79Commands =
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

        private static readonly float[] MyriadProGlyph79Coordinates =
            {
                0.456000f, 0.543000f, 0.522000f, 0.467000f,
                0.522000f, 0.345000f, 0.522000f, 0.212000f,
                0.448000f, 0.134000f, 0.379000f, 0.061000f,
                0.271000f, 0.061000f, 0.164000f, 0.061000f,
                0.097000f, 0.137000f, 0.029000f, 0.214000f,
                0.029000f, 0.336000f, 0.029000f, 0.463000f,
                0.100000f, 0.542000f, 0.169000f, 0.619000f,
                0.279000f, 0.619000f, 0.389000f, 0.619000f,
                0.456000f, 0.543000f, 0.146000f, 0.494000f,
                0.103000f, 0.432000f, 0.103000f, 0.337000f,
                0.103000f, 0.246000f, 0.148000f, 0.184000f,
                0.196000f, 0.118000f, 0.275000f, 0.118000f,
                0.355000f, 0.118000f, 0.403000f, 0.184000f,
                0.448000f, 0.247000f, 0.448000f, 0.342000f,
                0.448000f, 0.431000f, 0.406000f, 0.493000f,
                0.358000f, 0.562000f, 0.276000f, 0.562000f,
                0.193000f, 0.562000f, 0.146000f, 0.494000f
            };

        private static readonly byte[] MyriadProGlyph80Commands =
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

        private static readonly float[] MyriadProGlyph80Coordinates =
            {
                0.061000f, 0.603000f, 0.089000f, 0.608000f,
                0.119000f, 0.610000f, 0.156000f, 0.613000f,
                0.195000f, 0.613000f, 0.296000f, 0.613000f,
                0.346000f, 0.569000f, 0.393000f, 0.527000f,
                0.393000f, 0.456000f, 0.393000f, 0.383000f,
                0.351000f, 0.341000f, 0.295000f, 0.281000f,
                0.187000f, 0.281000f, 0.150000f, 0.281000f,
                0.131000f, 0.286000f, 0.131000f, 0.070000f,
                0.061000f, 0.070000f, 0.061000f, 0.603000f,
                0.131000f, 0.343000f, 0.152000f, 0.337000f,
                0.188000f, 0.337000f, 0.323000f, 0.337000f,
                0.323000f, 0.452000f, 0.323000f, 0.558000f,
                0.196000f, 0.558000f, 0.152000f, 0.558000f,
                0.131000f, 0.553000f, 0.131000f, 0.343000f
            };

        private static readonly byte[] MyriadProGlyph81Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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

        private static readonly float[] MyriadProGlyph81Coordinates =
            {
                0.506000f, -0.009000f, 0.396000f, 0.020000f,
                0.299000f, 0.053000f, 0.282000f, 0.059000f,
                0.273000f, 0.061000f, 0.267000f, 0.061000f,
                0.165000f, 0.065000f, 0.100000f, 0.135000f,
                0.029000f, 0.209000f, 0.029000f, 0.335000f,
                0.029000f, 0.463000f, 0.100000f, 0.542000f,
                0.169000f, 0.619000f, 0.279000f, 0.619000f,
                0.389000f, 0.619000f, 0.456000f, 0.542000f,
                0.522000f, 0.467000f, 0.522000f, 0.346000f,
                0.522000f, 0.245000f, 0.479000f, 0.176000f,
                0.438000f, 0.112000f, 0.368000f, 0.087000f,
                0.368000f, 0.084000f, 0.454000f, 0.062000f,
                0.526000f, 0.049000f, 0.506000f, -0.009000f,
                0.403000f, 0.184000f, 0.448000f, 0.247000f,
                0.448000f, 0.342000f, 0.448000f, 0.431000f,
                0.406000f, 0.493000f, 0.359000f, 0.562000f,
                0.278000f, 0.562000f, 0.194000f, 0.562000f,
                0.146000f, 0.493000f, 0.103000f, 0.431000f,
                0.103000f, 0.337000f, 0.103000f, 0.246000f,
                0.148000f, 0.184000f, 0.196000f, 0.118000f,
                0.275000f, 0.118000f, 0.355000f, 0.118000f,
                0.403000f, 0.184000f
            };

        private static readonly byte[] MyriadProGlyph82Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph82Coordinates =
            {
                0.061000f, 0.602000f, 0.123000f, 0.613000f,
                0.195000f, 0.613000f, 0.302000f, 0.613000f,
                0.351000f, 0.569000f, 0.393000f, 0.531000f,
                0.393000f, 0.466000f, 0.393000f, 0.416000f,
                0.364000f, 0.379000f, 0.337000f, 0.345000f,
                0.292000f, 0.329000f, 0.292000f, 0.327000f,
                0.350000f, 0.306000f, 0.371000f, 0.218000f,
                0.383000f, 0.166000f, 0.394000f, 0.124000f,
                0.404000f, 0.085000f, 0.412000f, 0.070000f,
                0.340000f, 0.070000f, 0.328000f, 0.093000f,
                0.305000f, 0.199000f, 0.283000f, 0.300000f,
                0.196000f, 0.304000f, 0.131000f, 0.304000f,
                0.131000f, 0.070000f, 0.061000f, 0.070000f,
                0.061000f, 0.602000f, 0.131000f, 0.357000f,
                0.202000f, 0.357000f, 0.323000f, 0.357000f,
                0.323000f, 0.459000f, 0.323000f, 0.559000f,
                0.199000f, 0.559000f, 0.152000f, 0.559000f,
                0.131000f, 0.553000f, 0.131000f, 0.357000f
            };

        private static readonly byte[] MyriadProGlyph83Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph83Coordinates =
            {
                0.052000f, 0.155000f, 0.107000f, 0.120000f,
                0.176000f, 0.120000f, 0.289000f, 0.120000f,
                0.289000f, 0.212000f, 0.289000f, 0.280000f,
                0.188000f, 0.318000f, 0.118000f, 0.343000f,
                0.083000f, 0.379000f, 0.045000f, 0.418000f,
                0.045000f, 0.472000f, 0.045000f, 0.536000f,
                0.093000f, 0.577000f, 0.142000f, 0.618000f,
                0.220000f, 0.618000f, 0.258000f, 0.618000f,
                0.291000f, 0.610000f, 0.319000f, 0.603000f,
                0.338000f, 0.592000f, 0.319000f, 0.535000f,
                0.303000f, 0.545000f, 0.280000f, 0.552000f,
                0.250000f, 0.561000f, 0.217000f, 0.561000f,
                0.166000f, 0.561000f, 0.139000f, 0.534000f,
                0.116000f, 0.512000f, 0.116000f, 0.480000f,
                0.116000f, 0.417000f, 0.223000f, 0.376000f,
                0.360000f, 0.323000f, 0.360000f, 0.217000f,
                0.360000f, 0.151000f, 0.313000f, 0.108000f,
                0.262000f, 0.061000f, 0.172000f, 0.061000f,
                0.087000f, 0.061000f, 0.034000f, 0.097000f,
                0.052000f, 0.155000f
            };

        private static readonly byte[] MyriadProGlyph84Commands =
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

        private static readonly float[] MyriadProGlyph84Coordinates =
            {
                0.163000f, 0.550000f, -0.001000f, 0.550000f,
                -0.001000f, 0.609000f, 0.398000f, 0.609000f,
                0.398000f, 0.550000f, 0.233000f, 0.550000f,
                0.233000f, 0.070000f, 0.163000f, 0.070000f,
                0.163000f, 0.550000f
            };

        private static readonly byte[] MyriadProGlyph85Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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

        private static readonly float[] MyriadProGlyph85Coordinates =
            {
                0.130000f, 0.609000f, 0.130000f, 0.289000f,
                0.130000f, 0.203000f, 0.166000f, 0.159000f,
                0.199000f, 0.118000f, 0.256000f, 0.118000f,
                0.387000f, 0.118000f, 0.387000f, 0.289000f,
                0.387000f, 0.609000f, 0.458000f, 0.609000f,
                0.458000f, 0.294000f, 0.458000f, 0.176000f,
                0.399000f, 0.116000f, 0.347000f, 0.061000f,
                0.254000f, 0.061000f, 0.165000f, 0.061000f,
                0.115000f, 0.114000f, 0.060000f, 0.172000f,
                0.060000f, 0.292000f, 0.060000f, 0.609000f,
                0.130000f, 0.609000f
            };

        private static readonly byte[] MyriadProGlyph86Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph86Coordinates =
            {
                0.179000f, 0.070000f, 0.002000f, 0.609000f,
                0.078000f, 0.609000f, 0.162000f, 0.344000f,
                0.194000f, 0.239000f, 0.209000f, 0.185000f,
                0.220000f, 0.142000f, 0.221000f, 0.142000f,
                0.232000f, 0.187000f, 0.248000f, 0.240000f,
                0.263000f, 0.287000f, 0.283000f, 0.343000f,
                0.374000f, 0.609000f, 0.448000f, 0.609000f,
                0.256000f, 0.070000f, 0.179000f, 0.070000f
            };

        private static readonly byte[] MyriadProGlyph87Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph87Coordinates =
            {
                0.149000f, 0.070000f, 0.012000f, 0.609000f,
                0.086000f, 0.609000f, 0.150000f, 0.337000f,
                0.174000f, 0.232000f, 0.190000f, 0.150000f,
                0.191000f, 0.150000f, 0.197000f, 0.186000f,
                0.210000f, 0.238000f, 0.215000f, 0.259000f,
                0.222000f, 0.286000f, 0.307000f, 0.609000f,
                0.380000f, 0.609000f, 0.457000f, 0.288000f,
                0.467000f, 0.241000f, 0.478000f, 0.190000f,
                0.483000f, 0.151000f, 0.485000f, 0.151000f,
                0.492000f, 0.190000f, 0.504000f, 0.241000f,
                0.526000f, 0.331000f, 0.599000f, 0.609000f,
                0.670000f, 0.609000f, 0.518000f, 0.070000f,
                0.445000f, 0.070000f, 0.377000f, 0.351000f,
                0.351000f, 0.457000f, 0.342000f, 0.527000f,
                0.340000f, 0.527000f, 0.328000f, 0.454000f,
                0.298000f, 0.351000f, 0.222000f, 0.070000f,
                0.149000f, 0.070000f
            };

        private static readonly byte[] MyriadProGlyph88Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph88Coordinates =
            {
                0.356000f, 0.070000f, 0.286000f, 0.189000f,
                0.251000f, 0.248000f, 0.225000f, 0.296000f,
                0.223000f, 0.296000f, 0.205000f, 0.258000f,
                0.165000f, 0.189000f, 0.100000f, 0.070000f,
                0.020000f, 0.070000f, 0.185000f, 0.343000f,
                0.026000f, 0.609000f, 0.107000f, 0.609000f,
                0.178000f, 0.483000f, 0.196000f, 0.453000f,
                0.205000f, 0.435000f, 0.218000f, 0.412000f,
                0.228000f, 0.392000f, 0.230000f, 0.392000f,
                0.249000f, 0.431000f, 0.279000f, 0.483000f,
                0.352000f, 0.609000f, 0.433000f, 0.609000f,
                0.269000f, 0.347000f, 0.437000f, 0.070000f,
                0.356000f, 0.070000f
            };

        private static readonly byte[] MyriadProGlyph89Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph89Coordinates =
            {
                0.181000f, 0.070000f, 0.181000f, 0.299000f,
                0.010000f, 0.609000f, 0.090000f, 0.609000f,
                0.194000f, 0.404000f, 0.209000f, 0.373000f,
                0.220000f, 0.349000f, 0.221000f, 0.349000f,
                0.230000f, 0.372000f, 0.246000f, 0.403000f,
                0.251000f, 0.413000f, 0.260000f, 0.431000f,
                0.353000f, 0.609000f, 0.432000f, 0.609000f,
                0.252000f, 0.300000f, 0.252000f, 0.070000f,
                0.181000f, 0.070000f
            };

        private static readonly byte[] MyriadProGlyph90Commands =
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

        private static readonly float[] MyriadProGlyph90Coordinates =
            {
                0.024000f, 0.111000f, 0.322000f, 0.549000f,
                0.322000f, 0.551000f, 0.050000f, 0.551000f,
                0.050000f, 0.609000f, 0.414000f, 0.609000f,
                0.414000f, 0.567000f, 0.116000f, 0.131000f,
                0.116000f, 0.129000f, 0.418000f, 0.129000f,
                0.418000f, 0.070000f, 0.024000f, 0.070000f,
                0.024000f, 0.111000f
            };

        private static readonly byte[] MyriadProGlyph91Commands =
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

        private static readonly float[] MyriadProGlyph91Coordinates =
            {
                0.065000f, -0.019000f, 0.065000f, 0.619000f,
                0.211000f, 0.619000f, 0.211000f, 0.575000f,
                0.120000f, 0.575000f, 0.120000f, 0.025000f,
                0.211000f, 0.025000f, 0.211000f, -0.019000f,
                0.065000f, -0.019000f
            };

        private static readonly byte[] MyriadProGlyph92Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph92Coordinates =
            {
                0.220000f, 0.039000f, 0.002000f, 0.619000f,
                0.056000f, 0.619000f, 0.274000f, 0.039000f,
                0.220000f, 0.039000f
            };

        private static readonly byte[] MyriadProGlyph93Commands =
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

        private static readonly float[] MyriadProGlyph93Coordinates =
            {
                0.162000f, 0.619000f, 0.162000f, -0.019000f,
                0.016000f, -0.019000f, 0.016000f, 0.025000f,
                0.107000f, 0.025000f, 0.107000f, 0.575000f,
                0.016000f, 0.575000f, 0.016000f, 0.619000f,
                0.162000f, 0.619000f
            };

        private static readonly byte[] MyriadProGlyph94Commands =
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

        private static readonly float[] MyriadProGlyph94Coordinates =
            {
                0.373000f, 0.221000f, 0.239000f, 0.532000f,
                0.238000f, 0.532000f, 0.104000f, 0.221000f,
                0.049000f, 0.221000f, 0.214000f, 0.590000f,
                0.264000f, 0.590000f, 0.429000f, 0.221000f,
                0.373000f, 0.221000f
            };

        private static readonly byte[] MyriadProGlyph95Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph95Coordinates =
            {
                0.400000f, 0.010000f, 0.400000f, -0.030000f,
                0.000000f, -0.030000f, 0.000000f, 0.010000f,
                0.400000f, 0.010000f
            };

        private static readonly byte[] MyriadProGlyph96Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph96Coordinates =
            {
                0.095000f, 0.625000f, 0.165000f, 0.510000f,
                0.116000f, 0.510000f, 0.018000f, 0.625000f,
                0.095000f, 0.625000f
            };

        private static readonly byte[] MyriadProGlyph97Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph97Coordinates =
            {
                0.330000f, 0.163000f, 0.330000f, 0.107000f,
                0.336000f, 0.070000f, 0.273000f, 0.070000f,
                0.267000f, 0.119000f, 0.265000f, 0.119000f,
                0.247000f, 0.094000f, 0.218000f, 0.079000f,
                0.185000f, 0.061000f, 0.146000f, 0.061000f,
                0.091000f, 0.061000f, 0.058000f, 0.096000f,
                0.028000f, 0.127000f, 0.028000f, 0.173000f,
                0.028000f, 0.318000f, 0.261000f, 0.317000f,
                0.261000f, 0.325000f, 0.261000f, 0.339000f,
                0.258000f, 0.352000f, 0.255000f, 0.369000f,
                0.247000f, 0.381000f, 0.225000f, 0.414000f,
                0.173000f, 0.413000f, 0.114000f, 0.413000f,
                0.071000f, 0.385000f, 0.055000f, 0.432000f,
                0.109000f, 0.465000f, 0.183000f, 0.465000f,
                0.264000f, 0.465000f, 0.301000f, 0.415000f,
                0.317000f, 0.394000f, 0.324000f, 0.365000f,
                0.330000f, 0.339000f, 0.330000f, 0.308000f,
                0.330000f, 0.163000f, 0.262000f, 0.268000f,
                0.230000f, 0.268000f, 0.204000f, 0.265000f,
                0.174000f, 0.262000f, 0.152000f, 0.253000f,
                0.098000f, 0.232000f, 0.098000f, 0.181000f,
                0.098000f, 0.113000f, 0.164000f, 0.113000f,
                0.200000f, 0.113000f, 0.227000f, 0.134000f,
                0.250000f, 0.151000f, 0.259000f, 0.178000f,
                0.262000f, 0.189000f, 0.262000f, 0.201000f,
                0.262000f, 0.268000f
            };

        private static readonly byte[] MyriadProGlyph98Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph98Coordinates =
            {
                0.058000f, 0.638000f, 0.128000f, 0.638000f,
                0.128000f, 0.395000f, 0.129000f, 0.395000f,
                0.170000f, 0.465000f, 0.261000f, 0.465000f,
                0.334000f, 0.465000f, 0.380000f, 0.411000f,
                0.425000f, 0.356000f, 0.425000f, 0.269000f,
                0.425000f, 0.171000f, 0.371000f, 0.113000f,
                0.321000f, 0.061000f, 0.251000f, 0.061000f,
                0.163000f, 0.061000f, 0.121000f, 0.133000f,
                0.119000f, 0.133000f, 0.115000f, 0.070000f,
                0.055000f, 0.070000f, 0.056000f, 0.092000f,
                0.057000f, 0.117000f, 0.058000f, 0.146000f,
                0.058000f, 0.170000f, 0.058000f, 0.638000f,
                0.128000f, 0.225000f, 0.128000f, 0.210000f,
                0.131000f, 0.200000f, 0.153000f, 0.117000f,
                0.237000f, 0.117000f, 0.292000f, 0.117000f,
                0.323000f, 0.159000f, 0.354000f, 0.199000f,
                0.354000f, 0.266000f, 0.354000f, 0.328000f,
                0.325000f, 0.367000f, 0.293000f, 0.410000f,
                0.238000f, 0.410000f, 0.155000f, 0.410000f,
                0.132000f, 0.324000f, 0.128000f, 0.309000f,
                0.128000f, 0.294000f, 0.128000f, 0.225000f
            };

        private static readonly byte[] MyriadProGlyph99Commands =
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

        private static readonly float[] MyriadProGlyph99Coordinates =
            {
                0.334000f, 0.084000f, 0.316000f, 0.075000f,
                0.291000f, 0.069000f, 0.258000f, 0.061000f,
                0.223000f, 0.061000f, 0.135000f, 0.061000f,
                0.083000f, 0.116000f, 0.030000f, 0.170000f,
                0.030000f, 0.259000f, 0.030000f, 0.350000f,
                0.087000f, 0.407000f, 0.144000f, 0.465000f,
                0.238000f, 0.465000f, 0.297000f, 0.465000f,
                0.336000f, 0.445000f, 0.320000f, 0.391000f,
                0.304000f, 0.399000f, 0.287000f, 0.404000f,
                0.264000f, 0.409000f, 0.238000f, 0.409000f,
                0.174000f, 0.409000f, 0.136000f, 0.366000f,
                0.101000f, 0.326000f, 0.101000f, 0.263000f,
                0.101000f, 0.197000f, 0.140000f, 0.157000f,
                0.177000f, 0.118000f, 0.236000f, 0.118000f,
                0.263000f, 0.118000f, 0.286000f, 0.124000f,
                0.303000f, 0.128000f, 0.322000f, 0.137000f,
                0.334000f, 0.084000f
            };

        private static readonly byte[] MyriadProGlyph100Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph100Coordinates =
            {
                0.392000f, 0.638000f, 0.392000f, 0.170000f,
                0.392000f, 0.146000f, 0.393000f, 0.117000f,
                0.394000f, 0.092000f, 0.395000f, 0.070000f,
                0.333000f, 0.070000f, 0.330000f, 0.137000f,
                0.327000f, 0.137000f, 0.291000f, 0.061000f,
                0.197000f, 0.061000f, 0.126000f, 0.061000f,
                0.079000f, 0.116000f, 0.031000f, 0.171000f,
                0.031000f, 0.258000f, 0.030000f, 0.352000f,
                0.082000f, 0.410000f, 0.131000f, 0.465000f,
                0.204000f, 0.465000f, 0.246000f, 0.465000f,
                0.278000f, 0.448000f, 0.306000f, 0.432000f,
                0.321000f, 0.407000f, 0.323000f, 0.407000f,
                0.323000f, 0.638000f, 0.392000f, 0.638000f,
                0.323000f, 0.300000f, 0.323000f, 0.318000f,
                0.319000f, 0.329000f, 0.300000f, 0.410000f,
                0.218000f, 0.410000f, 0.164000f, 0.410000f,
                0.132000f, 0.368000f, 0.102000f, 0.327000f,
                0.102000f, 0.261000f, 0.102000f, 0.200000f,
                0.131000f, 0.160000f, 0.162000f, 0.118000f,
                0.216000f, 0.118000f, 0.299000f, 0.118000f,
                0.319000f, 0.202000f, 0.323000f, 0.215000f,
                0.323000f, 0.233000f, 0.323000f, 0.300000f
            };

        private static readonly byte[] MyriadProGlyph101Commands =
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

        private static readonly float[] MyriadProGlyph101Coordinates =
            {
                0.097000f, 0.251000f, 0.098000f, 0.183000f,
                0.138000f, 0.148000f, 0.172000f, 0.117000f,
                0.230000f, 0.117000f, 0.265000f, 0.117000f,
                0.293000f, 0.122000f, 0.315000f, 0.127000f,
                0.337000f, 0.137000f, 0.350000f, 0.086000f,
                0.327000f, 0.076000f, 0.299000f, 0.070000f,
                0.262000f, 0.061000f, 0.220000f, 0.061000f,
                0.132000f, 0.061000f, 0.081000f, 0.116000f,
                0.030000f, 0.169000f, 0.030000f, 0.257000f,
                0.030000f, 0.347000f, 0.079000f, 0.405000f,
                0.129000f, 0.465000f, 0.212000f, 0.465000f,
                0.257000f, 0.465000f, 0.290000f, 0.447000f,
                0.320000f, 0.431000f, 0.339000f, 0.401000f,
                0.356000f, 0.376000f, 0.364000f, 0.342000f,
                0.372000f, 0.314000f, 0.372000f, 0.284000f,
                0.372000f, 0.263000f, 0.369000f, 0.251000f,
                0.097000f, 0.251000f, 0.304000f, 0.301000f,
                0.304000f, 0.344000f, 0.285000f, 0.375000f,
                0.259000f, 0.415000f, 0.206000f, 0.415000f,
                0.157000f, 0.415000f, 0.127000f, 0.377000f,
                0.103000f, 0.346000f, 0.098000f, 0.301000f,
                0.304000f, 0.301000f
            };

        private static readonly byte[] MyriadProGlyph102Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph102Coordinates =
            {
                0.066000f, 0.070000f, 0.066000f, 0.404000f,
                0.012000f, 0.404000f, 0.012000f, 0.457000f,
                0.066000f, 0.457000f, 0.066000f, 0.476000f,
                0.066000f, 0.567000f, 0.110000f, 0.611000f,
                0.148000f, 0.647000f, 0.205000f, 0.647000f,
                0.238000f, 0.647000f, 0.265000f, 0.636000f,
                0.255000f, 0.581000f, 0.236000f, 0.590000f,
                0.210000f, 0.590000f, 0.169000f, 0.590000f,
                0.150000f, 0.557000f, 0.135000f, 0.529000f,
                0.135000f, 0.478000f, 0.135000f, 0.457000f,
                0.229000f, 0.457000f, 0.229000f, 0.404000f,
                0.135000f, 0.404000f, 0.135000f, 0.070000f,
                0.066000f, 0.070000f
            };

        private static readonly byte[] MyriadProGlyph103Commands =
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

        private static readonly float[] MyriadProGlyph103Coordinates =
            {
                0.389000f, 0.127000f, 0.389000f, 0.001000f,
                0.334000f, -0.051000f, 0.307000f, -0.075000f,
                0.267000f, -0.087000f, 0.233000f, -0.097000f,
                0.192000f, -0.097000f, 0.112000f, -0.097000f,
                0.064000f, -0.065000f, 0.081000f, -0.011000f,
                0.102000f, -0.024000f, 0.130000f, -0.032000f,
                0.161000f, -0.042000f, 0.195000f, -0.042000f,
                0.252000f, -0.042000f, 0.284000f, -0.011000f,
                0.320000f, 0.024000f, 0.320000f, 0.094000f,
                0.320000f, 0.137000f, 0.318000f, 0.137000f,
                0.281000f, 0.072000f, 0.195000f, 0.072000f,
                0.123000f, 0.072000f, 0.076000f, 0.126000f,
                0.030000f, 0.180000f, 0.030000f, 0.261000f,
                0.030000f, 0.355000f, 0.084000f, 0.412000f,
                0.134000f, 0.465000f, 0.205000f, 0.465000f,
                0.251000f, 0.465000f, 0.284000f, 0.444000f,
                0.310000f, 0.427000f, 0.326000f, 0.399000f,
                0.328000f, 0.399000f, 0.330000f, 0.457000f,
                0.392000f, 0.457000f, 0.389000f, 0.421000f,
                0.389000f, 0.352000f, 0.389000f, 0.127000f,
                0.319000f, 0.305000f, 0.319000f, 0.325000f,
                0.315000f, 0.336000f, 0.292000f, 0.411000f,
                0.216000f, 0.411000f, 0.165000f, 0.411000f,
                0.134000f, 0.371000f, 0.101000f, 0.331000f,
                0.101000f, 0.265000f, 0.101000f, 0.205000f,
                0.130000f, 0.167000f, 0.161000f, 0.125000f,
                0.216000f, 0.125000f, 0.290000f, 0.125000f,
                0.313000f, 0.197000f, 0.319000f, 0.214000f,
                0.319000f, 0.235000f, 0.319000f, 0.305000f
            };

        private static readonly byte[] MyriadProGlyph104Commands =
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

        private static readonly float[] MyriadProGlyph104Coordinates =
            {
                0.058000f, 0.638000f, 0.128000f, 0.638000f,
                0.128000f, 0.396000f, 0.130000f, 0.396000f,
                0.148000f, 0.428000f, 0.180000f, 0.446000f,
                0.214000f, 0.465000f, 0.252000f, 0.465000f,
                0.274000f, 0.465000f, 0.295000f, 0.458000f,
                0.321000f, 0.450000f, 0.340000f, 0.433000f,
                0.362000f, 0.413000f, 0.374000f, 0.382000f,
                0.388000f, 0.348000f, 0.388000f, 0.301000f,
                0.388000f, 0.070000f, 0.317000f, 0.070000f,
                0.317000f, 0.293000f, 0.317000f, 0.344000f,
                0.297000f, 0.373000f, 0.274000f, 0.407000f,
                0.228000f, 0.407000f, 0.158000f, 0.407000f,
                0.133000f, 0.337000f, 0.128000f, 0.325000f,
                0.128000f, 0.304000f, 0.128000f, 0.070000f,
                0.058000f, 0.070000f, 0.058000f, 0.638000f
            };

        private static readonly byte[] MyriadProGlyph105Commands =
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph105Coordinates =
            {
                0.059000f, 0.070000f, 0.059000f, 0.457000f,
                0.129000f, 0.457000f, 0.129000f, 0.070000f,
                0.059000f, 0.070000f, 0.137000f, 0.566000f,
                0.137000f, 0.523000f, 0.092000f, 0.523000f,
                0.050000f, 0.523000f, 0.050000f, 0.566000f,
                0.050000f, 0.610000f, 0.094000f, 0.610000f,
                0.137000f, 0.610000f, 0.137000f, 0.566000f
            };

        private static readonly byte[] MyriadProGlyph106Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph106Coordinates =
            {
                -0.037000f, -0.043000f, 0.017000f, -0.039000f,
                0.040000f, -0.013000f, 0.055000f, 0.004000f,
                0.061000f, 0.033000f, 0.067000f, 0.065000f,
                0.067000f, 0.132000f, 0.067000f, 0.457000f,
                0.137000f, 0.457000f, 0.137000f, 0.105000f,
                0.137000f, -0.007000f, 0.091000f, -0.055000f,
                0.069000f, -0.076000f, 0.033000f, -0.088000f,
                0.002000f, -0.099000f, -0.029000f, -0.099000f,
                -0.037000f, -0.043000f, 0.145000f, 0.566000f,
                0.145000f, 0.523000f, 0.101000f, 0.523000f,
                0.058000f, 0.523000f, 0.058000f, 0.566000f,
                0.058000f, 0.610000f, 0.102000f, 0.610000f,
                0.145000f, 0.610000f, 0.145000f, 0.566000f
            };

        private static readonly byte[] MyriadProGlyph107Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph107Coordinates =
            {
                0.128000f, 0.280000f, 0.129000f, 0.280000f,
                0.145000f, 0.302000f, 0.163000f, 0.324000f,
                0.277000f, 0.457000f, 0.361000f, 0.457000f,
                0.212000f, 0.298000f, 0.383000f, 0.070000f,
                0.296000f, 0.070000f, 0.164000f, 0.256000f,
                0.128000f, 0.216000f, 0.128000f, 0.070000f,
                0.058000f, 0.070000f, 0.058000f, 0.638000f,
                0.128000f, 0.638000f, 0.128000f, 0.280000f
            };

        private static readonly byte[] MyriadProGlyph108Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph108Coordinates =
            {
                0.058000f, 0.638000f, 0.128000f, 0.638000f,
                0.128000f, 0.070000f, 0.058000f, 0.070000f,
                0.058000f, 0.638000f
            };

        private static readonly byte[] MyriadProGlyph109Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph109Coordinates =
            {
                0.058000f, 0.353000f, 0.058000f, 0.380000f,
                0.057000f, 0.408000f, 0.055000f, 0.457000f,
                0.117000f, 0.457000f, 0.120000f, 0.394000f,
                0.122000f, 0.394000f, 0.141000f, 0.426000f,
                0.167000f, 0.444000f, 0.200000f, 0.465000f,
                0.245000f, 0.465000f, 0.325000f, 0.465000f,
                0.353000f, 0.388000f, 0.355000f, 0.388000f,
                0.371000f, 0.417000f, 0.399000f, 0.438000f,
                0.435000f, 0.465000f, 0.484000f, 0.465000f,
                0.533000f, 0.465000f, 0.567000f, 0.432000f,
                0.588000f, 0.411000f, 0.599000f, 0.380000f,
                0.612000f, 0.345000f, 0.612000f, 0.297000f,
                0.612000f, 0.070000f, 0.543000f, 0.070000f,
                0.543000f, 0.289000f, 0.543000f, 0.408000f,
                0.459000f, 0.408000f, 0.399000f, 0.408000f,
                0.375000f, 0.345000f, 0.369000f, 0.326000f,
                0.369000f, 0.309000f, 0.369000f, 0.070000f,
                0.301000f, 0.070000f, 0.301000f, 0.302000f,
                0.301000f, 0.408000f, 0.220000f, 0.408000f,
                0.189000f, 0.408000f, 0.164000f, 0.386000f,
                0.142000f, 0.366000f, 0.133000f, 0.337000f,
                0.127000f, 0.324000f, 0.127000f, 0.303000f,
                0.127000f, 0.070000f, 0.058000f, 0.070000f,
                0.058000f, 0.353000f
            };

        private static readonly byte[] MyriadProGlyph110Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph110Coordinates =
            {
                0.058000f, 0.353000f, 0.058000f, 0.415000f,
                0.055000f, 0.457000f, 0.117000f, 0.457000f,
                0.121000f, 0.393000f, 0.123000f, 0.393000f,
                0.139000f, 0.423000f, 0.170000f, 0.443000f,
                0.206000f, 0.465000f, 0.251000f, 0.465000f,
                0.274000f, 0.465000f, 0.295000f, 0.458000f,
                0.320000f, 0.450000f, 0.340000f, 0.433000f,
                0.362000f, 0.413000f, 0.374000f, 0.382000f,
                0.388000f, 0.348000f, 0.388000f, 0.301000f,
                0.388000f, 0.070000f, 0.317000f, 0.070000f,
                0.317000f, 0.293000f, 0.317000f, 0.345000f,
                0.298000f, 0.374000f, 0.275000f, 0.408000f,
                0.228000f, 0.408000f, 0.157000f, 0.408000f,
                0.133000f, 0.336000f, 0.129000f, 0.323000f,
                0.129000f, 0.303000f, 0.129000f, 0.070000f,
                0.058000f, 0.070000f, 0.058000f, 0.353000f
            };

        private static readonly byte[] MyriadProGlyph111Commands =
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

        private static readonly float[] MyriadProGlyph111Coordinates =
            {
                0.357000f, 0.410000f, 0.408000f, 0.355000f,
                0.408000f, 0.267000f, 0.408000f, 0.167000f,
                0.347000f, 0.111000f, 0.293000f, 0.061000f,
                0.216000f, 0.061000f, 0.136000f, 0.061000f,
                0.084000f, 0.115000f, 0.030000f, 0.171000f,
                0.030000f, 0.261000f, 0.030000f, 0.355000f,
                0.086000f, 0.411000f, 0.140000f, 0.465000f,
                0.222000f, 0.465000f, 0.305000f, 0.465000f,
                0.357000f, 0.410000f, 0.130000f, 0.365000f,
                0.102000f, 0.324000f, 0.102000f, 0.263000f,
                0.102000f, 0.199000f, 0.135000f, 0.157000f,
                0.168000f, 0.114000f, 0.219000f, 0.114000f,
                0.269000f, 0.114000f, 0.303000f, 0.157000f,
                0.336000f, 0.199000f, 0.336000f, 0.265000f,
                0.336000f, 0.322000f, 0.310000f, 0.363000f,
                0.278000f, 0.413000f, 0.220000f, 0.413000f,
                0.163000f, 0.413000f, 0.130000f, 0.365000f
            };

        private static readonly byte[] MyriadProGlyph112Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph112Coordinates =
            {
                0.058000f, 0.331000f, 0.058000f, 0.364000f,
                0.057000f, 0.399000f, 0.055000f, 0.457000f,
                0.117000f, 0.457000f, 0.121000f, 0.391000f,
                0.123000f, 0.391000f, 0.167000f, 0.465000f,
                0.261000f, 0.465000f, 0.332000f, 0.465000f,
                0.378000f, 0.411000f, 0.425000f, 0.356000f,
                0.425000f, 0.269000f, 0.425000f, 0.170000f,
                0.371000f, 0.113000f, 0.322000f, 0.061000f,
                0.249000f, 0.061000f, 0.166000f, 0.061000f,
                0.129000f, 0.122000f, 0.128000f, 0.122000f,
                0.128000f, -0.088000f, 0.058000f, -0.088000f,
                0.058000f, 0.331000f, 0.128000f, 0.228000f,
                0.128000f, 0.211000f, 0.131000f, 0.199000f,
                0.153000f, 0.117000f, 0.237000f, 0.117000f,
                0.292000f, 0.117000f, 0.323000f, 0.158000f,
                0.354000f, 0.199000f, 0.354000f, 0.266000f,
                0.354000f, 0.327000f, 0.325000f, 0.367000f,
                0.293000f, 0.409000f, 0.239000f, 0.409000f,
                0.154000f, 0.409000f, 0.133000f, 0.323000f,
                0.128000f, 0.305000f, 0.128000f, 0.295000f,
                0.128000f, 0.228000f
            };

        private static readonly byte[] MyriadProGlyph113Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph113Coordinates =
            {
                0.322000f, 0.129000f, 0.320000f, 0.129000f,
                0.303000f, 0.099000f, 0.273000f, 0.081000f,
                0.238000f, 0.061000f, 0.194000f, 0.061000f,
                0.125000f, 0.061000f, 0.078000f, 0.115000f,
                0.030000f, 0.170000f, 0.030000f, 0.257000f,
                0.030000f, 0.358000f, 0.087000f, 0.416000f,
                0.136000f, 0.465000f, 0.205000f, 0.465000f,
                0.290000f, 0.465000f, 0.324000f, 0.399000f,
                0.326000f, 0.399000f, 0.328000f, 0.457000f,
                0.395000f, 0.457000f, 0.393000f, 0.407000f,
                0.392000f, 0.378000f, 0.392000f, 0.351000f,
                0.392000f, -0.088000f, 0.322000f, -0.088000f,
                0.322000f, 0.129000f, 0.322000f, 0.301000f,
                0.322000f, 0.318000f, 0.319000f, 0.329000f,
                0.298000f, 0.409000f, 0.218000f, 0.409000f,
                0.164000f, 0.409000f, 0.132000f, 0.368000f,
                0.101000f, 0.327000f, 0.101000f, 0.261000f,
                0.101000f, 0.199000f, 0.129000f, 0.160000f,
                0.160000f, 0.117000f, 0.216000f, 0.117000f,
                0.291000f, 0.117000f, 0.316000f, 0.193000f,
                0.322000f, 0.212000f, 0.322000f, 0.228000f,
                0.322000f, 0.301000f
            };

        private static readonly byte[] MyriadProGlyph114Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph114Coordinates =
            {
                0.058000f, 0.337000f, 0.058000f, 0.409000f,
                0.055000f, 0.457000f, 0.117000f, 0.457000f,
                0.120000f, 0.381000f, 0.122000f, 0.381000f,
                0.151000f, 0.465000f, 0.230000f, 0.465000f,
                0.237000f, 0.465000f, 0.249000f, 0.464000f,
                0.249000f, 0.397000f, 0.242000f, 0.399000f,
                0.225000f, 0.399000f, 0.147000f, 0.399000f,
                0.131000f, 0.309000f, 0.129000f, 0.295000f,
                0.129000f, 0.277000f, 0.129000f, 0.070000f,
                0.058000f, 0.070000f, 0.058000f, 0.337000f
            };

        private static readonly byte[] MyriadProGlyph115Commands =
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

        private static readonly float[] MyriadProGlyph115Coordinates =
            {
                0.049000f, 0.141000f, 0.067000f, 0.130000f,
                0.091000f, 0.123000f, 0.118000f, 0.114000f,
                0.142000f, 0.114000f, 0.217000f, 0.114000f,
                0.217000f, 0.172000f, 0.217000f, 0.216000f,
                0.146000f, 0.242000f, 0.042000f, 0.280000f,
                0.042000f, 0.352000f, 0.042000f, 0.400000f,
                0.078000f, 0.432000f, 0.116000f, 0.465000f,
                0.176000f, 0.465000f, 0.234000f, 0.465000f,
                0.270000f, 0.441000f, 0.254000f, 0.390000f,
                0.239000f, 0.400000f, 0.222000f, 0.405000f,
                0.198000f, 0.413000f, 0.174000f, 0.413000f,
                0.110000f, 0.413000f, 0.110000f, 0.361000f,
                0.110000f, 0.323000f, 0.183000f, 0.294000f,
                0.285000f, 0.256000f, 0.285000f, 0.178000f,
                0.285000f, 0.061000f, 0.141000f, 0.061000f,
                0.078000f, 0.061000f, 0.032000f, 0.089000f,
                0.049000f, 0.141000f
            };

        private static readonly byte[] MyriadProGlyph116Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph116Coordinates =
            {
                0.143000f, 0.550000f, 0.143000f, 0.457000f,
                0.244000f, 0.457000f, 0.244000f, 0.404000f,
                0.143000f, 0.404000f, 0.143000f, 0.195000f,
                0.143000f, 0.120000f, 0.196000f, 0.120000f,
                0.221000f, 0.120000f, 0.236000f, 0.125000f,
                0.240000f, 0.071000f, 0.212000f, 0.061000f,
                0.177000f, 0.061000f, 0.128000f, 0.061000f,
                0.101000f, 0.091000f, 0.074000f, 0.122000f,
                0.074000f, 0.193000f, 0.074000f, 0.404000f,
                0.014000f, 0.404000f, 0.014000f, 0.457000f,
                0.074000f, 0.457000f, 0.074000f, 0.529000f,
                0.143000f, 0.550000f
            };

        private static readonly byte[] MyriadProGlyph117Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph117Coordinates =
            {
                0.382000f, 0.177000f, 0.382000f, 0.111000f,
                0.386000f, 0.070000f, 0.323000f, 0.070000f,
                0.319000f, 0.133000f, 0.318000f, 0.133000f,
                0.301000f, 0.105000f, 0.273000f, 0.086000f,
                0.236000f, 0.061000f, 0.190000f, 0.061000f,
                0.135000f, 0.061000f, 0.100000f, 0.096000f,
                0.056000f, 0.139000f, 0.056000f, 0.231000f,
                0.056000f, 0.457000f, 0.126000f, 0.457000f,
                0.126000f, 0.244000f, 0.126000f, 0.120000f,
                0.213000f, 0.120000f, 0.246000f, 0.120000f,
                0.272000f, 0.140000f, 0.295000f, 0.158000f,
                0.306000f, 0.185000f, 0.312000f, 0.200000f,
                0.312000f, 0.221000f, 0.312000f, 0.457000f,
                0.382000f, 0.457000f, 0.382000f, 0.177000f
            };

        private static readonly byte[] MyriadProGlyph118Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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

        private static readonly float[] MyriadProGlyph118Coordinates =
            {
                0.085000f, 0.457000f, 0.161000f, 0.241000f,
                0.182000f, 0.182000f, 0.192000f, 0.141000f,
                0.195000f, 0.141000f, 0.201000f, 0.162000f,
                0.210000f, 0.189000f, 0.216000f, 0.208000f,
                0.228000f, 0.241000f, 0.303000f, 0.457000f,
                0.376000f, 0.457000f, 0.224000f, 0.070000f,
                0.157000f, 0.070000f, 0.010000f, 0.457000f,
                0.085000f, 0.457000f
            };

        private static readonly byte[] MyriadProGlyph119Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph119Coordinates =
            {
                0.086000f, 0.457000f, 0.138000f, 0.261000f,
                0.153000f, 0.198000f, 0.161000f, 0.163000f,
                0.166000f, 0.137000f, 0.168000f, 0.137000f,
                0.174000f, 0.164000f, 0.184000f, 0.198000f,
                0.198000f, 0.244000f, 0.266000f, 0.457000f,
                0.325000f, 0.457000f, 0.385000f, 0.264000f,
                0.407000f, 0.194000f, 0.420000f, 0.137000f,
                0.422000f, 0.137000f, 0.426000f, 0.165000f,
                0.434000f, 0.198000f, 0.441000f, 0.225000f,
                0.452000f, 0.263000f, 0.507000f, 0.457000f,
                0.576000f, 0.457000f, 0.452000f, 0.070000f,
                0.388000f, 0.070000f, 0.328000f, 0.255000f,
                0.317000f, 0.291000f, 0.310000f, 0.318000f,
                0.301000f, 0.350000f, 0.294000f, 0.382000f,
                0.292000f, 0.382000f, 0.286000f, 0.350000f,
                0.276000f, 0.316000f, 0.269000f, 0.290000f,
                0.257000f, 0.254000f, 0.195000f, 0.070000f,
                0.131000f, 0.070000f, 0.014000f, 0.457000f,
                0.086000f, 0.457000f
            };

        private static readonly byte[] MyriadProGlyph120Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph120Coordinates =
            {
                0.091000f, 0.457000f, 0.146000f, 0.374000f,
                0.165000f, 0.347000f, 0.186000f, 0.312000f,
                0.188000f, 0.312000f, 0.227000f, 0.375000f,
                0.280000f, 0.457000f, 0.357000f, 0.457000f,
                0.225000f, 0.270000f, 0.360000f, 0.070000f,
                0.281000f, 0.070000f, 0.224000f, 0.157000f,
                0.213000f, 0.173000f, 0.202000f, 0.191000f,
                0.182000f, 0.225000f, 0.180000f, 0.225000f,
                0.163000f, 0.193000f, 0.140000f, 0.157000f,
                0.084000f, 0.070000f, 0.006000f, 0.070000f,
                0.144000f, 0.268000f, 0.012000f, 0.457000f,
                0.091000f, 0.457000f
            };

        private static readonly byte[] MyriadProGlyph121Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph121Coordinates =
            {
                0.084000f, 0.457000f, 0.168000f, 0.229000f,
                0.182000f, 0.191000f, 0.193000f, 0.149000f,
                0.195000f, 0.149000f, 0.220000f, 0.230000f,
                0.297000f, 0.457000f, 0.371000f, 0.457000f,
                0.265000f, 0.181000f, 0.194000f, -0.007000f,
                0.133000f, -0.061000f, 0.109000f, -0.081000f,
                0.083000f, -0.093000f, 0.063000f, -0.103000f,
                0.046000f, -0.106000f, 0.029000f, -0.047000f,
                0.062000f, -0.037000f, 0.090000f, -0.013000f,
                0.126000f, 0.015000f, 0.149000f, 0.065000f,
                0.152000f, 0.072000f, 0.153000f, 0.075000f,
                0.155000f, 0.079000f, 0.155000f, 0.082000f,
                0.155000f, 0.088000f, 0.149000f, 0.101000f,
                0.007000f, 0.457000f, 0.084000f, 0.457000f
            };

        private static readonly byte[] MyriadProGlyph122Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph122Coordinates =
            {
                0.014000f, 0.111000f, 0.188000f, 0.339000f,
                0.240000f, 0.400000f, 0.240000f, 0.401000f,
                0.030000f, 0.401000f, 0.030000f, 0.457000f,
                0.324000f, 0.457000f, 0.324000f, 0.413000f,
                0.146000f, 0.182000f, 0.146000f, 0.181000f,
                0.145000f, 0.181000f, 0.127000f, 0.157000f,
                0.114000f, 0.140000f, 0.102000f, 0.128000f,
                0.102000f, 0.126000f, 0.328000f, 0.126000f,
                0.328000f, 0.070000f, 0.014000f, 0.070000f,
                0.014000f, 0.111000f
            };

        private static readonly byte[] MyriadProGlyph123Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph123Coordinates =
            {
                0.022000f, 0.321000f, 0.060000f, 0.321000f,
                0.075000f, 0.341000f, 0.086000f, 0.354000f,
                0.087000f, 0.381000f, 0.087000f, 0.396000f,
                0.085000f, 0.414000f, 0.078000f, 0.464000f,
                0.077000f, 0.474000f, 0.076000f, 0.481000f,
                0.074000f, 0.500000f, 0.074000f, 0.514000f,
                0.074000f, 0.619000f, 0.191000f, 0.619000f,
                0.207000f, 0.619000f, 0.207000f, 0.575000f,
                0.193000f, 0.575000f, 0.129000f, 0.574000f,
                0.129000f, 0.506000f, 0.129000f, 0.495000f,
                0.131000f, 0.478000f, 0.139000f, 0.420000f,
                0.141000f, 0.403000f, 0.141000f, 0.389000f,
                0.142000f, 0.318000f, 0.083000f, 0.302000f,
                0.083000f, 0.301000f, 0.141000f, 0.285000f,
                0.141000f, 0.213000f, 0.141000f, 0.199000f,
                0.139000f, 0.182000f, 0.131000f, 0.123000f,
                0.129000f, 0.106000f, 0.129000f, 0.094000f,
                0.129000f, 0.026000f, 0.193000f, 0.025000f,
                0.207000f, 0.025000f, 0.207000f, -0.019000f,
                0.190000f, -0.019000f, 0.137000f, -0.019000f,
                0.107000f, 0.005000f, 0.074000f, 0.033000f,
                0.074000f, 0.090000f, 0.074000f, 0.117000f,
                0.081000f, 0.156000f, 0.082000f, 0.159000f,
                0.082000f, 0.164000f, 0.085000f, 0.189000f,
                0.087000f, 0.207000f, 0.087000f, 0.221000f,
                0.087000f, 0.246000f, 0.076000f, 0.260000f,
                0.060000f, 0.281000f, 0.022000f, 0.281000f,
                0.022000f, 0.321000f
            };

        private static readonly byte[] MyriadProGlyph124Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph124Coordinates =
            {
                0.123000f, 0.670000f, 0.123000f, -0.130000f,
                0.069000f, -0.130000f, 0.069000f, 0.670000f,
                0.123000f, 0.670000f
            };

        private static readonly byte[] MyriadProGlyph125Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph125Coordinates =
            {
                0.205000f, 0.281000f, 0.167000f, 0.281000f,
                0.152000f, 0.260000f, 0.141000f, 0.246000f,
                0.140000f, 0.221000f, 0.140000f, 0.207000f,
                0.142000f, 0.189000f, 0.143000f, 0.182000f,
                0.144000f, 0.172000f, 0.151000f, 0.123000f,
                0.153000f, 0.105000f, 0.153000f, 0.090000f,
                0.153000f, 0.033000f, 0.119000f, 0.005000f,
                0.090000f, -0.019000f, 0.037000f, -0.019000f,
                0.020000f, -0.019000f, 0.020000f, 0.025000f,
                0.034000f, 0.025000f, 0.098000f, 0.026000f,
                0.098000f, 0.094000f, 0.098000f, 0.106000f,
                0.096000f, 0.123000f, 0.088000f, 0.182000f,
                0.086000f, 0.199000f, 0.086000f, 0.213000f,
                0.084000f, 0.285000f, 0.144000f, 0.301000f,
                0.144000f, 0.302000f, 0.086000f, 0.318000f,
                0.086000f, 0.389000f, 0.086000f, 0.403000f,
                0.088000f, 0.420000f, 0.088000f, 0.426000f,
                0.090000f, 0.435000f, 0.096000f, 0.478000f,
                0.098000f, 0.495000f, 0.098000f, 0.506000f,
                0.098000f, 0.574000f, 0.034000f, 0.575000f,
                0.020000f, 0.575000f, 0.020000f, 0.619000f,
                0.036000f, 0.619000f, 0.153000f, 0.619000f,
                0.153000f, 0.514000f, 0.153000f, 0.500000f,
                0.151000f, 0.481000f, 0.142000f, 0.414000f,
                0.140000f, 0.396000f, 0.140000f, 0.381000f,
                0.140000f, 0.354000f, 0.151000f, 0.341000f,
                0.166000f, 0.321000f, 0.205000f, 0.321000f,
                0.205000f, 0.281000f
            };

        private static readonly byte[] MyriadProGlyph126Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph126Coordinates =
            {
                0.041000f, 0.238000f, 0.039000f, 0.296000f,
                0.067000f, 0.329000f, 0.093000f, 0.359000f,
                0.136000f, 0.359000f, 0.173000f, 0.359000f,
                0.250000f, 0.323000f, 0.250000f, 0.323000f,
                0.251000f, 0.322000f, 0.264000f, 0.316000f,
                0.272000f, 0.312000f, 0.278000f, 0.310000f,
                0.292000f, 0.303000f, 0.303000f, 0.299000f,
                0.329000f, 0.289000f, 0.349000f, 0.289000f,
                0.391000f, 0.289000f, 0.392000f, 0.357000f,
                0.439000f, 0.357000f, 0.442000f, 0.295000f,
                0.414000f, 0.263000f, 0.389000f, 0.236000f,
                0.348000f, 0.236000f, 0.308000f, 0.236000f,
                0.232000f, 0.271000f, 0.205000f, 0.284000f,
                0.190000f, 0.291000f, 0.181000f, 0.296000f,
                0.155000f, 0.306000f, 0.136000f, 0.306000f,
                0.090000f, 0.306000f, 0.089000f, 0.238000f,
                0.041000f, 0.238000f
            };

        private static readonly byte[] MyriadProGlyph161Commands =
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph161Coordinates =
            {
                0.054000f, -0.086000f, 0.065000f, 0.296000f,
                0.119000f, 0.296000f, 0.131000f, -0.086000f,
                0.054000f, -0.086000f, 0.139000f, 0.410000f,
                0.139000f, 0.361000f, 0.092000f, 0.361000f,
                0.045000f, 0.361000f, 0.045000f, 0.410000f,
                0.045000f, 0.461000f, 0.093000f, 0.461000f,
                0.139000f, 0.461000f, 0.139000f, 0.410000f
            };

        private static readonly byte[] MyriadProGlyph162Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph162Coordinates =
            {
                0.215000f, 0.059000f, 0.215000f, 0.140000f,
                0.144000f, 0.148000f, 0.100000f, 0.196000f,
                0.054000f, 0.245000f, 0.054000f, 0.331000f,
                0.054000f, 0.409000f, 0.098000f, 0.463000f,
                0.142000f, 0.517000f, 0.215000f, 0.529000f,
                0.215000f, 0.609000f, 0.265000f, 0.609000f,
                0.265000f, 0.530000f, 0.315000f, 0.529000f,
                0.352000f, 0.510000f, 0.336000f, 0.457000f,
                0.321000f, 0.465000f, 0.303000f, 0.470000f,
                0.280000f, 0.477000f, 0.252000f, 0.477000f,
                0.195000f, 0.477000f, 0.159000f, 0.435000f,
                0.124000f, 0.394000f, 0.124000f, 0.333000f,
                0.124000f, 0.269000f, 0.161000f, 0.230000f,
                0.196000f, 0.193000f, 0.250000f, 0.193000f,
                0.279000f, 0.193000f, 0.305000f, 0.200000f,
                0.324000f, 0.205000f, 0.341000f, 0.213000f,
                0.353000f, 0.162000f, 0.340000f, 0.154000f,
                0.318000f, 0.148000f, 0.292000f, 0.141000f,
                0.265000f, 0.139000f, 0.265000f, 0.059000f,
                0.215000f, 0.059000f
            };

        private static readonly byte[] MyriadProGlyph163Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph163Coordinates =
            {
                0.045000f, 0.070000f, 0.045000f, 0.110000f,
                0.136000f, 0.156000f, 0.136000f, 0.250000f,
                0.136000f, 0.280000f, 0.132000f, 0.306000f,
                0.050000f, 0.306000f, 0.050000f, 0.357000f,
                0.124000f, 0.357000f, 0.121000f, 0.376000f,
                0.119000f, 0.387000f, 0.118000f, 0.397000f,
                0.115000f, 0.422000f, 0.115000f, 0.443000f,
                0.115000f, 0.513000f, 0.159000f, 0.556000f,
                0.202000f, 0.599000f, 0.269000f, 0.599000f,
                0.324000f, 0.599000f, 0.356000f, 0.579000f,
                0.341000f, 0.526000f, 0.312000f, 0.542000f,
                0.269000f, 0.542000f, 0.224000f, 0.542000f,
                0.202000f, 0.514000f, 0.182000f, 0.488000f,
                0.182000f, 0.442000f, 0.182000f, 0.419000f,
                0.184000f, 0.396000f, 0.191000f, 0.357000f,
                0.306000f, 0.357000f, 0.306000f, 0.306000f,
                0.197000f, 0.306000f, 0.199000f, 0.278000f,
                0.199000f, 0.261000f, 0.199000f, 0.236000f,
                0.194000f, 0.217000f, 0.181000f, 0.166000f,
                0.139000f, 0.130000f, 0.139000f, 0.129000f,
                0.377000f, 0.129000f, 0.377000f, 0.070000f,
                0.045000f, 0.070000f
            };

        private static readonly byte[] MyriadProGlyph164Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph164Coordinates =
            {
                0.297000f, 0.465000f, 0.354000f, 0.525000f,
                0.390000f, 0.489000f, 0.327000f, 0.432000f,
                0.355000f, 0.394000f, 0.355000f, 0.337000f,
                0.355000f, 0.277000f, 0.327000f, 0.240000f,
                0.387000f, 0.181000f, 0.352000f, 0.145000f,
                0.296000f, 0.206000f, 0.260000f, 0.173000f,
                0.203000f, 0.173000f, 0.146000f, 0.173000f,
                0.112000f, 0.205000f, 0.058000f, 0.145000f,
                0.024000f, 0.181000f, 0.081000f, 0.237000f,
                0.052000f, 0.277000f, 0.052000f, 0.333000f,
                0.052000f, 0.392000f, 0.083000f, 0.432000f,
                0.022000f, 0.489000f, 0.058000f, 0.525000f,
                0.112000f, 0.465000f, 0.150000f, 0.497000f,
                0.205000f, 0.497000f, 0.261000f, 0.497000f,
                0.297000f, 0.465000f, 0.134000f, 0.414000f,
                0.108000f, 0.382000f, 0.108000f, 0.334000f,
                0.108000f, 0.281000f, 0.140000f, 0.250000f,
                0.167000f, 0.223000f, 0.203000f, 0.223000f,
                0.241000f, 0.223000f, 0.267000f, 0.249000f,
                0.298000f, 0.280000f, 0.298000f, 0.337000f,
                0.298000f, 0.382000f, 0.274000f, 0.413000f,
                0.247000f, 0.447000f, 0.203000f, 0.447000f,
                0.160000f, 0.447000f, 0.134000f, 0.414000f
            };

        private static readonly byte[] MyriadProGlyph165Commands =
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph165Coordinates =
            {
                0.167000f, 0.070000f, 0.167000f, 0.211000f,
                0.043000f, 0.211000f, 0.043000f, 0.250000f,
                0.167000f, 0.250000f, 0.167000f, 0.309000f,
                0.043000f, 0.309000f, 0.043000f, 0.348000f,
                0.148000f, 0.348000f, 0.013000f, 0.590000f,
                0.088000f, 0.590000f, 0.171000f, 0.425000f,
                0.191000f, 0.385000f, 0.203000f, 0.353000f,
                0.206000f, 0.353000f, 0.219000f, 0.389000f,
                0.238000f, 0.427000f, 0.324000f, 0.590000f,
                0.398000f, 0.590000f, 0.255000f, 0.348000f,
                0.359000f, 0.348000f, 0.359000f, 0.309000f,
                0.234000f, 0.309000f, 0.234000f, 0.250000f,
                0.359000f, 0.250000f, 0.359000f, 0.211000f,
                0.234000f, 0.211000f, 0.234000f, 0.070000f,
                0.167000f, 0.070000f
            };

        private static readonly byte[] MyriadProGlyph166Commands =
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

        private static readonly float[] MyriadProGlyph166Coordinates =
            {
                0.123000f, 0.209000f, 0.123000f, -0.071000f,
                0.069000f, -0.071000f, 0.069000f, 0.209000f,
                0.123000f, 0.209000f, 0.123000f, 0.609000f,
                0.123000f, 0.329000f, 0.069000f, 0.329000f,
                0.069000f, 0.609000f, 0.123000f, 0.609000f
            };

        private static readonly byte[] MyriadProGlyph167Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph167Coordinates =
            {
                0.189000f, 0.275000f, 0.243000f, 0.255000f,
                0.267000f, 0.245000f, 0.280000f, 0.237000f,
                0.310000f, 0.259000f, 0.310000f, 0.298000f,
                0.310000f, 0.347000f, 0.239000f, 0.373000f,
                0.231000f, 0.375000f, 0.214000f, 0.382000f,
                0.197000f, 0.388000f, 0.188000f, 0.392000f,
                0.157000f, 0.403000f, 0.141000f, 0.413000f,
                0.105000f, 0.388000f, 0.105000f, 0.350000f,
                0.105000f, 0.306000f, 0.189000f, 0.275000f,
                0.317000f, 0.545000f, 0.299000f, 0.556000f,
                0.278000f, 0.562000f, 0.251000f, 0.570000f,
                0.221000f, 0.570000f, 0.138000f, 0.570000f,
                0.138000f, 0.511000f, 0.138000f, 0.483000f,
                0.166000f, 0.465000f, 0.178000f, 0.457000f,
                0.197000f, 0.449000f, 0.211000f, 0.443000f,
                0.238000f, 0.434000f, 0.269000f, 0.424000f,
                0.290000f, 0.415000f, 0.314000f, 0.403000f,
                0.331000f, 0.389000f, 0.368000f, 0.358000f,
                0.368000f, 0.309000f, 0.368000f, 0.251000f,
                0.317000f, 0.212000f, 0.328000f, 0.201000f,
                0.337000f, 0.184000f, 0.347000f, 0.163000f,
                0.347000f, 0.141000f, 0.347000f, 0.082000f,
                0.299000f, 0.049000f, 0.257000f, 0.021000f,
                0.195000f, 0.021000f, 0.115000f, 0.021000f,
                0.069000f, 0.054000f, 0.089000f, 0.100000f,
                0.106000f, 0.087000f, 0.131000f, 0.079000f,
                0.162000f, 0.068000f, 0.195000f, 0.068000f,
                0.284000f, 0.068000f, 0.284000f, 0.133000f,
                0.284000f, 0.182000f, 0.186000f, 0.217000f,
                0.152000f, 0.228000f, 0.130000f, 0.238000f,
                0.103000f, 0.251000f, 0.086000f, 0.264000f,
                0.047000f, 0.295000f, 0.047000f, 0.342000f,
                0.047000f, 0.398000f, 0.106000f, 0.437000f,
                0.077000f, 0.458000f, 0.077000f, 0.503000f,
                0.077000f, 0.555000f, 0.119000f, 0.586000f,
                0.160000f, 0.617000f, 0.224000f, 0.617000f,
                0.287000f, 0.617000f, 0.334000f, 0.590000f,
                0.317000f, 0.545000f
            };

        private static readonly byte[] MyriadProGlyph168Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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

        private static readonly float[] MyriadProGlyph168Coordinates =
            {
                0.006000f, 0.567000f, 0.006000f, 0.608000f,
                0.047000f, 0.608000f, 0.085000f, 0.608000f,
                0.085000f, 0.567000f, 0.085000f, 0.526000f,
                0.045000f, 0.526000f, 0.006000f, 0.526000f,
                0.006000f, 0.567000f, 0.155000f, 0.567000f,
                0.155000f, 0.608000f, 0.195000f, 0.608000f,
                0.234000f, 0.608000f, 0.234000f, 0.567000f,
                0.234000f, 0.526000f, 0.194000f, 0.526000f,
                0.155000f, 0.526000f, 0.155000f, 0.567000f
            };

        private static readonly byte[] MyriadProGlyph169Commands =
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph169Coordinates =
            {
                0.443000f, 0.516000f, 0.513000f, 0.445000f,
                0.513000f, 0.342000f, 0.513000f, 0.239000f,
                0.443000f, 0.167000f, 0.373000f, 0.094000f,
                0.272000f, 0.094000f, 0.170000f, 0.094000f,
                0.100000f, 0.167000f, 0.029000f, 0.239000f,
                0.029000f, 0.342000f, 0.029000f, 0.445000f,
                0.100000f, 0.516000f, 0.171000f, 0.589000f,
                0.273000f, 0.589000f, 0.373000f, 0.589000f,
                0.443000f, 0.516000f, 0.127000f, 0.493000f,
                0.069000f, 0.431000f, 0.069000f, 0.340000f,
                0.069000f, 0.250000f, 0.127000f, 0.189000f,
                0.186000f, 0.127000f, 0.272000f, 0.127000f,
                0.357000f, 0.126000f, 0.415000f, 0.188000f,
                0.473000f, 0.251000f, 0.473000f, 0.342000f,
                0.473000f, 0.432000f, 0.415000f, 0.494000f,
                0.356000f, 0.556000f, 0.271000f, 0.556000f,
                0.186000f, 0.556000f, 0.127000f, 0.493000f,
                0.370000f, 0.433000f, 0.365000f, 0.436000f,
                0.359000f, 0.439000f, 0.350000f, 0.442000f,
                0.341000f, 0.445000f, 0.317000f, 0.452000f,
                0.292000f, 0.452000f, 0.238000f, 0.452000f,
                0.208000f, 0.420000f, 0.180000f, 0.390000f,
                0.180000f, 0.340000f, 0.180000f, 0.291000f,
                0.209000f, 0.260000f, 0.240000f, 0.227000f,
                0.293000f, 0.227000f, 0.342000f, 0.227000f,
                0.374000f, 0.248000f, 0.383000f, 0.217000f,
                0.346000f, 0.193000f, 0.285000f, 0.193000f,
                0.217000f, 0.193000f, 0.177000f, 0.235000f,
                0.139000f, 0.275000f, 0.139000f, 0.337000f,
                0.139000f, 0.404000f, 0.185000f, 0.446000f,
                0.228000f, 0.486000f, 0.291000f, 0.486000f,
                0.354000f, 0.486000f, 0.379000f, 0.465000f,
                0.370000f, 0.433000f
            };

        private static readonly byte[] MyriadProGlyph170Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph170Coordinates =
            {
                0.196000f, 0.283000f, 0.192000f, 0.317000f,
                0.190000f, 0.317000f, 0.177000f, 0.300000f,
                0.157000f, 0.291000f, 0.135000f, 0.279000f,
                0.108000f, 0.279000f, 0.026000f, 0.279000f,
                0.026000f, 0.356000f, 0.026000f, 0.450000f,
                0.187000f, 0.446000f, 0.187000f, 0.454000f,
                0.187000f, 0.461000f, 0.185000f, 0.467000f,
                0.182000f, 0.477000f, 0.177000f, 0.484000f,
                0.161000f, 0.504000f, 0.127000f, 0.504000f,
                0.087000f, 0.504000f, 0.059000f, 0.483000f,
                0.046000f, 0.517000f, 0.082000f, 0.543000f,
                0.137000f, 0.543000f, 0.193000f, 0.543000f,
                0.218000f, 0.509000f, 0.239000f, 0.481000f,
                0.239000f, 0.431000f, 0.239000f, 0.345000f,
                0.239000f, 0.315000f, 0.243000f, 0.283000f,
                0.196000f, 0.283000f, 0.188000f, 0.412000f,
                0.142000f, 0.413000f, 0.114000f, 0.403000f,
                0.079000f, 0.390000f, 0.079000f, 0.359000f,
                0.079000f, 0.317000f, 0.125000f, 0.317000f,
                0.162000f, 0.317000f, 0.180000f, 0.347000f,
                0.183000f, 0.352000f, 0.186000f, 0.358000f,
                0.188000f, 0.364000f, 0.188000f, 0.368000f,
                0.188000f, 0.412000f
            };

        private static readonly byte[] MyriadProGlyph171Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph171Coordinates =
            {
                0.079000f, 0.272000f, 0.186000f, 0.125000f,
                0.129000f, 0.125000f, 0.023000f, 0.272000f,
                0.129000f, 0.419000f, 0.185000f, 0.419000f,
                0.079000f, 0.272000f, 0.210000f, 0.272000f,
                0.317000f, 0.125000f, 0.260000f, 0.125000f,
                0.154000f, 0.272000f, 0.260000f, 0.419000f,
                0.317000f, 0.419000f, 0.210000f, 0.272000f
            };

        private static readonly byte[] MyriadProGlyph172Commands =
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

        private static readonly float[] MyriadProGlyph172Coordinates =
            {
                0.445000f, 0.389000f, 0.445000f, 0.167000f,
                0.394000f, 0.167000f, 0.394000f, 0.341000f,
                0.032000f, 0.341000f, 0.032000f, 0.389000f,
                0.445000f, 0.389000f
            };

        private static readonly byte[] MyriadProGlyph173Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph173Coordinates =
            {
                0.222000f, 0.312000f, 0.222000f, 0.261000f,
                0.024000f, 0.261000f, 0.024000f, 0.312000f,
                0.222000f, 0.312000f
            };

        private static readonly byte[] MyriadProGlyph174Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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

        private static readonly float[] MyriadProGlyph174Coordinates =
            {
                0.147000f, 0.417000f, 0.117000f, 0.417000f,
                0.117000f, 0.549000f, 0.122000f, 0.549000f,
                0.125000f, 0.550000f, 0.127000f, 0.550000f,
                0.133000f, 0.551000f, 0.139000f, 0.551000f,
                0.153000f, 0.553000f, 0.167000f, 0.553000f,
                0.198000f, 0.553000f, 0.212000f, 0.542000f,
                0.226000f, 0.533000f, 0.226000f, 0.514000f,
                0.226000f, 0.492000f, 0.199000f, 0.483000f,
                0.199000f, 0.481000f, 0.216000f, 0.476000f,
                0.222000f, 0.449000f, 0.224000f, 0.436000f,
                0.227000f, 0.428000f, 0.228000f, 0.424000f,
                0.229000f, 0.422000f, 0.231000f, 0.417000f,
                0.199000f, 0.417000f, 0.197000f, 0.421000f,
                0.194000f, 0.429000f, 0.193000f, 0.433000f,
                0.192000f, 0.438000f, 0.190000f, 0.444000f,
                0.189000f, 0.448000f, 0.189000f, 0.449000f,
                0.185000f, 0.469000f, 0.162000f, 0.469000f,
                0.147000f, 0.469000f, 0.147000f, 0.417000f,
                0.148000f, 0.491000f, 0.163000f, 0.491000f,
                0.193000f, 0.491000f, 0.193000f, 0.510000f,
                0.193000f, 0.530000f, 0.165000f, 0.530000f,
                0.159000f, 0.530000f, 0.155000f, 0.530000f,
                0.151000f, 0.529000f, 0.148000f, 0.529000f,
                0.148000f, 0.491000f, 0.264000f, 0.579000f,
                0.303000f, 0.541000f, 0.303000f, 0.485000f,
                0.303000f, 0.430000f, 0.264000f, 0.392000f,
                0.225000f, 0.353000f, 0.168000f, 0.353000f,
                0.112000f, 0.353000f, 0.072000f, 0.392000f,
                0.033000f, 0.430000f, 0.033000f, 0.485000f,
                0.033000f, 0.541000f, 0.073000f, 0.579000f,
                0.112000f, 0.617000f, 0.169000f, 0.617000f,
                0.225000f, 0.617000f, 0.264000f, 0.579000f,
                0.096000f, 0.559000f, 0.067000f, 0.529000f,
                0.067000f, 0.485000f, 0.067000f, 0.441000f,
                0.096000f, 0.411000f, 0.125000f, 0.381000f,
                0.169000f, 0.381000f, 0.211000f, 0.380000f,
                0.240000f, 0.411000f, 0.269000f, 0.441000f,
                0.269000f, 0.485000f, 0.269000f, 0.529000f,
                0.240000f, 0.559000f, 0.211000f, 0.590000f,
                0.167000f, 0.590000f, 0.125000f, 0.590000f,
                0.096000f, 0.559000f
            };

        private static readonly byte[] MyriadProGlyph175Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph175Coordinates =
            {
                0.210000f, 0.585000f, 0.210000f, 0.539000f,
                0.030000f, 0.539000f, 0.030000f, 0.585000f,
                0.210000f, 0.585000f
            };

        private static readonly byte[] MyriadProGlyph176Commands =
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph176Coordinates =
            {
                0.207000f, 0.587000f, 0.235000f, 0.558000f,
                0.235000f, 0.515000f, 0.235000f, 0.468000f,
                0.202000f, 0.437000f, 0.171000f, 0.408000f,
                0.128000f, 0.408000f, 0.082000f, 0.408000f,
                0.052000f, 0.438000f, 0.023000f, 0.468000f,
                0.023000f, 0.511000f, 0.023000f, 0.557000f,
                0.054000f, 0.588000f, 0.085000f, 0.619000f,
                0.130000f, 0.619000f, 0.178000f, 0.619000f,
                0.207000f, 0.587000f, 0.082000f, 0.559000f,
                0.066000f, 0.539000f, 0.066000f, 0.511000f,
                0.066000f, 0.445000f, 0.129000f, 0.445000f,
                0.192000f, 0.445000f, 0.192000f, 0.514000f,
                0.192000f, 0.540000f, 0.177000f, 0.559000f,
                0.160000f, 0.581000f, 0.128000f, 0.581000f,
                0.099000f, 0.581000f, 0.082000f, 0.559000f
            };

        private static readonly byte[] MyriadProGlyph177Commands =
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph177Coordinates =
            {
                0.264000f, 0.527000f, 0.264000f, 0.372000f,
                0.445000f, 0.372000f, 0.445000f, 0.324000f,
                0.264000f, 0.324000f, 0.264000f, 0.164000f,
                0.213000f, 0.164000f, 0.213000f, 0.324000f,
                0.032000f, 0.324000f, 0.032000f, 0.372000f,
                0.213000f, 0.372000f, 0.213000f, 0.527000f,
                0.264000f, 0.527000f, 0.445000f, 0.118000f,
                0.445000f, 0.070000f, 0.032000f, 0.070000f,
                0.032000f, 0.118000f, 0.445000f, 0.118000f
            };

        private static readonly byte[] MyriadProGlyph178Commands =
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

        private static readonly float[] MyriadProGlyph178Coordinates =
            {
                0.010000f, 0.454000f, 0.060000f, 0.501000f,
                0.161000f, 0.593000f, 0.161000f, 0.640000f,
                0.161000f, 0.695000f, 0.100000f, 0.695000f,
                0.081000f, 0.695000f, 0.062000f, 0.687000f,
                0.047000f, 0.681000f, 0.033000f, 0.670000f,
                0.016000f, 0.707000f, 0.057000f, 0.740000f,
                0.115000f, 0.740000f, 0.167000f, 0.740000f,
                0.196000f, 0.711000f, 0.220000f, 0.686000f,
                0.220000f, 0.650000f, 0.220000f, 0.609000f,
                0.190000f, 0.569000f, 0.177000f, 0.552000f,
                0.156000f, 0.531000f, 0.141000f, 0.516000f,
                0.114000f, 0.493000f, 0.090000f, 0.470000f,
                0.090000f, 0.469000f, 0.226000f, 0.469000f,
                0.226000f, 0.425000f, 0.010000f, 0.425000f,
                0.010000f, 0.454000f
            };

        private static readonly byte[] MyriadProGlyph179Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph179Coordinates =
            {
                0.022000f, 0.716000f, 0.038000f, 0.726000f,
                0.060000f, 0.733000f, 0.087000f, 0.741000f,
                0.114000f, 0.741000f, 0.162000f, 0.741000f,
                0.189000f, 0.717000f, 0.212000f, 0.697000f,
                0.212000f, 0.665000f, 0.212000f, 0.614000f,
                0.150000f, 0.593000f, 0.150000f, 0.591000f,
                0.224000f, 0.580000f, 0.224000f, 0.513000f,
                0.224000f, 0.475000f, 0.192000f, 0.448000f,
                0.157000f, 0.420000f, 0.098000f, 0.420000f,
                0.040000f, 0.420000f, 0.006000f, 0.442000f,
                0.020000f, 0.482000f, 0.032000f, 0.475000f,
                0.051000f, 0.469000f, 0.075000f, 0.461000f,
                0.095000f, 0.461000f, 0.129000f, 0.461000f,
                0.149000f, 0.479000f, 0.166000f, 0.494000f,
                0.165000f, 0.515000f, 0.165000f, 0.544000f,
                0.139000f, 0.559000f, 0.116000f, 0.572000f,
                0.080000f, 0.572000f, 0.059000f, 0.572000f,
                0.059000f, 0.609000f, 0.081000f, 0.609000f,
                0.108000f, 0.609000f, 0.129000f, 0.620000f,
                0.154000f, 0.634000f, 0.154000f, 0.659000f,
                0.154000f, 0.699000f, 0.104000f, 0.699000f,
                0.084000f, 0.699000f, 0.064000f, 0.692000f,
                0.048000f, 0.686000f, 0.036000f, 0.677000f,
                0.022000f, 0.716000f
            };

        private static readonly byte[] MyriadProGlyph180Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph180Coordinates =
            {
                0.228000f, 0.625000f, 0.131000f, 0.510000f,
                0.081000f, 0.510000f, 0.151000f, 0.625000f,
                0.228000f, 0.625000f
            };

        private static readonly byte[] MyriadProGlyph181Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph181Coordinates =
            {
                0.320000f, 0.130000f, 0.305000f, 0.103000f,
                0.280000f, 0.085000f, 0.248000f, 0.063000f,
                0.208000f, 0.063000f, 0.148000f, 0.063000f,
                0.124000f, 0.105000f, 0.124000f, 0.058000f,
                0.124000f, 0.016000f, 0.125000f, -0.019000f,
                0.128000f, -0.067000f, 0.132000f, -0.088000f,
                0.069000f, -0.088000f, 0.063000f, -0.071000f,
                0.061000f, -0.031000f, 0.058000f, 0.005000f,
                0.058000f, 0.055000f, 0.058000f, 0.457000f,
                0.128000f, 0.457000f, 0.128000f, 0.229000f,
                0.128000f, 0.180000f, 0.149000f, 0.151000f,
                0.171000f, 0.119000f, 0.216000f, 0.119000f,
                0.248000f, 0.119000f, 0.274000f, 0.139000f,
                0.297000f, 0.157000f, 0.308000f, 0.184000f,
                0.314000f, 0.200000f, 0.314000f, 0.221000f,
                0.314000f, 0.457000f, 0.384000f, 0.457000f,
                0.384000f, 0.177000f, 0.384000f, 0.118000f,
                0.421000f, 0.116000f, 0.416000f, 0.065000f,
                0.404000f, 0.061000f, 0.391000f, 0.061000f,
                0.331000f, 0.061000f, 0.322000f, 0.130000f,
                0.320000f, 0.130000f
            };

        private static readonly byte[] MyriadProGlyph182Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph182Coordinates =
            {
                0.185000f, 0.031000f, 0.185000f, 0.282000f,
                0.179000f, 0.282000f, 0.125000f, 0.282000f,
                0.080000f, 0.320000f, 0.028000f, 0.363000f,
                0.027000f, 0.434000f, 0.027000f, 0.468000f,
                0.037000f, 0.497000f, 0.048000f, 0.530000f,
                0.071000f, 0.554000f, 0.098000f, 0.581000f,
                0.139000f, 0.595000f, 0.185000f, 0.611000f,
                0.247000f, 0.611000f, 0.309000f, 0.611000f,
                0.341000f, 0.605000f, 0.341000f, 0.031000f,
                0.291000f, 0.031000f, 0.291000f, 0.563000f,
                0.235000f, 0.563000f, 0.235000f, 0.031000f,
                0.185000f, 0.031000f
            };

        private static readonly byte[] MyriadProGlyph183Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph183Coordinates =
            {
                0.035000f, 0.280000f, 0.035000f, 0.330000f,
                0.083000f, 0.330000f, 0.130000f, 0.330000f,
                0.130000f, 0.280000f, 0.130000f, 0.230000f,
                0.081000f, 0.230000f, 0.035000f, 0.230000f,
                0.035000f, 0.280000f
            };

        private static readonly byte[] MyriadProGlyph184Commands =
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph184Coordinates =
            {
                0.152000f, 0.073000f, 0.125000f, 0.030000f,
                0.181000f, 0.024000f, 0.181000f, -0.025000f,
                0.181000f, -0.058000f, 0.156000f, -0.075000f,
                0.134000f, -0.090000f, 0.097000f, -0.090000f,
                0.066000f, -0.090000f, 0.043000f, -0.076000f,
                0.055000f, -0.042000f, 0.076000f, -0.053000f,
                0.098000f, -0.053000f, 0.134000f, -0.053000f,
                0.133000f, -0.028000f, 0.133000f, 0.000000f,
                0.070000f, 0.005000f, 0.108000f, 0.073000f,
                0.152000f, 0.073000f
            };

        private static readonly byte[] MyriadProGlyph185Commands =
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

        private static readonly float[] MyriadProGlyph185Coordinates =
            {
                0.086000f, 0.425000f, 0.086000f, 0.687000f,
                0.084000f, 0.687000f, 0.027000f, 0.659000f,
                0.018000f, 0.701000f, 0.093000f, 0.737000f,
                0.142000f, 0.737000f, 0.142000f, 0.425000f,
                0.086000f, 0.425000f
            };

        private static readonly byte[] MyriadProGlyph186Commands =
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph186Coordinates =
            {
                0.235000f, 0.506000f, 0.269000f, 0.470000f,
                0.269000f, 0.413000f, 0.269000f, 0.348000f,
                0.228000f, 0.311000f, 0.192000f, 0.279000f,
                0.141000f, 0.279000f, 0.087000f, 0.279000f,
                0.051000f, 0.314000f, 0.014000f, 0.351000f,
                0.014000f, 0.409000f, 0.014000f, 0.469000f,
                0.053000f, 0.507000f, 0.089000f, 0.543000f,
                0.144000f, 0.543000f, 0.200000f, 0.543000f,
                0.235000f, 0.506000f, 0.085000f, 0.472000f,
                0.068000f, 0.446000f, 0.068000f, 0.409000f,
                0.068000f, 0.371000f, 0.090000f, 0.345000f,
                0.112000f, 0.319000f, 0.142000f, 0.319000f,
                0.216000f, 0.319000f, 0.216000f, 0.411000f,
                0.216000f, 0.446000f, 0.198000f, 0.472000f,
                0.177000f, 0.503000f, 0.140000f, 0.503000f,
                0.105000f, 0.503000f, 0.085000f, 0.472000f
            };

        private static readonly byte[] MyriadProGlyph187Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph187Coordinates =
            {
                0.019000f, 0.419000f, 0.075000f, 0.419000f,
                0.181000f, 0.272000f, 0.075000f, 0.125000f,
                0.019000f, 0.125000f, 0.125000f, 0.272000f,
                0.019000f, 0.419000f, 0.149000f, 0.419000f,
                0.205000f, 0.419000f, 0.312000f, 0.272000f,
                0.205000f, 0.125000f, 0.149000f, 0.125000f,
                0.256000f, 0.272000f, 0.149000f, 0.419000f
            };

        private static readonly byte[] MyriadProGlyph188Commands =
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph188Coordinates =
            {
                0.102000f, 0.283000f, 0.102000f, 0.546000f,
                0.100000f, 0.546000f, 0.043000f, 0.518000f,
                0.034000f, 0.560000f, 0.109000f, 0.595000f,
                0.158000f, 0.595000f, 0.158000f, 0.283000f,
                0.102000f, 0.283000f, 0.110000f, 0.061000f,
                0.414000f, 0.599000f, 0.459000f, 0.599000f,
                0.156000f, 0.061000f, 0.110000f, 0.061000f,
                0.477000f, 0.070000f, 0.477000f, 0.153000f,
                0.317000f, 0.153000f, 0.317000f, 0.184000f,
                0.472000f, 0.386000f, 0.530000f, 0.386000f,
                0.530000f, 0.192000f, 0.578000f, 0.192000f,
                0.578000f, 0.153000f, 0.530000f, 0.153000f,
                0.530000f, 0.070000f, 0.477000f, 0.070000f,
                0.477000f, 0.286000f, 0.477000f, 0.298000f,
                0.478000f, 0.313000f, 0.480000f, 0.337000f,
                0.478000f, 0.337000f, 0.452000f, 0.293000f,
                0.375000f, 0.193000f, 0.376000f, 0.192000f,
                0.477000f, 0.192000f, 0.477000f, 0.286000f
            };

        private static readonly byte[] MyriadProGlyph189Commands =
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
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph189Coordinates =
            {
                0.091000f, 0.283000f, 0.091000f, 0.546000f,
                0.089000f, 0.546000f, 0.032000f, 0.518000f,
                0.023000f, 0.560000f, 0.098000f, 0.595000f,
                0.147000f, 0.595000f, 0.147000f, 0.283000f,
                0.091000f, 0.283000f, 0.095000f, 0.061000f,
                0.398000f, 0.599000f, 0.443000f, 0.599000f,
                0.140000f, 0.061000f, 0.095000f, 0.061000f,
                0.352000f, 0.100000f, 0.402000f, 0.146000f,
                0.457000f, 0.197000f, 0.478000f, 0.224000f,
                0.503000f, 0.257000f, 0.503000f, 0.285000f,
                0.503000f, 0.341000f, 0.442000f, 0.341000f,
                0.423000f, 0.341000f, 0.404000f, 0.333000f,
                0.389000f, 0.327000f, 0.375000f, 0.317000f,
                0.358000f, 0.353000f, 0.398000f, 0.386000f,
                0.457000f, 0.386000f, 0.509000f, 0.386000f,
                0.538000f, 0.357000f, 0.562000f, 0.333000f,
                0.562000f, 0.297000f, 0.562000f, 0.255000f,
                0.532000f, 0.215000f, 0.519000f, 0.198000f,
                0.498000f, 0.177000f, 0.484000f, 0.163000f,
                0.456000f, 0.138000f, 0.432000f, 0.116000f,
                0.432000f, 0.114000f, 0.568000f, 0.114000f,
                0.568000f, 0.070000f, 0.352000f, 0.070000f,
                0.352000f, 0.100000f
            };

        private static readonly byte[] MyriadProGlyph190Commands =
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph190Coordinates =
            {
                0.039000f, 0.573000f, 0.076000f, 0.599000f,
                0.130000f, 0.599000f, 0.179000f, 0.599000f,
                0.206000f, 0.576000f, 0.229000f, 0.555000f,
                0.229000f, 0.524000f, 0.229000f, 0.472000f,
                0.168000f, 0.452000f, 0.168000f, 0.450000f,
                0.242000f, 0.439000f, 0.242000f, 0.373000f,
                0.242000f, 0.333000f, 0.210000f, 0.307000f,
                0.175000f, 0.279000f, 0.116000f, 0.279000f,
                0.058000f, 0.279000f, 0.024000f, 0.301000f,
                0.038000f, 0.341000f, 0.069000f, 0.321000f,
                0.113000f, 0.321000f, 0.147000f, 0.321000f,
                0.167000f, 0.338000f, 0.184000f, 0.353000f,
                0.183000f, 0.374000f, 0.183000f, 0.403000f,
                0.157000f, 0.418000f, 0.134000f, 0.431000f,
                0.098000f, 0.430000f, 0.077000f, 0.430000f,
                0.077000f, 0.467000f, 0.098000f, 0.467000f,
                0.125000f, 0.467000f, 0.146000f, 0.478000f,
                0.171000f, 0.492000f, 0.171000f, 0.517000f,
                0.171000f, 0.557000f, 0.120000f, 0.557000f,
                0.101000f, 0.557000f, 0.080000f, 0.550000f,
                0.065000f, 0.544000f, 0.053000f, 0.536000f,
                0.039000f, 0.573000f, 0.140000f, 0.061000f,
                0.444000f, 0.599000f, 0.489000f, 0.599000f,
                0.186000f, 0.061000f, 0.140000f, 0.061000f,
                0.486000f, 0.070000f, 0.486000f, 0.153000f,
                0.326000f, 0.153000f, 0.326000f, 0.184000f,
                0.481000f, 0.386000f, 0.539000f, 0.386000f,
                0.539000f, 0.192000f, 0.587000f, 0.192000f,
                0.587000f, 0.153000f, 0.539000f, 0.153000f,
                0.539000f, 0.070000f, 0.486000f, 0.070000f,
                0.486000f, 0.286000f, 0.486000f, 0.298000f,
                0.487000f, 0.313000f, 0.489000f, 0.337000f,
                0.487000f, 0.337000f, 0.478000f, 0.321000f,
                0.477000f, 0.319000f, 0.477000f, 0.318000f,
                0.475000f, 0.315000f, 0.473000f, 0.313000f,
                0.466000f, 0.300000f, 0.461000f, 0.293000f,
                0.383000f, 0.193000f, 0.384000f, 0.192000f,
                0.486000f, 0.192000f, 0.486000f, 0.286000f
            };

        private static readonly byte[] MyriadProGlyph191Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph191Coordinates =
            {
                0.237000f, 0.410000f, 0.237000f, 0.361000f,
                0.190000f, 0.361000f, 0.142000f, 0.361000f,
                0.142000f, 0.410000f, 0.142000f, 0.461000f,
                0.190000f, 0.461000f, 0.237000f, 0.461000f,
                0.237000f, 0.410000f, 0.219000f, 0.299000f,
                0.222000f, 0.278000f, 0.229000f, 0.209000f,
                0.172000f, 0.139000f, 0.116000f, 0.073000f,
                0.116000f, 0.029000f, 0.116000f, -0.039000f,
                0.192000f, -0.039000f, 0.238000f, -0.039000f,
                0.274000f, -0.015000f, 0.292000f, -0.065000f,
                0.245000f, -0.097000f, 0.178000f, -0.097000f,
                0.112000f, -0.097000f, 0.076000f, -0.061000f,
                0.044000f, -0.029000f, 0.044000f, 0.021000f,
                0.044000f, 0.058000f, 0.064000f, 0.094000f,
                0.073000f, 0.109000f, 0.086000f, 0.126000f,
                0.096000f, 0.140000f, 0.114000f, 0.160000f,
                0.163000f, 0.219000f, 0.158000f, 0.278000f,
                0.158000f, 0.299000f, 0.219000f, 0.299000f
            };

        private static readonly byte[] MyriadProGlyph1025Commands =
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

        private static readonly float[] MyriadProGlyph1025Coordinates =
            {
                0.339000f, 0.323000f, 0.130000f, 0.323000f,
                0.130000f, 0.129000f, 0.364000f, 0.129000f,
                0.364000f, 0.070000f, 0.060000f, 0.070000f,
                0.060000f, 0.609000f, 0.352000f, 0.609000f,
                0.352000f, 0.551000f, 0.130000f, 0.551000f,
                0.130000f, 0.381000f, 0.339000f, 0.381000f,
                0.339000f, 0.323000f, 0.091000f, 0.688000f,
                0.091000f, 0.728000f, 0.130000f, 0.728000f,
                0.169000f, 0.728000f, 0.169000f, 0.688000f,
                0.169000f, 0.647000f, 0.130000f, 0.647000f,
                0.091000f, 0.647000f, 0.091000f, 0.688000f,
                0.239000f, 0.688000f, 0.239000f, 0.728000f,
                0.279000f, 0.728000f, 0.318000f, 0.728000f,
                0.318000f, 0.688000f, 0.318000f, 0.647000f,
                0.278000f, 0.647000f, 0.239000f, 0.647000f,
                0.239000f, 0.688000f
            };

        private static readonly byte[] MyriadProGlyph1026Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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

        private static readonly float[] MyriadProGlyph1026Coordinates =
            {
                0.413000f, 0.609000f, 0.413000f, 0.551000f,
                0.218000f, 0.551000f, 0.218000f, 0.397000f,
                0.221000f, 0.397000f, 0.242000f, 0.411000f,
                0.268000f, 0.420000f, 0.299000f, 0.430000f,
                0.329000f, 0.430000f, 0.412000f, 0.430000f,
                0.458000f, 0.363000f, 0.480000f, 0.333000f,
                0.490000f, 0.293000f, 0.500000f, 0.256000f,
                0.500000f, 0.213000f, 0.500000f, 0.083000f,
                0.425000f, 0.020000f, 0.402000f, -0.007000f,
                0.370000f, -0.023000f, 0.343000f, -0.036000f,
                0.313000f, -0.041000f, 0.301000f, 0.013000f,
                0.327000f, 0.020000f, 0.348000f, 0.033000f,
                0.373000f, 0.047000f, 0.389000f, 0.069000f,
                0.427000f, 0.119000f, 0.427000f, 0.206000f,
                0.427000f, 0.282000f, 0.399000f, 0.323000f,
                0.368000f, 0.372000f, 0.309000f, 0.372000f,
                0.261000f, 0.372000f, 0.218000f, 0.341000f,
                0.218000f, 0.070000f, 0.148000f, 0.070000f,
                0.148000f, 0.551000f, -0.001000f, 0.551000f,
                -0.001000f, 0.609000f, 0.413000f, 0.609000f
            };

        private static readonly byte[] MyriadProGlyph1027Commands =
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

        private static readonly float[] MyriadProGlyph1027Coordinates =
            {
                0.347000f, 0.609000f, 0.347000f, 0.551000f,
                0.130000f, 0.551000f, 0.130000f, 0.070000f,
                0.060000f, 0.070000f, 0.060000f, 0.609000f,
                0.347000f, 0.609000f, 0.311000f, 0.732000f,
                0.209000f, 0.638000f, 0.152000f, 0.638000f,
                0.226000f, 0.732000f, 0.311000f, 0.732000f
            };

        private static readonly byte[] MyriadProGlyph1028Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1028Coordinates =
            {
                0.419000f, 0.538000f, 0.374000f, 0.561000f,
                0.312000f, 0.561000f, 0.224000f, 0.561000f,
                0.167000f, 0.506000f, 0.113000f, 0.455000f,
                0.104000f, 0.373000f, 0.381000f, 0.373000f,
                0.381000f, 0.318000f, 0.105000f, 0.318000f,
                0.108000f, 0.234000f, 0.163000f, 0.178000f,
                0.220000f, 0.120000f, 0.310000f, 0.120000f,
                0.372000f, 0.120000f, 0.423000f, 0.141000f,
                0.435000f, 0.088000f, 0.413000f, 0.076000f,
                0.380000f, 0.070000f, 0.342000f, 0.061000f,
                0.297000f, 0.061000f, 0.180000f, 0.061000f,
                0.106000f, 0.135000f, 0.030000f, 0.211000f,
                0.030000f, 0.339000f, 0.030000f, 0.457000f,
                0.104000f, 0.536000f, 0.183000f, 0.618000f,
                0.310000f, 0.618000f, 0.355000f, 0.618000f,
                0.391000f, 0.609000f, 0.405000f, 0.606000f,
                0.417000f, 0.601000f, 0.427000f, 0.597000f,
                0.436000f, 0.593000f, 0.419000f, 0.538000f
            };

        private static readonly byte[] MyriadProGlyph1029Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1029Coordinates =
            {
                0.052000f, 0.155000f, 0.107000f, 0.120000f,
                0.176000f, 0.120000f, 0.289000f, 0.120000f,
                0.289000f, 0.212000f, 0.289000f, 0.280000f,
                0.188000f, 0.318000f, 0.118000f, 0.343000f,
                0.083000f, 0.379000f, 0.045000f, 0.418000f,
                0.045000f, 0.472000f, 0.045000f, 0.536000f,
                0.093000f, 0.577000f, 0.142000f, 0.618000f,
                0.220000f, 0.618000f, 0.258000f, 0.618000f,
                0.291000f, 0.610000f, 0.319000f, 0.603000f,
                0.338000f, 0.592000f, 0.319000f, 0.535000f,
                0.303000f, 0.545000f, 0.280000f, 0.552000f,
                0.250000f, 0.561000f, 0.217000f, 0.561000f,
                0.166000f, 0.561000f, 0.139000f, 0.534000f,
                0.116000f, 0.512000f, 0.116000f, 0.480000f,
                0.116000f, 0.417000f, 0.223000f, 0.376000f,
                0.360000f, 0.323000f, 0.360000f, 0.217000f,
                0.360000f, 0.151000f, 0.313000f, 0.108000f,
                0.262000f, 0.061000f, 0.172000f, 0.061000f,
                0.087000f, 0.061000f, 0.034000f, 0.097000f,
                0.052000f, 0.155000f
            };

        private static readonly byte[] MyriadProGlyph1030Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1030Coordinates =
            {
                0.130000f, 0.609000f, 0.130000f, 0.070000f,
                0.060000f, 0.070000f, 0.060000f, 0.609000f,
                0.130000f, 0.609000f
            };

        private static readonly byte[] MyriadProGlyph1031Commands =
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
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1031Coordinates =
            {
                0.130000f, 0.609000f, 0.130000f, 0.070000f,
                0.060000f, 0.070000f, 0.060000f, 0.609000f,
                0.130000f, 0.609000f, -0.017000f, 0.688000f,
                -0.017000f, 0.728000f, 0.022000f, 0.728000f,
                0.061000f, 0.728000f, 0.061000f, 0.688000f,
                0.061000f, 0.647000f, 0.021000f, 0.647000f,
                -0.017000f, 0.647000f, -0.017000f, 0.688000f,
                0.131000f, 0.688000f, 0.131000f, 0.728000f,
                0.171000f, 0.728000f, 0.209000f, 0.728000f,
                0.209000f, 0.688000f, 0.209000f, 0.647000f,
                0.169000f, 0.647000f, 0.131000f, 0.647000f,
                0.131000f, 0.688000f
            };

        private static readonly byte[] MyriadProGlyph1032Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1032Coordinates =
            {
                0.170000f, 0.609000f, 0.241000f, 0.609000f,
                0.241000f, 0.249000f, 0.241000f, 0.148000f,
                0.194000f, 0.101000f, 0.153000f, 0.061000f,
                0.077000f, 0.061000f, 0.033000f, 0.061000f,
                0.003000f, 0.074000f, 0.013000f, 0.131000f,
                0.039000f, 0.121000f, 0.072000f, 0.121000f,
                0.122000f, 0.121000f, 0.144000f, 0.148000f,
                0.170000f, 0.179000f, 0.170000f, 0.254000f,
                0.170000f, 0.609000f
            };

        private static readonly byte[] MyriadProGlyph1033Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1033Coordinates =
            {
                0.401000f, 0.609000f, 0.401000f, 0.406000f,
                0.429000f, 0.410000f, 0.466000f, 0.410000f,
                0.555000f, 0.410000f, 0.610000f, 0.371000f,
                0.673000f, 0.327000f, 0.673000f, 0.243000f,
                0.673000f, 0.172000f, 0.629000f, 0.125000f,
                0.597000f, 0.094000f, 0.545000f, 0.079000f,
                0.499000f, 0.065000f, 0.439000f, 0.065000f,
                0.406000f, 0.065000f, 0.375000f, 0.067000f,
                0.340000f, 0.070000f, 0.336000f, 0.070000f,
                0.331000f, 0.071000f, 0.331000f, 0.551000f,
                0.167000f, 0.551000f, 0.167000f, 0.344000f,
                0.166000f, 0.319000f, 0.165000f, 0.299000f,
                0.162000f, 0.250000f, 0.155000f, 0.214000f,
                0.146000f, 0.171000f, 0.131000f, 0.141000f,
                0.113000f, 0.108000f, 0.086000f, 0.089000f,
                0.046000f, 0.064000f, 0.005000f, 0.064000f,
                -0.005000f, 0.120000f, 0.029000f, 0.126000f,
                0.053000f, 0.149000f, 0.081000f, 0.177000f,
                0.092000f, 0.249000f, 0.096000f, 0.278000f,
                0.098000f, 0.316000f, 0.099000f, 0.344000f,
                0.099000f, 0.383000f, 0.099000f, 0.609000f,
                0.401000f, 0.609000f, 0.401000f, 0.123000f,
                0.417000f, 0.120000f, 0.457000f, 0.120000f,
                0.519000f, 0.120000f, 0.558000f, 0.150000f,
                0.601000f, 0.182000f, 0.601000f, 0.241000f,
                0.601000f, 0.300000f, 0.557000f, 0.330000f,
                0.519000f, 0.356000f, 0.456000f, 0.356000f,
                0.436000f, 0.356000f, 0.401000f, 0.353000f,
                0.401000f, 0.123000f
            };

        private static readonly byte[] MyriadProGlyph1034Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1034Coordinates =
            {
                0.130000f, 0.609000f, 0.130000f, 0.394000f,
                0.344000f, 0.394000f, 0.344000f, 0.609000f,
                0.414000f, 0.609000f, 0.414000f, 0.399000f,
                0.442000f, 0.403000f, 0.488000f, 0.403000f,
                0.573000f, 0.403000f, 0.627000f, 0.365000f,
                0.686000f, 0.322000f, 0.686000f, 0.241000f,
                0.686000f, 0.169000f, 0.642000f, 0.125000f,
                0.610000f, 0.093000f, 0.559000f, 0.079000f,
                0.514000f, 0.065000f, 0.454000f, 0.065000f,
                0.419000f, 0.065000f, 0.389000f, 0.067000f,
                0.364000f, 0.069000f, 0.344000f, 0.072000f,
                0.344000f, 0.335000f, 0.130000f, 0.335000f,
                0.130000f, 0.070000f, 0.060000f, 0.070000f,
                0.060000f, 0.609000f, 0.130000f, 0.609000f,
                0.414000f, 0.124000f, 0.435000f, 0.120000f,
                0.470000f, 0.120000f, 0.532000f, 0.120000f,
                0.571000f, 0.148000f, 0.614000f, 0.180000f,
                0.614000f, 0.239000f, 0.614000f, 0.295000f,
                0.571000f, 0.324000f, 0.534000f, 0.349000f,
                0.474000f, 0.349000f, 0.444000f, 0.349000f,
                0.414000f, 0.345000f, 0.414000f, 0.124000f
            };

        private static readonly byte[] MyriadProGlyph1035Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1035Coordinates =
            {
                0.405000f, 0.609000f, 0.405000f, 0.551000f,
                0.217000f, 0.551000f, 0.217000f, 0.397000f,
                0.218000f, 0.397000f, 0.244000f, 0.412000f,
                0.274000f, 0.422000f, 0.309000f, 0.433000f,
                0.341000f, 0.433000f, 0.403000f, 0.433000f,
                0.440000f, 0.396000f, 0.482000f, 0.352000f,
                0.482000f, 0.270000f, 0.482000f, 0.070000f,
                0.413000f, 0.070000f, 0.413000f, 0.261000f,
                0.413000f, 0.320000f, 0.387000f, 0.349000f,
                0.361000f, 0.376000f, 0.318000f, 0.376000f,
                0.262000f, 0.376000f, 0.217000f, 0.341000f,
                0.217000f, 0.070000f, 0.146000f, 0.070000f,
                0.146000f, 0.551000f, -0.001000f, 0.551000f,
                -0.001000f, 0.609000f, 0.405000f, 0.609000f
            };

        private static readonly byte[] MyriadProGlyph1036Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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

        private static readonly float[] MyriadProGlyph1036Coordinates =
            {
                0.131000f, 0.609000f, 0.131000f, 0.370000f,
                0.152000f, 0.370000f, 0.337000f, 0.609000f,
                0.420000f, 0.609000f, 0.216000f, 0.362000f,
                0.278000f, 0.354000f, 0.315000f, 0.315000f,
                0.331000f, 0.298000f, 0.345000f, 0.274000f,
                0.356000f, 0.253000f, 0.367000f, 0.223000f,
                0.396000f, 0.144000f, 0.412000f, 0.100000f,
                0.427000f, 0.070000f, 0.352000f, 0.070000f,
                0.340000f, 0.093000f, 0.326000f, 0.132000f,
                0.323000f, 0.139000f, 0.320000f, 0.148000f,
                0.303000f, 0.197000f, 0.282000f, 0.257000f,
                0.253000f, 0.284000f, 0.217000f, 0.317000f,
                0.153000f, 0.317000f, 0.131000f, 0.317000f,
                0.131000f, 0.070000f, 0.061000f, 0.070000f,
                0.061000f, 0.609000f, 0.131000f, 0.609000f,
                0.340000f, 0.728000f, 0.238000f, 0.634000f,
                0.181000f, 0.634000f, 0.255000f, 0.728000f,
                0.340000f, 0.728000f
            };

        private static readonly byte[] MyriadProGlyph1038Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1038Coordinates =
            {
                0.081000f, 0.609000f, 0.188000f, 0.378000f,
                0.210000f, 0.326000f, 0.227000f, 0.284000f,
                0.229000f, 0.284000f, 0.262000f, 0.381000f,
                0.347000f, 0.609000f, 0.420000f, 0.609000f,
                0.284000f, 0.276000f, 0.271000f, 0.245000f,
                0.260000f, 0.221000f, 0.232000f, 0.160000f,
                0.206000f, 0.127000f, 0.154000f, 0.061000f,
                0.084000f, 0.061000f, 0.058000f, 0.061000f,
                0.045000f, 0.065000f, 0.052000f, 0.122000f,
                0.061000f, 0.120000f, 0.078000f, 0.120000f,
                0.115000f, 0.120000f, 0.145000f, 0.151000f,
                0.157000f, 0.164000f, 0.167000f, 0.181000f,
                0.176000f, 0.195000f, 0.184000f, 0.212000f,
                0.190000f, 0.226000f, 0.181000f, 0.245000f,
                0.002000f, 0.609000f, 0.081000f, 0.609000f,
                0.160000f, 0.724000f, 0.163000f, 0.701000f,
                0.172000f, 0.690000f, 0.184000f, 0.674000f,
                0.209000f, 0.674000f, 0.234000f, 0.674000f,
                0.246000f, 0.689000f, 0.255000f, 0.700000f,
                0.258000f, 0.724000f, 0.312000f, 0.724000f,
                0.305000f, 0.637000f, 0.208000f, 0.637000f,
                0.113000f, 0.637000f, 0.107000f, 0.724000f,
                0.160000f, 0.724000f
            };

        private static readonly byte[] MyriadProGlyph1039Commands =
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

        private static readonly float[] MyriadProGlyph1039Coordinates =
            {
                0.130000f, 0.609000f, 0.130000f, 0.129000f,
                0.378000f, 0.129000f, 0.378000f, 0.609000f,
                0.449000f, 0.609000f, 0.449000f, 0.070000f,
                0.290000f, 0.070000f, 0.284000f, -0.070000f,
                0.226000f, -0.070000f, 0.220000f, 0.070000f,
                0.060000f, 0.070000f, 0.060000f, 0.609000f,
                0.130000f, 0.609000f
            };

        private static readonly byte[] MyriadProGlyph1040Commands =
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1040Coordinates =
            {
                0.148000f, 0.240000f, 0.092000f, 0.070000f,
                0.020000f, 0.070000f, 0.204000f, 0.609000f,
                0.287000f, 0.609000f, 0.471000f, 0.070000f,
                0.397000f, 0.070000f, 0.339000f, 0.240000f,
                0.148000f, 0.240000f, 0.326000f, 0.294000f,
                0.272000f, 0.449000f, 0.264000f, 0.473000f,
                0.257000f, 0.500000f, 0.246000f, 0.542000f,
                0.244000f, 0.546000f, 0.244000f, 0.548000f,
                0.242000f, 0.548000f, 0.230000f, 0.500000f,
                0.222000f, 0.471000f, 0.215000f, 0.450000f,
                0.162000f, 0.294000f, 0.326000f, 0.294000f
            };

        private static readonly byte[] MyriadProGlyph1041Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1041Coordinates =
            {
                0.363000f, 0.609000f, 0.363000f, 0.551000f,
                0.131000f, 0.551000f, 0.131000f, 0.406000f,
                0.159000f, 0.410000f, 0.197000f, 0.410000f,
                0.282000f, 0.410000f, 0.336000f, 0.374000f,
                0.405000f, 0.330000f, 0.405000f, 0.243000f,
                0.405000f, 0.172000f, 0.360000f, 0.125000f,
                0.329000f, 0.095000f, 0.276000f, 0.079000f,
                0.229000f, 0.065000f, 0.170000f, 0.065000f,
                0.136000f, 0.065000f, 0.106000f, 0.067000f,
                0.081000f, 0.069000f, 0.061000f, 0.072000f,
                0.061000f, 0.609000f, 0.363000f, 0.609000f,
                0.131000f, 0.124000f, 0.151000f, 0.120000f,
                0.189000f, 0.120000f, 0.263000f, 0.120000f,
                0.303000f, 0.161000f, 0.332000f, 0.192000f,
                0.332000f, 0.241000f, 0.332000f, 0.298000f,
                0.288000f, 0.329000f, 0.250000f, 0.356000f,
                0.186000f, 0.356000f, 0.166000f, 0.356000f,
                0.131000f, 0.353000f, 0.131000f, 0.124000f
            };

        private static readonly byte[] MyriadProGlyph1042Commands =
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1042Coordinates =
            {
                0.061000f, 0.601000f, 0.112000f, 0.613000f,
                0.188000f, 0.613000f, 0.288000f, 0.613000f,
                0.335000f, 0.574000f, 0.381000f, 0.540000f,
                0.381000f, 0.479000f, 0.381000f, 0.393000f,
                0.290000f, 0.361000f, 0.290000f, 0.358000f,
                0.334000f, 0.348000f, 0.365000f, 0.317000f,
                0.401000f, 0.279000f, 0.401000f, 0.224000f,
                0.401000f, 0.158000f, 0.355000f, 0.116000f,
                0.301000f, 0.065000f, 0.169000f, 0.065000f,
                0.136000f, 0.065000f, 0.106000f, 0.067000f,
                0.081000f, 0.069000f, 0.061000f, 0.072000f,
                0.061000f, 0.601000f, 0.131000f, 0.381000f,
                0.194000f, 0.381000f, 0.310000f, 0.381000f,
                0.310000f, 0.472000f, 0.310000f, 0.560000f,
                0.192000f, 0.560000f, 0.170000f, 0.560000f,
                0.154000f, 0.558000f, 0.131000f, 0.555000f,
                0.131000f, 0.381000f, 0.131000f, 0.123000f,
                0.150000f, 0.120000f, 0.189000f, 0.120000f,
                0.249000f, 0.120000f, 0.285000f, 0.143000f,
                0.327000f, 0.170000f, 0.327000f, 0.225000f,
                0.327000f, 0.276000f, 0.286000f, 0.304000f,
                0.249000f, 0.329000f, 0.188000f, 0.329000f,
                0.131000f, 0.329000f, 0.131000f, 0.123000f
            };

        private static readonly byte[] MyriadProGlyph1043Commands =
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

        private static readonly float[] MyriadProGlyph1043Coordinates =
            {
                0.347000f, 0.609000f, 0.347000f, 0.551000f,
                0.130000f, 0.551000f, 0.130000f, 0.070000f,
                0.060000f, 0.070000f, 0.060000f, 0.609000f,
                0.347000f, 0.609000f
            };

        private static readonly byte[] MyriadProGlyph1044Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1044Coordinates =
            {
                0.430000f, 0.609000f, 0.430000f, 0.127000f,
                0.477000f, 0.125000f, 0.472000f, -0.059000f,
                0.418000f, -0.059000f, 0.413000f, 0.070000f,
                0.073000f, 0.070000f, 0.068000f, -0.059000f,
                0.014000f, -0.059000f, 0.010000f, 0.125000f,
                0.050000f, 0.127000f, 0.068000f, 0.160000f,
                0.079000f, 0.184000f, 0.094000f, 0.217000f,
                0.103000f, 0.245000f, 0.128000f, 0.332000f,
                0.128000f, 0.473000f, 0.128000f, 0.609000f,
                0.430000f, 0.609000f, 0.193000f, 0.450000f,
                0.193000f, 0.316000f, 0.166000f, 0.230000f,
                0.158000f, 0.205000f, 0.146000f, 0.176000f,
                0.136000f, 0.154000f, 0.122000f, 0.128000f,
                0.360000f, 0.128000f, 0.360000f, 0.552000f,
                0.193000f, 0.552000f, 0.193000f, 0.450000f
            };

        private static readonly byte[] MyriadProGlyph1045Commands =
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

        private static readonly float[] MyriadProGlyph1045Coordinates =
            {
                0.339000f, 0.323000f, 0.130000f, 0.323000f,
                0.130000f, 0.129000f, 0.364000f, 0.129000f,
                0.364000f, 0.070000f, 0.060000f, 0.070000f,
                0.060000f, 0.609000f, 0.352000f, 0.609000f,
                0.352000f, 0.551000f, 0.130000f, 0.551000f,
                0.130000f, 0.381000f, 0.339000f, 0.381000f,
                0.339000f, 0.323000f
            };

        private static readonly byte[] MyriadProGlyph1046Commands =
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1046Coordinates =
            {
                0.099000f, 0.609000f, 0.266000f, 0.370000f,
                0.287000f, 0.370000f, 0.287000f, 0.609000f,
                0.355000f, 0.609000f, 0.355000f, 0.370000f,
                0.376000f, 0.370000f, 0.543000f, 0.609000f,
                0.624000f, 0.609000f, 0.433000f, 0.361000f,
                0.492000f, 0.356000f, 0.528000f, 0.318000f,
                0.557000f, 0.287000f, 0.579000f, 0.223000f,
                0.585000f, 0.208000f, 0.592000f, 0.185000f,
                0.595000f, 0.175000f, 0.595000f, 0.174000f,
                0.596000f, 0.172000f, 0.604000f, 0.146000f,
                0.619000f, 0.100000f, 0.632000f, 0.070000f,
                0.561000f, 0.070000f, 0.550000f, 0.092000f,
                0.537000f, 0.133000f, 0.517000f, 0.197000f,
                0.506000f, 0.228000f, 0.497000f, 0.247000f,
                0.485000f, 0.270000f, 0.471000f, 0.285000f,
                0.438000f, 0.317000f, 0.379000f, 0.317000f,
                0.355000f, 0.317000f, 0.355000f, 0.070000f,
                0.287000f, 0.070000f, 0.287000f, 0.317000f,
                0.263000f, 0.317000f, 0.203000f, 0.317000f,
                0.171000f, 0.285000f, 0.156000f, 0.270000f,
                0.144000f, 0.247000f, 0.135000f, 0.228000f,
                0.124000f, 0.197000f, 0.104000f, 0.133000f,
                0.091000f, 0.092000f, 0.080000f, 0.070000f,
                0.009000f, 0.070000f, 0.023000f, 0.100000f,
                0.038000f, 0.146000f, 0.063000f, 0.222000f,
                0.086000f, 0.286000f, 0.115000f, 0.317000f,
                0.149000f, 0.354000f, 0.208000f, 0.361000f,
                0.018000f, 0.609000f, 0.099000f, 0.609000f
            };

        private static readonly byte[] MyriadProGlyph1047Commands =
            {
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1047Coordinates =
            {
                0.040000f, 0.578000f, 0.070000f, 0.597000f,
                0.103000f, 0.608000f, 0.140000f, 0.619000f,
                0.183000f, 0.619000f, 0.254000f, 0.619000f,
                0.297000f, 0.584000f, 0.341000f, 0.548000f,
                0.341000f, 0.487000f, 0.341000f, 0.438000f,
                0.309000f, 0.402000f, 0.278000f, 0.366000f,
                0.230000f, 0.355000f, 0.230000f, 0.353000f,
                0.288000f, 0.347000f, 0.324000f, 0.312000f,
                0.361000f, 0.275000f, 0.362000f, 0.218000f,
                0.362000f, 0.140000f, 0.301000f, 0.098000f,
                0.248000f, 0.061000f, 0.166000f, 0.061000f,
                0.084000f, 0.061000f, 0.025000f, 0.097000f,
                0.043000f, 0.151000f, 0.068000f, 0.137000f,
                0.099000f, 0.128000f, 0.133000f, 0.118000f,
                0.165000f, 0.118000f, 0.288000f, 0.118000f,
                0.288000f, 0.221000f, 0.288000f, 0.276000f,
                0.241000f, 0.303000f, 0.203000f, 0.325000f,
                0.142000f, 0.325000f, 0.110000f, 0.325000f,
                0.110000f, 0.377000f, 0.141000f, 0.377000f,
                0.194000f, 0.377000f, 0.231000f, 0.406000f,
                0.268000f, 0.435000f, 0.268000f, 0.477000f,
                0.268000f, 0.562000f, 0.171000f, 0.562000f,
                0.142000f, 0.562000f, 0.111000f, 0.552000f,
                0.083000f, 0.542000f, 0.059000f, 0.527000f,
                0.040000f, 0.578000f
            };

        private static readonly byte[] MyriadProGlyph1048Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1048Coordinates =
            {
                0.127000f, 0.609000f, 0.127000f, 0.382000f,
                0.127000f, 0.316000f, 0.125000f, 0.263000f,
                0.124000f, 0.206000f, 0.120000f, 0.154000f,
                0.123000f, 0.153000f, 0.141000f, 0.193000f,
                0.167000f, 0.240000f, 0.190000f, 0.280000f,
                0.222000f, 0.332000f, 0.396000f, 0.609000f,
                0.466000f, 0.609000f, 0.466000f, 0.070000f,
                0.400000f, 0.070000f, 0.400000f, 0.361000f,
                0.401000f, 0.392000f, 0.401000f, 0.417000f,
                0.403000f, 0.472000f, 0.407000f, 0.519000f,
                0.404000f, 0.520000f, 0.386000f, 0.479000f,
                0.358000f, 0.429000f, 0.346000f, 0.408000f,
                0.332000f, 0.384000f, 0.304000f, 0.339000f,
                0.135000f, 0.070000f, 0.061000f, 0.070000f,
                0.061000f, 0.609000f, 0.127000f, 0.609000f
            };

        private static readonly byte[] MyriadProGlyph1049Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1049Coordinates =
            {
                0.127000f, 0.609000f, 0.127000f, 0.382000f,
                0.127000f, 0.316000f, 0.125000f, 0.263000f,
                0.124000f, 0.206000f, 0.120000f, 0.154000f,
                0.123000f, 0.153000f, 0.141000f, 0.193000f,
                0.167000f, 0.240000f, 0.190000f, 0.280000f,
                0.222000f, 0.332000f, 0.396000f, 0.609000f,
                0.466000f, 0.609000f, 0.466000f, 0.070000f,
                0.400000f, 0.070000f, 0.400000f, 0.361000f,
                0.401000f, 0.392000f, 0.401000f, 0.417000f,
                0.403000f, 0.472000f, 0.407000f, 0.519000f,
                0.404000f, 0.520000f, 0.386000f, 0.479000f,
                0.358000f, 0.429000f, 0.346000f, 0.408000f,
                0.332000f, 0.384000f, 0.304000f, 0.339000f,
                0.135000f, 0.070000f, 0.061000f, 0.070000f,
                0.061000f, 0.609000f, 0.127000f, 0.609000f,
                0.215000f, 0.722000f, 0.218000f, 0.699000f,
                0.226000f, 0.688000f, 0.238000f, 0.673000f,
                0.263000f, 0.673000f, 0.289000f, 0.673000f,
                0.300000f, 0.688000f, 0.309000f, 0.699000f,
                0.312000f, 0.722000f, 0.366000f, 0.722000f,
                0.359000f, 0.636000f, 0.262000f, 0.636000f,
                0.168000f, 0.636000f, 0.161000f, 0.722000f,
                0.215000f, 0.722000f
            };

        private static readonly byte[] MyriadProGlyph1050Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1050Coordinates =
            {
                0.131000f, 0.609000f, 0.131000f, 0.370000f,
                0.152000f, 0.370000f, 0.337000f, 0.609000f,
                0.420000f, 0.609000f, 0.216000f, 0.362000f,
                0.278000f, 0.354000f, 0.315000f, 0.315000f,
                0.331000f, 0.298000f, 0.345000f, 0.274000f,
                0.356000f, 0.253000f, 0.367000f, 0.223000f,
                0.396000f, 0.144000f, 0.412000f, 0.100000f,
                0.427000f, 0.070000f, 0.352000f, 0.070000f,
                0.340000f, 0.093000f, 0.326000f, 0.132000f,
                0.323000f, 0.139000f, 0.320000f, 0.148000f,
                0.303000f, 0.197000f, 0.282000f, 0.257000f,
                0.253000f, 0.284000f, 0.217000f, 0.317000f,
                0.153000f, 0.317000f, 0.131000f, 0.317000f,
                0.131000f, 0.070000f, 0.061000f, 0.070000f,
                0.061000f, 0.609000f, 0.131000f, 0.609000f
            };

        private static readonly byte[] MyriadProGlyph1051Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1051Coordinates =
            {
                0.415000f, 0.609000f, 0.415000f, 0.070000f,
                0.344000f, 0.070000f, 0.344000f, 0.551000f,
                0.167000f, 0.551000f, 0.166000f, 0.344000f,
                0.166000f, 0.319000f, 0.165000f, 0.299000f,
                0.162000f, 0.250000f, 0.155000f, 0.214000f,
                0.146000f, 0.171000f, 0.130000f, 0.141000f,
                0.113000f, 0.108000f, 0.086000f, 0.089000f,
                0.046000f, 0.064000f, 0.003000f, 0.064000f,
                -0.006000f, 0.120000f, 0.027000f, 0.125000f,
                0.051000f, 0.149000f, 0.080000f, 0.176000f,
                0.091000f, 0.249000f, 0.095000f, 0.277000f,
                0.097000f, 0.315000f, 0.098000f, 0.343000f,
                0.098000f, 0.382000f, 0.098000f, 0.609000f,
                0.415000f, 0.609000f
            };

        private static readonly byte[] MyriadProGlyph1052Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1052Coordinates =
            {
                0.512000f, 0.366000f, 0.509000f, 0.427000f,
                0.506000f, 0.496000f, 0.506000f, 0.540000f,
                0.504000f, 0.540000f, 0.496000f, 0.514000f,
                0.490000f, 0.492000f, 0.481000f, 0.466000f,
                0.473000f, 0.442000f, 0.455000f, 0.386000f,
                0.436000f, 0.335000f, 0.341000f, 0.073000f,
                0.288000f, 0.073000f, 0.200000f, 0.330000f,
                0.180000f, 0.391000f, 0.166000f, 0.440000f,
                0.150000f, 0.494000f, 0.139000f, 0.540000f,
                0.137000f, 0.540000f, 0.135000f, 0.436000f,
                0.127000f, 0.301000f, 0.112000f, 0.070000f,
                0.046000f, 0.070000f, 0.084000f, 0.609000f,
                0.172000f, 0.609000f, 0.264000f, 0.349000f,
                0.297000f, 0.253000f, 0.319000f, 0.167000f,
                0.320000f, 0.167000f, 0.340000f, 0.241000f,
                0.378000f, 0.349000f, 0.474000f, 0.609000f,
                0.563000f, 0.609000f, 0.596000f, 0.070000f,
                0.528000f, 0.070000f, 0.512000f, 0.366000f
            };

        private static readonly byte[] MyriadProGlyph1053Commands =
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

        private static readonly float[] MyriadProGlyph1053Coordinates =
            {
                0.130000f, 0.609000f, 0.130000f, 0.384000f,
                0.391000f, 0.384000f, 0.391000f, 0.609000f,
                0.462000f, 0.609000f, 0.462000f, 0.070000f,
                0.391000f, 0.070000f, 0.391000f, 0.323000f,
                0.130000f, 0.323000f, 0.130000f, 0.070000f,
                0.060000f, 0.070000f, 0.060000f, 0.609000f,
                0.130000f, 0.609000f
            };

        private static readonly byte[] MyriadProGlyph1054Commands =
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

        private static readonly float[] MyriadProGlyph1054Coordinates =
            {
                0.456000f, 0.543000f, 0.522000f, 0.467000f,
                0.522000f, 0.345000f, 0.522000f, 0.212000f,
                0.448000f, 0.134000f, 0.379000f, 0.061000f,
                0.271000f, 0.061000f, 0.164000f, 0.061000f,
                0.097000f, 0.137000f, 0.029000f, 0.214000f,
                0.029000f, 0.336000f, 0.029000f, 0.463000f,
                0.100000f, 0.542000f, 0.169000f, 0.619000f,
                0.279000f, 0.619000f, 0.389000f, 0.619000f,
                0.456000f, 0.543000f, 0.146000f, 0.494000f,
                0.103000f, 0.432000f, 0.103000f, 0.337000f,
                0.103000f, 0.246000f, 0.148000f, 0.184000f,
                0.196000f, 0.118000f, 0.275000f, 0.118000f,
                0.355000f, 0.118000f, 0.403000f, 0.184000f,
                0.448000f, 0.247000f, 0.448000f, 0.342000f,
                0.448000f, 0.431000f, 0.406000f, 0.493000f,
                0.358000f, 0.562000f, 0.276000f, 0.562000f,
                0.193000f, 0.562000f, 0.146000f, 0.494000f
            };

        private static readonly byte[] MyriadProGlyph1055Commands =
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

        private static readonly float[] MyriadProGlyph1055Coordinates =
            {
                0.451000f, 0.609000f, 0.451000f, 0.070000f,
                0.381000f, 0.070000f, 0.381000f, 0.551000f,
                0.130000f, 0.551000f, 0.130000f, 0.070000f,
                0.060000f, 0.070000f, 0.060000f, 0.609000f,
                0.451000f, 0.609000f
            };

        private static readonly byte[] MyriadProGlyph1056Commands =
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

        private static readonly float[] MyriadProGlyph1056Coordinates =
            {
                0.061000f, 0.603000f, 0.089000f, 0.608000f,
                0.119000f, 0.610000f, 0.156000f, 0.613000f,
                0.195000f, 0.613000f, 0.296000f, 0.613000f,
                0.346000f, 0.569000f, 0.393000f, 0.527000f,
                0.393000f, 0.456000f, 0.393000f, 0.383000f,
                0.351000f, 0.341000f, 0.295000f, 0.281000f,
                0.187000f, 0.281000f, 0.150000f, 0.281000f,
                0.131000f, 0.286000f, 0.131000f, 0.070000f,
                0.061000f, 0.070000f, 0.061000f, 0.603000f,
                0.131000f, 0.343000f, 0.152000f, 0.337000f,
                0.188000f, 0.337000f, 0.323000f, 0.337000f,
                0.323000f, 0.452000f, 0.323000f, 0.558000f,
                0.196000f, 0.558000f, 0.152000f, 0.558000f,
                0.131000f, 0.553000f, 0.131000f, 0.343000f
            };

        private static readonly byte[] MyriadProGlyph1057Commands =
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1057Coordinates =
            {
                0.437000f, 0.087000f, 0.416000f, 0.076000f,
                0.381000f, 0.069000f, 0.341000f, 0.061000f,
                0.295000f, 0.061000f, 0.177000f, 0.061000f,
                0.105000f, 0.132000f, 0.029000f, 0.205000f,
                0.029000f, 0.335000f, 0.029000f, 0.462000f,
                0.107000f, 0.540000f, 0.185000f, 0.618000f,
                0.311000f, 0.618000f, 0.355000f, 0.618000f,
                0.393000f, 0.610000f, 0.421000f, 0.603000f,
                0.439000f, 0.594000f, 0.421000f, 0.537000f,
                0.376000f, 0.560000f, 0.313000f, 0.560000f,
                0.217000f, 0.560000f, 0.160000f, 0.502000f,
                0.103000f, 0.442000f, 0.103000f, 0.337000f,
                0.103000f, 0.237000f, 0.157000f, 0.179000f,
                0.212000f, 0.121000f, 0.309000f, 0.121000f,
                0.377000f, 0.121000f, 0.423000f, 0.143000f,
                0.437000f, 0.087000f
            };

        private static readonly byte[] MyriadProGlyph1058Commands =
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

        private static readonly float[] MyriadProGlyph1058Coordinates =
            {
                0.163000f, 0.550000f, -0.001000f, 0.550000f,
                -0.001000f, 0.609000f, 0.398000f, 0.609000f,
                0.398000f, 0.550000f, 0.233000f, 0.550000f,
                0.233000f, 0.070000f, 0.163000f, 0.070000f,
                0.163000f, 0.550000f
            };

        private static readonly byte[] MyriadProGlyph1059Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1059Coordinates =
            {
                0.081000f, 0.609000f, 0.188000f, 0.378000f,
                0.210000f, 0.326000f, 0.227000f, 0.284000f,
                0.229000f, 0.284000f, 0.262000f, 0.381000f,
                0.347000f, 0.609000f, 0.420000f, 0.609000f,
                0.284000f, 0.276000f, 0.271000f, 0.245000f,
                0.260000f, 0.221000f, 0.232000f, 0.160000f,
                0.206000f, 0.127000f, 0.154000f, 0.061000f,
                0.084000f, 0.061000f, 0.058000f, 0.061000f,
                0.045000f, 0.065000f, 0.052000f, 0.122000f,
                0.061000f, 0.120000f, 0.078000f, 0.120000f,
                0.115000f, 0.120000f, 0.145000f, 0.151000f,
                0.157000f, 0.164000f, 0.167000f, 0.181000f,
                0.176000f, 0.195000f, 0.184000f, 0.212000f,
                0.190000f, 0.226000f, 0.181000f, 0.245000f,
                0.002000f, 0.609000f, 0.081000f, 0.609000f
            };

        private static readonly byte[] MyriadProGlyph1060Commands =
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
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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

        private static readonly float[] MyriadProGlyph1060Coordinates =
            {
                0.324000f, 0.631000f, 0.324000f, 0.582000f,
                0.419000f, 0.578000f, 0.480000f, 0.523000f,
                0.513000f, 0.492000f, 0.531000f, 0.449000f,
                0.551000f, 0.401000f, 0.551000f, 0.340000f,
                0.551000f, 0.278000f, 0.531000f, 0.231000f,
                0.513000f, 0.188000f, 0.480000f, 0.158000f,
                0.449000f, 0.130000f, 0.406000f, 0.115000f,
                0.368000f, 0.101000f, 0.323000f, 0.098000f,
                0.323000f, 0.049000f, 0.255000f, 0.049000f,
                0.255000f, 0.098000f, 0.211000f, 0.101000f,
                0.173000f, 0.115000f, 0.131000f, 0.130000f,
                0.100000f, 0.157000f, 0.067000f, 0.186000f,
                0.049000f, 0.229000f, 0.029000f, 0.275000f,
                0.029000f, 0.337000f, 0.029000f, 0.400000f,
                0.050000f, 0.449000f, 0.069000f, 0.493000f,
                0.104000f, 0.524000f, 0.135000f, 0.551000f,
                0.178000f, 0.566000f, 0.215000f, 0.580000f,
                0.257000f, 0.582000f, 0.257000f, 0.631000f,
                0.324000f, 0.631000f, 0.256000f, 0.533000f,
                0.194000f, 0.529000f, 0.152000f, 0.487000f,
                0.128000f, 0.463000f, 0.115000f, 0.428000f,
                0.101000f, 0.389000f, 0.101000f, 0.339000f,
                0.101000f, 0.250000f, 0.149000f, 0.199000f,
                0.190000f, 0.155000f, 0.256000f, 0.149000f,
                0.256000f, 0.533000f, 0.323000f, 0.149000f,
                0.389000f, 0.153000f, 0.430000f, 0.197000f,
                0.479000f, 0.247000f, 0.479000f, 0.340000f,
                0.479000f, 0.436000f, 0.430000f, 0.487000f,
                0.389000f, 0.528000f, 0.323000f, 0.533000f,
                0.323000f, 0.149000f
            };

        private static readonly byte[] MyriadProGlyph1061Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1061Coordinates =
            {
                0.356000f, 0.070000f, 0.286000f, 0.189000f,
                0.251000f, 0.248000f, 0.225000f, 0.296000f,
                0.223000f, 0.296000f, 0.205000f, 0.258000f,
                0.165000f, 0.189000f, 0.100000f, 0.070000f,
                0.020000f, 0.070000f, 0.185000f, 0.343000f,
                0.026000f, 0.609000f, 0.107000f, 0.609000f,
                0.178000f, 0.483000f, 0.196000f, 0.453000f,
                0.205000f, 0.435000f, 0.218000f, 0.412000f,
                0.228000f, 0.392000f, 0.230000f, 0.392000f,
                0.249000f, 0.431000f, 0.279000f, 0.483000f,
                0.352000f, 0.609000f, 0.433000f, 0.609000f,
                0.269000f, 0.347000f, 0.437000f, 0.070000f,
                0.356000f, 0.070000f
            };

        private static readonly byte[] MyriadProGlyph1062Commands =
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

        private static readonly float[] MyriadProGlyph1062Coordinates =
            {
                0.130000f, 0.609000f, 0.130000f, 0.129000f,
                0.378000f, 0.129000f, 0.378000f, 0.609000f,
                0.448000f, 0.609000f, 0.448000f, 0.127000f,
                0.495000f, 0.125000f, 0.490000f, -0.060000f,
                0.436000f, -0.060000f, 0.431000f, 0.070000f,
                0.060000f, 0.070000f, 0.060000f, 0.609000f,
                0.130000f, 0.609000f
            };

        private static readonly byte[] MyriadProGlyph1063Commands =
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1063Coordinates =
            {
                0.127000f, 0.609000f, 0.127000f, 0.437000f,
                0.127000f, 0.321000f, 0.240000f, 0.321000f,
                0.300000f, 0.321000f, 0.347000f, 0.352000f,
                0.347000f, 0.609000f, 0.417000f, 0.609000f,
                0.417000f, 0.067000f, 0.347000f, 0.067000f,
                0.347000f, 0.297000f, 0.346000f, 0.297000f,
                0.287000f, 0.264000f, 0.216000f, 0.264000f,
                0.187000f, 0.264000f, 0.161000f, 0.271000f,
                0.132000f, 0.279000f, 0.110000f, 0.295000f,
                0.057000f, 0.336000f, 0.057000f, 0.425000f,
                0.057000f, 0.609000f, 0.127000f, 0.609000f
            };

        private static readonly byte[] MyriadProGlyph1064Commands =
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

        private static readonly float[] MyriadProGlyph1064Coordinates =
            {
                0.130000f, 0.609000f, 0.130000f, 0.129000f,
                0.305000f, 0.129000f, 0.305000f, 0.609000f,
                0.374000f, 0.609000f, 0.374000f, 0.129000f,
                0.549000f, 0.129000f, 0.549000f, 0.609000f,
                0.618000f, 0.609000f, 0.618000f, 0.070000f,
                0.061000f, 0.070000f, 0.061000f, 0.609000f,
                0.130000f, 0.609000f
            };

        private static readonly byte[] MyriadProGlyph1065Commands =
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

        private static readonly float[] MyriadProGlyph1065Coordinates =
            {
                0.130000f, 0.609000f, 0.130000f, 0.129000f,
                0.305000f, 0.129000f, 0.305000f, 0.609000f,
                0.374000f, 0.609000f, 0.374000f, 0.129000f,
                0.549000f, 0.129000f, 0.549000f, 0.609000f,
                0.618000f, 0.609000f, 0.618000f, 0.127000f,
                0.665000f, 0.125000f, 0.660000f, -0.060000f,
                0.606000f, -0.060000f, 0.601000f, 0.070000f,
                0.061000f, 0.070000f, 0.061000f, 0.609000f,
                0.130000f, 0.609000f
            };

        private static readonly byte[] MyriadProGlyph1066Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1066Coordinates =
            {
                0.206000f, 0.609000f, 0.206000f, 0.408000f,
                0.233000f, 0.412000f, 0.271000f, 0.412000f,
                0.356000f, 0.412000f, 0.411000f, 0.372000f,
                0.473000f, 0.326000f, 0.473000f, 0.243000f,
                0.473000f, 0.173000f, 0.432000f, 0.129000f,
                0.400000f, 0.095000f, 0.348000f, 0.079000f,
                0.303000f, 0.065000f, 0.244000f, 0.065000f,
                0.211000f, 0.065000f, 0.181000f, 0.067000f,
                0.156000f, 0.069000f, 0.136000f, 0.072000f,
                0.136000f, 0.552000f, -0.002000f, 0.552000f,
                -0.002000f, 0.609000f, 0.206000f, 0.609000f,
                0.206000f, 0.124000f, 0.225000f, 0.120000f,
                0.261000f, 0.120000f, 0.323000f, 0.120000f,
                0.360000f, 0.150000f, 0.400000f, 0.182000f,
                0.400000f, 0.241000f, 0.400000f, 0.299000f,
                0.358000f, 0.329000f, 0.321000f, 0.356000f,
                0.262000f, 0.356000f, 0.240000f, 0.356000f,
                0.206000f, 0.353000f, 0.206000f, 0.124000f
            };

        private static readonly byte[] MyriadProGlyph1067Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1067Coordinates =
            {
                0.131000f, 0.609000f, 0.131000f, 0.407000f,
                0.155000f, 0.412000f, 0.195000f, 0.412000f,
                0.285000f, 0.412000f, 0.340000f, 0.372000f,
                0.403000f, 0.327000f, 0.403000f, 0.243000f,
                0.403000f, 0.173000f, 0.361000f, 0.129000f,
                0.330000f, 0.096000f, 0.276000f, 0.080000f,
                0.228000f, 0.065000f, 0.169000f, 0.065000f,
                0.136000f, 0.065000f, 0.106000f, 0.067000f,
                0.081000f, 0.069000f, 0.061000f, 0.072000f,
                0.061000f, 0.609000f, 0.131000f, 0.609000f,
                0.131000f, 0.124000f, 0.149000f, 0.120000f,
                0.187000f, 0.120000f, 0.248000f, 0.120000f,
                0.287000f, 0.150000f, 0.330000f, 0.182000f,
                0.330000f, 0.241000f, 0.330000f, 0.299000f,
                0.285000f, 0.330000f, 0.246000f, 0.356000f,
                0.186000f, 0.356000f, 0.170000f, 0.356000f,
                0.152000f, 0.355000f, 0.146000f, 0.354000f,
                0.139000f, 0.353000f, 0.131000f, 0.353000f,
                0.131000f, 0.124000f, 0.533000f, 0.609000f,
                0.533000f, 0.070000f, 0.463000f, 0.070000f,
                0.463000f, 0.609000f, 0.533000f, 0.609000f
            };

        private static readonly byte[] MyriadProGlyph1068Commands =
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
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1068Coordinates =
            {
                0.131000f, 0.609000f, 0.131000f, 0.408000f,
                0.157000f, 0.412000f, 0.197000f, 0.412000f,
                0.287000f, 0.412000f, 0.342000f, 0.373000f,
                0.405000f, 0.328000f, 0.405000f, 0.244000f,
                0.405000f, 0.173000f, 0.363000f, 0.129000f,
                0.332000f, 0.096000f, 0.278000f, 0.080000f,
                0.230000f, 0.065000f, 0.170000f, 0.065000f,
                0.136000f, 0.065000f, 0.106000f, 0.067000f,
                0.081000f, 0.069000f, 0.061000f, 0.072000f,
                0.061000f, 0.609000f, 0.131000f, 0.609000f,
                0.131000f, 0.124000f, 0.151000f, 0.120000f,
                0.188000f, 0.120000f, 0.251000f, 0.120000f,
                0.289000f, 0.149000f, 0.332000f, 0.181000f,
                0.332000f, 0.240000f, 0.332000f, 0.299000f,
                0.289000f, 0.329000f, 0.250000f, 0.356000f,
                0.187000f, 0.356000f, 0.166000f, 0.356000f,
                0.131000f, 0.353000f, 0.131000f, 0.124000f
            };

        private static readonly byte[] MyriadProGlyph1069Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1069Coordinates =
            {
                0.099000f, 0.374000f, 0.350000f, 0.374000f,
                0.343000f, 0.456000f, 0.296000f, 0.507000f,
                0.246000f, 0.561000f, 0.166000f, 0.561000f,
                0.135000f, 0.561000f, 0.104000f, 0.553000f,
                0.079000f, 0.547000f, 0.050000f, 0.534000f,
                0.033000f, 0.587000f, 0.064000f, 0.601000f,
                0.096000f, 0.609000f, 0.133000f, 0.618000f,
                0.170000f, 0.618000f, 0.292000f, 0.618000f,
                0.361000f, 0.538000f, 0.425000f, 0.462000f,
                0.425000f, 0.340000f, 0.425000f, 0.211000f,
                0.349000f, 0.134000f, 0.277000f, 0.061000f,
                0.165000f, 0.061000f, 0.086000f, 0.061000f,
                0.024000f, 0.089000f, 0.039000f, 0.145000f,
                0.093000f, 0.120000f, 0.156000f, 0.120000f,
                0.242000f, 0.120000f, 0.296000f, 0.177000f,
                0.347000f, 0.232000f, 0.350000f, 0.318000f,
                0.099000f, 0.318000f, 0.099000f, 0.374000f
            };

        private static readonly byte[] MyriadProGlyph1070Commands =
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1070Coordinates =
            {
                0.131000f, 0.609000f, 0.131000f, 0.377000f,
                0.211000f, 0.377000f, 0.221000f, 0.490000f,
                0.283000f, 0.555000f, 0.345000f, 0.619000f,
                0.440000f, 0.619000f, 0.544000f, 0.619000f,
                0.605000f, 0.543000f, 0.665000f, 0.468000f,
                0.665000f, 0.345000f, 0.665000f, 0.210000f,
                0.597000f, 0.133000f, 0.534000f, 0.061000f,
                0.433000f, 0.061000f, 0.335000f, 0.061000f,
                0.274000f, 0.131000f, 0.213000f, 0.200000f,
                0.209000f, 0.318000f, 0.131000f, 0.318000f,
                0.131000f, 0.070000f, 0.061000f, 0.070000f,
                0.061000f, 0.609000f, 0.131000f, 0.609000f,
                0.553000f, 0.184000f, 0.594000f, 0.246000f,
                0.594000f, 0.342000f, 0.594000f, 0.431000f,
                0.556000f, 0.493000f, 0.512000f, 0.563000f,
                0.437000f, 0.563000f, 0.361000f, 0.563000f,
                0.317000f, 0.494000f, 0.278000f, 0.431000f,
                0.278000f, 0.337000f, 0.278000f, 0.246000f,
                0.319000f, 0.185000f, 0.363000f, 0.117000f,
                0.436000f, 0.117000f, 0.510000f, 0.117000f,
                0.553000f, 0.184000f
            };

        private static readonly byte[] MyriadProGlyph1071Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1071Coordinates =
            {
                0.011000f, 0.070000f, 0.022000f, 0.089000f,
                0.033000f, 0.119000f, 0.066000f, 0.216000f,
                0.076000f, 0.243000f, 0.086000f, 0.262000f,
                0.099000f, 0.284000f, 0.114000f, 0.300000f,
                0.133000f, 0.319000f, 0.160000f, 0.328000f,
                0.160000f, 0.329000f, 0.107000f, 0.338000f,
                0.075000f, 0.372000f, 0.041000f, 0.409000f,
                0.041000f, 0.462000f, 0.041000f, 0.531000f,
                0.090000f, 0.572000f, 0.142000f, 0.613000f,
                0.245000f, 0.613000f, 0.319000f, 0.613000f,
                0.373000f, 0.602000f, 0.373000f, 0.070000f,
                0.304000f, 0.070000f, 0.304000f, 0.304000f,
                0.252000f, 0.304000f, 0.201000f, 0.304000f,
                0.175000f, 0.277000f, 0.162000f, 0.264000f,
                0.151000f, 0.242000f, 0.142000f, 0.225000f,
                0.133000f, 0.199000f, 0.129000f, 0.188000f,
                0.125000f, 0.175000f, 0.118000f, 0.152000f,
                0.109000f, 0.123000f, 0.104000f, 0.109000f,
                0.094000f, 0.087000f, 0.086000f, 0.070000f,
                0.011000f, 0.070000f, 0.304000f, 0.553000f,
                0.294000f, 0.555000f, 0.278000f, 0.557000f,
                0.260000f, 0.559000f, 0.237000f, 0.559000f,
                0.181000f, 0.559000f, 0.149000f, 0.537000f,
                0.111000f, 0.511000f, 0.111000f, 0.459000f,
                0.111000f, 0.411000f, 0.149000f, 0.384000f,
                0.186000f, 0.357000f, 0.245000f, 0.357000f,
                0.278000f, 0.357000f, 0.304000f, 0.358000f,
                0.304000f, 0.553000f
            };

        private static readonly byte[] MyriadProGlyph1072Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1072Coordinates =
            {
                0.330000f, 0.163000f, 0.330000f, 0.107000f,
                0.336000f, 0.070000f, 0.273000f, 0.070000f,
                0.267000f, 0.119000f, 0.265000f, 0.119000f,
                0.247000f, 0.094000f, 0.218000f, 0.079000f,
                0.185000f, 0.061000f, 0.146000f, 0.061000f,
                0.091000f, 0.061000f, 0.058000f, 0.096000f,
                0.028000f, 0.127000f, 0.028000f, 0.173000f,
                0.028000f, 0.318000f, 0.261000f, 0.317000f,
                0.261000f, 0.325000f, 0.261000f, 0.339000f,
                0.258000f, 0.352000f, 0.255000f, 0.369000f,
                0.247000f, 0.381000f, 0.225000f, 0.414000f,
                0.173000f, 0.413000f, 0.114000f, 0.413000f,
                0.071000f, 0.385000f, 0.055000f, 0.432000f,
                0.109000f, 0.465000f, 0.183000f, 0.465000f,
                0.264000f, 0.465000f, 0.301000f, 0.415000f,
                0.317000f, 0.394000f, 0.324000f, 0.365000f,
                0.330000f, 0.339000f, 0.330000f, 0.308000f,
                0.330000f, 0.163000f, 0.262000f, 0.268000f,
                0.230000f, 0.268000f, 0.204000f, 0.265000f,
                0.174000f, 0.262000f, 0.152000f, 0.253000f,
                0.098000f, 0.232000f, 0.098000f, 0.181000f,
                0.098000f, 0.113000f, 0.164000f, 0.113000f,
                0.200000f, 0.113000f, 0.227000f, 0.134000f,
                0.250000f, 0.151000f, 0.259000f, 0.178000f,
                0.262000f, 0.189000f, 0.262000f, 0.201000f,
                0.262000f, 0.268000f
            };

        private static readonly byte[] MyriadProGlyph1073Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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

        private static readonly float[] MyriadProGlyph1073Coordinates =
            {
                0.351000f, 0.589000f, 0.338000f, 0.584000f,
                0.313000f, 0.579000f, 0.295000f, 0.575000f,
                0.270000f, 0.571000f, 0.172000f, 0.556000f,
                0.132000f, 0.498000f, 0.115000f, 0.474000f,
                0.103000f, 0.437000f, 0.093000f, 0.404000f,
                0.090000f, 0.370000f, 0.092000f, 0.370000f,
                0.131000f, 0.457000f, 0.227000f, 0.457000f,
                0.301000f, 0.457000f, 0.345000f, 0.408000f,
                0.392000f, 0.356000f, 0.392000f, 0.266000f,
                0.392000f, 0.171000f, 0.345000f, 0.116000f,
                0.297000f, 0.061000f, 0.213000f, 0.061000f,
                0.119000f, 0.061000f, 0.071000f, 0.142000f,
                0.051000f, 0.177000f, 0.041000f, 0.226000f,
                0.032000f, 0.270000f, 0.032000f, 0.321000f,
                0.032000f, 0.458000f, 0.092000f, 0.535000f,
                0.140000f, 0.606000f, 0.258000f, 0.626000f,
                0.283000f, 0.631000f, 0.309000f, 0.635000f,
                0.337000f, 0.641000f, 0.354000f, 0.647000f,
                0.351000f, 0.589000f, 0.298000f, 0.357000f,
                0.269000f, 0.405000f, 0.213000f, 0.405000f,
                0.153000f, 0.405000f, 0.125000f, 0.353000f,
                0.106000f, 0.318000f, 0.106000f, 0.270000f,
                0.106000f, 0.213000f, 0.131000f, 0.168000f,
                0.162000f, 0.113000f, 0.214000f, 0.113000f,
                0.269000f, 0.113000f, 0.297000f, 0.160000f,
                0.321000f, 0.200000f, 0.321000f, 0.261000f,
                0.321000f, 0.318000f, 0.298000f, 0.357000f
            };

        private static readonly byte[] MyriadProGlyph1074Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1074Coordinates =
            {
                0.056000f, 0.453000f, 0.107000f, 0.461000f,
                0.179000f, 0.461000f, 0.209000f, 0.461000f,
                0.234000f, 0.458000f, 0.266000f, 0.454000f,
                0.290000f, 0.445000f, 0.352000f, 0.421000f,
                0.352000f, 0.365000f, 0.352000f, 0.294000f,
                0.271000f, 0.277000f, 0.271000f, 0.275000f,
                0.370000f, 0.261000f, 0.370000f, 0.180000f,
                0.370000f, 0.144000f, 0.348000f, 0.119000f,
                0.330000f, 0.098000f, 0.296000f, 0.085000f,
                0.268000f, 0.074000f, 0.230000f, 0.069000f,
                0.200000f, 0.065000f, 0.166000f, 0.065000f,
                0.137000f, 0.065000f, 0.102000f, 0.067000f,
                0.056000f, 0.070000f, 0.056000f, 0.453000f,
                0.124000f, 0.294000f, 0.177000f, 0.294000f,
                0.221000f, 0.294000f, 0.249000f, 0.308000f,
                0.282000f, 0.324000f, 0.282000f, 0.356000f,
                0.282000f, 0.413000f, 0.178000f, 0.413000f,
                0.163000f, 0.413000f, 0.148000f, 0.412000f,
                0.124000f, 0.409000f, 0.124000f, 0.294000f,
                0.123000f, 0.116000f, 0.153000f, 0.113000f,
                0.179000f, 0.113000f, 0.200000f, 0.113000f,
                0.218000f, 0.116000f, 0.240000f, 0.119000f,
                0.256000f, 0.126000f, 0.298000f, 0.143000f,
                0.298000f, 0.181000f, 0.298000f, 0.219000f,
                0.261000f, 0.236000f, 0.232000f, 0.249000f,
                0.174000f, 0.249000f, 0.123000f, 0.249000f,
                0.123000f, 0.116000f
            };

        private static readonly byte[] MyriadProGlyph1075Commands =
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

        private static readonly float[] MyriadProGlyph1075Coordinates =
            {
                0.295000f, 0.457000f, 0.295000f, 0.401000f,
                0.127000f, 0.401000f, 0.127000f, 0.070000f,
                0.057000f, 0.070000f, 0.057000f, 0.457000f,
                0.295000f, 0.457000f
            };

        private static readonly byte[] MyriadProGlyph1076Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1076Coordinates =
            {
                0.358000f, 0.457000f, 0.358000f, 0.123000f,
                0.398000f, 0.122000f, 0.394000f, -0.052000f,
                0.339000f, -0.052000f, 0.336000f, 0.070000f,
                0.068000f, 0.070000f, 0.064000f, -0.052000f,
                0.009000f, -0.052000f, 0.006000f, 0.121000f,
                0.039000f, 0.123000f, 0.064000f, 0.160000f,
                0.077000f, 0.202000f, 0.100000f, 0.273000f,
                0.100000f, 0.357000f, 0.100000f, 0.457000f,
                0.358000f, 0.457000f, 0.161000f, 0.341000f,
                0.161000f, 0.259000f, 0.141000f, 0.196000f,
                0.130000f, 0.158000f, 0.111000f, 0.124000f,
                0.289000f, 0.124000f, 0.289000f, 0.404000f,
                0.161000f, 0.404000f, 0.161000f, 0.341000f
            };

        private static readonly byte[] MyriadProGlyph1077Commands =
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

        private static readonly float[] MyriadProGlyph1077Coordinates =
            {
                0.097000f, 0.251000f, 0.098000f, 0.183000f,
                0.138000f, 0.148000f, 0.172000f, 0.117000f,
                0.230000f, 0.117000f, 0.265000f, 0.117000f,
                0.293000f, 0.122000f, 0.315000f, 0.127000f,
                0.337000f, 0.137000f, 0.350000f, 0.086000f,
                0.327000f, 0.076000f, 0.299000f, 0.070000f,
                0.262000f, 0.061000f, 0.220000f, 0.061000f,
                0.132000f, 0.061000f, 0.081000f, 0.116000f,
                0.030000f, 0.169000f, 0.030000f, 0.257000f,
                0.030000f, 0.347000f, 0.079000f, 0.405000f,
                0.129000f, 0.465000f, 0.212000f, 0.465000f,
                0.257000f, 0.465000f, 0.290000f, 0.447000f,
                0.320000f, 0.431000f, 0.339000f, 0.401000f,
                0.356000f, 0.376000f, 0.364000f, 0.342000f,
                0.372000f, 0.314000f, 0.372000f, 0.284000f,
                0.372000f, 0.263000f, 0.369000f, 0.251000f,
                0.097000f, 0.251000f, 0.304000f, 0.301000f,
                0.304000f, 0.344000f, 0.285000f, 0.375000f,
                0.259000f, 0.415000f, 0.206000f, 0.415000f,
                0.157000f, 0.415000f, 0.127000f, 0.377000f,
                0.103000f, 0.346000f, 0.098000f, 0.301000f,
                0.304000f, 0.301000f
            };

        private static readonly byte[] MyriadProGlyph1078Commands =
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1078Coordinates =
            {
                0.091000f, 0.457000f, 0.220000f, 0.289000f,
                0.234000f, 0.289000f, 0.234000f, 0.457000f,
                0.301000f, 0.457000f, 0.301000f, 0.289000f,
                0.315000f, 0.289000f, 0.443000f, 0.457000f,
                0.523000f, 0.457000f, 0.371000f, 0.281000f,
                0.451000f, 0.273000f, 0.487000f, 0.179000f,
                0.507000f, 0.122000f, 0.519000f, 0.089000f,
                0.529000f, 0.070000f, 0.459000f, 0.070000f,
                0.450000f, 0.086000f, 0.440000f, 0.111000f,
                0.423000f, 0.159000f, 0.392000f, 0.241000f,
                0.313000f, 0.241000f, 0.301000f, 0.241000f,
                0.301000f, 0.070000f, 0.234000f, 0.070000f,
                0.234000f, 0.241000f, 0.222000f, 0.241000f,
                0.141000f, 0.241000f, 0.110000f, 0.158000f,
                0.092000f, 0.111000f, 0.082000f, 0.086000f,
                0.074000f, 0.070000f, 0.005000f, 0.070000f,
                0.015000f, 0.090000f, 0.028000f, 0.122000f,
                0.030000f, 0.129000f, 0.033000f, 0.136000f,
                0.048000f, 0.178000f, 0.085000f, 0.273000f,
                0.164000f, 0.281000f, 0.011000f, 0.457000f,
                0.091000f, 0.457000f
            };

        private static readonly byte[] MyriadProGlyph1079Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1079Coordinates =
            {
                0.090000f, 0.295000f, 0.124000f, 0.295000f,
                0.223000f, 0.295000f, 0.223000f, 0.358000f,
                0.223000f, 0.415000f, 0.148000f, 0.415000f,
                0.099000f, 0.415000f, 0.054000f, 0.387000f,
                0.036000f, 0.430000f, 0.094000f, 0.465000f,
                0.165000f, 0.465000f, 0.217000f, 0.465000f,
                0.253000f, 0.443000f, 0.296000f, 0.415000f,
                0.296000f, 0.364000f, 0.296000f, 0.330000f,
                0.269000f, 0.305000f, 0.245000f, 0.283000f,
                0.209000f, 0.276000f, 0.209000f, 0.274000f,
                0.255000f, 0.270000f, 0.284000f, 0.245000f,
                0.315000f, 0.218000f, 0.315000f, 0.177000f,
                0.315000f, 0.119000f, 0.262000f, 0.089000f,
                0.216000f, 0.062000f, 0.148000f, 0.062000f,
                0.078000f, 0.062000f, 0.022000f, 0.093000f,
                0.040000f, 0.141000f, 0.088000f, 0.114000f,
                0.143000f, 0.114000f, 0.238000f, 0.114000f,
                0.238000f, 0.181000f, 0.238000f, 0.217000f,
                0.204000f, 0.233000f, 0.175000f, 0.247000f,
                0.125000f, 0.247000f, 0.091000f, 0.247000f,
                0.090000f, 0.295000f
            };

        private static readonly byte[] MyriadProGlyph1080Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1080Coordinates =
            {
                0.123000f, 0.457000f, 0.123000f, 0.294000f,
                0.123000f, 0.251000f, 0.122000f, 0.215000f,
                0.118000f, 0.139000f, 0.121000f, 0.138000f,
                0.152000f, 0.199000f, 0.167000f, 0.229000f,
                0.184000f, 0.257000f, 0.305000f, 0.457000f,
                0.387000f, 0.457000f, 0.387000f, 0.070000f,
                0.320000f, 0.070000f, 0.320000f, 0.234000f,
                0.320000f, 0.278000f, 0.321000f, 0.314000f,
                0.322000f, 0.330000f, 0.323000f, 0.351000f,
                0.325000f, 0.393000f, 0.323000f, 0.393000f,
                0.301000f, 0.349000f, 0.290000f, 0.329000f,
                0.274000f, 0.300000f, 0.258000f, 0.273000f,
                0.138000f, 0.070000f, 0.056000f, 0.070000f,
                0.056000f, 0.457000f, 0.123000f, 0.457000f
            };

        private static readonly byte[] MyriadProGlyph1081Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1081Coordinates =
            {
                0.123000f, 0.457000f, 0.123000f, 0.294000f,
                0.123000f, 0.251000f, 0.122000f, 0.215000f,
                0.118000f, 0.139000f, 0.121000f, 0.138000f,
                0.152000f, 0.199000f, 0.167000f, 0.229000f,
                0.184000f, 0.257000f, 0.305000f, 0.457000f,
                0.387000f, 0.457000f, 0.387000f, 0.070000f,
                0.320000f, 0.070000f, 0.320000f, 0.234000f,
                0.320000f, 0.278000f, 0.321000f, 0.314000f,
                0.322000f, 0.330000f, 0.323000f, 0.351000f,
                0.325000f, 0.393000f, 0.323000f, 0.393000f,
                0.301000f, 0.349000f, 0.290000f, 0.329000f,
                0.274000f, 0.300000f, 0.258000f, 0.273000f,
                0.138000f, 0.070000f, 0.056000f, 0.070000f,
                0.056000f, 0.457000f, 0.123000f, 0.457000f,
                0.169000f, 0.615000f, 0.173000f, 0.554000f,
                0.220000f, 0.554000f, 0.267000f, 0.554000f,
                0.274000f, 0.615000f, 0.325000f, 0.615000f,
                0.319000f, 0.516000f, 0.218000f, 0.516000f,
                0.169000f, 0.516000f, 0.143000f, 0.545000f,
                0.120000f, 0.570000f, 0.118000f, 0.615000f,
                0.169000f, 0.615000f
            };

        private static readonly byte[] MyriadProGlyph1082Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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

        private static readonly float[] MyriadProGlyph1082Coordinates =
            {
                0.128000f, 0.457000f, 0.128000f, 0.289000f,
                0.144000f, 0.289000f, 0.289000f, 0.457000f,
                0.375000f, 0.457000f, 0.207000f, 0.283000f,
                0.290000f, 0.273000f, 0.337000f, 0.165000f,
                0.355000f, 0.120000f, 0.367000f, 0.090000f,
                0.378000f, 0.070000f, 0.304000f, 0.070000f,
                0.297000f, 0.082000f, 0.287000f, 0.104000f,
                0.280000f, 0.121000f, 0.268000f, 0.149000f,
                0.230000f, 0.241000f, 0.141000f, 0.241000f,
                0.128000f, 0.241000f, 0.128000f, 0.070000f,
                0.058000f, 0.070000f, 0.058000f, 0.457000f,
                0.128000f, 0.457000f
            };

        private static readonly byte[] MyriadProGlyph1083Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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

        private static readonly float[] MyriadProGlyph1083Coordinates =
            {
                0.350000f, 0.457000f, 0.350000f, 0.070000f,
                0.280000f, 0.070000f, 0.280000f, 0.402000f,
                0.147000f, 0.402000f, 0.147000f, 0.303000f,
                0.147000f, 0.214000f, 0.135000f, 0.167000f,
                0.122000f, 0.112000f, 0.086000f, 0.089000f,
                0.056000f, 0.065000f, 0.009000f, 0.065000f,
                0.002000f, 0.120000f, 0.026000f, 0.124000f,
                0.040000f, 0.136000f, 0.065000f, 0.154000f,
                0.074000f, 0.197000f, 0.078000f, 0.216000f,
                0.079000f, 0.244000f, 0.080000f, 0.267000f,
                0.080000f, 0.303000f, 0.080000f, 0.457000f,
                0.350000f, 0.457000f
            };

        private static readonly byte[] MyriadProGlyph1084Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1084Coordinates =
            {
                0.064000f, 0.457000f, 0.150000f, 0.457000f,
                0.220000f, 0.262000f, 0.228000f, 0.238000f,
                0.238000f, 0.210000f, 0.249000f, 0.177000f,
                0.255000f, 0.156000f, 0.256000f, 0.156000f,
                0.263000f, 0.177000f, 0.277000f, 0.217000f,
                0.290000f, 0.254000f, 0.303000f, 0.289000f,
                0.364000f, 0.457000f, 0.452000f, 0.457000f,
                0.479000f, 0.070000f, 0.412000f, 0.070000f,
                0.396000f, 0.393000f, 0.394000f, 0.393000f,
                0.387000f, 0.370000f, 0.377000f, 0.340000f,
                0.372000f, 0.327000f, 0.365000f, 0.308000f,
                0.276000f, 0.073000f, 0.226000f, 0.073000f,
                0.157000f, 0.265000f, 0.137000f, 0.322000f,
                0.118000f, 0.393000f, 0.115000f, 0.393000f,
                0.112000f, 0.322000f, 0.111000f, 0.281000f,
                0.109000f, 0.253000f, 0.099000f, 0.070000f,
                0.034000f, 0.070000f, 0.064000f, 0.457000f
            };

        private static readonly byte[] MyriadProGlyph1085Commands =
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

        private static readonly float[] MyriadProGlyph1085Coordinates =
            {
                0.126000f, 0.457000f, 0.126000f, 0.301000f,
                0.310000f, 0.301000f, 0.310000f, 0.457000f,
                0.380000f, 0.457000f, 0.380000f, 0.070000f,
                0.310000f, 0.070000f, 0.310000f, 0.245000f,
                0.126000f, 0.245000f, 0.126000f, 0.070000f,
                0.056000f, 0.070000f, 0.056000f, 0.457000f,
                0.126000f, 0.457000f
            };

        private static readonly byte[] MyriadProGlyph1086Commands =
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

        private static readonly float[] MyriadProGlyph1086Coordinates =
            {
                0.357000f, 0.410000f, 0.408000f, 0.355000f,
                0.408000f, 0.267000f, 0.408000f, 0.167000f,
                0.347000f, 0.111000f, 0.293000f, 0.061000f,
                0.216000f, 0.061000f, 0.136000f, 0.061000f,
                0.084000f, 0.115000f, 0.030000f, 0.171000f,
                0.030000f, 0.261000f, 0.030000f, 0.355000f,
                0.086000f, 0.411000f, 0.140000f, 0.465000f,
                0.222000f, 0.465000f, 0.305000f, 0.465000f,
                0.357000f, 0.410000f, 0.130000f, 0.365000f,
                0.102000f, 0.324000f, 0.102000f, 0.263000f,
                0.102000f, 0.199000f, 0.135000f, 0.157000f,
                0.168000f, 0.114000f, 0.219000f, 0.114000f,
                0.269000f, 0.114000f, 0.303000f, 0.157000f,
                0.336000f, 0.199000f, 0.336000f, 0.265000f,
                0.336000f, 0.322000f, 0.310000f, 0.363000f,
                0.278000f, 0.413000f, 0.220000f, 0.413000f,
                0.163000f, 0.413000f, 0.130000f, 0.365000f
            };

        private static readonly byte[] MyriadProGlyph1087Commands =
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

        private static readonly float[] MyriadProGlyph1087Coordinates =
            {
                0.377000f, 0.457000f, 0.377000f, 0.070000f,
                0.306000f, 0.070000f, 0.306000f, 0.402000f,
                0.126000f, 0.402000f, 0.126000f, 0.070000f,
                0.056000f, 0.070000f, 0.056000f, 0.457000f,
                0.377000f, 0.457000f
            };

        private static readonly byte[] MyriadProGlyph1088Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1088Coordinates =
            {
                0.058000f, 0.331000f, 0.058000f, 0.364000f,
                0.057000f, 0.399000f, 0.055000f, 0.457000f,
                0.117000f, 0.457000f, 0.121000f, 0.391000f,
                0.123000f, 0.391000f, 0.167000f, 0.465000f,
                0.261000f, 0.465000f, 0.332000f, 0.465000f,
                0.378000f, 0.411000f, 0.425000f, 0.356000f,
                0.425000f, 0.269000f, 0.425000f, 0.170000f,
                0.371000f, 0.113000f, 0.322000f, 0.061000f,
                0.249000f, 0.061000f, 0.166000f, 0.061000f,
                0.129000f, 0.122000f, 0.128000f, 0.122000f,
                0.128000f, -0.088000f, 0.058000f, -0.088000f,
                0.058000f, 0.331000f, 0.128000f, 0.228000f,
                0.128000f, 0.211000f, 0.131000f, 0.199000f,
                0.153000f, 0.117000f, 0.237000f, 0.117000f,
                0.292000f, 0.117000f, 0.323000f, 0.158000f,
                0.354000f, 0.199000f, 0.354000f, 0.266000f,
                0.354000f, 0.327000f, 0.325000f, 0.367000f,
                0.293000f, 0.409000f, 0.239000f, 0.409000f,
                0.154000f, 0.409000f, 0.133000f, 0.323000f,
                0.128000f, 0.305000f, 0.128000f, 0.295000f,
                0.128000f, 0.228000f
            };

        private static readonly byte[] MyriadProGlyph1089Commands =
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

        private static readonly float[] MyriadProGlyph1089Coordinates =
            {
                0.334000f, 0.084000f, 0.316000f, 0.075000f,
                0.291000f, 0.069000f, 0.258000f, 0.061000f,
                0.223000f, 0.061000f, 0.135000f, 0.061000f,
                0.083000f, 0.116000f, 0.030000f, 0.170000f,
                0.030000f, 0.259000f, 0.030000f, 0.350000f,
                0.087000f, 0.407000f, 0.144000f, 0.465000f,
                0.238000f, 0.465000f, 0.297000f, 0.465000f,
                0.336000f, 0.445000f, 0.320000f, 0.391000f,
                0.304000f, 0.399000f, 0.287000f, 0.404000f,
                0.264000f, 0.409000f, 0.238000f, 0.409000f,
                0.174000f, 0.409000f, 0.136000f, 0.366000f,
                0.101000f, 0.326000f, 0.101000f, 0.263000f,
                0.101000f, 0.197000f, 0.140000f, 0.157000f,
                0.177000f, 0.118000f, 0.236000f, 0.118000f,
                0.263000f, 0.118000f, 0.286000f, 0.124000f,
                0.303000f, 0.128000f, 0.322000f, 0.137000f,
                0.334000f, 0.084000f
            };

        private static readonly byte[] MyriadProGlyph1090Commands =
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

        private static readonly float[] MyriadProGlyph1090Coordinates =
            {
                0.320000f, 0.457000f, 0.320000f, 0.402000f,
                0.199000f, 0.402000f, 0.199000f, 0.070000f,
                0.129000f, 0.070000f, 0.129000f, 0.402000f,
                0.008000f, 0.402000f, 0.008000f, 0.457000f,
                0.320000f, 0.457000f
            };

        private static readonly byte[] MyriadProGlyph1091Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1091Coordinates =
            {
                0.084000f, 0.457000f, 0.168000f, 0.229000f,
                0.182000f, 0.191000f, 0.193000f, 0.149000f,
                0.195000f, 0.149000f, 0.220000f, 0.230000f,
                0.297000f, 0.457000f, 0.371000f, 0.457000f,
                0.265000f, 0.181000f, 0.194000f, -0.007000f,
                0.133000f, -0.061000f, 0.109000f, -0.081000f,
                0.083000f, -0.093000f, 0.063000f, -0.103000f,
                0.046000f, -0.106000f, 0.029000f, -0.047000f,
                0.062000f, -0.037000f, 0.090000f, -0.013000f,
                0.126000f, 0.015000f, 0.149000f, 0.065000f,
                0.152000f, 0.072000f, 0.153000f, 0.075000f,
                0.155000f, 0.079000f, 0.155000f, 0.082000f,
                0.155000f, 0.088000f, 0.149000f, 0.101000f,
                0.007000f, 0.457000f, 0.084000f, 0.457000f
            };

        private static readonly byte[] MyriadProGlyph1092Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1092Coordinates =
            {
                0.289000f, 0.637000f, 0.288000f, 0.465000f,
                0.375000f, 0.458000f, 0.428000f, 0.406000f,
                0.483000f, 0.352000f, 0.483000f, 0.265000f,
                0.483000f, 0.173000f, 0.426000f, 0.119000f,
                0.374000f, 0.069000f, 0.288000f, 0.063000f,
                0.289000f, -0.088000f, 0.224000f, -0.088000f,
                0.224000f, 0.062000f, 0.138000f, 0.068000f,
                0.085000f, 0.119000f, 0.030000f, 0.172000f,
                0.030000f, 0.261000f, 0.030000f, 0.352000f,
                0.086000f, 0.407000f, 0.138000f, 0.457000f,
                0.224000f, 0.464000f, 0.224000f, 0.637000f,
                0.289000f, 0.637000f, 0.224000f, 0.416000f,
                0.167000f, 0.409000f, 0.133000f, 0.365000f,
                0.100000f, 0.323000f, 0.100000f, 0.262000f,
                0.100000f, 0.202000f, 0.133000f, 0.161000f,
                0.167000f, 0.118000f, 0.224000f, 0.111000f,
                0.224000f, 0.416000f, 0.288000f, 0.110000f,
                0.346000f, 0.118000f, 0.380000f, 0.162000f,
                0.413000f, 0.204000f, 0.413000f, 0.265000f,
                0.413000f, 0.399000f, 0.288000f, 0.416000f,
                0.288000f, 0.110000f
            };

        private static readonly byte[] MyriadProGlyph1093Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1093Coordinates =
            {
                0.091000f, 0.457000f, 0.146000f, 0.374000f,
                0.165000f, 0.347000f, 0.186000f, 0.312000f,
                0.188000f, 0.312000f, 0.227000f, 0.375000f,
                0.280000f, 0.457000f, 0.357000f, 0.457000f,
                0.225000f, 0.270000f, 0.360000f, 0.070000f,
                0.281000f, 0.070000f, 0.224000f, 0.157000f,
                0.213000f, 0.173000f, 0.202000f, 0.191000f,
                0.182000f, 0.225000f, 0.180000f, 0.225000f,
                0.163000f, 0.193000f, 0.140000f, 0.157000f,
                0.084000f, 0.070000f, 0.006000f, 0.070000f,
                0.144000f, 0.268000f, 0.012000f, 0.457000f,
                0.091000f, 0.457000f
            };

        private static readonly byte[] MyriadProGlyph1094Commands =
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

        private static readonly float[] MyriadProGlyph1094Coordinates =
            {
                0.126000f, 0.457000f, 0.126000f, 0.125000f,
                0.305000f, 0.125000f, 0.305000f, 0.457000f,
                0.374000f, 0.457000f, 0.374000f, 0.123000f,
                0.414000f, 0.122000f, 0.410000f, -0.052000f,
                0.355000f, -0.052000f, 0.352000f, 0.070000f,
                0.056000f, 0.070000f, 0.056000f, 0.457000f,
                0.126000f, 0.457000f
            };

        private static readonly byte[] MyriadProGlyph1095Commands =
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1095Coordinates =
            {
                0.122000f, 0.457000f, 0.122000f, 0.327000f,
                0.122000f, 0.245000f, 0.202000f, 0.245000f,
                0.249000f, 0.245000f, 0.286000f, 0.271000f,
                0.286000f, 0.457000f, 0.355000f, 0.457000f,
                0.355000f, 0.065000f, 0.286000f, 0.065000f,
                0.286000f, 0.221000f, 0.285000f, 0.221000f,
                0.240000f, 0.193000f, 0.179000f, 0.193000f,
                0.121000f, 0.193000f, 0.088000f, 0.222000f,
                0.052000f, 0.255000f, 0.052000f, 0.318000f,
                0.052000f, 0.457000f, 0.122000f, 0.457000f
            };

        private static readonly byte[] MyriadProGlyph1096Commands =
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

        private static readonly float[] MyriadProGlyph1096Coordinates =
            {
                0.126000f, 0.457000f, 0.126000f, 0.125000f,
                0.260000f, 0.125000f, 0.260000f, 0.457000f,
                0.330000f, 0.457000f, 0.330000f, 0.125000f,
                0.464000f, 0.125000f, 0.464000f, 0.457000f,
                0.534000f, 0.457000f, 0.534000f, 0.070000f,
                0.056000f, 0.070000f, 0.056000f, 0.457000f,
                0.126000f, 0.457000f
            };

        private static readonly byte[] MyriadProGlyph1097Commands =
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

        private static readonly float[] MyriadProGlyph1097Coordinates =
            {
                0.126000f, 0.457000f, 0.126000f, 0.125000f,
                0.261000f, 0.125000f, 0.261000f, 0.457000f,
                0.330000f, 0.457000f, 0.330000f, 0.125000f,
                0.465000f, 0.125000f, 0.465000f, 0.457000f,
                0.534000f, 0.457000f, 0.534000f, 0.123000f,
                0.574000f, 0.122000f, 0.570000f, -0.052000f,
                0.514000f, -0.052000f, 0.512000f, 0.070000f,
                0.056000f, 0.070000f, 0.056000f, 0.457000f,
                0.126000f, 0.457000f
            };

        private static readonly byte[] MyriadProGlyph1098Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1098Coordinates =
            {
                0.196000f, 0.457000f, 0.196000f, 0.327000f,
                0.226000f, 0.331000f, 0.262000f, 0.331000f,
                0.333000f, 0.331000f, 0.378000f, 0.303000f,
                0.434000f, 0.268000f, 0.434000f, 0.200000f,
                0.434000f, 0.144000f, 0.393000f, 0.110000f,
                0.364000f, 0.085000f, 0.317000f, 0.075000f,
                0.279000f, 0.066000f, 0.229000f, 0.066000f,
                0.177000f, 0.066000f, 0.125000f, 0.072000f,
                0.125000f, 0.402000f, 0.011000f, 0.402000f,
                0.011000f, 0.457000f, 0.196000f, 0.457000f,
                0.195000f, 0.120000f, 0.209000f, 0.118000f,
                0.218000f, 0.118000f, 0.232000f, 0.117000f,
                0.248000f, 0.117000f, 0.298000f, 0.117000f,
                0.328000f, 0.134000f, 0.364000f, 0.155000f,
                0.364000f, 0.197000f, 0.364000f, 0.243000f,
                0.325000f, 0.264000f, 0.295000f, 0.281000f,
                0.245000f, 0.281000f, 0.220000f, 0.281000f,
                0.195000f, 0.276000f, 0.195000f, 0.120000f
            };

        private static readonly byte[] MyriadProGlyph1099Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1099Coordinates =
            {
                0.126000f, 0.457000f, 0.126000f, 0.326000f,
                0.155000f, 0.331000f, 0.189000f, 0.331000f,
                0.259000f, 0.331000f, 0.304000f, 0.302000f,
                0.357000f, 0.267000f, 0.357000f, 0.201000f,
                0.357000f, 0.145000f, 0.316000f, 0.111000f,
                0.287000f, 0.086000f, 0.241000f, 0.075000f,
                0.205000f, 0.066000f, 0.160000f, 0.066000f,
                0.108000f, 0.066000f, 0.056000f, 0.072000f,
                0.056000f, 0.457000f, 0.126000f, 0.457000f,
                0.126000f, 0.120000f, 0.145000f, 0.117000f,
                0.174000f, 0.117000f, 0.221000f, 0.117000f,
                0.251000f, 0.135000f, 0.286000f, 0.157000f,
                0.286000f, 0.199000f, 0.286000f, 0.242000f,
                0.252000f, 0.263000f, 0.223000f, 0.281000f,
                0.178000f, 0.281000f, 0.147000f, 0.281000f,
                0.126000f, 0.276000f, 0.126000f, 0.120000f,
                0.475000f, 0.457000f, 0.475000f, 0.070000f,
                0.406000f, 0.070000f, 0.406000f, 0.457000f,
                0.475000f, 0.457000f
            };

        private static readonly byte[] MyriadProGlyph1100Commands =
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
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1100Coordinates =
            {
                0.126000f, 0.457000f, 0.126000f, 0.327000f,
                0.154000f, 0.331000f, 0.190000f, 0.331000f,
                0.226000f, 0.331000f, 0.255000f, 0.325000f,
                0.289000f, 0.318000f, 0.313000f, 0.304000f,
                0.370000f, 0.271000f, 0.370000f, 0.200000f,
                0.370000f, 0.145000f, 0.329000f, 0.111000f,
                0.300000f, 0.086000f, 0.250000f, 0.075000f,
                0.210000f, 0.066000f, 0.160000f, 0.066000f,
                0.108000f, 0.066000f, 0.056000f, 0.072000f,
                0.056000f, 0.457000f, 0.126000f, 0.457000f,
                0.126000f, 0.120000f, 0.145000f, 0.117000f,
                0.178000f, 0.117000f, 0.226000f, 0.117000f,
                0.258000f, 0.133000f, 0.299000f, 0.155000f,
                0.299000f, 0.198000f, 0.299000f, 0.244000f,
                0.257000f, 0.265000f, 0.226000f, 0.281000f,
                0.176000f, 0.281000f, 0.151000f, 0.281000f,
                0.126000f, 0.276000f, 0.126000f, 0.120000f
            };

        private static readonly byte[] MyriadProGlyph1101Commands =
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1101Coordinates =
            {
                0.075000f, 0.292000f, 0.269000f, 0.292000f,
                0.264000f, 0.345000f, 0.232000f, 0.376000f,
                0.197000f, 0.411000f, 0.136000f, 0.411000f,
                0.109000f, 0.411000f, 0.082000f, 0.404000f,
                0.063000f, 0.399000f, 0.044000f, 0.389000f,
                0.028000f, 0.436000f, 0.080000f, 0.465000f,
                0.148000f, 0.465000f, 0.236000f, 0.465000f,
                0.288000f, 0.411000f, 0.340000f, 0.356000f,
                0.340000f, 0.262000f, 0.340000f, 0.175000f,
                0.287000f, 0.120000f, 0.231000f, 0.062000f,
                0.136000f, 0.062000f, 0.071000f, 0.062000f,
                0.022000f, 0.089000f, 0.036000f, 0.138000f,
                0.053000f, 0.132000f, 0.064000f, 0.128000f,
                0.075000f, 0.125000f, 0.103000f, 0.117000f,
                0.132000f, 0.117000f, 0.259000f, 0.117000f,
                0.268000f, 0.243000f, 0.075000f, 0.243000f,
                0.075000f, 0.292000f
            };

        private static readonly byte[] MyriadProGlyph1102Commands =
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1102Coordinates =
            {
                0.126000f, 0.457000f, 0.126000f, 0.294000f,
                0.192000f, 0.294000f, 0.201000f, 0.371000f,
                0.248000f, 0.418000f, 0.294000f, 0.465000f,
                0.363000f, 0.465000f, 0.440000f, 0.465000f,
                0.487000f, 0.411000f, 0.534000f, 0.356000f,
                0.534000f, 0.267000f, 0.534000f, 0.175000f,
                0.483000f, 0.117000f, 0.434000f, 0.061000f,
                0.359000f, 0.061000f, 0.289000f, 0.061000f,
                0.243000f, 0.110000f, 0.197000f, 0.158000f,
                0.191000f, 0.241000f, 0.126000f, 0.241000f,
                0.126000f, 0.070000f, 0.057000f, 0.070000f,
                0.057000f, 0.457000f, 0.126000f, 0.457000f,
                0.439000f, 0.162000f, 0.463000f, 0.204000f,
                0.463000f, 0.265000f, 0.463000f, 0.325000f,
                0.438000f, 0.366000f, 0.410000f, 0.413000f,
                0.362000f, 0.413000f, 0.313000f, 0.413000f,
                0.284000f, 0.366000f, 0.258000f, 0.324000f,
                0.258000f, 0.261000f, 0.258000f, 0.201000f,
                0.284000f, 0.159000f, 0.312000f, 0.113000f,
                0.361000f, 0.113000f, 0.410000f, 0.113000f,
                0.439000f, 0.162000f
            };

        private static readonly byte[] MyriadProGlyph1103Commands =
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1103Coordinates =
            {
                0.341000f, 0.070000f, 0.271000f, 0.070000f,
                0.271000f, 0.233000f, 0.219000f, 0.233000f,
                0.178000f, 0.233000f, 0.155000f, 0.210000f,
                0.137000f, 0.196000f, 0.122000f, 0.162000f,
                0.118000f, 0.151000f, 0.111000f, 0.132000f,
                0.111000f, 0.131000f, 0.110000f, 0.130000f,
                0.100000f, 0.102000f, 0.094000f, 0.088000f,
                0.084000f, 0.070000f, 0.009000f, 0.070000f,
                0.023000f, 0.090000f, 0.033000f, 0.114000f,
                0.037000f, 0.124000f, 0.045000f, 0.144000f,
                0.051000f, 0.160000f, 0.054000f, 0.169000f,
                0.057000f, 0.176000f, 0.072000f, 0.213000f,
                0.094000f, 0.231000f, 0.113000f, 0.248000f,
                0.138000f, 0.253000f, 0.138000f, 0.255000f,
                0.096000f, 0.260000f, 0.068000f, 0.283000f,
                0.035000f, 0.310000f, 0.035000f, 0.352000f,
                0.035000f, 0.407000f, 0.087000f, 0.436000f,
                0.131000f, 0.462000f, 0.217000f, 0.462000f,
                0.285000f, 0.462000f, 0.341000f, 0.454000f,
                0.341000f, 0.070000f, 0.271000f, 0.411000f,
                0.242000f, 0.415000f, 0.213000f, 0.415000f,
                0.170000f, 0.415000f, 0.143000f, 0.402000f,
                0.108000f, 0.384000f, 0.108000f, 0.348000f,
                0.108000f, 0.314000f, 0.144000f, 0.295000f,
                0.174000f, 0.280000f, 0.211000f, 0.280000f,
                0.271000f, 0.280000f, 0.271000f, 0.411000f
            };

        private static readonly byte[] MyriadProGlyph1105Commands =
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
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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

        private static readonly float[] MyriadProGlyph1105Coordinates =
            {
                0.097000f, 0.251000f, 0.098000f, 0.183000f,
                0.138000f, 0.148000f, 0.172000f, 0.117000f,
                0.230000f, 0.117000f, 0.265000f, 0.117000f,
                0.293000f, 0.122000f, 0.315000f, 0.127000f,
                0.337000f, 0.137000f, 0.350000f, 0.086000f,
                0.327000f, 0.076000f, 0.299000f, 0.070000f,
                0.262000f, 0.061000f, 0.220000f, 0.061000f,
                0.132000f, 0.061000f, 0.081000f, 0.116000f,
                0.030000f, 0.169000f, 0.030000f, 0.257000f,
                0.030000f, 0.347000f, 0.079000f, 0.405000f,
                0.129000f, 0.465000f, 0.212000f, 0.465000f,
                0.257000f, 0.465000f, 0.290000f, 0.447000f,
                0.320000f, 0.431000f, 0.339000f, 0.401000f,
                0.356000f, 0.376000f, 0.364000f, 0.342000f,
                0.372000f, 0.314000f, 0.372000f, 0.284000f,
                0.372000f, 0.263000f, 0.369000f, 0.251000f,
                0.097000f, 0.251000f, 0.304000f, 0.301000f,
                0.304000f, 0.344000f, 0.285000f, 0.375000f,
                0.259000f, 0.415000f, 0.206000f, 0.415000f,
                0.157000f, 0.415000f, 0.127000f, 0.377000f,
                0.103000f, 0.346000f, 0.098000f, 0.301000f,
                0.304000f, 0.301000f, 0.100000f, 0.567000f,
                0.100000f, 0.608000f, 0.141000f, 0.608000f,
                0.180000f, 0.608000f, 0.180000f, 0.567000f,
                0.180000f, 0.526000f, 0.140000f, 0.526000f,
                0.100000f, 0.526000f, 0.100000f, 0.567000f,
                0.248000f, 0.567000f, 0.248000f, 0.608000f,
                0.288000f, 0.608000f, 0.328000f, 0.608000f,
                0.328000f, 0.567000f, 0.328000f, 0.526000f,
                0.288000f, 0.526000f, 0.248000f, 0.526000f,
                0.248000f, 0.567000f
            };

        private static readonly byte[] MyriadProGlyph1106Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph1106Coordinates =
            {
                0.072000f, 0.570000f, 0.072000f, 0.638000f,
                0.142000f, 0.638000f, 0.142000f, 0.570000f,
                0.323000f, 0.570000f, 0.323000f, 0.520000f,
                0.142000f, 0.520000f, 0.142000f, 0.406000f,
                0.144000f, 0.406000f, 0.193000f, 0.461000f,
                0.261000f, 0.461000f, 0.332000f, 0.461000f,
                0.372000f, 0.398000f, 0.414000f, 0.336000f,
                0.414000f, 0.229000f, 0.414000f, 0.066000f,
                0.335000f, 0.000000f, 0.289000f, -0.039000f,
                0.235000f, -0.044000f, 0.222000f, 0.010000f,
                0.269000f, 0.020000f, 0.296000f, 0.050000f,
                0.344000f, 0.104000f, 0.344000f, 0.225000f,
                0.344000f, 0.265000f, 0.337000f, 0.296000f,
                0.330000f, 0.333000f, 0.313000f, 0.361000f,
                0.287000f, 0.405000f, 0.240000f, 0.405000f,
                0.192000f, 0.405000f, 0.154000f, 0.358000f,
                0.142000f, 0.341000f, 0.142000f, 0.314000f,
                0.142000f, 0.070000f, 0.072000f, 0.070000f,
                0.072000f, 0.520000f, 0.006000f, 0.520000f,
                0.006000f, 0.570000f, 0.072000f, 0.570000f
            };

        private static readonly byte[] MyriadProGlyph8363Commands =
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph8363Coordinates =
            {
                0.341000f, 0.149000f, 0.341000f, 0.101000f,
                0.072000f, 0.101000f, 0.072000f, 0.149000f,
                0.341000f, 0.149000f, 0.338000f, 0.601000f,
                0.338000f, 0.548000f, 0.388000f, 0.548000f,
                0.388000f, 0.509000f, 0.338000f, 0.509000f,
                0.338000f, 0.269000f, 0.338000f, 0.227000f,
                0.340000f, 0.199000f, 0.285000f, 0.199000f,
                0.283000f, 0.245000f, 0.281000f, 0.245000f,
                0.252000f, 0.193000f, 0.181000f, 0.193000f,
                0.126000f, 0.193000f, 0.091000f, 0.231000f,
                0.054000f, 0.270000f, 0.054000f, 0.332000f,
                0.054000f, 0.399000f, 0.094000f, 0.440000f,
                0.132000f, 0.480000f, 0.189000f, 0.480000f,
                0.251000f, 0.480000f, 0.276000f, 0.438000f,
                0.277000f, 0.438000f, 0.277000f, 0.509000f,
                0.176000f, 0.509000f, 0.176000f, 0.548000f,
                0.277000f, 0.548000f, 0.277000f, 0.601000f,
                0.338000f, 0.601000f, 0.277000f, 0.356000f,
                0.277000f, 0.369000f, 0.275000f, 0.377000f,
                0.261000f, 0.433000f, 0.200000f, 0.433000f,
                0.118000f, 0.433000f, 0.118000f, 0.334000f,
                0.118000f, 0.293000f, 0.139000f, 0.268000f,
                0.160000f, 0.240000f, 0.198000f, 0.240000f,
                0.260000f, 0.240000f, 0.274000f, 0.297000f,
                0.276000f, 0.301000f, 0.277000f, 0.308000f,
                0.277000f, 0.313000f, 0.277000f, 0.318000f,
                0.277000f, 0.356000f
            };

        private static readonly byte[] MyriadProGlyph8364Commands =
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph8364Coordinates =
            {
                0.397000f, 0.094000f, 0.376000f, 0.080000f,
                0.347000f, 0.072000f, 0.314000f, 0.061000f,
                0.278000f, 0.061000f, 0.175000f, 0.061000f,
                0.115000f, 0.133000f, 0.068000f, 0.184000f,
                0.058000f, 0.270000f, 0.008000f, 0.270000f,
                0.008000f, 0.310000f, 0.054000f, 0.310000f,
                0.055000f, 0.357000f, 0.008000f, 0.357000f,
                0.008000f, 0.397000f, 0.061000f, 0.397000f,
                0.075000f, 0.481000f, 0.126000f, 0.533000f,
                0.189000f, 0.599000f, 0.284000f, 0.599000f,
                0.317000f, 0.599000f, 0.347000f, 0.591000f,
                0.371000f, 0.584000f, 0.391000f, 0.573000f,
                0.375000f, 0.521000f, 0.336000f, 0.543000f,
                0.286000f, 0.543000f, 0.221000f, 0.543000f,
                0.179000f, 0.500000f, 0.145000f, 0.464000f,
                0.132000f, 0.397000f, 0.355000f, 0.397000f,
                0.355000f, 0.357000f, 0.125000f, 0.357000f,
                0.123000f, 0.341000f, 0.123000f, 0.310000f,
                0.355000f, 0.310000f, 0.355000f, 0.270000f,
                0.129000f, 0.270000f, 0.138000f, 0.203000f,
                0.173000f, 0.165000f, 0.216000f, 0.119000f,
                0.286000f, 0.119000f, 0.314000f, 0.119000f,
                0.343000f, 0.128000f, 0.366000f, 0.135000f,
                0.383000f, 0.145000f, 0.397000f, 0.094000f
            };

        private static readonly byte[] MyriadProGlyph8304Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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

        private static readonly float[] MyriadProGlyph8304Coordinates =
            {
                0.018000f, 0.580000f, 0.018000f, 0.741000f,
                0.136000f, 0.741000f, 0.250000f, 0.741000f,
                0.250000f, 0.583000f, 0.250000f, 0.420000f,
                0.132000f, 0.420000f, 0.018000f, 0.420000f,
                0.018000f, 0.580000f, 0.194000f, 0.581000f,
                0.194000f, 0.700000f, 0.134000f, 0.700000f,
                0.074000f, 0.700000f, 0.074000f, 0.581000f,
                0.074000f, 0.461000f, 0.134000f, 0.461000f,
                0.194000f, 0.461000f, 0.194000f, 0.581000f
            };

        private static readonly byte[] MyriadProGlyph8308Commands =
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph8308Coordinates =
            {
                0.164000f, 0.425000f, 0.164000f, 0.506000f,
                0.013000f, 0.506000f, 0.013000f, 0.539000f,
                0.155000f, 0.736000f, 0.218000f, 0.736000f,
                0.218000f, 0.546000f, 0.262000f, 0.546000f,
                0.262000f, 0.506000f, 0.218000f, 0.506000f,
                0.218000f, 0.425000f, 0.164000f, 0.425000f,
                0.164000f, 0.638000f, 0.164000f, 0.649000f,
                0.165000f, 0.664000f, 0.167000f, 0.689000f,
                0.165000f, 0.689000f, 0.150000f, 0.659000f,
                0.138000f, 0.641000f, 0.069000f, 0.547000f,
                0.070000f, 0.546000f, 0.164000f, 0.546000f,
                0.164000f, 0.638000f
            };

        private static readonly byte[] MyriadProGlyph8309Commands =
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph8309Coordinates =
            {
                0.214000f, 0.690000f, 0.090000f, 0.690000f,
                0.080000f, 0.623000f, 0.086000f, 0.624000f,
                0.105000f, 0.624000f, 0.151000f, 0.624000f,
                0.179000f, 0.607000f, 0.223000f, 0.582000f,
                0.223000f, 0.526000f, 0.223000f, 0.480000f,
                0.189000f, 0.450000f, 0.154000f, 0.420000f,
                0.099000f, 0.420000f, 0.048000f, 0.420000f,
                0.015000f, 0.438000f, 0.026000f, 0.478000f,
                0.039000f, 0.472000f, 0.056000f, 0.467000f,
                0.077000f, 0.461000f, 0.097000f, 0.461000f,
                0.126000f, 0.461000f, 0.146000f, 0.477000f,
                0.168000f, 0.495000f, 0.168000f, 0.522000f,
                0.168000f, 0.585000f, 0.077000f, 0.585000f,
                0.067000f, 0.585000f, 0.053000f, 0.584000f,
                0.032000f, 0.582000f, 0.053000f, 0.734000f,
                0.214000f, 0.734000f, 0.214000f, 0.690000f
            };

        private static readonly byte[] MyriadProGlyph8310Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph8310Coordinates =
            {
                0.213000f, 0.697000f, 0.198000f, 0.699000f,
                0.181000f, 0.697000f, 0.088000f, 0.684000f,
                0.072000f, 0.599000f, 0.074000f, 0.599000f,
                0.104000f, 0.632000f, 0.149000f, 0.632000f,
                0.247000f, 0.632000f, 0.247000f, 0.531000f,
                0.247000f, 0.484000f, 0.216000f, 0.452000f,
                0.184000f, 0.420000f, 0.136000f, 0.420000f,
                0.082000f, 0.420000f, 0.049000f, 0.458000f,
                0.018000f, 0.494000f, 0.018000f, 0.554000f,
                0.018000f, 0.642000f, 0.072000f, 0.693000f,
                0.112000f, 0.731000f, 0.182000f, 0.738000f,
                0.213000f, 0.740000f, 0.213000f, 0.697000f,
                0.192000f, 0.528000f, 0.192000f, 0.593000f,
                0.132000f, 0.593000f, 0.093000f, 0.593000f,
                0.075000f, 0.557000f, 0.071000f, 0.549000f,
                0.071000f, 0.540000f, 0.071000f, 0.461000f,
                0.136000f, 0.461000f, 0.192000f, 0.461000f,
                0.192000f, 0.528000f
            };

        private static readonly byte[] MyriadProGlyph8311Commands =
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

        private static readonly float[] MyriadProGlyph8311Coordinates =
            {
                0.225000f, 0.735000f, 0.225000f, 0.701000f,
                0.088000f, 0.425000f, 0.032000f, 0.425000f,
                0.169000f, 0.691000f, 0.015000f, 0.691000f,
                0.015000f, 0.735000f, 0.225000f, 0.735000f
            };

        private static readonly byte[] MyriadProGlyph8312Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph8312Coordinates =
            {
                0.207000f, 0.716000f, 0.231000f, 0.694000f,
                0.231000f, 0.662000f, 0.231000f, 0.614000f,
                0.181000f, 0.592000f, 0.181000f, 0.590000f,
                0.243000f, 0.567000f, 0.243000f, 0.512000f,
                0.243000f, 0.471000f, 0.211000f, 0.446000f,
                0.179000f, 0.421000f, 0.129000f, 0.421000f,
                0.078000f, 0.421000f, 0.047000f, 0.446000f,
                0.019000f, 0.470000f, 0.019000f, 0.505000f,
                0.019000f, 0.559000f, 0.081000f, 0.585000f,
                0.081000f, 0.587000f, 0.030000f, 0.609000f,
                0.030000f, 0.656000f, 0.030000f, 0.693000f,
                0.060000f, 0.717000f, 0.089000f, 0.740000f,
                0.134000f, 0.740000f, 0.180000f, 0.740000f,
                0.207000f, 0.716000f, 0.189000f, 0.508000f,
                0.189000f, 0.552000f, 0.125000f, 0.569000f,
                0.073000f, 0.554000f, 0.073000f, 0.511000f,
                0.073000f, 0.458000f, 0.131000f, 0.458000f,
                0.189000f, 0.458000f, 0.189000f, 0.508000f,
                0.081000f, 0.658000f, 0.081000f, 0.621000f,
                0.137000f, 0.606000f, 0.181000f, 0.620000f,
                0.181000f, 0.657000f, 0.181000f, 0.703000f,
                0.131000f, 0.703000f, 0.081000f, 0.703000f,
                0.081000f, 0.658000f
            };

        private static readonly byte[] MyriadProGlyph8313Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph8313Coordinates =
            {
                0.046000f, 0.463000f, 0.062000f, 0.462000f,
                0.080000f, 0.464000f, 0.120000f, 0.468000f,
                0.147000f, 0.490000f, 0.179000f, 0.516000f,
                0.188000f, 0.564000f, 0.186000f, 0.564000f,
                0.160000f, 0.533000f, 0.115000f, 0.533000f,
                0.072000f, 0.533000f, 0.045000f, 0.560000f,
                0.018000f, 0.587000f, 0.018000f, 0.629000f,
                0.018000f, 0.675000f, 0.050000f, 0.707000f,
                0.082000f, 0.740000f, 0.131000f, 0.740000f,
                0.183000f, 0.740000f, 0.213000f, 0.703000f,
                0.242000f, 0.667000f, 0.242000f, 0.608000f,
                0.242000f, 0.514000f, 0.188000f, 0.464000f,
                0.149000f, 0.427000f, 0.084000f, 0.422000f,
                0.063000f, 0.421000f, 0.046000f, 0.421000f,
                0.046000f, 0.463000f, 0.072000f, 0.632000f,
                0.072000f, 0.572000f, 0.128000f, 0.572000f,
                0.167000f, 0.572000f, 0.185000f, 0.601000f,
                0.188000f, 0.606000f, 0.188000f, 0.617000f,
                0.188000f, 0.700000f, 0.128000f, 0.700000f,
                0.072000f, 0.700000f, 0.072000f, 0.632000f
            };

        private static readonly byte[] MyriadProGlyph8317Commands =
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph8317Coordinates =
            {
                0.134000f, 0.765000f, 0.108000f, 0.727000f,
                0.094000f, 0.682000f, 0.077000f, 0.630000f,
                0.077000f, 0.570000f, 0.077000f, 0.511000f,
                0.094000f, 0.460000f, 0.108000f, 0.418000f,
                0.134000f, 0.377000f, 0.094000f, 0.377000f,
                0.081000f, 0.394000f, 0.072000f, 0.411000f,
                0.060000f, 0.432000f, 0.052000f, 0.454000f,
                0.032000f, 0.508000f, 0.032000f, 0.570000f,
                0.032000f, 0.634000f, 0.052000f, 0.688000f,
                0.067000f, 0.729000f, 0.094000f, 0.765000f,
                0.134000f, 0.765000f
            };

        private static readonly byte[] MyriadProGlyph8318Commands =
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph8318Coordinates =
            {
                0.010000f, 0.377000f, 0.036000f, 0.417000f,
                0.051000f, 0.460000f, 0.068000f, 0.512000f,
                0.068000f, 0.571000f, 0.068000f, 0.631000f,
                0.051000f, 0.682000f, 0.037000f, 0.726000f,
                0.010000f, 0.765000f, 0.051000f, 0.765000f,
                0.077000f, 0.729000f, 0.092000f, 0.689000f,
                0.112000f, 0.634000f, 0.112000f, 0.571000f,
                0.112000f, 0.509000f, 0.092000f, 0.455000f,
                0.084000f, 0.433000f, 0.073000f, 0.412000f,
                0.063000f, 0.394000f, 0.051000f, 0.377000f,
                0.010000f, 0.377000f
            };

        private static readonly byte[] MyriadProGlyph8320Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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

        private static readonly float[] MyriadProGlyph8320Coordinates =
            {
                0.018000f, 0.108000f, 0.018000f, 0.269000f,
                0.136000f, 0.269000f, 0.250000f, 0.269000f,
                0.250000f, 0.111000f, 0.250000f, 0.036000f,
                0.220000f, -0.007000f, 0.189000f, -0.051000f,
                0.132000f, -0.051000f, 0.018000f, -0.051000f,
                0.018000f, 0.108000f, 0.194000f, 0.110000f,
                0.194000f, 0.228000f, 0.134000f, 0.228000f,
                0.074000f, 0.228000f, 0.074000f, 0.110000f,
                0.074000f, -0.011000f, 0.134000f, -0.011000f,
                0.194000f, -0.011000f, 0.194000f, 0.110000f
            };

        private static readonly byte[] MyriadProGlyph8321Commands =
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

        private static readonly float[] MyriadProGlyph8321Coordinates =
            {
                0.086000f, -0.047000f, 0.086000f, 0.216000f,
                0.084000f, 0.216000f, 0.027000f, 0.188000f,
                0.018000f, 0.229000f, 0.093000f, 0.265000f,
                0.142000f, 0.265000f, 0.142000f, -0.047000f,
                0.086000f, -0.047000f
            };

        private static readonly byte[] MyriadProGlyph8322Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph8322Coordinates =
            {
                0.010000f, -0.018000f, 0.060000f, 0.029000f,
                0.116000f, 0.080000f, 0.136000f, 0.106000f,
                0.161000f, 0.139000f, 0.161000f, 0.168000f,
                0.161000f, 0.224000f, 0.100000f, 0.224000f,
                0.081000f, 0.224000f, 0.062000f, 0.216000f,
                0.047000f, 0.209000f, 0.033000f, 0.199000f,
                0.016000f, 0.235000f, 0.056000f, 0.269000f,
                0.115000f, 0.269000f, 0.167000f, 0.269000f,
                0.196000f, 0.240000f, 0.220000f, 0.215000f,
                0.220000f, 0.179000f, 0.220000f, 0.138000f,
                0.190000f, 0.097000f, 0.177000f, 0.080000f,
                0.156000f, 0.059000f, 0.141000f, 0.045000f,
                0.114000f, 0.021000f, 0.090000f, -0.002000f,
                0.090000f, -0.003000f, 0.226000f, -0.003000f,
                0.226000f, -0.047000f, 0.010000f, -0.047000f,
                0.010000f, -0.018000f
            };

        private static readonly byte[] MyriadProGlyph8323Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph8323Coordinates =
            {
                0.022000f, 0.244000f, 0.038000f, 0.254000f,
                0.060000f, 0.261000f, 0.087000f, 0.269000f,
                0.114000f, 0.269000f, 0.162000f, 0.269000f,
                0.189000f, 0.245000f, 0.212000f, 0.225000f,
                0.212000f, 0.193000f, 0.212000f, 0.142000f,
                0.150000f, 0.121000f, 0.150000f, 0.120000f,
                0.224000f, 0.109000f, 0.224000f, 0.042000f,
                0.224000f, 0.003000f, 0.192000f, -0.023000f,
                0.157000f, -0.051000f, 0.098000f, -0.051000f,
                0.040000f, -0.051000f, 0.006000f, -0.029000f,
                0.020000f, 0.011000f, 0.051000f, -0.010000f,
                0.095000f, -0.010000f, 0.129000f, -0.010000f,
                0.149000f, 0.008000f, 0.166000f, 0.023000f,
                0.165000f, 0.044000f, 0.165000f, 0.072000f,
                0.139000f, 0.087000f, 0.116000f, 0.100000f,
                0.080000f, 0.100000f, 0.059000f, 0.100000f,
                0.059000f, 0.137000f, 0.081000f, 0.137000f,
                0.108000f, 0.137000f, 0.129000f, 0.148000f,
                0.154000f, 0.162000f, 0.154000f, 0.187000f,
                0.154000f, 0.227000f, 0.104000f, 0.227000f,
                0.084000f, 0.227000f, 0.064000f, 0.220000f,
                0.048000f, 0.214000f, 0.036000f, 0.205000f,
                0.022000f, 0.244000f
            };

        private static readonly byte[] MyriadProGlyph8324Commands =
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph8324Coordinates =
            {
                0.164000f, -0.047000f, 0.164000f, 0.034000f,
                0.013000f, 0.034000f, 0.013000f, 0.067000f,
                0.155000f, 0.265000f, 0.218000f, 0.265000f,
                0.218000f, 0.074000f, 0.262000f, 0.074000f,
                0.262000f, 0.034000f, 0.218000f, 0.034000f,
                0.218000f, -0.047000f, 0.164000f, -0.047000f,
                0.164000f, 0.167000f, 0.164000f, 0.178000f,
                0.165000f, 0.193000f, 0.167000f, 0.217000f,
                0.165000f, 0.217000f, 0.150000f, 0.188000f,
                0.138000f, 0.170000f, 0.069000f, 0.075000f,
                0.070000f, 0.074000f, 0.164000f, 0.074000f,
                0.164000f, 0.167000f
            };

        private static readonly byte[] MyriadProGlyph8325Commands =
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph8325Coordinates =
            {
                0.214000f, 0.219000f, 0.090000f, 0.219000f,
                0.080000f, 0.151000f, 0.086000f, 0.152000f,
                0.105000f, 0.152000f, 0.151000f, 0.152000f,
                0.179000f, 0.135000f, 0.223000f, 0.110000f,
                0.223000f, 0.055000f, 0.223000f, 0.008000f,
                0.189000f, -0.022000f, 0.154000f, -0.052000f,
                0.099000f, -0.052000f, 0.047000f, -0.052000f,
                0.015000f, -0.033000f, 0.026000f, 0.006000f,
                0.039000f, 0.000000f, 0.056000f, -0.005000f,
                0.077000f, -0.011000f, 0.097000f, -0.011000f,
                0.126000f, -0.011000f, 0.146000f, 0.005000f,
                0.168000f, 0.023000f, 0.168000f, 0.050000f,
                0.168000f, 0.113000f, 0.077000f, 0.113000f,
                0.065000f, 0.113000f, 0.053000f, 0.112000f,
                0.042000f, 0.112000f, 0.032000f, 0.110000f,
                0.053000f, 0.263000f, 0.214000f, 0.263000f,
                0.214000f, 0.219000f
            };

        private static readonly byte[] MyriadProGlyph8326Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph8326Coordinates =
            {
                0.213000f, 0.225000f, 0.198000f, 0.227000f,
                0.181000f, 0.225000f, 0.088000f, 0.212000f,
                0.072000f, 0.127000f, 0.074000f, 0.127000f,
                0.104000f, 0.160000f, 0.149000f, 0.160000f,
                0.247000f, 0.160000f, 0.247000f, 0.060000f,
                0.247000f, 0.013000f, 0.216000f, -0.019000f,
                0.184000f, -0.051000f, 0.136000f, -0.051000f,
                0.082000f, -0.051000f, 0.049000f, -0.014000f,
                0.018000f, 0.023000f, 0.018000f, 0.082000f,
                0.018000f, 0.170000f, 0.072000f, 0.221000f,
                0.114000f, 0.260000f, 0.182000f, 0.266000f,
                0.213000f, 0.268000f, 0.213000f, 0.225000f,
                0.192000f, 0.057000f, 0.192000f, 0.121000f,
                0.132000f, 0.121000f, 0.093000f, 0.121000f,
                0.075000f, 0.085000f, 0.071000f, 0.077000f,
                0.071000f, 0.069000f, 0.071000f, -0.011000f,
                0.136000f, -0.011000f, 0.192000f, -0.011000f,
                0.192000f, 0.057000f
            };

        private static readonly byte[] MyriadProGlyph8327Commands =
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

        private static readonly float[] MyriadProGlyph8327Coordinates =
            {
                0.225000f, 0.263000f, 0.225000f, 0.229000f,
                0.088000f, -0.047000f, 0.032000f, -0.047000f,
                0.169000f, 0.219000f, 0.015000f, 0.219000f,
                0.015000f, 0.263000f, 0.225000f, 0.263000f
            };

        private static readonly byte[] MyriadProGlyph8328Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph8328Coordinates =
            {
                0.207000f, 0.245000f, 0.231000f, 0.223000f,
                0.231000f, 0.191000f, 0.231000f, 0.143000f,
                0.181000f, 0.121000f, 0.181000f, 0.119000f,
                0.243000f, 0.095000f, 0.243000f, 0.041000f,
                0.243000f, -0.001000f, 0.211000f, -0.026000f,
                0.180000f, -0.051000f, 0.129000f, -0.051000f,
                0.078000f, -0.051000f, 0.047000f, -0.025000f,
                0.019000f, -0.002000f, 0.019000f, 0.033000f,
                0.019000f, 0.088000f, 0.081000f, 0.113000f,
                0.081000f, 0.116000f, 0.030000f, 0.138000f,
                0.030000f, 0.185000f, 0.030000f, 0.222000f,
                0.060000f, 0.246000f, 0.089000f, 0.269000f,
                0.134000f, 0.269000f, 0.180000f, 0.269000f,
                0.207000f, 0.245000f, 0.189000f, 0.036000f,
                0.189000f, 0.080000f, 0.125000f, 0.097000f,
                0.073000f, 0.083000f, 0.073000f, 0.040000f,
                0.073000f, -0.014000f, 0.131000f, -0.014000f,
                0.189000f, -0.014000f, 0.189000f, 0.036000f,
                0.081000f, 0.187000f, 0.081000f, 0.149000f,
                0.137000f, 0.135000f, 0.181000f, 0.149000f,
                0.181000f, 0.185000f, 0.181000f, 0.232000f,
                0.131000f, 0.232000f, 0.081000f, 0.232000f,
                0.081000f, 0.187000f
            };

        private static readonly byte[] MyriadProGlyph8329Commands =
            {
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
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
                (byte) VGPathSegment.VG_CLOSE_PATH,
                (byte) VGPathCommand.VG_MOVE_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph8329Coordinates =
            {
                0.046000f, -0.008000f, 0.062000f, -0.010000f,
                0.080000f, -0.007000f, 0.120000f, -0.004000f,
                0.147000f, 0.019000f, 0.179000f, 0.045000f,
                0.188000f, 0.093000f, 0.186000f, 0.093000f,
                0.160000f, 0.062000f, 0.115000f, 0.062000f,
                0.072000f, 0.062000f, 0.045000f, 0.089000f,
                0.018000f, 0.116000f, 0.018000f, 0.158000f,
                0.018000f, 0.204000f, 0.050000f, 0.236000f,
                0.082000f, 0.269000f, 0.131000f, 0.269000f,
                0.183000f, 0.269000f, 0.213000f, 0.231000f,
                0.242000f, 0.196000f, 0.242000f, 0.137000f,
                0.242000f, 0.043000f, 0.188000f, -0.007000f,
                0.149000f, -0.044000f, 0.084000f, -0.049000f,
                0.059000f, -0.052000f, 0.046000f, -0.051000f,
                0.046000f, -0.008000f, 0.072000f, 0.161000f,
                0.072000f, 0.101000f, 0.128000f, 0.101000f,
                0.167000f, 0.101000f, 0.185000f, 0.130000f,
                0.188000f, 0.134000f, 0.188000f, 0.145000f,
                0.188000f, 0.229000f, 0.128000f, 0.229000f,
                0.072000f, 0.229000f, 0.072000f, 0.161000f
            };

        private static readonly byte[] MyriadProGlyph8333Commands =
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph8333Coordinates =
            {
                0.134000f, 0.293000f, 0.108000f, 0.255000f,
                0.094000f, 0.210000f, 0.077000f, 0.158000f,
                0.077000f, 0.098000f, 0.077000f, 0.039000f,
                0.094000f, -0.012000f, 0.108000f, -0.054000f,
                0.134000f, -0.095000f, 0.094000f, -0.095000f,
                0.081000f, -0.078000f, 0.072000f, -0.061000f,
                0.060000f, -0.040000f, 0.052000f, -0.018000f,
                0.032000f, 0.036000f, 0.032000f, 0.098000f,
                0.032000f, 0.162000f, 0.052000f, 0.216000f,
                0.067000f, 0.257000f, 0.094000f, 0.293000f,
                0.134000f, 0.293000f
            };

        private static readonly byte[] MyriadProGlyph8334Commands =
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
                (byte) VGPathCommand.VG_QUAD_TO_ABS,
                (byte) VGPathCommand.VG_LINE_TO_ABS,
                (byte) VGPathSegment.VG_CLOSE_PATH
            };

        private static readonly float[] MyriadProGlyph8334Coordinates =
            {
                0.010000f, -0.095000f, 0.036000f, -0.055000f,
                0.051000f, -0.012000f, 0.068000f, 0.040000f,
                0.068000f, 0.099000f, 0.068000f, 0.159000f,
                0.051000f, 0.210000f, 0.037000f, 0.254000f,
                0.010000f, 0.293000f, 0.051000f, 0.293000f,
                0.077000f, 0.257000f, 0.092000f, 0.217000f,
                0.112000f, 0.162000f, 0.112000f, 0.099000f,
                0.112000f, 0.037000f, 0.092000f, -0.017000f,
                0.084000f, -0.039000f, 0.073000f, -0.060000f,
                0.063000f, -0.078000f, 0.051000f, -0.095000f,
                0.010000f, -0.095000f
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
                                       escapement = new[] {0.170000f, 0.000000f},
                                       commands = new byte[] {0},
                                       coordinates = new float[] {0}
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 33,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.184000f, 0.000000f},
                                       commands = MyriadProGlyph33Commands,
                                       coordinates = MyriadProGlyph33Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 34,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.270000f, 0.000000f},
                                       commands = MyriadProGlyph34Commands,
                                       coordinates = MyriadProGlyph34Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 35,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.398000f, 0.000000f},
                                       commands = MyriadProGlyph35Commands,
                                       coordinates = MyriadProGlyph35Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 36,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.411000f, 0.000000f},
                                       commands = MyriadProGlyph36Commands,
                                       coordinates = MyriadProGlyph36Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 37,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.634000f, 0.000000f},
                                       commands = MyriadProGlyph37Commands,
                                       coordinates = MyriadProGlyph37Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 38,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.484000f, 0.000000f},
                                       commands = MyriadProGlyph38Commands,
                                       coordinates = MyriadProGlyph38Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 39,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.151000f, 0.000000f},
                                       commands = MyriadProGlyph39Commands,
                                       coordinates = MyriadProGlyph39Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 40,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.227000f, 0.000000f},
                                       commands = MyriadProGlyph40Commands,
                                       coordinates = MyriadProGlyph40Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 41,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.227000f, 0.000000f},
                                       commands = MyriadProGlyph41Commands,
                                       coordinates = MyriadProGlyph41Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 42,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.332000f, 0.000000f},
                                       commands = MyriadProGlyph42Commands,
                                       coordinates = MyriadProGlyph42Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 43,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.477000f, 0.000000f},
                                       commands = MyriadProGlyph43Commands,
                                       coordinates = MyriadProGlyph43Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 44,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.166000f, 0.000000f},
                                       commands = MyriadProGlyph44Commands,
                                       coordinates = MyriadProGlyph44Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 45,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.246000f, 0.000000f},
                                       commands = MyriadProGlyph45Commands,
                                       coordinates = MyriadProGlyph45Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 46,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.166000f, 0.000000f},
                                       commands = MyriadProGlyph46Commands,
                                       coordinates = MyriadProGlyph46Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 47,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.274000f, 0.000000f},
                                       commands = MyriadProGlyph47Commands,
                                       coordinates = MyriadProGlyph47Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 48,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.411000f, 0.000000f},
                                       commands = MyriadProGlyph48Commands,
                                       coordinates = MyriadProGlyph48Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 49,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.410000f, 0.000000f},
                                       commands = MyriadProGlyph49Commands,
                                       coordinates = MyriadProGlyph49Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 50,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.410000f, 0.000000f},
                                       commands = MyriadProGlyph50Commands,
                                       coordinates = MyriadProGlyph50Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 51,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.411000f, 0.000000f},
                                       commands = MyriadProGlyph51Commands,
                                       coordinates = MyriadProGlyph51Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 52,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.410000f, 0.000000f},
                                       commands = MyriadProGlyph52Commands,
                                       coordinates = MyriadProGlyph52Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 53,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.411000f, 0.000000f},
                                       commands = MyriadProGlyph53Commands,
                                       coordinates = MyriadProGlyph53Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 54,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.410000f, 0.000000f},
                                       commands = MyriadProGlyph54Commands,
                                       coordinates = MyriadProGlyph54Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 55,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.411000f, 0.000000f},
                                       commands = MyriadProGlyph55Commands,
                                       coordinates = MyriadProGlyph55Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 56,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.411000f, 0.000000f},
                                       commands = MyriadProGlyph56Commands,
                                       coordinates = MyriadProGlyph56Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 57,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.411000f, 0.000000f},
                                       commands = MyriadProGlyph57Commands,
                                       coordinates = MyriadProGlyph57Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 58,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.165000f, 0.000000f},
                                       commands = MyriadProGlyph58Commands,
                                       coordinates = MyriadProGlyph58Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 59,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.166000f, 0.000000f},
                                       commands = MyriadProGlyph59Commands,
                                       coordinates = MyriadProGlyph59Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 60,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.477000f, 0.000000f},
                                       commands = MyriadProGlyph60Commands,
                                       coordinates = MyriadProGlyph60Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 61,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.477000f, 0.000000f},
                                       commands = MyriadProGlyph61Commands,
                                       coordinates = MyriadProGlyph61Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 62,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.477000f, 0.000000f},
                                       commands = MyriadProGlyph62Commands,
                                       coordinates = MyriadProGlyph62Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 63,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.325000f, 0.000000f},
                                       commands = MyriadProGlyph63Commands,
                                       coordinates = MyriadProGlyph63Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 64,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.589000f, 0.000000f},
                                       commands = MyriadProGlyph64Commands,
                                       coordinates = MyriadProGlyph64Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 65,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.490000f, 0.000000f},
                                       commands = MyriadProGlyph65Commands,
                                       coordinates = MyriadProGlyph65Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 66,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.434000f, 0.000000f},
                                       commands = MyriadProGlyph66Commands,
                                       coordinates = MyriadProGlyph66Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 67,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.464000f, 0.000000f},
                                       commands = MyriadProGlyph67Commands,
                                       coordinates = MyriadProGlyph67Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 68,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.533000f, 0.000000f},
                                       commands = MyriadProGlyph68Commands,
                                       coordinates = MyriadProGlyph68Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 69,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.394000f, 0.000000f},
                                       commands = MyriadProGlyph69Commands,
                                       coordinates = MyriadProGlyph69Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 70,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.390000f, 0.000000f},
                                       commands = MyriadProGlyph70Commands,
                                       coordinates = MyriadProGlyph70Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 71,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.517000f, 0.000000f},
                                       commands = MyriadProGlyph71Commands,
                                       coordinates = MyriadProGlyph71Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 72,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.522000f, 0.000000f},
                                       commands = MyriadProGlyph72Commands,
                                       coordinates = MyriadProGlyph72Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 73,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.191000f, 0.000000f},
                                       commands = MyriadProGlyph73Commands,
                                       coordinates = MyriadProGlyph73Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 74,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.296000f, 0.000000f},
                                       commands = MyriadProGlyph74Commands,
                                       coordinates = MyriadProGlyph74Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 75,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.434000f, 0.000000f},
                                       commands = MyriadProGlyph75Commands,
                                       coordinates = MyriadProGlyph75Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 76,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.378000f, 0.000000f},
                                       commands = MyriadProGlyph76Commands,
                                       coordinates = MyriadProGlyph76Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 77,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.643000f, 0.000000f},
                                       commands = MyriadProGlyph77Commands,
                                       coordinates = MyriadProGlyph77Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 78,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.527000f, 0.000000f},
                                       commands = MyriadProGlyph78Commands,
                                       coordinates = MyriadProGlyph78Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 79,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.551000f, 0.000000f},
                                       commands = MyriadProGlyph79Commands,
                                       coordinates = MyriadProGlyph79Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 80,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.426000f, 0.000000f},
                                       commands = MyriadProGlyph80Commands,
                                       coordinates = MyriadProGlyph80Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 81,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.551000f, 0.000000f},
                                       commands = MyriadProGlyph81Commands,
                                       coordinates = MyriadProGlyph81Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 82,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.431000f, 0.000000f},
                                       commands = MyriadProGlyph82Commands,
                                       coordinates = MyriadProGlyph82Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 83,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.395000f, 0.000000f},
                                       commands = MyriadProGlyph83Commands,
                                       coordinates = MyriadProGlyph83Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 84,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.397000f, 0.000000f},
                                       commands = MyriadProGlyph84Commands,
                                       coordinates = MyriadProGlyph84Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 85,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.518000f, 0.000000f},
                                       commands = MyriadProGlyph85Commands,
                                       coordinates = MyriadProGlyph85Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 86,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.446000f, 0.000000f},
                                       commands = MyriadProGlyph86Commands,
                                       coordinates = MyriadProGlyph86Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 87,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.677000f, 0.000000f},
                                       commands = MyriadProGlyph87Commands,
                                       coordinates = MyriadProGlyph87Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 88,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.457000f, 0.000000f},
                                       commands = MyriadProGlyph88Commands,
                                       coordinates = MyriadProGlyph88Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 89,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.433000f, 0.000000f},
                                       commands = MyriadProGlyph89Commands,
                                       coordinates = MyriadProGlyph89Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 90,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.442000f, 0.000000f},
                                       commands = MyriadProGlyph90Commands,
                                       coordinates = MyriadProGlyph90Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 91,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.227000f, 0.000000f},
                                       commands = MyriadProGlyph91Commands,
                                       coordinates = MyriadProGlyph91Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 92,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.273000f, 0.000000f},
                                       commands = MyriadProGlyph92Commands,
                                       coordinates = MyriadProGlyph92Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 93,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.227000f, 0.000000f},
                                       commands = MyriadProGlyph93Commands,
                                       coordinates = MyriadProGlyph93Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 94,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.477000f, 0.000000f},
                                       commands = MyriadProGlyph94Commands,
                                       coordinates = MyriadProGlyph94Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 95,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.400000f, 0.000000f},
                                       commands = MyriadProGlyph95Commands,
                                       coordinates = MyriadProGlyph95Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 96,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.240000f, 0.000000f},
                                       commands = MyriadProGlyph96Commands,
                                       coordinates = MyriadProGlyph96Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 97,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.386000f, 0.000000f},
                                       commands = MyriadProGlyph97Commands,
                                       coordinates = MyriadProGlyph97Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 98,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.455000f, 0.000000f},
                                       commands = MyriadProGlyph98Commands,
                                       coordinates = MyriadProGlyph98Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 99,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.358000f, 0.000000f},
                                       commands = MyriadProGlyph99Commands,
                                       coordinates = MyriadProGlyph99Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 100,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.451000f, 0.000000f},
                                       commands = MyriadProGlyph100Commands,
                                       coordinates = MyriadProGlyph100Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 101,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.400000f, 0.000000f},
                                       commands = MyriadProGlyph101Commands,
                                       coordinates = MyriadProGlyph101Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 102,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.234000f, 0.000000f},
                                       commands = MyriadProGlyph102Commands,
                                       coordinates = MyriadProGlyph102Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 103,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.447000f, 0.000000f},
                                       commands = MyriadProGlyph103Commands,
                                       coordinates = MyriadProGlyph103Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 104,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.444000f, 0.000000f},
                                       commands = MyriadProGlyph104Commands,
                                       coordinates = MyriadProGlyph104Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 105,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.188000f, 0.000000f},
                                       commands = MyriadProGlyph105Commands,
                                       coordinates = MyriadProGlyph105Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 106,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.194000f, 0.000000f},
                                       commands = MyriadProGlyph106Commands,
                                       coordinates = MyriadProGlyph106Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 107,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.375000f, 0.000000f},
                                       commands = MyriadProGlyph107Commands,
                                       coordinates = MyriadProGlyph107Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 108,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.188000f, 0.000000f},
                                       commands = MyriadProGlyph108Commands,
                                       coordinates = MyriadProGlyph108Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 109,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.667000f, 0.000000f},
                                       commands = MyriadProGlyph109Commands,
                                       coordinates = MyriadProGlyph109Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 110,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.444000f, 0.000000f},
                                       commands = MyriadProGlyph110Commands,
                                       coordinates = MyriadProGlyph110Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 111,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.439000f, 0.000000f},
                                       commands = MyriadProGlyph111Commands,
                                       coordinates = MyriadProGlyph111Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 112,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.455000f, 0.000000f},
                                       commands = MyriadProGlyph112Commands,
                                       coordinates = MyriadProGlyph112Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 113,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.450000f, 0.000000f},
                                       commands = MyriadProGlyph113Commands,
                                       coordinates = MyriadProGlyph113Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 114,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.261000f, 0.000000f},
                                       commands = MyriadProGlyph114Commands,
                                       coordinates = MyriadProGlyph114Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 115,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.317000f, 0.000000f},
                                       commands = MyriadProGlyph115Commands,
                                       coordinates = MyriadProGlyph115Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 116,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.264000f, 0.000000f},
                                       commands = MyriadProGlyph116Commands,
                                       coordinates = MyriadProGlyph116Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 117,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.441000f, 0.000000f},
                                       commands = MyriadProGlyph117Commands,
                                       coordinates = MyriadProGlyph117Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 118,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.384000f, 0.000000f},
                                       commands = MyriadProGlyph118Commands,
                                       coordinates = MyriadProGlyph118Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 119,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.588000f, 0.000000f},
                                       commands = MyriadProGlyph119Commands,
                                       coordinates = MyriadProGlyph119Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 120,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.370000f, 0.000000f},
                                       commands = MyriadProGlyph120Commands,
                                       coordinates = MyriadProGlyph120Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 121,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.377000f, 0.000000f},
                                       commands = MyriadProGlyph121Commands,
                                       coordinates = MyriadProGlyph121Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 122,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.342000f, 0.000000f},
                                       commands = MyriadProGlyph122Commands,
                                       coordinates = MyriadProGlyph122Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 123,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.227000f, 0.000000f},
                                       commands = MyriadProGlyph123Commands,
                                       coordinates = MyriadProGlyph123Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 124,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.191000f, 0.000000f},
                                       commands = MyriadProGlyph124Commands,
                                       coordinates = MyriadProGlyph124Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 125,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.227000f, 0.000000f},
                                       commands = MyriadProGlyph125Commands,
                                       coordinates = MyriadProGlyph125Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 126,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.477000f, 0.000000f},
                                       commands = MyriadProGlyph126Commands,
                                       coordinates = MyriadProGlyph126Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 160,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.170000f, 0.000000f},
                                       commands = new byte[] {0},
                                       coordinates = new float[] {0}
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 161,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.184000f, 0.000000f},
                                       commands = MyriadProGlyph161Commands,
                                       coordinates = MyriadProGlyph161Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 162,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.411000f, 0.000000f},
                                       commands = MyriadProGlyph162Commands,
                                       coordinates = MyriadProGlyph162Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 163,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.411000f, 0.000000f},
                                       commands = MyriadProGlyph163Commands,
                                       coordinates = MyriadProGlyph163Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 164,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.410000f, 0.000000f},
                                       commands = MyriadProGlyph164Commands,
                                       coordinates = MyriadProGlyph164Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 165,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.411000f, 0.000000f},
                                       commands = MyriadProGlyph165Commands,
                                       coordinates = MyriadProGlyph165Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 166,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.191000f, 0.000000f},
                                       commands = MyriadProGlyph166Commands,
                                       coordinates = MyriadProGlyph166Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 167,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.415000f, 0.000000f},
                                       commands = MyriadProGlyph167Commands,
                                       coordinates = MyriadProGlyph167Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 168,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.240000f, 0.000000f},
                                       commands = MyriadProGlyph168Commands,
                                       coordinates = MyriadProGlyph168Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 169,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.542000f, 0.000000f},
                                       commands = MyriadProGlyph169Commands,
                                       coordinates = MyriadProGlyph169Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 170,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.276000f, 0.000000f},
                                       commands = MyriadProGlyph170Commands,
                                       coordinates = MyriadProGlyph170Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 171,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.335000f, 0.000000f},
                                       commands = MyriadProGlyph171Commands,
                                       coordinates = MyriadProGlyph171Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 172,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.477000f, 0.000000f},
                                       commands = MyriadProGlyph172Commands,
                                       coordinates = MyriadProGlyph172Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 173,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.233000f, 0.000000f},
                                       commands = MyriadProGlyph173Commands,
                                       coordinates = MyriadProGlyph173Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 174,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.335000f, 0.000000f},
                                       commands = MyriadProGlyph174Commands,
                                       coordinates = MyriadProGlyph174Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 175,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.240000f, 0.000000f},
                                       commands = MyriadProGlyph175Commands,
                                       coordinates = MyriadProGlyph175Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 176,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.254000f, 0.000000f},
                                       commands = MyriadProGlyph176Commands,
                                       coordinates = MyriadProGlyph176Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 177,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.477000f, 0.000000f},
                                       commands = MyriadProGlyph177Commands,
                                       coordinates = MyriadProGlyph177Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 178,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.249000f, 0.000000f},
                                       commands = MyriadProGlyph178Commands,
                                       coordinates = MyriadProGlyph178Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 179,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.244000f, 0.000000f},
                                       commands = MyriadProGlyph179Commands,
                                       coordinates = MyriadProGlyph179Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 180,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.240000f, 0.000000f},
                                       commands = MyriadProGlyph180Commands,
                                       coordinates = MyriadProGlyph180Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 181,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.442000f, 0.000000f},
                                       commands = MyriadProGlyph181Commands,
                                       coordinates = MyriadProGlyph181Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 182,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.410000f, 0.000000f},
                                       commands = MyriadProGlyph182Commands,
                                       coordinates = MyriadProGlyph182Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 183,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.165000f, 0.000000f},
                                       commands = MyriadProGlyph183Commands,
                                       coordinates = MyriadProGlyph183Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 184,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.240000f, 0.000000f},
                                       commands = MyriadProGlyph184Commands,
                                       coordinates = MyriadProGlyph184Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 185,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.196000f, 0.000000f},
                                       commands = MyriadProGlyph185Commands,
                                       coordinates = MyriadProGlyph185Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 186,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.284000f, 0.000000f},
                                       commands = MyriadProGlyph186Commands,
                                       coordinates = MyriadProGlyph186Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 187,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.335000f, 0.000000f},
                                       commands = MyriadProGlyph187Commands,
                                       coordinates = MyriadProGlyph187Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 188,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.607000f, 0.000000f},
                                       commands = MyriadProGlyph188Commands,
                                       coordinates = MyriadProGlyph188Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 189,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.607000f, 0.000000f},
                                       commands = MyriadProGlyph189Commands,
                                       coordinates = MyriadProGlyph189Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 190,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.607000f, 0.000000f},
                                       commands = MyriadProGlyph190Commands,
                                       coordinates = MyriadProGlyph190Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 191,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.325000f, 0.000000f},
                                       commands = MyriadProGlyph191Commands,
                                       coordinates = MyriadProGlyph191Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1025,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.394000f, 0.000000f},
                                       commands = MyriadProGlyph1025Commands,
                                       coordinates = MyriadProGlyph1025Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1026,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.532000f, 0.000000f},
                                       commands = MyriadProGlyph1026Commands,
                                       coordinates = MyriadProGlyph1026Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1027,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.346000f, 0.000000f},
                                       commands = MyriadProGlyph1027Commands,
                                       coordinates = MyriadProGlyph1027Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1028,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.461000f, 0.000000f},
                                       commands = MyriadProGlyph1028Commands,
                                       coordinates = MyriadProGlyph1028Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1029,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.395000f, 0.000000f},
                                       commands = MyriadProGlyph1029Commands,
                                       coordinates = MyriadProGlyph1029Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1030,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.191000f, 0.000000f},
                                       commands = MyriadProGlyph1030Commands,
                                       coordinates = MyriadProGlyph1030Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1031,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.191000f, 0.000000f},
                                       commands = MyriadProGlyph1031Commands,
                                       coordinates = MyriadProGlyph1031Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1032,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.296000f, 0.000000f},
                                       commands = MyriadProGlyph1032Commands,
                                       coordinates = MyriadProGlyph1032Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1033,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.705000f, 0.000000f},
                                       commands = MyriadProGlyph1033Commands,
                                       coordinates = MyriadProGlyph1033Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1034,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.718000f, 0.000000f},
                                       commands = MyriadProGlyph1034Commands,
                                       coordinates = MyriadProGlyph1034Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1035,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.540000f, 0.000000f},
                                       commands = MyriadProGlyph1035Commands,
                                       coordinates = MyriadProGlyph1035Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1036,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.434000f, 0.000000f},
                                       commands = MyriadProGlyph1036Commands,
                                       coordinates = MyriadProGlyph1036Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1038,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.417000f, 0.000000f},
                                       commands = MyriadProGlyph1038Commands,
                                       coordinates = MyriadProGlyph1038Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1039,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.508000f, 0.000000f},
                                       commands = MyriadProGlyph1039Commands,
                                       coordinates = MyriadProGlyph1039Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1040,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.490000f, 0.000000f},
                                       commands = MyriadProGlyph1040Commands,
                                       coordinates = MyriadProGlyph1040Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1041,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.437000f, 0.000000f},
                                       commands = MyriadProGlyph1041Commands,
                                       coordinates = MyriadProGlyph1041Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1042,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.434000f, 0.000000f},
                                       commands = MyriadProGlyph1042Commands,
                                       coordinates = MyriadProGlyph1042Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1043,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.346000f, 0.000000f},
                                       commands = MyriadProGlyph1043Commands,
                                       coordinates = MyriadProGlyph1043Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1044,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.504000f, 0.000000f},
                                       commands = MyriadProGlyph1044Commands,
                                       coordinates = MyriadProGlyph1044Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1045,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.394000f, 0.000000f},
                                       commands = MyriadProGlyph1045Commands,
                                       coordinates = MyriadProGlyph1045Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1046,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.641000f, 0.000000f},
                                       commands = MyriadProGlyph1046Commands,
                                       coordinates = MyriadProGlyph1046Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1047,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.394000f, 0.000000f},
                                       commands = MyriadProGlyph1047Commands,
                                       coordinates = MyriadProGlyph1047Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1048,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.527000f, 0.000000f},
                                       commands = MyriadProGlyph1048Commands,
                                       coordinates = MyriadProGlyph1048Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1049,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.527000f, 0.000000f},
                                       commands = MyriadProGlyph1049Commands,
                                       coordinates = MyriadProGlyph1049Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1050,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.434000f, 0.000000f},
                                       commands = MyriadProGlyph1050Commands,
                                       coordinates = MyriadProGlyph1050Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1051,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.475000f, 0.000000f},
                                       commands = MyriadProGlyph1051Commands,
                                       coordinates = MyriadProGlyph1051Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1052,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.643000f, 0.000000f},
                                       commands = MyriadProGlyph1052Commands,
                                       coordinates = MyriadProGlyph1052Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1053,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.522000f, 0.000000f},
                                       commands = MyriadProGlyph1053Commands,
                                       coordinates = MyriadProGlyph1053Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1054,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.551000f, 0.000000f},
                                       commands = MyriadProGlyph1054Commands,
                                       coordinates = MyriadProGlyph1054Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1055,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.511000f, 0.000000f},
                                       commands = MyriadProGlyph1055Commands,
                                       coordinates = MyriadProGlyph1055Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1056,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.426000f, 0.000000f},
                                       commands = MyriadProGlyph1056Commands,
                                       coordinates = MyriadProGlyph1056Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1057,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.464000f, 0.000000f},
                                       commands = MyriadProGlyph1057Commands,
                                       coordinates = MyriadProGlyph1057Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1058,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.397000f, 0.000000f},
                                       commands = MyriadProGlyph1058Commands,
                                       coordinates = MyriadProGlyph1058Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1059,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.417000f, 0.000000f},
                                       commands = MyriadProGlyph1059Commands,
                                       coordinates = MyriadProGlyph1059Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1060,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.580000f, 0.000000f},
                                       commands = MyriadProGlyph1060Commands,
                                       coordinates = MyriadProGlyph1060Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1061,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.457000f, 0.000000f},
                                       commands = MyriadProGlyph1061Commands,
                                       coordinates = MyriadProGlyph1061Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1062,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.522000f, 0.000000f},
                                       commands = MyriadProGlyph1062Commands,
                                       coordinates = MyriadProGlyph1062Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1063,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.478000f, 0.000000f},
                                       commands = MyriadProGlyph1063Commands,
                                       coordinates = MyriadProGlyph1063Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1064,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.678000f, 0.000000f},
                                       commands = MyriadProGlyph1064Commands,
                                       coordinates = MyriadProGlyph1064Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1065,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.691000f, 0.000000f},
                                       commands = MyriadProGlyph1065Commands,
                                       coordinates = MyriadProGlyph1065Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1066,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.504000f, 0.000000f},
                                       commands = MyriadProGlyph1066Commands,
                                       coordinates = MyriadProGlyph1066Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1067,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.597000f, 0.000000f},
                                       commands = MyriadProGlyph1067Commands,
                                       coordinates = MyriadProGlyph1067Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1068,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.436000f, 0.000000f},
                                       commands = MyriadProGlyph1068Commands,
                                       coordinates = MyriadProGlyph1068Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1069,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.454000f, 0.000000f},
                                       commands = MyriadProGlyph1069Commands,
                                       coordinates = MyriadProGlyph1069Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1070,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.694000f, 0.000000f},
                                       commands = MyriadProGlyph1070Commands,
                                       coordinates = MyriadProGlyph1070Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1071,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.434000f, 0.000000f},
                                       commands = MyriadProGlyph1071Commands,
                                       coordinates = MyriadProGlyph1071Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1072,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.386000f, 0.000000f},
                                       commands = MyriadProGlyph1072Commands,
                                       coordinates = MyriadProGlyph1072Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1073,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.422000f, 0.000000f},
                                       commands = MyriadProGlyph1073Commands,
                                       coordinates = MyriadProGlyph1073Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1074,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.400000f, 0.000000f},
                                       commands = MyriadProGlyph1074Commands,
                                       coordinates = MyriadProGlyph1074Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1075,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.308000f, 0.000000f},
                                       commands = MyriadProGlyph1075Commands,
                                       coordinates = MyriadProGlyph1075Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1076,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.424000f, 0.000000f},
                                       commands = MyriadProGlyph1076Commands,
                                       coordinates = MyriadProGlyph1076Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1077,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.400000f, 0.000000f},
                                       commands = MyriadProGlyph1077Commands,
                                       coordinates = MyriadProGlyph1077Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1078,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.534000f, 0.000000f},
                                       commands = MyriadProGlyph1078Commands,
                                       coordinates = MyriadProGlyph1078Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1079,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.344000f, 0.000000f},
                                       commands = MyriadProGlyph1079Commands,
                                       coordinates = MyriadProGlyph1079Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1080,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.443000f, 0.000000f},
                                       commands = MyriadProGlyph1080Commands,
                                       coordinates = MyriadProGlyph1080Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1081,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.443000f, 0.000000f},
                                       commands = MyriadProGlyph1081Commands,
                                       coordinates = MyriadProGlyph1081Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1082,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.383000f, 0.000000f},
                                       commands = MyriadProGlyph1082Commands,
                                       coordinates = MyriadProGlyph1082Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1083,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.406000f, 0.000000f},
                                       commands = MyriadProGlyph1083Commands,
                                       coordinates = MyriadProGlyph1083Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1084,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.512000f, 0.000000f},
                                       commands = MyriadProGlyph1084Commands,
                                       coordinates = MyriadProGlyph1084Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1085,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.437000f, 0.000000f},
                                       commands = MyriadProGlyph1085Commands,
                                       coordinates = MyriadProGlyph1085Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1086,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.439000f, 0.000000f},
                                       commands = MyriadProGlyph1086Commands,
                                       coordinates = MyriadProGlyph1086Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1087,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.433000f, 0.000000f},
                                       commands = MyriadProGlyph1087Commands,
                                       coordinates = MyriadProGlyph1087Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1088,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.455000f, 0.000000f},
                                       commands = MyriadProGlyph1088Commands,
                                       coordinates = MyriadProGlyph1088Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1089,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.358000f, 0.000000f},
                                       commands = MyriadProGlyph1089Commands,
                                       coordinates = MyriadProGlyph1089Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1090,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.329000f, 0.000000f},
                                       commands = MyriadProGlyph1090Commands,
                                       coordinates = MyriadProGlyph1090Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1091,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.377000f, 0.000000f},
                                       commands = MyriadProGlyph1091Commands,
                                       coordinates = MyriadProGlyph1091Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1092,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.512000f, 0.000000f},
                                       commands = MyriadProGlyph1092Commands,
                                       coordinates = MyriadProGlyph1092Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1093,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.370000f, 0.000000f},
                                       commands = MyriadProGlyph1093Commands,
                                       coordinates = MyriadProGlyph1093Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1094,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.440000f, 0.000000f},
                                       commands = MyriadProGlyph1094Commands,
                                       coordinates = MyriadProGlyph1094Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1095,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.412000f, 0.000000f},
                                       commands = MyriadProGlyph1095Commands,
                                       coordinates = MyriadProGlyph1095Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1096,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.590000f, 0.000000f},
                                       commands = MyriadProGlyph1096Commands,
                                       coordinates = MyriadProGlyph1096Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1097,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.599000f, 0.000000f},
                                       commands = MyriadProGlyph1097Commands,
                                       coordinates = MyriadProGlyph1097Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1098,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.463000f, 0.000000f},
                                       commands = MyriadProGlyph1098Commands,
                                       coordinates = MyriadProGlyph1098Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1099,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.532000f, 0.000000f},
                                       commands = MyriadProGlyph1099Commands,
                                       coordinates = MyriadProGlyph1099Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1100,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.398000f, 0.000000f},
                                       commands = MyriadProGlyph1100Commands,
                                       coordinates = MyriadProGlyph1100Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1101,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.371000f, 0.000000f},
                                       commands = MyriadProGlyph1101Commands,
                                       coordinates = MyriadProGlyph1101Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1102,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.564000f, 0.000000f},
                                       commands = MyriadProGlyph1102Commands,
                                       coordinates = MyriadProGlyph1102Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1103,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.397000f, 0.000000f},
                                       commands = MyriadProGlyph1103Commands,
                                       coordinates = MyriadProGlyph1103Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1105,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.400000f, 0.000000f},
                                       commands = MyriadProGlyph1105Commands,
                                       coordinates = MyriadProGlyph1105Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 1106,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.446000f, 0.000000f},
                                       commands = MyriadProGlyph1106Commands,
                                       coordinates = MyriadProGlyph1106Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8304,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.268000f, 0.000000f},
                                       commands = MyriadProGlyph8304Commands,
                                       coordinates = MyriadProGlyph8304Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8308,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.278000f, 0.000000f},
                                       commands = MyriadProGlyph8308Commands,
                                       coordinates = MyriadProGlyph8308Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8309,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.246000f, 0.000000f},
                                       commands = MyriadProGlyph8309Commands,
                                       coordinates = MyriadProGlyph8309Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8310,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.265000f, 0.000000f},
                                       commands = MyriadProGlyph8310Commands,
                                       coordinates = MyriadProGlyph8310Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8311,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.235000f, 0.000000f},
                                       commands = MyriadProGlyph8311Commands,
                                       coordinates = MyriadProGlyph8311Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8312,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.262000f, 0.000000f},
                                       commands = MyriadProGlyph8312Commands,
                                       coordinates = MyriadProGlyph8312Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8313,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.261000f, 0.000000f},
                                       commands = MyriadProGlyph8313Commands,
                                       coordinates = MyriadProGlyph8313Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8317,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.144000f, 0.000000f},
                                       commands = MyriadProGlyph8317Commands,
                                       coordinates = MyriadProGlyph8317Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8318,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.144000f, 0.000000f},
                                       commands = MyriadProGlyph8318Commands,
                                       coordinates = MyriadProGlyph8318Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8320,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.268000f, 0.000000f},
                                       commands = MyriadProGlyph8320Commands,
                                       coordinates = MyriadProGlyph8320Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8321,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.196000f, 0.000000f},
                                       commands = MyriadProGlyph8321Commands,
                                       coordinates = MyriadProGlyph8321Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8322,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.249000f, 0.000000f},
                                       commands = MyriadProGlyph8322Commands,
                                       coordinates = MyriadProGlyph8322Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8323,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.244000f, 0.000000f},
                                       commands = MyriadProGlyph8323Commands,
                                       coordinates = MyriadProGlyph8323Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8324,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.278000f, 0.000000f},
                                       commands = MyriadProGlyph8324Commands,
                                       coordinates = MyriadProGlyph8324Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8325,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.246000f, 0.000000f},
                                       commands = MyriadProGlyph8325Commands,
                                       coordinates = MyriadProGlyph8325Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8326,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.265000f, 0.000000f},
                                       commands = MyriadProGlyph8326Commands,
                                       coordinates = MyriadProGlyph8326Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8327,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.235000f, 0.000000f},
                                       commands = MyriadProGlyph8327Commands,
                                       coordinates = MyriadProGlyph8327Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8328,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.262000f, 0.000000f},
                                       commands = MyriadProGlyph8328Commands,
                                       coordinates = MyriadProGlyph8328Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8329,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.261000f, 0.000000f},
                                       commands = MyriadProGlyph8329Commands,
                                       coordinates = MyriadProGlyph8329Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8333,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.144000f, 0.000000f},
                                       commands = MyriadProGlyph8333Commands,
                                       coordinates = MyriadProGlyph8333Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8334,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.144000f, 0.000000f},
                                       commands = MyriadProGlyph8334Commands,
                                       coordinates = MyriadProGlyph8334Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8363,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.411000f, 0.000000f},
                                       commands = MyriadProGlyph8363Commands,
                                       coordinates = MyriadProGlyph8363Coordinates
                                   },
                               new Glyph
                                   {
                                       glyphIndex = 8364,
                                       origin = new[] {0.000000f, 0.000000f},
                                       escapement = new[] {0.410000f, 0.000000f},
                                       commands = MyriadProGlyph8364Commands,
                                       coordinates = MyriadProGlyph8364Coordinates
                                   }
                           };
            }
        }

        // public uint GlyphsCount = 230;

        #endregion

        #region kernings

        public Kerning[] Kernings
        {
            get
            {
                return new[]
                           {
                               new Kerning {key = 0, x = 0.0f, y = 0.0f}
                           };

            }
        }

        // public uint KerningsCount = 0;

        #endregion
    }
}
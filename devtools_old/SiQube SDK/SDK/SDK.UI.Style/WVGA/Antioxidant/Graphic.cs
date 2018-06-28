using SDK.UI.Widgets.Base;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Style.WVGA.Antioxidant
{
    public static class Graphic
    {
        public static GraphicArea ClassicArea(IWidget parent)
        {
            var rv = new GraphicArea(parent, 460, 220) {Background = Palette.TextArea.Background};

            #region Lines & arrows
            {                             
                var path = VGPath.OpenVGPath();
                VG.vgLoadIdentity();

                VGU.vguLine(path, 0, 0, rv.Width - 60, 0);  // OX
                VGU.vguLine(path, 0, 0, 0, rv.Height - 40); // OY

                const float kXBias = 5f;
                const float kYBias = 12f;

                var yArroyBias = rv.Height - 40f;

                var pathData = new float[16];
                pathData[0] = -kXBias;
                pathData[1] = yArroyBias;//0f;
                pathData[2] = 0f;
                pathData[3] = yArroyBias + kYBias;// kYBias;
                pathData[4] = kXBias;
                pathData[5] = yArroyBias;//0f;
                VGU.vguPolygon(path, pathData, 3, VGboolean.VG_TRUE);

                var xArroyBias = rv.Width - 60f;
                pathData[0] = xArroyBias;
                pathData[1] = -kXBias;
                pathData[2] = xArroyBias+ kYBias;
                pathData[3] = 0f;
                pathData[4] = xArroyBias;
                pathData[5] = kXBias;
                VGU.vguPolygon(path, pathData, 3, VGboolean.VG_TRUE);

                var vgPath = new VGPath(path, new VGSolidColor(Palette.Black), new VGSolidColor(Palette.LightBlue));
                vgPath.Move(35, 15);
                rv.Arrows = vgPath;

            }
            #endregion

            #region Grid
            {
                var path = VGPath.OpenVGPath();

                for (var i = 1; i < 4; i++)
                    VGU.vguLine(path, 0, i * 60, rv.Width - 60, i * 60);  // OX   

                for (var i = 1; i < 11; i++)
                    VGU.vguLine(path, i * 40, 0, i * 40, rv.Height - 40); // OY

                var vgPath = new VGPath(path, null, null);
                vgPath.SetStroke(new VGSolidColor(Palette.DarkSlateGray), new[] {5.0f, 10.0f, 15.0f, 10.0f});
                vgPath.StrokeWidth = 0.5f;
                vgPath.Move(40, 20);

                rv.Grid = vgPath;

            }
            #endregion                               
            
            rv.Move(10, 10);
            return rv;
        }
    
    }
}

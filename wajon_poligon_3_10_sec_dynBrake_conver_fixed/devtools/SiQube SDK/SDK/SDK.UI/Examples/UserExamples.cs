using System;
using System.Diagnostics;
using SDK.UI.Widgets;
using SDK.UI.Widgets.Base;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Examples
{
    public class UserExamples
    {
        private const int kHeight = 272;
        private const int kWidth = 480;
        
        private static int mImageRotate;
        
        public static Window ShowWindow()
        {
            var window = new Window("show", kWidth, kHeight) { Description = "Шеф-повар \"Сибовар\"" };

            var line = new TableLine(25);
            line.AddColumn(80);
            line.AddColumn(80);
            line.AddColumn(70);

            line.Text[0].Text = "HgjloGreen";
            line.Text[0].SetFont(Palette.Lime, 20);
            line.Text[0].SetAlign(Align.Left, new GfxPoint(0, 3));
            line.Text[1].Text = "HelloRed";
            line.Text[1].SetFont(Palette.Red, 15);
            line.Text[1].SetAlign(Align.Center);
            line.Text[2].Text = "HgelloBlue";
            line.Text[2].SetFont(Palette.PaleTurquoise, 30);
            line.Text[2].SetAlign(Align.Left, new GfxPoint(0, 4));

            line.Name = "line";


            var table = new Table(window) { Name = "table" };
            table.Move(10, 50);
            table.AddLine(new TableLine(line));
            table.AddLine(new TableLine(line));
            table.AddLine(new TableLine(line));
            table.SetBackground(Palette.Red, Palette.White);
            table.SetBorder(1, Palette.Lime);
            table.OnPress += caller =>
                                 {
                                     var rv = table.GetLineByCell(caller);
                                     if (rv == null) return;

                                     table.ActiveLine = rv;
                                     window.Description = rv.Name;
                                 };


            var text = new TextArea(window, 10, 180, 325, 50);
            text.SetFont("i260c", Palette.PaleTurquoise, 50);
            text.Text = "0123456789:";

            text.OnPress += caller => window.Description = "Text.Pressed";

            var bar = new ProgressBar(window, 40, 30, 200, 15, 15) { Percent = 10, Status = { Text = "hello" } };
            bar.Status.SetAlign(Align.Center, new GfxPoint(3, 3));
            bar.Status.SetFont(Palette.White, 14);
            bar.Rotate(70);

            text.OnRelease += caller =>
                                  {
                                      window.Description = "Text.Released";
                                      //mApplication.SetFocusedWindow("1");
                                      line.Move(line.X - 3, line.Y - 3);
                                      table.ActiveLine = null;
                                      bar.Percent -= 1;
                                  };

            window.OnPaint += delegate { Debug.Print(DateTime.Now.ToString("HH:mm:ss") + ":\tHome update"); };

            var activePath = VG.vgCreatePath(0, VGPathDatatype.VG_PATH_DATATYPE_S_16, 1, 0, 0, 0, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);
            VGU.vguRoundRect(activePath, 0, 0, 60, 100, 20, 20);

            var normalPath = VG.vgCreatePath(0, VGPathDatatype.VG_PATH_DATATYPE_S_16, 1, 0, 0, 0, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);
            VGU.vguRoundRect(normalPath, 0, 0, 100, 50, 20, 20);
            VGU.vguRoundRect(normalPath, 10, 50, 80, 70, 20, 20);



            var activeButton = new VGSolidColor(new Color(0xFF0000FF));
            //var normalButton = new VGSolidColor(new Color(0x00FF00FF));
            var normalButton = new VGLinearGradient(0, 0, 100, 120);
            normalButton.AddColor(0, new Color(0xFF0000FF));
            normalButton.AddColor(100, new Color(0x00FF00FF));

            var button = new Button(window, new VGPath(activePath, null, activeButton), new VGPath(normalPath, null, normalButton));
            button.IsCached = true;
            button.Move(250, 50);
            button.OnPress += delegate { Console.WriteLine("button.OnPress"); };


            var image = new Image(window, 25, 10);
            image.Load("splash.raw");
            image.Scale(0.5f, 0.5f);
            image.RotateCenter = new GfxPoint(image.Width / 2, image.Height / 2);
            //image.Hide();

            window.OnPaint += caller =>
                                  {
                                      image.Rotate(mImageRotate);
                                      mImageRotate += 5;
                                  };

            var graphicArea = new GraphicArea(window, 200, 200);
            graphicArea.Move(70, 20);
            graphicArea.Background = new Color(0xF0F0F0FF);


            graphicArea.Grid = new VGPath(activePath, activeButton, null);
            graphicArea.Arrows = new VGPath(normalPath, new VGSolidColor(Palette.PaleTurquoise), null);

            var graphicData1 = new GraphicsData
                                   {
                                       Data =
                                           new byte[]
                                               {
                                                   0, 15, 25, 50, 40, 35, 12, 10, 15, 17, 30, 32, 35, 35, 35, 35, 35, 40, 
                                                   45, 57, 25, 23, 20, 18, 12, 12, 12, 30, 32, 35, 35, 35, 35, 35, 40, 45
                                               }
                                   };

            var graphicData2 = new GraphicsData(graphicData1) { Color = Palette.Lime, Position = new GfxPoint(10, 10) };

            graphicArea.AddGrapic(graphicData1);
            graphicArea.AddGrapic(graphicData2);

            return window;
        }    
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using SDK.Common;
using SDK.UI.Widgets.Base;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Style.WVGA.Antioxidant
{
    public class KeyboardWindow : ClassicWindow
    {
        private TextArea mTextArea;
        
        private readonly List<Button> mRusLayout = new List<Button>();
        private readonly List<Button> mEngLayout = new List<Button>();
        private readonly List<Button> mSymbolLayout = new List<Button>();
        private List<Button> mActiveLayout;

        private readonly PeriodicTask mBlink = new PeriodicTask(1000);


        private void ActivateLayout(List<Button> layout)
        {
            if (layout == null)
                layout = mEngLayout;

            if(mActiveLayout != null)
                foreach (var button in mActiveLayout)
                {
                    button.Hide();
                }

            mActiveLayout = layout;
            foreach (var button in mActiveLayout)
            {
                button.Show();
            }            
        }

        public KeyboardWindow()
            : base("keyboard")
        {
            mBackground = new Color(0x121212FF);

            InitPanel();
            AddChilds();

            Text = "";


            #region text blink
            mBlink.OnPeriod += () =>
                                   {
                                       if (mApplication.GetFocusedWindow() != this) return;

                                       if(mTextArea.Text.Length > 0)
                                       {
                                           var index = 0;
                                           if (mTextArea.Text.Length > 1)
                                               index = (mTextArea.Text.Length - 1);

                                           if (mTextArea.Text[index] == '|')
                                               mTextArea.Text = Text;
                                           else
                                               mTextArea.Text = Text + '|';                                           
                                       }
                                       else
                                           mTextArea.Text = Text + '|';                                           

                                       Invalidate();
                                   };
            mBlink.Start();
            #endregion

            OnShow += caller =>
                          {
                              ActivateLayout(mEngLayout);
                              mBlink.Start();
                          };

        }

        public ClassicWindow ReturnWindow { get; set; }
        public string Text { set; get; }
        public Action<string> OnEnter;

        private static string RemoveLastSymbol(string text)
        {            
            var rv = new StringBuilder(text);
            return text.Length > 0 ? rv.ToString(0, text.Length - 1) : "";
        }

        Button GenericButton(IWidget parent, int x, int y, int width, string text, Color color)
        {
            const int kHeight = 35;
            const float kRound = 5f;

            var contour = VGPath.OpenVGPath();
            VGU.vguRoundRect(contour, 0, 0, width, kHeight, kRound, kRound);
            var normal = new VGPath(contour, null, new VGSolidColor(color ?? Palette.LightGrey));

            var activeColor = Palette.DarkGray;
            if(color == Palette.Red)
                activeColor = Palette.Orange;
                //activeColor = new Color(0x640000FF);

            if (color == Palette.Lime)
                activeColor = Palette.Orange;
                //activeColor = new Color(0x006400FF);

            var active = new VGPath(contour, null, new VGSolidColor(activeColor));

            var btn = new Button(parent, active, normal);//, "generic");//, x, y, width, kHeight, kRound);

            var label = new TextArea(btn, 0, 0, btn.Width, btn.Height) { Text = text };
            label.SetAlign(Align.Center, new GfxPoint(0, 10));
            label.SetFont(22);            

            btn.Move(x, y);
            btn.Show();

            return btn;
        }
        Button NumericButton(IWidget parent, string name, int x, int y)
        {
            const int kHeight = 35;
            const float kRound = 5f;

            var contour = VGPath.OpenVGPath(); // 45x35
            VGU.vguRoundRect(contour, 0, 0, 45, kHeight, kRound, kRound);
            var normal = new VGPath(contour, null, new VGSolidColor(Palette.LightGrey));
            var active = new VGPath(contour, null, new VGSolidColor(Palette.DarkGray));

            var btn = new Button(parent, active, normal);//, "123");//, x, y, width, kHeight, kRound);

            var label = new TextArea(btn, 0, 0, btn.Width, btn.Height) { Text = name };
            label.SetAlign(Align.Center, new GfxPoint(0, 5));
            label.SetFont(22);

            btn.Move(x, y);
            btn.OnRelease = caller =>
                                {
                                    Text += label.Text;
                                    mTextArea.Text = Text;
                                };
            btn.Hide();
            mSymbolLayout.Add(btn);


            return btn;
        }
        Button RusButton(IWidget parent, string name, int x, int y)
        {
            const int kHeight = 35;
            const float kRound = 5f;

            var contour = VGPath.OpenVGPath(); // 33x35
            VGU.vguRoundRect(contour, 0, 0, 33, kHeight, kRound, kRound);
            var normal = new VGPath(contour, null, new VGSolidColor(Palette.LightGrey));
            var active = new VGPath(contour, null, new VGSolidColor(Palette.DarkGray));

            var btn = new Button(parent, active, normal);//, "rus");//, x, y, width, kHeight, kRound);

            var label = new TextArea(btn, 0, 0, btn.Width, btn.Height) { Text = name };
            label.SetAlign(Align.Center, new GfxPoint(0, 5));
            label.SetFont(22);

            btn.Move(x, y);
            btn.OnRelease = caller =>
                                {                                    
                                    Text += Text.Length == 0 ? label.Text : label.Text.ToLower();
                                    mTextArea.Text = Text;
                                };
            btn.Hide();
            mRusLayout.Add(btn);


            return btn;
        }
        Button EngButton(IWidget parent, string name, int x, int y)
        {
            const int kHeight = 35;
            const float kRound = 5f;

            var contour = VGPath.OpenVGPath(); // 33x35
            VGU.vguRoundRect(contour, 0, 0, 33, kHeight, kRound, kRound);
            var normal = new VGPath(contour, null, new VGSolidColor(Palette.LightGrey));
            var active = new VGPath(contour, null, new VGSolidColor(Palette.DarkGray));

            var btn = new Button(parent, active, normal);//, "eng");//, x, y, width, kHeight, kRound);

            var label = new TextArea(btn, 0, 0, btn.Width, btn.Height) { Text = name };
            label.SetAlign(Align.Center, new GfxPoint(0, 5));
            label.SetFont(22);

            btn.Move(x, y);
            btn.OnRelease = caller =>
                                {
                                    Text += Text.Length == 0 ? label.Text : label.Text.ToLower();
                                    mTextArea.Text = Text;
                                };
            btn.Hide();
            mEngLayout.Add(btn);

            return btn;
        }

        private void AddChilds()
        {
            #region generic

            var window = this;

            mTextArea = new TextArea(window, 20, 207, 435, 25) { Text = "" };//, Size = 18, Background = true};            
            mTextArea.SetFont(Palette.Black, 24);
            mTextArea.SetAlign(Align.Left, new GfxPoint(0, 5));


            var outline = VGPath.OpenVGPath();
            VGU.vguRoundRect(outline, 0, 0, mTextArea.Width + 6, mTextArea.Height + 6, 5, 5);
            var vgOutline = new VGPath(outline, new VGSolidColor(Palette.LightGrey), new VGSolidColor(Palette.White));
            vgOutline.Move(mTextArea.X - 3, mTextArea.Y - 3);
            window.AddVGPath(vgOutline);
            
            GenericButton(window, 15, 15, 80, "cancel", Palette.Red).OnRelease = caller =>
            {
                if (ReturnWindow == null) return;

                mTextArea.Text = "";
                Text = "";

                mBlink.Stop();

                mApplication.SetFocusedWindow(ReturnWindow);
            };
            
            GenericButton(window, 385, 15, 80, "enter", Palette.Lime).OnRelease = caller =>
            {
                if (ReturnWindow == null) return;
                
                if (OnEnter != null)
                    OnEnter(Text);

                mTextArea.Text = "";
                Text = "";

                mBlink.Stop();

                mApplication.SetFocusedWindow(ReturnWindow);
            };
            
            GenericButton(window, 110, 15, 260, "", null).OnRelease = caller =>
            {
                Text = (Text + " ");
                mTextArea.Text = Text;
            };
            
            #endregion

            #region symbols

            var xPos = 110;
            var xPosStep = 52;
            var yPos = 150;

            #region first row

            {
                var btnRus = NumericButton(window, "rus", 20, yPos);
                btnRus.OnRelease = caller => ActivateLayout(mRusLayout);
                
                NumericButton(window, "0", xPos, yPos);
                xPos += xPosStep;

                NumericButton(window, "1", xPos, yPos);
                xPos += xPosStep;

                NumericButton(window, "2", xPos, yPos);
                xPos += xPosStep;

                NumericButton(window, "3", xPos, yPos);
                xPos += xPosStep;

                NumericButton(window, "4", xPos, yPos);

                xPos = 415;
                var btnDel = NumericButton(window, "del", xPos, yPos);
                btnDel.OnRelease = caller =>
                {
                    Text = RemoveLastSymbol(Text);
                    mTextArea.Text = Text;
                };
                
            }

            #endregion
            
            #region second row
            xPos = 110;
            yPos = 107;
            {
                var btnEng = NumericButton(window, "eng", 20, yPos);
                //btnEng.PressColor = Utils.ColorPalette.Blue;
                btnEng.OnRelease = caller => ActivateLayout(mEngLayout);

                NumericButton(window, "5", xPos, yPos);
                xPos += xPosStep;

                NumericButton(window, "6", xPos, yPos);
                xPos += xPosStep;

                NumericButton(window, "7", xPos, yPos);
                xPos += xPosStep;

                NumericButton(window, "8", xPos, yPos);
                xPos += xPosStep;

                NumericButton(window, "9", xPos, yPos);
            }

            #endregion

            #region third row
            xPos = 110;
            yPos = 65;
            {
                NumericButton(window, ".", xPos, yPos);
                xPos += xPosStep;

                NumericButton(window, ",", xPos, yPos);
                xPos += xPosStep;

                NumericButton(window, "_", xPos, yPos);
                xPos += xPosStep;

                NumericButton(window, "#", xPos, yPos);
                xPos += xPosStep;

                NumericButton(window, ":", xPos, yPos);
            }

            #endregion
            
            #endregion
            
            #region russian
            xPos = 10;
            xPosStep = 39;
            yPos = 150;

            #region first row

            {
                RusButton(window, "É", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "Ö", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "Ó", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "Ê", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "Å", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "Í", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "Ã", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "Ø", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "Ù", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "Ç", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "Õ", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "Ú", xPos, yPos);
            }

            #endregion

            #region second row

            xPos = 10;
            yPos = 107;
            {
                var btn123 = RusButton(window, "123", xPos, yPos);
                //btn123.PressColor = Utils.ColorPalette.Blue;
                btn123.OnRelease = caller => ActivateLayout(mSymbolLayout);                
                xPos += xPosStep;

                RusButton(window, "Ô", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "Û", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "Â", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "À", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "Ï", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "Ð", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "Î", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "Ë", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "Ä", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "Æ", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "Ý", xPos, yPos);
            }

            #endregion

            #region third row

            xPos = 10;
            yPos = 65;
            {
                var btnEng = RusButton(window, "eng", xPos, yPos);
                //btnEng.PressColor = Utils.ColorPalette.Blue;
                btnEng.OnRelease = caller => ActivateLayout(mEngLayout);       
                xPos += xPosStep;

                RusButton(window, "ß", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "×", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "Ñ", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "Ì", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "È", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "Ò", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "Ü", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "Á", xPos, yPos);
                xPos += xPosStep;

                RusButton(window, "Þ", xPos, yPos);
                xPos += xPosStep;

                xPos += xPosStep;
                var btnDel = RusButton(window, "del", xPos, yPos);
                btnDel.OnRelease = caller =>
                {
                    Text = RemoveLastSymbol(Text);
                    mTextArea.Text = Text;
                };
            }

            #endregion


            #endregion
                        
            #region english
            xPos = 10;
            xPosStep = 39;
            yPos = 150;

            #region first row

            {
                EngButton(window, "Q", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "W", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "E", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "R", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "T", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "Y", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "U", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "I", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "O", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "P", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "{", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "}", xPos, yPos);
            }

            #endregion

            #region second row

            xPos = 10;
            yPos = 107;
            {
                var btn123 = EngButton(window, "123", xPos, yPos);
                //btn123.PressColor = Utils.ColorPalette.Blue;
                btn123.OnRelease = caller => ActivateLayout(mSymbolLayout);
                xPos += xPosStep;

                EngButton(window, "A", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "S", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "D", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "F", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "G", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "H", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "J", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "K", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "L", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, ";", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "\"", xPos, yPos);
            }

            #endregion

            #region third row

            xPos = 10;
            yPos = 65;
            {
                var btnRus = EngButton(window, "rus", xPos, yPos);
                //btnRus.PressColor = Utils.ColorPalette.Blue;
                btnRus.OnRelease = caller =>  ActivateLayout(mRusLayout);
                xPos += xPosStep;

                EngButton(window, "Z", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "X", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "C", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "V", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "B", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "N", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "M", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, "<", xPos, yPos);
                xPos += xPosStep;

                EngButton(window, ">", xPos, yPos);
                xPos += xPosStep;

                xPos += xPosStep;
                var btnDel = EngButton(window, "del", xPos, yPos);
                btnDel.OnRelease = caller => 
                {
                    Text = RemoveLastSymbol(Text);
                    mTextArea.Text = Text;
                };
            }

            #endregion


            #endregion
            
        }


    }
}
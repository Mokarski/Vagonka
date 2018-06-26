using System;
using SDK.UI.Widgets.Base;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Style.WXGA.Sparc
{
    public class ClassicWindow : Window
    {
        private TextArea mClock;

        public ClassicWindow(string name)
            : base(name, 1280, 800)
        {
            mBackground = new Color(0x121212FF);

            InitPanel();

            OnPaint += caller => UpdateClock();
        }

        public bool UpdateClock()
        {
            if(mClock != null)
            if(mClock.Text != null)
                if(mClock.Text != DateTime.Now.ToString("HH:mm"))
                {
                    mClock.Text = DateTime.Now.ToString("HH:mm");
                    return true;
                }

            return false;
        }

        public ButtonEvent OnHomeRelease { get; set; }

        protected void InitPanel()
        {
            mClock = Text.Clock(this);
        }

        public override ModalWindow AddModal(string name)
        {
            var modal = base.AddModal("modal-" + name);

            var modalOutline = VGPath.OpenVGPath();
            VGU.vguRoundRect(modalOutline, 0, 0, 400, 230, 20, 20);

            var fill = new VGLinearGradient(0, 0, 0, 230);
            fill.AddColor(0, Palette.DarkGray);
            fill.AddColor(25, Palette.LightGrey);
            fill.AddColor(100, Palette.LightGrey);

            var outline = new VGPath(modalOutline,
                                     new VGSolidColor(Palette.DarkSlateGray),
                                     fill) { StrokeWidth = 2.0f };
            outline.Move(40, 25);
            modal.AddVGPath(outline);

            var textOutline = VGPath.OpenVGPath();
            VGU.vguRect(textOutline, 0, 0, 360, 160);
            var text = new VGPath(textOutline,
                new VGSolidColor(Palette.DarkSlateGray),
                new VGSolidColor(Palette.White)) { StrokeWidth = 2.0f };
            text.Move(60, 85);
            modal.AddVGPath(text);

            switch (name)
            {
                case "yesno":
                    ConfigureModalYesNo(modal);
                    break;

                case "ok":
                    ConfigureModalOk(modal);
                    break;
            }

            return modal;
        }

        private void ConfigureModalYesNo(ModalWindow modal)
        {           
            /*
            var no = WVGA.Antioxidant.Buttons.ModalButton(modal, Resource.No, 65, 35, WVGA.Antioxidant.ColorStyle.Red);
            no.OnRelease += caller =>
                                {
                                    if (modal.OnNoRelease != null)
                                        modal.OnNoRelease();

                                    modal.Hide();
                                };
            no.Name = Resource.No;

            var yes = WVGA.Antioxidant.Buttons.ModalButton(modal, Resource.Yes, 320, 35, WVGA.Antioxidant.ColorStyle.Green);
            yes.OnRelease += caller =>
                                 {
                                     if (modal.OnYesRelease != null)
                                        modal.OnYesRelease();

                                     modal.Hide();
                                 };
            yes.Name = Resource.Yes;

            modal.OnShow += caller =>
                                {
                                    const int kSize = 22;
                                    const int kWidth = 350;

                                    if (!string.IsNullOrEmpty(modal.Header))
                                    {
                                        var header = new TextArea(modal, (mApplication.Screen.Width - kWidth) / 2, 215, kWidth, kSize) { Text = modal.Header };
                                        header.SetAlign(Align.Center, new GfxPoint(0, 5));
                                        header.SetFont(Palette.Black, kSize + 4);
                                    }

                                    if (string.IsNullOrEmpty(modal.Message))
                                        return;
                                    
                                    var lines = modal.Message.Split(new[] { "\\r", "\\n" }, StringSplitOptions.RemoveEmptyEntries);

                                    for (var i = 0; i < lines.Length; i++)
                                    {
                                        var line = new TextArea(modal, (mApplication.Screen.Width - kWidth)/2, 90 + kSize * i, kWidth, kSize)
                                        { Text = lines[lines.Length - i - 1] };

                                        line.SetAlign(Align.Center, new GfxPoint(0, 5));
                                        line.SetFont(Palette.Black, kSize);
                                    } 
                                };
             */
        }

        private void ConfigureModalOk(ModalWindow modal)
        {
            /*
            var no = WVGA.Antioxidant.Buttons.ModalButton(modal, Resource.Ok, 0, 35, WVGA.Antioxidant.ColorStyle.Green);
            no.Move((modal.Width - no.Width)/2, no.Y);
            no.OnRelease += caller =>
            {
                if (modal.OnOkRelease != null)
                    modal.OnOkRelease();

                modal.Hide();
            };
            no.Name = Resource.Ok;


            modal.OnShow += caller =>
            {
                const int kSize = 22;
 

                if (!string.IsNullOrEmpty(modal.Header))
                {
                    var header = new TextArea(modal, (mApplication.Screen.Width - 350) / 2, 215, 350, kSize) { Text = modal.Header };
                    header.SetAlign(Align.Center, new GfxPoint(0, 5));
                    header.SetFont(Palette.Black, kSize + 4);   
                }


                if(string.IsNullOrEmpty(modal.Message))
                    return;

                const int kWidth0 = 200;
                const int kWidth1 = 150;
                var lines = modal.Message.Split(new[] { "\\t" }, StringSplitOptions.RemoveEmptyEntries);                
                for (var i = 0; i < (lines.Length / 2) ; i++)
                {
                    var line0 = new TextArea(modal, 60, 90 + kSize * i, kWidth0, kSize) { Text = lines[lines.Length - 2 * i - 2] };
                    var line1 = new TextArea(modal, (60 + kWidth0), 90 + kSize * i, kWidth1, kSize) { Text = lines[lines.Length - 2 * i - 1] };

                    line0.SetAlign(Align.Left, new GfxPoint(5, 5));
                    line0.SetFont(Palette.Black, kSize);

                    line1.SetAlign(Align.Left, new GfxPoint(5, 5));
                    line1.SetFont(Palette.Black, kSize);

                }
                
            };
             */
        }
    }
}

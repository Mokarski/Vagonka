using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace SDK.UI.Windows
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly Thread mFbUpdaterThread;
        private readonly Image mImage;
        private static Application mApplication;

        private const int kWidth = 480;
        private const int kHeight = 272;

        public MainWindow()
        {
            InitializeComponent();

            MouseLeftButtonDown += OnMouseLeftDown;
            MouseLeftButtonUp += OnMouseLeftUp;

            MouseRightButtonDown += OnRightButtonDown;
            
            KeyDown += WpfWindowKeyDown;
            KeyUp += WpfWindowKeyUp;


            AllowsTransparency = true;
            WindowStyle = WindowStyle.None;

            Width = kWidth;
            Height = kHeight;
            Top = Left = 10;

            // Create Image Element
            mImage = new Image { Width = Width, Height = Height };

            Closing += StopThread;

            if (VGInit() <= 0)
                return;

            mApplication = new SmartApp.SmartApp().GetConfigureApplication(Application.Type.Windows, kWidth, kHeight);

            mFbUpdaterThread = new Thread(mApplication.Run);
            mFbUpdaterThread.Start((Application.ScreenUpdateEvent)VGSwapBuffers);

            Content = mImage;

            AppDomain.CurrentDomain.UnhandledException += (sender, e)
                => mApplication.HandleException((Exception)e.ExceptionObject);
        }

        private void OnRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            var position = e.MouseDevice.GetPosition(this);
            Debug.WriteLine("x: {0}, y: {1}", position.X, (Height - position.Y));
        }

        private MouseData GetMouseEvent(MouseEventArgs e)
        {
            var position = e.MouseDevice.GetPosition(this);

            return new MouseData { X = (int)position.X, Y = (int)(Height - position.Y) };
        }

        void OnMouseLeftDown(object sender, MouseButtonEventArgs e)
        {
            mApplication.PostEvent(Application.EventType.MouseDown, GetMouseEvent(e));
        }

        void OnMouseLeftUp(object sender, MouseButtonEventArgs e)
        {
            mApplication.PostEvent(Application.EventType.MouseUp, GetMouseEvent(e));
        }


        private static KeyboardData GetKeyEvent(KeyEventArgs e)
        {
            return new KeyboardData { Keycode = KeyInterop.VirtualKeyFromKey(e.Key) };
        }

        private void WpfWindowKeyUp(object sender, KeyEventArgs e)
        {
            //Console.WriteLine("Release: {0}", e.Key);

            mApplication.PostEvent(Application.EventType.KeyboardRelease, GetKeyEvent(e));
        }

        private void WpfWindowKeyDown(object sender, KeyEventArgs e)
        {
            //Console.WriteLine("Press: {0}", e.Key);

            mApplication.PostEvent(Application.EventType.KeyboardPress, GetKeyEvent(e));
        }

        private static void StopThread(object sender, CancelEventArgs e)
        {
            mApplication.Dispose();
            VGDestroy();   
        }

        #region vg_wrapper
        static uint VGInit()
        {
            return (uint) VgContext.vgInitContextAM(kWidth, kHeight, VGboolean.VG_TRUE);
        }

        static void VGDestroy()
        {
            VgContext.vgDestroyContextAM();
        }

        
        public void VGSwapBuffers()
        {
            Dispatcher.BeginInvoke(DispatcherPriority.Normal,
                new Action(
                            delegate
                            {
                                var image = new byte[kWidth * kHeight * 4];
                                
                                // Copy the array to unmanaged memory.
                                Marshal.Copy(VgContext.vgGetSurfacePixelsAM(), image, 0, image.Length);
                                var wbi = new WriteableBitmap(kWidth, kHeight, 96.0f, 96.0f, PixelFormats.Bgra32, null);
                                wbi.WritePixels(new Int32Rect(0, 0, wbi.PixelWidth, wbi.PixelHeight), image, (wbi.PixelWidth * wbi.Format.BitsPerPixel) / 8, 0);
                                mImage.Source = wbi;
                            }
                        ));
        }
         
        #endregion
    }
}


using System;

namespace SDK.UI.Windows
{
    class Program
    {
        private static Application mApplication;

        static void Main()
        {
            const int kWidth = 480;
            const int kHeight = 272;

            var hwnd = WindowClass.Create(10, 10, kWidth, kHeight);

            WindowClass.ShowWindow(hwnd, WindowClass.ShowWindowCommands.Normal);
            WindowClass.UpdateWindow(hwnd);

            if (EGLContext.InitWindows(hwnd, WindowClass.GetDC(IntPtr.Zero)))
            {
                mApplication = new SmartApp.WVGA.Sparc.SmartApp().GetConfigureApplication(Application.Type.Windows, kWidth, kHeight);
                mApplication.Run(Swap, WindowClass.DispatchMessages);
            }
            EGLContext.Dispose();

            Console.WriteLine("Oops, cann't init OpenVG library");
        }

        private static void Swap()
        {
            Console.WriteLine("{0}: swap", DateTime.Now.ToString("mm:ss.fff"));
            EGLContext.SwapBuffers();
        }
    }
}

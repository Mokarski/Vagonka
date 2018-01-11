using System;

namespace SDK.UI.Linux
{
    class Program
    {
        private static Application mApplication;

        static void Main()
        {
            //if (EGLContext.InitAmanith())
            if (EGLContext.InitVivante())
            {
                mApplication = new SmartApp.SmartApp().GetConfigureApplication(Application.Type.Windows, 480, 272);
                mApplication.Run(Swap, null);
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

using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using SDK.Common;
using SDK.Prospero.Hardware;
using SDK.RestServer;
using SDK.UI.Widgets;
using SDK.UI.Widgets.Base;

namespace SDK.UI.SmartApp
{
    public class SmartApp
    {       
        private static Application mApplication;
        private HttpRestServer mHtttd;
        private byte mUnsuccessPingCount;
        private int mHeight;
        private int mWidth;

        private static bool TestWiFi()
        {
            var ping = new Ping();
            try
            {
                var reply = ping.Send("192.168.1.1");

                return reply != null && reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
            }

            return false;
        }

        public Application GetConfigureApplication(Application.Type aEnviromentType, int width, int height)
        {
            mWidth = width;
            mHeight = height;

            
            #region Http daemon
            mHtttd = new HttpRestServer(null);
            mHtttd.Start();
            #endregion

            #region Hardware init
            HwCore.Init(aEnviromentType);
            Display.DefaultBrightness = 85;
            Display.SetDefaultBrightness();

            HwCore.DeepStandby = false;
            HwCore.StandbyTimeout = new TimeSpan(0, 0, 0, 30);
            #endregion

            #region Windows registration
            {
                mApplication =  Application.GetInstance();

                mApplication.AddWindow(HomeWindow());

                mApplication.SetFocusedWindow("home");
            }
            #endregion

            #region WiFi status
            var wifi = new PeriodicTask(3000);
            wifi.OnPeriod += () =>
            {
                if (mApplication == null)
                    return;

                if (!TestWiFi())
                    mUnsuccessPingCount++;
                else
                    mUnsuccessPingCount = 0;

                ((Window)(mApplication.GetFocusedWindow())).LeftText = (mUnsuccessPingCount < 10) ? "WiFi" : "";
                mApplication.GetFocusedWindow().Invalidate();
            };
            wifi.Start();
            #endregion

            #region User clock
            var clock = new PeriodicTask(1000);
            clock.OnPeriod += () =>
            {
                if (mApplication == null)
                    return;

                if (((Window) (mApplication.GetFocusedWindow())).RightText == DateTime.Now.ToString("HH:mm")) return;

                ((Window) (mApplication.GetFocusedWindow())).RightText = DateTime.Now.ToString("HH:mm");
                mApplication.GetFocusedWindow().Invalidate();
            };
            clock.Start();
            #endregion

            return mApplication;
        }

        private Window HomeWindow()
        {
            var window = new Window("home", mWidth, mHeight) {Description = "Шеф-повар \"Сибовар\""};

            window.OnPaint += () => Debug.Print("Home update");

            return window;
        }

        public void Dispose()
        {
            mHtttd.Stop();
            mApplication.Dispose();
        }
    }
}

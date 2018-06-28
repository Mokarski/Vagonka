using System;
using System.Diagnostics;
using System.Threading;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Widgets.Base
{
    //            var video0 = new ProcessHelper("/usr/bin/gst-launch-0.10", "tcpclientsrc host=127.0.0.1 port=5000 ! multipartdemux boundary=\"boundary\" ! vpudec ! mfw_isink axis-left=210 axis-top=20 disp-width=240 disp-height=180", 10);
    //            var video1 = new ProcessHelper("/usr/bin/gst-launch-0.10", "tcpclientsrc host=127.0.0.1 port=5001 ! multipartdemux boundary=\"boundary\" ! vpudec ! mfw_isink axis-left=500 axis-top=20 disp-width=240 disp-height=180", 10);

    //            var video = new ProcessHelper("/usr/bin/gst-launch-0.10", "tcpclientsrc host=127.0.0.1 port=5000 ! multipartdemux boundary=\"boundary\" ! vpudec ! mfw_isink axis-left=128 axis-top=0 disp-width=1024 disp-height=800", 10);

    //            var video = new ProcessHelper("/usr/bin/gst-launch-0.10", "tcpclientsrc host=127.0.0.1 port=5001 ! multipartdemux boundary=\"boundary\" ! vpudec ! mfw_isink axis-left=128 axis-top=0 disp-width=1024 disp-height=800", 10);

    
    public class VideoPlayer : Widget
    {
        private readonly Thread mThread;
        private Process mProcess;
        private readonly string mArgs;
        private bool mStart;
        private readonly VGPath mPath;

        public VideoPlayer(IWindow parent, string text, int port, int x, int y, int width, int height) : base(parent, x, Application.Screen.Height - y - height, width, height)
        {
            var label = new TextArea(this, 0, height/2 - 20, width, 40) {Text = text};
            label.SetFont(Palette.White, 35);
            label.SetAlign(Align.Center, new GfxPoint(0, 5));


            mPath = new VGPath(null, new VGSolidColor(new Color(0x2c2d2eff)));            
            //VGU.vguRect(mPath.GetPath(), 0, 0, width, height);            
            VGU.vguRoundRect(mPath.GetPath(), 0, 0, width - 12, height - 12, 10, 10);
            mPath.Move(6, 7);

            mArgs = string.Format("tcpclientsrc host=127.0.0.1 port={0} ! multipartdemux boundary=\"boundary\" ! vpudec ! mfw_isink axis-left={1} axis-top={2} disp-width={3} disp-height={4}",
                                  port,
                                  x, y,
                                  width, height);

            Environment.SetEnvironmentVariable("VSALPHA", "1");

            mThread = new Thread(Processing);
            mThread.Start();
        }

        private void Processing()
        {
            try
            {
                while (true)
                {
                    if (mStart)
                    {
                        if (mProcess == null)
                        {
                            //Console.WriteLine("try to start videoplayer: args {0}", mArgs);

                            Thread.Sleep(1000);
                            mProcess = new Process
                                           {
                                               StartInfo =
                                                   {
                                                       UseShellExecute = false,
                                                       CreateNoWindow = true,
                                                       FileName = "/usr/bin/gst-launch-0.10",
                                                       RedirectStandardOutput = true,
                                                       RedirectStandardError = true,
                                                       RedirectStandardInput = true,

                                                       
                                                       Arguments = mArgs
                                                   }
                                           };


                            mProcess.OutputDataReceived += (sender, args) => { };
                            mProcess.ErrorDataReceived += (sender, args) => { };
 
                           mProcess.Start();
                        }
                    }
                    else
                        StopProcess();

                    Thread.Sleep(100);
                }
            }
            catch (ThreadAbortException)
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine("oooops: videoplayer: {0}", ex);
            }

            StopProcess();
        }

        private void StopProcess()
        {
            if (mProcess == null)
                return;

            //Console.WriteLine("->> stop videoplayer");

            var kill = Process.Start("kill", " -SIGINT " + mProcess.Id);                
            Thread.Sleep(100);
            if (kill != null) kill.WaitForExit(500);

            mProcess.WaitForExit(500);
            mProcess = null;

            //Console.WriteLine("<<- stop videoplayer");
        }
        	

        public void Start()
        {
            if (Application.OperationSystem == Application.OS.Linux)          
                mStart = true;
        }

        public void Stop()
        {
            mStart = false;
        }

        protected override void Draw()
        {
            mPath.Update();
        }

        public new void Dispose()
        {
            Stop();
            mThread.Abort();

            mPath.Dispose();

            base.Dispose();
        }
    }
}
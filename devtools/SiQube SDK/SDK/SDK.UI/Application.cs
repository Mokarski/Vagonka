using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using SDK.UI.Fonts;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI
{
    public class Application : IDisposable
    {
        public enum EventType
        {
            SetFocus,
            Invalidate, //данные - объект требующий перерисовки

            MouseMove, //данные - экземпляр MouseData

            MouseUp, //данные - экземпляр MouseData
            MouseDown, //данные - экземпляр MouseData
            KeyboardPress,
            KeyboardRelease,
            KeyHold,

            Motion,
            BLEMessage
        }

        public delegate void PointerToVoidMethod();


        private static volatile Application mInstance;
        private static readonly object SyncRoot = new Object();

        private readonly List<IWindow> mWindows = new List<IWindow>();
        private static IWindow mFocusedWindow;
        private static IWindow mPreviousFocusedWindow;

        private struct EventBundle
        {
            public EventBundle(uint id, EventType aType, object aData)
            {
                mId = id;
                mType = aType;
                mData = aData;
            }

            private readonly uint mId;
            public readonly EventType mType;
            public readonly object mData;
        }

        private static readonly Queue<EventBundle> InvalidateEvents = new Queue<EventBundle>();
        private static readonly Queue<EventBundle> InputEvents = new Queue<EventBundle>();

        private readonly Dictionary<string, ITextRender> mTextRenders;

        public static string ResourceUrl { get; private set; }

        public void SetCulture(string lang)
        {
            // установить культуру для форматирования
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
           
            // установить культуру для ресурсов
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);

            try
            {
                File.WriteAllText(Path.Combine(ResourceUrl, @"lang"), lang);
                try
                {
                    Process.Start("sync");
                }
                catch (Win32Exception)
                {
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void LoadCulture()
        {
            try
            {
                // установить культуру для форматирования
                Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-Ru");

                if (File.Exists(Path.Combine(ResourceUrl, @"lang")))
                {
                    var lang = File.ReadAllText(Path.Combine(ResourceUrl, @"lang"));

                    // установить культуру для ресурсов
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
                }
                else
                    Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        public string Localization { get { return Thread.CurrentThread.CurrentUICulture.Name; } }

        public void HandleException(Exception ex)
        {
            try
            {
                File.WriteAllBytes("/dev/fb0", File.ReadAllBytes("/mnt/software/bin/images/fatal.raw"));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            var location = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            if (String.IsNullOrEmpty(location))
                location = "";

            using (var logStream = new FileStream(Path.Combine(location, "UnhandledExceptions.log"), FileMode.Append, FileAccess.Write))
            {
                var writer = new StreamWriter(logStream);

                var logData = String.Format("{0} {1}:{2}", DateTime.Now, ex.GetType(), ex.Message);

                Console.WriteLine("loging - {0}", logData);

                writer.WriteLine(logData);
                writer.WriteLine(ex.StackTrace);

                writer.Dispose();
            }
        }

        /// <summary>
        /// Только для отладки
        /// </summary>
        internal void Swap()
        {
            mSwapBuffer();
        }

        public static void Init(PointerToVoidMethod aScreenUpdateEvent, int width, int height)
        {
            Init(aScreenUpdateEvent, null, width, height);
        }

        public static void Init(PointerToVoidMethod aScreenUpdateEvent, PointerToVoidMethod aGdiDispatch, int width, int height)
        {
            Screen = new GfxSize(width, height);

            mSwapBuffer = aScreenUpdateEvent;
            mGdiDisptachEvent = aGdiDispatch;
        }

        public static void Run()
        {
            if (mSwapBuffer == null)
                throw new ArgumentException("screenUpdateEvent");

            while (true)
            {
                EventBundle? nextEvent = null;

                lock (InputEvents)
                {
                    if (InputEvents.Count > 0)
                    {
                        nextEvent = InputEvents.Dequeue();
                    }
                    else
                    {
                        lock (InvalidateEvents)
                        {
                            if (InvalidateEvents.Count > 0)
                            {
                                nextEvent = InvalidateEvents.Dequeue();

                                #region delete duplicate invalidate message
                                if (nextEvent.Value.mType == EventType.Invalidate)
                                {
                                    if (InvalidateEvents.Count > 0)
                                    {
                                        var peek = InvalidateEvents.Peek();
                                        var deletedEvent = 0;
                                        while (peek.mType == EventType.Invalidate)
                                        {
                                            if (ReferenceEquals(nextEvent.Value.mData, peek.mData))
                                            {
                                                nextEvent = InvalidateEvents.Dequeue();
                                                deletedEvent++;
                                            }
                                            else
                                                break;

                                            if (InvalidateEvents.Count > 0)
                                                peek = InvalidateEvents.Peek();
                                            else
                                                break;
                                        }

                                        if (deletedEvent > 0)
                                        {
                                            //Console.WriteLine("deleted event: {0}", deletedEvent);                                            
                                        }
                                    }

                                }
                                #endregion
                            }
                        }
                    }
                }

                if (nextEvent != null)
                {
                    //Console.WriteLine("EventHandler");

                    //handleEvents
                    switch (nextEvent.Value.mType)
                    {
                        case EventType.Invalidate:
                            {
                                //DebugTimeToConsole("--> Invalidate");
                                if (mFocusedWindow == null)
                                    break;

                                if (ReferenceEquals(mFocusedWindow, nextEvent.Value.mData))
                                {
                                    if (mFocusedWindow.OnPaint != null)
                                        mFocusedWindow.OnPaint(mFocusedWindow);

                                    //DebugTimeToConsole("0");
                                    mFocusedWindow.Update();
                                    //DebugTimeToConsole("1");
                                    mSwapBuffer();

                                    //DebugTimeToConsole("2");
                                    //if(nextEvent.Value.mId  == 0)
                                    //    Console.WriteLine("Application.FirstUpdate: {0}", mApplicationWatch.ElapsedMilliseconds);

                                    //DebugTimeToConsole("<-- Invalidate");
                                }
                            }
                            break;
                        case EventType.SetFocus:
                            {
                                if (nextEvent.Value.mData == null)
                                    break;

                                // de-focus
                                if (mFocusedWindow != null)
                                {
                                    // delete all input events
                                    lock (InputEvents)
                                    {
                                        while (InputEvents.Count > 0)
                                        {
                                            EventBundle? inputEvent = InputEvents.Dequeue();
                                            mFocusedWindow.HandleEvent(inputEvent.Value.mType, inputEvent.Value.mData);
                                        }
                                    }

                                    if (mFocusedWindow != null)
                                        if (mFocusedWindow.OnHide != null)
                                            mFocusedWindow.OnHide(mFocusedWindow);
                                }

                                // set new focus window
                                mPreviousFocusedWindow = mFocusedWindow;
                                mFocusedWindow = (IWindow)nextEvent.Value.mData;
                                mIsFirstPressEvent = true;

                                if (mFocusedWindow.OnShow != null)
                                    mFocusedWindow.OnShow(mFocusedWindow);

                                //PostEvent(EventType.Invalidate, mFocusedWindow);
                                
                                if (mFocusedWindow.OnPaint != null)
                                    mFocusedWindow.OnPaint(mFocusedWindow);

                                mFocusedWindow.Update();
                                mSwapBuffer();
                                

                                //DebugTimeToConsole("SetFocus");
                            }
                            break;

                        default:
                            {
                                //Console.WriteLine("     {0}:{1}", nextEvent.Value.mId, nextEvent.Value.mType);
                                //DebugTimeToConsole("e");

                                if (mFocusedWindow != null)
                                {

                                    switch (nextEvent.Value.mType)
                                    {
                                        case EventType.KeyboardRelease:
                                        case EventType.MouseUp:                                        
                                            {
                                                // у нас не было нажатий в этом окне, поэтому это событие с предыдушего окна
                                                if(mIsFirstPressEvent)
                                                {
                                                    if(mPreviousFocusedWindow != null)
                                                    {
                                                        if (mPreviousFocusedWindow.HandleEvent(nextEvent.Value.mType, nextEvent.Value.mData))
                                                        {
                                                            //Console.WriteLine("catch prev event");
                                                        } 
                                                    }
                                                }
                                                else
                                                {
                                                    if (mFocusedWindow.HandleEvent(nextEvent.Value.mType, nextEvent.Value.mData))
                                                    {
                                                        mFocusedWindow.Update();
                                                        mSwapBuffer();
                                                    } 
                                                }
                                            }    
                                            break;

                                        case EventType.KeyHold:
                                        case EventType.KeyboardPress:
                                        case EventType.MouseDown:
                                            if (mFocusedWindow.HandleEvent(nextEvent.Value.mType, nextEvent.Value.mData))
                                            {
                                                mFocusedWindow.Update();
                                                mSwapBuffer();
                                                mIsFirstPressEvent = false;
                                            }
                                            break;
                                    }
                                }
                            } break;
                    }
                }

                if (mGdiDisptachEvent != null)
                    mGdiDisptachEvent();

                if (InputEvents.Count == 0 && InvalidateEvents.Count == 0)
                    Thread.Sleep(10);

            }
        }

        public ITextRender GetTextRender(string fontName)
        {
            ITextRender rv;
            mTextRenders.TryGetValue(fontName, out rv);

            if (rv == null)
                mTextRenders.TryGetValue("default", out rv);

            return rv;
        }

        public string[] GetAvailableFonts()
        {
            var rv = new string[] { };
            mTextRenders.Keys.CopyTo(rv, 0);

            return rv;
        }

        public bool AddFont(string name, IFontInfo font)
        {
            if (String.IsNullOrEmpty(name) || font == null)
                return false;

            mTextRenders.Add(name, new TextRender(font));
            return true;
        }

        public void DebugTimeToConsole(string text)
        {
            Console.WriteLine("{0}: {1}", text, mApplicationWatch.ElapsedMilliseconds);
        }

        protected Application()
        {
            mApplicationWatch = new Stopwatch();
            mApplicationWatch.Start();

            VG.vgSeti(VGParamType.VG_RENDERING_QUALITY, (int)VGRenderingQuality.VG_RENDERING_QUALITY_BETTER);

            //Console.WriteLine("Application.PreLoadFont: {0}", mApplicationWatch.ElapsedMilliseconds);
            // create fonts
            mTextRenders = new Dictionary<string, ITextRender>
                               {
                                   { "default", new TextRender(new MyriadProFont()) },
                               };

            //Console.WriteLine("Application.LoadFont: {0}", mApplicationWatch.ElapsedMilliseconds);

            var location = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            if (String.IsNullOrEmpty(location))
                location = "";

            ResourceUrl = Path.Combine(location, @"resources/");

            LoadCulture();

            if (Path.DirectorySeparatorChar == '\\')
                OperationSystem = OS.Windows;
            else if (IsRunningOnMac())
                OperationSystem = OS.Mac;
            else if (Environment.OSVersion.Platform == PlatformID.Unix)
                OperationSystem = OS.Linux;
            else
                OperationSystem = OS.Other;

            //Console.WriteLine("Application constructor");
        }

        private uint mInputEventId;
        private uint mEventId;
        private readonly Stopwatch mApplicationWatch;
        private static PointerToVoidMethod mSwapBuffer;
        private static PointerToVoidMethod mGdiDisptachEvent;
        private static bool mIsFirstPressEvent = true;
        public static OS OperationSystem { get; private set; }

        public void PostEvent(EventType aType, object aEventData)
        {
            //Console.WriteLine("PostEvent");
            switch (aType)
            {
                case EventType.Invalidate:
                    {
                        if (aEventData as IWindow != null)
                        {
                            lock (InvalidateEvents)
                            {
                                InvalidateEvents.Enqueue(new EventBundle(mEventId, aType, aEventData));
                                mEventId++;
                            }
                        }
                        else
                        {
                            var widget = aEventData as IWidget;

                            if (widget != null)
                                if (widget.RootWindow != null)
                                {
                                    lock (InvalidateEvents)
                                    {
                                        InvalidateEvents.Enqueue(new EventBundle(mEventId, aType, aEventData));
                                        mEventId++;
                                    }
                                }
                        }
                    }
                    break;
                case EventType.SetFocus:
                    {
                        if (aEventData as IWindow != null)
                            lock (InvalidateEvents)
                            {
                                InvalidateEvents.Enqueue(new EventBundle(mEventId, aType, aEventData));
                                mEventId++;
                            }
                    }
                    break;
                default:
                    {
                        //if(mEventId != 0)
                        lock (InputEvents)
                        {
                            //Console.WriteLine("{0}:{1} - {2}:{3}", mInputEventId, aType, ((MouseData)aEventData).X, ((MouseData)aEventData).Y);
                            //Console.WriteLine("event handler");

                            //if(aType == EventType.KeyboardRelease || aType == EventType.KeyboardPress)
                            //    Console.WriteLine("{0}:{1} - {2}", mInputEventId, aType, ((KeyboardData)aEventData).Keycode);

                            //DebugTimeToConsole("p");

                            InputEvents.Enqueue(new EventBundle(mInputEventId, aType, aEventData));
                            mInputEventId++;
                        }
                    }
                    break;
            }
        }

        public static Application GetInstance()
        {
            if (mInstance == null)
                lock (SyncRoot)
                    if (mInstance == null)
                        mInstance = new Application();

            return mInstance;
        }

        public static GfxSize Screen { get; private set; }

        public void AddWindow(IWindow aWindow, bool focused = false, bool update = true)
        {
            lock (mWindows)
            {
                mWindows.Add(aWindow);            
                
                if(update)
                    aWindow.Update();

                if (!focused) return;
                
                // TODO: может быть тут наложить текст типа идет загрузка приложения?

                mSwapBuffer();
                SetFocusedWindow(aWindow);
            }
        }

        public void RemoveWindow(IWindow aWindow)
        {
            lock (mWindows)
                mWindows.Remove(aWindow);
        }

        public IEnumerable<IWindow> GetWindows()
        {
            lock (mWindows)
                return mWindows.ToArray();
        }

        public IWindow GetFocusedWindow()
        {
            return mFocusedWindow;
        }

        public IWindow GetPreviousFocusedWindow()
        {
            return mPreviousFocusedWindow;
        }

        public void SetFocusedWindow(IWindow aWindow)
        {
            if (aWindow == null)
                return;

            lock (mWindows)
                if (mWindows.Contains(aWindow))
                    if (mFocusedWindow != aWindow)
                    {
                        PostEvent(EventType.SetFocus, aWindow);
                    }
        }

        public void SetFocusedWindow(string name)
        {
            var window = mWindows.FirstOrDefault(w => w.Name == name);

            if (window == null)
                throw new ArgumentException(String.Format("unknown window with name {0}", name));

            SetFocusedWindow(window);
        }

        public void Dispose()
        {

        }

        public enum OS
        {
            Windows,
            Mac,
            Linux,
            Other
        }

        [DllImport("libc")]
        static extern int uname(IntPtr buf);

        private static bool IsRunningOnMac()
        {
            var buf = IntPtr.Zero;
            try
            {
                buf = Marshal.AllocHGlobal(8192);
                // This is a hacktastic way of getting sysname from uname ()
                if (uname(buf) == 0)
                {
                    var os = Marshal.PtrToStringAnsi(buf);
                    if (os == "Darwin")
                        return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ooops: {0}", ex);
            }
            finally
            {
                if (buf != IntPtr.Zero)
                    Marshal.FreeHGlobal(buf);
            }
            return false;
        }
    }

}

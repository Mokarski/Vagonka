using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Linq;
using MeasureProcessing.ProcessingDaemon;
using ProcessingDaemon;
using UILib.Widgets;

// Unhandled Exception: System.IO.DirectoryNotFoundException: Could not find a part of the path "/mnt/software/bin/images/1/btn_settings.raw".


namespace UILib
{
    public static class Pa1ApplicationFactory
    {
        public static int ScreenWidth { get { return 480; } }
        public static int ScreenHeight { get { return 272; } }

        private static Application mApplication;
        private static KeyboardWindow mKeyboardWindow;

        private static PA1Control mDeviceControl;
        private static MeasureProcessController mMeasureController;

        public enum EnviromentType
        {
            LinuxFrameBuffer,
            WindowsWpf
        }

        public static int ToVgY(int aNormalY)
        {
            return ScreenHeight - aNormalY;
        }
        
        public static Application GetConfiguredApplication(EnviromentType aEnviromentType)
        {
            var location = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            if(string.IsNullOrEmpty(location))
                location = "";

            var path = Path.Combine(location, "images");

            mApplication = Application.GetInstance();

            mDeviceControl = new PA1Control();

            mMeasureController = new MeasureProcessController(mDeviceControl)
                                     {
                                         SwitchWindowAction = windowName =>
                                                                  {
                                                                      var rv = mApplication.GetWindows().First(w => w.Name == windowName) as Window;

                                                                      if(rv != null)
                                                                          if (rv.OnShow != null)
                                                                            rv.OnShow();

                                                                      mApplication.SetFocusedWindow(rv);
                                                                  }
                                     };

            /* Номера окон:
             * 1 - Главное меню;
             * 2 - ввод данных;
             * 3 - диалоговое окно 1 (подготовка к анализу);
             * 4.1 - измерение начального потенциала, процесс
             * 4.2 - измерение начального потенциала, результат
             * 4.3 - неудовлетворительное значение при измерении начального потенциала
             * 4.4 - график измерения начального потенциала
             * 5 - диалоговое окно;
             * 6 - ...
             * 7 - результаты измерения;
             
             * 8.1 - окно с текстом перед началом отмывки;
             * 8.2 - окно со статусом отмывки;
             * 8.3 - окно с текстом по окончании отмывки;
             * 8.4 - промежуточное окно по окончании n-го цикла;
             
             *  9 - настройки;
             * 10.1 - выбор архива; 10.2 - фильтр выбора архива;
             * 11.1 - содержимое архива;
             * 11.2 - график архива.
             * */

            mKeyboardWindow = new KeyboardWindow("keyboard_window");
            mApplication.AddWindow(mKeyboardWindow);


            mApplication.AddWindow(CreateWindow1(path)); // стартовое окно

            mApplication.AddWindow(CreateWindow2(path)); // начало анализа
            mApplication.AddWindow(CreateWindow3(path));
            
            mApplication.AddWindow(CreateWindow6_1(path));
            mApplication.AddWindow(CreateWindow6_2(path));
            mApplication.AddWindow(CreateWindow6_3(path));

            mApplication.AddWindow(CreateWindow7(path)); // результат

            mApplication.AddWindow(CreateWindow9_1(path)); // настройки 
            mApplication.AddWindow(CreateWindow9_2(path));
            mApplication.AddWindow(CreateWindow9_3(path));
            mApplication.AddWindow(CreateWindow9_4(path)); 
            mApplication.AddWindow(GetLoadingWindow(path));

            mApplication.AddWindow(CreateWindow10_1(path)); // работа с архивом
            mApplication.AddWindow(CreateWindow11(path));

            //mApplication.SetFocusedWindow("keyboard_window");
            //mApplication.SetFocusedWindow("window9_3");
            mApplication.SetFocusedWindow("window1");
            
            return mApplication;
        }

        private static Window CreateWindow1(string path)
        {
            var window = new Window("window1", Path.Combine(path, @"generic/bg.raw"));

            window.AddChild(new RawButton("window1_RawButton_setting", Path.Combine(path, @"1/btn_settings.raw"),
                                        Path.Combine(path, @"1/btn_settings_press.raw"), 25, ToVgY(220))
            {
                OnRelease = () => mApplication.SetFocusedWindow("window9_1")
            });
            window.AddChild(new RawButton("window1_RawButton_analys", Path.Combine(path, @"1/btn_analys.raw"), Path.Combine(path, @"1/btn_analys_press.raw"),
                                        215, ToVgY(138))
            {
                OnRelease = () =>
                                {
                                    var rv = mApplication.GetWindows().First(w => w.Name == "window2") as Window;

                                    if (rv == null) return;

                                    rv.OnShow();
                                    mApplication.SetFocusedWindow(rv);
                                }
            });
            window.AddChild(new RawButton("window1_RawButton_setting", Path.Combine(path, @"1/btn_archive.raw"), Path.Combine(path, @"1/btn_archive_press.raw"),
                                        215, ToVgY(250))
            {
                OnRelease = () =>
                                {
                                    var rv = mApplication.GetWindows().First(w => w.Name == "window10_1") as Window;
                                    if(rv == null) return;
                                        
                                    rv.OnShow();
                                    mApplication.SetFocusedWindow(rv);
                                }
            });

            return window;
        }

        private static Window CreateWindow2(string path)
        {
            const int fontSize = 14;

            var window = new Window("window2", Path.Combine(path, @"generic/bg.raw"));

            window.AddChild(new RawButton("window2_home", Path.Combine(path, @"generic/home.raw"), Path.Combine(path, @"generic/home.raw"), 383, 247)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window1")
            });

            var window2_bt_sample = new RawButton("window2_bt_sample", Path.Combine(path, @"2/input_pacient.raw"),
                                            Path.Combine(path, @"2/input_pacient.raw"), 18, ToVgY(84));
            var window2_bt_sample_text_render = new TextArea("window2_bt_sample_text_render", null, 25, ToVgY(72), 427)
            {
                Size = fontSize,
                Text = "sample1"
            };

            var window2_bt_executor = new RawButton("window2_bt_executor", Path.Combine(path, @"2/input_executor.raw"),
                                            Path.Combine(path, @"2/input_executor.raw"), 18, ToVgY(121));
            var window2_bt_executor_text_render = new TextArea("window2_bt_executor_text_render", null, 25, ToVgY(109), 427)
            {
                Size = fontSize
            };

            // TODO: доступные методики загружаются только исключительно на старте приложения
            var window2_meth_list = new ListWith3Items("window2_meth_list", 18, ToVgY(160), mDeviceControl.GetAvailMethodologies(),
                                                       Path.Combine(path, @"2/list.raw"), Path.Combine(path, @"2/list_clean.raw"),
                                                       Path.Combine(path, @"2/list_pressed.raw"), Path.Combine(path, @"2/list1.raw"),
                                                       Path.Combine(path, @"2/list2.raw"), Path.Combine(path, @"2/list3.raw"));

            window.OnShow = () =>
                                 {
                                     var settings = mDeviceControl.SettingsStorage.Load();

                                     window2_bt_executor_text_render.Text = settings.LastUsedExecutor;

                                     window2_meth_list.SelectedMethodology = settings.LastUsedMethodology;
                                 };

            window2_bt_sample.AddChild(window2_bt_sample_text_render);
            window2_bt_executor.AddChild(window2_bt_executor_text_render);
            window.AddChild(window2_bt_sample);
            window.AddChild(window2_bt_executor);
            window.AddChild(window2_meth_list);
            window.AddChild(new RawButton("window2_bt_next", Path.Combine(path, @"RawButtons/bt_onwards.raw"), Path.Combine(path, @"RawButtons/bt_onwards_pr.raw"), 350, 5)
            {
                OnRelease = () =>
                                {
                                    var meth = window2_meth_list.SelectedMethodology;

                                    if(meth == null)
                                        return;

                                    var executor = window2_bt_executor_text_render.Text;

                                    if (string.IsNullOrEmpty(executor))
                                        return;

                                    if(string.IsNullOrEmpty(window2_bt_sample_text_render.Text))
                                        return;
                                    
                                    mDeviceControl.SetMeasureData(window2_bt_sample_text_render.Text, executor, meth);

                                    mMeasureController.Reset();

                                    mApplication.SetFocusedWindow("window3");
                                }
            });

            window2_bt_sample.OnRelease = () =>
            {
                window2_bt_sample.ChangeUpImg(Path.Combine(path, @"2/input.raw"));
                window2_bt_sample.ChangeDownImg(Path.Combine(path, @"2/input.raw"));


                mKeyboardWindow.OnEnter = returnText =>
                {
                    if (!string.IsNullOrWhiteSpace(returnText))
                    {
                        window2_bt_sample_text_render.Text = returnText;
                    }
                };

                mKeyboardWindow.ReturnWindow = "window2";
                mKeyboardWindow.Text = "";// window2_bt_sample_text_render.Text;

                mApplication.SetFocusedWindow("keyboard_window");
            };

            window2_bt_executor.OnRelease = () =>
            {
                window2_bt_executor.ChangeUpImg(Path.Combine(path, @"2/input.raw"));
                window2_bt_executor.ChangeDownImg(Path.Combine(path, @"2/input.raw"));

                var rv = mApplication.GetWindows().First(w => w.Name == "window9_2") as Window;

                if(rv == null) return;

                rv.OnShow();
                mApplication.SetFocusedWindow(rv);
            };

            return window;
        }
        
        private static IWidget CreateWindow3(string path)
        {
            var window = new Window("window3", Path.Combine(path, @"generic/bg.raw"));

            window.AddChild(new TextArea("", null, 60, 170, 450) { Text = "             Нанесите гель на электроды,", Size = 16, Color = new Color { R = 1.0f, B = 1.0f, G = 1.0f } });
            window.AddChild(new TextArea("", null, 60, 150, 450) { Text = "             нажмите \"Далее\", после чего", Size = 16, Color = new Color { R = 1.0f, B = 1.0f, G = 1.0f } });
            window.AddChild(new TextArea("", null, 60, 130, 450) { Text = "приложите электроды с гелем к коже пациента.", Size = 16, Color = new Color { R = 1.0f, B = 1.0f, G = 1.0f } });
            

            window.AddChild(new RawButton("", Path.Combine(path, "RawButtons/bt_back.raw"), Path.Combine(path, "RawButtons/bt_back_pr.raw"), 5, 5)
                                 {
                                     OnRelease = () => mApplication.SetFocusedWindow("window2")
                                 });

            window.AddChild(new RawButton("", Path.Combine(path, "RawButtons/bt_onwards.raw"), Path.Combine(path, "RawButtons/bt_onwards_pr.raw"), 350, 5)
            {
                OnRelease = () => mMeasureController.StartSampleMeasure()
            });

            return window;
        }

        private static IWidget CreateWindow6_1(string path)
        {
            var window = new Window("window6_1", Path.Combine(path, @"generic/bg.raw"));
            // {Description = {Text = "Измерение потенциала системы с пробой"}};

            window.AddChild(new TextArea("window6_1_title", null, 10, 215, 400)
            {
                Color = { B = 1, G = 1, R = 1 },
                Text = "Идет измерение потенциала",
                Size = 16
            });

            var progressArea = new ProgressBarImages("bar", path, 10, 10) { Percent = 100, Text = "", TextColor = { B = 1, R = 1, G = 1 } };
            window.AddChild(progressArea);


            const int btnsX = 350;
            const int btnsYBase = 100;
            const int btnsYStep = 70;

            window.AddChild(new RawButton("window_6_1_graphic", Path.Combine(path, "RawButtons/bt_graphic.raw"), Path.Combine(path, "RawButtons/bt_graphic_pr.raw"), btnsX, ToVgY(btnsYBase))
            {
                OnRelease = () => mMeasureController.ShowSampleGraphic()
            });

            var table = new TextTable("window6_1.table", 15, 60, new[] { 210, 100 }, TextTable.CreateOffset(5, 22), new[] { 4, 4 }, null, 16);

            table.Cells[0, 0].Text = "Потенциал";
            table.Cells[0, 1].Text = "Тип активности";
            table.Cells[0, 2].Text = "Стабильность потенциала";
            table.Cells[0, 3].Text = "Времени затрачено";
            table.Cells[0, 4].Text = "Времени осталось";

            window.AddChild(table);

            mMeasureController.Window61DataAction = (percent, status, potential, temperature, activity, stability, time, left) =>
            {
                progressArea.Percent = percent;
                progressArea.Text = status;

                table.Cells[1, 0].Text = potential;
                table.Cells[1, 1].Text = activity;
                table.Cells[1, 2].Text = stability;
                table.Cells[1, 3].Text = time;
                table.Cells[1, 4].Text = left;

                window.Invalidate();
            };


            const int popupX = 40;
            const int popupY = 30;

            #region acceptPopup
            var acceptPopup = new ModalWindow("", path);
            acceptPopup.TextLines[1].Text = "    Принять текущее значение потенциала?";
            acceptPopup.TextLines[1].Size = 16;

            acceptPopup.AddChild(new RawButton("", Path.Combine(path, "generic/modals/RawButtons/bt_yes.raw"), Path.Combine(path, "generic/modals/RawButtons/bt_yes_pr.raw"), popupX + 280, popupY)
            {
                OnRelease = () =>
                {
                    mMeasureController.StopSampleMeasure();
                    acceptPopup.IsVisible = false;

                    window.Invalidate();
                }
            });
            acceptPopup.AddChild(new RawButton("", Path.Combine(path, "generic/modals/RawButtons/bt_no.raw"), Path.Combine(path, "generic/modals/RawButtons/bt_no_pr.raw"), popupX + 20, popupY)
            {
                OnRelease = () =>
                {
                    acceptPopup.IsVisible = false;

                    window.Invalidate();
                }
            });

            window.AddPopup(acceptPopup);
            #endregion

            window.AddChild(new RawButton("window_6_1_accept", Path.Combine(path, "RawButtons/bt_accept.raw"), Path.Combine(path, "RawButtons/bt_accept_pr.raw"), btnsX, 5)
            {
                OnRelease = () =>
                {
                    acceptPopup.IsVisible = true;
                    window.Invalidate();
                }
            });


            #region stopPopup
            var stopPopup = new ModalWindow("", path);
            stopPopup.TextLines[1].Text = "       Вы действительно хотите остановить";
            stopPopup.TextLines[1].Size = 16;
            stopPopup.TextLines[2].Text = "                       исследование?";
            stopPopup.TextLines[2].Size = 16;

            stopPopup.AddChild(new RawButton("", Path.Combine(path, "generic/modals/RawButtons/bt_yes.raw"), Path.Combine(path, "generic/modals/RawButtons/bt_yes_pr.raw"), popupX + 280, popupY)
            {
                OnRelease = () =>
                {
                    mMeasureController.OnStopSampleMeasure();

                    stopPopup.IsVisible = false;

                    window.Invalidate();
                }
            });
            stopPopup.AddChild(new RawButton("", Path.Combine(path, "generic/modals/RawButtons/bt_no.raw"), Path.Combine(path, "generic/modals/RawButtons/bt_no_pr.raw"), popupX + 20, popupY)
            {
                OnRelease = () =>
                {
                    stopPopup.IsVisible = false;

                    window.Invalidate();
                }
            });

            window.AddPopup(stopPopup);
            #endregion

            window.AddChild(new RawButton("window_6_1_stop", Path.Combine(path, "RawButtons/bt_stop.raw"), Path.Combine(path, "RawButtons/bt_stop_pr.raw"), btnsX, ToVgY(btnsYBase + btnsYStep))
            {
                OnRelease = () =>
                {
                    stopPopup.IsVisible = true;
                    window.Invalidate();
                }
            });

            window.OnShow = () =>
            {
                acceptPopup.IsVisible = false;
                stopPopup.IsVisible = false;
            };

            return window;
        }

        private static IWidget CreateWindow6_2(string path)
        {
            var window = new Window("window6_2", Path.Combine(path, @"generic/bg.raw"));

            var graphic = new GraphicArea("", 10, 10);
            var graphicSampleData = new GraphicArea.GraphicsData { Color = new Color { R = 1 } };
            graphic.AddGrapics(graphicSampleData);
            window.AddChild(graphic);

            var vStartArea = new TextArea("", null, 12, 34, 100) { Size = 12, Text = "0.15 В" };
            window.AddChild(vStartArea);

            var vEndArea = new TextArea("", null, 12, 198, 100) { Size = 12, Text = "0.35 В" };
            window.AddChild(vEndArea);

            var timeStartArea = new TextArea("", null, 50, 12, 100) { Size = 14, Text = "Х с." };
            window.AddChild(timeStartArea);

            var timeEndArea = new TextArea("", null, 410, 12, 100) { Size = 14, Text = "XXXX c." };
            window.AddChild(timeEndArea);


            mMeasureController.Window62DataAction = (vStart, vEnd, timeStart, timeEnd, initialData, sampleData) =>
            {
                vStartArea.Text = vStart;
                vEndArea.Text = vEnd;
                timeStartArea.Text = timeStart;
                timeEndArea.Text = timeEnd;

                graphicSampleData.Data = sampleData;

                window.Invalidate();
            };

            window.AddChild(new RawButton("", Path.Combine(path, "RawButtons/bt_to_table.raw"), Path.Combine(path, "RawButtons/bt_to_table_pr.raw"), 380, 180)
            {
                OnRelease = () => mMeasureController.CloseSampleGraphic()
            });

            return window;
        }

        private static IWidget CreateWindow6_3(string path)
        {
            var window = new Window("window6_3", Path.Combine(path, @"generic/bg.raw"));

            window.AddChild(new RawButton("window6_3_home", Path.Combine(path, @"generic/home.raw"), Path.Combine(path, @"generic/home.raw"), 383, 247)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window1")
            });

            window.AddChild(new TextArea("window6_1_title", null, 10, 215, 400)
            {
                Color = { B = 1, G = 1, R = 1 },
                Text = "Результат измерения потенциала",
                Size = 16
            });

            const int btnsX = 350;
            const int btnsYBase = 100;
            const int btnsYStep = 70;

            window.AddChild(new RawButton("window_6_3_graphic", Path.Combine(path, "RawButtons/bt_graphic.raw"), Path.Combine(path, "RawButtons/bt_graphic_pr.raw"), btnsX, ToVgY(btnsYBase))
            {
                OnRelease = () => mMeasureController.ShowSampleGraphic()
            });
            window.AddChild(new RawButton("", Path.Combine(path, "RawButtons/bt_onwards.raw"), Path.Combine(path, "RawButtons/bt_onwards_pr.raw"), btnsX, 5)
            {
                OnRelease = () => mMeasureController.OnEndOfMeasureProcess()
            });


            window.AddChild(new ProgressBarImages("bar", path, 10, 10)
            {
                Percent = 100,
                Text = "       Завершено",
                TextColor = { B = 1, R = 1, G = 1 }
            });

            var table = new TextTable("window6_3.table", 15, 115, new[] { 210, 100 }, TextTable.CreateOffset(3, 22), new[] { 4, 4 }, null, 16);
            table.Cells[0, 0].Text = "Значение потенциала";
            table.Cells[0, 1].Text = "Тип активности";
            table.Cells[0, 2].Text = "Стабильность потенциала";
            window.AddChild(table);

            mMeasureController.Window63DataAction = (potential, temperature, activity, stability) =>
            {
                table.Cells[1, 0].Text = potential;
                table.Cells[1, 1].Text = activity;
                table.Cells[1, 2].Text = stability;

                window.Invalidate();
            };


            #region Repeat modal window
            const int popupX = 40;
            const int popupY = 30;

            var repeatPopup = new ModalWindow("", path);
            //                              "xxxxxxxxx xxxxxxxxx xxxxxxxxx xxxxxxxxx xxxxx "
            repeatPopup.TextLines[1].Text = "         Вы действительно хотите";
            repeatPopup.TextLines[1].Size = 20;

            repeatPopup.TextLines[2].Text = "         начать измерение заново?";
            repeatPopup.TextLines[2].Size = 20;

            repeatPopup.AddChild(new RawButton("", Path.Combine(path, "generic/modals/RawButtons/bt_yes.raw"), Path.Combine(path, "generic/modals/RawButtons/bt_yes_pr.raw"), popupX + 280, popupY)
            {
                OnRelease = () =>
                {
                    repeatPopup.IsVisible = false;

                    mMeasureController.Reset();
                    mApplication.SetFocusedWindow("window3");

                    window.Invalidate();
                }
            });
            repeatPopup.AddChild(new RawButton("", Path.Combine(path, "generic/modals/RawButtons/bt_no.raw"), Path.Combine(path, "generic/modals/RawButtons/bt_no_pr.raw"), popupX + 20, popupY)
            {
                OnRelease = () =>
                {
                    repeatPopup.IsVisible = false;

                    window.Invalidate();
                }
            });


            window.AddPopup(repeatPopup);
            #endregion

            window.AddChild(new RawButton("", Path.Combine(path, "RawButtons/bt_repeat_measurement.raw"), Path.Combine(path, "RawButtons/bt_repeat_measurement_pr.raw"), btnsX, ToVgY(btnsYBase + btnsYStep))
            {
                OnRelease = () =>
                {
                    repeatPopup.IsVisible = true;

                    window.Invalidate();
                }
            });


            #region Popup visibility
            {
                // TODO: set all to false
                //repeatPopup.IsVisible = true;
            }
            #endregion

            return window;
        }

        private static IWidget CreateWindow7(string path)
        {
            var window = new Window("window7", Path.Combine(path, @"generic/bg.raw"));

            window.AddChild(new RawButton("window7_home", Path.Combine(path, @"generic/home.raw"), Path.Combine(path, @"generic/home.raw"), 383, 247)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window1")
            });

            window.AddChild(new TextArea("", null, 30, 210, 350) { Text = "Отчёт о проведенном измерении", Size = 16, Color = new Color { R = 1.0f, G = 1.0f, B = 1.0f } });

            var table = new TextTable("window7.table", 15, 70, new[] { 180, 130 }, TextTable.CreateOffset(5, 22), new[] { 2, 4 }, null, 16);

            table.Cells[0, 0].Text = "Проба:";
            table.Cells[0, 1].Text = "Результат АОА:";
            table.Cells[0, 2].Text = "Результат ОА:";
            table.Cells[0, 3].Text = "Исполнитель:";
            table.Cells[0, 4].Text = "Дата:";
            window.AddChild(table);

            window.AddChild(new RawButton("", Path.Combine(path, "RawButtons/bt_next_measurement.raw"), Path.Combine(path, "RawButtons/bt_next_measurement_pr.raw"), 350, 5)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window2")
            });

            window.AddChild(new RawButton("", Path.Combine(path, "RawButtons/bt_repeat_measurement.raw"), Path.Combine(path, "RawButtons/bt_repeat_measurement_pr.raw"), 350, 165)
            {
                OnRelease = () =>
                    {
                        mMeasureController.Reset();
                        mApplication.SetFocusedWindow("window3");
                    }
            });

            const int popupX = 40;
            const int popupY = 30;

            var additionalWindow = new ModalWindow("", path) {HeaderLine = "       Дополнительные сведения:"};
            const int offset = 120;
            for (var i = 2; i < 7; i++)
            {
                additionalWindow.Cells[1, i].X -= offset;
                additionalWindow.Cells[0, i].Width -= offset;
                additionalWindow.Cells[1, i].Width = offset;
            }

            additionalWindow.AddChild(new RawButton("", Path.Combine(path, "generic/modals/RawButtons/bt_ok.raw"), Path.Combine(path, "generic/modals/RawButtons/bt_ok_pr.raw"), popupX + 151, popupY)
                                  {
                                      OnRelease = () =>
                                                      {
                                                          additionalWindow.IsVisible = false;
                                                          window.Invalidate();
                                                      }
                                  });

            window.AddPopup(additionalWindow);

            window.AddChild(new RawButton("", Path.Combine(path, "RawButtons/bt_additional_info.raw"), Path.Combine(path, "RawButtons/bt_additional_info_pr.raw"), 350, 105)
            {
                OnRelease = () =>
                                {
                                    additionalWindow.IsVisible = true;
                                    window.Invalidate();
                                }
            });

            mMeasureController.Window7DataAction = (sample, aoa, oa, executor, date, startTime, endTime, totalTime, stability, Ebase, Esample, Emax, t) =>
                    {

                        table.Cells[1, 0].Text = sample;
                        table.Cells[1, 1].Text = aoa;
                        table.Cells[1, 2].Text = oa;
                        table.Cells[1, 3].Text = executor;
                        table.Cells[1, 4].Text = date;

                        additionalWindow.Cells[0, 2].Text = "Затраченное время:";
                        additionalWindow.Cells[1, 2].Text = totalTime;

                        additionalWindow.Cells[0, 3].Text = "Начальный потенциал:";
                        if(Ebase.HasValue)
                            additionalWindow.Cells[1, 3].Text = Ebase.Value.ToString("F2") + " мВ";
                        else
                            additionalWindow.Cells[1, 3].Text = "-";


                        additionalWindow.Cells[0, 4].Text = "Потенциал пробы:";
                        if (Esample.HasValue)
                            additionalWindow.Cells[1, 4].Text = Esample.Value.ToString("F2") + " мВ";
                        else
                            additionalWindow.Cells[1, 4].Text = "-";


                        additionalWindow.Cells[0, 5].Text = "Макс. потенциал:";
                        if(Emax.HasValue)
                            additionalWindow.Cells[1, 5].Text = Emax.Value.ToString("F2") + " мВ";
                        else
                            additionalWindow.Cells[1, 5].Text = "-";
                    };

            return window;
        }



        #region рабочее
        // Экран с настройками
        private static Window CreateWindow9_1(string path)
        {
            var window = new Window("window9_1", Path.Combine(path, @"generic/bg.raw"));

            window.AddChild(new RawButton("window9_home", Path.Combine(path, @"generic/home.raw"), Path.Combine(path, @"generic/home.raw"), 383, 247)
                                 {
                                     OnRelease = () => mApplication.SetFocusedWindow("window1")
                                 });


            window.AddChild(new RawButton("", Path.Combine(path, @"9/1/bt_datetime.raw"), Path.Combine(path, @"9/1/bt_datetime_pr.raw"), 146, 160)
            {
                  OnRelease = () => mApplication.SetFocusedWindow("window9_3")
            });


            window.AddChild(new RawButton("", Path.Combine(path, @"9/1/bt_checkSW.raw"), Path.Combine(path, @"9/1/bt_checkSW_pr.raw"), 146/*20*/, 5)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window9_4")
            });

            /*
            window.AddChild(new RawButton("", Path.Combine(path, @"RawButtons/bt_editor.raw"), Path.Combine(path, @"RawButtons/bt_editor_pr.raw"), 146, 83)
            {
                OnRelease = () =>
                                {
                                    mKeyboardWindow.ReturnWindow = "window9_1";
                                    mKeyboardWindow.OnEnter = returnText =>
                                    {
                                        if (!string.IsNullOrWhiteSpace(returnText))
                                        {
                                            mKeyboardWindow.ReturnWindow = null;
                                            mApplication.SetFocusedWindow(returnText == "1234" ? "window_loading" : "window1");
                                            mMeasureController.LoadEditor();
                                        }
                                    };

                                    mApplication.SetFocusedWindow("keyboard_window");
                                }
            });
            */

            return window;
        }

        // Executors
        private static Window CreateWindow9_2(string path)
        {
            var window = new Window("window9_2", Path.Combine(path, @"generic/bg.raw"));

            window.AddChild(new RawButton("window9_home", Path.Combine(path, @"generic/home.raw"), Path.Combine(path, @"generic/home.raw"), 383, 247)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window1")
            });


            var list = new ListWidget("list", 10, 75, new[] { 300 }, TextTable.CreateOffset(6, 25));
            window.OnShow = () =>
            {
                var executors = mDeviceControl.SettingsStorage.Load().Executors;

                list.Items = executors.ConvertAll(e => new ListWidget.Item { Column1 = e, Id = e }).ToArray();
            };
            window.AddChild(list);


            window.AddChild(new RawButton("", Path.Combine(path, "9/2/bt_up.raw"), Path.Combine(path, "9/2/bt_up_pr.raw"), 340, 175)
            {
                OnRelease = list.Up
            });


            window.AddChild(new RawButton("", Path.Combine(path, "9/2/bt_choose.raw"), Path.Combine(path, "9/2/bt_choose_pr.raw"), 340, 135)
            {
                OnRelease = () =>
                                {
                                    var settings = mDeviceControl.SettingsStorage.Load();

                                    settings.Executors = list.Items.ToList().ConvertAll(i => i.Column1);

                                    settings.LastUsedExecutor = (string) list.CurrentSelection;

                                    mDeviceControl.SettingsStorage.Save(settings);

                                    var rv = mApplication.GetWindows().First(w => w.Name == "window2") as Window;

                                    if (rv == null) return;
                                    
                                    rv.OnShow();
                                    mApplication.SetFocusedWindow(rv);
                                }
            });
            
            window.AddChild(new RawButton("", Path.Combine(path, "9/2/bt_down.raw"), Path.Combine(path, "9/2/bt_down_pr.raw"), 340, 65)
            {
                OnRelease = list.Down
            });

            window.AddChild(new RawButton("", Path.Combine(path, "9/2/bt_add.raw"), Path.Combine(path, "9/2/bt_add_pr.raw"), 320, 5)//340, 5)
            {
                OnRelease = () =>
                                {
                                    mKeyboardWindow.OnEnter = returnText =>
                                                                  {
                                                                      if (!string.IsNullOrWhiteSpace(returnText))
                                                                      {
                                                                          var newItems =
                                                                              new ListWidget.Item[list.Items.Length + 1];

                                                                          Array.Copy(list.Items, newItems, list.Items.Length);

                                                                          newItems[list.Items.Length] =
                                                                              new ListWidget.Item
                                                                                  {Column1 = returnText, Id = returnText};

                                                                          list.Items = newItems;
                                                                      }
                                                                  };

                                    mKeyboardWindow.ReturnWindow = "window9_2";
                                    
                                    mApplication.SetFocusedWindow("keyboard_window");
                                }
            });

            window.AddChild(new RawButton("", Path.Combine(path, "9/2/bt_delete.raw"), Path.Combine(path, "9/2/bt_delete_pr.raw"), 185, 5)//205, 5)
            {
                OnRelease = () =>
                                {
                                    var newItems = list.Items.ToList();

                                    newItems.RemoveAll(i => i.Id == list.CurrentSelection);

                                    list.Items = newItems.ToArray();
                                }
            });

            window.AddChild(new RawButton("", Path.Combine(path, "9/2/bt_back.raw"), Path.Combine(path, "9/2/bt_back_pr.raw"), 20, 5)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window2")
            });

            return window;
        }

        // DateTime
        private static Window CreateWindow9_3(string path)
        {
            var window = new Window("window9_3", Path.Combine(path, @"generic/bg.raw"));

            window.AddChild(new RawButton("window9_home", Path.Combine(path, @"generic/home.raw"), Path.Combine(path, @"generic/home.raw"), 383, 247)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window1")
            });

            window.AddChild(new TextArea("window9_3_text1", null, 75, 205, 330) { Text = "Настройка времени и даты", Size = 26, Color = new Color { R = 1.0f, G = 1.0f, B = 1.0f } });

            var clockset = new ClockSet("", path, 0, 120);
            window.AddChild(clockset);

            window.AddChild(new RawButton("", Path.Combine(path, "9/3/bt_back.raw"), Path.Combine(path, "9/3/bt_back_pr.raw"), 20, 5)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window9_1")
            });

            window.AddChild(new RawButton("", Path.Combine(path, "RawButtons/bt_accept.raw"), Path.Combine(path, "RawButtons/bt_accept_pr.raw"), 350, 5)
            {
                OnRelease = () =>
                                {
                                    clockset.SetSystemTime();
                                    mApplication.SetFocusedWindow("window9_1");
                                }
            });

            return window;
        }

        // TODO: checkSW
        private static Window CreateWindow9_4(string path)
        {
            var window = new Window("window9_4", Path.Combine(path, @"generic/bg.raw"));

            window.AddChild(new RawButton("window9_home", Path.Combine(path, @"generic/home.raw"), Path.Combine(path, @"generic/home.raw"), 383, 247)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window1")
            });

            window.AddChild(new TextArea("window9_4_text1", null, 55, 150, 370) { Text = "Вы используете сертфицированную версию ПО", Size = 16, Color = new Color { R = 1.0f, G = 1.0f, B = 1.0f } });
            window.AddChild(new TextArea("window9_4_text1", null, 55, 130, 370) { Text = "Хэш-код: 343543-3453453-34512", Size = 16, Color = new Color { R = 1.0f, G = 1.0f, B = 1.0f } });           
            window.AddChild(new ImageLabel("", Path.Combine(path, @"9/4/image_check.raw"), 15, 130));

            window.AddChild(new RawButton("", Path.Combine(path, "9/2/bt_back.raw"), Path.Combine(path, "9/2/bt_back_pr.raw"), 20, 5)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window9_1")
            });

            return window;
        }

        // Executors
        private static Window GetLoadingWindow(string path)
        {
            var window = new Window("window_loading", Path.Combine(path, @"generic/bg.raw"));

            var progressBar = new ProgressBarImages("bar", path, 80, 100)
                                  {
                                      Percent = 0, 
                                      Text = "Идет загрузка редактора методик", 
                                      TextColor = {B = 1, R = 1, G = 1}
                                  };
            window.AddChild(progressBar);

            mMeasureController.SetProgresbarData = (percent, message) =>
                                              {
                                                  progressBar.Percent = (uint)percent;

                                                  progressBar.Text = message;

                                                  window.Invalidate();
                                              };

            return window;
        }

        // работа с архивом. копирование / удаление 
        private static Window CreateWindow10_1(string path)
        {
            var window = new Window("window10_1", Path.Combine(path, @"generic/bg.raw"));

            window.AddChild(new RawButton("window10_1.home", Path.Combine(path, @"generic/home.raw"), Path.Combine(path, @"generic/home.raw"), 383, 247)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window1")
            });

            var list = new ListWidget("list", 10, 70, new []{130, 180}, TextTable.CreateOffset(6, 26));
            window.OnShow = () =>
                                {
                                    var descs = mDeviceControl.GetSavedReportsDescs().OrderByDescending(d => d.Date);

                                    var items = new ListWidget.Item[descs.Count()];

                                    var i = 0;
                                    foreach (var desc in descs)
                                    {
                                        items[i] = new ListWidget.Item { Column1 = desc.SampleName, Column2 = desc.Date.ToString(CultureInfo.GetCultureInfo("ru-RU")), Id = desc.Id };
                                        i++;
                                    }

                                    list.Items = items;
                                };
            window.AddChild(list);

            
            window.AddChild(new RawButton("window10_1.btn_up", Path.Combine(path, @"10/1/bt_up.raw"), Path.Combine(path, @"10/1/bt_up_press.raw"), 333, 175)
            {
                OnRelease = list.Up
            });
            //window10_1.AddChild(new RawButton("window10_1.btn_mark", Path.Combine(path, @"10/1/bt_mark.raw"), Path.Combine(path, @"10/1/bt_mark_press.raw"), 333, ToVgY(145)) { PixelFormat = pixelFormat });
            window.AddChild(new RawButton("window10_1.btn_down", Path.Combine(path, @"10/1/bt_down.raw"), Path.Combine(path, @"10/1/bt_down_press.raw"), 333, 60)
            {
                OnRelease = list.Down
            });

            window.AddChild(new RawButton("window10_1.btn_view", Path.Combine(path, @"10/1/bt_view.raw"),
                                       Path.Combine(path, @"10/1/bt_view_press.raw"), 5, 5)
                                {
                                    OnRelease = () => mMeasureController.ShowReport((Guid) list.CurrentSelection)
                                });

            window.AddChild(new RawButton("window10_1.btn_copy", Path.Combine(path, @"10/1/bt_copy.raw"), Path.Combine(path, @"10/1/bt_copy_press.raw"), 125, 5)
                                {
                                    OnRelease = () => mMeasureController.CopyReport((Guid)list.CurrentSelection)
                                });
            window.AddChild(new RawButton("window10_1.btn_delete", Path.Combine(path, @"10/1/bt_delete.raw"), Path.Combine(path, @"10/1/bt_delete_press.raw"), 245, 5)
                                {
                                    OnRelease = () =>
                                                    {
                                                        var id = list.CurrentSelection;

                                                        if(id != null)
                                                            mDeviceControl.RemoveReports(new [] {(Guid)id});

                                                        window.OnShow();

                                                        window.Invalidate();
                                                    }
                                });
            
            //window10_1.AddChild(new RawButton("window10_1.btn_filter", Path.Combine(path, @"10/1/bt_filter.raw"), Path.Combine(path, @"10/1/bt_filter_press.raw"), 365, 5) { PixelFormat = pixelFormat });


            return window;
        }

        // просмотр архива
        private static IWidget CreateWindow11(string path)
        {
            var window = new Window("window11", Path.Combine(path, @"generic/bg.raw"));

            window.AddChild(new RawButton("window11_home", Path.Combine(path, @"generic/home.raw"), Path.Combine(path, @"generic/home.raw"), 383, 247)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window1")
            });

            window.AddChild(new TextArea("", null, 30, 210, 350) { Text = "Отчёт о проведенном измерении", Size = 16, Color = new Color { R = 1.0f, G = 1.0f, B = 1.0f } });

            var table = new TextTable("window11.table", 15, 70, new[] { 180, 130 }, TextTable.CreateOffset(5, 22), new[] { 2, 4 }, null, 16);

            table.Cells[0, 0].Text = "Проба:";
            table.Cells[0, 1].Text = "Результат АОА:";
            table.Cells[0, 2].Text = "Результат ОА:";
            table.Cells[0, 3].Text = "Исполнитель:";
            table.Cells[0, 4].Text = "Дата:";
            window.AddChild(table);

            window.AddChild(new RawButton("window11_to_choice", Path.Combine(path, @"11/1/bt_toarchive.raw"), Path.Combine(path, @"11/1/bt_toarchive_press.raw"), 16, 5)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window10_1")
            });


            const int popupX = 40;
            const int popupY = 30;

            var additionalPopup = new ModalWindow("", path) { HeaderLine = "       Дополнительные сведения:" };
            const int offset = 120;
            for (var i = 2; i < 7; i++)
            {
                additionalPopup.Cells[1, i].X -= offset;
                additionalPopup.Cells[0, i].Width -= offset;
                additionalPopup.Cells[1, i].Width = offset;
            }

            //additionalWindow.AddChild(new ImageLabel("", Path.Combine(path, "7/modals/modal_generic.raw"), addWindowX, addWindowY));
            additionalPopup.AddChild(new RawButton("", Path.Combine(path, "generic/modals/RawButtons/bt_ok.raw"), Path.Combine(path, "generic/modals/RawButtons/bt_ok_pr.raw"), popupX + 151, popupY)
            {
                OnRelease = () =>
                {
                    additionalPopup.IsVisible = false;
                    window.Invalidate();
                }
            });

            window.AddPopup(additionalPopup);

            window.AddChild(new RawButton("", Path.Combine(path, "RawButtons/bt_additional_info.raw"), Path.Combine(path, "RawButtons/bt_additional_info_pr.raw"), 350, 105)
            {
                OnRelease = () =>
                {
                    additionalPopup.IsVisible = true;
                    window.Invalidate();
                }
            });

            mMeasureController.Window11DataAction = (sample, aoa, oa, executor, date, startTime, endTime, totalTime, stability, Ebase, Esample, Emax, t) =>
            {

                table.Cells[1, 0].Text = sample;
                table.Cells[1, 1].Text = aoa;
                table.Cells[1, 2].Text = oa;
                table.Cells[1, 3].Text = executor;
                table.Cells[1, 4].Text = date;

                additionalPopup.Cells[0, 2].Text = "Затраченное время:";
                additionalPopup.Cells[1, 2].Text = totalTime;

                additionalPopup.Cells[0, 3].Text = "Начальный потенциал:";
                if (Ebase.HasValue)
                    additionalPopup.Cells[1, 3].Text = Ebase.Value.ToString("F2") + " мВ";
                else
                    additionalPopup.Cells[1, 3].Text = "-";


                additionalPopup.Cells[0, 4].Text = "Потенциал пробы:";
                if (Esample.HasValue)
                    additionalPopup.Cells[1, 4].Text = Esample.Value.ToString("F2") + " мВ";
                else
                    additionalPopup.Cells[1, 4].Text = "-";


                additionalPopup.Cells[0, 5].Text = "Макс. потенциал:";
                if (Emax.HasValue)
                    additionalPopup.Cells[1, 5].Text = Emax.Value.ToString("F2") + " мВ";
                else
                    additionalPopup.Cells[1, 5].Text = "-";

            };

            return window;
        }
        #endregion
    }
}

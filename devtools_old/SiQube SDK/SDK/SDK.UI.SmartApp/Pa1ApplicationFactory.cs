using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Linq;
using MeasureProcessing.ProcessingDaemon;
using ProcessingDaemon;
using UILib.Fonts;
using UILib.Widgets;

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

        public static int DefaultLanguage { get; set; }

        private static string[] UIText(string rus, string eng)
        {
            return new[] { DefaultLanguage == Language.Rus ? rus : eng };
        }

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
            if (string.IsNullOrEmpty(location))
                location = "";

            var path = Path.Combine(location, "images");

            DefaultLanguage = Language.Rus;

            mApplication = Application.GetInstance();

            mDeviceControl = new PA1Control();

            mMeasureController = new MeasureProcessController(mDeviceControl)
                                     {
                                         SwitchWindowAction = windowName =>
                                                                  {
                                                                      var rv = mApplication.GetWindows().First(w => w.Name == windowName) as Window;

                                                                      if (rv != null)
                                                                          if (rv.OnShow != null)
                                                                              rv.OnShow();

                                                                      mApplication.SetFocusedWindow(rv);
                                                                  }
                                     };

            /* Номера окон:
             * 1 - Главное меню;
             * 2 - ввод данных;
             * 3 - диалоговое окно 1;
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
             * 9 - настройки;
             * 10.1 - выбор архива; 10.2 - фильтр выбора архива;
             * 11.1 - содержимое архива;
             * 11.2 - график архива.
             * */

            mApplication.AddFont("MyriadPro", new MyriadProFont());

            mKeyboardWindow = new KeyboardWindow("keyboard_window");
            mApplication.AddWindow(mKeyboardWindow);

            mApplication.AddWindow(CreateWindow1());
            mApplication.AddWindow(CreateWindow2(path));
            mApplication.AddWindow(CreateWindow3());
            mApplication.AddWindow(CreateWindow4_1(path));
            mApplication.AddWindow(CreateWindow4_2());
            mApplication.AddWindow(CreateWindow4_3(path));
            mApplication.AddWindow(CreateWindow4_4());

            mApplication.AddWindow(CreateWindow5_1(path));
            mApplication.AddWindow(CreateWindow5_2());

            mApplication.AddWindow(CreateWindow6_1(path));
            mApplication.AddWindow(CreateWindow6_2());
            mApplication.AddWindow(CreateWindow6_3(path));
            mApplication.AddWindow(CreateWindow6_4());

            mApplication.AddWindow(CreateWindow7(path));

            mApplication.AddWindow(CreateWindow8_1());
            mApplication.AddWindow(CreateWindow8_2());
            mApplication.AddWindow(CreateWindow8_4());

            mApplication.AddWindow(CreateWindow9_1(path));
            mApplication.AddWindow(CreateWindow9_2(path));
            mApplication.AddWindow(CreateWindow9_3(path));
            mApplication.AddWindow(CreateWindow9_4(path));
            mApplication.AddWindow(CreateWindow9_5(path));
            mApplication.AddWindow(GetLoadingWindow(path));

            mApplication.AddWindow(CreateWindow10_1(path));
            mApplication.AddWindow(CreateWindow11(path));

            //mApplication.SetFocusedWindow("keyboard_window");
            mApplication.SetFocusedWindow("window1");

            return mApplication;
        }

        // vector rus & eng
        private static Window CreateWindow1()
        {
            var window = new Window("window1");

            var lavadoBtn = Utils.ClassicButton(25, ToVgY(125), UIText("Отмывка", "Washing"), null);
            lavadoBtn.OnRelease = () => mMeasureController.OpenLavadoWindow("window8_4");
            window.AddChild(lavadoBtn);

            /*
            var settingsBtn = Utils.ClassicButton(25, ToVgY(220), UIText("Настройка", "Settings"), null);
            settingsBtn.OnRelease = () => mApplication.SetFocusedWindow("window9_1");
            window.AddChild(settingsBtn);
            */

            window.AddChild(new TextArea("", "MyriadPro", 10, 10, 200) { Align = AlignType.Left, Text = "\u00a8 C\u00b0 \u00b1 Hello\u00b2ToMe \u00b4", Size = 10, Color = new Color(0xFFFFFFFF) });
            window.AddChild(new TextArea("", null, 10, 40, 200) { Align = AlignType.Left, Text = "\u00a8 C\u00b0 \u00b1 Hello\u00b2ToMe \u00b4", Size = 7, Color = new Color(0xFFFFFFFF) });


            var analysBtn = Utils.LargeButton(215, ToVgY(138), UIText("Анализ", "Analysis"), Utils.ColorPalette.Green);
            analysBtn.OnRelease = () =>
                                      {
                                          var rv = mApplication.GetWindows().First(w => w.Name == "window2") as Window;

                                          if (rv == null) return;

                                          rv.OnShow();
                                          mApplication.SetFocusedWindow(rv);
                                      };
            window.AddChild(analysBtn);

            var archiveBtn = Utils.LargeButton(215, ToVgY(250), UIText("Архив", "Archive"), null);
            archiveBtn.OnRelease = () =>
            {
                var rv = mApplication.GetWindows().First(w => w.Name == "window10_1") as Window;
                if (rv == null) return;

                rv.OnShow();
                mApplication.SetFocusedWindow(rv);
            };
            window.AddChild(archiveBtn);




            return window;
        }

        // vector rus & eng
        // TODO: переделать лист выбора методики
        private static Window CreateWindow2(string path)
        {
            const int kFontSize = 16;

            var window = new Window("window2");

            window.AddChild(new RawButton("window2_home", Path.Combine(path, @"generic/home.raw"), Path.Combine(path, @"generic/home.raw"), 383, 247)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window1")
            });


            var sampleTextRender = new TextArea("window2_bt_sample_text_render", null, 25, ToVgY(70), 427)
            {
                Text = UIText("Проба", "Sample")[0],
                Color = new Color(0x0000007f),
                Align = AlignType.Center,

                Size = kFontSize,
                Background = true
            };

            var executorTextRender = new TextArea("window2_bt_executor_text_render", null, 25, ToVgY(110), 427)
            {
                Text = UIText("Исполнитель", "Performer")[0],
                Color = new Color(0x0000007f),
                Align = AlignType.Center,

                Size = kFontSize,
                Background = true
            };

            var methodologyTextRender = new TextArea("window2_bt_methodology_text_render", null, 25, ToVgY(150), 427)
            {
                Text = UIText("Методика", "Methodics")[0],
                Color = new Color(0x0000007f),
                Align = AlignType.Center,

                Size = kFontSize,
                Background = true
            };

            window.OnShow = () =>
                                 {
                                     var settings = mDeviceControl.SettingsStorage.Load();
                                     executorTextRender.Text = settings.LastUsedExecutor;
                                     methodologyTextRender.Text = settings.LastUsedMethodology;

                                     if (methodologyTextRender.Text == "" || methodologyTextRender.Text == "Методика" || methodologyTextRender.Text == "Methodics" | methodologyTextRender.Text == null)
                                     {
                                         methodologyTextRender.Text = UIText("Методика", "Methodics")[0];
                                         methodologyTextRender.Color = new Color(0x0000007f);
                                         methodologyTextRender.Align = AlignType.Center;
                                     }
                                     else
                                     {
                                         methodologyTextRender.Color = new Color(0x000000ff);
                                         methodologyTextRender.Align = AlignType.Left;
                                     }
                                 };


            window.AddChild(sampleTextRender);
            window.AddChild(executorTextRender);
            window.AddChild(methodologyTextRender);


            var btnNext = Utils.ClassicButton(345, 10, UIText("Далее", "Next"), Utils.ColorPalette.Green);
            btnNext.OnRelease = () =>
                                       {
                                           if (methodologyTextRender.Text == "" | methodologyTextRender.Text == "Методика" | methodologyTextRender.Text == "Methodics" | methodologyTextRender.Text == null)
                                               return;

                                           mDeviceControl.SetMeasureData(sampleTextRender.Text, executorTextRender.Text, methodologyTextRender.Text);
                                           mMeasureController.Reset();
                                           mMeasureController.OpenWindow3();
                                       };
            window.AddChild(btnNext);

            #region sample
            sampleTextRender.OnUpdate = () =>
                                            {
                                                if (sampleTextRender.Text == "" || sampleTextRender.Text == "Проба" ||
                                                    sampleTextRender.Text == "Sample")
                                                {
                                                    sampleTextRender.Text = UIText("Проба", "Sample")[0];
                                                    sampleTextRender.Color = new Color(0x0000007f);
                                                    sampleTextRender.Align = AlignType.Center;
                                                }
                                                else
                                                {
                                                    sampleTextRender.Color = new Color(0x000000ff);
                                                    sampleTextRender.Align = AlignType.Left;
                                                }
                                            };

            sampleTextRender.OnPress = () =>
                                           {
                                               mKeyboardWindow.OnEnter = returnText =>
                                                                             {
                                                                                 if (!string.IsNullOrWhiteSpace(returnText))
                                                                                 {
                                                                                     sampleTextRender.Text = returnText;
                                                                                 }
                                                                             };

                                               mKeyboardWindow.ReturnWindow = "window2";
                                               mKeyboardWindow.Text = ""; // window2_bt_sample_text_render.Text;

                                               mApplication.SetFocusedWindow("keyboard_window");
                                           };
            #endregion

            #region executor
            executorTextRender.OnUpdate = () =>
                                            {
                                                if (executorTextRender.Text == "" || executorTextRender.Text == "Исполнитель" || executorTextRender.Text == "Performer")
                                                {
                                                    executorTextRender.Text = UIText("Исполнитель", "Performer")[0];
                                                    executorTextRender.Color = new Color(0x0000007f);
                                                    executorTextRender.Align = AlignType.Center;
                                                }
                                                else
                                                {
                                                    executorTextRender.Color = new Color(0x000000ff);
                                                    executorTextRender.Align = AlignType.Left;
                                                }
                                            };


            executorTextRender.OnPress = () =>
            {
                var rv = mApplication.GetWindows().First(w => w.Name == "window9_2") as Window;
                if (rv == null) return;

                if (rv.OnShow != null)
                    rv.OnShow();

                mApplication.SetFocusedWindow(rv);
            };
            #endregion

            #region methodology
            methodologyTextRender.OnUpdate = () =>
            {
                if (methodologyTextRender.Text == "" || methodologyTextRender.Text == "Методика" || methodologyTextRender.Text == "Methodics" | methodologyTextRender.Text == null)
                {
                    methodologyTextRender.Text = UIText("Методика", "Methodics")[0];
                    methodologyTextRender.Color = new Color(0x0000007f);
                    methodologyTextRender.Align = AlignType.Center;
                }
                else
                {
                    methodologyTextRender.Color = new Color(0x000000ff);
                    methodologyTextRender.Align = AlignType.Left;
                }
            };


            methodologyTextRender.OnPress = () =>
            {
                var rv = mApplication.GetWindows().First(w => w.Name == "window9_5") as Window;
                if (rv == null) return;

                if (rv.OnShow != null)
                    rv.OnShow();

                mApplication.SetFocusedWindow(rv);
            };
            #endregion

            return window;
        }

        // vector rus & eng
        private static IWidget CreateWindow3()
        {
            var window = new Window("window3");

            /*window.AddChild(new RawButton("window3.home", Path.Combine(path, @"generic/home.raw"), Path.Combine(path, @"generic/home.raw"), 383, 247)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window1")
            });*/

            window.AddChild(new TextArea("", null, 15, 225, 450) { Text = UIText("Вылейте воду из ячейки.", "Pour water out of the cell.")[0], Size = 16, Color = new Color { R = 1.0f, B = 1.0f, G = 1.0f } });
            window.AddChild(new TextArea("", null, 15, 205, 450) { Text = UIText("Внесите в ячейку анализатора растворы в объеме, указан-", "Introduce volume of the solution as identified in the Table")[0], Size = 16, Color = new Color { R = 1.0f, B = 1.0f, G = 1.0f } });
            window.AddChild(new TextArea("", null, 15, 185, 450) { Text = UIText("ном в таблице, после чего опустите электроды в раствор.", "into the cell, then pour the electrodes into solution ")[0], Size = 16, Color = new Color { R = 1.0f, B = 1.0f, G = 1.0f } });

            var table = new TextTable("window3.table", 50, 75, new[] { 150, 150, 80 }, TextTable.CreateOffset(4, 23), new[] { 4, 4 }, null, 16);
            for (var i = 0; i < 3; i++)
            {
                table.Cells[i, 0].Y += 2;
                table.Cells[i, 0].Size = 18;
            }
            table.Cells[0, 0].Text = UIText("Раствор", "Solution")[0];
            table.Cells[0, 0].Align = AlignType.Center;

            table.Cells[1, 0].Text = UIText("Концентрация", "Concentration")[0];
            table.Cells[1, 0].Align = AlignType.Center;

            table.Cells[2, 0].Text = UIText("Объем", "Volume")[0];
            table.Cells[2, 0].Align = AlignType.Center;

            window.AddChild(table);

            var btnBack = Utils.ClassicButton(10, 10, UIText("Назад", "Back"), Utils.ColorPalette.Red);
            btnBack.OnRelease = () => mApplication.SetFocusedWindow("window2");

            var btnNext = Utils.ClassicButton(345, 10, UIText("Далее", "Next"), Utils.ColorPalette.Green);
            btnNext.OnRelease = () => mMeasureController.StartInitialMeasure();

            window.AddChild(btnNext);
            window.AddChild(btnBack);


            mMeasureController.Window3DataAction = (aBuffer, aBufferC, aBufferV, aRed, aRedC, aRedV, aOx, aOxC, aOxV) =>
                                                       {
                                                           table.Cells[0, 1].Text = aBuffer;
                                                           table.Cells[0, 2].Text = aRed;
                                                           table.Cells[0, 3].Text = aOx;

                                                           table.Cells[1, 1].Text = aBufferC;
                                                           table.Cells[1, 2].Text = aRedC + UIText("моль/л", "mol/l")[0];
                                                           table.Cells[1, 3].Text = aOxC + UIText("моль/л", "mol/l")[0];

                                                           table.Cells[2, 1].Text = aBufferV + UIText("мл", "ml")[0];
                                                           table.Cells[2, 2].Text = aRedV + UIText("мл", "ml")[0];
                                                           table.Cells[2, 3].Text = aOxV + UIText("мл", "ml")[0];
                                                       };

            return window;
        }

        // vector rus & eng
        private static IWidget CreateWindow4_2()
        {
            var window = new Window("window4_2");

            var graphic = new GraphicArea("", 10, 10);
            var graphicData = new GraphicArea.GraphicsData { Color = new Color { B = 1f } };
            graphic.AddGrapics(graphicData);
            window.AddChild(graphic);

            var vStartArea = new TextArea("", null, 12, 34, 100) { Size = 12, Text = "0.15 В" };
            window.AddChild(vStartArea);

            var vEndArea = new TextArea("", null, 12, 198, 100) { Size = 12, Text = "0.35 В" };
            window.AddChild(vEndArea);

            var timeStartArea = new TextArea("", null, 50, 12, 100) { Size = 14, Text = "Х с." };
            window.AddChild(timeStartArea);

            var timeEndArea = new TextArea("", null, 410, 12, 100) { Size = 14, Text = "XXXX c." };
            window.AddChild(timeEndArea);

            mMeasureController.Window42DataAction = (vStart, vEnd, timeStart, timeEnd, data) =>
                                                        {
                                                            vStartArea.Text = vStart + UIText("В", "V")[0];
                                                            vEndArea.Text = vEnd + UIText("В", "V")[0];
                                                            timeStartArea.Text = timeStart + UIText("с", "s")[0];
                                                            timeEndArea.Text = timeEnd + UIText("с", "s")[0];

                                                            graphicData.Data = data;

                                                            graphic.Invalidate();
                                                        };

            var btn = new Button("classicButton", 380, 180, 80, 30, 10)
                          {
                              OnRelease = () => mMeasureController.CloseInitialGraphic(),
                              PressColor = Utils.ColorPalette.Green,
                          };

            btn.AddChild(new TextArea("", null, btn.X, (btn.Height - 16) / 2 + 3 + btn.Y, btn.Width) { Text = UIText("Таблица", "Table")[0], Size = 16, Align = AlignType.Center });
            window.AddChild(btn);

            return window;
        }

        // vector rus & eng
        private static IWidget CreateWindow4_4()
        {
            var window = new Window("window4_4");

            var btnRepeat = Utils.ClassicButton(177, 10, DefaultLanguage == Language.Rus ? new[] { "Повторить", "измерение" } : new[] { "Repeat", "the test" }, null);
            btnRepeat.OnRelease = () => mMeasureController.OpenWindow3();
            window.AddChild(btnRepeat);

            var btnNext = Utils.ClassicButton(345, 10, UIText("Далее", "Next"), Utils.ColorPalette.Green);
            btnNext.OnRelease = () => mApplication.SetFocusedWindow("window4_3");
            window.AddChild(btnNext);


            var table = new TextTable("", 16, 100, new[] { 445 }, TextTable.CreateOffset(4, 23), new[] { 4, 4 }, null, 16) { CellBorder = false };
            window.AddChild(table);

            table.Cells[0, 0].Align = AlignType.Center;
            table.Cells[0, 1].Align = AlignType.Center;
            table.Cells[0, 2].Align = AlignType.Center;
            table.Cells[0, 3].Align = AlignType.Center;

            mMeasureController.Window44DataAction = (stability, EStandard) =>
                                                        {
                                                            if (!stability && !EStandard)
                                                            {
                                                                table.Cells[0, 0].Text = UIText("Потенциал системы не стабилен и имеет слишком высокое", "Potential of the system is unstable, and (or) its value is ")[0];
                                                                table.Cells[0, 1].Text = UIText("(низкое) значение. Проверьте правильность подключения", "too low (high). Check correctness of electrode connection,")[0];
                                                                table.Cells[0, 2].Text = UIText("электродов, подготовки растворов, перезаполните", "and solution preparation, refill reference electrode.")[0];
                                                                table.Cells[0, 3].Text = UIText("электрод сравнения.", "")[0];
                                                            }
                                                            else
                                                                if (!EStandard)
                                                                {
                                                                    table.Cells[0, 0].Text = UIText("Потенциал системы не стабилен и имеет слишком высокое", "Potential of the system is ")[0];
                                                                    table.Cells[0, 1].Text = UIText("(низкое) значение. Проверьте правильность подключения", "too low (high). Check correctness of electrode connection,")[0];
                                                                    table.Cells[0, 2].Text = UIText("электродов, подготовки растворов, перезаполните", "and solution preparation, refill reference electrode.")[0];
                                                                    table.Cells[0, 3].Text = UIText("электрод сравнения.", "")[0];
                                                                }
                                                                else
                                                                    if (!stability)
                                                                    {
                                                                        table.Cells[0, 0].Text = UIText("Потенциал не стабилен", "Potential of the system is unstable")[0];
                                                                        table.Cells[0, 1].Text = "";
                                                                        table.Cells[0, 2].Text = "";
                                                                        table.Cells[0, 3].Text = "";
                                                                    }

                                                            window.Invalidate();
                                                        };


            return window;
        }

        // vector rus & eng
        private static IWidget CreateWindow6_4()
        {
            var window = new Window("window6_4");

            var table = new TextTable("", 25, 100, new[] { 420 }, TextTable.CreateOffset(4, 23), new[] { 4, 4 }, null, 16) { CellBorder = false };
            table.Cells[0, 0].Text = "";
            table.Cells[0, 1].Text = UIText("Потенциал системы изменился незначительно.", "System potential shift is insignificant.")[0];
            table.Cells[0, 2].Text = UIText("Рекомендуется внести дополнительный объём пробы.", "It is recommended to introduce additional sample volume.")[0];
            table.Cells[0, 3].Text = "";

            table.Cells[0, 0].Align = AlignType.Center;
            table.Cells[0, 1].Align = AlignType.Center;
            table.Cells[0, 2].Align = AlignType.Center;
            table.Cells[0, 3].Align = AlignType.Center;

            window.AddChild(table);

            var btnAddSample = Utils.ClassicButton(345, 10, DefaultLanguage == Language.Rus ? new[] { "Внести", "дополнительный", "объем аликвоты" } : new[] { "Introduce", "additional", "aliquot volume" }, Utils.ColorPalette.Green);
            btnAddSample.OnRelease = () => mMeasureController.AddAliqout();
            window.AddChild(btnAddSample);

            var btnSkip = Utils.ClassicButton(177, 10, UIText("Пропустить", "Skip"), null);
            btnSkip.OnRelease = () => mApplication.SetFocusedWindow("window6_3");
            window.AddChild(btnSkip);

            return window;
        }

        // vector rus & eng
        private static IWidget CreateWindow6_3(string path)
        {
            var window = new Window("window6_3");

            window.AddChild(new RawButton("window6_3_home", Path.Combine(path, @"generic/home.raw"), Path.Combine(path, @"generic/home.raw"), 383, 247)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window1")
            });

            window.AddChild(new TextArea("window6_3_title", null, 10, 220, 460)
            {
                Color = { B = 1, G = 1, R = 1 },
                Text = UIText("Измерение потенциала системы с пробой", "Potential measurement of the system with the sample")[0],
                Size = 16,
                Align = AlignType.Center
            });

            var btnGraphic = Utils.ClassicButton(345, 160, UIText("График", "Graph"), null);
            btnGraphic.OnRelease = () => mMeasureController.ShowSampleGraphic();
            window.AddChild(btnGraphic);

            var btnNext = Utils.ClassicButton(345, 10, UIText("Далее", "Next"), Utils.ColorPalette.Green);
            btnNext.OnRelease = () => mMeasureController.OnEndOfMeasureProcess();
            window.AddChild(btnNext);

            window.AddChild(new ProgressBarImages("bar", path, 10, 10)
                                   {
                                       Percent = 100,
                                       Text = UIText("Завершено", "Completed")[0],
                                       TextColor = { B = 1, R = 1, G = 1 }
                                   });

            var table = new TextTable("window6_3.table", 15, 115, new[] { 210, 100 }, TextTable.CreateOffset(4, 22), new[] { 4, 4 }, null, 16);
            table.Cells[0, 0].Text = UIText("Значение потенциала", "Potential value")[0];
            table.Cells[0, 1].Text = UIText("Температура", "Temperature")[0];
            table.Cells[0, 2].Text = UIText("Тип активности", "Type of activity")[0];
            table.Cells[0, 3].Text = UIText("Стабильность потенциала", "Potential stability")[0];
            window.AddChild(table);

            mMeasureController.Window63DataAction = (potential, temperature, activity, stability) =>
            {
                table.Cells[1, 0].Text = potential + UIText(" мВ", " mV")[0];
                table.Cells[1, 1].Text = temperature + " C";
                table.Cells[1, 2].Text = activity;
                table.Cells[1, 3].Text = stability ? UIText("Да", "Yes")[0] : UIText("Нет", "No")[0];

                window.Invalidate();
            };


            #region Repeat modal window
            // TODO: переделать класс ModalWindow на использование без картинки в основании
            var repeatPopup = new ModalWindow("", path) { HeaderLine = UIText("Внимание!", "Attention!")[0] };

            repeatPopup.TextLines[1].Text = UIText("Вы действительно хотите", "Do you want")[0];
            repeatPopup.TextLines[1].Size = 20;

            repeatPopup.TextLines[2].Text = UIText("начать измерение заново?", "to restart the measurement?")[0];
            repeatPopup.TextLines[2].Size = 20;

            var btnYes = Utils.ModalButton(325, 35, UIText("Да", "Yes"), Utils.ColorPalette.Green);
            btnYes.OnRelease = () =>
            {
                mMeasureController.Open5_1();
                repeatPopup.IsVisible = false;
                window.Invalidate();
            };
            repeatPopup.AddChild(btnYes);

            var btnNo = Utils.ModalButton(56, 35, UIText("Нет", "No"), Utils.ColorPalette.Red);
            btnNo.OnRelease = () =>
            {
                repeatPopup.IsVisible = false;
                window.Invalidate();
            };
            repeatPopup.AddChild(btnNo);

            window.AddPopup(repeatPopup);
            #endregion

            var btnRepeat = Utils.ClassicButton(345, 105, DefaultLanguage == Language.Rus ? new[] { "Повторное", "измерение" } : new[] { "Repeat", "measurement" }, null);
            btnRepeat.OnRelease = () =>
                                    {
                                        repeatPopup.IsVisible = true;
                                        window.Invalidate();
                                    };
            window.AddChild(btnRepeat);

            return window;
        }

        // vector rus & eng
        private static IWidget CreateWindow6_2()
        {
            var window = new Window("window6_2");

            var graphic = new GraphicArea("", 10, 10);
            var graphicInitialData = new GraphicArea.GraphicsData { Color = new Color { B = 1 } };
            var graphicSampleData = new GraphicArea.GraphicsData { Color = new Color { R = 1 } };
            graphic.AddGrapics(graphicInitialData);
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
                vStartArea.Text = vStart + UIText("В", "V")[0];
                vEndArea.Text = vEnd + UIText("В", "V")[0];
                timeStartArea.Text = timeStart + UIText("с", "s")[0];
                timeEndArea.Text = timeEnd + UIText("с", "s")[0];

                graphicInitialData.Data = initialData;
                graphicSampleData.Data = sampleData;

                graphic.Invalidate();
            };

            var btn = new Button("classicButton", 380, 180, 80, 30, 10)
            {
                OnRelease = () => mMeasureController.CloseSampleGraphic(),
                PressColor = Utils.ColorPalette.Green,
            };

            btn.AddChild(new TextArea("", null, btn.X, (btn.Height - 16) / 2 + 3 + btn.Y, btn.Width) { Text = UIText("Таблица", "Table")[0], Size = 16, Align = AlignType.Center });
            window.AddChild(btn);

            return window;
        }

        // vector rus & eng
        private static IWidget CreateWindow6_1(string path)
        {
            var window = new Window("window6_1");// {Description = {Text = "Измерение потенциала системы с пробой"}};

            window.AddChild(new TextArea("window6_1_title", null, 10, 220, 460)
            {
                Color = { B = 1, G = 1, R = 1 },
                Text = UIText("Измерение потенциала системы с пробой", "Potential measurement of the system with the sample")[0],
                Size = 16,
                Align = AlignType.Center
            });

            var progressArea = new ProgressBarImages("bar", path, 10, 10) { Percent = 100, Text = UIText("Подготовка", "Preparation")[0], TextColor = { B = 1, R = 1, G = 1 } };
            window.AddChild(progressArea);

            var table = new TextTable("window6_1.table", 15, 60, new[] { 210, 100 }, TextTable.CreateOffset(6, 22), new[] { 4, 4 }, null, 16);

            table.Cells[0, 0].Text = UIText("Потенциал", "Potential")[0];
            table.Cells[0, 1].Text = UIText("Температура", "Temperature")[0];
            table.Cells[0, 2].Text = UIText("Тип активности", "Type of activity")[0];
            table.Cells[0, 3].Text = UIText("Стабильность потенциала", "Potential stability")[0];
            table.Cells[0, 4].Text = UIText("Времени затрачено", "Time spent")[0];
            table.Cells[0, 5].Text = UIText("Времени осталось", "Time left")[0];

            window.AddChild(table);

            mMeasureController.Window61DataAction = (percent, potential, temperature, activity, stability, time, left) =>
                                                        {
                                                            progressArea.Percent = (uint)percent;
                                                            progressArea.Text = UIText("Измерение", "Measurement ")[0];

                                                            table.Cells[1, 0].Text = potential + UIText(" мВ", " mV")[0];
                                                            table.Cells[1, 1].Text = temperature + " C";
                                                            table.Cells[1, 2].Text = activity;
                                                            table.Cells[1, 3].Text = stability ? UIText("Да", "Yes")[0] : UIText("Нет", "No")[0];
                                                            table.Cells[1, 4].Text = time;
                                                            table.Cells[1, 5].Text = left;

                                                            window.Invalidate();
                                                        };


            #region oaPopup
            var oaPopup = new ModalWindow("", path) { HeaderLine = UIText("Внимание!", "Attention!")[0] };
            {
                oaPopup.TextLines[1].Text =
                    UIText("Анализируемая проба содержит оксиданты,", "The analyzed sample contains oxidants,")[0];
                oaPopup.TextLines[1].Size = 16;

                oaPopup.TextLines[2].Text = UIText("необходимо изменить состав", "modify the mediator system")[0];
                oaPopup.TextLines[2].Size = 16;

                oaPopup.TextLines[3].Text = UIText("медиаторной системы", "")[0];
                oaPopup.TextLines[3].Size = 16;

                var btnYes = Utils.ModalButton(193, 35, UIText("Ok", "Ok"), Utils.ColorPalette.Green);
                btnYes.OnRelease = () =>
                                       {
                                           var isNeedLavado = mDeviceControl.GetLavadoConfiguration().LavadoAfterMeasure;
                                           oaPopup.IsVisible = false;
                                           mMeasureController.OpenWindow3(isNeedLavado);
                                           window.Invalidate();
                                       };
                oaPopup.AddChild(btnYes);
            }
            window.AddPopup(oaPopup);
            #endregion

            mMeasureController.ShowOaPopup = () =>
                                                 {
                                                     oaPopup.IsVisible = true;
                                                     window.Invalidate();
                                                 };

            #region acceptPopup

            var acceptPopup = new ModalWindow("", path) { HeaderLine = UIText("Внимание!", "Attention!")[0] };
            {
                acceptPopup.TextLines[1].Text = UIText("Принять текущее значение потенциала?", "Accept the current potential value?")[0];
                acceptPopup.TextLines[1].Size = 16;

                var btnYes = Utils.ModalButton(325, 35, UIText("Да", "Yes"), Utils.ColorPalette.Green);
                btnYes.OnRelease = () =>
                                            {
                                                mMeasureController.StopSampleMeasure();
                                                acceptPopup.IsVisible = false;
                                                window.Invalidate();
                                            };
                acceptPopup.AddChild(btnYes);

                var btnNo = Utils.ModalButton(56, 35, UIText("Нет", "No"), Utils.ColorPalette.Red);
                btnNo.OnRelease = () =>
                                      {
                                          acceptPopup.IsVisible = false;
                                          window.Invalidate();
                                      };
                acceptPopup.AddChild(btnNo);

            }
            window.AddPopup(acceptPopup);


            #endregion

            #region stopPopup
            var stopPopup = new ModalWindow("", path) { HeaderLine = UIText("Внимание!", "Attention!")[0] };
            {
                stopPopup.TextLines[1].Text = UIText("Вы действительно хотите остановить", "Do you really want to stop the")[0];
                stopPopup.TextLines[1].Size = 16;
                stopPopup.TextLines[2].Text = UIText("исследование?", "measurement?")[0];
                stopPopup.TextLines[2].Size = 16;

                var btnYes = Utils.ModalButton(325, 35, UIText("Да", "Yes"), Utils.ColorPalette.Green);
                btnYes.OnRelease = () =>
                                            {
                                                mMeasureController.OnStopSampleMeasure();
                                                stopPopup.IsVisible = false;
                                                window.Invalidate();
                                            };
                stopPopup.AddChild(btnYes);

                var btnNo = Utils.ModalButton(56, 35, UIText("Нет", "No"), Utils.ColorPalette.Red);
                btnNo.OnRelease = () =>
                                      {
                                          stopPopup.IsVisible = false;
                                          window.Invalidate();
                                      };
                stopPopup.AddChild(btnNo);

            }
            window.AddPopup(stopPopup);
            #endregion

            #region buttons
            var btnGraphic = Utils.ClassicButton(345, 160, UIText("График", "Graph"), null);
            btnGraphic.OnRelease = () => mMeasureController.ShowSampleGraphic();
            window.AddChild(btnGraphic);

            var btnAccept = Utils.ClassicButton(345, 10, UIText("Принять", "Accept"), Utils.ColorPalette.Green);
            btnAccept.OnRelease = () =>
            {
                acceptPopup.IsVisible = true;
                window.Invalidate();
            };
            window.AddChild(btnAccept);

            var btnStop = Utils.ClassicButton(345, 105, UIText("Стоп", "Stop"), Utils.ColorPalette.Red);
            btnStop.OnRelease = () =>
                {
                    stopPopup.IsVisible = true;
                    window.Invalidate();
                };
            window.AddChild(btnStop);
            #endregion

            window.OnShow = () =>
            {
                oaPopup.IsVisible = false;
                acceptPopup.IsVisible = false;
                stopPopup.IsVisible = false;
            };

            return window;
        }

        // vector rus & eng
        private static IWidget CreateWindow4_3(string path)
        {
            var window = new Window("window4_3");

            window.AddChild(new RawButton("window4_3_home", Path.Combine(path, @"generic/home.raw"), Path.Combine(path, @"generic/home.raw"), 383, 247)
            {
                OnRelease = () =>
                    {
                        mDeviceControl.StopMeasureProcess();
                        mApplication.SetFocusedWindow("window1");
                    }
            });

            window.AddChild(new TextArea("window4_3_title", null, 10, 220, 460)
            {
                Color = { B = 1, G = 1, R = 1 },
                Text = UIText("Измерение начального потенциала системы", "Measurement of the system initial potential")[0],
                Size = 16,
                Align = AlignType.Center
            });

            var btnGraphic = Utils.ClassicButton(345, 160, UIText("График", "Graph"), null);
            btnGraphic.OnRelease = () => mMeasureController.ShowInitialGraphic();
            window.AddChild(btnGraphic);

            var btnNext = Utils.ClassicButton(345, 10, UIText("Далее", "Next"), Utils.ColorPalette.Green);
            btnNext.OnRelease = () => mMeasureController.Open5_1();
            window.AddChild(btnNext);

            var progressArea = new ProgressBarImages("bar", path, 10, 10)
                                   {
                                       Percent = 100,
                                       Text = UIText("Завершено", "Completed")[0],
                                       TextColor = { B = 1, R = 1, G = 1 }
                                   };
            window.AddChild(progressArea);


            var table = new TextTable("window4_3.table", 15, 115, new[] { 210, 100 }, TextTable.CreateOffset(4, 22), new[] { 4, 4 }, null, 16);
            table.Cells[0, 0].Text = UIText("Значение потенциала", "Potential value")[0];
            table.Cells[0, 1].Text = UIText("Температура", "Temperature")[0];
            table.Cells[0, 2].Text = UIText("Тип активности", "Type of activity")[0];
            table.Cells[0, 3].Text = UIText("Стабильность потенциала", "Potential stability")[0];
            window.AddChild(table);

            mMeasureController.Window43DataAction = (potential, temperature, standard, stability) =>
            {
                table.Cells[1, 0].Text = potential + UIText(" мВ", " mV")[0];
                table.Cells[1, 1].Text = temperature + " C";
                table.Cells[1, 2].Text = standard ? UIText("Да", "Yes")[0] : UIText("Нет", "No")[0];
                table.Cells[1, 3].Text = stability ? UIText("Да", "Yes")[0] : UIText("Нет", "No")[0];

                window.Invalidate();
            };

            #region repeatPopup
            var repeatPopup = new ModalWindow("", path) { HeaderLine = UIText("Внимание!", "Attention!")[0] };
            repeatPopup.TextLines[1].Text = UIText("Вы действительно хотите", "Do you want")[0];
            repeatPopup.TextLines[1].Size = 20;

            repeatPopup.TextLines[2].Text = UIText("начать измерение заново?", "to restart the measurement?")[0];
            repeatPopup.TextLines[2].Size = 20;

            var btnYes = Utils.ModalButton(325, 35, UIText("Да", "Yes"), Utils.ColorPalette.Green);
            btnYes.OnRelease = () =>
            {
                mMeasureController.OpenWindow3();
                repeatPopup.IsVisible = false;
                window.Invalidate();
            };
            repeatPopup.AddChild(btnYes);

            var btnNo = Utils.ModalButton(56, 35, UIText("Нет", "No"), Utils.ColorPalette.Red);
            btnNo.OnRelease = () =>
            {
                repeatPopup.IsVisible = false;
                window.Invalidate();
            };
            repeatPopup.AddChild(btnNo);

            window.AddPopup(repeatPopup);
            #endregion

            var btnRepeat = Utils.ClassicButton(345, 105, DefaultLanguage == Language.Rus ? new[] { "Повторное", "измерение" } : new[] { "Repeat", "measurement" }, null);
            btnRepeat.OnRelease = () =>
            {
                repeatPopup.IsVisible = true;
                window.Invalidate();
            };
            window.AddChild(btnRepeat);

            return window;
        }

        // vector rus & eng
        private static IWidget CreateWindow4_1(string path)
        {
            var window = new Window("window4_1");

            /*window4_1.AddChild(new RawButton("window4_1_home", Path.Combine(path, @"generic/home.raw"), Path.Combine(path, @"generic/home.raw"), 383, 247)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window1")
            });*/

            window.AddChild(new TextArea("window4_1_title", null, 10, 220, 460)
            {
                Color = { B = 1, G = 1, R = 1 },
                Text = UIText("Измерение начального потенциала системы", "Measurement of the system initial potential")[0],
                Size = 16,
                Align = AlignType.Center
            });

            var progressArea = new ProgressBarImages("bar", path, 10, 10) { Percent = 100, Text = UIText("Подготовка", "Preparation")[0], TextColor = { B = 1, R = 1, G = 1 } };
            window.AddChild(progressArea);

            var btnGraphic = Utils.ClassicButton(345, 160, UIText("График", "Graph"), null);
            btnGraphic.OnRelease = () => mMeasureController.ShowInitialGraphic();
            window.AddChild(btnGraphic);

            var table = new TextTable("window4_1.table", 15, 60, new[] { 210, 100 }, TextTable.CreateOffset(6, 22), new[] { 4, 4 }, null, 16);

            table.Cells[0, 0].Text = UIText("Потенциал", "Potential")[0];
            table.Cells[0, 1].Text = UIText("Температура", "Temperature")[0];
            table.Cells[0, 2].Text = UIText("Cоответствие потенциала", "Potential correspondence")[0];
            table.Cells[0, 3].Text = UIText("Стабильность потенциала", "Potential stability")[0];
            table.Cells[0, 4].Text = UIText("Времени затрачено", "Time spent")[0];
            table.Cells[0, 5].Text = UIText("Времени осталось", "Time left")[0];

            window.AddChild(table);

            mMeasureController.Window41DataAction = (percent, potential, temperature, standard, stability, time, left) =>
                                                        {
                                                            progressArea.Percent = (uint)percent;
                                                            progressArea.Text = UIText("Измерение", "Measurement")[0];

                                                            table.Cells[1, 0].Text = potential + UIText(" мВ", " mV")[0];
                                                            table.Cells[1, 1].Text = temperature + " C";
                                                            table.Cells[1, 2].Text = standard
                                                                                         ? UIText("Да", "Yes")[0]
                                                                                         : UIText("Нет", "No")[0];
                                                            table.Cells[1, 3].Text = stability
                                                                                         ? UIText("Да", "Yes")[0]
                                                                                         : UIText("Нет", "No")[0];
                                                            table.Cells[1, 4].Text = time;
                                                            table.Cells[1, 5].Text = left;

                                                            window.Invalidate();
                                                        };

            #region acceptPopup
            var acceptPopup = new ModalWindow("", path) { HeaderLine = UIText("Внимание!", "Attention!")[0] };
            {
                acceptPopup.TextLines[1].Text = UIText("Принять текущее значение потенциала?", "Accept the current potential value?")[0];
                acceptPopup.TextLines[1].Size = 16;

                var btnYes = Utils.ModalButton(325, 35, UIText("Да", "Yes"), Utils.ColorPalette.Green);
                btnYes.OnRelease = () =>
                {
                    mMeasureController.StopInitialMeasure();
                    acceptPopup.IsVisible = false;
                    window.Invalidate();
                };
                acceptPopup.AddChild(btnYes);

                var btnNo = Utils.ModalButton(56, 35, UIText("Нет", "No"), Utils.ColorPalette.Red);
                btnNo.OnRelease = () =>
                {
                    acceptPopup.IsVisible = false;
                    window.Invalidate();
                };
                acceptPopup.AddChild(btnNo);
            }

            window.AddPopup(acceptPopup);
            #endregion

            #region stopPopup
            var stopPopup = new ModalWindow("", path) { HeaderLine = UIText("Внимание!", "Attention!")[0] };
            {
                stopPopup.TextLines[1].Text = UIText("Вы действительно хотите остановить", "Do you really want to stop the")[0];
                stopPopup.TextLines[1].Size = 16;
                stopPopup.TextLines[2].Text = UIText("исследование?", "measurement?")[0];
                stopPopup.TextLines[2].Size = 16;

                var btnYes = Utils.ModalButton(325, 35, UIText("Да", "Yes"), Utils.ColorPalette.Green);
                btnYes.OnRelease = () =>
                {
                    mMeasureController.OnStopInitialMeasure();
                    stopPopup.IsVisible = false;
                    window.Invalidate();
                };
                stopPopup.AddChild(btnYes);

                var btnNo = Utils.ModalButton(56, 35, UIText("Нет", "No"), Utils.ColorPalette.Red);
                btnNo.OnRelease = () =>
                {
                    stopPopup.IsVisible = false;
                    window.Invalidate();
                };
                stopPopup.AddChild(btnNo);
            }

            window.AddPopup(stopPopup);
            #endregion

            #region buttons
            var btnAccept = Utils.ClassicButton(345, 10, UIText("Принять", "Accept"), Utils.ColorPalette.Green);
            btnAccept.OnRelease = () =>
            {
                acceptPopup.IsVisible = true;
                window.Invalidate();
            };
            window.AddChild(btnAccept);

            var btnStop = Utils.ClassicButton(345, 105, UIText("Стоп", "Stop"), Utils.ColorPalette.Red);
            btnStop.OnRelease = () =>
            {
                stopPopup.IsVisible = true;
                window.Invalidate();
            };
            window.AddChild(btnStop);
            #endregion

            // TODO: Debug only
            {
                //acceptPopup.IsVisible = false;
                //stopPopup.IsVisible = false;
            }


            return window;
        }

        // vector rus & eng
        private static IWidget CreateWindow5_1(string path)
        {
            var window = new Window("window5_1");

            window.AddChild(new RawButton("window5_1_home", Path.Combine(path, @"generic/home.raw"), Path.Combine(path, @"generic/home.raw"), 383, 247)
            {
                OnRelease = () =>
                                {
                                    mDeviceControl.StopMeasureProcess();
                                    mApplication.SetFocusedWindow("window1");
                                }
            });


            var text = new TextArea("", null, 40, 150, 400) { Align = AlignType.Center, Text = UIText("Внесите в ячейку анализатора XXX мл пробы", "Add XXX ml of the sample into the cell ")[0], Size = 18, Color = new Color { R = 1.0f, G = 1.0f, B = 1.0f } };
            window.AddChild(text);

            mMeasureController.Window51DataAction = t =>
                                                        {
                                                            text.Text = UIText("Внесите в ячейку анализатора", "Add")[0] + string.Format(" {0} ", t) + UIText("мл пробы", "ml of the sample into the cell ")[0];

                                                            window.Invalidate();
                                                        };

            var btnBack = Utils.ClassicButton(10, 10, UIText("Назад", "Back"), Utils.ColorPalette.Red);
            btnBack.OnRelease = () => mApplication.SetFocusedWindow("window4_3");
            window.AddChild(btnBack);


            var btnPrepare = Utils.ClassicButton(10 + 42 + 125, 10, DefaultLanguage == Language.Rus
                                                     ? new[] { "Подготовка", "пробы" }
                                                     : new[] { "Sample", "preparation" }, null);
            btnPrepare.OnRelease = () => mMeasureController.Open5_2();
            window.AddChild(btnPrepare);


            var btnNext = Utils.ClassicButton(10 + 42 * 2 + 250, 10, UIText("Далее", "Next"), Utils.ColorPalette.Green);
            btnNext.OnRelease = () => mMeasureController.StartSampleMeasure();
            window.AddChild(btnNext);

            return window;
        }

        // vector rus & eng
        private static IWidget CreateWindow5_2()
        {
            var window = new Window("window5_2");

            window.AddChild(new TextArea("", null, 20, 200, 440)
            {
                Align = AlignType.Center,
                Text = UIText("Подготовьте пробу в соответствии с данными в таблице", "Prepare the sample in accordance with the data in the table")[0],
                Size = 16,
                Color = new Color { R = 1.0f, G = 1.0f, B = 1.0f }
            });

            var table = new TextTable("window5_2.table", 60, 100, new[] { 240, 100 }, TextTable.CreateOffset(3, 22), new[] { 2, 4 }, null, 16);
            table.Cells[0, 0].Text = UIText("Навеска", "Weighed sample")[0];
            table.Cells[0, 1].Text = UIText("Объём растворителя", "Solvent volume")[0];
            table.Cells[0, 2].Text = UIText("Объём подготовленной пробы", "Prepared sample volume")[0];
            window.AddChild(table);

            mMeasureController.Window52DataAction = (vsample, isLiquid, vsolution, valiquot) =>
                                                        {
                                                            table.Cells[1, 0].Text = vsample + (isLiquid ? UIText(" мл.", " ml.")[0] : UIText(" мг.", " mg.")[0]);
                                                            table.Cells[1, 1].Text = vsolution + UIText(" мл.", " ml.")[0];
                                                            table.Cells[1, 2].Text = valiquot + UIText(" мл.", " ml.")[0];

                                                            window.Invalidate();
                                                        };
            var btnClose = Utils.ClassicButton(177, 10, UIText("Закрыть", "Close"), Utils.ColorPalette.Green);
            btnClose.OnRelease = () => mApplication.SetFocusedWindow("window5_1");
            window.AddChild(btnClose);

            return window;
        }

        // vector rus & eng
        private static IWidget CreateWindow7(string path)
        {
            var window = new Window("window7");

            window.AddChild(new RawButton("window7_home", Path.Combine(path, @"generic/home.raw"), Path.Combine(path, @"generic/home.raw"), 383, 247)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window1")
            });

            window.AddChild(new TextArea("", null, 80, 210, 320)
            {
                Align = AlignType.Left,
                Text = UIText("Отчёт о проведенном измерении", "Measurement report")[0],
                Size = 16,
                Color = new Color { R = 1.0f, G = 1.0f, B = 1.0f }
            });

            var table = new TextTable("window7.table", 15, 70, new[] { 180, 130 }, TextTable.CreateOffset(5, 22), new[] { 2, 4 }, null, 16);

            table.Cells[0, 0].Text = UIText("Проба:", "Sample:")[0];
            table.Cells[0, 1].Text = UIText("Результат АОА:", "Result AOA:")[0];
            table.Cells[0, 2].Text = UIText("Результат ОА:", "Result OA:")[0];
            table.Cells[0, 3].Text = UIText("Исполнитель:", "Performer:")[0];
            table.Cells[0, 4].Text = UIText("Дата:", "Data:")[0];
            window.AddChild(table);

            var additionalWindow = new ModalWindow("", path) { HeaderLine = UIText("Дополнительные сведения:", "Additional information")[0] };
            {
                const int kOffset = 120;
                for (var i = 2; i < 7; i++)
                {
                    additionalWindow.Cells[1, i].X -= kOffset;
                    additionalWindow.Cells[0, i].Width -= kOffset;
                    additionalWindow.Cells[1, i].Width = kOffset;
                }

                var btnYes = Utils.ModalButton(193, 35, UIText("Ok", "Ok"), Utils.ColorPalette.Green);
                btnYes.OnRelease = () =>
                {
                    additionalWindow.IsVisible = false;
                    window.Invalidate();
                };
                additionalWindow.AddChild(btnYes);
            }
            window.AddPopup(additionalWindow);


            mMeasureController.Window7DataAction = (sample, aoa, oa, executor, date, startTime, endTime, totalTime, stability, Ebase, Esample, Emax, t) =>
            {

                table.Cells[1, 0].Text = sample;
                table.Cells[1, 1].Text = aoa != string.Empty ? aoa + UIText(" мМ-экв/л", " mM-eq")[0] : UIText("не обнаружено", "not found")[0];
                table.Cells[1, 2].Text = oa != string.Empty ? oa + UIText(" мМ-экв/л", " mM-eq")[0] : UIText("не обнаружено", "not found")[0];
                table.Cells[1, 3].Text = executor;
                table.Cells[1, 4].Text = date;

                additionalWindow.Cells[0, 2].Text = UIText("Затраченное время:", "The time spent:")[0];
                additionalWindow.Cells[1, 2].Text = totalTime;

                additionalWindow.Cells[0, 3].Text = UIText("Начальный потенциал:", "Initial potential:")[0];
                if (Ebase.HasValue)
                    additionalWindow.Cells[1, 3].Text = Ebase.Value.ToString("F2") + UIText(" мВ", " mV")[0];
                else
                    additionalWindow.Cells[1, 3].Text = "-";


                additionalWindow.Cells[0, 4].Text = UIText("Потенциал пробы:", "Sample potential:")[0];
                if (Esample.HasValue)
                    additionalWindow.Cells[1, 4].Text = Esample.Value.ToString("F2") + UIText(" мВ", " mV")[0];
                else
                    additionalWindow.Cells[1, 4].Text = "-";


                additionalWindow.Cells[0, 5].Text = UIText("Макс. потенциал:", "Maximum potential:")[0];
                if (Emax.HasValue)
                    additionalWindow.Cells[1, 5].Text = Emax.Value.ToString("F2") + UIText(" мВ", " mV")[0];
                else
                    additionalWindow.Cells[1, 5].Text = "-";

                additionalWindow.Cells[0, 6].Text = UIText("Температура:", "Temperature:")[0];
                if (t.HasValue)
                    additionalWindow.Cells[1, 6].Text = t + " C";
                else
                    additionalWindow.Cells[1, 6].Text = "-";
            };


            #region buttons
            var btnNext = Utils.ClassicButton(345, 10, DefaultLanguage == Language.Rus
                                         ? new[] { "Следующий", "анализ" }
                                         : new[] { "Next", "analysis" }, Utils.ColorPalette.Green);
            btnNext.OnRelease = () => mApplication.SetFocusedWindow("window2");
            window.AddChild(btnNext);


            var btnRepeat = Utils.ClassicButton(345, 165, DefaultLanguage == Language.Rus
                                         ? new[] { "Повторить", "измерение" }
                                         : new[] { "Repeat", "measurement" }, null);
            btnRepeat.OnRelease = () =>
            {
                mMeasureController.Reset();
                mMeasureController.OpenWindow3();
            };
            window.AddChild(btnRepeat);

            var btnExtraInfo = Utils.ClassicButton(345, 105, DefaultLanguage == Language.Rus
                                         ? new[] { "", "Дополнительно", "" }
                                         : new[] { "", "Additionally", "" }, null);
            btnExtraInfo.OnRelease = () =>
            {
                additionalWindow.IsVisible = true;
                window.Invalidate();
            };
            window.AddChild(btnExtraInfo);
            #endregion

            return window;
        }

        // vector rus & eng
        private static IWidget CreateWindow8_1()
        {
            var window = new Window("window8_1");

            /*window.AddChild(new RawButton("window8_1.home", Path.Combine(path, @"generic/home.raw"), Path.Combine(path, @"generic/home.raw"), 383, 247)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window1")
            });*/

            var table = new TextTable("", 25, 120, new[] { 420 }, TextTable.CreateOffset(2, 23), new[] { 4, 4 }, new Color { R = 1f, B = 1f, G = 1f }, 16) { CellBorder = false, CellFill = false, Border = false };
            table.Cells[0, 0].Text = UIText("Смените раствор в ячейке на дистилированную воду,", "Change the solution in the cell for distilled water,")[0];
            table.Cells[0, 0].Align = AlignType.Center;
            table.Cells[0, 1].Text = UIText("опустите электроды в ячейку.", "immerse the electrode into the cell.")[0];
            table.Cells[0, 1].Align = AlignType.Center;
            window.AddChild(table);


            var btnNext = Utils.ClassicButton(345, 10, UIText("Далее", "Next"), Utils.ColorPalette.Green);
            btnNext.OnRelease = () =>
            {
                mWindow8_2Timer.MaxTime = mDeviceControl.GetLavadoConfiguration().Time;
                mDeviceControl.StartLavado();
                //mWindow8_2Timer.Language = DefaultLanguage;
                mWindow8_2Timer.StartTimer();
                mApplication.SetFocusedWindow("window8_2");
            };
            window.AddChild(btnNext);

            return window;
        }

        // vector rus & eng
        private static IWidget CreateWindow8_2()
        {
            var window = new Window("window8_2");

            var btnSkip = Utils.ClassicButton(177, 10, UIText("Пропустить", "Skip"), Utils.ColorPalette.Green);
            btnSkip.OnRelease = () => mMeasureController.StopLavado();
            window.AddChild(btnSkip);

            var timer = mWindow8_2Timer;

            window.AddChild(timer);

            //window.OnShow = () =>
            {
                timer.Language = DefaultLanguage;
            };

            return window;
        }

        // vector rus & eng
        private static IWidget CreateWindow8_4()
        {
            var window = new Window("window8_4");

            /*window.AddChild(new RawButton("window8_4.home", Path.Combine(path, @"generic/home.raw"), Path.Combine(path, @"generic/home.raw"), 383, 247)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window1")
            });*/

            var btnBack = Utils.ClassicButton(10, 10, UIText("Назад", "Back"), Utils.ColorPalette.Red);
            btnBack.OnRelease = () => mApplication.SetFocusedWindow("window1");
            window.AddChild(btnBack);

            var btnRepeat = Utils.ClassicButton(177, 10, DefaultLanguage == Language.Rus
                                                     ? new[] { "Повторить", "отмывку" }
                                                     : new[] { "Repeat", "washing" }, null);
            btnRepeat.OnRelease = () => mMeasureController.OpenLavadoWindow("window8_4");
            window.AddChild(btnRepeat);

            return window;
        }

        // vector rus & eng
        private static Window CreateWindow9_1(string path)
        {
            var window = new Window("window9_1");

            window.AddChild(new RawButton("window9_home", Path.Combine(path, @"generic/home.raw"), Path.Combine(path, @"generic/home.raw"), 383, 247)
                                 {
                                     OnRelease = () => mApplication.SetFocusedWindow("window1")
                                 });



            const int kWidth = 165;
            const int kHeight = 55;
            const float kRound = 20f;
            const int kSize = 18;
            const int kBias = 5;

            var btnDate = new Button("classicButton", 157, 70 + 2 * kHeight, kWidth, kHeight, kRound);
            btnDate.AddChild(new TextArea("", null, 157, (btnDate.Height - kSize) / 2 + kBias + 70 + 2 * kHeight, btnDate.Width) { Text = UIText("Дата и время", "Date and time")[0], Size = kSize, Align = AlignType.Center });
            btnDate.OnRelease = () => mApplication.SetFocusedWindow("window9_3");
            window.AddChild(btnDate);

            var btnEditor = new Button("classicButton", 157, 40 + kHeight, kWidth, kHeight, kRound);
            btnEditor.AddChild(new TextArea("", null, 157, (btnEditor.Height - kSize) / 2 + kBias + 40 + kHeight, btnEditor.Width) { Text = UIText("Редактор методик", "Methods editor")[0], Size = kSize, Align = AlignType.Center });
            btnEditor.OnRelease = () =>
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
            };
            window.AddChild(btnEditor);

            var btnCheckSw = new Button("classicButton", 157, 10, kWidth, kHeight, kRound);
            btnCheckSw.AddChild(new TextArea("", null, 157, (btnCheckSw.Height - kSize) / 2 + kBias + 10, btnCheckSw.Width) { Text = UIText("Проверка ПО", "SW verification")[0], Size = kSize, Align = AlignType.Center });
            btnCheckSw.OnRelease = () => mApplication.SetFocusedWindow("window9_4");
            window.AddChild(btnCheckSw);

            return window;
        }

        // vector rus & eng
        // Executors
        private static Window CreateWindow9_2(string path)
        {
            var window = new Window("window9_2");

            window.AddChild(new RawButton("window9_home", Path.Combine(path, @"generic/home.raw"), Path.Combine(path, @"generic/home.raw"), 383, 247)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window1")
            });

            var counter = new TextArea("counter", null, 20, 190, 100){Color = new Color(0xFFFFFFFF), Size = 16};
            window.AddChild(counter);

            var list = new ListWidget("list", 20, 75, new[] { 440 }, TextTable.CreateOffset(4, 25));
            list.OnSelectionChanged = () =>
                                          {
                                              counter.Text = (list.CurrentId + 1) + " / " + list.Items.Length;
                                          };

            list.OnPress = () =>
                             {                                
                                 if (list.IsPositionChanged) return;

                                 var settings = mDeviceControl.SettingsStorage.Load();
                                 settings.Executors = list.Items.ToList().ConvertAll(i => i.Column1);
                                 settings.LastUsedExecutor = (string)list.CurrentSelection;
                                 mDeviceControl.SettingsStorage.Save(settings);
                                 var rv = mApplication.GetWindows().First(w => w.Name == "window2") as Window;

                                 if (rv == null) return;

                                 rv.OnShow();
                                 mApplication.SetFocusedWindow(rv);
                             };

            window.OnShow = () =>
            {
                var executors = mDeviceControl.SettingsStorage.Load().Executors;
                list.Items = executors.ConvertAll(e => new ListWidget.Item { Column1 = e, Id = e }).ToArray();
                counter.Text = (list.CurrentId + 1) + " / " + list.Items.Length;
            };
            window.AddChild(list);


            window.AddChild(new RawButton("", Path.Combine(path, "9/2/bt_up.raw"), Path.Combine(path, "9/2/bt_up_pr.raw"), 340, 180)
            {
                OnRelease = list.PageUp
            });

            window.AddChild(new RawButton("", Path.Combine(path, "9/2/bt_down.raw"), Path.Combine(path, "9/2/bt_down_pr.raw"), 340, 5)
            {
                OnRelease = list.PageDown
            });

            var btnAdd = Utils.PickButton(255, 15, "+", null);
            {
                btnAdd.OnRelease = () =>
                                       {
                                           mKeyboardWindow.OnEnter = returnText =>
                                                                         {
                                                                             if (string.IsNullOrWhiteSpace(returnText))
                                                                                 return;

                                                                             var newItems = new ListWidget.Item[list.Items.Length + 1];
                                                                             Array.Copy(list.Items, newItems, list.Items.Length);
                                                                             newItems[list.Items.Length] = new ListWidget.Item { Column1 = returnText, Id = returnText };
                                                                             list.Items = newItems;
                                                                         };

                                           mKeyboardWindow.ReturnWindow = "window9_2";

                                           mApplication.SetFocusedWindow("keyboard_window");
                                       };
            }
            window.AddChild(btnAdd);

            var btnDel = Utils.PickButton(200, 15, "-", Utils.ColorPalette.Red);
            {
                btnDel.OnRelease = () =>
                                       {
                                           var newItems = list.Items.ToList();
                                           newItems.RemoveAll(i => i.Id == list.CurrentSelection);
                                           list.Items = newItems.ToArray();
                                       };
            }
            window.AddChild(btnDel);


            var btnBack = Utils.ClassicButton(15, 15, UIText("Назад", "Back"), null);
            btnBack.OnRelease = () => mApplication.SetFocusedWindow("window2");
            window.AddChild(btnBack);

            return window;
        }

        // vector rus & eng
        // TODO: DateTime
        private static Window CreateWindow9_3(string path)
        {
            var window = new Window("window9_3");

            window.AddChild(new RawButton("window9_home", Path.Combine(path, @"generic/home.raw"), Path.Combine(path, @"generic/home.raw"), 383, 247)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window1")
            });

            window.AddChild(new TextArea("window9_3_text1", null, 20, 205, 440) { Text = UIText("Настройка времени и даты", "Date and Time Setting")[0], Align = AlignType.Center, Size = 26, Color = new Color { R = 1.0f, G = 1.0f, B = 1.0f } });

            var clockset = new ClockSet("", path, 0, 120);
            window.AddChild(clockset);


            var btnBack = Utils.ClassicButton(10, 10, UIText("Назад", "Back"), null);
            btnBack.OnRelease = () => mApplication.SetFocusedWindow("window9_1");
            window.AddChild(btnBack);

            var btnAccept = Utils.ClassicButton(345, 10, UIText("Принять", "Accept"), Utils.ColorPalette.Green);
            btnAccept.OnRelease = () =>  {
                                    clockset.SetSystemTime();
                                    mApplication.SetFocusedWindow("window9_1");
                                };
            window.AddChild(btnAccept);

            return window;
        }

        // vector rus & eng
        // TODO: checkSW
        private static Window CreateWindow9_4(string path)
        {
            var window = new Window("window9_4");

            window.AddChild(new RawButton("window9_home", Path.Combine(path, @"generic/home.raw"), Path.Combine(path, @"generic/home.raw"), 383, 247)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window1")
            });

            window.AddChild(new TextArea("window9_4_text1", null, 20, 150, 440) { Text = UIText("Вы используете сертфицированную версию ПО", "You apply certified version of the software")[0], Align = AlignType.Center, Size = 16, Color = new Color { R = 1.0f, G = 1.0f, B = 1.0f } });
            window.AddChild(new TextArea("window9_4_text1", null, 20, 130, 440) { Text = UIText("Хэш-код: ", "Hash-code: ")[0] + "f2ad-5e6c-b4c83ccb-8e836ae9-54f95d5f", Align = AlignType.Center, Size = 16, Color = new Color { R = 1.0f, G = 1.0f, B = 1.0f } });
            window.AddChild(new ImageLabel("", Path.Combine(path, @"9/4/image_check.raw"), 15, 130));

            var btnBack = Utils.ClassicButton(177, 10, UIText("Назад", "Back"), Utils.ColorPalette.Green);
            btnBack.OnRelease = () => mApplication.SetFocusedWindow("window9_1");
            window.AddChild(btnBack);

            return window;
        }


        // vector rus & eng
        // Methodics
        private static Window CreateWindow9_5(string path)
        {
            var window = new Window("window9_5");

            window.AddChild(new RawButton("window9_home", Path.Combine(path, @"generic/home.raw"), Path.Combine(path, @"generic/home.raw"), 383, 247)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window1")
            });


            var list = new ListWidget("list", 20, 75, new[] { 440 }, TextTable.CreateOffset(4, 25));
            list.OnPress = () =>
            {
                
                //if (list.IsPositionChanged) return;
                
                var settings = mDeviceControl.SettingsStorage.Load();               
                settings.LastUsedMethodology = (string)list.CurrentSelection;
                mDeviceControl.SettingsStorage.Save(settings);
                
                var rv = mApplication.GetWindows().First(w => w.Name == "window2") as Window;

                if (rv == null) return;

                rv.OnShow();
                mApplication.SetFocusedWindow(rv);
            };

            window.OnShow = () =>
            {
                var methodologies = mDeviceControl.GetAvailMethodologies();
                list.Items = methodologies.ConvertAll(e => new ListWidget.Item { Column1 = e, Id = e }).ToArray();
            };
            window.AddChild(list);

            var btnBack = Utils.ClassicButton(15, 15, UIText("Назад", "Back"), null);
            btnBack.OnRelease = () => mApplication.SetFocusedWindow("window2");
            window.AddChild(btnBack);

            return window;
        }

        // vector rus & eng
        // Executors
        private static Window GetLoadingWindow(string path)
        {
            var window = new Window("window_loading");

            var progressBar = new ProgressBarImages("bar", path, 80, 100)
                                  {
                                      Percent = 0,
                                      TextColor = { B = 1, R = 1, G = 1 }
                                  };
            window.AddChild(progressBar);

            mMeasureController.Language = DefaultLanguage;
            mMeasureController.SetProgresbarData = (percent, message) =>
                                              {
                                                  progressBar.Percent = (uint)percent;
                                                  progressBar.Text = message;

                                                  window.Invalidate();
                                              };

            return window;
        }

        // vector rus & eng
        private static Window CreateWindow10_1(string path)
        {
            var window = new Window("window10_1");

            window.AddChild(new RawButton("window10_1.home", Path.Combine(path, @"generic/home.raw"), Path.Combine(path, @"generic/home.raw"), 383, 247)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window1")
            });

            var counter = new TextArea("counter", null, 20, 190, 100) { Color = new Color(0xFFFFFFFF), Size = 16 };
            window.AddChild(counter);

            var list = new ListWidget("list", 20, 75, new[] { 260, 180 }, TextTable.CreateOffset(4, 25));
            list.OnSelectionChanged = () =>
            {
                counter.Text = (list.CurrentId + 1) + " / " + list.Items.Length;
            };

            list.OnPress = () =>
            {
                if (list.IsPositionChanged) return;

                mMeasureController.ShowReport((Guid)list.CurrentSelection);
            };  

            window.OnShow = () =>
                                {
                                    counter.Text = (list.CurrentId + 1) + " / " + list.Items.Length;
                                    
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


            window.AddChild(new RawButton("", Path.Combine(path, "9/2/bt_up.raw"), Path.Combine(path, "9/2/bt_up_pr.raw"), 340, 180)
            {
                OnRelease = list.PageUp
            });

            window.AddChild(new RawButton("", Path.Combine(path, "9/2/bt_down.raw"), Path.Combine(path, "9/2/bt_down_pr.raw"), 340, 5)
            {
                OnRelease = list.PageDown
            });

            var btnCopy = Utils.ClassicButton(15, 15, DefaultLanguage == Language.Rus
                                         ? new[] { "", "Скопировать", "" }
                                         : new[] { "Copy" }, null);
            btnCopy.OnRelease = () =>
            {
                                                        var id = list.CurrentSelection;

                                                        if (id != null)
                                                        {
                                                            mMeasureController.CopyReport((Guid)id);
                                                        }
                                                    };
            window.AddChild(btnCopy);


            var btnDel = Utils.PickButton(200, 15, "-", Utils.ColorPalette.Red);
            {
                btnDel.OnRelease = () =>
                   {
                                                        var id = list.CurrentSelection;
                                                        if (id != null)
                                                            mDeviceControl.RemoveReports(new[] { (Guid)id });

                                                        window.OnShow();

                                                        window.Invalidate();
                                                    };
            }
            window.AddChild(btnDel);

            return window;
        }

        // vector rus & eng
        private static IWidget CreateWindow11(string path)
        {
            var window = new Window("window11");

            window.AddChild(new RawButton("window11_home", Path.Combine(path, @"generic/home.raw"), Path.Combine(path, @"generic/home.raw"), 383, 247)
            {
                OnRelease = () => mApplication.SetFocusedWindow("window1")
            });

            window.AddChild(new TextArea("", null, 80, 210, 350) { Text = UIText("Отчёт о проведенном измерении", "Measurement report")[0], Size = 16, Color = new Color { R = 1.0f, G = 1.0f, B = 1.0f } });

            var table = new TextTable("window11.table", 15, 70, new[] { 180, 130 }, TextTable.CreateOffset(5, 22), new[] { 2, 4 }, null, 16);

            table.Cells[0, 0].Text = UIText("Проба:", "Sample:")[0];
            table.Cells[0, 1].Text = UIText("Результат АОА:", "Result AOA:")[0];
            table.Cells[0, 2].Text = UIText("Результат ОА:", "Result OA:")[0];
            table.Cells[0, 3].Text = UIText("Исполнитель:", "Performer:")[0];
            table.Cells[0, 4].Text = UIText("Дата:", "Data:")[0];
            window.AddChild(table);
            
            var btnArchive = Utils.ClassicButton(10, 10, DefaultLanguage == Language.Rus
                             ? new[] { "К выбору", "архива" }
                             : new[] { "Choose", "report" }, null);
            btnArchive.OnRelease = () => mApplication.SetFocusedWindow("window10_1");
            window.AddChild(btnArchive);
          

            var additionalWindow = new ModalWindow("", path) { HeaderLine = UIText("Дополнительные сведения:", "Additional information")[0] };
            {
                const int kOffset = 120;
                for (var i = 2; i < 7; i++)
                {
                    additionalWindow.Cells[1, i].X -= kOffset;
                    additionalWindow.Cells[0, i].Width -= kOffset;
                    additionalWindow.Cells[1, i].Width = kOffset;
                }

                var btnYes = Utils.ModalButton(193, 35, UIText("Ok", "Ok"), Utils.ColorPalette.Green);
                btnYes.OnRelease = () =>
                {
                    additionalWindow.IsVisible = false;
                    window.Invalidate();
                };
                additionalWindow.AddChild(btnYes);
            }
            window.AddPopup(additionalWindow);

            var btnExtraInfo = Utils.ClassicButton(345, 105, DefaultLanguage == Language.Rus
                                         ? new[] { "", "Дополнительно", "" }
                                         : new[] { "", "Additionally", "" }, null);
            btnExtraInfo.OnRelease = () =>
            {
                additionalWindow.IsVisible = true;
                window.Invalidate();
            };
            window.AddChild(btnExtraInfo);


            mMeasureController.Window11DataAction = (sample, aoa, oa, executor, date, startTime, endTime, totalTime, stability, Ebase, Esample, Emax, t) =>
            {                
                table.Cells[1, 0].Text = sample;
                table.Cells[1, 1].Text = aoa != string.Empty ? aoa + UIText(" мМ-экв/л", " mM-eq")[0] : UIText("не обнаружено", "not found")[0];
                table.Cells[1, 2].Text = oa != string.Empty ? oa + UIText(" мМ-экв/л", " mM-eq")[0] : UIText("не обнаружено", "not found")[0];
                table.Cells[1, 3].Text = executor;
                table.Cells[1, 4].Text = date;

                additionalWindow.Cells[0, 2].Text = UIText("Затраченное время:", "The time spent:")[0];
                additionalWindow.Cells[1, 2].Text = totalTime;

                additionalWindow.Cells[0, 3].Text = UIText("Начальный потенциал:", "Initial potential:")[0];
                if (Ebase.HasValue)
                    additionalWindow.Cells[1, 3].Text = Ebase.Value.ToString("F2") + UIText(" мВ", " mV")[0];
                else
                    additionalWindow.Cells[1, 3].Text = "-";


                additionalWindow.Cells[0, 4].Text = UIText("Потенциал пробы:", "Sample potential:")[0];
                if (Esample.HasValue)
                    additionalWindow.Cells[1, 4].Text = Esample.Value.ToString("F2") + UIText(" мВ", " mV")[0];
                else
                    additionalWindow.Cells[1, 4].Text = "-";


                additionalWindow.Cells[0, 5].Text = UIText("Макс. потенциал:", "Maximum potential:")[0];
                if (Emax.HasValue)
                    additionalWindow.Cells[1, 5].Text = Emax.Value.ToString("F2") + UIText(" мВ", " mV")[0];
                else
                    additionalWindow.Cells[1, 5].Text = "-";

                additionalWindow.Cells[0, 6].Text = UIText("Температура:", "Temperature:")[0];
                if (t.HasValue)
                    additionalWindow.Cells[1, 6].Text = t + " C";
                else
                    additionalWindow.Cells[1, 6].Text = "-";
            };

            return window;
        }

        // vector rus & eng
        private static readonly TimerWidget mWindow8_2Timer = new TimerWidget("Window8_2Timer")
                                   {
                                       OnTimeOut = () => mMeasureController.StopLavado()
                                   };
    }
}

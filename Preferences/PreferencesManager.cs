using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Dashboard.Common;

namespace Dashboard.Preferences
{
    [Serializable]
    public class Preferences
    {
        public bool CloseOnActivity { get; set; } = false;

        public Modes MultiScreenMode { get; set; } = Modes.Span;

        public List<ScreenInformation> Screens { get; set; } = new List<ScreenInformation>();
    }


    public class PreferencesManager
    {
        private readonly IDataSource<Preferences> dataSource;
        public Preferences CurrentPreferences { get; set; }
        private const string DEFAULT_URL = "http://www.google.co.in";
        private void LoadPreferences()
        {
            CurrentPreferences = dataSource.GetValue();
            if (CurrentPreferences == null) {
                CurrentPreferences = new Preferences();
            }

        }

        private static Rectangle FindEnclosingRect(List<Rectangle> rectangles)
        {
            return Rectangle.FromLTRB(
                rectangles.Min(r => r.Left),
                rectangles.Min(r => r.Top),
                rectangles.Max(r => r.Right),
                rectangles.Max(r => r.Bottom));
        }

        public PreferencesManager()
        {
            dataSource = new DataSource<Preferences>();
            CurrentPreferences = new Preferences();
            LoadPreferences();
            LoadeEffectiveScreensList();
        }

        private void LoadeEffectiveScreensList()
        {
            if (CurrentPreferences.Screens.Count > 0)
                switch (CurrentPreferences.MultiScreenMode)
                {
                    case Modes.Span:
                        Rectangle enclosingRect = FindEnclosingRect(Screen.AllScreens.Select(r => r.Bounds).ToList());
                        CurrentPreferences.Screens[0].ScreenNum = 0;
                        CurrentPreferences.Screens[0].Bounds = enclosingRect;
                        CurrentPreferences.Screens[0].IsPrimary = true;
                        break;

                    case Modes.Mirror:
                        var screen = CurrentPreferences.Screens[0];
                        screen.ScreenNum = 0;
                        screen.Bounds = Screen.AllScreens[0].Bounds;
                        screen.IsPrimary = true;
                        for (int i = 1; i < Screen.AllScreens.Length; i++)
                        {
                            var screenInfo = new ScreenInformation
                            {
                                UrlList = CurrentPreferences.Screens[0].UrlList.ToList(),
                                Bounds = Screen.AllScreens[i].Bounds,
                                IsPrimary = Screen.AllScreens[i].Primary,
                                Interval = CurrentPreferences.Screens[0].Interval,
                                Randomize = CurrentPreferences.Screens[0].Randomize,
                                ScreenNum = i
                            };
                            CurrentPreferences.Screens.Add(screenInfo);
                        }
                        break;

                    case Modes.Separate:
                        for (int i = 0; i < Screen.AllScreens.Length; i++)
                        {
                            var singleScreen = CurrentPreferences.Screens[i];
                            singleScreen.ScreenNum = i;
                            singleScreen.Bounds = Screen.AllScreens[i].Bounds;
                            singleScreen.IsPrimary = Screen.AllScreens[i].Primary;
                        }
                        break;
                }
        }


        public List<string> GetUrlsByScreen(int screenNum)
        {
            if (CurrentPreferences.Screens.Count == screenNum)
            {
                CurrentPreferences.Screens.Add(new ScreenInformation());
            }
            var urls = CurrentPreferences.Screens[screenNum].UrlList;
            if (urls.Count == 0)
            {
                urls.Add(DEFAULT_URL);
            }

            return CurrentPreferences.Screens[screenNum].UrlList;
        }
        public void SavePreferences()
        {
            if (CurrentPreferences.MultiScreenMode != Modes.Separate)
            {
                CurrentPreferences.Screens.RemoveRange(1, CurrentPreferences.Screens.Count - 1);
            }
            dataSource.SetValue(CurrentPreferences);
        }
    }
}
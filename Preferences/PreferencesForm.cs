using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using Dashboard.Common;

namespace Dashboard.Preferences
{

    public partial class PreferencesForm : Form
    {
        private readonly PreferencesManager prefsManager = new PreferencesManager();

        private List<ScreenControl> screenUserControls;

        public PreferencesForm()
        {
            InitializeComponent();
        }
        protected override void OnClosed(EventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                ReadBackValuesFromUI();
                prefsManager.SavePreferences();
            }

            base.OnClosed(e);
        }

        private void PreferencesForm_Load(object sender, EventArgs e)
        {
            cbCloseOnActivity.Checked = prefsManager.CurrentPreferences.CloseOnActivity;
            if (Screen.AllScreens.Count() == 1)
            {
                multiScreenGroup.Enabled = false;
                screenUserControls = new List<ScreenControl>() { ucScreenPreferences };
                tcScreens.TabPages[0].Text = "Screen";
                LoadValuesForTab(0);
            }
            else
            {
                multiScreenGroup.Enabled = true;
                SetMultiScreenButtonFromMode();
                ArrangeScreenTabs();
            }
        }

        private void LoadValuesForTab(int screenNum)
        {
            var currentPrefsUserControl = screenUserControls[screenNum];
            LoadUrlsForTabToControl(screenNum, currentPrefsUserControl);
            currentPrefsUserControl.nudRotationInterval.Value = prefsManager.CurrentPreferences.Screens[screenNum].Interval;
            currentPrefsUserControl.cbRandomize.Checked = prefsManager.CurrentPreferences.Screens[screenNum].Randomize;
        }

        private void ArrangeScreenTabs()
        {
            RemoveExtraTabPages();
            screenUserControls = new List<ScreenControl>() { ucScreenPreferences };
            LoadValuesForTab(0);

            switch (prefsManager.CurrentPreferences.MultiScreenMode)
            {
                case Modes.Span:
                    tcScreens.TabPages[0].Text = "Composite Screen";
                    break;
                case Modes.Mirror:
                    tcScreens.TabPages[0].Text = "Each Screen";
                    break;
                case Modes.Separate:
                    tcScreens.TabPages[0].Text = "Screen 1";
                    AddTabsForExtraScreens();
                    SetPrimaryScreenInicator();
                    break;
            }
        }
        private void AddTabsForExtraScreens()
        {
            for (int i = 1; i < Screen.AllScreens.Length; i++)
            {
                TabPage tabPage = new TabPage($"Screen {i + 1}");
                tcScreens.TabPages.Add(tabPage);

                var prefsByScreenUserControl = new ScreenControl
                {
                    Name = string.Format("ucScreenPreferences{0}", i + 1),
                    Location = new Point(0, 0), //prefsByScreenUserControl1.Location,
                    Size = ucScreenPreferences.Size,
                    Anchor = ucScreenPreferences.Anchor,
                    BackColor = ucScreenPreferences.BackColor
                };
                screenUserControls.Add(prefsByScreenUserControl);
                tabPage.Controls.Add(prefsByScreenUserControl);
                LoadValuesForTab(i);
            }
        }
        private void SetPrimaryScreenInicator()
        {
            for (int i = 0; i < Screen.AllScreens.Length; i++)
            {
                if (Screen.AllScreens[i].Primary)
                {
                    tcScreens.TabPages[i].Text += " (Primary)";
                    break;
                }
            }
        }

        private void RemoveExtraTabPages()
        {
            while (tcScreens.TabPages.Count > 1)
            {
                tcScreens.TabPages.RemoveAt(tcScreens.TabPages.Count - 1);
            }
        }

        private void SetMultiScreenButtonFromMode()
        {
            switch (prefsManager.CurrentPreferences.MultiScreenMode)
            {
                case Modes.Span:
                    spanScreensButton.Checked = true;
                    break;
                case Modes.Mirror:
                    mirrorScreensButton.Checked = true;
                    break;
                case Modes.Separate:
                    separateScreensButton.Checked = true;
                    break;
            }
        }

        private void SetMultiScreenModeFromButtonState()
        {
            if (spanScreensButton.Checked) prefsManager.CurrentPreferences.MultiScreenMode = Modes.Span;
            else if (mirrorScreensButton.Checked) prefsManager.CurrentPreferences.MultiScreenMode = Modes.Mirror;
            else prefsManager.CurrentPreferences.MultiScreenMode = Modes.Separate;
            //prefsManager.ResetEffectiveScreensList();
        }

        private void ReadBackValuesFromUI()
        {
           
            prefsManager.CurrentPreferences.Screens = new List<ScreenInformation>();

            for (int index = 0; index < screenUserControls.Count; index++)
            {
                var screenControl = screenUserControls[index];
                var urls = screenControl.lvUrls.Items.Cast<ListViewItem>().Select(x => x.Text).ToList();
                var screenInformation = new ScreenInformation
                {
                    UrlList = urls,
                    Randomize = screenControl.cbRandomize.Checked,
                    Interval = (int)screenControl.nudRotationInterval.Value,
                    IsPrimary = index == 0,
                    ScreenNum = index
                };
                prefsManager.CurrentPreferences.Screens.Add(screenInformation);

            }
            prefsManager.CurrentPreferences.CloseOnActivity = cbCloseOnActivity.Checked;
        }

        private void LoadUrlsForTabToControl(int screenNum, ScreenControl currentPrefsUserControl)
        {
            currentPrefsUserControl.lvUrls.Items.Clear();
            var urls = prefsManager.GetUrlsByScreen(screenNum);

            foreach (var url in urls)
            {
                currentPrefsUserControl.lvUrls.Items.Add(url);
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AnyMultiScreenModeButton_Click(object sender, EventArgs e)
        {
            SetMultiScreenModeFromButtonState();
            ArrangeScreenTabs();
            ReadBackValuesFromUI();
        }
    }
}

using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using Dashboard.Preferences;
using Dashboard.Screensaver;

namespace Dashboard
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // Set version of embedded browser (http://weblog.west-wind.com/posts/2011/May/21/Web-Browser-Control-Specifying-the-IE-Version)
            var exeName = Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", exeName, 0x2AF8, RegistryValueKind.DWord);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length > 0 && args[0].ToLower().Contains("/p"))
                return;

            if (args.Length > 0 && args[0].ToLower().Contains("/c"))
                Application.Run(new PreferencesForm());
            else
            {
                var formsList = new List<Form>();
                var screens = (new PreferencesManager()).CurrentPreferences.Screens;
                foreach (var screen in screens)
                {
                    var screensaverForm = new ScreensaverForm(screen.ScreenNum)
                    {
                        Location = new Point(screen.Bounds.Left, screen.Bounds.Top),
                        Size = new Size(screen.Bounds.Width, screen.Bounds.Height)
                    };

                    FormStartPosition x = screensaverForm.StartPosition;

                    formsList.Add(screensaverForm);
                }

                Application.Run(new MultiFormContext(formsList));
            }
        }
    }

    public class MultiFormContext : ApplicationContext
    {
        public MultiFormContext(List<Form> forms)
        {
            foreach (var form in forms)
            {
                form.FormClosed += (s, args) =>  ExitThread();
                form.Show();
            }
        }
    }
}

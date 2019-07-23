using System;
using System.Collections.Generic;
using System.Drawing;

namespace Dashboard.Common
{
    [Serializable]
    public class ScreenInformation
    {
        public int ScreenNum { get; set; }
        public Rectangle Bounds { get; set; }
        public bool IsPrimary { get; set; }
        public List<string> UrlList { get; set; } = new List<string>();
        public int Interval { get; set; } = 30;
        public bool Randomize { get; set; } = false;
    }
}

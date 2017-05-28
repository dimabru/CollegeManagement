using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Project_Team3
{
    static class FB_Program
    {
        [STAThread]
        public static void FB_Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new FB_Analyze());
        }
    }
}

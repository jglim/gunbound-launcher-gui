using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Diagnostics;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;

namespace Launcher
{
    class Program
    {

        public static MainForm mainForm;

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new MainForm();
            mainForm.ChangeLauncherState(MainForm.LauncherState.AWAITING_LOGIN);
            Application.Run(mainForm);
            return;
        }
    }
}

using System;
using System.Windows.Forms;

namespace HLTextureTools
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!FreeImageAPI.FreeImage.IsAvailable())
            {
                MessageBox.Show("FreeImage.dll 似乎丢失。终止程序.", "错误", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

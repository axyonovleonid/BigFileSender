using System;
using System.Windows.Forms;

namespace BigFileSender
{
    internal static class Program
    {
        ///<summary>
        ///Главнаяточкавходадляприложения.
        ///</summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
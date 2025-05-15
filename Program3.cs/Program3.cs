using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lab7CSharp3
{
    static class Program3
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form3());
        }
    }
}

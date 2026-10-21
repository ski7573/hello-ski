using System;
using System.Windows.Forms;

namespace HelloSki
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            MessageBox.Show("안녕 ski", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

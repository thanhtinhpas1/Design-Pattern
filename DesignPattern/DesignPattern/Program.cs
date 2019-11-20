using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesignPattern.View;

namespace DesignPattern
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Form grd1 = new GridData();
            //grd1.ShowDialog();

            Form cb1 = new ComboBoxGen();
            cb1.ShowDialog();
        }
    }
}

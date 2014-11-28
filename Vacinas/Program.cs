using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app = System.Windows.Forms;

namespace Vacinas
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            app.Application.EnableVisualStyles();
            app.Application.SetCompatibleTextRenderingDefault(false);
            app.Application.Run(new frmMain());
        }
    }
}

using Products_Managment.presintation_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products_Managment
{
    static class Program
    {
     public static  Main_Form main_form;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            main_form = new Main_Form();
            Application.Run(main_form);
        }
    }
}

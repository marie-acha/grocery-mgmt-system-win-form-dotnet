using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarieA_Assign2
{
    internal static class Program
    {
        //CSIS 1175, Section 003
        //Marie Acha
        //300363065

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GroceryForm());
        }
    }
}

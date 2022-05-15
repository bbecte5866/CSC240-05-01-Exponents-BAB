using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


/*          Name:           Brandi Bectel
 *          Date:           05/15/2022
 *          Description:    Exponents-startup
 *          Resources:      https://github.com/scordle/CSC240-05-01-Exponents-startup
 */          
           

namespace Exponents
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
            Application.Run(new Form1());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTVPlayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread] //Indicates the COM threding model for the application is single-threaded apartment (STA)
        static void Main()
        {
            //Enables visuals and runs the application
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
}

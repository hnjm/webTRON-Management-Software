﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using webTRON_Management_Software.Views.Admin;
using webTRON_Management_Software.Views.Others;

namespace webTRON_Management_Software
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
            //Application.Run(new CreateAccount());
            // Application.Run(new ForgetPassword());
            // Application.Run(new AdminDashboard());
            //Application.Run(new LandingWindow());
            //Application.Run(new CreateAccount());
            // Application.Run(new CreateNewPatient());
            Application.Run(new CreateAccount());
       
          
        }
    }
}

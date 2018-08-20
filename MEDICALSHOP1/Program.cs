using MEDICALSHOP1.REPORTS;
using MEDICALSHOP1.Trail;
using SecureApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDICALSHOP1
{
    static class Program
    {
        /// <summary>D:\MEDICALSHOPUPDATE22_09_2017\MEDICALSHOP06-02_2018\MEDICALSHOP1\Program.cs
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()  
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string path = @"Aimsoft\pranav\Protection";
            Secure scr = new Secure();
            bool logic = scr.Algorithm("Aimsoft@2018", path);
            if (logic == true)
                 Application.Run(new UserSelection());
          //  Application.Run(new Purchase());
            //Application.Run(new ItemwiseReport());
        }
    }
}

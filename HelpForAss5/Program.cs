using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpForAss5
{
    public static class Program
    {
        

        public static DBViewForm dbViewForm;

        public static ContactInfoForm contactInfoForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            

            dbViewForm = new DBViewForm();
            contactInfoForm = new ContactInfoForm();

            Application.Run(dbViewForm);
        }
    }
}

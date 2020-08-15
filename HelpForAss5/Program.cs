using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpForAss5
{
    public static class Program
    {
        public static List<Contact> contacts;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // new empty list of contacts
            contacts = new List<Contact>();

            Application.Run(new DBViewForm());
        }
    }
}

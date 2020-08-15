using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpForAss5
{
    public partial class DBViewForm : Form
    {
        public DBViewForm()
        {
            InitializeComponent();
        }

        private void DBViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lesson11DBDataSet.Contacts' table. You can move, or remove it, as needed.
            this.contactsTableAdapter.Fill(this.lesson11DBDataSet.Contacts);

            /* //all
            var contacts =
                from contact in this.lesson11DBDataSet.Contacts
                select contact;
            */

            /* // list of FirstName
            var contacts =
                from contact in this.lesson11DBDataSet.Contacts
                orderby contact.LastName descending
                select contact.FirstName;
            */

            var contacts =
                (from contact in this.lesson11DBDataSet.Contacts
                orderby contact.LastName 
                select contact).ToList();

            foreach (var contact in contacts)
            {
                var newContact = new Contact(
                    contact.FirstName,
                    contact.LastName,
                    contact.EmailAddress,
                    contact.ContactNumber
                    );

                Program.contacts.Add(newContact);

            }
            /*
            foreach (var contact in contacts)
            {
                Debug.WriteLine($"First name:{contact.FirstName}");
                Debug.WriteLine($"Last name:{contact.LastName}");
                Debug.WriteLine("");
            }
            */
        }
    }
}

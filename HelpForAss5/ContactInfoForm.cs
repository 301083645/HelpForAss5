using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpForAss5
{
    public partial class ContactInfoForm : Form
    {

        public List<Contact> Contacts { get; set; }

        public ContactInfoForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contacts = new List<Contact>();

            // configure the open file dialog
            ContactListOpenFile.InitialDirectory = Directory.GetCurrentDirectory();

            var openFileDialogResult = ContactListOpenFile.ShowDialog();

            if(openFileDialogResult != DialogResult.Cancel)
            {
                // create a new stream reader
                StreamReader streamReader = new StreamReader(ContactListOpenFile.FileName);

                // read in the list
                while (!streamReader.EndOfStream)
                {
                    var contact = new Contact();

                    contact.FirstName = streamReader.ReadLine();
                    contact.LastName = streamReader.ReadLine();
                    contact.EmailAddress = streamReader.ReadLine();
                    contact.ContactNumber = streamReader.ReadLine();

                    ContactListBox.Items.Add(contact.LastName);
                    ContactComboBox.Items.Add(contact.LastName);

                    Contacts.Add(contact); // add our new contact to the Contacts List
                }

                // clean up
                streamReader.Close();

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ContactInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ContactInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void ContactListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = Contacts[ContactListBox.SelectedIndex].FirstName;
            LastNameTextBox.Text = Contacts[ContactListBox.SelectedIndex].LastName;
            EmailTextBox.Text = Contacts[ContactListBox.SelectedIndex].EmailAddress;
            ContactNumberTextBox.Text = Contacts[ContactListBox.SelectedIndex].ContactNumber;

        }

        private void ContactComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = Contacts[ContactComboBox.SelectedIndex].FirstName;
            LastNameTextBox.Text = Contacts[ContactComboBox.SelectedIndex].LastName;
            EmailTextBox.Text = Contacts[ContactComboBox.SelectedIndex].EmailAddress;
            ContactNumberTextBox.Text = Contacts[ContactComboBox.SelectedIndex].ContactNumber;

        }
    }
}

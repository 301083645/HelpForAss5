﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the save file dialog
            ContactListSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            // display the savefiledialog and save the results in the saveFileDialogResult object
            var saveFileDialogResult = ContactListSaveFileDialog.ShowDialog();

            if (saveFileDialogResult != DialogResult.Cancel)
            {
                // create new stream
                StreamWriter streamWriter = new StreamWriter(ContactListSaveFileDialog.FileName);

                // write to the file

                using (var db = new ContactModel())// Entity Framework
                {


                    var contacts = (from contact in db.Contacts
                                 select contact).ToList();

                    foreach (var contact in contacts)
                    {
                        streamWriter.WriteLine(contact.FirstName);
                        streamWriter.WriteLine(contact.LastName);
                        streamWriter.WriteLine(contact.EmailAddress);
                        streamWriter.WriteLine(contact.ContactNumber);

                    }
                }
                

                // clean up
                streamWriter.Flush();
                streamWriter.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.contactInfoForm.Show();
            this.Hide();
        }
    }
}

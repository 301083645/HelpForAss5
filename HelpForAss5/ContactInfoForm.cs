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
        public ContactInfoForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                    streamReader.ReadLine();
                    ContactListBox.Items.Add(streamReader.ReadLine());
                    streamReader.ReadLine();
                    streamReader.ReadLine();

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
    }
}

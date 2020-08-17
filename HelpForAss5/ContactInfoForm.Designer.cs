namespace HelpForAss5
{
    partial class ContactInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PrimaryMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContactListBox = new System.Windows.Forms.ListBox();
            this.ContactListOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.ContactInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.ContactNumberLabel = new System.Windows.Forms.Label();
            this.ContactNumberTextBox = new System.Windows.Forms.TextBox();
            this.ContactComboBox = new System.Windows.Forms.ComboBox();
            this.PrimaryMenuStrip.SuspendLayout();
            this.ContactInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrimaryMenuStrip
            // 
            this.PrimaryMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.PrimaryMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.PrimaryMenuStrip.Name = "PrimaryMenuStrip";
            this.PrimaryMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.PrimaryMenuStrip.TabIndex = 0;
            this.PrimaryMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ContactListBox
            // 
            this.ContactListBox.FormattingEnabled = true;
            this.ContactListBox.ItemHeight = 31;
            this.ContactListBox.Location = new System.Drawing.Point(30, 67);
            this.ContactListBox.Name = "ContactListBox";
            this.ContactListBox.Size = new System.Drawing.Size(283, 35);
            this.ContactListBox.TabIndex = 1;
            this.ContactListBox.SelectedIndexChanged += new System.EventHandler(this.ContactListBox_SelectedIndexChanged);
            // 
            // ContactListOpenFile
            // 
            this.ContactListOpenFile.DefaultExt = "txt";
            this.ContactListOpenFile.FileName = "ContactList";
            this.ContactListOpenFile.Filter = "Text Files|*.txt|All Files|*.*";
            // 
            // ContactInfoGroupBox
            // 
            this.ContactInfoGroupBox.Controls.Add(this.ContactNumberTextBox);
            this.ContactInfoGroupBox.Controls.Add(this.ContactNumberLabel);
            this.ContactInfoGroupBox.Controls.Add(this.EmailTextBox);
            this.ContactInfoGroupBox.Controls.Add(this.EmailLabel);
            this.ContactInfoGroupBox.Controls.Add(this.LastNameTextBox);
            this.ContactInfoGroupBox.Controls.Add(this.LastNameLabel);
            this.ContactInfoGroupBox.Controls.Add(this.FirstNameTextBox);
            this.ContactInfoGroupBox.Controls.Add(this.FirstNameLabel);
            this.ContactInfoGroupBox.Location = new System.Drawing.Point(328, 42);
            this.ContactInfoGroupBox.Name = "ContactInfoGroupBox";
            this.ContactInfoGroupBox.Size = new System.Drawing.Size(444, 384);
            this.ContactInfoGroupBox.TabIndex = 2;
            this.ContactInfoGroupBox.TabStop = false;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(7, 25);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(147, 31);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.BackColor = System.Drawing.Color.White;
            this.FirstNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.FirstNameTextBox.Location = new System.Drawing.Point(13, 60);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.ReadOnly = true;
            this.FirstNameTextBox.Size = new System.Drawing.Size(291, 38);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(7, 108);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(145, 31);
            this.LastNameLabel.TabIndex = 0;
            this.LastNameLabel.Text = "Last Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.BackColor = System.Drawing.Color.White;
            this.LastNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.LastNameTextBox.Location = new System.Drawing.Point(13, 143);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.ReadOnly = true;
            this.LastNameTextBox.Size = new System.Drawing.Size(291, 38);
            this.LastNameTextBox.TabIndex = 1;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(7, 191);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(90, 31);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "E-mail";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.White;
            this.EmailTextBox.ForeColor = System.Drawing.Color.Black;
            this.EmailTextBox.Location = new System.Drawing.Point(14, 226);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.ReadOnly = true;
            this.EmailTextBox.Size = new System.Drawing.Size(425, 38);
            this.EmailTextBox.TabIndex = 1;
            // 
            // ContactNumberLabel
            // 
            this.ContactNumberLabel.AutoSize = true;
            this.ContactNumberLabel.Location = new System.Drawing.Point(7, 273);
            this.ContactNumberLabel.Name = "ContactNumberLabel";
            this.ContactNumberLabel.Size = new System.Drawing.Size(212, 31);
            this.ContactNumberLabel.TabIndex = 0;
            this.ContactNumberLabel.Text = "Contact Number";
            // 
            // ContactNumberTextBox
            // 
            this.ContactNumberTextBox.BackColor = System.Drawing.Color.White;
            this.ContactNumberTextBox.ForeColor = System.Drawing.Color.Black;
            this.ContactNumberTextBox.Location = new System.Drawing.Point(14, 308);
            this.ContactNumberTextBox.Name = "ContactNumberTextBox";
            this.ContactNumberTextBox.ReadOnly = true;
            this.ContactNumberTextBox.Size = new System.Drawing.Size(425, 38);
            this.ContactNumberTextBox.TabIndex = 1;
            // 
            // ContactComboBox
            // 
            this.ContactComboBox.FormattingEnabled = true;
            this.ContactComboBox.Location = new System.Drawing.Point(30, 233);
            this.ContactComboBox.Name = "ContactComboBox";
            this.ContactComboBox.Size = new System.Drawing.Size(283, 39);
            this.ContactComboBox.TabIndex = 3;
            this.ContactComboBox.SelectedIndexChanged += new System.EventHandler(this.ContactComboBox_SelectedIndexChanged);
            // 
            // ContactInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ContactComboBox);
            this.Controls.Add(this.ContactInfoGroupBox);
            this.Controls.Add(this.ContactListBox);
            this.Controls.Add(this.PrimaryMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.PrimaryMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "ContactInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactInfoForm_FormClosing);
            this.Load += new System.EventHandler(this.ContactInfoForm_Load);
            this.PrimaryMenuStrip.ResumeLayout(false);
            this.PrimaryMenuStrip.PerformLayout();
            this.ContactInfoGroupBox.ResumeLayout(false);
            this.ContactInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip PrimaryMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox ContactListBox;
        private System.Windows.Forms.OpenFileDialog ContactListOpenFile;
        private System.Windows.Forms.GroupBox ContactInfoGroupBox;
        private System.Windows.Forms.TextBox ContactNumberTextBox;
        private System.Windows.Forms.Label ContactNumberLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.ComboBox ContactComboBox;
    }
}
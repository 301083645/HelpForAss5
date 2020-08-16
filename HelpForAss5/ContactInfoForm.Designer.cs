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
            this.PrimaryMenuStrip.SuspendLayout();
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
            this.ContactListBox.Location = new System.Drawing.Point(24, 59);
            this.ContactListBox.Name = "ContactListBox";
            this.ContactListBox.Size = new System.Drawing.Size(334, 35);
            this.ContactListBox.TabIndex = 1;
            // 
            // ContactListOpenFile
            // 
            this.ContactListOpenFile.DefaultExt = "txt";
            this.ContactListOpenFile.FileName = "ContactList";
            this.ContactListOpenFile.Filter = "Text Files|*.txt|All Files|*.*";
            // 
            // ContactInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
    }
}
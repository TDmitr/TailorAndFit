namespace TailorAndFit
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.newClientBtn = new System.Windows.Forms.Button();
            this.materialsBtn = new System.Windows.Forms.Button();
            this.clientsBtn = new System.Windows.Forms.Button();
            this.archiveBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.buttonShowJournal = new System.Windows.Forms.Button();
            this.addRep = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonShowClients = new System.Windows.Forms.Button();
            this.buttonAddAccount = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // newClientBtn
            // 
            this.newClientBtn.AutoSize = true;
            this.newClientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newClientBtn.Image = global::TailorAndFit.Properties.Resources._1459701471_document_search;
            this.newClientBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.newClientBtn.Location = new System.Drawing.Point(12, 24);
            this.newClientBtn.Name = "newClientBtn";
            this.newClientBtn.Padding = new System.Windows.Forms.Padding(10);
            this.newClientBtn.Size = new System.Drawing.Size(148, 137);
            this.newClientBtn.TabIndex = 2;
            this.newClientBtn.Text = "Journal";
            this.newClientBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.newClientBtn.UseVisualStyleBackColor = true;
            this.newClientBtn.Click += new System.EventHandler(this.newClientBtn_Click);
            // 
            // materialsBtn
            // 
            this.materialsBtn.AutoSize = true;
            this.materialsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialsBtn.Image = ((System.Drawing.Image)(resources.GetObject("materialsBtn.Image")));
            this.materialsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.materialsBtn.Location = new System.Drawing.Point(12, 167);
            this.materialsBtn.Name = "materialsBtn";
            this.materialsBtn.Padding = new System.Windows.Forms.Padding(10);
            this.materialsBtn.Size = new System.Drawing.Size(148, 137);
            this.materialsBtn.TabIndex = 3;
            this.materialsBtn.Text = "Materials";
            this.materialsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.materialsBtn.UseVisualStyleBackColor = true;
            this.materialsBtn.Click += new System.EventHandler(this.materialsBtn_Click);
            // 
            // clientsBtn
            // 
            this.clientsBtn.AutoSize = true;
            this.clientsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientsBtn.Image = global::TailorAndFit.Properties.Resources._1459704994_user_manage;
            this.clientsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clientsBtn.Location = new System.Drawing.Point(166, 24);
            this.clientsBtn.Name = "clientsBtn";
            this.clientsBtn.Padding = new System.Windows.Forms.Padding(10);
            this.clientsBtn.Size = new System.Drawing.Size(148, 137);
            this.clientsBtn.TabIndex = 6;
            this.clientsBtn.Text = "Clients";
            this.clientsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.clientsBtn.UseVisualStyleBackColor = true;
            this.clientsBtn.Click += new System.EventHandler(this.clientsBtn_Click);
            // 
            // archiveBtn
            // 
            this.archiveBtn.AutoSize = true;
            this.archiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.archiveBtn.Image = global::TailorAndFit.Properties.Resources._1459705182_icons_11;
            this.archiveBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.archiveBtn.Location = new System.Drawing.Point(166, 167);
            this.archiveBtn.Name = "archiveBtn";
            this.archiveBtn.Padding = new System.Windows.Forms.Padding(10);
            this.archiveBtn.Size = new System.Drawing.Size(148, 137);
            this.archiveBtn.TabIndex = 7;
            this.archiveBtn.Text = "Archive";
            this.archiveBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.archiveBtn.UseVisualStyleBackColor = true;
            this.archiveBtn.Click += new System.EventHandler(this.archiveBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 29);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::TailorAndFit.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::TailorAndFit.Properties.Resources.useful_info_icon;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonShowJournal);
            this.panel1.Controls.Add(this.addRep);
            this.panel1.Location = new System.Drawing.Point(344, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 280);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 9;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(26, 195);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10);
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(229, 52);
            this.button2.TabIndex = 14;
            this.button2.Text = "Add Type of Clothing";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1459705182_icons-11.png");
            this.imageList1.Images.SetKeyName(1, "1459704994_user_manage.png");
            this.imageList1.Images.SetKeyName(2, "1459704887_notification_error.png");
            this.imageList1.Images.SetKeyName(3, "1459704403_Exit.png");
            this.imageList1.Images.SetKeyName(4, "1459704309_netlog.png");
            this.imageList1.Images.SetKeyName(5, "1459703803_Button.png");
            this.imageList1.Images.SetKeyName(6, "1459702417_Toilet_tissue.png");
            this.imageList1.Images.SetKeyName(7, "1459701471_document_search.png");
            this.imageList1.Images.SetKeyName(8, "1459701304_user_add.png");
            this.imageList1.Images.SetKeyName(9, "1459700932_document_add.png");
            this.imageList1.Images.SetKeyName(10, "1459700443_document_add.png");
            this.imageList1.Images.SetKeyName(11, "1459711453_folder_add.png");
            this.imageList1.Images.SetKeyName(12, "1459711403_folder_search.png");
            this.imageList1.Images.SetKeyName(13, "1459711936_user.png");
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 9;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(28, 137);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10);
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(161, 52);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add Group";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonShowJournal
            // 
            this.buttonShowJournal.AutoSize = true;
            this.buttonShowJournal.BackColor = System.Drawing.Color.Transparent;
            this.buttonShowJournal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowJournal.FlatAppearance.BorderSize = 0;
            this.buttonShowJournal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowJournal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowJournal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonShowJournal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShowJournal.ImageIndex = 12;
            this.buttonShowJournal.ImageList = this.imageList1;
            this.buttonShowJournal.Location = new System.Drawing.Point(28, 21);
            this.buttonShowJournal.Name = "buttonShowJournal";
            this.buttonShowJournal.Padding = new System.Windows.Forms.Padding(10);
            this.buttonShowJournal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonShowJournal.Size = new System.Drawing.Size(177, 52);
            this.buttonShowJournal.TabIndex = 12;
            this.buttonShowJournal.Text = "Show Journal";
            this.buttonShowJournal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonShowJournal.UseVisualStyleBackColor = false;
            this.buttonShowJournal.Click += new System.EventHandler(this.buttonShowJournal_Click);
            // 
            // addRep
            // 
            this.addRep.AutoSize = true;
            this.addRep.BackColor = System.Drawing.Color.Transparent;
            this.addRep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addRep.FlatAppearance.BorderSize = 0;
            this.addRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRep.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addRep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addRep.ImageIndex = 9;
            this.addRep.ImageList = this.imageList1;
            this.addRep.Location = new System.Drawing.Point(28, 79);
            this.addRep.Name = "addRep";
            this.addRep.Padding = new System.Windows.Forms.Padding(10);
            this.addRep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addRep.Size = new System.Drawing.Size(161, 52);
            this.addRep.TabIndex = 10;
            this.addRep.Text = "Add Repair";
            this.addRep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addRep.UseVisualStyleBackColor = false;
            this.addRep.Click += new System.EventHandler(this.addRep_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonShowClients);
            this.panel2.Controls.Add(this.buttonAddAccount);
            this.panel2.Location = new System.Drawing.Point(344, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 280);
            this.panel2.TabIndex = 13;
            // 
            // buttonShowClients
            // 
            this.buttonShowClients.AutoSize = true;
            this.buttonShowClients.BackColor = System.Drawing.Color.Transparent;
            this.buttonShowClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowClients.FlatAppearance.BorderSize = 0;
            this.buttonShowClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowClients.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonShowClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShowClients.ImageIndex = 12;
            this.buttonShowClients.ImageList = this.imageList1;
            this.buttonShowClients.Location = new System.Drawing.Point(28, 21);
            this.buttonShowClients.Name = "buttonShowClients";
            this.buttonShowClients.Padding = new System.Windows.Forms.Padding(10);
            this.buttonShowClients.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonShowClients.Size = new System.Drawing.Size(173, 52);
            this.buttonShowClients.TabIndex = 12;
            this.buttonShowClients.Text = "Show Clients";
            this.buttonShowClients.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonShowClients.UseVisualStyleBackColor = false;
            this.buttonShowClients.Click += new System.EventHandler(this.buttonShowClients_Click);
            // 
            // buttonAddAccount
            // 
            this.buttonAddAccount.AutoSize = true;
            this.buttonAddAccount.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddAccount.FlatAppearance.BorderSize = 0;
            this.buttonAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddAccount.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAddAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddAccount.ImageIndex = 8;
            this.buttonAddAccount.ImageList = this.imageList1;
            this.buttonAddAccount.Location = new System.Drawing.Point(28, 79);
            this.buttonAddAccount.Name = "buttonAddAccount";
            this.buttonAddAccount.Padding = new System.Windows.Forms.Padding(10);
            this.buttonAddAccount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAddAccount.Size = new System.Drawing.Size(173, 52);
            this.buttonAddAccount.TabIndex = 11;
            this.buttonAddAccount.Text = "Add Account";
            this.buttonAddAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddAccount.UseVisualStyleBackColor = false;
            this.buttonAddAccount.Click += new System.EventHandler(this.buttonAddAccount_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Controls.Add(this.archiveBtn);
            this.panel5.Controls.Add(this.clientsBtn);
            this.panel5.Controls.Add(this.materialsBtn);
            this.panel5.Controls.Add(this.newClientBtn);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Location = new System.Drawing.Point(16, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(627, 320);
            this.panel5.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(653, 387);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Tailor and Fit | MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newClientBtn;
        private System.Windows.Forms.Button materialsBtn;
        private System.Windows.Forms.Button clientsBtn;
        private System.Windows.Forms.Button archiveBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonShowJournal;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button addRep;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonShowClients;
        private System.Windows.Forms.Button buttonAddAccount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}
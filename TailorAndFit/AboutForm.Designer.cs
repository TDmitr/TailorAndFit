namespace TailorAndFit
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.scissors_pictureBox = new System.Windows.Forms.PictureBox();
            this.logo_pictureBox = new System.Windows.Forms.PictureBox();
            this.header_label = new System.Windows.Forms.Label();
            this.general_text_label = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            this.developer_h_label = new System.Windows.Forms.Label();
            this.developer_text_label = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.Contacts = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.scissors_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // scissors_pictureBox
            // 
            this.scissors_pictureBox.Image = global::TailorAndFit.Properties.Resources.LochScissors1;
            this.scissors_pictureBox.Location = new System.Drawing.Point(84, 311);
            this.scissors_pictureBox.Name = "scissors_pictureBox";
            this.scissors_pictureBox.Size = new System.Drawing.Size(1019, 281);
            this.scissors_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scissors_pictureBox.TabIndex = 1;
            this.scissors_pictureBox.TabStop = false;
            // 
            // logo_pictureBox
            // 
            this.logo_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logo_pictureBox.Image = global::TailorAndFit.Properties.Resources.tailorfit;
            this.logo_pictureBox.Location = new System.Drawing.Point(49, 32);
            this.logo_pictureBox.Name = "logo_pictureBox";
            this.logo_pictureBox.Size = new System.Drawing.Size(225, 225);
            this.logo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_pictureBox.TabIndex = 0;
            this.logo_pictureBox.TabStop = false;
            // 
            // header_label
            // 
            this.header_label.AutoSize = true;
            this.header_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header_label.Location = new System.Drawing.Point(369, 32);
            this.header_label.Name = "header_label";
            this.header_label.Size = new System.Drawing.Size(345, 25);
            this.header_label.TabIndex = 2;
            this.header_label.Text = "Tailor and Fit Repairment v. 0.1";
            this.header_label.Click += new System.EventHandler(this.header_label_Click);
            // 
            // general_text_label
            // 
            this.general_text_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.general_text_label.Location = new System.Drawing.Point(371, 79);
            this.general_text_label.Name = "general_text_label";
            this.general_text_label.Size = new System.Drawing.Size(330, 97);
            this.general_text_label.TabIndex = 3;
            this.general_text_label.Text = "This module were created for the \"Tailor and Fit Wellworth industries\" company to" +
    " provide them with corporate data storage application by \"Max and Tanya Labs\". A" +
    "ll rights reserved (c). ";
            // 
            // close_button
            // 
            this.close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_button.Location = new System.Drawing.Point(671, 367);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(81, 36);
            this.close_button.TabIndex = 4;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // developer_h_label
            // 
            this.developer_h_label.AutoSize = true;
            this.developer_h_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.developer_h_label.Location = new System.Drawing.Point(371, 216);
            this.developer_h_label.Name = "developer_h_label";
            this.developer_h_label.Size = new System.Drawing.Size(85, 16);
            this.developer_h_label.TabIndex = 5;
            this.developer_h_label.Text = "Developer:";
            // 
            // developer_text_label
            // 
            this.developer_text_label.AutoSize = true;
            this.developer_text_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.developer_text_label.Location = new System.Drawing.Point(514, 216);
            this.developer_text_label.Name = "developer_text_label";
            this.developer_text_label.Size = new System.Drawing.Size(107, 16);
            this.developer_text_label.TabIndex = 6;
            this.developer_text_label.Text = "Tania Dmitrenko";
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year_label.Location = new System.Drawing.Point(370, 397);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(49, 20);
            this.year_label.TabIndex = 7;
            this.year_label.Text = "2016";
            this.year_label.Click += new System.EventHandler(this.year_label_Click);
            // 
            // Contacts
            // 
            this.Contacts.AutoSize = true;
            this.Contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Contacts.Location = new System.Drawing.Point(371, 241);
            this.Contacts.Name = "Contacts";
            this.Contacts.Size = new System.Drawing.Size(56, 16);
            this.Contacts.TabIndex = 8;
            this.Contacts.Text = "E-mail:";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_label.Location = new System.Drawing.Point(514, 241);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(186, 16);
            this.email_label.TabIndex = 9;
            this.email_label.TabStop = true;
            this.email_label.Text = "tanyamechanical@gmail.com";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(798, 425);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.Contacts);
            this.Controls.Add(this.year_label);
            this.Controls.Add(this.developer_text_label);
            this.Controls.Add(this.developer_h_label);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.general_text_label);
            this.Controls.Add(this.header_label);
            this.Controls.Add(this.scissors_pictureBox);
            this.Controls.Add(this.logo_pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.Text = "Tailor and Fit | About";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scissors_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo_pictureBox;
        private System.Windows.Forms.PictureBox scissors_pictureBox;
        private System.Windows.Forms.Label header_label;
        private System.Windows.Forms.Label general_text_label;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label developer_h_label;
        private System.Windows.Forms.Label developer_text_label;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Label Contacts;
        private System.Windows.Forms.LinkLabel email_label;
    }
}
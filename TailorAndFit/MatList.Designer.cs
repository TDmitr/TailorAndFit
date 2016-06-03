namespace TailorAndFit
{
    partial class MatList
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
            this.lbAccounts = new System.Windows.Forms.ListBox();
            this.lbRepairs = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAccounts
            // 
            this.lbAccounts.FormattingEnabled = true;
            this.lbAccounts.Location = new System.Drawing.Point(24, 12);
            this.lbAccounts.Name = "lbAccounts";
            this.lbAccounts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbAccounts.Size = new System.Drawing.Size(193, 199);
            this.lbAccounts.TabIndex = 0;
            this.lbAccounts.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbRepairs
            // 
            this.lbRepairs.FormattingEnabled = true;
            this.lbRepairs.Location = new System.Drawing.Point(223, 12);
            this.lbRepairs.Name = "lbRepairs";
            this.lbRepairs.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbRepairs.Size = new System.Drawing.Size(193, 199);
            this.lbRepairs.TabIndex = 1;
            this.lbRepairs.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 199);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MatList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbRepairs);
            this.Controls.Add(this.lbAccounts);
            this.Name = "MatList";
            this.Text = "MatList";
            this.Load += new System.EventHandler(this.MatList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAccounts;
        private System.Windows.Forms.ListBox lbRepairs;
        private System.Windows.Forms.Button button1;
    }
}
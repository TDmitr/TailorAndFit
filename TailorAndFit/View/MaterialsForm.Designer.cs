﻿namespace TailorAndFit
{
    partial class MaterialsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialsForm));
            this.lbMaterials = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMaterials
            // 
            this.lbMaterials.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbMaterials.FormattingEnabled = true;
            this.lbMaterials.ItemHeight = 20;
            this.lbMaterials.Location = new System.Drawing.Point(24, 58);
            this.lbMaterials.Name = "lbMaterials";
            this.lbMaterials.Size = new System.Drawing.Size(204, 264);
            this.lbMaterials.TabIndex = 1;
            this.lbMaterials.SelectedIndexChanged += new System.EventHandler(this.lbMaterials_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.newItemToolStripMenuItem,
            this.editItemToolStripMenuItem,
            this.deleteItemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(622, 28);
            this.menuStrip1.TabIndex = 55;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.dataToolStripMenuItem.Image = global::TailorAndFit.Properties.Resources._1459704994_user_manage;
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Image = global::TailorAndFit.Properties.Resources.open_file_icon;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.importToolStripMenuItem.Text = "Open";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(126, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::TailorAndFit.Properties.Resources.Save_icon;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::TailorAndFit.Properties.Resources.save_all_icon;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // newItemToolStripMenuItem
            // 
            this.newItemToolStripMenuItem.Image = global::TailorAndFit.Properties.Resources._1459711453_folder_add;
            this.newItemToolStripMenuItem.Name = "newItemToolStripMenuItem";
            this.newItemToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.newItemToolStripMenuItem.Text = "New Item";
            this.newItemToolStripMenuItem.Click += new System.EventHandler(this.newItemToolStripMenuItem_Click);
            // 
            // editItemToolStripMenuItem
            // 
            this.editItemToolStripMenuItem.Image = global::TailorAndFit.Properties.Resources._1459711403_folder_search;
            this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            this.editItemToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.editItemToolStripMenuItem.Text = "Edit Item";
            this.editItemToolStripMenuItem.Click += new System.EventHandler(this.editItemToolStripMenuItem_Click);
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Image = global::TailorAndFit.Properties.Resources._1459704887_notification_error;
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.deleteItemToolStripMenuItem.Text = "Delete Item";
            this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.deleteItemToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.textBox_Description);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox_Name);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(245, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 264);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Location = new System.Drawing.Point(54, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 51);
            this.panel1.TabIndex = 64;
            this.panel1.Visible = false;
            // 
            // buttonClear
            // 
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(5, 6);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(123, 35);
            this.buttonClear.TabIndex = 54;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(134, 6);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(157, 35);
            this.buttonSave.TabIndex = 53;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(134, 7);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(157, 35);
            this.buttonAdd.TabIndex = 56;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(142, 102);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.ReadOnly = true;
            this.textBox_Description.Size = new System.Drawing.Size(208, 92);
            this.textBox_Description.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Description: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(208, 26);
            this.textBox1.TabIndex = 61;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(142, 38);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.ReadOnly = true;
            this.textBox_Name.Size = new System.Drawing.Size(208, 26);
            this.textBox_Name.TabIndex = 60;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 44);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 20);
            this.nameLabel.TabIndex = 58;
            this.nameLabel.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Price: ";
            // 
            // MaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(622, 343);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbMaterials);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MaterialsForm";
            this.Text = "TailorAndFit | Materials";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MaterialsForm_FormClosing);
            this.Load += new System.EventHandler(this.AddMaterial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbMaterials;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    }
}
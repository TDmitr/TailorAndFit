﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TailorAndFit
{
    public partial class MaterialsForm : Form
    {
        private string file = "dataMaterials";

        public MaterialsForm()
        {
            InitializeComponent();
        }

        private void AddMaterial_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void lbMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenTextBox(false);
            //Guid id = (Guid) lbMaterials.SelectedValue;
            Material material = (Material) lbMaterials.SelectedItem;
            textBox_Name.Text = material.Name;
            textBox_Description.Text = material.Description;
            textBox1.Text = material.Price.ToString();
        }

        private void newItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controling.ClearTextBoxes(groupBox1);
            OpenTextBox(true);
            buttonSave.Visible = false;
            buttonAdd.Visible = true;
        }

        private void OpenTextBox(bool b)
        {
            textBox_Description.ReadOnly = !b;
            textBox_Name.ReadOnly = !b;
            textBox1.ReadOnly = !b;
            panel1.Visible = b;
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (lbMaterials.Items.Count != 0)
            {
                OpenTextBox(true);
                buttonSave.Visible = true;
                buttonAdd.Visible = false;
            }
            else
            {
                OpenTextBox(false);
            }
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbMaterials.Items.Count != 0)
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to delete the Item?", "Are you sure?",
                    MessageBoxButtons.YesNo);

                OpenTextBox(false);

                if (dialog == DialogResult.Yes)
                {
                    if (lbMaterials.Items.Count != 0)
                    {
                        // Guid id = (Guid) lbMaterials.SelectedValue;
                        Material material = (Material) lbMaterials.SelectedItem;
                        Material.Items.Remove(material.Id);
                        RefreshTable();
                    }
                }
            }
            else
            {
                MessageBox.Show("You do not have items to delete");
            }

        }



        private void RefreshTable()
        {
            //lbMaterials.Items.Clear();
            lbMaterials.DataSource = Material.Items.Values.ToList();
            lbMaterials.DisplayMember = "Name";
            lbMaterials.ValueMember = "Id";

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (Valdation())
            {
                new Material(textBox_Name.Text, textBox_Description.Text, Double.Parse(textBox1.Text));
                RefreshTable();
                MessageBox.Show("Material is added :)");

            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Valdation())
            {
                OpenTextBox(false);
                Guid id = (Guid) lbMaterials.SelectedValue;
                Material material = (Material) lbMaterials.SelectedItem;
                material.Name = textBox_Name.Text;
                material.Description = textBox_Description.Text;
                material.Price = Double.Parse(textBox1.Text);
                RefreshTable();
                MessageBox.Show("Material is edited");
            }
        }

        private bool Valdation()
        {
            if (textBox_Name.Text == string.Empty)
            {
                MessageBox.Show("The Name field is not filled");
                return false;
            }
            try
            {
                Double.Parse(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid price value");
                return false;
            }
            return true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Controling.ClearTextBoxes(groupBox1);
        }

        private void MaterialsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save changes?", "Question",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                ;
            if (result == DialogResult.Yes)
            {
                Material.Serialize(file);
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                // f.ShowDialog();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    file = f.FileName;
                    Material.Items = Material.Deserialize(file);
                    RefreshTable();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Oops! Something wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Material.Serialize(file);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                file = f.FileName;
                Material.Serialize(file);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
      

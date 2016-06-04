using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TailorAndFit
{
    public partial class RepGroupForm : Form
    {
        public RepGroupForm()
        {
            InitializeComponent();
        }

        private string file = "dataGroup.bin";

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void RepGroupForm_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void RefreshTable()
        {
            //lbMaterials.Items.Clear();
            lbGroup.DataSource = RepGroup.Items.Values.ToList();
            lbGroup.DisplayMember = "Name";
            lbGroup.ValueMember = "Id";

        }
        private void OpenTextBox(bool b)
        {
            textBox_Description.ReadOnly = !b;
            textBox_Name.ReadOnly = !b;
            textBox1.ReadOnly = !b;
           // comboBoxClothes.Enabled = b;
            panel1.Visible = b;
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

        private void lbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenTextBox(false);
            //Guid id = (Guid)lbGroup.SelectedValue;
            RepGroup group = (RepGroup)lbGroup.SelectedItem;
            textBox_Name.Text = group.Name;
            textBox_Description.Text = group.Description;
            textBox1.Text = group.Price.ToString();
           // comboBoxClothes.Text = group.ClothesKind.Name;

        }

        private void newItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox_Description.Text = string.Empty;
            textBox_Name.Text = string.Empty;
            OpenTextBox(true);
            buttonSave.Visible = false;
            buttonAdd.Visible = true;

            

        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbGroup.Items.Count != 0)
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
            if (lbGroup.Items.Count != 0)
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to delete the Item?", "Are you sure?",
                    MessageBoxButtons.YesNo);

                OpenTextBox(false);

                if (dialog == DialogResult.Yes)
                {
                    if (lbGroup.Items.Count != 0)
                    {
                        //Guid id = (Guid)lbGroup.SelectedValue;
                        RepGroup group = (RepGroup)lbGroup.SelectedItem;
                        RepGroup.Items.Remove(group.Id);
                        RefreshTable();
                    }
                }
            }
            else
            {
                MessageBox.Show("You do not have items to delete");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Valdation())
            {
                OpenTextBox(false);
                //Guid id = (Guid)lbGroup.SelectedValue;
                RepGroup group = (RepGroup)lbGroup.SelectedItem;
                group.Name = textBox_Name.Text;
                group.Description = textBox_Description.Text;
                group.Price = Double.Parse(textBox1.Text);
                RefreshTable();
                MessageBox.Show("Group is edited");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (Valdation())
            {
                //Guid _id = (Guid)comboBoxClothes.SelectedValue;
                //ClothesKind clothes = (ClothesKind)comboBoxClothes.SelectedItem;
                new RepGroup(textBox_Name.Text, textBox_Description.Text, Double.Parse(textBox1.Text));
                RefreshTable();
                MessageBox.Show("Group is added", "Successful", MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Controling.ClearTextBoxes(groupBox1);
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
                    RepGroup.Items = RepGroup.Deserialize(file);
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
            RepGroup.Serialize(file);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                file = f.FileName;
                RepGroup.Serialize(file);
            }
        }
    }
}

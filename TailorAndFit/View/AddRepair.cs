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
    public partial class AddRepair : Form
    {

        private Repair newRepair;

        public AddRepair()
        {
            InitializeComponent();
        }

        private void AddRepair_Load(object sender, EventArgs e)
        {
            //new Material("Knight","Description");
            //new Material("Name", "Desc");
            comboBox_Clothes.DataSource = ClothesKind.Items.Values.ToList();
            comboBox_Types.DataSource = RepGroup.Items.Values.ToList();
            comboBox_Accounts.DataSource = Account.Items.Values.ToList();
            comboBox_Accounts.DisplayMember = "Name";
            comboBox_Accounts.ValueMember = "Id";

            lbAll.DataSource = Material.Items.Values.ToList();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {

            //new Repair(textBox_Name.Text, DateTime.Today, textBox_Description.Text);

        }



        private void lbAll_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            lbChosen.Items.Clear();
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            int count = lbChosen.Items.Count;
            if (count != 0)
            {
                lbChosen.Items.RemoveAt(count - 1);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (lbAll.Items.Count != 0)
                lbChosen.Items.Add(lbAll.SelectedItem);
            else
                MessageBox.Show("Error! Storage has no materials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                for (int i = 0; i < lbChosen.Items.Count; i++)
                {
                    Consist c = new Consist((Material) lbChosen.Items[i], newRepair);
                }
                MessageBox.Show("Repair is added", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Not all fields are filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validation()
        {
            if (textBox_Name.Text != string.Empty &&
                comboBox_Accounts.SelectedItem != null &&
                comboBox_Clothes.SelectedItem != null &&
                comboBox_Types.SelectedItem != null)
                return true;
            return false;
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                Account account = (Account) comboBox_Accounts.SelectedItem;
                ClothesKind clothes = (ClothesKind) comboBox_Clothes.SelectedItem;
                RepGroup group = (RepGroup) comboBox_Types.SelectedItem;
                newRepair = new Repair(textBox_Name.Text, DateTime.Now, textBox_Description.Text, account,group,clothes);
                tabControl1.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("Not all fields are filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }
    }


}

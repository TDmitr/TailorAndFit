using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace TailorAndFit
{
    public partial class ShowJournal : Form
    {
        private IEnumerable<Repair> query;
        private string file = "dataRepairs.bin";
        private string consist = "dataConsist.bin";
        private string materials = "dataMaterials.bin";


        public ShowJournal()
        {
            InitializeComponent();
        }

        private void RefreshTable()
        {
            dataGridViewRep.AutoGenerateColumns = false;

            query = from item in Repair.Items.Values.ToList()
                    where item.IsDone == false
                    select item;

            dataGridViewRep.DataSource = query.ToList();

            
            //dataGridViewRep.DataSource = Repair.Items.Values.ToList();
        }

        private void Try()
        {
            Account a =new Account("Tania", "Dmitrenko", DateTime.Today, "email","+38050");
            ClothesKind c = new ClothesKind("Skirt", "", 32);
            RepGroup r = new RepGroup("Group");
            Material m = new Material("Button", "", 32);
            Material m1 = new Material("Button", "", 32);
            Material m2 = new Material("Button", "", 32);
            Repair rep = new Repair("Rep1", DateTime.Now, "",a,r,c);
            new Consist(m, rep);
            new Consist(m1, rep);
            new Consist(m2, rep);
        }

        private void ShowJournal_Load(object sender, EventArgs e)
        {
            
            
            comboBoxAcc.DataSource = Account.Items.Values.ToList();
            comboBoxAcc.DisplayMember = "Name";
            comboBoxAcc.ValueMember = "Id";

            comboBoxMat.DataSource = Material.Items.Values.ToList();
            comboBoxMat.DisplayMember = "Name";
            comboBoxMat.ValueMember = "Id";

            comboBoxGroup.DataSource = RepGroup.Items.Values.ToList();
            comboBoxGroup.DisplayMember = "Name";
            comboBoxGroup.ValueMember = "Id";

            comboBoxClothes.DataSource = ClothesKind.Items.Values.ToList();
            comboBoxClothes.DisplayMember = "Name";
            comboBoxClothes.ValueMember = "Id";

            RefreshTable();
        }


        private void typeOfClothesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelClothes.BringToFront();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAccount.BringToFront();
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelGroup.BringToFront();
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDate.BringToFront();
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelName.BringToFront();
        }

        private void materialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMaterial.BringToFront();
        }

        private void priceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPricepanelPrice.BringToFront();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (textBoxPrice.Text != string.Empty)
            {
                query = from item in Repair.Items.Values.ToList()
                    where item.Price == Double.Parse(textBoxPrice.Text) && item.IsDone == false
                        select item;

                dataGridViewRep.DataSource = query.ToList();
            }
            else MessageBox.Show("The field is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonDate_Click(object sender, EventArgs e)
        {
            query = from item in Repair.Items.Values.ToList()
                where item.Date > dateTimePicker2.Value && item.Date < dateTimePicker1.Value && item.IsDone == false
                    select item;
            dataGridViewRep.DataSource = query.ToList();
        }

        private void buttonAcc_Click(object sender, EventArgs e)
        {
            Account account = (Account) comboBoxAcc.SelectedItem;
            query = from item in Repair.Items.Values.ToList()
                where item.Account == account && item.IsDone == false
                    select item;
            dataGridViewRep.DataSource = query.ToList();
        }

        private void buttonMat_Click(object sender, EventArgs e)
        {
            Material mat = (Material) comboBoxMat.SelectedItem;
            query = from item in Repair.Items.Values.ToList()
                where item.Material.Contains(mat) && item.IsDone == false
                    select item;
            dataGridViewRep.DataSource = query.ToList();
        }

        private void buttonGroup_Click(object sender, EventArgs e)
        {
            RepGroup rep = (RepGroup) comboBoxGroup.SelectedItem;
            query = from item in Repair.Items.Values.ToList()
                where item.RepGroup == rep && item.IsDone == false
                    select item;
            dataGridViewRep.DataSource = query.ToList();

        }

        private void buttonClothes_Click(object sender, EventArgs e)
        {
            ClothesKind rep = (ClothesKind)comboBoxClothes.SelectedItem;
            query = from item in Repair.Items.Values.ToList()
                    where item.Clothes == rep && item.IsDone == false
                    select item;
            dataGridViewRep.DataSource = query.ToList();
        }

        private void buttonName_Click(object sender, EventArgs e)
        {
            query = from item in Repair.Items.Values.ToList()
                    where item.Name == textBoxName.Text && item.IsDone == false
                    select item;
            dataGridViewRep.DataSource = query.ToList();
        }

        private void dataGridViewRep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void showInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridViewRep.RowCount != 0)
            {
                textBoxMaterials.Text = string.Empty;
                Repair r = (Repair) dataGridViewRep.CurrentRow.DataBoundItem;
                textBoxRepName.Text = r.Name;
                textBoxDescription.Text = r.Description;
                textBoxPr.Text = r.Price.ToString();
                textBoxRepAcc.Text = r.Account.Name;
                textBoxRepCl.Text = r.Clothes.Name;
                textBoxRepDate.Text = r.Date.ToShortDateString();
                textBoxRepGr.Text = r.RepGroup.Name;
                foreach (var item in r.Material)
                {
                    textBoxMaterials.Text += item.Name + "; ";
                }
            }
            else MessageBox.Show("You do not have items!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void addRepairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRepair add = new AddRepair();
            add.ShowDialog();
            RefreshTable();
        }

        private void addToArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewRep.RowCount != 0)
            {
                Repair r = (Repair)dataGridViewRep.CurrentRow.DataBoundItem;
                r.IsDone = true;
                MessageBox.Show("The item is added to Archive", "Added",MessageBoxButtons.OK,MessageBoxIcon.Information);
                RefreshTable();
            }
            else MessageBox.Show("You do not have items!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewRep.RowCount != 0)
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to delete the Item?", "Are you sure?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    Repair r = (Repair) dataGridViewRep.CurrentRow.DataBoundItem;
                    Repair.Items.Remove(r.Id);
                    RefreshTable();
                }
            }
            else
                MessageBox.Show("You do not have items to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.Title = "Repair File";
                // f.ShowDialog();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    file = f.FileName;
                    Repair.Items = Repair.Deserialize(file);
                    // RefreshTable();

                    OpenFileDialog f2 = new OpenFileDialog();
                    f2.Title = "Consist File";
                    // f.ShowDialog();
                    if (f2.ShowDialog() == DialogResult.OK)
                    {
                        consist = f2.FileName;
                        Consist.Items = Consist.Deserialize(consist);
                        //RefreshTable();

                        OpenFileDialog f3 = new OpenFileDialog();
                        f3.Title = "Materials File";
                        // f.ShowDialog();
                        if (f3.ShowDialog() == DialogResult.OK)
                        {
                            consist = f3.FileName;
                            Material.Items = Material.Deserialize(materials);
                            //RefreshTable();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Oops! Something wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshTable();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Repair.Serialize(file);
            Consist.Serialize(consist);
            Material.Serialize(materials);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Title = "Repair File";
            if (f.ShowDialog() == DialogResult.OK)
            {
                file = f.FileName;
                Repair.Serialize(file);

                OpenFileDialog f2 = new OpenFileDialog();
                f2.Title = "Materials in Repair File";
                if (f2.ShowDialog() == DialogResult.OK)
                {
                    //f2.ShowDialog();
                    consist = f2.FileName;
                    Consist.Serialize(consist);
                }
            }

        }
    }
}

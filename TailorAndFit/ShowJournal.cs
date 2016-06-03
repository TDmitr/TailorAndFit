using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TailorAndFit.Data;

namespace TailorAndFit
{
    public partial class ShowJournal : Form
    {
        private IEnumerable<Repair> query;
       
        public ShowJournal()
        {
            InitializeComponent();
        }

        private void RefreshTable()
        {

            query = from item in Repair.Items.Values.ToList()
                    where item.IsDone == false
                    select item;

            dataGridViewRep.DataSource = query.ToList();
            
            //dataGridViewRep.DataSource = Repair.Items.Values.ToList();
        }

        private void Try()
        {
            Account a =new Account("Tania Dmitrenko");
            ClothesKind c = new ClothesKind("Skirt", "", 32);
            RepGroup r = new RepGroup("Group");
            Material m = new Material("Button", "", 32);
            Material m1 = new Material("Button", "", 32);
            Material m2 = new Material("Button", "", 32);
            Repair rep = new Repair("Rep1", DateTime.Now, "",a,r,c);
            new Consist(m, rep);
            new Consist(m1, rep);
            new Consist(m2, rep);
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SerializableDictionary<Guid, Account>));
                using (FileStream fs = new FileStream("test344.xml", FileMode.CreateNew))
                {
                    xmlSerializer.Serialize(fs, Account.Items);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());

            }

            //try
            //{
            //    XmlSerializer xml = new XmlSerializer(typeof(Account));
            //    using (var fStream = new FileStream("./SuperHumanInfo.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            //    {
            //        xml.Serialize(fStream, a);
            //    }
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.ToString());
            //}


        }

        private void ShowJournal_Load(object sender, EventArgs e)
        {
            Try();
            dataGridViewRep.AutoGenerateColumns = false;
            RefreshTable();
            
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
    }
}

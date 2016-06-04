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
    public partial class Archive : Form
    {
        private IEnumerable<Repair> query;
        private string file = "dataRepairs.bin";
        private string consist = "dataConsist.bin";
        private string materials = "dataMaterials.bin";

        public Archive()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void RefreshTable()
        {
            dataGridViewRep.AutoGenerateColumns = false;
            query = from item in Repair.Items.Values.ToList()
                where item.IsDone == true
                select item;
            dataGridViewRep.DataSource = query.ToList();

        }

        private void Archive_Load(object sender, EventArgs e)
        {
            RefreshTable();
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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewRep.RowCount != 0)
            {
                Repair r = (Repair) dataGridViewRep.CurrentRow.DataBoundItem;
                Repair.Items.Remove(r.Id);
                MessageBox.Show("Item is deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshTable();
            }
            else MessageBox.Show("You do not have items!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            query = from item in Repair.Items.Values.ToList()
                where item.Id.ToString() == textBox1.Text
                select item;
            dataGridViewRep.DataSource = query.ToList();
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
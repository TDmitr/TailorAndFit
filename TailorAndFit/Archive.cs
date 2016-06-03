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
                where item.IsDone == false
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
    }
}
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
    public partial class MatList : Form
    {
        public MatList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Repairing((Account)lbAccounts.SelectedItem, (Repair)lbRepairs.SelectedItem);


        }

        private void MatList_Load(object sender, EventArgs e)
        {
            Account g1 = new Account("IT-42");
            Account g2 = new Account("IT-41") ;

            //Repair s1 = new Repair("Math");
            //Repair s2 = new Repair("FP");
           // Repair s3 = new Repair("OOP");

            //new Repairing(g1, s1);
            //new Repairing(g1, s3);
            //new Repairing(g2, s2);
            //new Repairing(g2, s3);

            lbAccounts.DataSource = Account.Items.Values.ToList();
            lbRepairs.DataSource = Repair.Items.Values.ToList();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbRepairs.SelectedItems.Clear();
            foreach (var subj in ((Account)lbAccounts.SelectedItem).Subjects)
            {
                lbRepairs.SelectedItems.Add(subj);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

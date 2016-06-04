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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void newClientBtn_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();

        }

        private void clientsBtn_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();

        }

        private void materialsBtn_Click(object sender, EventArgs e)
        {
            MaterialsForm s = new MaterialsForm();
            s.ShowDialog();
        }

        private void archiveBtn_Click(object sender, EventArgs e)
        {
            Archive a = new Archive();
            a.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonShowJournal_Click(object sender, EventArgs e)
        {
            ShowJournal show = new ShowJournal();
            show.ShowDialog();
        }

        private void buttonAddAccount_Click(object sender, EventArgs e)
        {
            AddAccount add = new AddAccount();
            add.ShowDialog();
        }

        private void addRep_Click(object sender, EventArgs e)
        {
            AddRepair add = new AddRepair();
            add.ShowDialog();

            
        }

        private void buttonShowClients_Click(object sender, EventArgs e)
        {
            Accounts acc = new Accounts();
            acc.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RepGroupForm r = new RepGroupForm();
            r.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClothesFormcs c = new ClothesFormcs();
            c.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm a = new AboutForm();
            a.ShowDialog();
        }
    }
}

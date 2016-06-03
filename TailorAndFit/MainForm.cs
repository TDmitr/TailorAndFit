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

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void newClientBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

        }

        private void clientsBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void materialsBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
        }

        private void archiveBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
            panel3.Visible = true;
        }

        private void опрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            MaterialsForm m = new MaterialsForm();
            m.ShowDialog();
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

        private void button6_Click(object sender, EventArgs e)
        {
            Archive a = new Archive();
            a.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Security.Cryptography;

namespace TailorAndFit
{
    public partial class Accounts : Form
    {
        private IEnumerable<Account> query; 
        public Accounts()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RefreshTable()
        {
            dataGridAcc.AutoGenerateColumns = false;
            dataGridAcc.DataSource = Account.Items.Values.ToList();
        }


        private void Accounts_Load(object sender, EventArgs e)
        {
             new Account("Tania", "Dmitrenko", DateTime.Today, "tanya", "0234");
             new Account("Nastua", "Dmitrenko", DateTime.Today, "tanya", "0234");
             new Account("Tania", "Sopilkova", DateTime.Today, "tanya", "0234");
             RefreshTable();
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void IsEditable(bool isedit)
        {
            textBoxRepMail.ReadOnly = !isedit;
            textBoxRepMob.ReadOnly = !isedit;
            buttonSave.Visible = isedit;

            if (isedit)
            {
                textBoxRepMail.BackColor = Color.White;
                textBoxRepMob.BackColor = Color.White;
            }
            else
            {
                textBoxRepMail.BackColor = Color.WhiteSmoke;
                textBoxRepMob.BackColor = Color.WhiteSmoke;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAccount(true);
            
        }

        private void addRepairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsEditable(false);
            AddAccount a = new AddAccount();
            a.ShowDialog();
            RefreshTable();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            IsEditable(false);
            RefreshTable();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Account editAccount = (Account) dataGridAcc.CurrentRow.DataBoundItem;
            editAccount.Email = textBoxRepMail.Text;
            editAccount.MobilePhone = textBoxRepMob.Text;
            MessageBox.Show("The Account " + editAccount.Name + " was edited", "Successful", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            IsEditable(false);
            RefreshTable();
        }

        private void showInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {  
            ShowAccount(false);
        }

        private void ShowAccount(bool isEdit)
        {
            IsEditable(isEdit);
            if (dataGridAcc.RowCount != 0)
            {
                Account account = (Account)dataGridAcc.CurrentRow.DataBoundItem;
                textBoxRepName.Text = account.PersonName;
                textBoxSurname.Text = account.PersonSurname;
                textBoxAccD.Text = account.AccountDate.ToShortDateString();
                textBoxBday.Text = account.BirthDate.ToShortDateString();
                textBoxRepMail.Text = account.Email;
                textBoxRepMob.Text = account.MobilePhone;
                textBoxId.Text = account.Id.ToString();
            }
            else
            {
                IsEditable(false);
                MessageBox.Show("You do not have items!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonFullName_Click(object sender, EventArgs e)
        {
            query = from item in Account.Items.Values
                where item.Name == textBoxFullName.Text
                select item;
            dataGridAcc.DataSource = query.ToList();
        }

        private void buttonMob_Click(object sender, EventArgs e)
        {
            query = from item in Account.Items.Values
                    where item.MobilePhone == textBoxFMob.Text
                    select item;
            dataGridAcc.DataSource = query.ToList();
        }

        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsEditable(false);
        }

        private void panelFullName_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonEmail_Click(object sender, EventArgs e)
        {
            query = from item in Account.Items.Values
                    where item.Email == textBoxFEmail.Text
                    select item;
            dataGridAcc.DataSource = query.ToList();
        }

        private void buttonSur_Click(object sender, EventArgs e)
        {
            query = from item in Account.Items.Values
                    where item.PersonSurname == textBoxFSur.Text
                    select item;
            dataGridAcc.DataSource = query.ToList();
        }

        private void buttonName_Click(object sender, EventArgs e)
        {
            query = from item in Account.Items.Values
                    where item.PersonName == textBoxName.Text
                    select item;
            dataGridAcc.DataSource = query.ToList();
        }

        private void buttonFAd_Click(object sender, EventArgs e)
        {
            query = from item in Account.Items.Values.ToList()
                    where item.AccountDate > dateTimePickerAd1.Value && item.AccountDate < dateTimePickerFAd2.Value 
                    select item;
            dataGridAcc.DataSource = query.ToList();
        }

        private void buttonFBd_Click(object sender, EventArgs e)
        {
            query = from item in Account.Items.Values.ToList()
                    where item.BirthDate > dateTimePickerbd1.Value && item.BirthDate < dateTimePickerbd2.Value
                    select item;
            dataGridAcc.DataSource = query.ToList();
        }

        private void fullNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFullName.BringToFront();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelName.BringToFront();
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFSur.BringToFront();
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelEmail.BringToFront();
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFMob.BringToFront();
        }

        private void materialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFBd.BringToFront();
        }

        private void typeOfClothesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFAd.BringToFront();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsEditable(false);
            if (dataGridAcc.RowCount != 0)
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to delete the Item?", "Are you sure?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    Account account = (Account) dataGridAcc.CurrentRow.DataBoundItem;
                    Account.Items.Remove(account.Id);
                    RefreshTable();
                }
                else
                    MessageBox.Show("You do not have items to delete!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);

            }
            else
                MessageBox.Show("You do not have items!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            
        }
    }
}

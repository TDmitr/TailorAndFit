using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace TailorAndFit
{
    public partial class Accounts : Form
    {
        private string file = "dataAccount.bin";
        //private IEnumerable<Account> query; 
        public Accounts()
        {
            InitializeComponent();
        }


        private void Accounts_Load(object sender, EventArgs e)
        {
            IControl<Account>.RefreshTable(dataGridAcc);          
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
            IControl<Account>.RefreshTable(dataGridAcc);
        }


        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            IsEditable(false);
            IControl<Account>.RefreshTable(dataGridAcc);
        }
        

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Account editAccount = (Account) dataGridAcc.CurrentRow.DataBoundItem;
            editAccount.Email = textBoxRepMail.Text;
            editAccount.MobilePhone = textBoxRepMob.Text;
            MessageBox.Show("The Account " + editAccount.Name + " was edited", "Successful", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            IsEditable(false);
            IControl<Account>.RefreshTable(dataGridAcc);
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
            dataGridAcc.DataSource = Account.SearchByName(textBoxFullName.Text).ToList();
        }


        private void buttonMob_Click(object sender, EventArgs e)
        {
            dataGridAcc.DataSource = Account.SearchByPhone(textBoxFMob.Text).ToList();
        }


        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsEditable(false);
        }


        private void buttonEmail_Click(object sender, EventArgs e)
        {
            dataGridAcc.DataSource = Account.SearchByEmail(textBoxFEmail.Text).ToList();
        }


        private void buttonSur_Click(object sender, EventArgs e)
        {
            dataGridAcc.DataSource = Account.SearchBySurname(textBoxFSur.Text).ToList();
        }


        private void buttonName_Click(object sender, EventArgs e)
        {
            dataGridAcc.DataSource = Account.SearchByPersonName(textBoxName.Text).ToList();
        }


        private void buttonFAd_Click(object sender, EventArgs e)
        {
            dataGridAcc.DataSource = Account.SearchByAccDate(dateTimePickerAd1.Value, dateTimePickerFAd2.Value).ToList();
        }


        private void buttonFBd_Click(object sender, EventArgs e)
        {
            dataGridAcc.DataSource = Account.SearchByAccDate(dateTimePickerbd1.Value, dateTimePickerbd2.Value).ToList();
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
                    IControl<Account>.RefreshTable(dataGridAcc);
                }
                else
                    MessageBox.Show("You do not have items to delete!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);

            }
            else
                MessageBox.Show("You do not have items!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account.Serialize(file);
        }


        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IControl<Account>.Export(file, Account.Items);
        }


        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account.Items = IControl<Account>.Import(file, Account.Items);
            IControl<Account>.RefreshTable(dataGridAcc);
        }
    }
}

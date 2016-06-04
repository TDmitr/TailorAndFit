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
    public partial class AddAccount : Form
    {

        private bool  Validation()
        {
            if (textBox_Name.Text == string.Empty && textBox_Surname.Text == string.Empty)
            {
                MessageBox.Show("You have empty fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            return true;
        }

        public AddAccount()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                new Account(textBox_Name.Text, textBox_Surname.Text, dateTime.Value.Date, textBox_email.Text, textBox_mobile.Text);
                MessageBox.Show("Account is added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxAccount_Enter(object sender, EventArgs e)
        {

        }
    }
}

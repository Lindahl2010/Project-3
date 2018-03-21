using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3
{
    public partial class DunwoodyRH : Form
    {
        public DunwoodyRH()
        {
            InitializeComponent();
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            passwordBox.MaxLength = 8;
            passwordBox.PasswordChar = '*'; 
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == "" && passwordBox.Text == "")
            {
                MessageBox.Show("Please enter username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (usernameBox.Text == "home" && passwordBox.Text == "1234")
            {
                this.Hide();
                RD rdWindow = new RD();
                rdWindow.Show();
            }
            else if (usernameBox.Text == "home" && passwordBox.Text != "1234")
            {
                MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (usernameBox.Text != "home" && passwordBox.Text == "1234")
            {
                MessageBox.Show("Wrong Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Wrong Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

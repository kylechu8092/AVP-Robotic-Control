using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
            InitalizeFields();
        }

        public void InitalizeFields()
        {
            usernameTxtBox.Text = "Enter username";
            passwordTxtBox.Text = "Enter password";
            usernameTxtBox.ForeColor = Color.Gray;
            passwordTxtBox.ForeColor = Color.Gray;
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void usernameTxtBox_Enter(object sender, EventArgs e)
        {
            if (usernameTxtBox.Text == "Enter username")
            {
                usernameTxtBox.Text = string.Empty;
                usernameTxtBox.ForeColor = Color.Black;
            }
        }

        private void usernameTxtBox_Leave(object sender, EventArgs e)
        {
            if (usernameTxtBox.Text == "")
            {
                usernameTxtBox.ForeColor = Color.Gray;
                usernameTxtBox.Text = "Enter username";
            }
        }

        private void passwordTxtBox_Enter(object sender, EventArgs e)
        {
            if (passwordTxtBox.Text == "Enter password")
            {
                passwordTxtBox.Text = string.Empty;
                passwordTxtBox.ForeColor = Color.Black;
                passwordTxtBox.PasswordChar = '*';
            }
        }

        private void passwordTxtBox_Leave(object sender, EventArgs e)
        {
            if (passwordTxtBox.Text == "")
            {
                passwordTxtBox.ForeColor = Color.Gray;
                passwordTxtBox.Text = "Enter password";
                passwordTxtBox.PasswordChar = '\0';
            }
        }
    }


    

    
}

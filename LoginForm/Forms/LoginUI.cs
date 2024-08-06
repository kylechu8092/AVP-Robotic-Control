using LoginForm.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManagement;

namespace LoginForm
{
    public partial class LoginUI : Form
    {
        userAuthentication userAuthentication;
        public LoginUI()
        {
            InitializeComponent();
            InitalizeFields();
            createUserAuth();
        }

        public void InitalizeFields()
        {
            usernameTxtBox.Text = "Enter username";
            passwordTxtBox.Text = "Enter password";
            usernameTxtBox.ForeColor = Color.Gray;
            passwordTxtBox.ForeColor = Color.Gray;
        }

        public void createUserAuth()
        {
            try
            {
                userAuthentication = new userAuthentication();
            }
            catch { }
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

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (usernameTxtBox.Text == string.Empty || passwordTxtBox.Text == string.Empty)
                {
                    MessageBox.Show("Username and password fields are empty");
                }
                else
                {
                    if (userAuthentication.isAuthenticated(usernameTxtBox.Text, passwordTxtBox.Text))
                    {
                        MainUI mainUI = new MainUI();
                        mainUI.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username and password not found");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }


    

    
}

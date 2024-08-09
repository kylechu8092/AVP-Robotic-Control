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

namespace LoginForm.ServiceForms
{
    public partial class UserControlComponent : UserControl
    {
        UserDTO currUser;
        public UserControlComponent(UserDTO user)
        {
            currUser = user;
            InitializeComponent();
            setFields();
        }

        public void setFields()
        {
            usernameTxt.Text = currUser.userName;
            idTxt.Text = currUser.Id.ToString();
            passwordTxt.Text = currUser.password;
            isActiveTxt.Text = currUser.isActive.ToString();
            Role.Text = currUser.role;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {

            } catch (Exception ex) 
            {
            
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManagement.Admin_Control;

namespace LoginForm.ServiceForms
{
    public partial class AddUserForm : UserControl
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddUser addUser = new UserManagement.Admin_Control.AddUser();
                bool active = bool.Parse(isActiveTxt.Text);
                addUser.addUser(Int32.Parse(idTxt.Text), usernameTxt.Text, passwordTxt.Text, active, Role.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

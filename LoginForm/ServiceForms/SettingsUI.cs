using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm.ServiceForms
{
    public partial class SettingsUI : UserControl
    {
        public SettingsUI()
        {
            InitializeComponent();
            InitializeUserList();
            InitializeAddUser();
        }

        public void InitializeUserList()
        {
            displayPanelUser.Controls.Clear();
            for (int i = 0; i < 20; i++)
            {
                displayPanelUser.Controls.Add(new UserControlComponent(new UserManagement.UserDTO()));
            }
        }

        public void InitializeAddUser()
        {
            addUserPanel.Controls.Add(new AddUserForm());
        }

        private void SettingsUI_Load(object sender, EventArgs e)
        {

        }
    }
}

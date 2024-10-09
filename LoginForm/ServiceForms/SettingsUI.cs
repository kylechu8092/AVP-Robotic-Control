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
using UserManagement.Admin_Control;

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
            try
            {
                List<UserDTO> currUsers = new UserToDTOArray().getUserDTOArray();
                foreach (UserDTO userDTO in currUsers)
                {
                    UserControlComponent u = new UserControlComponent(userDTO);
                    flowLayoutPanel1.Controls.Add(u);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void InitializeAddUser()
        {
            addUserPanel.Controls.Add(new AddUserForm());
        }


        private void SettingsUI_Load(object sender, EventArgs e)
        {

        }

        private void addUserPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

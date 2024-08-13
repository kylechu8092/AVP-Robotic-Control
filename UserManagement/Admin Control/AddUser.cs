using DatabaseLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Admin_Control
{
    public class AddUser
    {
        AdminRepository admin = new AdminRepository();

        public AddUser() { }

        public void addUser(int id, string username, string password, Boolean isActive, string role)
        {
            try
            {
                admin.addNewUser(id, username, password, isActive, role);
            }
            catch { }
        }
    }
}
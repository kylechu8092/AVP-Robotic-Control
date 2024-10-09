using DatabaseLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Admin_Control
{
    public class DeleteUser
    {
        AdminRepository admin = new AdminRepository();

        public DeleteUser() { }

        public void deleteUser(int ID)
        {
            try
            {
                admin.deleteOldUser(ID);
            }
            catch (Exception ex) { }
        }
    }
}

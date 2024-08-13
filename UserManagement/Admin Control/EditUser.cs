using DatabaseLayer;
using DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Admin_Control
{
    public class EditUser
    {
        AdminRepository admin = new AdminRepository();

        public EditUser() { }

        public void editFields(UserDTO userDTO)
        {
            try
            {
                User referencedUser = admin.getAllUsers().FirstOrDefault(u => u.Id == userDTO.Id);

                if (referencedUser != null)
                {
                    if (!string.IsNullOrWhiteSpace(userDTO.userName))
                    {
                        referencedUser.username = userDTO.userName;
                    }

                    if (!string.IsNullOrWhiteSpace(userDTO.password))
                    {
                        referencedUser.password = userDTO.password;
                    }

                    referencedUser.isActive = userDTO.isActive;

                    if (!string.IsNullOrWhiteSpace(userDTO.role))
                    {
                        referencedUser.role = userDTO.role;
                    }

                    admin.updateUser(referencedUser);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex) { }
        }
    }
}

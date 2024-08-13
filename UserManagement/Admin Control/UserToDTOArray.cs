using DatabaseLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDatabase;
using DatabaseLayer.Models;

namespace UserManagement
{
    public class UserToDTOArray
    {
        AdminRepository admin = new AdminRepository();
        UserProfile mapper = new UserProfile();
        List<UserDTO> userDTOList = new List<UserDTO>();

        public UserToDTOArray() { }

        public List<UserDTO> getUserDTOArray()
        {
            try
            {
                return convertToDTOArray(admin.getAllUsers());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<UserDTO> convertToDTOArray(IEnumerable<User> users)
        {
            try
            {
                if (users == null)
                {
                    throw new Exception("Null user");
                }
                foreach (User user in users)
                {
                    UserDTO temp = mapper.createDTO(user);
                    userDTOList.Add(temp);
                }
                return userDTOList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
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
    public class userToDTOArray 
    {
        AdminRepository admin;
        UserProfile mapper;
        List<UserDTO> userDTOList;

        public userToDTOArray(){ }

        public List<UserDTO> getUserDTOArray()
        {
            try
            {
                return convertToDTOArray(admin.getAllUsers());
            }
            catch(Exception ex) 
            {
                throw ex; 
            }
        }

        public List<UserDTO> convertToDTOArray(IEnumerable<User> users)
        {
            try
            {
                mapper = new UserProfile();
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

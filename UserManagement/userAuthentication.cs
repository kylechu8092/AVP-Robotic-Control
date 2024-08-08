using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DatabaseLayer;
using DatabaseLayer.Models;

namespace UserManagement
{
    public class userAuthentication : IuserAuthentication
    {
        UserRepository authenticator = new UserRepository();
        UserProfile mapper = new UserProfile();
        UserDTO currUser;

        public userAuthentication() { }

        public bool isAuthenticated(string username, string password)
        {
            try
            {
                User u = authenticator.findUser(username);
                //Found the user
                if (u != null)
                {
                    currUser = mapper.createDTO(u);
                    if (currUser.userName.Equals(username) && currUser.password.Equals(password))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public UserDTO GetUserDTO()
        {
            return currUser;
        }
    }
}

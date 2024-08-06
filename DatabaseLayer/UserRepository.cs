using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDatabase.Context;
using DatabaseLayer.Models;

namespace DatabaseLayer
{
    public class UserRepository
    {
        UserContext db = new UserContext();

        public UserRepository() 
        {
        }
        public User findUser(string username)
        {
            try
            {
                User user = db.Users.Where(u => u.username.Equals(username)).FirstOrDefault();
                return user;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

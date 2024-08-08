using ApplicationDatabase.Context;
using DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class AdminRepository : IAdminRepository
    {
        private UserContext db;

        public AdminRepository() 
        { 
            db = new UserContext();
        }

        public IEnumerable<User> getAllUsers()
        {
            return db.Users.ToList();
        }

        public void createNew() 
        { 

        }

        public void deleteUser()
        {

        }

        public void updateUser()
        {

        }
    }
}

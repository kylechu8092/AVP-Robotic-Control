using ApplicationDatabase.Context;
using DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            try
            {
                return db.Users.ToList();
            }
            catch
            {
                throw new Exception();
            }
        }

        public void addNewUser(int Id, string username, string password, Boolean isActive, string role)
        {
            try
            {
                var userCount = db.Users.Count(u => u.Id == Id);
                if (userCount == 0)
                {
                    var user = new User();
                    user.Id = Id;
                    user.username = username;
                    user.password = password;
                    user.isActive = isActive;
                    user.role = role;
                    db.Users.Add(user);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Theres already an existing user!");
                }
            }
            catch
            {
                throw new Exception();
            }

        }

        public void deleteOldUser(int userID)
        {
            try
            {
                var user = db.Users.SingleOrDefault(u => u.Id == userID);
                if (user != null)
                {
                    db.Users.Remove(user);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("No user located");
                }
            }
            catch
            {
                throw new Exception();
            }
        }

        public void updateUser(User referencedUser)
        {
            try
            {
                User existingUser = db.Users.Find(referencedUser.Id);
                if (existingUser != null)
                {
                    existingUser.username = referencedUser.username;
                    existingUser.password = referencedUser.password;
                    existingUser.isActive = referencedUser.isActive;
                    existingUser.role = referencedUser.role;
                }
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
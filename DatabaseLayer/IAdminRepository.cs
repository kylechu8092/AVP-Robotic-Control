using DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public interface IAdminRepository
    {
        IEnumerable<User> getAllUsers();

        void addNewUser(int id, string username, string password, Boolean isActive, string role);

        void deleteOldUser(int userID);

        void updateUser(User referencedUser);
    }
}
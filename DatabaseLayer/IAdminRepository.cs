using DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    internal interface IAdminRepository
    {
        IEnumerable<User> getAllUsers();

        void createNew();

        void deleteUser();

        void updateUser();
    }
}

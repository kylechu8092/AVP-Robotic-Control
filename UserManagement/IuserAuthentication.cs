using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement
{
    internal interface IuserAuthentication
    {
        bool isAuthenticated(string username, string password);
    }
}

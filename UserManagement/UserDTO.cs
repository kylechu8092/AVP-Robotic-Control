using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DatabaseLayer.Models;


namespace UserManagement
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string level { get; set; }
        public Boolean isActive { get; set; }

    }
}

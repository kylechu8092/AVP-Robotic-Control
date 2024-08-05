using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DatabaseLayer.Models;
namespace UserManagement
{
    public class UserProfile : Profile
    {
        Mapper map;
        public UserProfile() 
        {
            CreateMap<User, UserDTO>();
        }
        
        public UserDTO createDTO(User u)
        {
            return map.Map<User, UserDTO>(u);
        }
    }
}

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
        IMapper _map;
        public UserProfile() 
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>();
            });
            _map =config.CreateMapper();
        }
        
        public UserDTO createDTO(User u)
        {
            if (u == null)
            {
                throw new Exception("Null user");
            }
            return _map.Map<User, UserDTO>(u);
        }
    }
}

using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantWebAPI.Service
{
    public interface IUserService
    {
        List<UserDTO> FindAll();

        UserDTO Save(UserDTO user);

        UserDTO Update(long id, UserDTO user);

        void Delete(long id);
    }
}

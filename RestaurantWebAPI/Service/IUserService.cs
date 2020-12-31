using RestaurantWebAPI.BindingData;
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

        bool Delete(long id);

        UserDTO ResetPassword(long id, ResetPassword data);

        UserDTO CheckLogin(Login data);
    }
}

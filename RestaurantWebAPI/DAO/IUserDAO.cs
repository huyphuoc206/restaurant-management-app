using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantWebAPI.DAO
{
    public interface IUserDAO
    {
        List<UserDTO> FindAll();

        List<UserDTO> FindUsersByUserNameAndEmail(string username, string email);

        UserDTO FindOneById(long id);

        long Save(UserDTO user);

        void Update(long id, UserDTO user);

        void Delete(long id);
    }
}

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

        UserDTO FindOneByUserNameAndPasswordAndStatus(string username, string password, int status);

        long Save(UserDTO user);

        bool Update(long id, UserDTO user);

        bool Delete(long id);

        bool ResetPassword(long id, UserDTO user);
        List<UserDTO> FindAllByKeyWord(string keyword);
    }
}

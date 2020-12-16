using RestaurantWebAPI.DTO;
using RestaurantWebAPI.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.DAO.impl
{
    public class UserDAO : AbstractDAO<UserDTO>, IUserDAO
    {
        private static UserDAO instance;

        public static UserDAO Instance
        {
            get { if (instance == null) instance = new UserDAO(); return instance; }
            private set => instance = value;
        }

        private UserDAO() { }

        public List<UserDTO> findAll()
        {
            string sql = "SELECT * FROM user join role on user.roleid = role.id";
            List<UserDTO> users = query(sql, new UserMapper());
            return users;
        }
    }
}
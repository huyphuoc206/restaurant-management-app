using RestaurantWebAPI.DAO;
using RestaurantWebAPI.DAO.impl;
using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.Service.impl
{
    public class UserService : IUserService
    {
        private IUserDAO userDAO;
        private static UserService instance;

        public static UserService Instance
        {
            get { if (instance == null) instance = new UserService(); return instance; }
            private set => instance = value;
        }
        private UserService() { }

        public List<UserDTO> findAll()
        {
            userDAO = UserDAO.Instance;
            return userDAO.findAll();
        }
    }
}
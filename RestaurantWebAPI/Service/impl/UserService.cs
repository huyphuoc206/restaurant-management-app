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

        public List<UserDTO> FindAll()
        {
            userDAO = UserDAO.Instance;
            return userDAO.FindAll();
        }

        public UserDTO Save(UserDTO user)
        {
            userDAO = UserDAO.Instance;
            List<UserDTO> userTemp = userDAO.FindUsersByUserNameAndEmail(user.UserName, user.Email);
            if (userTemp.Count == 0)
            {
                user.CreatedDate = DateTime.Now;
                long id = userDAO.Save(user);
                return userDAO.FindOneById(id);
            }
            return null;
        }

        public UserDTO Update(long id, UserDTO user)
        {
            userDAO = UserDAO.Instance;
            List<UserDTO> listTempUser = userDAO.FindUsersByUserNameAndEmail(user.UserName, user.Email);
            // Cap nhat tai khoan bi trung email hoac user da ton tai tren he thong
            if (listTempUser.Count > 1) return null; // neu tim duoc tu 2 user tro len tuc la bi trung username hoac email
            else if (listTempUser.Count == 1) // neu tim dc 1 user thi check xem neu khong phai la user hien tai dang chinh sua thi return null
                if (listTempUser[0].ID != id) return null;
            // Xac nhan co user dua vao id
            UserDTO oldUser = userDAO.FindOneById(id);
            if (oldUser != null)
            {
                user.CreatedDate = oldUser.CreatedDate;
                user.CreatedBy = oldUser.CreatedBy;
                user.ModifiedDate = DateTime.Now;
                userDAO.Update(id, user);
                return userDAO.FindOneById(id);
            }
            return null;
        }

        public void Delete(long id)
        {
            userDAO = UserDAO.Instance;
            UserDTO userTemp = userDAO.FindOneById(id);
            if (userTemp != null)
                userDAO.Delete(id);
        }
    }
}
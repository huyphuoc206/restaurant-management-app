using RestaurantWebAPI.BindingData;
using RestaurantWebAPI.DAO;
using RestaurantWebAPI.DAO.impl;
using RestaurantWebAPI.DTO;
using RestaurantWebAPI.Utils;
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
                user.PassWord = MD5Hashing.CreateMD5(user.PassWord);
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
                // kiem tra neu dang cap nhat thong tin (do STAFF cap nhat)
                if (user.Role == null)
                {
                    user.Status = oldUser.Status;
                    user.Role = oldUser.Role;
                }
                if (user.PassWord == null)
                    user.PassWord = oldUser.PassWord;
                // Neu mat khau truyen vao k = mat khau cu thi dang cap nhat user co doi mat khau
                if (!user.PassWord.Equals(oldUser.PassWord))
                    user.PassWord = MD5Hashing.CreateMD5(user.PassWord);
                if (userDAO.Update(id, user))
                    return userDAO.FindOneById(id);
            }
            return null;
        }

        public bool Delete(long id)
        {
            userDAO = UserDAO.Instance;
            return userDAO.Delete(id);
        }

        public UserDTO ResetPassword(long id, ResetPassword data)
        {
            if (!data.NewPassword.Equals(data.NewPasswordConfirm) || data.CurrentPassword.Equals(data.NewPassword))
                return null;
            userDAO = UserDAO.Instance;
            UserDTO user = userDAO.FindOneById(id);
            if (user != null)
            {
                if (!user.PassWord.Equals(MD5Hashing.CreateMD5(data.CurrentPassword)))
                    return null;
                user.ModifiedDate = DateTime.Now;
                user.PassWord = MD5Hashing.CreateMD5(data.NewPassword);
                if (userDAO.ResetPassword(id, user))
                    return user;
            }
            return null;
        }

        public UserDTO CheckLogin(Login data)
        {
            userDAO = UserDAO.Instance;
            data.Password = MD5Hashing.CreateMD5(data.Password);
            UserDTO user = userDAO.FindOneByUserNameAndPasswordAndStatus(data.Username, data.Password, 1);
            if (!user.UserName.Equals(data.Username)) return null;
            return user;
        }

        public UserDTO FindOneById(long id)
        {
            userDAO = UserDAO.Instance;
            return userDAO.FindOneById(id);
        }
    }
}
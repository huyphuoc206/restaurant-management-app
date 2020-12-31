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

        public List<UserDTO> FindAll()
        {
            string sql = "SELECT user.*, role.name FROM user JOIN role ON user.roleid = role.id";
            List<UserDTO> users = Query(sql, new UserMapper());
            return users;
        }

        public List<UserDTO> FindUsersByUserNameAndEmail(string username, string email)
        {
            string sql = "SELECT * FROM user WHERE username = @username OR email = @email";
            object[] parameters = { username, email };
            List<UserDTO> users = Query(sql, new UserMapper(), parameters);
            return users;
        }

        public UserDTO FindOneById(long id)
        {
            string sql = "SELECT * FROM user WHERE id = @id";
            object[] parameters = { id };
            List<UserDTO> users = Query(sql, new UserMapper(), parameters);
            if (users.Count == 0) return null;
            return users[0];
        }


        public UserDTO FindOneByUserNameAndPasswordAndStatus(string username, string password, int status)
        {
            string sql = "SELECT * FROM user WHERE username = @username AND password = @password AND status = @status";
            object[] parameters = { username, password, status };
            List<UserDTO> users = Query(sql, new UserMapper(), parameters);
            if (users.Count == 0) return null;
            return users[0];
        }

        public long Save(UserDTO user)
        {
            string sql = "INSERT INTO user (fullname, username, password, phone, address, email, dob, gender, status, roleid, createddate, createdby) " +
                        "VALUES( @fullname , @username , @password , @phone , @address , @email , @dob , @gender , @status , @roleid , @createddate , @createdby )";
            object[] parameters = { user.FullName, user.UserName, user.PassWord, user.Phone, user.Address, user.Email, user.Dob, user.Gender, user.Status, user.Role.ID, user.CreatedDate, user.CreatedBy };
            return Insert(sql, parameters);
        }

        public bool Update(long id, UserDTO user)
        {
            string sql = "UPDATE user SET fullname = @fullname , username = @username , password = @password , phone = @phone , address = @address , email = @email , dob = @dob , gender = @gender , status = @status , roleid = @roleid , modifieddate = @modifieddate , modifiedby = @modifiedby WHERE id = @id";
            object[] parameters = { user.FullName, user.UserName, user.PassWord, user.Phone, user.Address, user.Email, user.Dob, user.Gender, user.Status, user.Role.ID, user.ModifiedDate, user.ModifiedBy, id };
            return Update(sql, parameters);
        }

        public bool Delete(long id)
        {
            string sql = "DELETE FROM user WHERE id = @id";
            object[] parameters = { id };
            return Update(sql, parameters);
        }

        public bool ResetPassword(long id, UserDTO user)
        {
            string sql = "UPDATE user SET password = @password , modifieddate = @modifieddate , modifiedby = @modifiedby WHERE id = @id";
            object[] parameters = { user.PassWord, user.ModifiedDate, user.ModifiedBy, id };
            return Update(sql, parameters);
        }
    }
}
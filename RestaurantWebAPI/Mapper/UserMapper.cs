using MySql.Data.MySqlClient;
using RestaurantWebAPI.DTO;
using System;

namespace RestaurantWebAPI.Mapper
{
    public class UserMapper : IRowMapper<UserDTO>
    {
        public UserDTO MapRow(MySqlDataReader reader)
        {
            UserDTO user = new UserDTO();
            user.ID = reader.GetInt64("id");
            user.FullName = reader.GetString("fullname");
            user.UserName = reader.GetString("username");
            user.PassWord = reader.GetString("password");
            user.Phone = reader.GetString("phone");
            user.Address = reader.GetString("address");
            user.Email = reader.GetString("email");
            user.Gender = reader.GetString("gender");
            user.Status = reader.GetInt16("status");

            RoleDTO role = new RoleDTO();
            role.ID = reader.GetInt64("roleid");
            if (MapperUtils.HasColumn("name", reader))
                role.Name = reader.GetString("name");
            user.Role = role;

            if (reader["createddate"] != DBNull.Value)
                user.CreatedDate = reader.GetDateTime("createddate");
            if (reader["createdby"] != DBNull.Value)
                user.CreatedBy = reader.GetString("createdby");
            if (reader["modifieddate"] != DBNull.Value)
                user.ModifiedDate = reader.GetDateTime("modifieddate");
            if (reader["modifiedby"] != DBNull.Value)
                user.ModifiedBy = reader.GetString("modifiedby");
            return user;
        }
    }
}
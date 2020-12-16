using MySql.Data.MySqlClient;
using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
            if(MapperUtils.HasColumn("name",reader))
                role.Name = reader.GetString("name");
            if (MapperUtils.HasColumn("code", reader))
                role.Code = reader.GetString("code");
            user.Role = role;
            return user;
        }
    }
}
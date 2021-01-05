using MySql.Data.MySqlClient;
using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.Mapper
{
    public class RoleMapper : IRowMapper<RoleDTO>
    {
        public RoleDTO MapRow(MySqlDataReader reader)
        {
            RoleDTO role = new RoleDTO();
            role.ID = reader.GetInt64("id");
            role.Name = reader.GetString("name");
            role.Code = reader.GetString("code");

            if (reader["createddate"] != DBNull.Value)
                role.CreatedDate = reader.GetDateTime("createddate");
            if (reader["createdby"] != DBNull.Value)
                role.CreatedBy = reader.GetString("createdby");
            if (reader["modifieddate"] != DBNull.Value)
                role.ModifiedDate = reader.GetDateTime("modifieddate");
            if (reader["modifiedby"] != DBNull.Value)
                role.ModifiedBy = reader.GetString("modifiedby");

            return role;
        }
    }
}
using MySql.Data.MySqlClient;
using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.Mapper
{
    public class CategoryMapper : IRowMapper<CategoryDTO>
    {
        public CategoryDTO MapRow(MySqlDataReader reader)
        {
            CategoryDTO category = new CategoryDTO();
            category.ID = reader.GetInt64("id");
            category.Name = reader.GetString("name");
            category.Status = reader.GetInt32("status");

            if (reader["createddate"] != DBNull.Value)
                category.CreatedDate = reader.GetDateTime("createddate");
            if (reader["createdby"] != DBNull.Value)
                category.CreatedBy = reader.GetString("createdby");
            if (reader["modifieddate"] != DBNull.Value)
                category.ModifiedDate = reader.GetDateTime("modifieddate");
            if (reader["modifiedby"] != DBNull.Value)
                category.ModifiedBy = reader.GetString("modifiedby");
            return category;
        }
    }
}
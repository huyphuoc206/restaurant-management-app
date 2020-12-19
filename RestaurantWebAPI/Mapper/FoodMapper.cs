using MySql.Data.MySqlClient;
using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.Mapper
{
    public class FoodMapper : IRowMapper<FoodDTO>
    {
        public FoodDTO MapRow(MySqlDataReader reader)
        {
            FoodDTO food = new FoodDTO();
            food.ID = reader.GetInt64("id");
            food.Name = reader.GetString("name");
            food.Price = reader.GetInt64("price");
            food.Discount = reader.GetInt32("discount");
            food.Status = reader.GetInt32("status");
            CategoryDTO category = new CategoryDTO();
            if (MapperUtils.HasColumn("categoryname", reader))
                category.Name = reader.GetString("categoryname");
            category.ID = reader.GetInt64("categoryid");
            food.Category = category;
            if (reader["createddate"] != DBNull.Value)
                food.CreatedDate = reader.GetDateTime("createddate");
            if (reader["createdby"] != DBNull.Value)
                food.CreatedBy = reader.GetString("createdby");
            if (reader["modifieddate"] != DBNull.Value)
                food.ModifiedDate = reader.GetDateTime("modifieddate");
            if (reader["modifiedby"] != DBNull.Value)
                food.ModifiedBy = reader.GetString("modifiedby");
            return food;
        }
    }
}
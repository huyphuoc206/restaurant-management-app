using MySql.Data.MySqlClient;
using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.Mapper
{
    public class SaleMapper : IRowMapper<SaleDTO>
    {
        public SaleDTO MapRow(MySqlDataReader reader)
        {
            SaleDTO sale = new SaleDTO();
            sale.ID = reader.GetInt64("id");
            sale.Name = reader.GetString("name");
            sale.Discount = reader.GetInt16("discount");
            sale.Status = reader.GetInt32("status");

            if (reader["createddate"] != DBNull.Value)
                sale.CreatedDate = reader.GetDateTime("createddate");
            if (reader["createdby"] != DBNull.Value)
                sale.CreatedBy = reader.GetString("createdby");
            if (reader["modifieddate"] != DBNull.Value)
                sale.ModifiedDate = reader.GetDateTime("modifieddate");
            if (reader["modifiedby"] != DBNull.Value)
                sale.ModifiedBy = reader.GetString("modifiedby");

            return sale;
        }
    }
}
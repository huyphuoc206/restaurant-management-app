using MySql.Data.MySqlClient;
using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.Mapper
{
    public class TableMapper : IRowMapper<TableDTO>
    {
        public TableDTO MapRow(MySqlDataReader reader)
        {
            TableDTO table = new TableDTO();
            table.ID = reader.GetInt64("id");
            table.Name = reader.GetString("name");
            table.Seats = reader.GetInt32("seats");
            table.Status = reader.GetInt32("status");

            if (reader["createddate"] != DBNull.Value)
                table.CreatedDate = reader.GetDateTime("createddate");
            if (reader["createdby"] != DBNull.Value)
                table.CreatedBy = reader.GetString("createdby");
            if (reader["modifieddate"] != DBNull.Value)
                table.ModifiedDate = reader.GetDateTime("modifieddate");
            if (reader["modifiedby"] != DBNull.Value)
                table.ModifiedBy = reader.GetString("modifiedby");
            return table;
        }
    }
}
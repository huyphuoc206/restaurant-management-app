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
            throw new NotImplementedException();
        }
    }
}
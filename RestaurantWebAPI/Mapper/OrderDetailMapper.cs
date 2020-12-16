using MySql.Data.MySqlClient;
using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.Mapper
{
    public class OrderDetailMapper : IRowMapper<OrderDetailDTO>
    {
        public OrderDetailDTO MapRow(MySqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
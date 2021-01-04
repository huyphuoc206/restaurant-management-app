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
            OrderDetailDTO orderDetail = new OrderDetailDTO();
            orderDetail.ID = reader.GetInt64("id");
            orderDetail.UnitPrice = reader.GetInt64("unitprice");
            orderDetail.Quantity = reader.GetInt32("quantity");

            OrderDTO order = new OrderDTO();
            order.ID = reader.GetInt64("orderid");
            orderDetail.Order = order;

            FoodDTO food = new FoodDTO();
            food.ID = reader.GetInt64("foodid");
            if (MapperUtils.HasColumn("price", reader))
                food.Price = reader.GetInt64("price");
            if (MapperUtils.HasColumn("discount", reader))
                food.Discount = reader.GetInt32("discount");
            if (MapperUtils.HasColumn("name", reader))
                food.Name = reader.GetString("name");
            orderDetail.Food = food;

            if (reader["createddate"] != DBNull.Value)
                orderDetail.CreatedDate = reader.GetDateTime("createddate");
            if (reader["createdby"] != DBNull.Value)
                orderDetail.CreatedBy = reader.GetString("createdby");
            if (reader["modifieddate"] != DBNull.Value)
                orderDetail.ModifiedDate = reader.GetDateTime("modifieddate");
            if (reader["modifiedby"] != DBNull.Value)
                orderDetail.ModifiedBy = reader.GetString("modifiedby");
            return orderDetail;
        }
    }
}
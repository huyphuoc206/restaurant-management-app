using MySql.Data.MySqlClient;
using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.Mapper
{
    public class OrderMapper : IRowMapper<OrderDTO>
    {
        public OrderDTO MapRow(MySqlDataReader reader)
        {
            OrderDTO order = new OrderDTO();
            order.ID = reader.GetInt64("id");
            order.TotalPrice = reader.GetInt64("totalprice");
            order.Status = reader.GetInt32("status");

            SaleDTO sale = new SaleDTO();
            sale.ID = reader.GetInt64("saleid");
            if (MapperUtils.HasColumn("salename", reader))
                sale.Name = reader.GetString("salename");
            if (MapperUtils.HasColumn("discount", reader))
                sale.Discount = reader.GetInt32("discount");
            order.Sale = sale;

            TableDTO table = new TableDTO();
            table.ID = reader.GetInt64("tableid");
            if (MapperUtils.HasColumn("tablename", reader))
                table.Name = reader.GetString("tablename");
            if (MapperUtils.HasColumn("seats", reader))
                table.Seats = reader.GetInt32("seats");
            order.Table = table;

            if (reader["createddate"] != DBNull.Value)
                order.CreatedDate = reader.GetDateTime("createddate");
            if (reader["createdby"] != DBNull.Value)
                order.CreatedBy = reader.GetString("createdby");
            if (reader["modifieddate"] != DBNull.Value)
                order.ModifiedDate = reader.GetDateTime("modifieddate");
            if (reader["modifiedby"] != DBNull.Value)
                order.ModifiedBy = reader.GetString("modifiedby");
            return order;

        }
    }
}
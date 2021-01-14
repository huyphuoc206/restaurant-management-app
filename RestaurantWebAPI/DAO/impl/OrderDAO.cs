using RestaurantWebAPI.DTO;
using RestaurantWebAPI.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.DAO.impl
{
    public class OrderDAO : AbstractDAO<OrderDTO>, IOrderDAO
    {
        private static OrderDAO instance;

        public static OrderDAO Instance
        {
            get { if (instance == null) instance = new OrderDAO(); return instance; }
            private set => instance = value;
        }

        private OrderDAO() { }

        public List<OrderDTO> FindAll()
        {
            string sql = "SELECT orders.*, tables.name as tablename, tables.seats, sales.name as salename, sales.discount FROM orders JOIN tables ON orders.tableid = tables.id JOIN sales ON orders.saleid = sales.id";
            return Query(sql, new OrderMapper());
        }

        public OrderDTO FindOneById(long id)
        {
            string sql = "SELECT orders.*, tables.name as tablename, tables.seats, sales.name as salename, sales.discount FROM orders JOIN tables ON orders.tableid = tables.id JOIN sales ON orders.saleid = sales.id WHERE orders.id = @id";
            object[] parameters = { id };
            List<OrderDTO> orders = Query(sql, new OrderMapper(), parameters);
            if (orders.Count == 0) return null;
            return orders[0];
        }

        public List<OrderDTO> FindAllByDate(string fromDate, string toDate)
        {
            string sql = "SELECT orders.*, tables.name as tablename, tables.seats, sales.name as salename, sales.discount FROM orders JOIN tables ON orders.tableid = tables.id JOIN sales ON orders.saleid = sales.id WHERE orders.status = 1 AND orders.modifieddate >= @fromdate AND orders.modifieddate <= @todate";
            string from = fromDate + " 00:00:00";
            string to = toDate + " 23:59:59";
            object[] parameters = { from, to };
            return Query(sql, new OrderMapper(), parameters);
        }

        public long Save(OrderDTO order)
        {
            string sql = "INSERT INTO orders (totalprice, tableid, status, createddate, createdby) VALUES( @totalprice , @tableid , @status , @createddate , @createdby )";
            object[] parameters = { order.TotalPrice, order.Table.ID, order.Status, order.CreatedDate, order.CreatedBy };
            return Insert(sql, parameters);
        }

        public bool Update(long id, OrderDTO order)
        {
            string sql = "UPDATE orders SET totalprice = @totalprice , saleid = @saleid , tableid = @tableid , status = @status , modifieddate = @modifieddate , modifiedby = @modifiedby WHERE id = @id";
            object[] parameters = { order.TotalPrice, order.Sale.ID, order.Table.ID, order.Status, order.ModifiedDate, order.ModifiedBy, id };
            return Update(sql, parameters);
        }

        public bool Delete(long id)
        {
            string sql = "DELETE FROM orders WHERE id = @id";
            object[] parameters = { id };
            return Update(sql, parameters);
        }

        public List<OrderDTO> FindAllByTableId(long tableId)
        {
            string sql = "SELECT orders.*, tables.name as tablename, tables.seats, sales.name as salename, sales.discount FROM orders JOIN tables ON orders.tableid = tables.id JOIN sales ON orders.saleid = sales.id WHERE tables.id = @id";
            object[] parameters = { tableId };
            return Query(sql, new OrderMapper(), parameters);
        }
    }
}
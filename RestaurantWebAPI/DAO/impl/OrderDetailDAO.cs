using RestaurantWebAPI.DTO;
using RestaurantWebAPI.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.DAO.impl
{
    public class OrderDetailDAO : AbstractDAO<OrderDetailDTO>, IOrderDetailDAO
    {
        private static OrderDetailDAO instance;

        public static OrderDetailDAO Instance
        {
            get { if (instance == null) instance = new OrderDetailDAO(); return instance; }
            private set => instance = value;
        }

        private OrderDetailDAO() { }

        public long Save(long orderId, OrderDetailDTO orderDetail)
        {
            string sql = "INSERT INTO orderdetail (orderid, foodid, unitprice, quantity, createddate, createdby) VALUES ( @orderid , @foodid , @unitprice , @quantity , @createddate , @createdby )";
            object[] parameters = { orderId, orderDetail.Food.ID, orderDetail.UnitPrice, orderDetail.Quantity, orderDetail.CreatedDate, orderDetail.CreatedBy };
            return Insert(sql, parameters);
        }

        public OrderDetailDTO FindOneById(long id)
        {
            string sql = "SELECT orderdetail.*, food.price, food.discount, food.name FROM orderdetail JOIN food ON orderdetail.foodid = food.id JOIN orders ON orderdetail.orderid = orders.id WHERE orderdetail.id = @id";
            object[] parameters = { id };
            List<OrderDetailDTO> orderDetails = Query(sql, new OrderDetailMapper(), parameters);
            if (orderDetails.Count == 0) return null;
            return orderDetails[0];
        }

        public List<OrderDetailDTO> FindAllByOrderId(long orderId)
        {
            string sql = "SELECT orderdetail.*, food.price, food.discount, food.name FROM orderdetail JOIN food ON orderdetail.foodid = food.id JOIN orders ON orderdetail.orderid = orders.id WHERE orderdetail.orderid = @id";
            object[] parameters = { orderId };
            return Query(sql, new OrderDetailMapper(), parameters);
        }

        public bool UpdateQuantity(long orderDetailId, int quantity)
        {
            string sql = "UPDATE orderdetail SET quantity = @quantity WHERE id = @orderdetailid";
            object[] parameters = { quantity, orderDetailId };
            return Update(sql, parameters);
        }

        public bool Delete(long orderDetailId)
        {
            string sql = "DELETE FROM orderdetail WHERE id = @id";
            object[] parameters = { orderDetailId };
            return Update(sql, parameters);
        }

        public bool Update(long id, OrderDetailDTO orderDetail)
        {
            string sql = "UPDATE orderdetail SET orderid = @orderid , foodid = @foodid , unitprice = @unitprice , quantity = @quantity , modifieddate = @modifieddate , modifiedby = @modifiedby WHERE id = @id";
            object[] parameters = { orderDetail.Order.ID, orderDetail.Food.ID, orderDetail.UnitPrice, orderDetail.Quantity, orderDetail.ModifiedDate, orderDetail.ModifiedBy, id };
            return Update(sql, parameters);
        }
    }
}
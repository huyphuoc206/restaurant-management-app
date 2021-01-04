using RestaurantWebAPI.DAO;
using RestaurantWebAPI.DAO.impl;
using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.Service.impl
{
    public class OrderService : IOrderService
    {
        private IOrderDAO orderDAO;
        private ITableDAO tableDAO;

        private static OrderService instance;

        public static OrderService Instance
        {
            get { if (instance == null) instance = new OrderService(); return instance; }
            private set => instance = value;
        }
        private OrderService() { }

        public List<OrderDTO> FindAll()
        {
            orderDAO = OrderDAO.Instance;
            return orderDAO.FindAll();
        }

        public OrderDTO Save(OrderDTO order)
        {
            orderDAO = OrderDAO.Instance;
            order.CreatedDate = DateTime.Now;
            long id = orderDAO.Save(order);
            return orderDAO.FindOneById(id);
        }

        public OrderDTO Update(long id, OrderDTO order)
        {
            orderDAO = OrderDAO.Instance;
            OrderDTO oldOrder = orderDAO.FindOneById(id);
            if (oldOrder != null)
            {
                order.CreatedBy = oldOrder.CreatedBy;
                order.CreatedDate = oldOrder.CreatedDate;
                order.ModifiedDate = DateTime.Now;
                if (orderDAO.Update(id, order))
                    return orderDAO.FindOneById(id);
            }
            return null;
        }

        public bool Delete(long id)
        {
            orderDAO = OrderDAO.Instance;
            return orderDAO.Delete(id);
        }

        public List<OrderDTO> FindAllByTableId(long tableId)
        {
            orderDAO = OrderDAO.Instance;
            tableDAO = TableDAO.Instance;
            if (tableDAO.FindOneById(tableId) == null) return null;
            return orderDAO.FindAllByTableId(tableId);
        }
    }
}
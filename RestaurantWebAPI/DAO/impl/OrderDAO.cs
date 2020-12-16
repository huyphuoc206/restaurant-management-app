using RestaurantWebAPI.DTO;
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
    }
}
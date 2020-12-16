using RestaurantWebAPI.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.Service.impl
{
    public class OrderService : IOrderService
    {
        private IOrderDAO orderDAO;
        private static OrderService instance;

        public static OrderService Instance
        {
            get { if (instance == null) instance = new OrderService(); return instance; }
            private set => instance = value;
        }
        private OrderService() { }
    }
}
using RestaurantWebAPI.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.Service.impl
{
    public class OrderDetailService : IOrderDetailService
    {
        private IOrderDetailDAO orderDetailDAO;

        private static OrderDetailService instance;

        public static OrderDetailService Instance
        {
            get { if (instance == null) instance = new OrderDetailService(); return instance; }
            private set => instance = value;
        }
        private OrderDetailService() { }
    }
}
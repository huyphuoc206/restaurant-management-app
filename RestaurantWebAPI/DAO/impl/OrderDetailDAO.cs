using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.DAO.impl
{
    public class OrderDetailDAO : IOrderDetailDAO
    {
        private static OrderDetailDAO instance;

        public static OrderDetailDAO Instance
        {
            get { if (instance == null) instance = new OrderDetailDAO(); return instance; }
            private set => instance = value;
        }

        private OrderDetailDAO() { }
    }
}
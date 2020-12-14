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
    }
}
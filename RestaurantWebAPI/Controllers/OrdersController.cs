using RestaurantWebAPI.DTO;
using RestaurantWebAPI.Service;
using RestaurantWebAPI.Service.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestaurantWebAPI.Controllers
{
    public class OrdersController : ApiController
    {
        private IOrderService orderService;

        public List<OrderDTO> Get()
        {
            orderService = OrderService.Instance;
            return orderService.FindAll();
        }

        public OrderDTO Post(OrderDTO order)
        {
            orderService = OrderService.Instance;
            return orderService.Save(order);
        }

        public OrderDTO Put(long id, OrderDTO order)
        {
            orderService = OrderService.Instance;
            return orderService.Update(id, order);
        }

        public bool Delete(long id)
        {
            orderService = OrderService.Instance;
            return orderService.Delete(id);
        }
    }
}

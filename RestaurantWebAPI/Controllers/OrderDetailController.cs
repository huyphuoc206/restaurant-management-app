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
    public class OrderDetailController : ApiController
    {
        private IOrderDetailService orderDetailService;

        [Route("api/orders/{orderId:long}/orderdetails")]
        [HttpGet]
        public List<OrderDetailDTO> Get(long orderId)
        {
            orderDetailService = OrderDetailService.Instance;
            return orderDetailService.FindAllByOrderId(orderId);
        }

        [Route("api/orders/{orderId:long}/orderdetails")]
        [HttpPost]
        public OrderDetailDTO Post(long orderId, OrderDetailDTO orderDetail)
        {
            orderDetailService = OrderDetailService.Instance;
            return orderDetailService.Save(orderId, orderDetail);
        }

        public OrderDetailDTO Put(long id, OrderDetailDTO orderDetail)
        {
            orderDetailService = OrderDetailService.Instance;
            return orderDetailService.Update(id, orderDetail);
        }

        public bool Delete(long id)
        {
            orderDetailService = OrderDetailService.Instance;
            return orderDetailService.Delete(id);
        }
    }
}

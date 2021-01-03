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
            /* return foodService.FindAllByCategoryId(categoryId);*/
            return null;
        }
    }
}

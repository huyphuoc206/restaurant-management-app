using RestaurantWebAPI.Service;
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
    }
}

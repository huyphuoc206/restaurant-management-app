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
    public class UserController : ApiController
    {
        private IUserService userService;

        [Route("~/api/GetAllUsers")]
        [HttpGet]
        public List<UserDTO> Get()
        {
            userService = UserService.Instance;
            return userService.findAll();
        }
    }
}

using RestaurantWebAPI.BindingData;
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
    public class UsersController : ApiController
    {
        private IUserService userService;

        public List<UserDTO> Get()
        {
            userService = UserService.Instance;
            return userService.FindAll();
        }

        public UserDTO Get(long id)
        {
            userService = UserService.Instance;
            return userService.FindOneById(id);
        }

        public UserDTO Post(UserDTO user)
        {
            userService = UserService.Instance;
            return userService.Save(user);
        }

        public UserDTO Put(long id, UserDTO user)
        {
            userService = UserService.Instance;
            return userService.Update(id, user);
        }

        public bool Delete(long id)
        {
            userService = UserService.Instance;
            return userService.Delete(id);
        }

        [Route("api/users/Login")]
        [HttpPost]
        public UserDTO Login(Login data)
        {
            userService = UserService.Instance;
            return userService.CheckLogin(data);
        }

        [Route("api/users/ResetPassword/{id:long}")]
        [HttpPut]
        public UserDTO ResetPassword(long id, ResetPassword data)
        {
            userService = UserService.Instance;
            return userService.ResetPassword(id, data);
        }
    }
}

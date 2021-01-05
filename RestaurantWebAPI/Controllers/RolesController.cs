using RestaurantWebAPI.DTO;
using RestaurantWebAPI.Service;
using RestaurantWebAPI.Service.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace RestaurantWebAPI.Controllers
{
    public class RolesController : ApiController
    {
        private IRoleService roleService;

        public List<RoleDTO> Get()
        {
            roleService = RoleService.Instance;
            return roleService.FindAll();
        }
    }
}
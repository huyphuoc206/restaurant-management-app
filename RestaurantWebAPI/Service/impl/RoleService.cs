using RestaurantWebAPI.DAO;
using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.Service.impl
{
    public class RoleService : IRoleService
    {
        private IRoleDAO roleDAO;
        private static RoleService instance;

        public static RoleService Instance
        {
            get { if (instance == null) instance = new RoleService(); return instance; }
            private set => instance = value;
        }
        private RoleService() { }

        public List<RoleDTO> FindAll()
        {
            roleDAO = RoleDAO.Instance;
            return roleDAO.FindAll();
        }
    }
}
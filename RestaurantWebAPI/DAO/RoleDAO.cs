using RestaurantWebAPI.DAO.impl;
using RestaurantWebAPI.DTO;
using RestaurantWebAPI.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.DAO
{
    public class RoleDAO : AbstractDAO<RoleDTO>, IRoleDAO
    {
        private static RoleDAO instance;

        public static RoleDAO Instance
        {
            get { if (instance == null) instance = new RoleDAO(); return instance; }
            private set => instance = value;
        }

        private RoleDAO() { }

        public List<RoleDTO> FindAll()
        {
            string sql = "SELECT * FROM role";
            return Query(sql, new RoleMapper());
        }
    }
}
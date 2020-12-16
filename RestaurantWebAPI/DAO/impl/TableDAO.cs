using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.DAO.impl
{
    public class TableDAO : AbstractDAO<TableDTO>, ITableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return instance; }
            private set => instance = value;
        }

        private TableDAO() { }
    }
}
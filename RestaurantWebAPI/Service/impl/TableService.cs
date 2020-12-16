using RestaurantWebAPI.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.Service.impl
{
    public class TableService : ITableService
    {
        private ITableDAO tableDAO;
        private static TableService instance;

        public static TableService Instance
        {
            get { if (instance == null) instance = new TableService(); return instance; }
            private set => instance = value;
        }
        private TableService() { }
    }
}
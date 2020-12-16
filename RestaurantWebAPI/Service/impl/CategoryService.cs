using RestaurantWebAPI.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.Service.impl
{
    public class CategoryService : ICategoryService
    {
        private ICategoryDAO categoryDAO;
        private static CategoryService instance;

        public static CategoryService Instance
        {
            get { if (instance == null) instance = new CategoryService(); return instance; }
            private set => instance = value;
        }
        private CategoryService() { }
    }
}
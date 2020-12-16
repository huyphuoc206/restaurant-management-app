using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.DAO.impl
{
    public class CategoryDAO : AbstractDAO<CategoryDTO>, ICategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance { 
            get { if (instance == null) instance = new CategoryDAO(); return instance; } 
            private set => instance = value; 
        }

        private CategoryDAO() { }
        
    }
}
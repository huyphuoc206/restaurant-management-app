using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.DAO.impl
{
    public class FoodDAO : AbstractDAO<FoodDTO>, IFoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return instance; }
            private set => instance = value;
        }

        private FoodDAO() { }
    }
}
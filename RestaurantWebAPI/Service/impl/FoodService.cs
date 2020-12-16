using RestaurantWebAPI.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.Service.impl
{
    public class FoodService : IFoodService
    {
        private IFoodDAO foodDAO;
        private static FoodService instance;

        public static FoodService Instance
        {
            get { if (instance == null) instance = new FoodService(); return instance; }
            private set => instance = value;
        }
        private FoodService() { }
    }
}
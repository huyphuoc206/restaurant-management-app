using RestaurantWebAPI.DAO;
using RestaurantWebAPI.DAO.impl;
using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.Service.impl
{
    public class FoodService : IFoodService
    {
        private IFoodDAO foodDAO;
        private ICategoryDAO categoryDAO;
        private static FoodService instance;

        public static FoodService Instance
        {
            get { if (instance == null) instance = new FoodService(); return instance; }
            private set => instance = value;
        }
        private FoodService() { }

        public List<FoodDTO> FindAll()
        {
            foodDAO = FoodDAO.Instance;
            return foodDAO.FindAll();
        }

        public List<FoodDTO> FindAllByCategoryId(long categoryId)
        {
            foodDAO = FoodDAO.Instance;
            categoryDAO = CategoryDAO.Instance;
            if (categoryDAO.FindOneById(categoryId) == null) return null;
            return foodDAO.FindAllByCategoryId(categoryId);
        }

        public FoodDTO Save(FoodDTO food)
        {
            foodDAO = FoodDAO.Instance;
            if (food.Price < 0 || food.Discount < 0 || food.Discount > 100) return null;
            food.CreatedDate = DateTime.Now;
            long id = foodDAO.Save(food);
            return foodDAO.FindOneById(id);
        }

        public FoodDTO Update(long id, FoodDTO food)
        {
            foodDAO = FoodDAO.Instance;
            if (food.Price < 0 || food.Discount < 0 || food.Discount > 100) return null;
            FoodDTO oldFood = foodDAO.FindOneById(id);
            if (oldFood != null)
            {
                food.CreatedBy = oldFood.CreatedBy;
                food.CreatedDate = oldFood.CreatedDate;
                food.ModifiedDate = DateTime.Now;
                if (foodDAO.Update(id, food))
                    return foodDAO.FindOneById(id);
            }
            return null;
        }

        public bool Delete(long id)
        {
            foodDAO = FoodDAO.Instance;
            return foodDAO.Delete(id);
        }

    }
}
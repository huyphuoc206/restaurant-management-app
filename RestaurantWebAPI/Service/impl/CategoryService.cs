using RestaurantWebAPI.DAO;
using RestaurantWebAPI.DAO.impl;
using RestaurantWebAPI.DTO;
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

        public List<CategoryDTO> FindAll()
        {
            categoryDAO = CategoryDAO.Instance;
            return categoryDAO.FindAll();
        }

        public CategoryDTO Save(CategoryDTO category)
        {
            categoryDAO = CategoryDAO.Instance;
            category.CreatedDate = DateTime.Now;
            long id = categoryDAO.Save(category);
            return categoryDAO.FindOneById(id);
        }

        public CategoryDTO Update(long id, CategoryDTO category)
        {
            categoryDAO = CategoryDAO.Instance;
            CategoryDTO oldCategory = categoryDAO.FindOneById(id);
            if (oldCategory != null)
            {
                category.CreatedDate = oldCategory.CreatedDate;
                category.CreatedBy = oldCategory.CreatedBy;
                category.ModifiedDate = DateTime.Now;
                categoryDAO.Update(id, category);
                return categoryDAO.FindOneById(id);
            }
            return null;

        }

        public void Delete(long id)
        {
            categoryDAO = CategoryDAO.Instance;
            categoryDAO.Delete(id);
        }
    }
}
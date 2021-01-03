using RestaurantWebAPI.DTO;
using RestaurantWebAPI.Service;
using RestaurantWebAPI.Service.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestaurantWebAPI.Controllers
{
    public class CategoriesController : ApiController
    {
        private ICategoryService categoryService;

        public List<CategoryDTO> Get()
        {
            categoryService = CategoryService.Instance;
            return categoryService.FindAll();
        }

        public CategoryDTO Post(CategoryDTO category)
        {
            categoryService = CategoryService.Instance;
            return categoryService.Save(category);
        }

        public CategoryDTO Put(long id, CategoryDTO category)
        {
            categoryService = CategoryService.Instance;
            return categoryService.Update(id, category);
        }

        public bool Delete(long id)
        {
            categoryService = CategoryService.Instance;
            return categoryService.Delete(id);
        }
    }
}

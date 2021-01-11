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
    public class FoodController : ApiController
    {
        private IFoodService foodService;

        public List<FoodDTO> Get()
        {
            foodService = FoodService.Instance;
            return foodService.FindAll();
        }

        [Route("api/category/{categoryId:long}/food")]
        [HttpGet]
        public List<FoodDTO> Get(long categoryId)
        {
            foodService = FoodService.Instance;
            return foodService.FindAllByCategoryId(categoryId);
        }

        [Route("api/food/search")]
        [HttpGet]
        public List<FoodDTO> Search(string keyword)
        {
            foodService = FoodService.Instance;
            return foodService.FindByKeyWord(keyword);
        }

        public FoodDTO Post(FoodDTO food)
        {
            foodService = FoodService.Instance;
            return foodService.Save(food);
        }

        public FoodDTO Put(long id, FoodDTO food)
        {
            foodService = FoodService.Instance;
            return foodService.Update(id, food);
        }

        public bool Delete(long id)
        {
            foodService = FoodService.Instance;
            return foodService.Delete(id);
        }
    }
}

using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantWebAPI.Service
{
    public interface IFoodService
    {
        List<FoodDTO> FindAll();

        List<FoodDTO> FindAllByCategoryId(long categoryId);

        FoodDTO Save(FoodDTO food);

        FoodDTO Update(long id, FoodDTO food);

        void Delete(long id);
    }
}

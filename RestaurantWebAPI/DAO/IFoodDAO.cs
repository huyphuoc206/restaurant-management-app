using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantWebAPI.DAO
{
    public interface IFoodDAO
    {
        List<FoodDTO> FindAll();

        List<FoodDTO> FindAllByCategoryId(long categoryId);

        FoodDTO FindOneById(long id);

        long Save(FoodDTO food);

        bool Update(long id, FoodDTO food);

        bool Delete(long id);
        List<FoodDTO> FindByKeyWord(string keyword);
    }
}

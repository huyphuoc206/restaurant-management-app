using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantWebAPI.DAO
{
    public interface ICategoryDAO
    {
        List<CategoryDTO> FindAll();

        CategoryDTO FindOneById(long id);

        long Save(CategoryDTO category);

        void Update(long id, CategoryDTO category);

        void Delete(long id);
    }
}

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

        List<CategoryDTO> FindAllByStatus(int status);

        CategoryDTO FindOneById(long id);

        long Save(CategoryDTO category);

        bool Update(long id, CategoryDTO category);

        bool Delete(long id);
    }
}

using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantWebAPI.Service
{
    public interface ICategoryService
    {
        List<CategoryDTO> FindAll();

        CategoryDTO Save(CategoryDTO category);

        CategoryDTO Update(long id, CategoryDTO category);

        bool Delete(long id);
    }
}

using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantWebAPI.Service
{
    public interface ITableService
    {
        List<TableDTO> FindAll();

        TableDTO Save(TableDTO table);

        TableDTO Update(long id, TableDTO table);

        bool Delete(long id);
        TableDTO FindOneById(long id);
    }
}

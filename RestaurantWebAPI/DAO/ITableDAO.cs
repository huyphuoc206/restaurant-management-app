using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantWebAPI.DAO
{
    public interface ITableDAO
    {
        List<TableDTO> FindAll();

        TableDTO FindOneById(long id);

        long Save(TableDTO table);

        void Update(long id, TableDTO table);

        void Delete(long id);
    }
}

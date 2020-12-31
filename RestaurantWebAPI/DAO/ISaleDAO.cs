using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantWebAPI.DAO
{
    interface ISaleDAO
    {
        List<SaleDTO> FindAll();

        List<SaleDTO> FindAllByStatus(int status);

        SaleDTO FindOneById(long id);

        long Save(SaleDTO sale);

        bool Update(long id, SaleDTO sale);

        bool Delete(long id);
    }
}

using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantWebAPI.Service
{
    interface ISaleService
    {
        List<SaleDTO> FindAll();

        List<SaleDTO> FindAllByStatus(int status);

        SaleDTO Save(SaleDTO sale);

        SaleDTO Update(long id, SaleDTO sale);

        bool Delete(long id);
    }
}

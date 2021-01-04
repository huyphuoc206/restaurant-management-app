using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantWebAPI.Service
{
    public interface IOrderService
    {
        List<OrderDTO> FindAll();

        OrderDTO Save(OrderDTO order);

        OrderDTO Update(long id, OrderDTO order);

        bool Delete(long id);

        List<OrderDTO> FindAllByTableId(long tableId);
    }
}

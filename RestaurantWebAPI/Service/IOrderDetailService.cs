using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantWebAPI.Service
{
    public interface IOrderDetailService
    {
        List<OrderDetailDTO> FindAllByOrderId(long orderId);

        OrderDetailDTO Save(long orderId, OrderDetailDTO orderDetail);

        bool Delete(long orderDetailId);

        OrderDetailDTO Update(long id, OrderDetailDTO orderDetail);
    }
}

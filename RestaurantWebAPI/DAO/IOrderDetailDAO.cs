using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantWebAPI.DAO
{
    public interface IOrderDetailDAO
    {
        List<OrderDetailDTO> FindAllByOrderId(long orderId);
        OrderDetailDTO FindOneById(long id);
        long Save(long orderId, OrderDetailDTO orderDetail);
        bool UpdateQuantity(long orderDetailId, int quantity);
        bool Delete(long orderDetailId);
        bool Update(long id, OrderDetailDTO orderDetail);
    }
}

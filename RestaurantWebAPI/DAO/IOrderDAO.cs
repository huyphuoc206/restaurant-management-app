using RestaurantWebAPI.DAO.impl;
using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantWebAPI.DAO
{
    public interface IOrderDAO
    {
        List<OrderDTO> FindAll();
        OrderDTO FindOneById(long id);
        long Save(OrderDTO order);
        bool Update(long id, OrderDTO order);
        bool Delete(long id);
        List<OrderDTO> FindAllByTableId(long tableId);
        List<OrderDTO> FindAllByDate(string fromDate, string toDate);
    }
}

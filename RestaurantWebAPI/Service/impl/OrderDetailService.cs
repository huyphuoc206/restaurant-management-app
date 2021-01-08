using RestaurantWebAPI.DAO;
using RestaurantWebAPI.DAO.impl;
using RestaurantWebAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.Service.impl
{
    public class OrderDetailService : IOrderDetailService
    {
        private IOrderDetailDAO orderDetailDAO;
        private IOrderDAO orderDAO;
        private IFoodDAO foodDAO;

        private static OrderDetailService instance;

        public static OrderDetailService Instance
        {
            get { if (instance == null) instance = new OrderDetailService(); return instance; }
            private set => instance = value;
        }
        private OrderDetailService() { }

        public OrderDetailDTO Save(long orderId, OrderDetailDTO orderDetail)
        {
            orderDAO = OrderDAO.Instance;
            orderDetailDAO = OrderDetailDAO.Instance;
            foodDAO = FoodDAO.Instance;

            // xu ly neu don hang chua ton tai thi tao moi luon hoac xu ly ben app??????????
            if (orderDAO.FindOneById(orderId) == null || foodDAO.FindOneById(orderDetail.Food.ID) == null) return null;

            orderDetail.CreatedDate = DateTime.Now;
            FoodDTO food = foodDAO.FindOneById(orderDetail.Food.ID);
            orderDetail.Food = food;
            orderDetail.UnitPrice = orderDetail.Food.Price - orderDetail.Food.Price * orderDetail.Food.Discount / 100;

            // Neu food da ton tai trong order thi cap nhat lai quantity
            List<OrderDetailDTO> orderDetails = orderDetailDAO.FindAllByOrderId(orderId);
            foreach (OrderDetailDTO o in orderDetails)
            {
                if (o.Food.ID == orderDetail.Food.ID)
                {
                    int totalQuantity = orderDetail.Quantity + o.Quantity;
                    if (totalQuantity <= 0)
                    {
                        orderDetailDAO.Delete(o.ID);
                        return null;
                    }

                    orderDetailDAO.UpdateQuantity(o.ID, totalQuantity);
                    return orderDetailDAO.FindOneById(o.ID);
                }
            }
            if (orderDetail.Quantity < 1) return null;
            long id = orderDetailDAO.Save(orderId, orderDetail);
            return orderDetailDAO.FindOneById(id);
        }

        public List<OrderDetailDTO> FindAllByOrderId(long orderId)
        {
            orderDetailDAO = OrderDetailDAO.Instance;
            orderDAO = OrderDAO.Instance;
            if (orderDAO.FindOneById(orderId) == null) return null;
            return orderDetailDAO.FindAllByOrderId(orderId);
        }

        public bool Delete(long orderDetailId)
        {
            orderDetailDAO = OrderDetailDAO.Instance;
            return orderDetailDAO.Delete(orderDetailId);
        }

        public OrderDetailDTO Update(long id, OrderDetailDTO orderDetail)
        {
            orderDetailDAO = OrderDetailDAO.Instance;
            OrderDetailDTO oldOrderDetail = orderDetailDAO.FindOneById(id);
            if (oldOrderDetail != null)
            {
                orderDetail.CreatedBy = oldOrderDetail.CreatedBy;
                orderDetail.CreatedDate = oldOrderDetail.CreatedDate;
                orderDetail.ModifiedDate = DateTime.Now;
                if (orderDetailDAO.Update(id, orderDetail))
                    return orderDetailDAO.FindOneById(id);
            }
            return null;
        }
    }
}
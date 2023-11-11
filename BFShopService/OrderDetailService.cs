using BFShopBussinessObjects.Entities;
using BFShopRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopService
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IOrderDetailRepository _orderDetailRepository;
        public OrderDetailService()
        {
            _orderDetailRepository = new OrderDetailRepository();   
        }
        public bool AddNewOrderDetails(List<OrderDetail> orderDetailList)
                => _orderDetailRepository.AddNewOrderDetails(orderDetailList);

        public bool DeleteOrderDetail(string orderID)
                => _orderDetailRepository.DeleteOrderDetail(orderID);

        public List<OrderDetail> GetOrderDetail(string orderID)
                => _orderDetailRepository.GetOrderDetail(orderID);
    }
}

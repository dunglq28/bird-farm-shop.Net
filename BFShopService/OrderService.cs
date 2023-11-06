using BFShopRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopService
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService()
        {
            _orderRepository = new OrderRepository();
        }

        public string createOrderID() => _orderRepository.createOrderID();

    }
}

using BFShopBussinessObjects.Entities;
using BFShopDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopRepository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public bool AddNewOrderDetails(List<OrderDetail> orderDetailList)
                         => OrderDetailDAO.Instance.AddNewOrderDetails(orderDetailList);
        public List<OrderDetail> GetOrderDetail(string orderID)
                         => OrderDetailDAO.Instance.GetOrderDetail(orderID);
    }
}

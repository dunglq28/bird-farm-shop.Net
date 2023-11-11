using BFShopBussinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopService
{
    public interface IOrderDetailService
    {
        bool AddNewOrderDetails(List<OrderDetail> orderDetailList);
        List<OrderDetail> GetOrderDetail(string orderID);
        bool DeleteOrderDetail(string orderID);
    }
}

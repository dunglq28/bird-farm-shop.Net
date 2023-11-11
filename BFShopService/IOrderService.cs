using BFShopBussinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopService
{
    public interface IOrderService
    {
        string createOrderID();
        bool AddNewOrder(Order order);
        Order Search(string orderID);
        bool DeleteOrder(string orderID);
    }
}

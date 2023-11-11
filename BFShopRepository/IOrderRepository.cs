using BFShopBussinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopRepository
{
    public interface IOrderRepository
    {
        string createOrderID();
        bool AddNewOrder(Order order);
        Order Search(string orderID);
        bool DeleteOrder(string orderID);
    }
}

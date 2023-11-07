using BFShopDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopRepository
{
    public class OrderRepository : IOrderRepository
    {
        public string createOrderID() => OrderDAO.Instance.createOrderID();
       
    }
}

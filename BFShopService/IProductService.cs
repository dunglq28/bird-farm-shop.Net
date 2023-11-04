using BFShopBussinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopService
{
    public interface IProductService
    {
        List<Product> GetAllProduct();

        Product GetProductByProductID(string proID);
    }
}

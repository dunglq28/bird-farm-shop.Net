using BFShopBussinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopRepository
{
    public interface IProductRepository
    {
        List<Product> GetAllProduct();

        Product GetProductByProductID(string proID);
    }
}

using BFShopBussinessObjects.Entities;
using BFShopDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopRepository
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetAllProduct() => ProductDAO.Instance.GetAllProduct();

        public Product GetProductByProductID(string proID) => ProductDAO.Instance.GetProductByProductID(proID);

    }
}

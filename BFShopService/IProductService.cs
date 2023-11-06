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
        bool Create(Product product);
        bool Update(string productId, Product product);
        bool Delete(string productId);
        List<Product> Search(string searchValue);
        List<Product> GetAllProduct();
        Product GetProduct(string productId);
        List<Product> GetProducts();
    }
}

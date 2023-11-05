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
        public bool Create(Product product)
            => ProductDAO.Instance.Create(product);

        public bool Delete(string productId)
            => ProductDAO.Instance.Delete(productId);

        public Product GetProduct(string productId)
            => ProductDAO.Instance.GetProduct(productId);

        public List<Product> GetProducts()
            => ProductDAO.Instance.GetProducts();

        public List<Product> Search(string searchValue)
            => ProductDAO.Instance.Search(searchValue);

        public bool Update(string productId, Product product)
            => ProductDAO.Instance.Update(productId, product);
    }
}

using BFShopBussinessObjects.Entities;
using BFShopRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopService
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepo;

        public ProductService()
        {
            _productRepo = new ProductRepository();
        }
        
        public bool Create(Product product)
            => _productRepo.Create(product);
        public bool Delete(string productId)
            => _productRepo.Delete(productId);
        public Product GetProduct(string productId)
            => _productRepo.GetProduct(productId);
        public List<Product> GetProducts()
            => _productRepo.GetProducts();
        public List<Product> Search(string searchValue)
            => _productRepo.Search(searchValue);
        public bool Update(string productId, Product product)
            => _productRepo.Update(productId, product);
    }
}

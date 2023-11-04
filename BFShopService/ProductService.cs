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
        private readonly IProductRepository _repository;
        public ProductService()
        {
            _repository = new ProductRepository();
        }
        public List<Product> GetAllProduct()
        {
            return _repository.GetAllProduct();
        }

        public Product GetProductByProductID(string proID)
        {
            return _repository.GetProductByProductID(proID);
        }

    }
}

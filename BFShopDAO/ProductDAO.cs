using BFShopBussinessObjects.Entities;
using BFShopDAO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopDAO
{
    public class ProductDAO
    {
        private static ProductDAO instance;
        private static object objectLock = new object();


        public static ProductDAO Instance
        {
            get
            {
                lock(objectLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Product> GetAllProduct()
        {
            var context = new Bird_Farm_Shop_PRNContext();
            return context.Products.ToList();
        }

        public Product GetProductByProductID(string proID)
        {
            var context = new Bird_Farm_Shop_PRNContext();
            return context.Products.SingleOrDefault(m => m.ProductId.Equals(proID));
        }

    }
}

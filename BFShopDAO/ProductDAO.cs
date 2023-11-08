using BFShopBussinessObjects.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
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
                lock (objectLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }

        public bool Create(Product product)
        {
            using (var context = new Bird_Farm_Shop_PRNContext())
            {
                context.Products.Add(product);
                return context.SaveChanges() > 0;
            }
        }
        public bool Update(string productId, Product product)
        {
            using (var context = new Bird_Farm_Shop_PRNContext())
            {
                var productEntity = context.Products.Where(x => x.ProductId.Equals(productId))
                                                    .FirstOrDefault();
                if (productEntity is null) return false;

                // update features
                productEntity.ProductName = product.ProductName;
                productEntity.CategoryId = product.CategoryId;
                productEntity.Age = product.Age;
                productEntity.Gender = product.Gender;
                productEntity.Color = product.Color;
                productEntity.QuantityAvailable = product.QuantityAvailable;
                productEntity.QuantitySold = product.QuantitySold;
                productEntity.Price = product.Price;
                productEntity.Characteristics = product.Characteristics;
                productEntity.Detail = product.Detail;
                productEntity.DateCreated = product.DateCreated;
                productEntity.Status = product.Status;
                productEntity.Image = product.Image;

                context.SaveChanges();
                return true;
            }
        }
        public bool Delete(string productId)
        {
            using (var context = new Bird_Farm_Shop_PRNContext())
            {
                var productEntity = context.Products.Where(x => x.ProductId.Equals(productId))
                                                    .FirstOrDefault();
                if (productEntity is null) return false;

                context.Products.Remove(productEntity);
                return context.SaveChanges() > 0;
            }
        }
        public List<Product> Search(string searchValue)
        {
            using (var context = new Bird_Farm_Shop_PRNContext())
            {
                // building query
                var products = context.Products.Include(x => x.Category).AsQueryable();


                var isNumber = false;
                // is integer number
                if (int.TryParse(searchValue, out var num))
                {
                    // flag is number
                    isNumber = true;

                    products = products.Where(x => x.CategoryId == num
                                                || x.QuantityAvailable == num
                                                || Convert.ToInt32(x.QuantitySold) == num);
                }
                // is double number
                if (double.TryParse(searchValue, out var doubleNum))
                {
                    // flag is number
                    isNumber = true;

                    products = products.Where(x => x.Price == doubleNum);
                }

                // is string and not a number
                if (!String.IsNullOrEmpty(searchValue) && !isNumber)
                {
                    products = products.Where(x => x.ProductName.Contains(searchValue)
                                                || x.ProductId.Contains(searchValue)
                                                || x.Age.Contains(searchValue)
                                                || x.Color.Contains(searchValue)
                                                || x.Gender.Contains(searchValue)
                                                || x.Characteristics.Contains(searchValue)
                                                || x.Detail.Contains(searchValue)
                                                || x.Status.Contains(searchValue)
                                                || x.Category.CategoryName.Contains(searchValue));
                }

                var result = products.ToList();

                // is datetime
                if (DateTime.TryParse(searchValue, out var date))
                {
                    var dateFormat = DateTime.ParseExact(searchValue,
                        "yyyy-MM-dd", CultureInfo.InvariantCulture);

                    var productsByDate = result.Where(x
                        => Convert.ToDateTime(x.DateCreated).ToString("yyyy-MM-dd").Equals(dateFormat))
                                               .ToList();

                    return productsByDate;
                }

                return result;
            }
        }

        public List<Product> GetAllProduct()
        {
            using (var context = new Bird_Farm_Shop_PRNContext())
            {
                return context.Products.ToList();
            }
        }

        public Product GetProduct(string productId)
        {
            using (var context = new Bird_Farm_Shop_PRNContext())
            {
                return context.Products.Where(x => x.ProductId.Equals(productId))
                                       .Include(x => x.Category)
                                       .FirstOrDefault();
            }
        }
        public List<Product> GetProducts()
        {
            using (var context = new Bird_Farm_Shop_PRNContext())
            {
                return context.Products.Include(x => x.Category).ToList();
            }
        }
    }
}

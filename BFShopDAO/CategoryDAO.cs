using BFShopBussinessObjects.Entities;
using BFShopDAO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopDAO
{
    public class CategoryDAO
    {
        private static object objectLock= new object();
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get
            {
                lock (objectLock)
                {
                    if (instance == null)
                    {
                        instance = new CategoryDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Category> GetCategories()
        {
            using(var context = new Bird_Farm_Shop_PRNContext())
            {
                // get all category
                return context.Categories.ToList();
            }
        }

        public Category GetCategory(int categoryId)
        {
            using (var context = new Bird_Farm_Shop_PRNContext())
            {
                // get category by id
                return context.Categories.Where(x => x.CategoryId == categoryId)
                                         .FirstOrDefault();
            }
        }

        public bool Create(Category category)
        {
            // init dbContext
            using(var context = new Bird_Farm_Shop_PRNContext())
            {
                // create new category
                context.Categories.Add(category);
                // save changes
                return context.SaveChanges() > 0;
            }
        }

        public void Update(int categoryId, Category category)
        {
            using(var context = new Bird_Farm_Shop_PRNContext())
            {
                // get category by id 
                var categoryEntity = context.Categories.Where(x => x.CategoryId == categoryId)
                                                       .FirstOrDefault();
                // not found
                if (categoryEntity is null) return;

                // update features
                categoryEntity.CategoryName = category.CategoryName;

                // save changes
                context.SaveChanges();
            }
        }

        public bool Delete(int categoryId)
        {
            using(var context = new Bird_Farm_Shop_PRNContext())
            {
                // get category by id
                var categoryEntity = context.Categories.Where(x => x.CategoryId == categoryId)
                                                       .FirstOrDefault();
                if (categoryEntity is null) return false;

                // delete category 
                context.Categories.Remove(categoryEntity);

                // save changes
                return context.SaveChanges() > 0;
            }
        }

        public List<Category> Search(string searchValue)
        {
            using(var context = new Bird_Farm_Shop_PRNContext())
            {
                // building query
                var categories = context.Categories.AsQueryable();

                var isNumber = false;
                if(int.TryParse(searchValue, out int num))
                {
                    // flag is a number
                    isNumber = true;

                    // search category Id
                    categories = categories.Where(x => x.CategoryId 
                        == Convert.ToInt32(num));
                }

                if (!String.IsNullOrEmpty(searchValue) && !isNumber)
                {
                    // search category
                    categories = categories.Where(x => x.CategoryName.Contains(searchValue));
                }

                return categories.ToList();
            }
        }
    }
}

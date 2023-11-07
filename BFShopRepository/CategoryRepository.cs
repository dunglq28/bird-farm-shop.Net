using BFShopBussinessObjects.Entities;
using BFShopDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        public bool Create(Category category)
            => CategoryDAO.Instance.Create(category);

        public bool Delete(int categoryId)
            => CategoryDAO.Instance.Delete(categoryId);

        public List<Category> GetCategories()
            => CategoryDAO.Instance.GetCategories();

        public Category GetCategory(int categoryId)
            => CategoryDAO.Instance.GetCategory(categoryId);

        public List<Category> SearchCategory(string searchValue)
            => CategoryDAO.Instance.Search(searchValue);
        public void Update(int categoryId, Category category)
            => CategoryDAO.Instance.Update(categoryId, category);
    }
}

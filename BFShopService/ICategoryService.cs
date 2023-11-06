using BFShopBussinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopService
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        Category GetCategory(int categoryId);
        bool Create(Category category);
        void Update(int categoryId, Category category);
        bool Delete(int categoryId);
        List<Category> SearchCategory(string searchValue);
    }
}

using BFShopBussinessObjects.Entities;
using BFShopRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopService
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepo;

        public CategoryService()
        {
            _categoryRepo = new CategoryRepository();
        }

        public bool Create(Category category)
            => _categoryRepo.Create(category);

        public bool Delete(int categoryId)
            => _categoryRepo.Delete(categoryId);

        public List<Category> GetCategories()
            => _categoryRepo.GetCategories();

        public Category GetCategory(int categoryId)
            => _categoryRepo.GetCategory(categoryId);

        public List<Category> SearchCategory(string searchValue)
            => _categoryRepo.SearchCategory(searchValue);

        public void Update(int categoryId, Category category)
            => _categoryRepo.Update(categoryId, category);
    }
}

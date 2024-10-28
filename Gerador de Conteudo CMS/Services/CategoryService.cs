using System.Collections.Generic;
using ContentManagementSystem.Models;

namespace ContentManagementSystem.Services
{
    public class CategoryService
    {
        private List<Category> categories = new List<Category>();

        public void AddCategory(Category category)
        {
            categories.Add(category);
        }

        public List<Category> GetAllCategories()
        {
            return categories;
        }
    }
}

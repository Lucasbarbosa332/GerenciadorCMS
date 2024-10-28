using System;
using ContentManagementSystem.Models;
using ContentManagementSystem.Services;

namespace ContentManagementSystem.Controllers
{
    public class CategoryController
    {
        private CategoryService categoryService = new CategoryService();

        public void AddCategory()
        {
            Console.Write("Digite o nome da categoria: ");
            var name = Console.ReadLine();
            var category = new Category(name);
            categoryService.AddCategory(category);
        }

        public void ListCategories()
        {
            var categories = categoryService.GetAllCategories();
            foreach (var category in categories)
            {
                Console.WriteLine($"Categoria: {category.Name}");
            }
        }
    }
}

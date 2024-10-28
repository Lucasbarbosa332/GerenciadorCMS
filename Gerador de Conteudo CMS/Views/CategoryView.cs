using System;
using System.Collections.Generic;
using ContentManagementSystem.Models;
using ContentManagementSystem.Utils;

namespace ContentManagementSystem.Views
{
    public class CategoryView
    {
        public void DisplayCategories(List<Category> categories)
        {
            foreach (var category in categories)
            {
                Console.WriteLine(category.Name);
            }
        }
    }
}

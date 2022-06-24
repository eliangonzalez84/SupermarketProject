using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.PluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryRepository : ICategoryRepository
    {
        private List<Category> categories;

        public CategoryRepository()
        {
            categories = new List<Category>() { new Category { CategoryId = 1, Name = "Panaderia", Description = "Vende panes, Galletitas" } };
            categories.Add(new Category { CategoryId = 1, Name = "Carniceria", Description = "Vende cortes de carne" });
            categories.Add(new Category { CategoryId = 1, Name = "Electronica", Description = "Vende productos de electro" });
        }

        public void AddCategory(Category category)
        {
            if (categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;
            var maxId = categories.Max(x => x.CategoryId);
            category.CategoryId = maxId + 1;

            categories.Add(category);
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }
    }
}

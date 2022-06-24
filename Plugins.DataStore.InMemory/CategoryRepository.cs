using CoreBusiness;
using System;
using System.Collections.Generic;
using UseCases.PluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryRepository : ICategoryRepository
    {
        private List<Category> categories;

        public CategoryRepository()
        {
            categories = new List<Category>() { new Category { CategoryId = 1, Name = "Panaderia", Description = "Vende panes, Galletitas" } };
            categories = new List<Category>() { new Category { CategoryId = 1, Name = "Carniceria", Description = "Vende cortes de carne" } };
            categories = new List<Category>() { new Category { CategoryId = 1, Name = "Electronica", Description = "Vende productos de electro" } };
        }
        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }
    }
}

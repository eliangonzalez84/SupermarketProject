using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products;
        public ProductRepository()
        {
            products = new List<Product>(){ 
                new Product { ProductId = 1, CategoryId = 1, Name = "Te helado", Quantity = 100, Price = 1.99} ,
                new Product { ProductId = 2, CategoryId = 1, Name = "Te Canadiense", Quantity = 200, Price = 2.99} ,
                new Product { ProductId = 3, CategoryId = 2, Name = "Bife ancho", Quantity = 300, Price = 4.99} ,
                new Product { ProductId = 4, CategoryId = 2, Name = "Bife angosto", Quantity = 200, Price = 4}
            };
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}

﻿using CoreBusiness;
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

        public void AddProduct(Product product)
        {
            if (products.Any(x => x.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (products != null && products.Count > 0)
            {
                var maxId = products.Max(x => x.ProductId);
                product.ProductId = maxId + 1;
            }
            else
            {
                product.ProductId = 1;
            }

            products.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            var productToUpdate = GetProductById(product.ProductId);
            if (productToUpdate != null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.CategoryId = product.CategoryId;
                productToUpdate.Price = product.Price;
                productToUpdate.Quantity = product.Quantity;
            }
        }

        public Product GetProductById(int productId)
        {
            return products.FirstOrDefault(x => x.ProductId == productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }

        public void DeleteProduct(int productId)
        {
            products?.Remove(GetProductById(productId));
        }

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            return products.Where(x => x.CategoryId == categoryId);
        }
    }
}

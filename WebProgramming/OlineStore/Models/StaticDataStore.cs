using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace OnlineStore.Models
{
    public static class StaticDataStore
    {
        static List<Product> Products { get; set; } = new List<Product>();

        public static List<Product> GetAll() => new List<Product> 
        { 
            new Product{ Id=100, Name="Football-1", Description="Pakistan's professional Football"}, 
            new Product{ Id=101, Name="Football-2", Description="Pakistan's professional Football"}, 
            new Product{ Id=102, Name="Football-3", Description="Pakistan's professional Football"}, 
            new Product{ Id=103, Name="Football-4", Description="Pakistan's professional Football"}, 
            new Product{ Id=104, Name="Football-5", Description="Pakistan's professional Football"}, 
        };

        public static List<Product> CreateDummyProduct(int howMuch = 15)
        {
            int start = 100, end = start + howMuch;
            // Create a list to store 15 products
            List<Product> productList = new List<Product>();

            // Generate 15 products with dummy data
            for (int i = start; i <= end; i++)
            {
                Product product = new Product
                {
                    Id = i,
                    Name = $"Product {i}",
                    Description = $"Description for Product {i}"
                };

                // Add the product to the list
                productList.Add(product);
            }
            return productList;
        }

        public static void AddProduct(Product product) => Products.Add(product);
    }
}
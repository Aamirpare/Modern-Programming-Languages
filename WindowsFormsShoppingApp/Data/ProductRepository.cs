using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShoppingApp.Data
{
    internal class ProductRepository
    {
        List<Product> products = new List<Product>();
        public ProductRepository()
        {
             products.AddRange(new List<Product>() 
             { 
                new Product{ Id=1, Name="Samsung Note 20", Price = 120000.0M },
                new Product{ Id=2, Name="Infinix Note 13", Price = 960000.0M },
                new Product{ Id=3, Name="Redme Note 12", Price = 72000.0M },
                new Product{ Id=4, Name="Samsung Galaxy", Price = 90000.0M },
             });
        }

        public List<Product> GetProducts() 
        {
            return products;
        }
    }
}

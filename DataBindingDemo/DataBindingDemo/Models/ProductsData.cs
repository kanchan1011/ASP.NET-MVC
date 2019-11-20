using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataBindingDemo.Models;
namespace DataBindingDemo.Models
{
    public class ProductsData
    {        
        public IEnumerable<Product> GetProducts
            {
                 get
                 {
                        List<Product> products = new List<Product>()
                       {
                            new Product { ProductId = 1,Name = "Samsung TV", Price = 30000.56  },
                            new Product { ProductId = 2, Name = "Nike Shoes",Price = 4000.50 },
                            new Product  {ProductId = 3,Name = "Shoes", Price = 3000.50 }
                        };
                    return products;
                 }
            }
    }
}
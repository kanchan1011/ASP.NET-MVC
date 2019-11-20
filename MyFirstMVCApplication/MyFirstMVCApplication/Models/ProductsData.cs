using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyFirstMVCApplication.Models;
namespace MyFirstMVCApplication.Models
{
    public class ProductsData
    {
        public IEnumerable<Product> GetProducts
        {
            get
            {
                List<Product> products = new List<Product>()
            {
                new Product {ProductId=1,ProductName="Samsung TV",Price=30000.67,CategoryId=1 },
                new Product {ProductId=2,ProductName="Mobile",Price=17000.07,CategoryId=1 },
                new Product {ProductId=3,ProductName="T-Shirt",Price=30000.67,CategoryId=2 },
                new Product {ProductId=4,ProductName="Cotten-Jeans",Price=30000.67,CategoryId=2 },
                new Product {ProductId=5,ProductName="Men's Casual Shooes",Price=30000.67,CategoryId=3 },
                new Product {ProductId=6,ProductName="Women's Sport Shoes",Price=30000.67,CategoryId=3 }

            };
                return products;
            }
        }
    }
}
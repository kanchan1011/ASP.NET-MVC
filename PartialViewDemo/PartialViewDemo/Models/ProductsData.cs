using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialViewDemo.Models
{
    public class ProductsData
    {
        public IEnumerable<Product> GetProducts
        {
            get
            {
                List<Product> products = new List<Product>()
                {
                   new Product {ProductId=1,Name="Samsung TV", Price=30000.57,Photo="~/Images/tv.jpg" },

                   new Product {ProductId=2,Name="Mobile", Price=13000.50,Photo="~/Images/mobile.jpg" },

                   new Product {ProductId=3,Name="Shoes", Price=3000.47,Photo="~/Images/shoes.jpg" },

                   new Product {ProductId=4,Name="Casual Shirt", Price=2000.57,Photo="~/Images/shirt.jpg" },
                };
                return products;
            }
        }
    }
}
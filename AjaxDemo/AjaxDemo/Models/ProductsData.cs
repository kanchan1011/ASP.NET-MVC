using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxDemo.Models
{
    public class ProductsData
    {
        public IEnumerable<Product> GetProducts
        {
            get
            {
                List<Product> products = new List<Product>()
                {
                   new Product {ProductId=1,Name="Samsung TV", Price=30000.57},

                   new Product {ProductId=2,Name="Mobile", Price=13000.50 },

                   new Product {ProductId=3,Name="Shoes", Price=3000.47},

                   new Product {ProductId=4,Name="Nike Sports Shoes", Price=2000.57},
                };
                return products;
            }
        }
    }
}
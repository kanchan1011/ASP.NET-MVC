using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MulitpleModelsDemo.Models
{
    public class ShoppingData
    {
        public IEnumerable<Category> GetCategories
        {
            get
            {
                List<Category> categories = new List<Category>()
                    {
                        new Category {CategoryId=1,
                        CategoryName="Electronics"},

                        new Category {CategoryId=2,
                        CategoryName="Shoes"}
                    };
                return categories;
            }
        }

        public IEnumerable<Product> GetProducts
        {
            get
            {
                List<Product> products = new List<Product>()
                {
                    new Product {ProductId=1,ProductName="Samsung TV",Price=50000.40,Category_CategoryId=1},
                    new Product {ProductId=2,ProductName="Nike Casual",Price=2000.43,Category_CategoryId=2 },
                    new Product {ProductId=3,ProductName="Mobile",Price=15000.75,Category_CategoryId=1 },
                    new Product {ProductId=4,ProductName="Puma Sports Shoes",Price=4000.76,Category_CategoryId=2 },

                };
                return products;
            }
        }
    }
}
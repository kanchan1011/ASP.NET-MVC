using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyFirstMVCApplication.Models;
namespace MyFirstMVCApplication.Models
{
    public class CategoriesData
    {
        public IEnumerable<Category> GetCategories
        {
            get
            {
                List<Category> categories = new List<Category>()
            {
                new Category {CategoryId=1,Name="Electronic" },

                new Category {CategoryId=2,Name="Cloths" },

                new Category {CategoryId=3,Name="Footwear" },
            };
                return categories;
            }

        }
    }
}
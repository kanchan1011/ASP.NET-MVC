using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AjaxDemo.Models;
namespace AjaxDemo.Models
{
    public class CategoriesData
    {
        public IEnumerable<Category> GetCategoies
        {
            get
            {
                List<Category> categories = new List<Category>()
                {
                   new Category {CategoryId=1,CategoryName="Electronic"},

                   new Category{CategoryId=2, CategoryName="Shoes" }

                      };
                return categories;
            }
        }
    }
}
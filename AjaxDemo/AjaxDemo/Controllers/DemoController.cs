using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxDemo.Models;
namespace AjaxDemo.Controllers
{
    public class DemoController : Controller
    {
        ProductsData pd = new ProductsData();
        CategoriesData cd = new CategoriesData();
        public PartialViewResult Products()
        {
            return PartialView(pd.GetProducts);
        }
        public PartialViewResult Categories()
        {
            return PartialView(cd.GetCategoies);
        }
        public ViewResult Index()
        {
            return View();
        }
    }
}
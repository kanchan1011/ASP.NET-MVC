using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxDemo.Models;
using System.Threading;
namespace AjaxDemo.Controllers
{
    public class ProductsController : Controller
    {
       ProductsData db= new ProductsData();
        public PartialViewResult Grid()
        {
            return PartialView();
        }
        public PartialViewResult OrderById()
        {
            Thread.Sleep(5000);
            List<Product> products = db.GetProducts.OrderBy(x=>x.ProductId).ToList();
                return PartialView("Grid", products);
        }
        public PartialViewResult OrderByName()
        {
            Thread.Sleep(5000);
            List<Product> products = db.GetProducts.OrderBy(x => x.Name).ToList();
            return PartialView("Grid", products);
        }
        public PartialViewResult OrderByPrice()
        {
            Thread.Sleep(5000);
            List<Product> products = db.GetProducts.OrderBy(x => x.Price).ToList();
            return PartialView("Grid", products);
        }
        public ViewResult Index()
        { return View();
        }
    }
}
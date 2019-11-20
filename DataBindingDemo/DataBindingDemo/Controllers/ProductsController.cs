using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataBindingDemo.Models;
namespace DataBindingDemo.Controllers
{
    public class ProductsController : Controller
    {
        ProductsData db = new ProductsData();

        public ViewResult Index()
        {
            return View(db.GetProducts);
        }
        public ViewResult Details(int id)
        {
            return View(db.GetProducts.Single(x=> x.ProductId==id));
        }

    }
}
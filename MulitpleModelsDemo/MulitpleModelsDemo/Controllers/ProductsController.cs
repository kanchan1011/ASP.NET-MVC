using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MulitpleModelsDemo.Models;
namespace MulitpleModelsDemo.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        ShoppingData db = new ShoppingData();
        public ViewResult Index(int id)
        {
            return View(db.GetProducts.Where(x=>x.Category_CategoryId==id).ToList());
        }
        public ViewResult Details(int id)
        {
            return View(db.GetProducts.Single(x=>x.ProductId==id));
        }
    }
}
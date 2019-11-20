using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MulitpleModelsDemo.Models;
namespace MulitpleModelsDemo.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        ShoppingData db = new ShoppingData();
        public ViewResult Index()
        {
            return View(db.GetCategories);
        }
    }
}
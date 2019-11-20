using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstMVCApplication.Models;
namespace MyFirstMVCApplication.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        ProductsData pd = new ProductsData();
        public ViewResult Index()
        {
            return View();
        }
        public FileResult Tutorial()
        {
             //"application/pdf" is MIME type which is get from IIS
            return File("~/Kanchan/PDF FILES/asp.dpf", "application/pdf");
       }
        public FileResult Ado()
        {
            return File("~/Desktop/Kanchan Dhanawade CV.docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
        }
        public JsonResult API()
        {
            return Json(pd.GetProducts, JsonRequestBehavior.AllowGet);
        }

    }
}
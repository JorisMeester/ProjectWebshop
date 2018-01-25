using ProjectWebshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProjectWebshop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About us.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us.";

            return View();
        }

        //public ActionResult ProductPage()
        //{
        //    ViewBag.Message = "Product page.";

        //    return View();
        //}

        //public ActionResult ProductOverview()
        //{
        //    ViewBag.Message = "Products overview.";

        //    return View();
        //}

        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Products
        public ActionResult ProductOverview()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult ProductPage(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
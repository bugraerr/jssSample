using NetMVC.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetMVC.UI.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Home()
        {
            NORTHWND2Entities db = new NORTHWND2Entities();
            List<Product> urunListesi = db.Products.ToList();
            return View(urunListesi);
        }
        public ActionResult Abaout()
        {
            return View();
        }

        public ActionResult Iletisim()
        {
            return View();
        }

        public ActionResult NewProduct()
        {

            return View(new Product());
        }
        [HttpPost]
        public ActionResult NewProduct(Product eklenecekVeri)
        {

            NORTHWND2Entities db = new NORTHWND2Entities();
            db.Products.Add(eklenecekVeri);
            int donenVeri = db.SaveChanges();
            if (donenVeri > 0)

            {
                return RedirectToAction("Home");
            }
            else
            {
                return RedirectToAction("Hata");
            }
        }
    }
}
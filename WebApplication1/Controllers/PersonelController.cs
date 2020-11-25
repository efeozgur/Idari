using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PersonelController : Controller
    {
        EDataEntities db = new EDataEntities();

        // GET: Personel
        public ActionResult Add()
        {

            return View();
        }


        [HttpPost]
        public ActionResult Add(tblKisi p)
        {
            db.tblKisi.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index", "Ana");
        }

    }
}
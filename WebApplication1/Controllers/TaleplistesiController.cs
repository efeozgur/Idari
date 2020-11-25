
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TaleplistesiController : Controller
    {
        EDataEntities db = new EDataEntities();
        // GET: Taleplistesi
        public ActionResult Index()
        {            
            return View(db.Talep.ToList());
        }
    }
}
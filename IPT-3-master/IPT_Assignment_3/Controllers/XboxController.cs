using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IPT_Assignment_3.Models;
using System.Data.Entity;

namespace IPT_Assignment_3.Controllers
{
    public class XboxController : Controller
    {
        GamesEntities db = new GamesEntities();
        // GET: Xbox
        public ActionResult Index()
        {
            var data = db.Xboxes.ToList();
            return View(data);
        }


        // GET: Xbox/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Xbox/Create
        [HttpPost]
        public ActionResult Create(Xbox xb)
        {
            try
            {
                var data = db.Entry(xb).State = System.Data.Entity.EntityState.Added;
                int a = db.SaveChanges();
                if (a > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(data);
                }
            }
            catch
            {
                return View();
            }
        }

    }
}

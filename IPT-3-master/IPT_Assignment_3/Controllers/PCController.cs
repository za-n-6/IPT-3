using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IPT_Assignment_3.Models;
using System.Data.Entity;

namespace IPT_Assignment_3.Controllers
{
    public class PCController : Controller
    {
        GamesEntities db = new GamesEntities();
        // GET: PC
        public ActionResult Index()
        {
            var data = db.PCs.ToList();
            return View(data);
        }

        // GET: PC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PC/Create
        [HttpPost]
        public ActionResult Create(PC pg)
        {
            try
            {
                // TODO: Add insert logic here

                var data = db.Entry(pg).State = System.Data.Entity.EntityState.Added;
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

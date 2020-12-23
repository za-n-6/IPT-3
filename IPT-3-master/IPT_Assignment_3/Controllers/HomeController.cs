using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IPT_Assignment_3.Models;
using System.Data.Entity;

namespace IPT_Assignment_3.Controllers
{
    public class HomeController : Controller
    {
        GamesEntities db = new GamesEntities();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.PS4.ToList();
            return View(data);
        }

       
        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(PS4 ps)
        {
            try
            {
                // TODO: Add insert logic here

                var data = db.Entry(ps).State = System.Data.Entity.EntityState.Added;
                int a = db.SaveChanges();
                if(a > 0)
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

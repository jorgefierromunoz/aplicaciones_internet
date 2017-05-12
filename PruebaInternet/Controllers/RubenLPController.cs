using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaInternet.Controllers
{
    public class RubenLPController : Controller
    {
        //
        // GET: /RubenLP/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /RubenLP/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /RubenLP/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /RubenLP/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /RubenLP/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /RubenLP/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /RubenLP/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /RubenLP/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

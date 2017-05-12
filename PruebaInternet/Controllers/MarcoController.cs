using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaInternet.Controllers
{
    public class MarcoController : Controller
    {
        //
        // GET: /Marco/

        public ActionResult Index()
        {

            Console.WriteLine("Ahi te va tu controler putito");

            return View();
        }

    }
}

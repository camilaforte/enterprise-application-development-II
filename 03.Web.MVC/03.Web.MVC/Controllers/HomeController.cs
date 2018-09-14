using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03.Web.MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //metodo que iniciará a pagina, coloco login pq é o que vai ficar na url
        public ActionResult Login()
        {
            return View();
        }
    }
}
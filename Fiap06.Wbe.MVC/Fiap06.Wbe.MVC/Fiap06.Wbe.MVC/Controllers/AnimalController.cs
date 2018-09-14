using Fiap06.Wbe.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap06.Wbe.MVC.Controllers
{
    public class AnimalController : Controller
    {

        private PetShopContext _context = new PetShopContext();
        
        // GET: Animal

        
        public ActionResult Cadastrar()
        {
            _context.add
            return View();
        }
    }
}
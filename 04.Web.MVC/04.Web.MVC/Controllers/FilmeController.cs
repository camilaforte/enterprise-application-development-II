using _04.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04.Web.MVC.Controllers
{
    public class FilmeController : Controller
    {
        //atributos
       

        // GET: Filme

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Filme filme)
        {
            //passar valores para view
            ViewBag.titulo = filme.nome;
            //este sobrevive apos redirct
            TempData["genero"] = filme.genero;
        
            

            //content retorna um texto no browser
            //return Content(filme.nome);  
            return View(filme);
        }


    }
}
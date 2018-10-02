using Fiap08.Web.MVC.Models;
using Fiap08.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap08.Web.MVC.Controllers
{
    public class ResponsavelController : Controller
    {

        private UnitOfWork _unit = new UnitOfWork();

        // GET: Responsavel
        public ActionResult Cadastrar()
        {
            return View();
        }

        //POST
        [HttpPost]
        public ActionResult Cadastrar(Responsavel resp)
        {
            _unit.ResponsavelRepository.Cadastrar(resp);
            _unit.Salvar();
            TempData["msg"] = "Responsavel cadastrado!";
            return RedirectToAction("Cadastrar");
        }

        // liberar os recursos (conexao com o banco)
        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }

    }

}
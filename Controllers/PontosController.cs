using Direct_TJBA.DAO;
using Direct_TJBA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Direct_TJBA.Controllers
{
    public class PontosController : Controller
    {
        private PontoDAO dao;
        private ReferenciaDAO daoReferencia;

        public PontosController(PontoDAO dao, ReferenciaDAO daoReferencia)
        {
            this.dao = dao;
            this.daoReferencia = daoReferencia;
        }
        //
        // GET: /Pontos/

        public ActionResult Index()
        {
            IList<Ponto> pontos = dao.Lista();
            return View(pontos);
        }

        //
        // GET: /Pontos/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Pontos/Create

        public ActionResult Create()
        {
            IList<Referencia> referencias = daoReferencia.Lista();
            ViewBag.Referencias = referencias;
            return View();
        }

        //
        // POST: /Pontos/Create

        [HttpPost]
        public ActionResult Create(Ponto ponto)
        {
            try
            {
                // TODO: Add insert logic here
                this.dao.Adiciona(ponto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Pontos/Edit/5

        public ActionResult Edit(int id)
        {
            IList<Referencia> referencias = daoReferencia.Lista();
            ViewBag.Referencias = referencias;
            Ponto ponto = this.dao.BuscaPorId(id);
            return View(ponto);
        }

        //
        // POST: /Pontos/Edit/5

        [HttpPost]
        public ActionResult Edit(Ponto ponto)
        {
            try
            {
                // TODO: Add update logic here
                this.dao.Atualiza(ponto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Pontos/Delete/5

        public ActionResult Delete(int id)
        {
            Ponto ponto = this.dao.BuscaPorId(id);
            return View(ponto);
        }

        //
        // POST: /Pontos/Delete/5

        [HttpPost]
        public ActionResult Delete(Ponto ponto)
        {
            try
            {
                // TODO: Add delete logic here
                this.dao.Deleta(ponto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

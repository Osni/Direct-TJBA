using Direct_TJBA.DAO;
using Direct_TJBA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Direct_TJBA.Controllers
{
    public class TipoReferenciasController : Controller
    {
        private TipoReferenciaDAO dao;

        public TipoReferenciasController(TipoReferenciaDAO dao)
        {
            this.dao = dao;
        }
        //
        // GET: /TipoReferencias/

        public ActionResult Index()
        {
            IList<TipoReferencia> tipos = dao.Lista();
            return View(tipos);
        }

        public ActionResult Form()
        {
            return View();
        }

        //
        // GET: /TipoReferencias/Details/5

        public ActionResult Details(int id)
        {
            TipoReferencia tipo = dao.BuscaPorId(id);
            return View(tipo);
        }

        //
        // GET: /TipoReferencias/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TipoReferencias/Create

        [HttpPost]
        public ActionResult Create(TipoReferencia tipo)
        {
            try
            {
                // TODO: Add insert logic here
                this.dao.Adiciona(tipo);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /TipoReferencias/Edit/5

        public ActionResult Edit(int id)
        {
            TipoReferencia tipo = dao.BuscaPorId(id);
            return View(tipo);
        }

        //
        // POST: /TipoReferencias/Edit/5

        [HttpPost]
        public ActionResult Edit(TipoReferencia tipo)
        {
            try
            {
                // TODO: Add update logic here
                dao.Atualiza(tipo);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /TipoReferencias/Delete/5

        public ActionResult Delete(int id)
        {
            TipoReferencia tipo = dao.BuscaPorId(id);            
            return View(tipo);
        }

        //
        // POST: /TipoReferencias/Delete/5

        [HttpPost]
        public ActionResult Delete(TipoReferencia tipo)
        {
            try
            {
                // TODO: Add delete logic here
                dao.Deleta(tipo);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

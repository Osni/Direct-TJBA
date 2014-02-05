using Direct_TJBA.DAO;
using Direct_TJBA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Direct_TJBA.Controllers
{
    public class ReferenciasController : Controller
    {
        private ReferenciaDAO dao;
        private TipoReferenciaDAO daoTipos;
        
        public ReferenciasController(ReferenciaDAO dao,TipoReferenciaDAO daoTipos)
        {
            this.dao = dao;
            this.daoTipos = daoTipos;
        }
        //
        // GET: /Referencias/

        public ActionResult Index()
        {
            IList<Referencia> referencias = dao.Lista();
            return View(referencias);
        }

        //
        // GET: /Referencias/Details/5

        public ActionResult Details(int id)
        {
            Referencia referencia = dao.BuscaPorId(id);
            return View(referencia);
        }

        //
        // GET: /Referencias/Create

        public ActionResult Create()
        {
            IList<TipoReferencia> tipos = daoTipos.Lista();
            ViewBag.TipoReferencia = tipos;
            return View();
        }

        //
        // POST: /Referencias/Create

        [HttpPost]
        public ActionResult Create(Referencia referencia)
        {
            try
            {
                // TODO: Add insert logic here
                this.dao.Adiciona(referencia);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Referencias/Edit/5

        public ActionResult Edit(int id)
        {
            IList<TipoReferencia> tipos = daoTipos.Lista();
            ViewBag.TipoReferencia = tipos;
            Referencia referencia = this.dao.BuscaPorId(id);
            return View(referencia);
        }

        //
        // POST: /Referencias/Edit/5

        [HttpPost]
        public ActionResult Edit(Referencia referencia)
        {
            try
            {
                // TODO: Add update logic here
                this.dao.Atualiza(referencia);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Referencias/Delete/5

        public ActionResult Delete(int id)
        {
            Referencia referencia = this.dao.BuscaPorId(id);            
            return View(referencia);
        }

        //
        // POST: /Referencias/Delete/5

        [HttpPost]
        public ActionResult Delete(Referencia referencia)
        {
            try
            {
                // TODO: Add delete logic here
                this.dao.Deleta(referencia);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

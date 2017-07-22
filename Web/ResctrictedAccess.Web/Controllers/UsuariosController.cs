using ResctrictedAccess.Web.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResctrictedAccess.Web.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Index()
        {
            return View();
        }

        // GET: Usuarios/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            using (var db = new FabricaAppRADbContext())
            {
                return View(new Models.Usuarios.Index.ViewModel
                {
                    //Usuarios = db.Usuarios.ToArray()
                });
            }
        }

        // POST: Usuarios/Create
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

        // GET: Usuarios/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Usuarios/Edit/5
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

        // GET: Usuarios/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuarios/Delete/5
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

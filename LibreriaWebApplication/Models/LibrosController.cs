using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
// vamos a usar la referencia al wcf  de la libreria ObtenerLibros
using LibreriaWebApplication.ServiceReference1  ;

namespace LibreriaWebApplication.Models
{
    public class LibrosController : Controller
    {
        // instanciamos el servicio wcf para obtener los metodos 
        LibreriaClient servicio = new LibreriaClient();

        public ActionResult Index()
        {
            // obtenemos la lista de libros
            var lista = servicio.ObtenerLibros();
            // retornamos la vista con la lista de libros
            return View(lista);
          
        }

        // GET: Libros/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Libros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Libros/Create
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

        // GET: Libros/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Libros/Edit/5
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

        // GET: Libros/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Libros/Delete/5
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibreriaFrontEnd.Models;

namespace LibreriaFrontEnd.Controllers
{
    public class LibrosController : Controller
    {
        // GET: Libros
        ServiceReference1.LibreriaClient ru = new ServiceReference1.LibreriaClient();

        public ActionResult Index()
        {
            // Vamos a obtener los datos de el metodo obtenerLibros
            List<Libros> libros = new List<Libros>();
            var result = ru.ObtenerLibros();

            foreach (var item in result)
            {
                Libros libro = new Libros();
                libro.ID = item.ID;
                libro.Título = item.Título;
                libro.IDAutor = item.IDAutor;
                libros.Add(libro);
            }

            return View(libros);

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

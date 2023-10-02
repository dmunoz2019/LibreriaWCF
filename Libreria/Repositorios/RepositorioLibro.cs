using Libreria.Data;
using Libreria.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core;
using System.Linq;
using System.Web;

namespace Libreria.Repositorios
{
    public class RepositorioLibro : IRepositorioLibro
    {
        private SistemaGestionLibrosEntities db;

        public RepositorioLibro(SistemaGestionLibrosEntities context)
        {
            this.db = context;
        }

        public ObjectResult<sp_GetAutorYLibrosPorLibroId_Result> ObtenerAutorPorLibro(int libroid)
        {
            try
            {
                return db.sp_GetAutorYLibrosPorLibroId(libroid);
            }
            catch (EntityException ex)
            {
                throw new Exception("Error al acceder a la base de datos: " + ex.Message);
            }
        }

        public IEnumerable<Libro> ObtenerLibros()
        {
            try
            {
                ObjectResult<sp_GetAllBooks_Result> libros = db.sp_GetAllBooks();
                List<Libro> listaLibros = new List<Libro>();
                foreach (sp_GetAllBooks_Result libro in libros)
                {
                    Libro libroitem = new Libro
                    {
                        ID = libro.ID,
                        Título = libro.Título,
                        IDAutor = libro.IDAutor
                    };
                    listaLibros.Add(libroitem);
                }

                return listaLibros;
            }
            catch (EntityException ex)
            {
                throw new Exception("Error al acceder a la base de datos: " + ex.Message + "/" + ex.InnerException);
            }
        }

        void IRepositorioLibro.ActualizarLibro(int id, string Título, int Año, int IDAutor)
        {
            // vamos a actualizar un libro
            try
            {
                db.sp_UpdateLibro(id, Título, Año, IDAutor);
            }
            catch (EntityException ex)
            {
                throw new Exception("Error al acceder a la base de datos: " + ex.Message);
            }
        }

        void IRepositorioLibro.AgregarLibro(string Título, int Año, string NombreAutor)
        {
            // Vamos a insertar un libro
            try
            {
                db.sp_CreateLibro(Título, Año, NombreAutor);
            }
            catch (EntityException ex)
            {
                throw new Exception("Error al acceder a la base de datos: " + ex.Message);
            }
        }

        void IRepositorioLibro.EliminarLibro(int id)
        {
            // Vamos a borrar un libro
            try
            {
                db.sp_DeleteLibro(id);

            }
            catch (EntityException ex)
            {
                throw new Exception("Error al acceder a la base de datos: " + ex.Message);
            }
        }

        public Libro ObtenerLibroPorId(int id)
        {
            try
            {
                ObjectResult<sp_GetLibroById_Result> libroResult = db.sp_GetLibroById(id);
                var libroData = libroResult.FirstOrDefault();
                if (libroData == null)
                {
                    return null;
                }

                Libro libroitem = new Libro
                {
                    ID = libroData.ID,
                    Título = libroData.Título,
                    Año = libroData.Año,
                    IDAutor = libroData.IDAutor
                };
                return libroitem;
            }
            catch (EntityException ex)
            {
                throw new Exception("Error al acceder a la base de datos: " + ex.Message + "/"+ ex.InnerException);
            }
        }


        IEnumerable<LibroConAutor> IRepositorioLibro.ObtenerLibrosPorAutor(string nombreAutor)
        {
            if (string.IsNullOrWhiteSpace(nombreAutor))
            {
                throw new ArgumentException($"'{nameof(nombreAutor)}' no puede ser nulo.", nameof(nombreAutor));
            }
            //Vamos a obtener libros por autor
            try
            {

                ObjectResult<sp_GetLibrosPorNombreAutor_Result> libros = db.sp_GetLibrosPorNombreAutor(nombreAutor);

                List<LibroConAutor> listaLibros = new List<LibroConAutor>();
                foreach (sp_GetLibrosPorNombreAutor_Result idlibro in libros)
                {
                    LibroConAutor libroitem = new LibroConAutor
                    {

                        LibroID = idlibro.ID,
                        Título = idlibro.Título,
                        Año = idlibro.Año,
                        Autor = idlibro.Autor

                    };
                    listaLibros.Add(libroitem);
                }

                return listaLibros;
            }
            catch (EntityException ex)
            {
                throw new Exception("Error al acceder a la base de datos: " + ex.Message);
            }
        }

        //  vamos  a implementar ObtenerLibrosPorEditorial


        IEnumerable<LibroEditorial> IRepositorioLibro.ObtenerLibrosPorEditorial(string nombreEditorial)
        {
            try
            {
                ObjectResult<sp_GetLibrosPorNombreEditorial_Result> libros = db.sp_GetLibrosPorNombreEditorial(nombreEditorial);

                List<LibroEditorial> listaLibros = new List<LibroEditorial>();
                foreach (sp_GetLibrosPorNombreEditorial_Result libro in libros)
                {


                    LibroEditorial libroitem = new LibroEditorial
                    {
                        Título = libro.Título,
                        Autor = libro.Autor,
                        Editorial = libro.Editorial,

                    };
                    listaLibros.Add(libroitem);
                }

                return listaLibros;
            }
            catch (EntityException ex)
            {
                throw new Exception("Error al acceder a la base de datos: " + ex.Message);
            }
        }
    }
}
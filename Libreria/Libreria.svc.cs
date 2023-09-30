using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Libreria
{
    public class Service1 : ILibreria
    {
        SistemaGestionLibrosEntities db = new SistemaGestionLibrosEntities();

        public List<Autores> ObtenerAutores()
        {
            try
            {
                ObjectResult<sp_GetAllAutores_Result> autores = db.sp_GetAllAutores();
                List<Autores> listaAutores = new List<Autores>();
                foreach (sp_GetAllAutores_Result autor in autores)
                {
                    Autores autoritem = new Autores();
                    autoritem.ID = autor.ID;
                    autoritem.Nombre = autor.Nombre;
                    autoritem.Nacionalidad = autor.Nacionalidad;
                    listaAutores.Add(autoritem);
                }

                return listaAutores;
            }
            catch (EntityException ex)
            {
                // Handle the Entity Framework specific exception
                throw new FaultException("Error al acceder a la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle any other exception
                throw new FaultException("Ocurrió un error inesperado: " + ex.Message);
            }
        }

        public List<Libros> ObtenerLibros()
        {
            try
            {
                ObjectResult<sp_GetAllBooks_Result> libros = db.sp_GetAllBooks();
                List<Libros> listaLibros = new List<Libros>();
                foreach (sp_GetAllBooks_Result libro in libros)
                {
                    Libros libroitem = new Libros();
                    libroitem.ID = libro.ID;
                    libroitem.Título = libro.Título;
                    libroitem.IDAutor = libro.IDAutor;
                    listaLibros.Add(libroitem);
                }

                return listaLibros;
            }
            catch (EntityException ex)
            {
                // Handle the Entity Framework specific exception
                throw new FaultException("Error al acceder a la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle any other exception
                throw new FaultException("Ocurrió un error inesperado: " + ex.Message);
            }
        }
    }
}

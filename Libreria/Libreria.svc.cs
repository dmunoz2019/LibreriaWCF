using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Libreria


{
    //Repositorios
    // INTERFACES DE REPOSITORIO

    public interface IRepositorioAutor
    {
        IEnumerable<Autores> ObtenerAutores();
        Autores ObtenerAutorPorId(int id);
        void AgregarAutor(Autores autor);
        void ActualizarAutor(Autores autor);
        void EliminarAutor(int id);
    }

    public interface IRepositorioLibro
    {
        IEnumerable<Libros> ObtenerLibros();
        IEnumerable<Libros> ObtenerLibrosPorAutor(string nombreAutor);
        Libros ObtenerLibroPorId(int id);
        void AgregarLibro(Libros libro);
        void ActualizarLibro(Libros libro);
        void EliminarLibro(int id);
    }


    // IMPLEMENTACIÓN DE REPOSITORIOS

    public class RepositorioAutor : IRepositorioAutor
    {
        private SistemaGestionLibrosEntities db;

        public RepositorioAutor(SistemaGestionLibrosEntities context)
        {
            this.db = context;
        }

        public IEnumerable<Autores> ObtenerAutores()
        {
            try
            {
                ObjectResult<sp_GetAllAutores_Result> autores = db.sp_GetAllAutores();
                List<Autores> listaAutores = new List<Autores>();
                foreach (sp_GetAllAutores_Result autor in autores)
                {
                    Autores autoritem = new Autores
                    {
                        ID = autor.ID,
                        Nombre = autor.Nombre,
                        Nacionalidad = autor.Nacionalidad
                    };
                    listaAutores.Add(autoritem);
                }

                return listaAutores;
            }
            catch (EntityException ex)
            {
                throw new Exception("Error al acceder a la base de datos: " + ex.Message);
            }
        }

        void IRepositorioAutor.ActualizarAutor(Autores autor)
        {
            throw new NotImplementedException();
        }

        void IRepositorioAutor.AgregarAutor(Autores autor)
        {
            throw new NotImplementedException();
        }

        void IRepositorioAutor.EliminarAutor(int id)
        {
            throw new NotImplementedException();
        }

        Autores IRepositorioAutor.ObtenerAutorPorId(int id)
        {
            throw new NotImplementedException();
        }

    }

    public class RepositorioLibro : IRepositorioLibro
    {
        private SistemaGestionLibrosEntities db;

        public RepositorioLibro(SistemaGestionLibrosEntities context)
        {
            this.db = context;
        }

        public IEnumerable<Libros> ObtenerLibros()
        {
            try
            {
                ObjectResult<sp_GetAllBooks_Result> libros = db.sp_GetAllBooks();
                List<Libros> listaLibros = new List<Libros>();
                foreach (sp_GetAllBooks_Result libro in libros)
                {
                    Libros libroitem = new Libros
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
                throw new Exception("Error al acceder a la base de datos: " + ex.Message);
            }
        }

        void IRepositorioLibro.ActualizarLibro(Libros libro)
        {
            throw new NotImplementedException();
        }

        void IRepositorioLibro.AgregarLibro(Libros libro)
        {
            throw new NotImplementedException();
        }

        void IRepositorioLibro.EliminarLibro(int id)
        {
            throw new NotImplementedException();
        }

        Libros IRepositorioLibro.ObtenerLibroPorId(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Libros> IRepositorioLibro.ObtenerLibrosPorAutor(string nombreAutor)
        {
            //Vamos a obtener libros por autor
            try
            {
                //lets check if the autor exist using a ternary operator 
                //if the autor is null then throw an exception else return the autor
                var autor = db.Autores.FirstOrDefault(a => a.Nombre == nombreAutor) ?? throw new Exception("El autor no existe, revise poner nombre completo");
                if (nombreAutor == null)
                {
                    throw new Exception("El nombre del autor no puede ser nulo");
                }
                if (nombreAutor == "")
                {
                    throw new Exception("El nombre del autor no puede estar vacío");
                }
                if (nombreAutor.Length > 50)
                {
                    throw new Exception("El nombre del autor no puede tener más de 50 caracteres");
                }
                ObjectResult<sp_GetLibrosPorNombreAutor_Result> libros = db.sp_GetLibrosPorNombreAutor(nombreAutor);

                List<Libros> listaLibros = new List<Libros>();
                foreach (sp_GetLibrosPorNombreAutor_Result idlibro in libros)
                {
                    Libros libroitem = new Libros
                    {
                        ID = idlibro.ID,
                        Título= idlibro.Título,

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

    // UNIDAD DE TRABAJO
    public interface IUnidadDeTrabajo : IDisposable
    {
        IRepositorioAutor RepositorioAutor { get; }
        IRepositorioLibro RepositorioLibro { get; }
        void Guardar();
    }

    public class UnidadDeTrabajo : IUnidadDeTrabajo
    {
        private SistemaGestionLibrosEntities db = new SistemaGestionLibrosEntities();
        public IRepositorioAutor RepositorioAutor { get; private set; }
        public IRepositorioLibro RepositorioLibro { get; private set; }

        public UnidadDeTrabajo()
        {
            this.RepositorioAutor = new RepositorioAutor(db);
            this.RepositorioLibro = new RepositorioLibro(db);
        }

        public void Guardar()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }

    // ... Aquí seguiría el código del servicio WCF.
    // SERVICIO WCF

    public class Service1 : ILibreria, IDisposable
    {
        private IUnidadDeTrabajo unidadDeTrabajo;

        public Service1()
        {
            this.unidadDeTrabajo = new UnidadDeTrabajo();
        }

        public List<Autores> ObtenerAutores()
        {
            try
            {
                return unidadDeTrabajo.RepositorioAutor.ObtenerAutores().ToList();
            }
            catch (Exception ex)
            {
                
                throw new FaultException("Ocurrió un error al obtener los autores: " + ex.Message);
            }
        }

        public List<Libros> ObtenerLibros()
        {
            try
            {
                return unidadDeTrabajo.RepositorioLibro.ObtenerLibros().ToList();
            }
            catch (Exception ex)
            {
                throw new FaultException("Ocurrió un error al obtener los libros: " + ex.Message);
            }
        }

       

        public void Dispose()
        {
            unidadDeTrabajo.Dispose();
        }

        List<Libros> ILibreria.ObtenerLibrosPorAutor(string nombreAutor)
        {
            // 
            try
            {
                return unidadDeTrabajo.RepositorioLibro.ObtenerLibrosPorAutor(nombreAutor).ToList();
            }
            catch (Exception ex)
            {
                throw new FaultException("Ocurrió un error al obtener los libros: " + ex.Message);
            }

           }
    }



}

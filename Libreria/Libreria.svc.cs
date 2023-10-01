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
        void AgregarAutor(string Nombre, string Nacionalidad);
        void ActualizarAutor(Autores autor);
        void EliminarAutor(int id);
    }

    public interface IRepositorioLibro
    {
        IEnumerable<Libros> ObtenerLibros();
        IEnumerable<LibroConAutor> ObtenerLibrosPorAutor(string nombreAutor);
        Libros ObtenerLibroPorId(int id);
        void AgregarLibro(string Título, int Año, string NombreAutor);
        void ActualizarLibro(Libros libro);
        void EliminarLibro(int id);
        ObjectResult<sp_GetAutorYLibrosPorLibroId_Result> ObtenerAutorPorLibro(int libroid);
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

        void IRepositorioAutor.AgregarAutor(string Nombre, string Nacionalidad)
        {
            // Vamos a insertar un autor
            try
            {
                db.sp_CreateAutor(Nombre, Nacionalidad);
            }
            catch (EntityException ex)
            {
                throw new Exception("Error al acceder a la base de datos: " + ex.Message);
            }
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

        public ObjectResult<sp_GetAutorYLibrosPorLibroId_Result> ObtenerAutorPorLibro(int libroid)
        {
            // Vamos a obtener a un autor por el id libro
            try
            {
                return db.sp_GetAutorYLibrosPorLibroId(libroid);
            }
            catch (EntityException ex)
            {
                throw new Exception("Error al acceder a la base de datos: " + ex.Message);
            }
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

        Libros IRepositorioLibro.ObtenerLibroPorId(int id)
        {
            // Vamos a obtener un libro por id
            try
            {
                ObjectResult<sp_GetLibroById_Result> libro = db.sp_GetLibroById(id);
                Libros libroitem = new Libros
                {
                    ID = libro.FirstOrDefault().ID,
                    Título = libro.FirstOrDefault().Título,
                    Año = libro.FirstOrDefault().Año,
                    IDAutor = libro.FirstOrDefault().IDAutor
                };
                return libroitem;
            }
            catch (EntityException ex)
            {
                throw new Exception("Error al acceder a la base de datos: " + ex.Message);
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


    public class LibreriaService : ILibreria, IDisposable
    {
        private IUnidadDeTrabajo unidadDeTrabajo;

        public LibreriaService()
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

        List<LibroConAutor> ILibreria.ObtenerLibrosPorAutor(string nombreAutor)
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

        public List<LibroConAutor> ObtenerLibrosPorAutor(string nombreAutor)
        {
            throw new NotImplementedException();
        }

        public List<AutorConLibro> ObtenerAutorPorLibro(int Libroid)
        {
            // Vamos a obtener a un autor por el id libro
            try
            {
             // a usar sp_GetAutorPorLibro
                ObjectResult<sp_GetAutorYLibrosPorLibroId_Result> autor = unidadDeTrabajo.RepositorioLibro.ObtenerAutorPorLibro(Libroid);
                List<AutorConLibro> listaLibros = new List<AutorConLibro>();
                foreach (sp_GetAutorYLibrosPorLibroId_Result idlibro in autor)
                {
                    AutorConLibro libroitem = new AutorConLibro
                    {
                        ID = idlibro.ID,
                            Nombre = idlibro.Nombre,
                            Nacionalidad = idlibro.Nacionalidad,
                            Título = idlibro.Título,
                            Año = idlibro.Año
                    };
                    listaLibros.Add(libroitem);
                }

                return listaLibros; 
            }
            catch (Exception ex)
            {
                throw new FaultException("Ocurrió un error al obtener los libros: " + ex.Message);
            }
        }

        public void InsertarLibro(string Título, int Año, string NombreAutor)
        {
            // Vamos a insertar un libro
            try
            {
                unidadDeTrabajo.RepositorioLibro.AgregarLibro(Título , Año ,NombreAutor);
                unidadDeTrabajo.Guardar();
            }
            catch (Exception ex)
            {
                throw new FaultException("Ocurrió un error al insertar el libro: " + ex.Message);
            }
        }

        public void InsertarAutor(string Nombre, string Nacionalidad)
        {
            // Vamos a insertar un autor
            try
            {
                unidadDeTrabajo.RepositorioAutor.AgregarAutor(Nombre, Nacionalidad);
                unidadDeTrabajo.Guardar();
            }
            catch (Exception ex)
            {
                throw new FaultException("Ocurrió un error al insertar el autor: " + ex.Message);
            }
        }

        public void BorrarLibro(int idLibro)
        {
            throw new NotImplementedException();
        }

        public void ActualizarAutor(AutorUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public void ActualizarLibro(LibroUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }



}

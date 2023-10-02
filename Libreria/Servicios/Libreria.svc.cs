using Libreria.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Libreria.Repositorios.Interfaces;
using Libreria.Repositorios;
using Libreria.UnidadesT;

namespace Libreria
{


    public class LibreriaService : ILibreria, IDisposable
    {
        private IUnidadDeTrabajo unidadDeTrabajo;

        public LibreriaService()
        {
            this.unidadDeTrabajo = new UnidadDeTrabajo();
        }

        public List<Autore> ObtenerAutores()
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

        public List<Libro> ObtenerLibros()
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
            try
            {
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
             unidadDeTrabajo.RepositorioLibro.EliminarLibro(idLibro);
        }

        public void BorrarAutor(int idAutor)
        {
            unidadDeTrabajo.RepositorioAutor.EliminarAutor(idAutor);
        }

        public void ActualizarAutor(int id, string Nombre, string Nacionalidad)
        {
             // vamos a actualizar un autor
             try
            {
                    unidadDeTrabajo.RepositorioAutor.ActualizarAutor(id, Nombre, Nacionalidad);
                    unidadDeTrabajo.Guardar();
                }
                catch (Exception ex)
            {
                    throw new FaultException("Ocurrió un error al actualizar el autor: " + ex.Message);
                }

        }

        public void ActualizarLibro(int id, string Título, int Año, int IDAutor)
        {
            // vamos a actualizar un libro
                      try
            {
                unidadDeTrabajo.RepositorioLibro.ActualizarLibro(id, Título, Año, IDAutor);
                unidadDeTrabajo.Guardar();
            }
            catch (Exception ex)
                       {
                throw new FaultException("Ocurrió un error al actualizar el libro: " + ex.Message);
            }

        }

        public List<LibroEditorial> ObtenerLibrosPorEditorial(string nombreEditorial)
        {
            try
            {
                
                return unidadDeTrabajo.RepositorioLibro.ObtenerLibrosPorEditorial(nombreEditorial).ToList();

            
            }
            catch (Exception ex)
            {
                throw new FaultException("Ocurrió un error al obtener los libros: " + ex.Message);
            }
        }

        public List<Editoriale> ObtenerEditoriales()
        {
            return unidadDeTrabajo.RepositorioEditoriale.ObtenerEditoriales().ToList();
        }

        public Libro ObtenerLibroPorId(int idLibro)
        {
            return unidadDeTrabajo.RepositorioLibro.ObtenerLibroPorId(idLibro);
        }

        public Autore ObtenerAutorPorId(int idAutor)
        {
            return unidadDeTrabajo.RepositorioAutor.ObtenerAutorPorId(idAutor);
        }

        public Editoriale ObtenerEditorialPorId(int idEditorial)
        {
            return unidadDeTrabajo.RepositorioEditoriale.ObtenerEditorialPorId(idEditorial);
        }
    }



}

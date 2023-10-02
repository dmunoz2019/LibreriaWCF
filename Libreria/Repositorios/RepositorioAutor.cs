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
    public class RepositorioAutor : IRepositorioAutor
    {
        private SistemaGestionLibrosEntities db;

        public RepositorioAutor(SistemaGestionLibrosEntities context)
        {
            this.db = context;
        }

        public IEnumerable<Autore> ObtenerAutores()
        {
            try
            {
                ObjectResult<sp_GetAllAutores_Result> autores = db.sp_GetAllAutores();
                List<Autore> listaAutores = new List<Autore>();
                foreach (sp_GetAllAutores_Result autor in autores)
                {
                    Autore autoritem = new Autore
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

        void IRepositorioAutor.ActualizarAutor(int id ,string Nombre, string Nacionalidad)
        {
            // vamos a actualizar un autor 
            try
            {
                db.sp_UpdateAutor(id,Nombre, Nacionalidad);
            }
            catch (EntityException ex)
            {
                throw new Exception("Error al acceder a la base de datos: " + ex.Message);
            }
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
            try
            {
                db.sp_DeleteAutor(id);
            }
            catch (EntityException ex)
            {
                throw new Exception("Error al acceder a la base de datos: " + ex.Message);
            }
        }

        Autore IRepositorioAutor.ObtenerAutorPorId(int id)
        {
            // vamos a obtener un autor por su id

            try
            {
                ObjectResult<sp_GetAutorById_Result> autorResult = db.sp_GetAutorById(id);
                var autorData = autorResult.FirstOrDefault();
                if (autorData == null)
                {
                    return null;
                }

                Autore autoreitem = new Autore
                {
                    ID = autorData.ID,
                    Nombre = autorData.Nombre,
                    Nacionalidad = autorData.Nacionalidad
                };

                return autoreitem;
            }
            catch (EntityException ex)
            {
                throw new Exception("Error al acceder a la base de datos: " + ex.Message);
            }
        }

    }
}
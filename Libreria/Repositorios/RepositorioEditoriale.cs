using Libreria.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using Libreria.Repositorios.Interfaces;
using System.Data.SqlClient;

namespace Libreria.Repositorios
{
    public class RepositorioEditoriale : IRepositorioEditoriale
    {
        private SistemaGestionLibrosEntities db;

        public RepositorioEditoriale(SistemaGestionLibrosEntities context)
        {
            this.db = context;
        }
        // Esto es para obtener información de la base de datos
        public List<Editoriale> ObtenerEditoriales()
        {
            ObjectResult<sp_GetAllEditoriales_Result> Editorales = db.sp_GetAllEditoriales();
            List<Editoriale> listaEditoriales = new List<Editoriale>();
            foreach (sp_GetAllEditoriales_Result editorial in Editorales)
            {
                   Editoriale editorialitem = new Editoriale
                   {
                    IDEditorial = editorial.IDEditorial,
                    Nombre = editorial.Nombre,
                    País = editorial.País
                    
                };
                listaEditoriales.Add(editorialitem);
            }
                return listaEditoriales;
            
        }

        public Editoriale ObtenerEditorialPorId(int idEditorial)
        {
            // Usamos SqlQuery para ejecutar una consulta SQL directa
            // Utilizamos @idEditorial como parámetro para prevenir inyecciones SQL
            string query = "SELECT * FROM Editoriales WHERE IDEditorial = @idEditorial";
            try
            {
                Editoriale editorial = db.Editoriales.SqlQuery(query, new SqlParameter("@idEditorial", idEditorial))
                                               .FirstOrDefault();
                return editorial;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al acceder a la base de datos: " + ex.Message);
            }
            

            
        }

    }
}
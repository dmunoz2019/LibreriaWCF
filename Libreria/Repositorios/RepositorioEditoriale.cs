using Libreria.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using Libreria.Repositorios.Interfaces;

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

        
    }
}
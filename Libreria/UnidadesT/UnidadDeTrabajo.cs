using Libreria.Data;
using Libreria.Repositorios.Interfaces;
using Libreria.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Libreria.UnidadesT
{







    public class UnidadDeTrabajo : IUnidadDeTrabajo
    {
        private SistemaGestionLibrosEntities db = new SistemaGestionLibrosEntities();
        public IRepositorioAutor RepositorioAutor { get; private set; }
        public IRepositorioLibro RepositorioLibro { get; private set; }
        public IRepositorioEditoriale RepositorioEditoriale { get; private set; }

        public UnidadDeTrabajo()
        {
            this.RepositorioAutor = new RepositorioAutor(db);
            this.RepositorioLibro = new RepositorioLibro(db);
            this.RepositorioEditoriale = new RepositorioEditoriale(db);

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
}
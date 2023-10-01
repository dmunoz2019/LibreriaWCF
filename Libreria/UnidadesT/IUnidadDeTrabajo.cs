using Libreria.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.UnidadesT
{
    // UNIDAD DE TRABAJO
    public interface IUnidadDeTrabajo : IDisposable
    {
        IRepositorioAutor RepositorioAutor { get; }
        IRepositorioLibro RepositorioLibro { get; }
        IRepositorioEditoriale RepositorioEditoriale { get; }
        void Guardar();
    }
}

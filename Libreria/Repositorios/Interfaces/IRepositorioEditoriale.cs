using Libreria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Libreria.Repositorios.Interfaces
{

    public interface IRepositorioEditoriale
    {
        List<Editoriale> ObtenerEditoriales();
        Editoriale ObtenerEditorialPorId(int idEditorial);
    }
}
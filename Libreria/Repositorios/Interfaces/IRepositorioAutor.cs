using Libreria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Libreria.Repositorios.Interfaces
{

    public interface IRepositorioAutor
    {
        IEnumerable<Autore> ObtenerAutores();
        Autore ObtenerAutorPorId(int id);
        void AgregarAutor(string Nombre, string Nacionalidad);
        void ActualizarAutor(int id,  string Nombre, string Nacionalidad);
        void EliminarAutor(int id);
    }
}
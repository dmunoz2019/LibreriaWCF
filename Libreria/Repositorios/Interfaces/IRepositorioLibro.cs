using Libreria.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

namespace Libreria.Repositorios.Interfaces
{
    public interface IRepositorioLibro
    {
        IEnumerable<Libro> ObtenerLibros();
        IEnumerable<LibroConAutor> ObtenerLibrosPorAutor(string nombreAutor);
        Libro ObtenerLibroPorId(int id);
        void AgregarLibro(string Título, int Año, string NombreAutor);
        void ActualizarLibro(int id, string Título, int Año, int IDAutor);
        void EliminarLibro(int id);
        ObjectResult<sp_GetAutorYLibrosPorLibroId_Result> ObtenerAutorPorLibro(int libroid);
        IEnumerable<LibroEditorial> ObtenerLibrosPorEditorial(string nombreEditorial);
    }
}
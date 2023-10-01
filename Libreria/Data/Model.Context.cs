﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Libreria.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SistemaGestionLibrosEntities : DbContext
    {
        public SistemaGestionLibrosEntities()
            : base("name=SistemaGestionLibrosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Autore> Autores { get; set; }
        public virtual DbSet<Editoriale> Editoriales { get; set; }
        public virtual DbSet<Libro> Libros { get; set; }
    
        public virtual int sp_CreateAutor(string nombre, string nacionalidad)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var nacionalidadParameter = nacionalidad != null ?
                new ObjectParameter("Nacionalidad", nacionalidad) :
                new ObjectParameter("Nacionalidad", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_CreateAutor", nombreParameter, nacionalidadParameter);
        }
    
        public virtual int sp_CreateLibro(string título, Nullable<int> año, string nombreAutor)
        {
            var títuloParameter = título != null ?
                new ObjectParameter("Título", título) :
                new ObjectParameter("Título", typeof(string));
    
            var añoParameter = año.HasValue ?
                new ObjectParameter("Año", año) :
                new ObjectParameter("Año", typeof(int));
    
            var nombreAutorParameter = nombreAutor != null ?
                new ObjectParameter("NombreAutor", nombreAutor) :
                new ObjectParameter("NombreAutor", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_CreateLibro", títuloParameter, añoParameter, nombreAutorParameter);
        }
    
        public virtual int sp_DeleteAutor(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DeleteAutor", iDParameter);
        }
    
        public virtual int sp_DeleteLibro(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DeleteLibro", iDParameter);
        }
    
        public virtual ObjectResult<sp_GetAllAutores_Result> sp_GetAllAutores()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetAllAutores_Result>("sp_GetAllAutores");
        }
    
        public virtual ObjectResult<sp_GetAllBooks_Result> sp_GetAllBooks()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetAllBooks_Result>("sp_GetAllBooks");
        }
    
        public virtual ObjectResult<sp_GetAllEditoriales_Result> sp_GetAllEditoriales()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetAllEditoriales_Result>("sp_GetAllEditoriales");
        }
    
        public virtual ObjectResult<sp_GetAutorById_Result> sp_GetAutorById(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetAutorById_Result>("sp_GetAutorById", iDParameter);
        }
    
        public virtual ObjectResult<sp_GetAutoresConMasDeTresLibros_Result> sp_GetAutoresConMasDeTresLibros()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetAutoresConMasDeTresLibros_Result>("sp_GetAutoresConMasDeTresLibros");
        }
    
        public virtual ObjectResult<sp_GetAutorYLibrosPorLibroId_Result> sp_GetAutorYLibrosPorLibroId(Nullable<int> iDLibro)
        {
            var iDLibroParameter = iDLibro.HasValue ?
                new ObjectParameter("IDLibro", iDLibro) :
                new ObjectParameter("IDLibro", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetAutorYLibrosPorLibroId_Result>("sp_GetAutorYLibrosPorLibroId", iDLibroParameter);
        }
    
        public virtual ObjectResult<sp_GetLibroById_Result> sp_GetLibroById(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetLibroById_Result>("sp_GetLibroById", iDParameter);
        }
    
        public virtual ObjectResult<sp_GetLibrosPorAutorId_Result> sp_GetLibrosPorAutorId(Nullable<int> iDAutor)
        {
            var iDAutorParameter = iDAutor.HasValue ?
                new ObjectParameter("IDAutor", iDAutor) :
                new ObjectParameter("IDAutor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetLibrosPorAutorId_Result>("sp_GetLibrosPorAutorId", iDAutorParameter);
        }
    
        public virtual ObjectResult<sp_GetLibrosPorNombreAutor_Result> sp_GetLibrosPorNombreAutor(string nombre)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetLibrosPorNombreAutor_Result>("sp_GetLibrosPorNombreAutor", nombreParameter);
        }
    
        public virtual ObjectResult<sp_GetLibrosPorNombreEditorial_Result> sp_GetLibrosPorNombreEditorial(string nombreEditorial)
        {
            var nombreEditorialParameter = nombreEditorial != null ?
                new ObjectParameter("NombreEditorial", nombreEditorial) :
                new ObjectParameter("NombreEditorial", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetLibrosPorNombreEditorial_Result>("sp_GetLibrosPorNombreEditorial", nombreEditorialParameter);
        }
    
        public virtual int sp_UpdateAutor(Nullable<int> iD, string nombre, string nacionalidad)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var nacionalidadParameter = nacionalidad != null ?
                new ObjectParameter("Nacionalidad", nacionalidad) :
                new ObjectParameter("Nacionalidad", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdateAutor", iDParameter, nombreParameter, nacionalidadParameter);
        }
    
        public virtual int sp_UpdateLibro(Nullable<int> iD, string título, Nullable<int> año, Nullable<int> iDAutor)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var títuloParameter = título != null ?
                new ObjectParameter("Título", título) :
                new ObjectParameter("Título", typeof(string));
    
            var añoParameter = año.HasValue ?
                new ObjectParameter("Año", año) :
                new ObjectParameter("Año", typeof(int));
    
            var iDAutorParameter = iDAutor.HasValue ?
                new ObjectParameter("IDAutor", iDAutor) :
                new ObjectParameter("IDAutor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdateLibro", iDParameter, títuloParameter, añoParameter, iDAutorParameter);
        }
    }
}
﻿using Libreria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Libreria
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ILibreria
    {


        // Estos son para obtener información de la base de datos


        [OperationContract]
        List<Editoriale> ObtenerEditoriales();

        [OperationContract]
        List<Libro> ObtenerLibros();
        
        [OperationContract]
        List<Autore> ObtenerAutores();
        [OperationContract]
        List<LibroConAutor> ObtenerLibrosPorAutor(string nombreAutor);

        // Ahora el dataset con los libros y sus autores en el mismo objeto LibroConAutor
 
        [OperationContract]
        List<AutorConLibro> ObtenerAutorPorLibro(int Libroid);

        // obtener libros de una editarial por su nombre
        [OperationContract]
        List<LibroEditorial> ObtenerLibrosPorEditorial(string nombreEditorial);

        // obtener un solo libro por su id
        [OperationContract]
        Libro ObtenerLibroPorId(int idLibro);

        // obtener un solo autor por su id
        [OperationContract]
        Autore ObtenerAutorPorId(int idAutor);

        // obtener una editorial por su id
        [OperationContract]
        Editoriale ObtenerEditorialPorId(int idEditorial);

            
        // Estos son para insertar en formato es JSON {"Título":"El Quijote", "Año":1605 , "NombreAutor":"Cervantes"}
        [OperationContract]
        void InsertarLibro(string Título, int Año , string NombreAutor );

        // Estos son para insertar en formato es JSON {"Nombre":"Cervantes", "Nacionalidad": "Español"}
        [OperationContract]
        void InsertarAutor(string Nombre, string Nacionalidad);
        
        // Ahora para borrar
        [OperationContract]
        void BorrarLibro(int idLibro);

        [OperationContract]
        void BorrarAutor(int idAutor);

        // En tu ServiceContract
        [OperationContract]
        void ActualizarAutor(int id, string Nombre, string Nacionalidad);

        [OperationContract]
        void ActualizarLibro(int id , string Título, int Año, int IDAutor);

    }

    [DataContract]
    public class LibroConAutor
    {


        [DataMember]
        public int LibroID { get; set; }


        [DataMember]
        public string Título { get; set; }

        [DataMember]
        public int Año { get; set; }


        [DataMember]
        public string Autor { get; set; }
        [DataMember]
        public string Nacionalidad { get; set; }

 }

    // datacontract para ObtenerAutorPorLibro 
    [DataContract]
    public class AutorConLibro
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public string Nacionalidad { get; set; }

        [DataMember]
        public string Título { get; set; }

        [DataMember]
        public int Año { get; set; }
    }


    [DataContract]
    public class AutorUpdateRequest
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public string Nacionalidad { get; set; }
    }

    [DataContract]
    public class LibroUpdateRequest
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Título { get; set; }

        [DataMember]
        public int Año { get; set; }

        [DataMember]
        public int IDAutor { get; set; }
    }

    [DataContract]
    public partial class LibroEditorial
    {
        // vamos a usar este datacontract para obtener los libros de una editorial
        [DataMember]
        public string Título { get; set; }
        [DataMember]
        public string Autor { get; set; }
        [DataMember]
        public string Editorial { get; set; }
        

    }

 








}

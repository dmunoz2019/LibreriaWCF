﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibreriaFrontEnd.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Editoriale", Namespace="http://schemas.datacontract.org/2004/07/Libreria.Data")]
    [System.SerializableAttribute()]
    public partial class Editoriale : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CiudadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDEditorialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LibreriaFrontEnd.ServiceReference1.Libro[] LibrosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PaísField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ciudad {
            get {
                return this.CiudadField;
            }
            set {
                if ((object.ReferenceEquals(this.CiudadField, value) != true)) {
                    this.CiudadField = value;
                    this.RaisePropertyChanged("Ciudad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IDEditorial {
            get {
                return this.IDEditorialField;
            }
            set {
                if ((this.IDEditorialField.Equals(value) != true)) {
                    this.IDEditorialField = value;
                    this.RaisePropertyChanged("IDEditorial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LibreriaFrontEnd.ServiceReference1.Libro[] Libros {
            get {
                return this.LibrosField;
            }
            set {
                if ((object.ReferenceEquals(this.LibrosField, value) != true)) {
                    this.LibrosField = value;
                    this.RaisePropertyChanged("Libros");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string País {
            get {
                return this.PaísField;
            }
            set {
                if ((object.ReferenceEquals(this.PaísField, value) != true)) {
                    this.PaísField = value;
                    this.RaisePropertyChanged("País");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Libro", Namespace="http://schemas.datacontract.org/2004/07/Libreria.Data")]
    [System.SerializableAttribute()]
    public partial class Libro : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LibreriaFrontEnd.ServiceReference1.Autore AutoreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AñoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LibreriaFrontEnd.ServiceReference1.Editoriale EditorialeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> IDAutorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> IDEditorialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TítuloField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LibreriaFrontEnd.ServiceReference1.Autore Autore {
            get {
                return this.AutoreField;
            }
            set {
                if ((object.ReferenceEquals(this.AutoreField, value) != true)) {
                    this.AutoreField = value;
                    this.RaisePropertyChanged("Autore");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Año {
            get {
                return this.AñoField;
            }
            set {
                if ((this.AñoField.Equals(value) != true)) {
                    this.AñoField = value;
                    this.RaisePropertyChanged("Año");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LibreriaFrontEnd.ServiceReference1.Editoriale Editoriale {
            get {
                return this.EditorialeField;
            }
            set {
                if ((object.ReferenceEquals(this.EditorialeField, value) != true)) {
                    this.EditorialeField = value;
                    this.RaisePropertyChanged("Editoriale");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> IDAutor {
            get {
                return this.IDAutorField;
            }
            set {
                if ((this.IDAutorField.Equals(value) != true)) {
                    this.IDAutorField = value;
                    this.RaisePropertyChanged("IDAutor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> IDEditorial {
            get {
                return this.IDEditorialField;
            }
            set {
                if ((this.IDEditorialField.Equals(value) != true)) {
                    this.IDEditorialField = value;
                    this.RaisePropertyChanged("IDEditorial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Título {
            get {
                return this.TítuloField;
            }
            set {
                if ((object.ReferenceEquals(this.TítuloField, value) != true)) {
                    this.TítuloField = value;
                    this.RaisePropertyChanged("Título");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Autore", Namespace="http://schemas.datacontract.org/2004/07/Libreria.Data")]
    [System.SerializableAttribute()]
    public partial class Autore : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LibreriaFrontEnd.ServiceReference1.Libro[] LibrosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NacionalidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LibreriaFrontEnd.ServiceReference1.Libro[] Libros {
            get {
                return this.LibrosField;
            }
            set {
                if ((object.ReferenceEquals(this.LibrosField, value) != true)) {
                    this.LibrosField = value;
                    this.RaisePropertyChanged("Libros");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nacionalidad {
            get {
                return this.NacionalidadField;
            }
            set {
                if ((object.ReferenceEquals(this.NacionalidadField, value) != true)) {
                    this.NacionalidadField = value;
                    this.RaisePropertyChanged("Nacionalidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LibroConAutor", Namespace="http://schemas.datacontract.org/2004/07/Libreria")]
    [System.SerializableAttribute()]
    public partial class LibroConAutor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AutorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AñoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LibroIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NacionalidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TítuloField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Autor {
            get {
                return this.AutorField;
            }
            set {
                if ((object.ReferenceEquals(this.AutorField, value) != true)) {
                    this.AutorField = value;
                    this.RaisePropertyChanged("Autor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Año {
            get {
                return this.AñoField;
            }
            set {
                if ((this.AñoField.Equals(value) != true)) {
                    this.AñoField = value;
                    this.RaisePropertyChanged("Año");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LibroID {
            get {
                return this.LibroIDField;
            }
            set {
                if ((this.LibroIDField.Equals(value) != true)) {
                    this.LibroIDField = value;
                    this.RaisePropertyChanged("LibroID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nacionalidad {
            get {
                return this.NacionalidadField;
            }
            set {
                if ((object.ReferenceEquals(this.NacionalidadField, value) != true)) {
                    this.NacionalidadField = value;
                    this.RaisePropertyChanged("Nacionalidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Título {
            get {
                return this.TítuloField;
            }
            set {
                if ((object.ReferenceEquals(this.TítuloField, value) != true)) {
                    this.TítuloField = value;
                    this.RaisePropertyChanged("Título");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AutorConLibro", Namespace="http://schemas.datacontract.org/2004/07/Libreria")]
    [System.SerializableAttribute()]
    public partial class AutorConLibro : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AñoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NacionalidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TítuloField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Año {
            get {
                return this.AñoField;
            }
            set {
                if ((this.AñoField.Equals(value) != true)) {
                    this.AñoField = value;
                    this.RaisePropertyChanged("Año");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nacionalidad {
            get {
                return this.NacionalidadField;
            }
            set {
                if ((object.ReferenceEquals(this.NacionalidadField, value) != true)) {
                    this.NacionalidadField = value;
                    this.RaisePropertyChanged("Nacionalidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Título {
            get {
                return this.TítuloField;
            }
            set {
                if ((object.ReferenceEquals(this.TítuloField, value) != true)) {
                    this.TítuloField = value;
                    this.RaisePropertyChanged("Título");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LibroEditorial", Namespace="http://schemas.datacontract.org/2004/07/Libreria")]
    [System.SerializableAttribute()]
    public partial class LibroEditorial : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AutorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EditorialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TítuloField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Autor {
            get {
                return this.AutorField;
            }
            set {
                if ((object.ReferenceEquals(this.AutorField, value) != true)) {
                    this.AutorField = value;
                    this.RaisePropertyChanged("Autor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Editorial {
            get {
                return this.EditorialField;
            }
            set {
                if ((object.ReferenceEquals(this.EditorialField, value) != true)) {
                    this.EditorialField = value;
                    this.RaisePropertyChanged("Editorial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Título {
            get {
                return this.TítuloField;
            }
            set {
                if ((object.ReferenceEquals(this.TítuloField, value) != true)) {
                    this.TítuloField = value;
                    this.RaisePropertyChanged("Título");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ILibreria")]
    public interface ILibreria {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/ObtenerEditoriales", ReplyAction="http://tempuri.org/ILibreria/ObtenerEditorialesResponse")]
        LibreriaFrontEnd.ServiceReference1.Editoriale[] ObtenerEditoriales();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/ObtenerEditoriales", ReplyAction="http://tempuri.org/ILibreria/ObtenerEditorialesResponse")]
        System.Threading.Tasks.Task<LibreriaFrontEnd.ServiceReference1.Editoriale[]> ObtenerEditorialesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/ObtenerLibros", ReplyAction="http://tempuri.org/ILibreria/ObtenerLibrosResponse")]
        LibreriaFrontEnd.ServiceReference1.Libro[] ObtenerLibros();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/ObtenerLibros", ReplyAction="http://tempuri.org/ILibreria/ObtenerLibrosResponse")]
        System.Threading.Tasks.Task<LibreriaFrontEnd.ServiceReference1.Libro[]> ObtenerLibrosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/ObtenerAutores", ReplyAction="http://tempuri.org/ILibreria/ObtenerAutoresResponse")]
        LibreriaFrontEnd.ServiceReference1.Autore[] ObtenerAutores();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/ObtenerAutores", ReplyAction="http://tempuri.org/ILibreria/ObtenerAutoresResponse")]
        System.Threading.Tasks.Task<LibreriaFrontEnd.ServiceReference1.Autore[]> ObtenerAutoresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/ObtenerLibrosPorAutor", ReplyAction="http://tempuri.org/ILibreria/ObtenerLibrosPorAutorResponse")]
        LibreriaFrontEnd.ServiceReference1.LibroConAutor[] ObtenerLibrosPorAutor(string nombreAutor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/ObtenerLibrosPorAutor", ReplyAction="http://tempuri.org/ILibreria/ObtenerLibrosPorAutorResponse")]
        System.Threading.Tasks.Task<LibreriaFrontEnd.ServiceReference1.LibroConAutor[]> ObtenerLibrosPorAutorAsync(string nombreAutor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/ObtenerAutorPorLibro", ReplyAction="http://tempuri.org/ILibreria/ObtenerAutorPorLibroResponse")]
        LibreriaFrontEnd.ServiceReference1.AutorConLibro[] ObtenerAutorPorLibro(int Libroid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/ObtenerAutorPorLibro", ReplyAction="http://tempuri.org/ILibreria/ObtenerAutorPorLibroResponse")]
        System.Threading.Tasks.Task<LibreriaFrontEnd.ServiceReference1.AutorConLibro[]> ObtenerAutorPorLibroAsync(int Libroid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/ObtenerLibrosPorEditorial", ReplyAction="http://tempuri.org/ILibreria/ObtenerLibrosPorEditorialResponse")]
        LibreriaFrontEnd.ServiceReference1.LibroEditorial[] ObtenerLibrosPorEditorial(string nombreEditorial);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/ObtenerLibrosPorEditorial", ReplyAction="http://tempuri.org/ILibreria/ObtenerLibrosPorEditorialResponse")]
        System.Threading.Tasks.Task<LibreriaFrontEnd.ServiceReference1.LibroEditorial[]> ObtenerLibrosPorEditorialAsync(string nombreEditorial);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/ObtenerLibroPorId", ReplyAction="http://tempuri.org/ILibreria/ObtenerLibroPorIdResponse")]
        LibreriaFrontEnd.ServiceReference1.Libro ObtenerLibroPorId(int idLibro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/ObtenerLibroPorId", ReplyAction="http://tempuri.org/ILibreria/ObtenerLibroPorIdResponse")]
        System.Threading.Tasks.Task<LibreriaFrontEnd.ServiceReference1.Libro> ObtenerLibroPorIdAsync(int idLibro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/ObtenerAutorPorId", ReplyAction="http://tempuri.org/ILibreria/ObtenerAutorPorIdResponse")]
        LibreriaFrontEnd.ServiceReference1.Autore ObtenerAutorPorId(int idAutor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/ObtenerAutorPorId", ReplyAction="http://tempuri.org/ILibreria/ObtenerAutorPorIdResponse")]
        System.Threading.Tasks.Task<LibreriaFrontEnd.ServiceReference1.Autore> ObtenerAutorPorIdAsync(int idAutor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/ObtenerEditorialPorId", ReplyAction="http://tempuri.org/ILibreria/ObtenerEditorialPorIdResponse")]
        LibreriaFrontEnd.ServiceReference1.Editoriale ObtenerEditorialPorId(int idEditorial);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/ObtenerEditorialPorId", ReplyAction="http://tempuri.org/ILibreria/ObtenerEditorialPorIdResponse")]
        System.Threading.Tasks.Task<LibreriaFrontEnd.ServiceReference1.Editoriale> ObtenerEditorialPorIdAsync(int idEditorial);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/InsertarLibro", ReplyAction="http://tempuri.org/ILibreria/InsertarLibroResponse")]
        void InsertarLibro(string Título, int Año, string NombreAutor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/InsertarLibro", ReplyAction="http://tempuri.org/ILibreria/InsertarLibroResponse")]
        System.Threading.Tasks.Task InsertarLibroAsync(string Título, int Año, string NombreAutor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/InsertarAutor", ReplyAction="http://tempuri.org/ILibreria/InsertarAutorResponse")]
        void InsertarAutor(string Nombre, string Nacionalidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/InsertarAutor", ReplyAction="http://tempuri.org/ILibreria/InsertarAutorResponse")]
        System.Threading.Tasks.Task InsertarAutorAsync(string Nombre, string Nacionalidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/BorrarLibro", ReplyAction="http://tempuri.org/ILibreria/BorrarLibroResponse")]
        void BorrarLibro(int idLibro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/BorrarLibro", ReplyAction="http://tempuri.org/ILibreria/BorrarLibroResponse")]
        System.Threading.Tasks.Task BorrarLibroAsync(int idLibro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/BorrarAutor", ReplyAction="http://tempuri.org/ILibreria/BorrarAutorResponse")]
        void BorrarAutor(int idAutor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/BorrarAutor", ReplyAction="http://tempuri.org/ILibreria/BorrarAutorResponse")]
        System.Threading.Tasks.Task BorrarAutorAsync(int idAutor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/ActualizarAutor", ReplyAction="http://tempuri.org/ILibreria/ActualizarAutorResponse")]
        void ActualizarAutor(int id, string Nombre, string Nacionalidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/ActualizarAutor", ReplyAction="http://tempuri.org/ILibreria/ActualizarAutorResponse")]
        System.Threading.Tasks.Task ActualizarAutorAsync(int id, string Nombre, string Nacionalidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/ActualizarLibro", ReplyAction="http://tempuri.org/ILibreria/ActualizarLibroResponse")]
        void ActualizarLibro(int id, string Título, int Año, int IDAutor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibreria/ActualizarLibro", ReplyAction="http://tempuri.org/ILibreria/ActualizarLibroResponse")]
        System.Threading.Tasks.Task ActualizarLibroAsync(int id, string Título, int Año, int IDAutor);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILibreriaChannel : LibreriaFrontEnd.ServiceReference1.ILibreria, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LibreriaClient : System.ServiceModel.ClientBase<LibreriaFrontEnd.ServiceReference1.ILibreria>, LibreriaFrontEnd.ServiceReference1.ILibreria {
        
        public LibreriaClient() {
        }
        
        public LibreriaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LibreriaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibreriaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibreriaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public LibreriaFrontEnd.ServiceReference1.Editoriale[] ObtenerEditoriales() {
            return base.Channel.ObtenerEditoriales();
        }
        
        public System.Threading.Tasks.Task<LibreriaFrontEnd.ServiceReference1.Editoriale[]> ObtenerEditorialesAsync() {
            return base.Channel.ObtenerEditorialesAsync();
        }
        
        public LibreriaFrontEnd.ServiceReference1.Libro[] ObtenerLibros() {
            return base.Channel.ObtenerLibros();
        }
        
        public System.Threading.Tasks.Task<LibreriaFrontEnd.ServiceReference1.Libro[]> ObtenerLibrosAsync() {
            return base.Channel.ObtenerLibrosAsync();
        }
        
        public LibreriaFrontEnd.ServiceReference1.Autore[] ObtenerAutores() {
            return base.Channel.ObtenerAutores();
        }
        
        public System.Threading.Tasks.Task<LibreriaFrontEnd.ServiceReference1.Autore[]> ObtenerAutoresAsync() {
            return base.Channel.ObtenerAutoresAsync();
        }
        
        public LibreriaFrontEnd.ServiceReference1.LibroConAutor[] ObtenerLibrosPorAutor(string nombreAutor) {
            return base.Channel.ObtenerLibrosPorAutor(nombreAutor);
        }
        
        public System.Threading.Tasks.Task<LibreriaFrontEnd.ServiceReference1.LibroConAutor[]> ObtenerLibrosPorAutorAsync(string nombreAutor) {
            return base.Channel.ObtenerLibrosPorAutorAsync(nombreAutor);
        }
        
        public LibreriaFrontEnd.ServiceReference1.AutorConLibro[] ObtenerAutorPorLibro(int Libroid) {
            return base.Channel.ObtenerAutorPorLibro(Libroid);
        }
        
        public System.Threading.Tasks.Task<LibreriaFrontEnd.ServiceReference1.AutorConLibro[]> ObtenerAutorPorLibroAsync(int Libroid) {
            return base.Channel.ObtenerAutorPorLibroAsync(Libroid);
        }
        
        public LibreriaFrontEnd.ServiceReference1.LibroEditorial[] ObtenerLibrosPorEditorial(string nombreEditorial) {
            return base.Channel.ObtenerLibrosPorEditorial(nombreEditorial);
        }
        
        public System.Threading.Tasks.Task<LibreriaFrontEnd.ServiceReference1.LibroEditorial[]> ObtenerLibrosPorEditorialAsync(string nombreEditorial) {
            return base.Channel.ObtenerLibrosPorEditorialAsync(nombreEditorial);
        }
        
        public LibreriaFrontEnd.ServiceReference1.Libro ObtenerLibroPorId(int idLibro) {
            return base.Channel.ObtenerLibroPorId(idLibro);
        }
        
        public System.Threading.Tasks.Task<LibreriaFrontEnd.ServiceReference1.Libro> ObtenerLibroPorIdAsync(int idLibro) {
            return base.Channel.ObtenerLibroPorIdAsync(idLibro);
        }
        
        public LibreriaFrontEnd.ServiceReference1.Autore ObtenerAutorPorId(int idAutor) {
            return base.Channel.ObtenerAutorPorId(idAutor);
        }
        
        public System.Threading.Tasks.Task<LibreriaFrontEnd.ServiceReference1.Autore> ObtenerAutorPorIdAsync(int idAutor) {
            return base.Channel.ObtenerAutorPorIdAsync(idAutor);
        }
        
        public LibreriaFrontEnd.ServiceReference1.Editoriale ObtenerEditorialPorId(int idEditorial) {
            return base.Channel.ObtenerEditorialPorId(idEditorial);
        }
        
        public System.Threading.Tasks.Task<LibreriaFrontEnd.ServiceReference1.Editoriale> ObtenerEditorialPorIdAsync(int idEditorial) {
            return base.Channel.ObtenerEditorialPorIdAsync(idEditorial);
        }
        
        public void InsertarLibro(string Título, int Año, string NombreAutor) {
            base.Channel.InsertarLibro(Título, Año, NombreAutor);
        }
        
        public System.Threading.Tasks.Task InsertarLibroAsync(string Título, int Año, string NombreAutor) {
            return base.Channel.InsertarLibroAsync(Título, Año, NombreAutor);
        }
        
        public void InsertarAutor(string Nombre, string Nacionalidad) {
            base.Channel.InsertarAutor(Nombre, Nacionalidad);
        }
        
        public System.Threading.Tasks.Task InsertarAutorAsync(string Nombre, string Nacionalidad) {
            return base.Channel.InsertarAutorAsync(Nombre, Nacionalidad);
        }
        
        public void BorrarLibro(int idLibro) {
            base.Channel.BorrarLibro(idLibro);
        }
        
        public System.Threading.Tasks.Task BorrarLibroAsync(int idLibro) {
            return base.Channel.BorrarLibroAsync(idLibro);
        }
        
        public void BorrarAutor(int idAutor) {
            base.Channel.BorrarAutor(idAutor);
        }
        
        public System.Threading.Tasks.Task BorrarAutorAsync(int idAutor) {
            return base.Channel.BorrarAutorAsync(idAutor);
        }
        
        public void ActualizarAutor(int id, string Nombre, string Nacionalidad) {
            base.Channel.ActualizarAutor(id, Nombre, Nacionalidad);
        }
        
        public System.Threading.Tasks.Task ActualizarAutorAsync(int id, string Nombre, string Nacionalidad) {
            return base.Channel.ActualizarAutorAsync(id, Nombre, Nacionalidad);
        }
        
        public void ActualizarLibro(int id, string Título, int Año, int IDAutor) {
            base.Channel.ActualizarLibro(id, Título, Año, IDAutor);
        }
        
        public System.Threading.Tasks.Task ActualizarLibroAsync(int id, string Título, int Año, int IDAutor) {
            return base.Channel.ActualizarLibroAsync(id, Título, Año, IDAutor);
        }
    }
}

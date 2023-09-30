# Sistema de Gestión de Libros con WCF 📚

Bienvenido al Sistema de Gestión de Libros. Esta aplicación, construida con WCF, permite a los usuarios obtener información sobre libros y autores desde una base de datos.

## Tabla de contenidos
- [Dependencias y versiones](#dependencias-y-versiones)
- [Características](#características)
- [Estructura del Proyecto](#estructura-del-proyecto)
- [Instalación](#instalación)
- [Uso](#uso)
- [Contribuciones](#contribuciones)
- [Licencia](#licencia)

## Dependencias y Versiones 🛠️

Para asegurar el correcto funcionamiento del proyecto, es necesario contar con las siguientes dependencias y versiones:

- **EntityFramework**: 6.2.0
  - Provee las funcionalidades de ORM para interactuar con la base de datos.
  
- **.NET Framework**: v4.7.2
  - Framework de desarrollo en el que se basa la aplicación.

Para instalar estas dependencias, se recomienda usar `NuGet` desde la línea de comandos o a través del administrador de paquetes en Visual Studio.

```bash
Install-Package EntityFramework -Version 6.2.0
```

## Características

- Obtener todos los libros de un autor específico.
- Listar todos los autores que tienen más de 3 libros.
- Actualizar la nacionalidad de un autor.
- Consultar todos los libros publicados en un año específico.

## Estructura del Proyecto

El proyecto está estructurado de la siguiente manera:

```
SistemaGestionLibros/
│
│   .gitattributes
│   .gitignore
│   image.png
│   Libreria.sln
│   README.md
│
├─ 📂 db/
│   │   SistemaGestionLibros.bak
│   │
│   └─ 📂 Procedimientos/
│       │   Creación de base de datos.sql
│       │   LibrosAutores.sql
│       │   Procedimientos.sql
│
├─ 📂 Libreria/
│   │   Autores.cs
│   │   ILibreria.cs
│   │   Libreria.csproj
│   │   Libreria.csproj.user
│   │   Libreria.svc
│   │   Libreria.svc.cs
│   │   Libros.cs
│   │   Model.Context.cs
│   │   Model.Context.tt
│   │   Model.cs
│   │   Model.Designer.cs
│   │   Model.edmx
│   │   Model.edmx.diagram
│   │   Model.tt
│   │   packages.config
│   │   sp_GetAllAutores_Result.cs
│   │   sp_GetAllBooks_Result.cs
│   │   sp_GetAutorById_Result.cs
│   │   sp_GetAutoresConMasDeTresLibros_Result.cs
│   │   sp_GetAutorYLibrosPorLibroId_Result.cs
│   │   sp_GetLibroById_Result.cs
│   │   sp_GetLibrosPorAutorId_Result.cs
│   │   sp_GetLibrosPorNombreAutor_Result.cs
│   │   Web.config
│   │   Web.Debug.config
│   │   Web.Release.config
│   │
│   ├─── App_Data/
│   ├─── bin/
│   │       EntityFramework.dll
│   │       EntityFramework.SqlServer.dll
│   │       EntityFramework.SqlServer.xml
│   │       EntityFramework.xml
│   │       Libreria.dll
│   │       Libreria.dll.config
│   │       Libreria.pdb
│   │
│   ├─── obj/
│   │   ├─── Debug/
│   │   │   │   ...
│   │   │   └─ 📂 edmxResourcesToEmbed/
│   │   └─ 📂 Release/
│   │       │   ...
│   │       └─ 📂 edmxResourcesToEmbed/
│   │
│   └─ 📂 Properties/
│           AssemblyInfo.cs
│
└─ 📂 packages/
    └─ 📂 EntityFramework.6.2.0/
        │   ...
        ├─── Content/
        │   └─ 📂 net40/
        ├─── lib/
        │   ├─── net40/
        │   └─ 📂 net45/
        └─ 📂 tools/
```

## Instalación

1. Clona el repositorio:

```bash
git clone https://github.com/yourusername/SistemaGestionLibros.git
```

2. Configura la base de datos usando los scripts ubicados en el directorio `db/`.

3. Asegúrate de tener las dependencias necesarias para ejecutar un servicio WCF.

4. Ejecuta el servicio WCF.

## Uso

1. Una vez que el servicio WCF esté en funcionamiento, puedes consumirlo desde cualquier cliente compatible.
2. Utiliza las operaciones definidas en el servicio para gestionar libros y autores.
3. Consulta y actualiza la información según sea necesario.

## Contribuciones

Las contribuciones son bienvenidas. Por favor, abre un issue para discutir lo que te gustaría cambiar o añadir.

## Licencia

[MIT](https://choosealicense.com/licenses/mit/)
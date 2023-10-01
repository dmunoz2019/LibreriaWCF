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
📁 `Libreria`
│
├───📂 `db`
│   └───📜 `Procedimientos`
│
├───📘 `Libreria`
│   ├───🔒 `App_Data`
│   ├───🔧 `bin`
│   ├───💽 `Data`
│   ├───🔍 `obj`
│   │   ├───🐞 `Debug`
│   │   │   ├───📦 `edmxResourcesToEmbed`
│   │   │   │   └───💾 `Data`
│   │   │   └───🌡️ `TempPE`
│   │   └───🚀 `Release`
│   │       ├───📦 `edmxResourcesToEmbed`
│   │       │   └───💾 `Data`
│   │       ├───📦 `Package`
│   │       │   └───📂 `PackageTmp`
│   │       │       ├───🔧 `bin`
│   │       │       ├───💽 `Data`
│   │       │       └───📡 `Servicios`
│   │       ├───🔍 `ProfileTransformWebConfig`
│   │       │   └───🔍 `transformed`
│   │       ├───🌡️ `TempPE`
│   │       └───🔍 `TransformWebConfig`
│   │           ├───🔍 `assist`
│   │           ├───🔍 `original`
│   │           └───🔍 `transformed`
│   ├───⚙️ `Properties`
│   │   └───🚀 `PublishProfiles`
│   ├───📚 `Repositorios`
│   │   └───📄 `Interfaces`
│   ├───📡 `Servicios`
│   └───📚 `UnidadesT`
│
├───📦 `packages`
│   └───📚 `EntityFramework.6.2.0`
│       ├───📄 `Content`
│       │   └───🔍 `net40`
│       ├───📚 `lib`
│       │   ├───🔍 `net40`
│       │   └───🔍 `net45`
│       └───🛠️ `tools`
│
└───🚀 `Publish`
    ├───🔧 `bin`
    ├───💽 `Data`
    └───📡 `Servicios`
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
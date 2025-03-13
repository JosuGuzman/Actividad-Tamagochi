<h1 align="center"> E.T. Nº12 D.E. 1º "Libertador Gral. José de San Martín" </h1>
<p align="center">
    <img src="https://et12.edu.ar/imgs/et12.gif">
</p>

# Computación : 2025

**Asignatura**: **PSR**

**Nombre TP**: Tamagochi

**Apellido y Nombre Alumno**: Josu Duran

**Curso**: 6 ° 7

# Tamagochi

El proyecto Tamagochi es una simulación de una mascota virtual que puede cambiar de estado según las interacciones del usuario. La mascota puede estar en diferentes estados como hambrienta, aburrida o alegre, y cada estado define cómo la mascota reacciona a las acciones de comer y jugar.

## Comenzando 🚀

Clonar el repositorio github, desde Github Desktop o ejecutar en la terminal o CMD:

```
https://github.com/JosuGuzman/Tamagochi
```

## Pre-requisitos 📋

- .NET 8 (SDK .NET 8.0.105) - [Descargar](https://dotnet.microsoft.com/es-es/download/dotnet/8.0)
- Visual Studio Code - [Descargar](https://code.visualstudio.com/#alt-downloads)
- Git - [Descargar](https://git-scm.com/downloads)

## Despliegue 📦

Para desplegar el proyecto, sigue los siguientes pasos:

1. **Abrir el proyecto**:
     - Navega al directorio del proyecto clonado:
         ``` bash
         cd Tamagochi
         ```
     - Abre el proyecto en Visual Studio Code ejecutando:
         ``` bash
         code .
         ```

2. **Instalar dependencias**:
     - Asegúrate de tener instalado el SDK de .NET 8.0.105. Si no lo tienes, descárgalo desde [aquí](https://dotnet.microsoft.com/es-es/download/dotnet/8.0).
     - En la terminal de Visual Studio Code, ejecuta el siguiente comando para restaurar las dependencias del proyecto:
         ``` bash
         dotnet restore
         ```

3. **Ejecutar el proyecto**:
     - Regresa al directorio raíz del proyecto:
         ``` bash
         cd ..
         ```
     - Ejecuta el proyecto utilizando el siguiente comando:
         ``` bash
         dotnet run
         ```

4. **Probar el proyecto**:
     - Para ejecutar las pruebas unitarias, utiliza el siguiente comando:
         ``` bash
         dotnet test
         ```

5. **Acceder a la aplicación**:
     - Una vez que el proyecto esté en ejecución, podrás acceder a la aplicación a través de tu navegador en la dirección que se indique en la terminal (generalmente `http://localhost:5000` o similar).

En la carpeta `src` encontrarás el código fuente del proyecto. En la carpeta `scripts sql` encontrarás los scripts SQL utilizados para la creación y manipulación de la base de datos.

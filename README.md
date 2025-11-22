# Sistema de Registro de Pacientes (C# Windows Forms)

Aplicación de escritorio desarrollada en **C#** utilizando **Windows Forms** para la gestión y administración de datos de pacientes en un entorno clínico. El sistema permite un control organizado y centralizado de la información médica. No se envían los datos a ningún servidor, es únicamente de muestra.

> **ADVERTENCIA:** Este software ha sido creado con fines educativos y de portafolio. **No garantiza** el cumplimiento de normativas de privacidad y protección de datos médicos (como HIPAA o GDPR). **No debe ser utilizado con datos reales de pacientes.**

<img src="screenshots/Interfaz.gif" alt="Interfaz Principal" width="700"/>

## Funcionalidades Principales

* **Interfaz de Escritorio:** Interfaz gráfica nativa, rápida y diseñada para ser utilizada en consultorios o estaciones de trabajo.
* **Información Médica:** Permite almacenar datos personales, alergias, etc.

## Stack Tecnológico

* ![C#](https://img.shields.io/badge/C%23-100%25-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white) **C#:** Lenguaje principal de programación.
* **Windows Forms:** Framework utilizado para la construcción de la interfaz gráfica de usuario (GUI).
* **Visual Studio:** Entorno de desarrollo recomendado para abrir y compilar el proyecto.

## Estructura del Proyecto

La estructura corresponde a un proyecto estándar de C# Windows Forms:

```text
registro-de-pacientes/
├── Properties/      # Configuración y recursos del proyecto
├── img/             # Iconos o imágenes internas de la aplicación
├── screenshots/     # Capturas de pantalla para la documentación (README)
├── App.config       # Archivo de configuración de la aplicación (conexión a DB)
├── Program.cs       # Punto de entrada principal de la aplicación
├── Registro de Pacientes.cs # Clase principal del formulario y lógica de negocio
├── Registro de Pacientes.csproj # Archivo de proyecto de C#
└── Registro de Pacientes.sln  # Archivo de Solución (para abrir en Visual Studio)
```

## Instalación y Ejecución
Para abrir y ejecutar esta aplicación de escritorio, se necesita tener instalado el entorno de desarrollo de Microsoft.

### 1. Requisitos
Visual Studio (Recomendado 2019 o superior).

.NET Framework (Versión utilizada por el proyecto).

### 2. Apertura y Compilación
Clonar el repositorio:

Bash

git clone [https://github.com/kevinmontilla/registro-de-pacientes.git](https://github.com/kevinmontilla/registro-de-pacientes.git)
Abre el archivo de la solución (Registro de Pacientes.sln) con Visual Studio.

Compila y ejecuta el proyecto (Presiona F5 o el botón "Start").

## Estado del Proyecto
Tipo: Aplicación de Escritorio.

Estado: 🟢 Finalizado.

## Autores

<p style="font-size: 22px; font-family: 'Georgia', serif; line-height: 1.6;">
  • <strong>Carlos Luna</strong><br>
  • <strong>Kevin Montilla</strong>
</p>

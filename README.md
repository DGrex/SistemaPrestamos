# Sistema de Préstamos - BibliotecaApp

Este proyecto es una aplicación de escritorio desarrollada en C# con Visual Studio, orientada a la gestión de préstamos de libros en una biblioteca institucional. La arquitectura está basada en capas, separando la lógica de dominio, la lógica de aplicación y la interfaz principal.

---

##  Estructura del Proyecto

- **Dominio/**  
  Contiene las entidades centrales del sistema:
  - `Cliente.cs`: Representa al usuario que solicita préstamos.
  - `Libro.cs`: Define las propiedades del libro.
  - `Ejemplar.cs`: Controla las copias disponibles de cada libro.
  - `Prestamo.cs`: Registra los préstamos realizados.
  - `Bibliotecario.cs` y `Persona.cs`: Modelan el personal y atributos comunes.

- **Aplicacion/**  
  Contiene la lógica de negocio:
  - `GestorPrestamos.cs`: Controla la creación, validación y registro de préstamos.
  - `IGestorPrestamos.cs`: Define la interfaz para el gestor, facilitando pruebas y extensibilidad.

- **Program.cs**  
  Punto de entrada de la aplicación. Inicializa el sistema y lanza la interfaz.

---

##  Funcionamiento de la Interfaz

La interfaz está diseñada para ser clara, modular y funcional. Aunque no se muestra visualmente en este repositorio, se espera que incluya:

- **Formulario principal** con navegación hacia módulos como:
  - Registro de clientes
  - Registro de libros y ejemplares
  - Gestión de préstamos
  - Visualización de historial

- **Validaciones integradas**:
  - Verificación de campos obligatorios
  - Control de disponibilidad de ejemplares
  - Prevención de duplicados

- **Visualización estructurada**:
  - Listas de clientes, libros y préstamos
  - Filtros por estado, fecha o cliente

---

##  Buenas prácticas implementadas

- Separación por capas (Dominio / Aplicación / Interfaz)
- Uso de interfaces para facilitar pruebas unitarias
- Validación lógica antes de registrar entidades
- Documentación técnica adaptable a entornos institucionales
- `.gitignore` configurado para excluir archivos temporales de Visual Studio

---

##  Cómo ejecutar el proyecto

1. Clona el repositorio:
   ```bash
   git clone https://github.com/DGrex/SistemaPrestamos.git

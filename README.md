# CombinarPDFs / PDF Merger

**Una aplicación de Windows Forms en C# (.NET Framework 4.8) que permite combinar múltiples archivos PDF en uno solo.**  
*A Windows Forms application in C# (.NET Framework 4.8) that allows you to merge multiple PDF files into one.*

---

## Tabla de Contenidos / Table of Contents

- [Características / Features](#características--features)
- [Requisitos / Requirements](#requisitos--requirements)
- [Instalación / Installation](#instalación--installation)
- [Uso / Usage](#uso--usage)
- [Estructura del Proyecto / Project Structure](#estructura-del-proyecto--project-structure)
- [Personalización / Customization](#personalización--customization)
- [Licencia / License](#licencia--license)
- [Agradecimientos / Acknowledgments](#agradecimientos--acknowledgments)
- [Changelog / Registro de Cambios](#changelog--registro-de-cambios)

---

## Características / Features

- **Agregar PDFs / Add PDFs:**  
  Selecciona uno o varios archivos PDF para agregarlos a la lista.  
  *Select one or more PDF files to add them to the list.*

- **Eliminar PDFs / Remove PDFs:**  
  Remueve un archivo PDF seleccionado de la lista.  
  *Remove a selected PDF file from the list.*

- **Unir PDFs / Merge PDFs:**  
  Combina todos los archivos PDF agregados en un único documento, respetando el orden de agregado.  
  *Merge all added PDF files into a single document, maintaining the order in which they were added.*

---

## Requisitos / Requirements

- **Windows 10** o superior / Windows 10 or higher.
- **.NET Framework 4.8.**
- **Visual Studio 2022** (u otra versión compatible para desarrollo en .NET Framework 4.8).  
  *Visual Studio 2022 (or any compatible version for development on .NET Framework 4.8).*

---

## Instalación / Installation

1. **Clonar el repositorio / Clone the repository:**

   ```bash
   git clone https://github.com/tu_usuario/CombinarPDFs.git
   ```

2. **Abrir el proyecto en Visual Studio / Open the project in Visual Studio:**

   Abre el archivo de solución (`.sln`) en Visual Studio 2022.  
   *Open the solution file (`.sln`) in Visual Studio 2022.*

3. **Instalar las dependencias de NuGet / Install NuGet dependencies:**

   - En el Explorador de Soluciones, haz clic derecho sobre el proyecto y selecciona **Administrar paquetes NuGet...**.  
     *In the Solution Explorer, right-click on the project and select **Manage NuGet Packages...**.*
   - Busca e instala el paquete **iTextSharp** (por ejemplo, la versión **5.5.13.3**).  
     *Search for and install the **iTextSharp** package (for example, version **5.5.13.3**).*

---

## Uso / Usage

1. **Compilar y ejecutar la aplicación / Build and Run the Application:**

   - Selecciona **Compilar > Compilar solución** o presiona `Ctrl+Shift+B`.  
     *Select **Build > Build Solution** or press `Ctrl+Shift+B`.*
   - Ejecuta la aplicación desde Visual Studio (`F5`) o ejecuta el `.exe` generado en la carpeta `bin\Debug` o `bin\Release`.  
     *Run the application from Visual Studio (`F5`) or run the generated `.exe` from the `bin\Debug` or `bin\Release` folder.*

2. **Agregar archivos PDF / Adding PDF Files:**

   - Haz clic en el botón **Agregar PDF** para seleccionar uno o varios archivos PDF desde el explorador de archivos.  
     *Click the **Add PDF** button to select one or more PDF files from your file explorer.*
   - Los nombres de los archivos se mostrarán en la lista.  
     *The file names will be displayed in the list.*

3. **Eliminar archivos PDF / Removing PDF Files:**

   - Selecciona un archivo en la lista y haz clic en **Eliminar PDF** para removerlo.  
     *Select a file from the list and click **Remove PDF** to delete it.*

4. **Unir archivos PDF / Merging PDF Files:**

   - Una vez agregados los archivos deseados, haz clic en **Unir PDFs**.  
     *Once you have added the desired files, click **Merge PDFs**.*
   - Selecciona la ubicación y asigna un nombre al PDF combinado en el diálogo de guardado.  
     *Select the location and assign a name to the merged PDF in the save dialog.*
   - Se mostrará un mensaje confirmando la creación del PDF combinado.  
     *A message will appear confirming that the merged PDF has been created.*

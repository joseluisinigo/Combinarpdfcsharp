using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CombinarPDFs
{
    public partial class Form1 : Form
    {
        // Lista para almacenar las rutas de los archivos PDF
        private List<string> listaPDFs = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        // Evento para agregar archivos PDF
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Multiselect = true;
                dlg.Filter = "Archivos PDF (*.pdf)|*.pdf";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    foreach (string archivo in dlg.FileNames)
                    {
                        if (!listaPDFs.Contains(archivo))
                        {
                            listaPDFs.Add(archivo);
                            lstArchivos.Items.Add(Path.GetFileName(archivo));
                        }
                    }
                }
            }
        }

        // Evento para eliminar el PDF seleccionado
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstArchivos.SelectedIndex >= 0)
            {
                int indice = lstArchivos.SelectedIndex;
                lstArchivos.Items.RemoveAt(indice);
                listaPDFs.RemoveAt(indice);
            }
            else
            {
                MessageBox.Show("Selecciona un archivo para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Evento para unir los archivos PDF
        private void btnUnir_Click(object sender, EventArgs e)
        {
            if (listaPDFs.Count == 0)
            {
                MessageBox.Show("Agrega al menos un archivo PDF", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveDlg = new SaveFileDialog())
            {
                saveDlg.Filter = "Archivos PDF (*.pdf)|*.pdf";
                saveDlg.Title = "Guardar PDF combinado";
                saveDlg.FileName = "Combinado.pdf";

                if (saveDlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        CombinarPDFs(listaPDFs, saveDlg.FileName);
                        MessageBox.Show("PDFs combinados exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al combinar PDFs: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Combina los archivos PDF indicados en 'archivos' y genera uno nuevo en 'pdfSalida'.
        /// </summary>
        /// <param name="archivos">Lista de rutas de los archivos PDF a combinar.</param>
        /// <param name="pdfSalida">Ruta del archivo PDF resultante.</param>
        private void CombinarPDFs(List<string> archivos, string pdfSalida)
        {
            using (FileStream stream = new FileStream(pdfSalida, FileMode.Create))
            using (Document doc = new Document())
            using (PdfCopy pdfCopyProvider = new PdfCopy(doc, stream))
            {
                doc.Open();
                foreach (string archivo in archivos)
                {
                    using (PdfReader reader = new PdfReader(archivo))
                    {
                        for (int i = 1; i <= reader.NumberOfPages; i++)
                        {
                            PdfImportedPage importedPage = pdfCopyProvider.GetImportedPage(reader, i);
                            pdfCopyProvider.AddPage(importedPage);
                        }
                        pdfCopyProvider.FreeReader(reader);
                    }
                }
                doc.Close();
            }
        }
    }
}

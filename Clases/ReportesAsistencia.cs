using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Image;
using iText.Layout.Properties;
using System.Diagnostics;

using Proyecto_DAE.Modelos;



namespace Proyecto_DAE.Clases
{
    internal class ReportesAsistencia
    {
        public void CrearReporteEmpleados(string rutaArchivo)
        {

            using (var query = new RegistroAsistenciaContext()) {
                string directory = Path.GetDirectoryName(rutaArchivo);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                    MessageBox.Show("CREADO");
                }

                var asistencias = (from a in query.Asistencia
                                    join da in query.DetalleAsistencia on a.IdAsistencia equals da.IdAsistencia
                                    join e in query.Estudiantes on da.Estudiante equals e.CarnetEstudiantes
                                    select new
                                    {
                                        Carnet = e.CarnetEstudiantes,
                                        Apellido = e.Apellido,
                                        Nombre = e.Nombre,
                                        Estado = da.Estado,
                                        Observaciones = da.Detalle
                                    }).ToList();

                // Crear el archivo PDF
                try
                {
                    using (PdfWriter writer = new PdfWriter(rutaArchivo))
                    {
                        PdfDocument pdf = new PdfDocument(writer);
                        Document document = new Document(pdf);

                        // Agregar encabezado con el logo y el texto "Empleados"
                        AgregarEncabezado(document);

                        // Crear una tabla con 6 columnas
                        Table tabla = new Table(new float[] { 1, 2, 2, 2, 4 });
                        tabla.SetWidth(UnitValue.CreatePercentValue(100));

                        // Agregar encabezados de columna
                        tabla.AddHeaderCell("Carnet");
                        tabla.AddHeaderCell("Apellido");
                        tabla.AddHeaderCell("Nombre");
                        tabla.AddHeaderCell("Estado");
                        tabla.AddHeaderCell("Observaciones");

                        // Agregar filas de empleados
                        foreach (var asistencia in asistencias)
                        {
                            tabla.AddCell(asistencia.Carnet.ToString() ?? "N/A");
                            tabla.AddCell(asistencia.Apellido ?? "N/A");
                            tabla.AddCell(asistencia.Nombre ?? "N/A");
                            tabla.AddCell(asistencia.Estado ?? "N/A");
                            tabla.AddCell(asistencia.Observaciones ?? "N/A");
                        }

                        document.Add(tabla);

                        // Cerrar el documento
                        document.Close();
                    }

                    // Abrir el PDF automáticamente después de crearlo
                    AbrirPDF(rutaArchivo);

                }
                catch (Exception ex) {

                    MessageBox.Show("Error" + ex);
                }

            
            }

        }
        private void AgregarEncabezado(Document document)
        {
            // Crear una tabla para el encabezado
            Table encabezadoTabla = new Table(1);
            encabezadoTabla.SetWidth(UnitValue.CreatePercentValue(100));

            // Agregar la imagen del logo si existe


            // Agregar el texto del encabezado
            Cell cellTexto = new Cell().Add(new Paragraph("Asistencia General")//MODIFICAR TITULO DEL ENCABEZADO
                .SetFontSize(18)
                .SetBold());
            cellTexto.SetBorder(iText.Layout.Borders.Border.NO_BORDER); // Sin borde
            cellTexto.SetVerticalAlignment(VerticalAlignment.MIDDLE);
            encabezadoTabla.AddCell(cellTexto);

            // Añadir el encabezado al documento
            document.Add(encabezadoTabla);
            document.Add(new Paragraph("\n")); // Añadir un espacio después del encabezado
        }

        // Método para abrir el archivo PDF automáticamente
        private void AbrirPDF(string rutaArchivo)
        {
            try
            {
                // Usar Process.Start() para abrir el archivo PDF con el visor predeterminado del sistema operativo
                Process.Start(new ProcessStartInfo(rutaArchivo) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el archivo PDF: " + ex.Message);
            }
        }
    }
}

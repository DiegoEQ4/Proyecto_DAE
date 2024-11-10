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
using iText.Kernel.Colors;

namespace Proyecto_DAE.Clases
{
    internal class ReporteEstudiante
    {
        public void CreacionReporte(string rutaArchivo, int estudianteId, int grado)
        {

            using (var query = new RegistroAsistenciaContext())
            {

                var estudiantes = (from a in query.Asistencia
                                   join da in query.DetalleAsistencia on a.IdAsistencia equals da.IdAsistencia
                                   join e in query.Estudiantes on da.Estudiante equals e.CarnetEstudiantes
                                   join c in query.Clases on a.ClaseAsistencia equals c.IdClase
                                   where e.CarnetEstudiantes == estudianteId
                                   select new
                                   {
                                       Carnet = e.CarnetEstudiantes,
                                       Apellido = e.Apellido,
                                       Nombre = e.Nombre,
                                       Estado = da.Estado,
                                       Clase = c.ContenidoClase,
                                       Fecha = a.FechaHora,
                                       Observaciones = da.Detalle,
                                   }).ToList();
                var grados = (from g in query.Grados
                              where g.IdGrado == grado
                              select new
                              {

                                  Grado = g.NombreCompleto,


                              }
                             ).FirstOrDefault();

                var estudianteNombre = query.Estudiantes
                    .Where(e => e.CarnetEstudiantes == estudianteId)
                    .FirstOrDefault();
                // Crear el archivo PDF
                try
                {
                    using (PdfWriter writer = new PdfWriter(rutaArchivo))
                    {
                        PdfDocument pdf = new PdfDocument(writer);
                        Document document = new Document(pdf);

                        // Agregar encabezado con el logo y el texto "Empleados"
                        AgregarEncabezado(document);


                        string rangoFechas = $"REPORTE DE ESTUDIANTE:  {estudianteNombre.Apellido} {estudianteNombre.Nombre} ";
                        document.Add(new Paragraph(rangoFechas).SetFontSize(16).SetFontColor(ColorConstants.BLACK));
                        string gradoString = $"Grado: {grados.Grado}";
                        document.Add(new Paragraph(gradoString).SetFontSize(14).SetFontColor(ColorConstants.BLACK));


                        // Espacio entre el rango de fechas y la tabla
                        document.Add(new Paragraph("\n"));

                        // Crear una tabla con 6 columnas
                        Table tabla = new Table(new float[] { 1, 2, 2, 2, 3, 3, 3 });
                        tabla.SetWidth(UnitValue.CreatePercentValue(100));

                        // Agregar encabezados de columna
                        tabla.AddHeaderCell("Carnet");
                        tabla.AddHeaderCell("Apellido");
                        tabla.AddHeaderCell("Nombre");
                        tabla.AddHeaderCell("Estado");
                        tabla.AddHeaderCell("Clase");
                        tabla.AddHeaderCell("FECHA");
                        tabla.AddHeaderCell("Observaciones");

                        // Agregar filas de empleados
                        if (estudiantes.Count < 1)
                        {

                            MessageBox.Show("ESTE ESTUDIANTE NO TIENE NINGUNA ASISTENCIA REGISTRADA", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            foreach (var estudiante in estudiantes)
                            {
                                tabla.AddCell(estudiante.Carnet.ToString() ?? "N/A");
                                tabla.AddCell(estudiante.Apellido ?? "N/A");
                                tabla.AddCell(estudiante.Nombre ?? "N/A");
                                tabla.AddCell(estudiante.Estado ?? "N/A");
                                tabla.AddCell(estudiante.Clase ?? "N/A");
                                tabla.AddCell(estudiante.Fecha.ToString() ?? "N/A");
                                tabla.AddCell(estudiante.Observaciones ?? "N/A");
                            }

                            document.Add(tabla);

                            // Cerrar el documento
                            document.Close();
                        }
                        else { 
                        
                            foreach (var estudiante in estudiantes)
                            {
                                tabla.AddCell(estudiante.Carnet.ToString() ?? "N/A");
                                tabla.AddCell(estudiante.Apellido ?? "N/A");
                                tabla.AddCell(estudiante.Nombre ?? "N/A");
                                tabla.AddCell(estudiante.Estado ?? "N/A");
                                tabla.AddCell(estudiante.Clase ?? "N/A");
                                tabla.AddCell(estudiante.Fecha.ToString() ?? "N/A");
                                tabla.AddCell(estudiante.Observaciones ?? "N/A");
                            }

                            document.Add(tabla);

                            // Cerrar el documento
                        }
                        document.Close();
                    }

                    // Abrir el PDF automáticamente después de crearlo
                    AbrirPDF(rutaArchivo);

                }
                catch (Exception ex)
                {

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
            Cell cellTexto = new Cell().Add(new Paragraph("REPORTE DE ASISTENCIAS")//MODIFICAR TITULO DEL ENCABEZADO
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

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
    internal class ReportesAsistencia
    {
        public void FiltradoUno(string rutaArchivo, int grado, DateTime fechaInicio, DateTime fechaFinal)
        {

            using (var query = new RegistroAsistenciaContext())
            {
                string directory = Path.GetDirectoryName(rutaArchivo);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                    MessageBox.Show("CREADO");
                }

                var asistencias = (from a in query.Asistencia
                                   join da in query.DetalleAsistencia on a.IdAsistencia equals da.IdAsistencia
                                   join e in query.Estudiantes on da.Estudiante equals e.CarnetEstudiantes
                                   join c in query.Clases on a.ClaseAsistencia equals c.IdClase
                                   where e.Grado == grado && a.FechaHora >= fechaInicio && a.FechaHoraFinal <= fechaFinal
                                   select new
                                   {
                                       Carnet = e.CarnetEstudiantes,
                                       Apellido = e.Apellido,
                                       Nombre = e.Nombre,
                                       Estado = da.Estado,
                                       Clase = c.ContenidoClase,
                                       Observaciones = da.Detalle,
                                       Fecha = a.FechaHora,
                                   }).ToList();
                var grados = (from g in query.Grados
                             where g.IdGrado == grado
                             select new {
                                
                                 Grado = g.NombreCompleto,


                             }
                             ).FirstOrDefault();
                // Crear el archivo PDF
                try
                {
                    using (PdfWriter writer = new PdfWriter(rutaArchivo))
                    {
                        PdfDocument pdf = new PdfDocument(writer);
                        Document document = new Document(pdf);

                        // Agregar encabezado con el logo y el texto "Empleados"
                        AgregarEncabezado(document);


                        string gradoString = $"Grado: {grados.Grado}";
                        document.Add(new Paragraph(gradoString).SetFontSize(16).SetFontColor(ColorConstants.BLACK));
                        string rangoFechas = $"Consulta de asistencia de las fechas: {fechaInicio.ToShortDateString()} - {fechaFinal.ToShortDateString()}";
                        document.Add(new Paragraph(rangoFechas).SetFontSize(14).SetFontColor(ColorConstants.BLACK));


                        // Espacio entre el rango de fechas y la tabla
                        document.Add(new Paragraph("\n"));

                        // Crear una tabla con 6 columnas
                        Table tabla = new Table(new float[] { 1, 2, 2, 2, 3, 3,3 });
                        tabla.SetWidth(UnitValue.CreatePercentValue(100));

                        // Agregar encabezados de columna
                        tabla.AddHeaderCell("Carnet");
                        tabla.AddHeaderCell("Apellido");
                        tabla.AddHeaderCell("Nombre");
                        tabla.AddHeaderCell("Estado");
                        tabla.AddHeaderCell("Clase");
                        tabla.AddHeaderCell("Observaciones");
                        tabla.AddHeaderCell("FECHA");

                        // Agregar filas de empleados
                        foreach (var asistencia in asistencias)
                        {
                            tabla.AddCell(asistencia.Carnet.ToString() ?? "N/A");
                            tabla.AddCell(asistencia.Apellido ?? "N/A");
                            tabla.AddCell(asistencia.Nombre ?? "N/A");
                            tabla.AddCell(asistencia.Estado ?? "N/A");
                            tabla.AddCell(asistencia.Clase ?? "N/A");
                            tabla.AddCell(asistencia.Observaciones ?? "N/A");
                            tabla.AddCell(asistencia.Fecha.ToShortDateString() ?? "N/A");
                        }

                        document.Add(tabla);

                        // Cerrar el documento
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
        public void FiltradoDos(string rutaArchivo, int grado)
        {

            using (var query = new RegistroAsistenciaContext())
            {
                string directory = Path.GetDirectoryName(rutaArchivo);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                    MessageBox.Show("CREADO");
                }

                var asistencias = (from a in query.Asistencia
                                   join da in query.DetalleAsistencia on a.IdAsistencia equals da.IdAsistencia
                                   join e in query.Estudiantes on da.Estudiante equals e.CarnetEstudiantes
                                   join c in query.Clases on a.ClaseAsistencia equals c.IdClase
                                   where e.Grado == grado
                                   select new
                                   {
                                       Carnet = e.CarnetEstudiantes,
                                       Apellido = e.Apellido,
                                       Nombre = e.Nombre,
                                       Estado = da.Estado,
                                       Clase = c.ContenidoClase,
                                       Observaciones = da.Detalle,
                                       Fecha = a.FechaHora,
                                   }).ToList();
                var grados = (from g in query.Grados
                              where g.IdGrado == grado
                              select new
                              {
                                  Grado = g.NombreCompleto,

                              }
                             ).FirstOrDefault();
                // Crear el archivo PDF
                try
                {
                    using (PdfWriter writer = new PdfWriter(rutaArchivo))
                    {
                        PdfDocument pdf = new PdfDocument(writer);
                        Document document = new Document(pdf);

                        // Agregar encabezado con el logo y el texto "Empleados"
                        AgregarEncabezado(document);


                        string gradoString = $"Grado: {grados.Grado}";
                        document.Add(new Paragraph(gradoString).SetFontSize(16).SetFontColor(ColorConstants.BLACK));
   
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
                        tabla.AddHeaderCell("Observaciones");
                        tabla.AddHeaderCell("FECHA");

                        // Agregar filas de empleados
                        foreach (var asistencia in asistencias)
                        {
                            tabla.AddCell(asistencia.Carnet.ToString() ?? "N/A");
                            tabla.AddCell(asistencia.Apellido ?? "N/A");
                            tabla.AddCell(asistencia.Nombre ?? "N/A");
                            tabla.AddCell(asistencia.Estado ?? "N/A");
                            tabla.AddCell(asistencia.Clase ?? "N/A");
                            tabla.AddCell(asistencia.Observaciones ?? "N/A");
                            tabla.AddCell(asistencia.Fecha.ToShortDateString() ?? "N/A");
                        }

                        document.Add(tabla);

                        // Cerrar el documento
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
        public void FiltradoTres(string rutaArchivo, int clase)
        {

            using (var query = new RegistroAsistenciaContext())
            {
                string directory = Path.GetDirectoryName(rutaArchivo);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                    MessageBox.Show("CREADO");
                }

                var asistencias = (from a in query.Asistencia
                                   join da in query.DetalleAsistencia on a.IdAsistencia equals da.IdAsistencia
                                   join e in query.Estudiantes on da.Estudiante equals e.CarnetEstudiantes
                                   join c in query.Clases on a.ClaseAsistencia equals c.IdClase
                                   where c.IdClase == clase
                                   select new
                                   {
                                       Carnet = e.CarnetEstudiantes,
                                       Apellido = e.Apellido,
                                       Nombre = e.Nombre,
                                       Estado = da.Estado,
                                       Clase = c.ContenidoClase,
                                       Observaciones = da.Detalle,
                                       Fecha = a.FechaHora,
                                   }).ToList();
                var grados = (from g in query.Grados
                              join mg in query.MateriaGrados 
                              on g.IdGrado equals mg.IdGradoDetalle
                              select new
                              {

                                  Grado = g.NombreCompleto,


                              }
                             ).FirstOrDefault();
                // Crear el archivo PDF
                try
                {
                    using (PdfWriter writer = new PdfWriter(rutaArchivo))
                    {
                        PdfDocument pdf = new PdfDocument(writer);
                        Document document = new Document(pdf);

                        // Agregar encabezado con el logo y el texto "Empleados"
                        AgregarEncabezado(document);


                        string gradoString = $"Grado: {grados.Grado}";
                        document.Add(new Paragraph(gradoString).SetFontSize(16).SetFontColor(ColorConstants.BLACK));

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
                        tabla.AddHeaderCell("Observaciones");
                        tabla.AddHeaderCell("FECHA");

                        // Agregar filas de empleados
                        foreach (var asistencia in asistencias)
                        {
                            tabla.AddCell(asistencia.Carnet.ToString() ?? "N/A");
                            tabla.AddCell(asistencia.Apellido ?? "N/A");
                            tabla.AddCell(asistencia.Nombre ?? "N/A");
                            tabla.AddCell(asistencia.Estado ?? "N/A");
                            tabla.AddCell(asistencia.Clase ?? "N/A");
                            tabla.AddCell(asistencia.Observaciones ?? "N/A");
                            tabla.AddCell(asistencia.Fecha.ToShortDateString() ?? "N/A");
                        }

                        document.Add(tabla);

                        // Cerrar el documento
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

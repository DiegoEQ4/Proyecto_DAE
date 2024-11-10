using Proyecto_DAE.Clases;
using Proyecto_DAE.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DAE.Vistas
{
    public partial class ReportesEstudiantes : Form
    {

        int idEstudiante = 0;
        int idGrado = 0;

        public ReportesEstudiantes()
        {
            InitializeComponent();
        }

        private void ReportesEstudiantes_Load(object sender, EventArgs e)
        {
            CargarGrados();
            idEstudiante = 0;
            idGrado = 0;
        }



        private void CargarGrados()
        {

            using (var query = new RegistroAsistenciaContext())
            {

                var grados = query.Grados.ToList();

                dataGrados.DataSource = grados;

                dataGrados.Columns["MateriaGrados"].Visible = false;
                dataGrados.Columns["Estudiantes"].Visible = false;
                dataGrados.Columns["NombreCompleto"].Visible = false;



                dataGrados.Columns["IdGrado"].HeaderText = "ID";
                dataGrados.Columns["NombreGrado"].HeaderText = "Grado";
                dataGrados.Columns["Anio"].HeaderText = "Año";




            }
        }

        private void CargarEstudiantes()
        {

            using (var query = new RegistroAsistenciaContext())
            {

                var estudiantes = query.Estudiantes
                    .Where(e => e.Grado == idGrado)
                    .OrderBy(e=> e.Apellido)
                    .ToList();

                dataEstudiantes.DataSource = estudiantes;

                dataEstudiantes.Columns["DetalleAsistencia"].Visible = false;
                dataEstudiantes.Columns["GradoNavigation"].Visible = false;
                dataEstudiantes.Columns["Grado"].Visible = false;


                dataEstudiantes.Columns["CarnetEstudiantes"].HeaderText = "Carnet";
                dataEstudiantes.Columns["CorreoInstitucional"].HeaderText = "Correo";
                dataEstudiantes.Columns["FechaNacimiento"].HeaderText = "Nacimiento";

            }
        }

        private void dataGrados_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrados.SelectedRows.Count > 0)
            {
                idEstudiante = 0;
                DataGridViewRow selected = dataGrados.SelectedRows[0];

                var idA = selected.Cells["IdGrado"].Value.ToString();
                idGrado = int.Parse(idA);
                CargarEstudiantes();
            }
        }

        private void dataEstudiantes_SelectionChanged(object sender, EventArgs e)
        {
            if (dataEstudiantes.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dataEstudiantes.SelectedRows[0];

                var idE = selected.Cells["CarnetEstudiantes"].Value.ToString();
                idEstudiante = int.Parse(idE);
            }
        }

        private void btnCrearReporte_Click(object sender, EventArgs e)
        {
            // Crear una instancia del contexto de EF Core
            using (var query = new RegistroAsistenciaContext())
            {

                // Crear el reporte
                ReporteEstudiante reporte = new ReporteEstudiante();
                if (idEstudiante != 0 && idGrado != 0)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Guardar Reporte de Estudiante";
                    saveFileDialog.FileName = "ReporteEstudiante.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Ruta seleccionada por el usuario
                        string rutaArchivo = saveFileDialog.FileName;

                        reporte.CreacionReporte(rutaArchivo, idEstudiante, idGrado);
                    }

                }
                else {

                    MessageBox.Show("SELECCIONA UN ALUMNO!", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
            }
        }
    }
}

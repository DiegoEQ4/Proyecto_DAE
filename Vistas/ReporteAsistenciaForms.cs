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
    public partial class ReporteAsistenciaForms : Form
    {
        public ReporteAsistenciaForms()
        {
            InitializeComponent();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            // Crear una instancia del contexto de EF Core
            using (var query = new RegistroAsistenciaContext())
            {
                // Usar SaveFileDialog para que el usuario seleccione la ruta donde se guardará el archivo PDF
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar Reporte de Empleados";
                saveFileDialog.FileName = "ReporteEmpleados.pdf";// MODIFICAR AQUÍ

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Ruta seleccionada por el usuario
                    string rutaArchivo = saveFileDialog.FileName;



                    // Crear el reporte
                    ReportesAsistencia reporte = new ReportesAsistencia();
                    reporte.CrearReporteEmpleados(rutaArchivo);

                    MessageBox.Show("Reporte creado con éxito.");
                }
            }
        }
    }
}

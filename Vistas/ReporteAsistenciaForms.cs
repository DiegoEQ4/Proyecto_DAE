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
        int filtrado = 0;


        public ReporteAsistenciaForms()
        {
            InitializeComponent();
        }

        private void ReporteAsistenciaForms_Load(object sender, EventArgs e)
        {
            CargarGrado();
            CargarClase();
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
                    //COMBOBOX FECHA
                    int idGradoF = 0;
                    if (cmbGradoFecha.SelectedItem is Grado selectGradoF)
                    {
                        idGradoF = selectGradoF.IdGrado;
                    }

                    //COMBOBOX GRADO
                    int idGrado = 0;
                    if (cmbGrado.SelectedItem is Grado selectGrado)
                    {
                        idGrado = selectGrado.IdGrado;
                    }

                    //COMBOBOX CLASE
                    int idClase = 0;
                    if (cmbClase.SelectedItem is Clase selectClase)
                    {
                        idClase = selectClase.IdClase;
                    }
                    switch (filtrado)
                    {

                        case 1:
                            reporte.FiltradoUno(rutaArchivo,idGradoF, dateInicio.Value, dateFinal.Value);
                            break;
                        case 2:
                            reporte.FiltradoDos(rutaArchivo, idGrado);
                            break;
                        case 3:
                            MessageBox.Show("ID: " + idClase);
                            reporte.FiltradoTres(rutaArchivo, idClase);
                            break;


                    }


                    MessageBox.Show("Reporte creado con éxito.");
                }
            }
        }

        private void CargarGradoFecha()
        {

            using (var query = new RegistroAsistenciaContext())
            {

                List<Grado> grados = query.Grados.ToList();

                cmbGradoFecha.DataSource = grados;
                cmbGradoFecha.ValueMember = "IdGrado";
                cmbGradoFecha.DisplayMember = "NombreCompleto";

            }


        }

        private void CargarGrado()
        {

            using (var query = new RegistroAsistenciaContext())
            {

                List<Grado> grados = query.Grados.ToList();

                cmbGrado.DataSource = grados;
                cmbGrado.ValueMember = "IdGrado";
                cmbGrado.DisplayMember = "NombreCompleto";

            }


        }

        private void CargarClase()
        {

            using (var query = new RegistroAsistenciaContext())
            {

                List<Clase> clases = query.Clases.ToList();

                cmbClase.DataSource = clases;
                cmbClase.ValueMember = "IdClase";
                cmbClase.DisplayMember = "ContenidoClase";

            }


        }


        private void btnFecha_Click(object sender, EventArgs e)
        {
            
            filtrado = 1;
            //HACER VISIBLE CONTROLES
            btnReporte.Visible = true;
            lblInicio.Visible = true;
            lblFinal.Visible = true;
            lblFechaGrado.Visible = true;
            dateInicio.Visible = true;
            dateFinal.Visible = true;
            cmbGradoFecha.Visible = true;
            CargarGradoFecha();
            //OCULTAR
            lblGrado.Visible = false;
            cmbGrado.Visible = false;
            lblClase.Visible = false;
            cmbClase.Visible = false;

        }

        private void btnGrado_Click(object sender, EventArgs e)
        {
            filtrado = 2;
            //VISIBLE
            btnReporte.Visible = true;
            lblGrado.Visible = true;
            cmbGrado.Visible = true;
            CargarGrado();


            //OCULTO
            lblClase.Visible = false;
            cmbClase.Visible = false;
            lblInicio.Visible = false;
            lblFinal.Visible = false;
            lblFechaGrado.Visible = false;
            dateInicio.Visible = false;
            dateFinal.Visible = false;
            cmbGradoFecha.Visible = false;
        }

        private void btnClase_Click(object sender, EventArgs e)
        {
            filtrado = 3;
            //VISIBLE 
            btnReporte.Visible = true;
            lblClase.Visible = true;
            cmbClase.Visible = true;
            CargarClase();
            //OCULTO
            lblInicio.Visible = false;
            lblFinal.Visible = false;
            lblFechaGrado.Visible = false;
            dateInicio.Visible = false;
            dateFinal.Visible = false;
            cmbGradoFecha.Visible = false;
            lblGrado.Visible = false;
            cmbGrado.Visible = false;
        }


    }
}

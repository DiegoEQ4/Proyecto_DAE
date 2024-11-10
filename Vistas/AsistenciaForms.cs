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
    public partial class AsistenciaForms : Form
    {
        GestionAsistencia gestionAsistencia = new GestionAsistencia();

        int idDetalle;
        int idAsistencia;
        public AsistenciaForms(int id)
        {
            InitializeComponent();

            idAsistencia = id;
        }

        private void AsistenciaForms_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ID DETALLE: " + idAsistencia);
            CargarAlumnos();
        }





        private void CargarAlumnos()
        {

            using (var query = new RegistroAsistenciaContext())
            {

                var detalle = (from d in query.DetalleAsistencia
                               join e in query.Estudiantes
                               on d.Estudiante equals e.CarnetEstudiantes
                               where d.IdAsistencia == idAsistencia
                               select new
                               {
                                   Asistencia = d.IdDetalleAsistencia,
                                   Carnet = e.CarnetEstudiantes,
                                   Apellido = e.Apellido,
                                   Nombre = e.Nombre,
                                   Estado = d.Estado,
                                   Detalle = d.Detalle,

                               }
                                )
                                .OrderBy(e => e.Apellido)
                                .ToList();
                dataGridView1.DataSource = detalle;

            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dataGridView1.SelectedRows[0];

                var id = selected.Cells["Asistencia"].Value.ToString();
                try
                {
                    txtCarnet.Text = selected.Cells["Carnet"].Value.ToString();
                    txtNombre.Text = selected.Cells["Apellido"].Value.ToString() + " " + selected.Cells["Nombre"].Value.ToString();
                    if (selected.Cells["Detalle"].Value != null && selected.Cells["Estado"].Value != null)
                    {
                        txtObservacion.Text = selected.Cells["Detalle"].Value.ToString();
                        txtEstado.Text = selected.Cells["Estado"].Value.ToString();

                    }
                    else
                    {
                        txtObservacion.Text = "Sin observaciones";

                    }
                    txtEstado.Text = selected.Cells["Estado"].Value.ToString();
                }
                catch (Exception ex) { }
                idDetalle = int.Parse(id);
                MessageBox.Show("ID: " + idDetalle);
            }
        }

        private void btnPresente_Click(object sender, EventArgs e)
        {
            int rowActual = dataGridView1.CurrentRow?.Index ?? -1;
            gestionAsistencia.EstadoAsistencia(1, idDetalle, txtObservacion.Text);
            CargarAlumnos();
            if (dataGridView1.Rows.Count > 0)
            {
                if (rowActual == -1 || rowActual == dataGridView1.Rows.Count - 1)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
                }
                else
                {
                    // Selecciona la siguiente fila

                    dataGridView1.CurrentCell = dataGridView1.Rows[rowActual + 1].Cells[0];
                }
            }
        }

        private void btnPermiso_Click(object sender, EventArgs e)
        {
            int rowActual = dataGridView1.CurrentRow?.Index ?? -1;
            gestionAsistencia.EstadoAsistencia(2, idDetalle, txtObservacion.Text);
            CargarAlumnos();
            if (dataGridView1.Rows.Count > 0)
            {

                if (rowActual == -1 || rowActual == dataGridView1.Rows.Count - 1)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
                }
                else
                {
                    // Selecciona la siguiente fila

                    dataGridView1.CurrentCell = dataGridView1.Rows[rowActual + 1].Cells[0];
                }
            }
            
        }

        private void btnAusente_Click(object sender, EventArgs e)
        {

            int rowActual = dataGridView1.CurrentRow?.Index ?? -1;
            gestionAsistencia.EstadoAsistencia(3, idDetalle, txtObservacion.Text);
            CargarAlumnos();
            if (dataGridView1.Rows.Count > 0)
            {
                if (rowActual == -1 || rowActual == dataGridView1.Rows.Count - 1)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
                }
                else
                {
                    // Selecciona la siguiente fila

                    dataGridView1.CurrentCell = dataGridView1.Rows[rowActual + 1].Cells[0];
                }
            }
            
        }


        private int[] getDetalle()
        {

            int[] detalles;
            using (var query = new RegistroAsistenciaContext())
            {

                int[] ids = (
                        from d in query.DetalleAsistencia
                        where d.IdAsistencia == idAsistencia
                        select d.IdDetalleAsistencia
                    ).ToArray();
                detalles = ids;
            }

            return detalles;

        }
        private void btnAllPresente_Click(object sender, EventArgs e)
        {
            gestionAsistencia.AllEstadoAsistencia(getDetalle(), 1);
            CargarAlumnos();
        }

        private void btnAllPermisos_Click(object sender, EventArgs e)
        {
            gestionAsistencia.AllEstadoAsistencia(getDetalle(), 2);
            CargarAlumnos();
        }

        private void btnAllAusente_Click(object sender, EventArgs e)
        {
            gestionAsistencia.AllEstadoAsistencia(getDetalle(), 3);
            CargarAlumnos();
        }

        private void txtObservacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

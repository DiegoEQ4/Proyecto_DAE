using Microsoft.EntityFrameworkCore;
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
using static System.Collections.Specialized.BitVector32;

namespace Proyecto_DAE.Vistas
{
    public partial class GradoForms : Form
    {
        private Grado grado;
        GestionGrado gestionGrado = new GestionGrado();
        RegistroAsistenciaContext context = new RegistroAsistenciaContext();

        public GradoForms()
        {
            InitializeComponent();
        }

        private void GradoForms_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            gestionGrado.InsertGrado(GetGrado());
            CargarTabla();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            gestionGrado.UpdateGrado(GetGrado(), int.Parse(txtIdGrado.Text));
            context.SaveChanges();
            MessageBox.Show("Grado Actualizado");

            CargarTabla();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            gestionGrado.DeleteGrado(int.Parse(txtIdGrado.Text));
            MessageBox.Show("Grado Eliminado");
            CargarTabla();
        }

        private Grado GetGrado()
        {
            grado = new Grado
            {
                NombreGrado = txtNombreGrado.Text,
                Seccion = txtSeccionGrado.Text,
                Cupos = int.Parse(txtCupos.Text),
                Anio = int.Parse(txtAnio.Text)
            };
            return grado;
        }


        private void CargarTabla()
        {
            var gradosTabla = context.Grados.AsNoTracking().ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gradosTabla;

            dataGridView1.Columns["IdGrado"].HeaderText = "Id";
            dataGridView1.Columns["NombreGrado"].HeaderText = "Nombre";
            dataGridView1.Columns["Anio"].HeaderText = "Año";

            dataGridView1.Columns["Estudiantes"].Visible = false;
            dataGridView1.Columns["MateriaGrados"].Visible = false;

            dataGridView1.Refresh();

        }

        // SELECCION EN TABLA 

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dataGridView1.SelectedRows[0];

                txtIdGrado.Text = selected.Cells["IdGrado"].Value.ToString();
                txtNombreGrado.Text = selected.Cells["NombreGrado"].Value.ToString();
                txtSeccionGrado.Text = selected.Cells["Seccion"].Value.ToString();
                txtCupos.Text = selected.Cells["Cupos"].Value.ToString();
                txtAnio.Text = selected.Cells["Anio"].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

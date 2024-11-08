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
    public partial class EstudianteForms : Form
    {

        private List<Grado> grados;
        private List<Estudiante> estudiantes;

        GestionEstudiantes gestionEstudiantes = new GestionEstudiantes();

        public EstudianteForms()
        {
            InitializeComponent();
        }

        private void EstudianteForms_Load(object sender, EventArgs e)
        {
            CargarGrados();
            CargarTabla();
        }


        private void CargarGrados()
        {
            using (var query = new RegistroAsistenciaContext())
            {
                grados = query.Grados.ToList();

                cmbGrado.DataSource = grados;
                cmbGrado.ValueMember = "IdGrado";
                cmbGrado.DisplayMember = "NombreGrado";
            }
        }

        private void CargarTabla()
        {
            using (var query = new RegistroAsistenciaContext())
            {
                estudiantes = query.Estudiantes.ToList();

                dataGridView1.DataSource = estudiantes;

                dataGridView1.Columns["DetalleAsistencia"].Visible = false;
                dataGridView1.Columns["GradoNavigation"].Visible = false;
            }
        }

        private Estudiante GetEstudiante()
        {
            int idGrado = 0;

            if (cmbGrado.SelectedItem is Grado selectGrado)
            {
                idGrado = selectGrado.IdGrado;
            }

            DateOnly fecha = DateOnly.FromDateTime(dateNacimiento.Value);

            var estudiante = new Estudiante
            {
                CarnetEstudiantes = int.Parse(txtCarnet.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                CorreoInstitucional = txtCorreo.Text,
                FechaNacimiento = fecha,
                Grado = idGrado,
            };

            return estudiante;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gestionEstudiantes.InsertEstudiante(GetEstudiante());
            CargarTabla();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            gestionEstudiantes.UpdateEstudiante(GetEstudiante(), int.Parse(txtCarnet.Text));
            CargarTabla();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            gestionEstudiantes.DeleteEstudiante(int.Parse(txtCarnet.Text));
            CargarTabla();
        }


        // SELECCION EN TABLA 
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dataGridView1.SelectedRows[0];

                txtCarnet.Text = selected.Cells["CarnetEstudiantes"].Value.ToString();
                txtNombre.Text = selected.Cells["Nombre"].Value.ToString();
                txtApellido.Text = selected.Cells["Apellido"].Value.ToString();
                txtCorreo.Text = selected.Cells["CorreoInstitucional"].Value.ToString();
                cmbGrado.Text = selected.Cells["Grado"].Value.ToString();
                dateNacimiento.Text = selected.Cells["FechaNacimiento"].Value.ToString();

            }
        }

        private void cmbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using Proyecto_DAE.Clases;
using Proyecto_DAE.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DAE.Vistas
{
    public partial class EstudianteForms : Form
    {

        private List<Grado> grados;

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


        
        //AGREGAR
        private void button1_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                gestionEstudiantes.InsertEstudiante(GetEstudiante());
                CargarTabla();
            }
        }
        //EDITAR
        private void button3_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                gestionEstudiantes.UpdateEstudiante(GetEstudiante(), int.Parse(txtCarnet.Text));
                CargarTabla();
            }
        }
        //BORRAR
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

                txtCarnet.Text = selected.Cells["Carnet"].Value.ToString();
                txtNombre.Text = selected.Cells["Nombre"].Value.ToString();
                txtApellido.Text = selected.Cells["Apellido"].Value.ToString();
                txtCorreo.Text = selected.Cells["Correo"].Value.ToString();
                cmbGrado.SelectedValue = selected.Cells["IdGrado"].Value;
                dateNacimiento.Text = selected.Cells["Nacimiento"].Value.ToString();

            }
        }

        private void cmbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void txtCarnet_TextChanged(object sender, EventArgs e)
        {
            ValidarCarnet();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
        }


        private void btnPermitir_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            txtCarnet.Enabled = true;
        }




        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarNombreApellido();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            ValidarNombreApellido();
        }

        private void CargarGrados()
        {
            using (var query = new RegistroAsistenciaContext())
            {
                grados = query.Grados.ToList();


                cmbGrado.DataSource = grados;
                cmbGrado.ValueMember = "IdGrado";
                cmbGrado.DisplayMember = "NombreCompleto";
            }
        }

        private void CargarTabla()
        {
            using (var query = new RegistroAsistenciaContext())
            {
                var estudiantes = (
                        from e in query.Estudiantes
                        join g in query.Grados
                        on e.Grado equals g.IdGrado
                        select new
                        {
                            Carnet = e.CarnetEstudiantes,
                            Nombre = e.Nombre,
                            Apellido = e.Apellido,
                            Nacimiento = e.FechaNacimiento,
                            Correo = e.CorreoInstitucional,
                            IdGrado = g.IdGrado,
                            Grado = g.NombreCompleto,
                        }

                    ).ToList();

                dataGridView1.DataSource = estudiantes;
                dataGridView1.Columns["IdGrado"].Visible = false;
            }
        }
        // FUNCIONES 
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


        // VALIDACIONES!
        private void ValidarNombreApellido()
        {
            string nombrePattern = @"^[a-zA-Z\s]+$"; // Solo letras y espacios
            bool nombreValido = !string.IsNullOrEmpty(txtNombre.Text) && Regex.IsMatch(txtNombre.Text, nombrePattern);
            bool apellidoValido = !string.IsNullOrEmpty(txtApellido.Text) && Regex.IsMatch(txtApellido.Text, nombrePattern);

            btnAgregar.Enabled = nombreValido && apellidoValido;
            btnEditar.Enabled = nombreValido && apellidoValido;

            if (!nombreValido)
            {

                txtNombre.Focus();
            }

            if (!apellidoValido)
            {

                txtApellido.Focus();
            }
        }

        private bool Validaciones()
        {
            return ValidarCarnet() & ValidarCorreo(); // El operador '&' asegura que ambas validaciones se ejecuten.
        }

        private bool ValidarCarnet()
        {
            bool carnetValido = !string.IsNullOrEmpty(txtCarnet.Text) && txtCarnet.Text.All(char.IsDigit);

            if (carnetValido)
            {
                txtCarnet.BackColor = SystemColors.Window;
            }
            else
            {
                txtCarnet.BackColor = Color.LightCoral;
                MessageBox.Show("El Carnet no es válido. Solo se permiten dígitos.", "Validación de Carnet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return carnetValido;
        }

        private bool ValidarCorreo()
        {
            string correoPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            bool correoValido = Regex.IsMatch(txtCorreo.Text, correoPattern);

            if (correoValido)
            {
                txtCorreo.BackColor = SystemColors.Window;
            }
            else
            {
                txtCorreo.BackColor = Color.LightCoral;
                MessageBox.Show("El correo electrónico no es válido.", "Validación de Correo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Clear();

            }

            return correoValido;
        }
    }
}

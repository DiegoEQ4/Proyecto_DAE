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
    public partial class ProfesorForms : Form
    {
        int idUser = 0;
        int tipoC;
        private List<Profesor> profesorList;

        GestionProfes gestionProfes = new GestionProfes();
        public ProfesorForms(int id, int tipo)
        {
            InitializeComponent();
            idUser = id;
            tipoC = tipo;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (int.TryParse(txtCarnetProfe.Text, out result))
            {

                gestionProfes.InsertProfes(GetProfesor());
                CargarTabla();
                this.Close();

            }
            else {

                MessageBox.Show("INGRESA UN CARNET VALIDO", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            }
        }

        //PERMISOS DEPENDIENDO DE OPCION
        private void PermisosUser()
        {

            if (idUser == 0)
            {

                btnAgregar.Enabled = false;
                txtCarnetProfe.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
                txtCarnetProfe.Enabled = true;

                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }

        }



        private void CargarTabla()
        {
            using (var query = new RegistroAsistenciaContext())
            {
                profesorList = query.Profesors.ToList();
                dataGridView1.DataSource = profesorList;


                dataGridView1.Columns["MateriaGrados"].Visible = false;
                dataGridView1.Columns["UsuarioNavigation"].Visible = false;
                dataGridView1.Columns["Usuario"].Visible = false;

                dataGridView1.Columns["CarnetProfesor"].HeaderText = "Carnet";
                dataGridView1.Columns["NombreProfesor"].HeaderText = "Nombre Completo";
                dataGridView1.Columns["CorreoInstitucional"].HeaderText = "Correo";
            }
        }

        //OBTIENE LOS DATOS DEL PROFESOR
        private Profesor GetProfesor()
        {


            DateOnly fecha = DateOnly.FromDateTime(dateFechaNacimiento.Value);

            var profe = new Profesor
            {
                CarnetProfesor = int.Parse(txtCarnetProfe.Text),
                NombreProfesor = string.Join(" ", txtNombreProfe.Text, txtApellidoProfe.Text),
                Titulo = txtTitulo.Text,
                CorreoInstitucional = txtCorreoProfe.Text,
                Telefono = txtTelefono.Text,
                FechaNacimiento = fecha,
                Usuario = idUser,
            };

            return profe;
        }

        private void ProfesorForms_Load(object sender, EventArgs e)
        {
            Validaciones();
            CargarTabla();
            PermisosUser();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dataGridView1.SelectedRows[0];


                string nombreCompleto = selected.Cells["NombreProfesor"].Value.ToString();
                string[] nombreSeparado = nombreCompleto.Split(' ');

                txtCarnetProfe.Text = selected.Cells["CarnetProfesor"].Value.ToString();
                txtNombreProfe.Text = nombreSeparado[0];
                txtApellidoProfe.Text = nombreSeparado[1];
                txtTitulo.Text = selected.Cells["Titulo"].Value.ToString();
                txtCorreoProfe.Text = selected.Cells["CorreoInstitucional"].Value.ToString();
                txtTelefono.Text = selected.Cells["Telefono"].Value.ToString();
                dateFechaNacimiento.Text = selected.Cells["FechaNacimiento"].Value.ToString();

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            gestionProfes.UpdateProfes(GetProfesor(), int.Parse(txtCarnetProfe.Text));
            CargarTabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            gestionProfes.DeleteProfe(int.Parse(txtCarnetProfe.Text));
            CargarTabla();
        }

        private void txtNombreProfe_TextChanged(object sender, EventArgs e)
        {
            Validaciones();
        }
        private void txtApellidoProfe_TextChanged(object sender, EventArgs e)
        {
            Validaciones();
        }

        private void txtCorreoProfe_TextChanged(object sender, EventArgs e)
        {
            Validaciones();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            Validaciones();
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            Validaciones();
        }

        //VALIDACION DE LOS CAMPOS
        private void Validaciones()
        {

            //VALIDACION NOMBRE
            string nombrePattern = @"^(?!\s*$)[a-zA-Z\s]+$";
            bool nombreValido = !string.IsNullOrEmpty(txtNombreProfe.Text) && Regex.IsMatch(txtNombreProfe.Text, nombrePattern);

            if (nombreValido)
            {
                txtNombreProfe.BackColor = SystemColors.Window;
            }
            else
            {
                txtNombreProfe.BackColor = Color.LightCoral;
            }
            //VALIDACION APELLIDO
            string apellidoPattern = @"^(?!\s*$)[a-zA-Z\s]+$";
            bool apellidoValido = !string.IsNullOrEmpty(txtApellidoProfe.Text) && Regex.IsMatch(txtApellidoProfe.Text, apellidoPattern);

            if (apellidoValido)
            {
                txtApellidoProfe.BackColor = SystemColors.Window;
            }
            else
            {
                txtApellidoProfe.BackColor = Color.LightCoral;
            }

            //VALIDACION CORREO
            string correoPattern = @"^(?!\s*$)(?!.*\d)[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"; // Expresión regular para correo válido
            bool correoValido = !string.IsNullOrEmpty(txtCorreoProfe.Text) && Regex.IsMatch(txtCorreoProfe.Text, correoPattern);

            if (correoValido)
            {
                txtCorreoProfe.BackColor = SystemColors.Window;
            }
            else
            {
                txtCorreoProfe.BackColor = Color.LightCoral;
            }
            //VALIDACION TELEFONO
            string telefonoPattern = @"^\d{8}$";
            bool telefonoValido = !string.IsNullOrEmpty(txtTelefono.Text) && Regex.IsMatch(txtTelefono.Text, telefonoPattern);

            if (telefonoValido)
            {
                txtTelefono.BackColor = SystemColors.Window;
            }
            else
            {
                txtTelefono.BackColor = Color.LightCoral;
            }

            //VALIDACION TITULACION
            bool tituloValido = !string.IsNullOrWhiteSpace(txtTitulo.Text);

            if (tituloValido)
            {
                txtTitulo.BackColor = SystemColors.Window;
            }
            else
            {
                txtTitulo.BackColor = Color.LightCoral;
            }

            if (idUser != 0)
            {

                btnAgregar.Enabled = apellidoValido && nombreValido && correoValido && telefonoValido && tituloValido;

            }
            else if (idUser == 0) {

                btnModificar.Enabled = apellidoValido && nombreValido && correoValido && telefonoValido && tituloValido;

            }




        }

    }
}

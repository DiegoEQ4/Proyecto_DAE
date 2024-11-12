using Microsoft.IdentityModel.Tokens;
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
    public partial class UsuarioForms : Form
    {

        GestionUsuario gestionUsuario = new GestionUsuario();
        public UsuarioForms()
        {
            InitializeComponent();
        }

        private void UsuarioForms_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {

                gestionUsuario.InsertUsuario(GetUsuario());
                CargarUsuarios();

            }
            else {

                MessageBox.Show("NO PUEDES DEJAR CAMPOS VACIOS ", "ADVERTENCIA", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            
            }

        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Validaciones()) { 
            
                gestionUsuario.UpdateUsuario(int.Parse(txtID.Text), GetUsuario());
                CargarUsuarios();

            }
            else
            {

                MessageBox.Show("NO PUEDES DEJAR CAMPOS VACIOS ", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            gestionUsuario.DeleteUsuario(int.Parse(txtID.Text));
            CargarUsuarios();
        }

        private Usuario GetUsuario()
        {

            var usuario = new Usuario
            {

                NombreUsuario = txtNombre.Text,
                Contrasena = txtContrasena.Text,
                Tipo = int.Parse(cmbTipo.Text),


            };


            return usuario;
        }

        private bool Validaciones() { 
        
            string nombreUsuario = txtNombre.Text;
            string password = txtContrasena.Text;
            bool nombreValido;
            bool passValida;

            if (!string.IsNullOrWhiteSpace(nombreUsuario) && !string.IsNullOrWhiteSpace(password) )
            {
                nombreValido = true;
                passValida = true;
            }
            else {

                passValida = false;
                nombreValido = false;

            }
            
            return nombreValido && passValida;
        
        }

        private void CargarUsuarios()
        {

            using (var query = new RegistroAsistenciaContext())
            {

                var usuarios = query.Usuarios.ToList();

                dataGridView1.DataSource = usuarios;

                dataGridView1.Columns["Profesors"].Visible = false;
                dataGridView1.Columns["Contrasena"].Visible = false;
            }
            //AJUSTAR EL ANCHO A LA TABLA
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn columna in dataGridView1.Columns)
            {
                columna.FillWeight = 1;
            }


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selected = dataGridView1.SelectedRows[0];
                    txtID.Text = selected.Cells["IdUsuario"].Value.ToString();
                    cmbTipo.Text = selected.Cells["Tipo"].Value.ToString();
                    txtNombre.Text = selected.Cells["NombreUsuario"].Value.ToString();

                }
                catch (Exception ex)
                {
                }
            }
        }


    }
}

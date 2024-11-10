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
            gestionUsuario.InsertUsuario(GetUsuario());
            CargarUsuarios();
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            gestionUsuario.UpdateUsuario(int.Parse(txtID.Text), GetUsuario());
            CargarUsuarios();
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

        private void CargarUsuarios()
        {

            using (var query = new RegistroAsistenciaContext())
            {

                var usuarios = query.Usuarios.ToList();

                dataGridView1.DataSource = usuarios;

                dataGridView1.Columns["Profesors"].Visible = false;
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


                }
                catch (Exception ex)
                {
                }
            }
        }


    }
}

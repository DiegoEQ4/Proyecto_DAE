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
    public partial class UserForm : Form
    {
        GestionUsuario gestionUsuario = new GestionUsuario();

        private Usuario usuario;

        public int id { get; set; }
        public string nombreUsuario { get; set; }
        public string contrasena { get; set; }

        public int tipo { get; set; }



        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        //CREA EL USUARIO PARA EL PROFESOR
        private void btnCrear_Click(object sender, EventArgs e)
        {
            using (var query = new RegistroAsistenciaContext())
            {
                if (Validaciones())
                {

                    nombreUsuario = txtUser.Text;
                    contrasena = txtPassword.Text;
                    tipo = 2;

                    usuario = new Usuario
                    {
                        NombreUsuario = nombreUsuario,
                        Contrasena = contrasena,
                        Tipo = tipo,
                    };



                    var result = gestionUsuario.InsertUsuario(usuario); //INSERTA USUARIO EN BASE DE DATO

                    if (result)
                    {

                        int? ultimoId = query.Usuarios.Max(u => (int?)u.IdUsuario);
                        id = ultimoId.Value;
                        ProfesorForms profesor = new ProfesorForms(id, 1);
                        this.Close();
                        profesor.Show();

                    }
                }
                else
                {

                    MessageBox.Show("NO PUEDES DEJAR CAMPOS VACIOS ", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        //CANCELAR CREACION DE USUARIO 
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Validaciones()
        {

            string nombreUsuario = txtUser.Text;
            string password = txtPassword.Text;
            bool nombreValido;
            bool passValida;

            if (!string.IsNullOrWhiteSpace(nombreUsuario) && !string.IsNullOrWhiteSpace(password))
            {
                nombreValido = true;
                passValida = true;
            }
            else
            {

                passValida = false;
                nombreValido = false;

            }

            return nombreValido && passValida;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

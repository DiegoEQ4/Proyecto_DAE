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
                nombreUsuario = txtUser.Text;
                contrasena = txtPassword.Text;
                tipo = 2;

                usuario = new Usuario
                {
                    NombreUsuario = nombreUsuario,
                    Contrasena = contrasena,
                    Tipo = tipo,
                };



                gestionUsuario.InsertUsuario(usuario); //INSERTA USUARIO EN BASE DE DATO
                int? ultimoId = query.Usuarios.Max(u => (int?)u.IdUsuario);
                id = ultimoId.Value;
                ProfesorForms profesor = new ProfesorForms(id);
                this.Close();
                profesor.Show();
            }
        }

        //CANCELAR CREACION DE USUARIO 
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

    public partial class MenuForms : Form
    {
        int idUser;
        public MenuForms(int id)
        {
            InitializeComponent();
            SessionDatos.UserId = id;
            idUser = SessionDatos.UserId;
        }

        //OBTIENE LOS DATOS DEL USUARIO
        public void GetUser()
        {
            using (var query = new RegistroAsistenciaContext())
            {
                var user = query.Usuarios.Find(idUser);

                lblUser.Text = user.NombreUsuario.ToString();
                SessionDatos.UserName = user.NombreUsuario.ToString();
                SessionDatos.Tipo = user.Tipo;
            }



        }

        private void MenuForms_Load(object sender, EventArgs e)
        {
            //OCULTA OPCIONES PARA USUARIO NORMAL
            this.WindowState = FormWindowState.Maximized;

            GetUser();

            if (SessionDatos.Tipo != 1)
            {
                gestionDeProfesorToolStripMenuItem.Visible = false;
                gestionUToolStripMenuItem.Visible = false;

            }

            //CENTRA LA IMAGEN
            pictureBox1.Left = (this.ClientSize.Width - pictureBox1.Width) / 2;
            pictureBox1.Top = (this.ClientSize.Height - pictureBox1.Height) / 2;


        }
        private void gestionDeProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Desea crear un nuevo usuario a un nuevo profesor?", "Crear Usuario?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UserForm userForm = new UserForm();
                userForm.ShowDialog();
            }
            else
            {
                int idUser = 0;
                ProfesorForms profeForms = new ProfesorForms(idUser);
                profeForms.Show();

            }
        }

        private void gestionDeGradoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionDeMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MateriaForms materiaForms = new MateriaForms();
            materiaForms.Show();
        }

        private void gestionDeEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstudianteForms estudianteForms = new EstudianteForms();
            estudianteForms.Show();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void añadirEditarOBorrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GradoForms gradoForms = new GradoForms();
            gradoForms.Show();
        }

        private void asignarMateriasAGradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarForms asignarForms = new AsignarForms();
            asignarForms.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gestionDeClasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClaseForms claseForms = new ClaseForms();
            claseForms.Show();
        }

        private void gestionDeAsistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ElegirAsistenciaForms elegirAsistencia = new ElegirAsistenciaForms();
            elegirAsistencia.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();

        }

        private void gestionUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioForms usarioForms = new UsuarioForms();
            usarioForms.Show();
        }

        private void reportesDeAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteAsistenciaForms reporteAsistenciaForms = new ReporteAsistenciaForms();
            reporteAsistenciaForms.Show();
        }
    }
}

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

            //POSICIONAR OBJETOS
            //MENU

            //imagen
            pictureBox1.Left = (this.ClientSize.Width - pictureBox1.Width) / 2;
            pictureBox2.Left = -25;
            pictureBox3.Left = this.ClientSize.Width - pictureBox3.Width + 25; 
            pictureBox4.Left = (this.ClientSize.Width - pictureBox4.Width) / 2;


            //BOTON
            btnCerrarSesion.Left = (this.ClientSize.Width - btnCerrarSesion.Width) / 2;

            //LABEL
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            lblUser.Left = ((this.ClientSize.Width - lblUser.Width) / 2)+ 155;

        }
        private void gestionDeProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Desea crear un nuevo usuario a un nuevo profesor?", "Crear Usuario?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UserForm userForm = new UserForm();
                userForm.ShowDialog();
            }
            else if (result == DialogResult.No)
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

        private void reporteDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportesEstudiantes reportesEstudiantes = new ReportesEstudiantes();    
            reportesEstudiantes.Show();
        }
    }
}

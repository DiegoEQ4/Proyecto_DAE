using Proyecto_DAE.Clases;
using Proyecto_DAE.Vistas;

namespace Proyecto_DAE
{
    public partial class Login : Form
    {

        LoginClass login = new LoginClass();

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idUser = login.VerificarUser(txtUsuario.Text, txtContrasena.Text);
            if (idUser != 0)
            {
                MenuForms menuF = new MenuForms(idUser);
                menuF.Show();
                this.Hide();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                MessageBox.Show("Cancelado."); // Cancela el cierre solo si se selecciona "No"
            }
            else
            {
                Application.Exit(); // Asegura que toda la aplicación finaliza
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { 
            
                int idUser = login.VerificarUser(txtUsuario.Text, txtContrasena.Text);
                if (idUser != 0)
                {
                    MenuForms menuF = new MenuForms(idUser);
                    menuF.Show();
                    this.Hide();
                }
            
            }
        }
    }
}

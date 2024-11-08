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
            if (idUser!= 0)
            {
                MenuForms menuF = new MenuForms(idUser);
                menuF.Show();
                this.Hide();
            }
        }
    }
}

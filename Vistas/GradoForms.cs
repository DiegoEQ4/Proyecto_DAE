using Microsoft.EntityFrameworkCore;
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
using static System.Collections.Specialized.BitVector32;

namespace Proyecto_DAE.Vistas
{
    public partial class GradoForms : Form
    {
        private Grado grado;

        GestionGrado gestionGrado = new GestionGrado();
        RegistroAsistenciaContext context = new RegistroAsistenciaContext();


        public GradoForms()
        {
            InitializeComponent();
        }

        private void GradoForms_Load(object sender, EventArgs e)
        {
            CargarTabla();
            if (SessionDatos.Tipo > 1)
            {
                button1.Visible = false;
                btnBorrar.Enabled = false;
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            gestionGrado.InsertGrado(GetGrado());
            CargarTabla();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            gestionGrado.UpdateGrado(GetGrado(), int.Parse(txtIdGrado.Text));
            context.SaveChanges();


            CargarTabla();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!txtIdGrado.Text.IsNullOrEmpty())
            {
                gestionGrado.DeleteGrado(int.Parse(txtIdGrado.Text));
                CargarTabla();
            }
            else
            {
                MessageBox.Show("SELECCIONA UN GRADO");

            }
        }

        private Grado GetGrado()
        {
            grado = new Grado
            {
                NombreGrado = txtNombreGrado.Text,
                Seccion = txtSeccionGrado.Text,
                Cupos = int.Parse(txtCupos.Text),
                Anio = int.Parse(txtAnio.Text)
            };
            return grado;
        }


        private void CargarTabla()
        {
            var gradosTabla = context.Grados.AsNoTracking().ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gradosTabla;

            dataGridView1.Columns["IdGrado"].HeaderText = "Id";
            dataGridView1.Columns["NombreGrado"].HeaderText = "Nombre";
            dataGridView1.Columns["Anio"].HeaderText = "Año";

            dataGridView1.Columns["Estudiantes"].Visible = false;
            dataGridView1.Columns["MateriaGrados"].Visible = false;
            dataGridView1.Columns["NombreCompleto"].Visible = false;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            dataGridView1.Refresh();

        }

        // SELECCION EN TABLA 

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dataGridView1.SelectedRows[0];

                txtIdGrado.Text = selected.Cells["IdGrado"].Value.ToString();
                txtNombreGrado.Text = selected.Cells["NombreGrado"].Value.ToString();
                txtSeccionGrado.Text = selected.Cells["Seccion"].Value.ToString();
                txtCupos.Text = selected.Cells["Cupos"].Value.ToString();
                txtAnio.Text = selected.Cells["Anio"].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNombreGrado_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreGrado.Text.IsNullOrEmpty())
            {

                txtNombreGrado.BackColor = Color.LightPink;

            }
            else
            {
                if (txtNombreGrado.Text.All(char.IsDigit))
                {
                    txtNombreGrado.BackColor = Color.LightPink;
                }
                else
                {
                    txtNombreGrado.BackColor = Color.White;
                }

            }
            ActualizarEstadoBotones();
        }


        //VALIDACION DE AÑO
        private void txtAnio_TextChanged(object sender, EventArgs e)
        {
            if (txtAnio.Text.IsNullOrEmpty())
            {

                txtAnio.BackColor = Color.LightPink;

            }
            else
            {
                if (int.TryParse(txtAnio.Text, out _))
                {
                    if (int.Parse(txtAnio.Text) > 1500)
                    {
                        txtAnio.BackColor = Color.White;

                    }
                    else
                    {
                        txtAnio.BackColor = Color.LightPink;

                    }
                }
                else
                {
                    txtAnio.BackColor = Color.LightPink;


                }
                ActualizarEstadoBotones();
            }
        }

        private void ActualizarEstadoBotones()
        {
            bool nombreValido = !string.IsNullOrEmpty(txtNombreGrado.Text) && !txtNombreGrado.Text.All(char.IsDigit);
            bool anioValido = int.TryParse(txtAnio.Text, out int anio) && anio > 1500;

            btnAgregar.Enabled = nombreValido && anioValido;
            btnModificar.Enabled = nombreValido && anioValido;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("DESEA PASAR AL SIGUIENTE AÑO?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes) {

                using (var query = new RegistroAsistenciaContext()) { 
                    int getYear = DateTime.Today.Year;
                    getYear = getYear + 1;
                    var date_Find = query.Grados
                        .Where(g => g.Anio == getYear)
                        .ToList();
                    foreach (var date in date_Find) {

                        var id = date.IdGrado;
                        var gradoFind = query.Grados.Find(id);
                        gradoFind.Anio = getYear-1;
                        query.SaveChanges();
                    };
                
                }
                CargarTabla();
            }
        }
    }
}

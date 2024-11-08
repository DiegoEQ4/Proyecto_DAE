using Microsoft.EntityFrameworkCore;
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
using MaterialSkin.Controls;
using MaterialSkin;
using Microsoft.IdentityModel.Tokens;

namespace Proyecto_DAE.Vistas
{
    public partial class MateriaForms : Form
    {
        private Materia materia;
        private List<Materia> materiaList;
        GestionMateria gestionMateria = new GestionMateria();

        public MateriaForms()
        {
            InitializeComponent();
        }
        private void MateriaForms_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            gestionMateria.InsertMateria(GetMateria());
            CargarTabla();
            ClearTxt();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            gestionMateria.UpdateMateria(GetMateria(), int.Parse(txtIdMateria.Text));
            CargarTabla();
            ClearTxt();
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!txtIdMateria.Text.IsNullOrEmpty())
            {
                gestionMateria.DeleteMateria(int.Parse(txtIdMateria.Text));
                CargarTabla();
                ClearTxt();
            }
            else {
                MessageBox.Show("SELECCIONA UNA MATERIA", "PRECAUCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        public Materia GetMateria()
        {

            materia = new Materia
            {
                NombreMateria = txtNombreMateria.Text,
                DuracionDias = int.Parse(txtDuracion.Text),
                Descripcion = txtDescripcion.Text,
            };


            return materia;
        }



        private void CargarTabla()
        {
            using (var query = new RegistroAsistenciaContext())
            {
                materiaList = query.Materias.AsNoTracking().ToList();

                dataGridView1.DataSource = materiaList;

                dataGridView1.Columns["MateriaGrados"].Visible = false;

                dataGridView1.Columns["IdMateria"].HeaderText = "ID";
                dataGridView1.Columns["NombreMateria"].HeaderText = "Nombre";
                dataGridView1.Columns["DuracionDias"].HeaderText = "Duracion en dias";
                dataGridView1.Columns["IdMateria"].HeaderText = "ID";
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dataGridView1.SelectedRows[0];

                txtIdMateria.Text = selected.Cells["IdMateria"].Value.ToString();
                txtNombreMateria.Text = selected.Cells["NombreMateria"].Value.ToString();
                txtDescripcion.Text = selected.Cells["Descripcion"].Value.ToString();
                txtDuracion.Text = selected.Cells["DuracionDias"].Value.ToString();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNombreMateria_TextChanged(object sender, EventArgs e)
        {
            if (!txtNombreMateria.Text.IsNullOrEmpty())
            {
                txtNombreMateria.BackColor = Color.White;
                btnAgregar.Enabled = true;
                btnModificar.Enabled = true;

            }
            else {

                txtNombreMateria.BackColor = Color.LightPink;
                btnAgregar.Enabled = false;
                btnModificar.Enabled = false;
                
            }
        }

        private void ClearTxt() {

            txtNombreMateria.Clear();
            txtDescripcion.Clear();
            txtDuracion.Value = 1;



        }
    }
}

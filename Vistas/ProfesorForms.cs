﻿using Proyecto_DAE.Clases;
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
    public partial class ProfesorForms : Form
    {
        int idUser = 0;
        private List<Profesor> profesorList;

        GestionProfes gestionProfes = new GestionProfes();
        public ProfesorForms(int id)
        {
            InitializeComponent();
            idUser = id;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("id: " + idUser);
            gestionProfes.InsertProfes(GetProfesor());
            CargarTabla();
        }

        //PERMISOS DEPENDIENDO DE OPCION
        private void PermisosUser() {

            if (idUser == 0) { 
                
                btnAgregar.Enabled = false;
                txtCarnetProfe.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled=true;
                txtCarnetProfe.Enabled=true;

                btnModificar.Enabled=false;
                btnEliminar.Enabled = false;
            }
        
        }



        private void CargarTabla()
        {
            using (var query = new RegistroAsistenciaContext())
            {
                profesorList = query.Profesors.ToList();
                dataGridView1.DataSource = profesorList;


                dataGridView1.Columns["MateriaGrados"].Visible = false;
                dataGridView1.Columns["UsuarioNavigation"].Visible = false;

                dataGridView1.Columns["CarnetProfesor"].HeaderText = "Carnet";
                dataGridView1.Columns["NombreProfesor"].HeaderText = "Nombre Completo";
                dataGridView1.Columns["CorreoInstitucional"].HeaderText = "Correo";
            }
        }

        //OBTIENE LOS DATOS DEL PROFESOR
        private Profesor GetProfesor()
        {


            DateOnly fecha = DateOnly.FromDateTime(dateFechaNacimiento.Value);

            var profe = new Profesor
            {
                CarnetProfesor = int.Parse(txtCarnetProfe.Text),
                NombreProfesor = string.Join(" ", txtNombreProfe.Text, txtApellidoProfe.Text),
                Titulo = txtTitulo.Text,
                CorreoInstitucional = txtCorreoProfe.Text,
                Telefono = txtTelefono.Text,
                FechaNacimiento = fecha,
                Usuario = idUser,
            };

            return profe;
        }

        private void ProfesorForms_Load(object sender, EventArgs e)
        {
            CargarTabla();
            PermisosUser();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dataGridView1.SelectedRows[0];

                
                string nombreCompleto = selected.Cells["NombreProfesor"].Value.ToString();
                string[] nombreSeparado = nombreCompleto.Split(' ');

                txtCarnetProfe.Text = selected.Cells["CarnetProfesor"].Value.ToString();
                txtNombreProfe.Text = nombreSeparado[0];
                txtApellidoProfe.Text = nombreSeparado[1];
                txtTitulo.Text = selected.Cells["Titulo"].Value.ToString();
                txtCorreoProfe.Text = selected.Cells["CorreoInstitucional"].Value.ToString();
                txtTelefono.Text = selected.Cells["Telefono"].Value.ToString();
                dateFechaNacimiento.Text = selected.Cells["FechaNacimiento"].Value.ToString();

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            gestionProfes.UpdateProfes(GetProfesor(), int.Parse(txtCarnetProfe.Text));
            CargarTabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            gestionProfes.DeleteProfe(int.Parse(txtCarnetProfe.Text));
            CargarTabla();
        }
    }
}

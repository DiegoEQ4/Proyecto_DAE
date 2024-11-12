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
    public partial class ClaseForms : Form
    {
        int idClase;
        int idDetalle;
        int idUsuario = SessionDatos.UserId;
        GestionClase gestionClase = new GestionClase();



        public ClaseForms()
        {
            InitializeComponent();
        }

        private void ClaseForms_Load(object sender, EventArgs e)
        {
            CargarClases();
            CargarMaterias();
            Validacion();


            if (SessionDatos.Tipo > 1)
            {
                btnEliminar.Enabled = false;
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            gestionClase.InsertClase(GetClase());
            CargarClases();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out idClase))
            {

                MessageBox.Show("SELECCIONA UNA CLASE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                gestionClase.UpdateClase(int.Parse(txtID.Text),GetClase());
                CargarClases();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out idClase))
            {

                MessageBox.Show("SELECCIONA UNA CLASE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                gestionClase.DeleteClase(int.Parse(txtID.Text));
                CargarClases();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out idClase))
            {

                MessageBox.Show("SELECCIONA UNA CLASE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else { 
            
                idClase = int.Parse(txtID.Text);
                ClaseAsistencia claseAsistencia = new ClaseAsistencia(idClase);
                claseAsistencia.Show();
            
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selected = dataGridView1.SelectedRows[0];
                    var iddetalle = selected.Cells["IdMateria"].Value.ToString();
                    idDetalle = int.Parse(iddetalle);
                    cmbMateria.SelectedValue = idDetalle;
                    txtID.Text = selected.Cells["ID"].Value.ToString();
                    idClase = int.Parse(txtID.Text);
                    txtContent.Text = selected.Cells["Contenido"].Value.ToString();
                    txtDuracion.Text = selected.Cells["Duracion"].Value.ToString();
                }
                catch (Exception ex)
                {

                }
            }
        }


        //FUNCIONES PARA OBTENER Y CARGAR DATOS 
        private void CargarClases()
        {

            using (var query = new RegistroAsistenciaContext())
            {
                if (SessionDatos.Tipo != 1)
                {

                    var claseList = (from c in query.Clases
                                     join mg in query.MateriaGrados
                                     on c.IdMateriaDetalle equals mg.IdMateriaGrado
                                     join m in query.Materias
                                     on mg.IdMateriaDetalle equals m.IdMateria
                                     join g in query.Grados
                                     on mg.IdGradoDetalle equals g.IdGrado
                                     join p in query.Profesors
                                     on mg.IdProfeDetalle equals p.CarnetProfesor
                                     where p.Usuario == idUsuario
                                     select new
                                     {
                                         ID = c.IdClase,
                                         Contenido = c.ContenidoClase,
                                         Duracion = c.DuracionHoras,
                                         IdMateria = mg.IdMateriaGrado,
                                         Materia = m.NombreMateria,
                                         Grado = g.NombreGrado + " " + g.Seccion,
                                     }
                        ).ToList();
                    dataGridView1.DataSource = claseList;

                }
                else if (SessionDatos.Tipo == 1) {

                    var claseList = (from c in query.Clases
                                     join mg in query.MateriaGrados
                                     on c.IdMateriaDetalle equals mg.IdMateriaGrado
                                     join m in query.Materias
                                     on mg.IdMateriaDetalle equals m.IdMateria
                                     join g in query.Grados
                                     on mg.IdGradoDetalle equals g.IdGrado
                                     join p in query.Profesors
                                     on mg.IdProfeDetalle equals p.CarnetProfesor
                                     select new
                                     {
                                         ID = c.IdClase,
                                         Contenido = c.ContenidoClase,
                                         Duracion = c.DuracionHoras,
                                         IdMateria = mg.IdMateriaGrado,
                                         Materia = m.NombreMateria,
                                         Grado = g.NombreGrado + " " + g.Seccion,
                                     }
                        ).ToList();
                    dataGridView1.DataSource = claseList;




                }

                dataGridView1.Columns["IdMateria"].Visible = false;




            }
        }

        private void CargarMaterias()
        {
            using (var query = new RegistroAsistenciaContext())
            {

                if (SessionDatos.Tipo != 1)
                {

                    var materias = (from m in query.Materias
                                    join mg in query.MateriaGrados on m.IdMateria equals mg.IdMateriaDetalle
                                    join p in query.Profesors on mg.IdProfeDetalle equals p.CarnetProfesor
                                    join g in query.Grados on mg.IdGradoDetalle equals g.IdGrado
                                    where p.Usuario == idUsuario
                                    select new
                                    {

                                        mg.IdMateriaGrado,
                                        Nombre = m.NombreMateria + "-" + g.NombreGrado + " " + g.Seccion,

                                    }
                                    ).ToList();

                    cmbMateria.DataSource = materias;
                    cmbMateria.DisplayMember = "Nombre";
                    cmbMateria.ValueMember = "IdMateriaGrado";


                }
                else if(SessionDatos.Tipo == 1) {

                    var materias = (from m in query.Materias
                                    join mg in query.MateriaGrados on m.IdMateria equals mg.IdMateriaDetalle
                                    join p in query.Profesors on mg.IdProfeDetalle equals p.CarnetProfesor
                                    join g in query.Grados on mg.IdGradoDetalle equals g.IdGrado
                                    select new
                                    {

                                        mg.IdMateriaGrado,
                                        Nombre = m.NombreMateria + "-" + g.NombreGrado + " " + g.Seccion,

                                    }
                                   ).ToList();

                    cmbMateria.DataSource = materias;
                    cmbMateria.DisplayMember = "Nombre";
                    cmbMateria.ValueMember = "IdMateriaGrado";

                }


            }

        }

        private Clase GetClase()
        {


            if (cmbMateria.SelectedValue != null)
            {
                idDetalle = (int)cmbMateria.SelectedValue;
            }

            var clase = new Clase
            {

                IdMateriaDetalle = idDetalle,
                DuracionHoras = decimal.Parse(txtDuracion.Text),
                ContenidoClase = txtContent.Text,

            };

            return clase;
        }

        private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            Validacion();
        }

        private void Validacion() {
            bool contenidoValido = !string.IsNullOrWhiteSpace(txtContent.Text);
            if (contenidoValido)
            {

                txtContent.BackColor = SystemColors.Window;
                btnAgregar.Enabled = true;
                btnEditar.Enabled = true;

            }
            else
            {
                txtContent.BackColor = Color.LightCoral;
                btnAgregar.Enabled = false;
                btnEditar.Enabled = false;
            }

        }

    }
}

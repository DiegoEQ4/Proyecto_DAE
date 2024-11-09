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
    public partial class AsignarForms : Form
    {
        GestionAsignar gestionAsignar = new GestionAsignar();

        public List<Grado> grados;
        public List<Materia> materias;

        public int idGrado = 0;
        public int idMateria = 0;
        public int idDetalle = 0;
        public int idProfe;

        public AsignarForms()
        {
            InitializeComponent();
        }

        private void AsignarForms_Load(object sender, EventArgs e)
        {
            CargarGrados();
            CargarMaterias();
            CargarProfes();
        }

        private void dataGrados_SelectionChanged(object sender, EventArgs e)
        {
            idDetalle = 0;
            if (dataGrados.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dataGrados.SelectedRows[0];
                txtGrado.Text = selected.Cells["NombreGrado"].Value.ToString();
                var idgrado = selected.Cells["IdGrado"].Value.ToString();
                idGrado = int.Parse(idgrado);
                CargarDetalleMateria(idGrado);
            }
        }

        private void dataMateria_SelectionChanged(object sender, EventArgs e)
        {
            if (dataMateria.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = dataMateria.SelectedRows[0];

                txtMateria.Text = selected.Cells["NombreMateria"].Value.ToString();

                var idmateria = selected.Cells["IdMateria"].Value.ToString();
                idMateria = int.Parse(idmateria);
            }
        }

        private void dataDetalleMateria_SelectionChanged(object sender, EventArgs e)
        {
            if (dataMateria.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selected = dataDetalleMateria.SelectedRows[0];
                    var iddetalle = selected.Cells["IdDetalle"].Value.ToString();
                    idDetalle = int.Parse(iddetalle);
                }
                catch (Exception ex)
                {

                }
            }
        }

        // FUNCIONES 

        private MateriaGrado GetMateriaGrado()
        {


            if (cmbProfe.SelectedItem is Profesor selectProfe)
            {
                idProfe = selectProfe.CarnetProfesor;
            }
            var materiaG = new MateriaGrado
            {
                IdGradoDetalle = idGrado,
                IdMateriaDetalle = idMateria,
                IdProfeDetalle = idProfe,

            };

            return materiaG;
        }

        private void CargarGrados()
        {

            using (var query = new RegistroAsistenciaContext())
            {

                grados = query.Grados.ToList();

                dataGrados.DataSource = grados;

                dataGrados.Columns["IdGrado"].HeaderText = "Id";
                dataGrados.Columns["NombreGrado"].HeaderText = "Nombre";

                dataGrados.Columns["IdGrado"].Visible = false;
                dataGrados.Columns["NombreCompleto"].Visible = false;
                dataGrados.Columns["Cupos"].Visible = false;
                dataGrados.Columns["Estudiantes"].Visible = false;
                dataGrados.Columns["MateriaGrados"].Visible = false;
                dataGrados.Columns["Anio"].Visible = false;
            }

            //AJUSTAR EL ANCHO A LA TABLA
            dataGrados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn columna in dataGrados.Columns)
            {
                columna.FillWeight = 1;
            }
        }

        private void CargarMaterias()
        {

            using (var query = new RegistroAsistenciaContext())
            {

                materias = query.Materias.ToList();

                dataMateria.DataSource = materias;

                dataMateria.Columns["IdMateria"].HeaderText = "Id";
                dataMateria.Columns["NombreMateria"].HeaderText = "Nombre";

                dataMateria.Columns["DuracionDias"].Visible = false;
                dataMateria.Columns["Descripcion"].Visible = false;
                dataMateria.Columns["MateriaGrados"].Visible = false;

            }

            //AJUSTAR EL ANCHO A LA TABLA
            dataMateria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn columna in dataMateria.Columns)
            {
                columna.FillWeight = 1;
            }
        }

        private void CargarDetalleMateria(int id)
        {
            
            using (var query = new RegistroAsistenciaContext())
            {
                //CONSULTA PARA OBTENER LOS DATOS 
                var materiaDetalle = (from mg in query.MateriaGrados
                                      join g in query.Grados
                                      on mg.IdGradoDetalle equals g.IdGrado
                                      join m in query.Materias
                                      on mg.IdMateriaDetalle equals m.IdMateria
                                      join p in query.Profesors
                                      on mg.IdProfeDetalle equals p.CarnetProfesor

                                      where mg.IdGradoDetalle == id
                                      select new
                                      {
                                          IdDetalle = mg.IdMateriaGrado,
                                          IdGrado = g.IdGrado,
                                          Grado = g.NombreGrado,
                                          IdMateria = m.IdMateria,
                                          Materia = m.NombreMateria,
                                          IdProfe = p.CarnetProfesor,
                                          Profesor = p.NombreProfesor,

                                      }
                                        ).ToList();

                dataDetalleMateria.DataSource = materiaDetalle;

                dataDetalleMateria.Columns["Materia"].HeaderText = "Materia";
                dataDetalleMateria.Columns["Grado"].HeaderText = "Grado";
                dataDetalleMateria.Columns["Profesor"].HeaderText = "Profesor";

                dataDetalleMateria.Columns["IdGrado"].Visible = false;
                dataDetalleMateria.Columns["IdMateria"].Visible = false;
                dataDetalleMateria.Columns["IdProfe"].Visible = false;


                //AJUSTAR EL ANCHO A LA TABLA
                dataDetalleMateria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                foreach (DataGridViewColumn columna in dataDetalleMateria.Columns)
                {
                    columna.FillWeight = 1;
                }
            }
        }

        private void CargarProfes()
        {

            using (var query = new RegistroAsistenciaContext())
            {
                var profes = query.Profesors.ToList();

                cmbProfe.DataSource = profes;
                cmbProfe.ValueMember = "CarnetProfesor";
                cmbProfe.DisplayMember = "NombreProfesor";
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            gestionAsignar.InsertMateria(GetMateriaGrado());
            CargarDetalleMateria(idGrado);
               
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idDetalle != 0)
            {
                gestionAsignar.UpdateMateria(idDetalle, GetMateriaGrado());
                CargarDetalleMateria(idGrado);
            }
            else {

                MessageBox.Show("SELECCIONE UNA MATERIA ASIGNADA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (idDetalle != 0)
            {
                gestionAsignar.DeleteMateria(idDetalle);
                CargarDetalleMateria(idGrado);
            }
            else
            {

                MessageBox.Show("SELECCIONE UNA MATERIA ASIGNADA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataDetalleMateria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

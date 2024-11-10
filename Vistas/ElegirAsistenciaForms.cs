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
    public partial class ElegirAsistenciaForms : Form
    {

        GestionAsistencia gestionAsistencia = new GestionAsistencia();
        int idUsuario = SessionDatos.UserId;
        int idClase;
        int idAsistencia;

        public ElegirAsistenciaForms()
        {
            InitializeComponent();
        }

        private void ElegirAsistenciaForms_Load(object sender, EventArgs e)
        {
            CargarGrados();
            CargarAsistencia();
            if (SessionDatos.Tipo != 1)
            {
                btnBorrar.Enabled = false;
            }

        }

        private void CargarGrados()
        {

            using (var query = new RegistroAsistenciaContext())
            {
                if (SessionDatos.Tipo != 1)
                {
                    var grados = (
                            from g in query.Grados
                            join mg in query.MateriaGrados
                            on g.IdGrado equals mg.IdGradoDetalle
                            join p in query.Profesors
                            on mg.IdProfeDetalle equals p.CarnetProfesor
                            join c in query.Clases
                            on mg.IdMateriaGrado equals c.IdMateriaDetalle
                            where p.Usuario == idUsuario
                            select new
                            {
                                ID = c.IdClase,
                                Contenido = c.ContenidoClase,
                                Grado = g.NombreGrado,
                                Seccion = g.Seccion
                            }

                        )
                        .Distinct()
                        .ToList();
                    dataGrados.DataSource = grados;
                }
                else if (SessionDatos.Tipo == 1) {

                    var grados = (
                        from g in query.Grados
                        join mg in query.MateriaGrados
                        on g.IdGrado equals mg.IdGradoDetalle
                        join p in query.Profesors
                        on mg.IdProfeDetalle equals p.CarnetProfesor
                        join c in query.Clases
                        on mg.IdMateriaGrado equals c.IdMateriaDetalle
                        select new
                        {
                            ID = c.IdClase,
                            Contenido = c.ContenidoClase,
                            Grado = g.NombreGrado,
                            Seccion = g.Seccion
                        }

                    )
                    .Distinct()
                    .ToList();
                    dataGrados.DataSource = grados;
                } 

            }
        }

        private void dataGrados_SelectionChanged(object sender, EventArgs e)
        {
            idAsistencia = 0;
            if (dataGrados.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selected = dataGrados.SelectedRows[0];
                    var idgrado = selected.Cells["ID"].Value.ToString();
                    idClase = int.Parse(idgrado);
                    CargarAsistencia();

                }
                catch (Exception ex)
                {
                }
            }
        }
        private void CargarAsistencia()
        {
            idAsistencia = 0;
            using (var query = new RegistroAsistenciaContext())
            {

                var asistencias = (
                        from a in query.Asistencia
                        join c in query.Clases
                        on a.ClaseAsistencia equals c.IdClase
                        where c.IdClase == idClase
                        select new
                        {

                            ID = a.IdAsistencia,
                            Fecha_Inicio = a.FechaHora,
                            Fecha_Final = a.FechaHoraFinal

                        }
                    ).ToList();

                if (asistencias != null)
                {
                    dataAsistencia.DataSource = asistencias;
                    dataAsistencia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    foreach (DataGridViewColumn columna in dataAsistencia.Columns)
                    {
                        columna.FillWeight = 1;
                    }
                }
                else
                {
                    MessageBox.Show("No hay asistencias para esta clase");
                }

            }
        }

        private void dataAsistencia_SelectionChanged(object sender, EventArgs e)
        {
            if (dataAsistencia.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selected = dataAsistencia.SelectedRows[0];
                    var idasistencia = selected.Cells["ID"].Value.ToString();
                    idAsistencia = int.Parse(idasistencia);

                }
                catch (Exception ex)
                {
                }
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (idAsistencia > 0)
            {
                AsistenciaForms asistenciaForms = new AsistenciaForms(idAsistencia);
                asistenciaForms.Show();
            }
            else
            {

                MessageBox.Show("SELECCIONA UNA ASISTENCIA!");

            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            if (idAsistencia != 0)
            {

                gestionAsistencia.BorrarAsistencia(idAsistencia);
                CargarAsistencia();

            }
            else {

                MessageBox.Show("SELECCIONA UNA ASISTENCIA", "ADVERTEBCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (idClase==0)
            {

                MessageBox.Show("SELECCIONA UNA CLASE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                ClaseAsistencia claseAsistencia = new ClaseAsistencia(idClase);
                claseAsistencia.Show();
                this.Close();

            }
        }
    }
}

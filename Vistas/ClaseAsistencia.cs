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
    public partial class ClaseAsistencia : Form
    {
        GestionAsistencia gestionAsistencia = new GestionAsistencia();

        int? idGrado;
        int idClase;
        public ClaseAsistencia(int id)
        {
            InitializeComponent();
            idClase = id;
        }

        private void ClaseAsistencia_Load(object sender, EventArgs e)
        {
            DateFormat();
            SetClase();
        }



        //FORMATO DE FECHA Y HORA
        private void DateFormat()
        {
            decimal duracion;
            fechaInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            fechaFinal.CustomFormat = "dd/MM/yyyy HH:mm";

            DateTime fechaSelect = fechaInicio.Value;


            using (var query = new RegistroAsistenciaContext())
            {

                var clase = query.Clases.Find(idClase);

                duracion = clase.DuracionHoras;
            }
            DateTime fechaFin = fechaSelect.AddHours((double)duracion);
            fechaFinal.Value = fechaFin;
        }

        private Asistencium GetAsistencia()
        {

            var asistencia = new Asistencium
            {
                FechaHora = fechaInicio.Value,
                FechaHoraFinal = fechaFinal.Value,
                ClaseAsistencia = idClase,
            };

            return asistencia;
        }



        private void SetClase()
        {

            using (var query = new RegistroAsistenciaContext())
            {

                //OBTENER EL CONTENIDO DE LA CLASE 
                var contenido = query.Clases
                    .Where(c => c.IdClase == idClase)
                    .Select(c => c.ContenidoClase)
                    .FirstOrDefault();
                txtContenido.Text = contenido;

                //OBTENER EL GRADO DE LA CLASE 
                var grado = (
                    from mg in query.MateriaGrados
                    where mg.Clases.Any(c => c.IdClase == idClase)
                    select new
                    {
                        IdGrado = mg.IdGradoDetalle,
                        Grado = mg.IdGradoDetalleNavigation.NombreGrado + " " + mg.IdGradoDetalleNavigation.Seccion
                    }
                             ).ToList();
                var primerGrado = grado.First();

                idGrado = primerGrado.IdGrado;
                txtClase.Text = primerGrado.Grado;

            }


        }
        private int[] getCarnetsAlumnos()
        {

            int[] carnetsAlumnos;
            using (var query = new RegistroAsistenciaContext())
            {

                int[] carnets = (
                        from e in query.Estudiantes
                        where e.Grado == idGrado
                        select e.CarnetEstudiantes
                    ).ToArray();
                carnetsAlumnos = carnets;
            }

            return carnetsAlumnos;

        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            gestionAsistencia.InsertAsistencia(GetAsistencia(), getCarnetsAlumnos());
            AsistenciaForms asistenciaForms = new AsistenciaForms(gestionAsistencia.idAsitencia);
            asistenciaForms.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

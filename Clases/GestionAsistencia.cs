using Proyecto_DAE.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Proyecto_DAE.Clases
{
    internal class GestionAsistencia
    {
        public int idAsitencia;
        public void InsertAsistencia(Asistencium asistencia, int[] carnets) {

            using (var query = new RegistroAsistenciaContext()) {
                
                query.Asistencia.Add(asistencia);
                try { 
                    int resultados = query.SaveChanges();
                    if (resultados > 0) {
                        int idAsistencia = asistencia.IdAsistencia;
                        this.idAsitencia = idAsistencia;
                        for (int i = 0; i < carnets.Length; i++)
                        {
                            var detalle = new DetalleAsistencium
                            {
                               
                                IdAsistencia = idAsistencia,
                                Estudiante = carnets[i],
                                Estado = "Indefinido",
                            };
                            query.DetalleAsistencia.Add(detalle);
                        };
                        query.SaveChanges();

                    }

                }catch (Exception ex) {

                    MessageBox.Show("Error " + ex);
                } 
            }
        }


        public void EstadoAsistencia(int estado, int id, string detalle) {

            switch (estado) {
                case 1: //PRESENTE
                    using (var query = new RegistroAsistenciaContext()) {
                        var detalle_find = query.DetalleAsistencia.Find(id);

                        detalle_find.Estado = "Presente";
                        detalle_find.Detalle = detalle;
                        query.SaveChanges();    
                    
                    }
                    break;
                case 2: //PERMISO
                    using (var query = new RegistroAsistenciaContext())
                    {
                        var detalle_find = query.DetalleAsistencia.Find(id);

                        detalle_find.Estado = "Permiso";
                        detalle_find.Detalle = detalle;
                        query.SaveChanges();

                    }
                    break;
                case 3: //AUSENTE
                    using (var query = new RegistroAsistenciaContext())
                    {
                        var detalle_find = query.DetalleAsistencia.Find(id);

                        detalle_find.Estado = "Ausente";
                        detalle_find.Detalle = detalle;
                        query.SaveChanges();

                    }
                    break;  
            }
        }
        public void AllEstadoAsistencia(int[] detalles, int estado)
        {
            using (var query = new RegistroAsistenciaContext()) {

                switch (estado) {
                    
                    case 1: //PRESENTE
                        
                        for (int i = 0; i < detalles.Length; i++){
                            var detalle_find = query.DetalleAsistencia.Find(detalles[i]);
                            detalle_find.Estado = "Presente";
                            query.SaveChanges();

                        }
                        break;
                    case 2: //PERMISO
                        for (int i = 0; i < detalles.Length; i++)
                        {
                            var detalle_find = query.DetalleAsistencia.Find(detalles[i]);
                            detalle_find.Estado = "Permiso";
                            query.SaveChanges();

                        }
                        break;
                    case 3: //AUSENTE
                        for (int i = 0; i < detalles.Length; i++)
                        {
                            var detalle_find = query.DetalleAsistencia.Find(detalles[i]);
                            detalle_find.Estado = "Ausente";
                            query.SaveChanges();
                        }
                            break;
                }
            
            }
        }

        public void BorrarAsistencia(int id) {

            using (var query = new RegistroAsistenciaContext()) {

                var detalleFind = query.DetalleAsistencia
                    .Where(da => da.IdAsistencia == id)
                    .ToList();

                MessageBox.Show("deta" + detalleFind);
                if (detalleFind.Count > 0)
                {

                    foreach (var detalle in detalleFind)
                    {

                        int? idDetalle = detalle.IdDetalleAsistencia;
                        MessageBox.Show("A ver" + idDetalle);
                        var detalles = query.DetalleAsistencia.Find(idDetalle);
                        if (detalles != null)
                        {

                            query.DetalleAsistencia.Remove(detalles);
                            var resultD = query.SaveChanges();
                            if (resultD > 0)
                            {
                                var asistencia = query.Asistencia.Find(id);
                                query.Asistencia.Remove(asistencia);
                                query.SaveChanges();
                                break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No hay detalle para borrar");
                            DialogResult result = MessageBox.Show("Desea borrar la asistencia?", "NO HAY DETALLES", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                var asistencia = query.Asistencia.Find(id);
                                query.Asistencia.Remove(asistencia);
                                query.SaveChanges();
                            }
                        }
                    }
                } else {
                    MessageBox.Show("No hay detalle para borrar");
                    DialogResult result = MessageBox.Show("Desea borrar la asistencia?", "NO HAY DETALLES", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var asistencia = query.Asistencia.Find(id);
                        query.Asistencia.Remove(asistencia);
                        query.SaveChanges();
                    }
                }
            }

        
        
        }
    }
}

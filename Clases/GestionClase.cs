using Proyecto_DAE.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DAE.Clases
{
    internal class GestionClase
    {

        public void InsertClase(Clase clase) {
            using (var query = new RegistroAsistenciaContext()) {

                if (clase.IdMateriaDetalle == null || clase.IdMateriaDetalle == 0)
                {

                    MessageBox.Show("SELECCIONA UNA MATERIA A IMPARTIR", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else { 
                
                    query.Clases.Add(clase);
                    try
                    {
                        query.SaveChanges();

                    }
                    catch (Exception ex) { 
                        MessageBox.Show("Error: "+ ex);
                    }
                
                }
            }
        }


        public void UpdateClase(int id, Clase clase) {

            using (var query = new RegistroAsistenciaContext())
            {
                var clase_find  = query.Clases.Find(id);
                if (clase_find != null) { 
                
                }
                clase_find.ContenidoClase = clase.ContenidoClase;
                clase_find.IdMateriaDetalle = clase.IdMateriaDetalle;
                clase_find.DuracionHoras = clase.DuracionHoras;
                query.SaveChanges();
            }
        }

        public void DeleteClase(int id) {

            using (var query = new RegistroAsistenciaContext()) {
                var clase_find = query.Clases.Find(id);
                if (clase_find != null)
                {
                    query.Clases.Remove(clase_find);
                    try
                    {
                        query.SaveChanges();
                    }
                    catch (Exception ex) {

                        MessageBox.Show("CLASE CONTIENE UNA ASISTENCIA BORRA ESA ASISTENCIA PARA ELIMINAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    }
                }



            
            }
        
        }

    }
}

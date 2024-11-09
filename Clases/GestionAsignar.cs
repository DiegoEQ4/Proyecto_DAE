using Proyecto_DAE.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DAE.Clases
{
    internal class GestionAsignar
    {


        public void InsertMateria(MateriaGrado materiaGrado) {

            using (var query = new RegistroAsistenciaContext()) {
                if (materiaGrado.IdProfeDetalle == 0 && materiaGrado.IdGradoDetalle == 0 && materiaGrado.IdMateriaDetalle == 0)
                {

                    MessageBox.Show("NO HAY UN GRADO, MATERIA o PROFESOR SELECCIONADO, SI NO EXISTEN AGREGUE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    
                    var materiaEsta = query.MateriaGrados.Any(mg => mg.IdMateriaDetalle == materiaGrado.IdMateriaDetalle && mg.IdGradoDetalle == materiaGrado.IdGradoDetalle);
                    if (materiaEsta)
                    {

                        MessageBox.Show("YA ESTA ESA MATERIA ASIGNADA EN EL GRADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else {
                        query.MateriaGrados.Add(materiaGrado);
                        query.SaveChanges();
                    }
                }

            }
        }

        public void UpdateMateria(int id, MateriaGrado materiaGrado) {

            using (var query = new RegistroAsistenciaContext()) {

                var materiaG_Find = query.MateriaGrados.Find(id);
                
                materiaG_Find.IdMateriaDetalle = materiaGrado.IdMateriaDetalle;
                materiaG_Find.IdProfeDetalle = materiaGrado.IdProfeDetalle;

                query.SaveChanges();
            
            }
        }

        public void DeleteMateria(int id)
        {
            using (var query = new RegistroAsistenciaContext())
            {
                try
                {

                    var materiaG_Find = query.MateriaGrados.Find(id);
                    query.MateriaGrados.Remove(materiaG_Find);
                    query.SaveChanges();

                }
                catch (Exception ex) {

                    MessageBox.Show("ESA MATERIA TIENE UNA CLASE IMPARTIDA, NO SE PUEDE ELIMINAR || BORRAR LA CLASE PRIMERO");
                } 
            }
        }
    }
}

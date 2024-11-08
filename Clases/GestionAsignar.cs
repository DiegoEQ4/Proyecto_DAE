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
                
                query.MateriaGrados.Add(materiaGrado);
                query.SaveChanges();

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
                var materiaG_Find = query.MateriaGrados.Find(id);
                query.MateriaGrados.Remove(materiaG_Find);
                query.SaveChanges();
            }
        }
    }
}

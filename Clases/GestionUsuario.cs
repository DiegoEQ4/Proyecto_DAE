using Proyecto_DAE.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DAE.Clases
{
    internal class GestionUsuario
    {


        public void InsertUsuario(Usuario usuario)
        {
            using (var query = new RegistroAsistenciaContext())
            {
                query.Usuarios.Add(usuario);
                query.SaveChanges();

            }
        }

    }
}

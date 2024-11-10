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


        public void UpdateUsuario(int id, Usuario usuario) {

            using (var query = new RegistroAsistenciaContext())
            {
                var user_find = query.Usuarios.Find(id);

                if (user_find != null)
                {

                    user_find.NombreUsuario = usuario.NombreUsuario;
                    user_find.Contrasena = usuario.Contrasena;
                    user_find.Tipo = usuario.Tipo;
                    query.SaveChanges();

                }
                else {

                    MessageBox.Show("NO SE ENCONTRO EL USUARIO!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                }
            }

        }

        public void DeleteUsuario(int id) {

            using (var query = new RegistroAsistenciaContext()) {

                var user_find = query.Usuarios.Find(id);
                if (user_find != null) {
                    if (user_find.Tipo != 1)
                    {

                        query.Usuarios.Remove(user_find);
                        query.SaveChanges();

                    }
                    else {

                        MessageBox.Show("NO SE PUEDE ELIMINAR EL USUARIO ADMIN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {

                    MessageBox.Show("NO SE ENCONTRO EL USUARIO!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }
        
        

        }

    }
}

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


        public bool InsertUsuario(Usuario usuario)
        {
            bool result;

            using (var query = new RegistroAsistenciaContext())
            {
                var usuario_exist = query.Usuarios
                    .Where(u => u.NombreUsuario == usuario.NombreUsuario)
                    .Count();

                if (usuario_exist > 0)
                {

                    MessageBox.Show("EL USUARIO YA EXISTE", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    result = false;
                }
                else { 
                
                    query.Usuarios.Add(usuario);
                    query.SaveChanges();
                    result = true;
                
                }

                return result;

            }
        }


        public void UpdateUsuario(int id, Usuario usuario) {

            using (var query = new RegistroAsistenciaContext())
            {
                var user_find = query.Usuarios.Find(id);

                if (user_find != null)
                {

                    var usuario_exist = query.Usuarios
                        .Where(u => u.NombreUsuario == usuario.NombreUsuario)
                        .Count();

                    if (usuario_exist > 0)
                    {
                        MessageBox.Show("EL NOMBRE DE USUARIO YA EXISTE", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else { 
                    
                        user_find.NombreUsuario = usuario.NombreUsuario;
                        user_find.Contrasena = usuario.Contrasena;
                        user_find.Tipo = usuario.Tipo;
                        query.SaveChanges();
                    
                    
                    }
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

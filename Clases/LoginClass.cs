using Proyecto_DAE.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DAE.Clases
{

    internal class LoginClass
    {
        public List<Usuario> users;
        RegistroAsistenciaContext context = new RegistroAsistenciaContext();

        //VERIFICA EL USUARIO PARA EL INICIO DE SESION
        public int VerificarUser(string usuario, string password) {

            string userlog = null, passwordlog = null;
            int idUser = 0;


            using ( var query  =  new RegistroAsistenciaContext()) { 
            
                users = query.Usuarios.ToList();
            
            }
            //RECORRE LA TABLA USUARIO
            foreach(Usuario user in users)
            {
                if(user.NombreUsuario == usuario)
                {
                    userlog = usuario;
                    if (user.Contrasena == password)
                    {
                        
                        passwordlog = password;
                        idUser = user.IdUsuario;
                        MessageBox.Show("Sesion iniciada");
                        return user.IdUsuario;
                    }
                }
            }
            if(idUser == 0) MessageBox.Show("Usuario o Contraseña Incorrecta");

            return idUser;

        }





    }
}

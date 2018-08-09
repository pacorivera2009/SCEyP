using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers;
using Models;

namespace Views
{
    public class vw_inicioSesion
    {
        con_inicioSesion con_iniciosesion = new con_inicioSesion();
        public string inicioSesion(string nombreUsuario = "", string contrasenaUsuario = "", string connectionString = "")
        {
            string resultado = string.Empty;

            if(nombreUsuario == "" && contrasenaUsuario == "")
            {
                resultado = "¡Complete los campos!";
            }
            else if(nombreUsuario == "")
            {
                resultado = "¡Introduzca su nombre de usuario!";
            }
            else if (contrasenaUsuario == "")
            {
                resultado = "¡Introduzca su contraseña de acceso!";
            }
            else if(connectionString == "")
            {
                resultado = "¡Consulte a sistemas!, no se encuentra la cadena de conexión hacia la base de datos";
            }
            else
            {
                resultado = con_iniciosesion.inicioSesion(nombreUsuario, contrasenaUsuario, connectionString)[0].mensaje.ToString();
            }

            return resultado;
        }
    }
}

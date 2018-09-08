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
        string nombreEquipo = Environment.MachineName;

        con_inicioSesion con_iniciosesion = new con_inicioSesion();
        public List<mod_Login> inicioSesion(string nombreUsuario = "", string contrasenaUsuario = "", string connectionString = "")
        {
            List<mod_Login> respuesta = new List<mod_Login>();

            mod_Login loginRespuesta = new mod_Login();

            if(nombreUsuario == "" && contrasenaUsuario == "")
            {
                loginRespuesta.bandera = "0";
                loginRespuesta.mensaje = "¡Complete los campos!";
            }
            else if(nombreUsuario == "")
            {
                loginRespuesta.bandera = "0";
                loginRespuesta.mensaje = "¡Introduzca su nombre de usuario!";
            }
            else if (contrasenaUsuario == "")
            {
                loginRespuesta.bandera = "0";
                loginRespuesta.mensaje = "¡Introduzca su contraseña de acceso!";
            }
            else if(connectionString == "")
            {
                loginRespuesta.bandera = "0";
                loginRespuesta.mensaje = "¡Consulte a sistemas!, no se encuentra la cadena de conexión hacia la base de datos";
            }
            else
            {
                con_Seguridad seguridad = new con_Seguridad();

                List<mod_respuestaProcedimientoAlmacenadoSimple> respuestaController = con_iniciosesion.inicioSesion(nombreUsuario, seguridad.Encriptar(contrasenaUsuario), connectionString, nombreEquipo).ToList();

                loginRespuesta.bandera = respuestaController[0].bandera.ToString();
                loginRespuesta.mensaje = respuestaController[0].mensaje.ToString();
            }

            respuesta.Add(loginRespuesta);

            return respuesta;
        }
    }
}

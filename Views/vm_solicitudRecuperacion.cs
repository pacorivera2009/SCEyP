using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Controllers;

namespace Views
{
    public class vm_solicitudRecuperacion
    {
        con_solicitudRecuperacion con_solicitudRecuperacion = new con_solicitudRecuperacion();

        public List<mod_solicitudRecuperacion> solicitudRecuperacion(string nombreUsuario = "", string connectionString = "")
        {
            List<mod_solicitudRecuperacion> respuesta = new List<mod_solicitudRecuperacion>();

            mod_solicitudRecuperacion solicitudRecuperacion = new mod_solicitudRecuperacion();

            if (nombreUsuario == "")
            {
                solicitudRecuperacion.bandera = "0";
                solicitudRecuperacion.mensaje = "¡Complete los campos!";
            }
            else
            {
                List<mod_respuestaProcedimientoAlmacenadoSimple> respuestaController = con_solicitudRecuperacion.solicitudRecuperacion(nombreUsuario, connectionString).ToList();

                solicitudRecuperacion.bandera = respuestaController[0].bandera.ToString();
                solicitudRecuperacion.mensaje = respuestaController[0].mensaje.ToString();
            }

            respuesta.Add(solicitudRecuperacion);

            return respuesta;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Controllers;

namespace Views
{
    public class vm_menuPrincipal
    {
        string nombreEquipo = Environment.MachineName;

        con_menuPrincipal con_menuPrincipal = new con_menuPrincipal();
        public List<mod_cierreSesion> cierreSesion(string nombreUsuario = "", string connectionString = "")
        {
            List<mod_cierreSesion> respuesta = new List<mod_cierreSesion>();

            mod_cierreSesion cierreSesionRespuesta = new mod_cierreSesion();

            List<mod_respuestaProcedimientoAlmacenadoSimple> respuestaController = con_menuPrincipal.cierreSesion(nombreUsuario,  connectionString, nombreEquipo).ToList();

            cierreSesionRespuesta.bandera = respuestaController[0].bandera.ToString();
            cierreSesionRespuesta.mensaje = respuestaController[0].mensaje.ToString();

            respuesta.Add(cierreSesionRespuesta);

            return respuesta;
        }
    }
}

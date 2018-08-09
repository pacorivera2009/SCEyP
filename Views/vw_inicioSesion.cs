using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers;

namespace Views
{
    public class vw_inicioSesion
    {
        con_inicioSesion con_iniciosesion = new con_inicioSesion();
        public string inicioSesion(string nombreUsuario = "", string contrasenaUsuario = "", string connectionString = "")
        {
            return con_iniciosesion.inicioSesion(nombreUsuario, contrasenaUsuario, connectionString);
        }
    }
}

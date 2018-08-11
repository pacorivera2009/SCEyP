using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Models;

namespace Controllers
{
    public class con_inicioSesion : con_conexionBD
    {
        con_conexionBD conexionBD = new con_conexionBD();

        public List<mod_respuestaProcedimientoAlmacenadoSimple> inicioSesion(string nombreUsuario, string contrasenaUsuario, string connectionString, string nombreEquipo)
        {
            //List<mod_respuestaProcedimientoAlmacenadoSimple> respuesta = new List<mod_respuestaProcedimientoAlmacenadoSimple>();
            List<MySqlParameter> parametrosLista = new List<MySqlParameter>();

            parametrosLista.Add(new MySqlParameter()
            {
                ParameterName = "nombreUsuario",
                MySqlDbType = MySqlDbType.VarChar,
                Value = nombreUsuario,
                Size = 200
            });

            parametrosLista.Add(new MySqlParameter()
            {
                ParameterName = "contrasenaUsuario",
                MySqlDbType = MySqlDbType.VarChar,
                Value = nombreUsuario,
                Size = 50
            });

            parametrosLista.Add(new MySqlParameter()
            {
                ParameterName = "dispositivoUsuario",
                MySqlDbType = MySqlDbType.VarChar,
                Value = nombreUsuario,
                Size = 200
            });

            return conexionBD.ejecucionProcedimientoAlmacenado("sp_inicioSesion", parametrosLista, connectionString);
            
            

        }
    }
}

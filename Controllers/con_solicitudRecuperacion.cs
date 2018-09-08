using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Models;

namespace Controllers
{
    public class con_solicitudRecuperacion
    {
        con_conexionBD conexionBD = new con_conexionBD();

        public List<mod_respuestaProcedimientoAlmacenadoSimple> solicitudRecuperacion(string nombreUsuario, string connectionString)
        {
            List<MySqlParameter> parametrosLista = new List<MySqlParameter>();

            parametrosLista.Add(new MySqlParameter()
            {
                ParameterName = "nombreUsuario",
                MySqlDbType = MySqlDbType.VarChar,
                Value = nombreUsuario,
                Size = 200
            });

            return conexionBD.ejecucionProcedimientoAlmacenado("sp_solicitudRecuperacion", parametrosLista, connectionString);

        }
    }
}

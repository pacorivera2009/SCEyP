using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Controllers
{
    public class con_conexionBD
    {

        public static MySqlConnection mysqlconnection(string connectionString)
        {
            // Prepara la conexión
            MySqlConnection dbConexion = new MySqlConnection(connectionString);

            return dbConexion;

        }
    }
}

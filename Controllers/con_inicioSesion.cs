using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Controllers
{
    public class con_inicioSesion
    {
        public string inicioSesion(string nombreUsuario, string contrasenaUsuario, string connectionString)
        {
            string query = "select * from tablaestadosentidadesfederativas;";

            MySqlConnection bdCon = new MySqlConnection(connectionString);

            bdCon.Open();

            MySqlCommand cmd = new MySqlCommand(query, bdCon);

            cmd.ExecuteScalar();

            bdCon.Close();

            return connectionString;
        }
    }
}

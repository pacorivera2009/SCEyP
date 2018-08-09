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
        public List<mod_Login> inicioSesion(string nombreUsuario, string contrasenaUsuario, string connectionString)
        {
            mod_Login Login = new mod_Login();

            List<mod_Login> lst_Login = new List<mod_Login>();

            string query = "call bdhugriba.sp_inicioSesion('" + nombreUsuario + "', '" + contrasenaUsuario + "');";

            MySqlConnection connection = con_conexionBD.mysqlconnection(connectionString);

            // Prepara la conexión
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            //commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            // A consultar !
            try
            {
                // Abre la base de datos
                connection.Open();

                // Ejecuta la consultas
                reader = commandDatabase.ExecuteReader();

                // Hasta el momento todo bien, es decir datos obtenidos

                // IMPORTANTE :#
                // Si tu consulta retorna un resultado, usa el siguiente proceso para obtener datos

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // En nuestra base de datos, el array contiene:  ID 0, FIRST_NAME 1,LAST_NAME 2, ADDRESS 3
                        // Hacer algo con cada fila obtenida
                        //string[] row = { reader.GetString(0), reader.GetString(1) };

                        Login.bandera = reader.GetString(0);
                        Login.mensaje = reader.GetString(1);

                        lst_Login.Add(Login);
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron datos.");
                }

                // Cerrar la conexión
                connection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar cualquier excepción
                Login.bandera = "0";
                Login.mensaje = ex.ToString();

                //return ex.ToString();
            }

            return lst_Login;

        }
    }
}

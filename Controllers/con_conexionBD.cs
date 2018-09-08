using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Diagnostics;
using Models;
using System.Data;

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

        public List<mod_respuestaProcedimientoAlmacenadoSimple> ejecucionProcedimientoAlmacenado(String StoreProcedure, List<MySqlParameter> ListParameters = null, string connectionString = "")
        {
            List<mod_respuestaProcedimientoAlmacenadoSimple> respuestaProcedimiento = new List<mod_respuestaProcedimientoAlmacenadoSimple>();
            mod_respuestaProcedimientoAlmacenadoSimple mod_respuestaProcedimiento = new mod_respuestaProcedimientoAlmacenadoSimple();

            MySqlConnection mySQLConnection = new MySqlConnection(connectionString);

            try
            {
                using (mySQLConnection)
                {
                    using (MySqlCommand cmd = new MySqlCommand(StoreProcedure, mySQLConnection))
                    {
                        mySQLConnection.Open();

                        cmd.CommandType = CommandType.StoredProcedure;

                        if (ListParameters != null)
                        {
                            foreach (MySqlParameter Parameter in ListParameters)
                            {
                                cmd.Parameters.Add(Parameter);
                            }
                        }

                        Debug.WriteLine(StoreProcedure);

                        MySqlDataReader reader;

                        // Ejecuta la consultas
                        reader = cmd.ExecuteReader();

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

                                mod_respuestaProcedimiento.bandera = reader.GetString(0);
                                mod_respuestaProcedimiento.mensaje = reader.GetString(1);

                                respuestaProcedimiento.Add(mod_respuestaProcedimiento);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se encontraron datos.");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {

                mod_respuestaProcedimiento.bandera = "0";
                mod_respuestaProcedimiento.mensaje = ex.Message.ToString();

                respuestaProcedimiento.Add(mod_respuestaProcedimiento);
            }
            catch (Exception ex)
            {
               
                mod_respuestaProcedimiento.bandera = "0";
                mod_respuestaProcedimiento.mensaje = ex.Message.ToString();

                respuestaProcedimiento.Add(mod_respuestaProcedimiento);
            }
            finally
            {
                mySQLConnection.Close();
            }

            return respuestaProcedimiento;

        }

    }
}

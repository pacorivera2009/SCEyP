using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views;
using System.Configuration;
using MySql.Data.MySqlClient;
using Models;

namespace SCEyP
{
    public partial class wf_inicioSesion : Form
    {
        vw_inicioSesion vm_iniciosesion = new vw_inicioSesion();

        //Cadena de conexion//
        string connectionString = string.Empty;

        public wf_inicioSesion()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["SCEyP.Properties.Settings.bdhugribaConnectionString"].ConnectionString;
        }

        private void wf_inicioSesion_Load(object sender, EventArgs e)
        {
            //SCEyP.Properties.Settings.bdhugribaConnectionString
        }

        private void btninicioSesion_Click(object sender, EventArgs e)
        {
            List<mod_Login> respuesta_pet = vm_iniciosesion.inicioSesion(txtnombreUsuario.Text, txtcontrasenaAcceso.Text, connectionString).ToList();

            if (respuesta_pet[0].bandera == "0")
            {
                MessageBox.Show(respuesta_pet[0].mensaje, "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if(txtnombreUsuario.Text == "" && txtcontrasenaAcceso.Text == "")
                {
                    txtnombreUsuario.Focus();
                }
                else if (txtnombreUsuario.Text == "" && txtcontrasenaAcceso.Text != "")
                {
                    txtnombreUsuario.Focus();
                }
                else if(txtnombreUsuario.Text != "" && txtcontrasenaAcceso.Text == "")
                {
                    txtcontrasenaAcceso.Focus();
                }
                else
                {
                    txtnombreUsuario.Clear();
                    txtcontrasenaAcceso.Clear();

                    txtnombreUsuario.Focus();
                }
            }
            else
            {
                MessageBox.Show(respuesta_pet[0].mensaje, "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}

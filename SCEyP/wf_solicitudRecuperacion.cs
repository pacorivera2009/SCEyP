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
using Models;
using System.Configuration;

namespace SCEyP
{
    public partial class wf_solicitudRecuperacion : Form
    {
        vm_solicitudRecuperacion vm_solicitudRecuperacion = new vm_solicitudRecuperacion();

        //Cadena de conexion//
        string connectionString = string.Empty;

        public wf_solicitudRecuperacion()
        {
            InitializeComponent();
        }

        private void wf_solicitudRecuperacion_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["SCEyP.Properties.Settings.bdhugribaConnectionString"].ConnectionString;
        }

        private void btnrecuperacionAcceso_Click(object sender, EventArgs e)
        {
            List<mod_solicitudRecuperacion> respuesta_pet = vm_solicitudRecuperacion.solicitudRecuperacion(txtnombreUsuario.Text, connectionString).ToList();

            if (respuesta_pet[0].bandera == "0")
            {
                MessageBox.Show(respuesta_pet[0].mensaje, "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (txtnombreUsuario.Text == "")
                {
                    txtnombreUsuario.Focus();
                }
                else
                {
                    txtnombreUsuario.Clear();
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

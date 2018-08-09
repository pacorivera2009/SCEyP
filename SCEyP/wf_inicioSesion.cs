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

            string cadenaConexion = vm_iniciosesion.inicioSesion(textBox1.Text, textBox2.Text, connectionString);

            MessageBox.Show(cadenaConexion);

        }
    }
}

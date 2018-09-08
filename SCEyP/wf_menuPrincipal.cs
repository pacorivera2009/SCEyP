using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Views;
using System.Configuration;

namespace SCEyP
{
    public partial class wf_menuPrincipal : Form
    {
        vm_menuPrincipal vm_menuPrincipal = new vm_menuPrincipal();

        //Cadena de conexion//
        string connectionString = string.Empty;

        public wf_menuPrincipal()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["SCEyP.Properties.Settings.bdhugribaConnectionString"].ConnectionString;
        }

        private void wf_menuPrincipal_Load(object sender, EventArgs e)
        {
            tss_fechaHoraSistema.Text = DateTime.Now.ToLongDateString() + "   " + DateTime.Now.ToShortTimeString();
            tss_nombreUsuario.Text = "Francisco José Rivera Mundo";

            tm_horaSistema.Enabled = true;
        }

        private void tm_horaSistema_Tick(object sender, EventArgs e)
        {
            tm_horaSistema.Enabled = false;
            tss_fechaHoraSistema.Text = DateTime.Now.ToLongDateString() + "   " + DateTime.Now.ToShortTimeString();
            tm_horaSistema.Enabled = true;
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult mensaje = new DialogResult();

            mensaje = MessageBox.Show("¿Desea cerrar sesión?", "Pregunta del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(mensaje == DialogResult.Yes)
            {
                List<mod_cierreSesion> respuesta_pet = vm_menuPrincipal.cierreSesion(nombreUsuario: "pacorivera2009",  connectionString: connectionString).ToList();

                if(respuesta_pet[0].bandera == "0")
                {
                    MessageBox.Show(respuesta_pet[0].mensaje, "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void cerrarSCEyPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult mensaje = new DialogResult();

            mensaje = MessageBox.Show("¿Desea cerrar la aplicación?", "Pregunta del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (mensaje == DialogResult.Yes)
            {
                List<mod_cierreSesion> respuesta_pet = vm_menuPrincipal.cierreSesion(nombreUsuario: "pacorivera2009", connectionString: connectionString).ToList();

                if (respuesta_pet[0].bandera == "0")
                {
                    MessageBox.Show(respuesta_pet[0].mensaje, "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}

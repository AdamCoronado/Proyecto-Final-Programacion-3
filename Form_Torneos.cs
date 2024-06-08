using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutBol_Torneos_Management
{
    public partial class Form_Torneos : Form
    {
        public Form_Torneos()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            this.Close();
            principal.Show();
        }

        private void btnNuevoTorneo_Click(object sender, EventArgs e)
        {
            Form_TorneosNuevo form_NuevoTorneo = new Form_TorneosNuevo();
            this.Close();
            form_NuevoTorneo.Show();
        }

        private void btnAdminTorneo_Click(object sender, EventArgs e)
        {
            Form_AdminTorneos form_TorneosAdmin = new Form_AdminTorneos();
            this.Close();
            form_TorneosAdmin.Show();
        }
    }
}

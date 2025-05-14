using Consultorio_JVH.bbdd;
using Consultorio_JVH.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio_JVH.Vistas
{
    public partial class NuevaCita : Form
    {
        public NuevaCita()
        {
            InitializeComponent();
            campoDNI.Text = Principal.DNIPaciente;
            campoNomyAPE.Text = Principal.nombreApePacientes;
            comboHora.SelectedIndex = 0;
            fecha.MinDate = DateTime.Now.AddDays(1);
        }

        private void buttonregistrar_Click(object sender, EventArgs e)
        {
            registrarCita();
        }
    }
}

using Consultorio_JVH.bbdd;
using Consultorio_JVH.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio_JVH.Vistas
{
    public partial class InformeEnfermeria : Form
    {
        public InformeEnfermeria()
        {
            InitializeComponent();
            campoDNI.Text = Principal.DNIPaciente;
        }

        private void buttonregistrar_Click(object sender, EventArgs e)
        {
            registrar();
        }
       

        private void buttoncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

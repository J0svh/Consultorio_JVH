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
    public partial class InformeConsulta : Form
    {
        public InformeConsulta()
        {
            InitializeComponent();
            campoDNI.Text = Principal.DNIPaciente;
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (Utilidades.Utilidades.CampoVacio(campoDiagnostico))
            {
                Utilidades.Utilidades.MostrarAlerta(" Diagnóstico ");
            } else if(Utilidades.Utilidades.CampoVacio(campoTratamiento))
            {
                Utilidades.Utilidades.MostrarAlerta(" Tratamiento ");

            } else if (Utilidades.Utilidades.CampoVacio(campoObservaciones))
            {
                Utilidades.Utilidades.MostrarAlerta(" Observaciones ");

            } else
            {
                DateTime fechaActual = DateTime.Today;
                string dniPaciente = campoDNI.Text;
                int codigoFacultativo = Convert.ToInt32(Login.Datos[1]);


                Consulta c = new Consulta(
                    dniPaciente,
                    fechaActual,
                    campoDiagnostico.Text,
                    campoTratamiento.Text,
                    campoObservaciones.Text,
                    codigoFacultativo
                );

                if (Conexion.RegistrarConsulta(c))
                {
                   MessageBox.Show("Consulta registrada correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al registrar la consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

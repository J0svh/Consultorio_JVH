using Consultorio_JVH.bbdd;
using Consultorio_JVH.Utilidades;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        public static string[] DatosPaciente;
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            if (!Utilidades.Utilidades.FormatoDNICorrecto(campoDNI.Text))
            {
                Utilidades.Utilidades.MostrarAlerta("EL FORMATO DEL DNI NO ES VALIDO");

            }
            else if (Utilidades.Utilidades.DNIValido(campoDNI.Text))
            {
                Utilidades.Utilidades.MostrarAlerta("EL DNI NO ES VALIDO");

            } else
            {
                if (Conexion.CompruebaDni(Utilidades.Encriptado.Encriptar(campoDNI.Text)))
                {
                    DNIPaciente = campoDNI.Text;
                    nombreApePacientes = campoNombre.Text + " " + campoApe.Text;

                    DatosPaciente = Conexion.RescatarDatosPaciente(Encriptado.Encriptar(campoDNI.Text));

                    campoNombre.Text = Utilidades.Encriptado.Desencriptar(DatosPaciente[0]);
                    campoApe.Text = Utilidades.Encriptado.Desencriptar(DatosPaciente[1]);
                    campoTelf.Text = DatosPaciente[3];
                    campoMail.Text = DatosPaciente[2];

                    botonActualizar.Enabled = true;
                    botonCita.Enabled = true;
                    botonInforme.Enabled = true;
                    if (Login.Datos[2].Equals("MËDICO"))
                    {
                        dataGridView1.DataSource = Conexion.VerHistorial(Encriptado.Encriptar(campoDNI.Text));
                    }
                    else
                    {
                        dataGridView1.DataSource = Conexion.VerHistorialEnfermeria(Encriptado.Encriptar(campoDNI.Text));

                    }


                }
                MessageBox.Show("El Paciente cone se DNI, no existe. Porfavor Regístrelo primero");
                NuevoPaciente np = new NuevoPaciente();
                np.Show();
            }
        }

        

        private void Principal_Load(object sender, EventArgs e)
        {
            if (Login.Datos[2].Equals("MËDICO"))
            {
                label1.Text = " CONSULTA MËDICA";
                label7.Text = "HISTORIAL DE CONSULTAS MËDICAS";

            } else
            {
                label1.Text = " CONSULTA ENFERMERÍA";
                label7.Text = "HISTORIAL DE CONSULTAS DEO ENFERMERÍA";

            }
        }

        private void botonInforme_Click(object sender, EventArgs e)
        {
            if (Login.Datos[2].Equals("MËDICO"))
            {
                InformeConsulta ic = new InformeConsulta();
                ic.Show();
            }
            else
            {
                InformeEnfermeria ie = new InformeEnfermeria();
                ie.Show();
            }
        }

        private void botonCita_Click(object sender, EventArgs e)
        {
            if (Login.Datos[2].Equals("MËDICO"))
            {
                NuevaCita nc = new NuevaCita();
                nc.Show();
            }
            else
            {
                NuevaCitaEnfermeria ne = new NuevaCitaEnfermeria();
                ne.Show();
            }
        }

        private void botonActualizar_Click(object sender, EventArgs e)
        {
            if (Login.Datos[2].Equals("MËDICO"))
            {
                dataGridView1.DataSource= Conexion.VerHistorial(Encriptado.Encriptar
                    (campoDNI.Text));
            }
            else
            {
                dataGridView1.DataSource = Conexion.VerHistorialEnfermeria(Encriptado.Encriptar
                    (campoDNI.Text));
            }
        }
    }
}

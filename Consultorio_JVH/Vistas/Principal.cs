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
            if (Utilidades.Utilidades.CampoVacio(campoDNI))
            {
                Utilidades.Utilidades.MostrarAlerta("Campo DNI");
            }
            else if (!Utilidades.Utilidades.DNIValido(campoDNI.Text))
            {
                MessageBox.Show("EL FORMATO DEL DNI NO ES VALIDO");

            }
             else
            {
                if (Conexion.CompruebaDni(Utilidades.Encriptado.Encriptar(campoDNI.Text)))
                {
                    DNIPaciente = campoDNI.Text;
                    nombreApePacientes = campoNombre.Text + "" + campoApe.Text;

                    DatosPaciente = Conexion.RescatarDatosPaciente(Encriptado.Encriptar(campoDNI.Text));

                    campoNombre.Text = Utilidades.Encriptado.Desencriptar(DatosPaciente[0]);
                    campoApe.Text = Utilidades.Encriptado.Desencriptar(DatosPaciente[1]);
                    campoTelf.Text = DatosPaciente[2];
                    campoMail.Text = DatosPaciente[3];

                    botonActualizar.Enabled = true;
                    botonCita.Enabled = true;
                    botonInforme.Enabled = true;
                    if (Login.Datos[2].Equals("MEDICO"))
                    {
                        dataGridView1.DataSource = Conexion.VerHistorial(campoDNI.Text);
                    }
                    else
                    {
                        dataGridView1.DataSource = Conexion.VerHistorialEnfermeria(campoDNI.Text);

                    }
                }
                else { 
                    MessageBox.Show("El Paciente con ese DNI, no existe. Porfavor Regístrelo primero");
                    NuevoPaciente np = new NuevoPaciente();
                    np.Show();


                }
                
            }
        }

        

        private void Principal_Load(object sender, EventArgs e)
        {
            if (Login.Datos[2].Equals("MEDICO"))
            {
                label1.Text = " CONSULTA MÉDICO";
                label7.Text = "HISTORIAL DE CONSULTAS MÉDICA";

            } else
            {
                label1.Text = " CONSULTA ENFERMERÍA";
                label7.Text = "HISTORIAL DE CONSULTAS DE ENFERMERÍA";

            }
        }

        private void botonInforme_Click(object sender, EventArgs e)
        {
            if (Login.Datos[2].Equals("MEDICO"))
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
             if (Login.Datos[2].Equals("MEDICO"))
            {
                DNIPaciente = campoDNI.Text.Trim();
                nombreApePacientes = campoNombre.Text.Trim() + " " + campoApe.Text.Trim();
                NuevaCita nc = new NuevaCita();
                nc.Show();
            }
            else
            {
                DNIPaciente = campoDNI.Text.Trim();
                nombreApePacientes = campoNombre.Text.Trim() + " " + campoApe.Text.Trim();
                NuevaCitaEnfermeria ne = new NuevaCitaEnfermeria();
                ne.Show();
            }
        }

        private void botonActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Login.Datos[2].Equals("MEDICO"))
                {
                    dataGridView1.DataSource = Conexion.VerHistorial(campoDNI.Text);
                }
                else
                {
                    dataGridView1.DataSource = Conexion.VerHistorialEnfermeria(campoDNI.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());


        }
    }
}

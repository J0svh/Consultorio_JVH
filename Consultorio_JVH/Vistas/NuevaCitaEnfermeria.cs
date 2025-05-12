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
    public partial class NuevaCitaEnfermeria : Form
    {
        public NuevaCitaEnfermeria()
        {
            InitializeComponent();
            campoDNI.Text = Principal.DNIPaciente;
            campoNomyAPE.Text = Principal.nombreApePacientes;
            comboHora.SelectedIndex = 0;
            fecha.MinDate = DateTime.Now.AddDays(1);
        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            if (Utilidades.Utilidades.ComboNoSeleccionado(comboHora))
            {
                Utilidades.Utilidades.MostrarAlerta("No se ha seleccionado Nada");
            } else
            {
                Cita c = new Cita(campoDNI.Text, campoNomyAPE.Text,
                    fecha.Value, Convert.ToDouble(comboHora));
                if (Conexion.RegistarCita(c))
                {
                    string recibidor = Principal.DatosPaciente[3];
                    string enviador = "dam@reynaldomd.com";
                    string pass = "2024-dam";
                    string mensaje = " ";
                    string asunto = " Cita Médica";
                    Utilidades.Utilidades.MostrarAlerta("Registro realizado correctamente, se le enviara un correo electronico a su email con los datos de la cita\");" +
                        "");
                    Utilidades.Email.EnvioCorreo(pass,enviador,recibidor, mensaje
                        ,asunto,c);

                }
                else
                {
                    Utilidades.Utilidades.MostrarAlerta("Error al registrar la cita");
                }
            }
        }
    }
}

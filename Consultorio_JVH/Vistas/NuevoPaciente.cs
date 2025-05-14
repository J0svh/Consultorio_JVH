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
    public partial class NuevoPaciente : Form
    {
        public NuevoPaciente()
        {
            InitializeComponent();


            radioButtonotros.Checked = true;
            buttonSi.Checked = true;
            buttonHabitual.Checked = true;
            Conexion.CargarCombo(comboCP);
            campoDni.Text = Principal.DNIPaciente;
        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            if (Utilidades.Utilidades.CampoVacio(campoDni))
            {
                Utilidades.Utilidades.MostrarAlerta("DNI ");
            }
            else if (!Utilidades.Utilidades.DNIValido(campoDni.Text))
            {
                MessageBox.Show("El formato del dni no es correcto");
            }
            else if (Utilidades.Utilidades.CampoVacio(campoNombre))
            {
                Utilidades.Utilidades.MostrarAlerta("nombre ");
            }
            else if (Utilidades.Utilidades.CampoVacio(campoApe))
            {
                Utilidades.Utilidades.MostrarAlerta("apellidos ");
            }
            else if (Utilidades.Utilidades.CampoVacio(campoTelf))
            {
                Utilidades.Utilidades.MostrarAlerta("telefono  ");
            }
            else if (!Utilidades.Utilidades.FormatoTelefonoMovilValido(campoTelf.Text))
            {
                MessageBox.Show("El formato del telefono no es valido");
            }
            else if (Utilidades.Utilidades.CampoVacio(campoEmail))
            {
                Utilidades.Utilidades.MostrarAlerta("email");
            }
            else if (!Utilidades.Utilidades.compruebaCorreo(campoEmail.Text))
            {
                MessageBox.Show("El formato email no es valido");
            }
            if (!Utilidades.Utilidades.RadioButtonSeleccionado(groupBoxsexo))
            {
                MessageBox.Show("Debe seleccionar un Sexo");
                return;
            }

            if (!Utilidades.Utilidades.RadioButtonSeleccionado(groupBoxtabaquismo))
            {
                MessageBox.Show("Debe seleccionar un Estado");
                return;
            }

            if (!Utilidades.Utilidades.RadioButtonSeleccionado(groupBoxconsumo))
            {
                MessageBox.Show("Debe seleccionar un Turno");
                return;
            }
            else if (Utilidades.Utilidades.CampoVacio(campoAntecedentes))
            {
                Utilidades.Utilidades.MostrarAlerta("antecedentes");
            }
            else if (Utilidades.Utilidades.CampoVacio(campoPersonal))
            {
                Utilidades.Utilidades.MostrarAlerta("personal");
            }
            else
            {
                Modelo.Paciente paciente = new Modelo.Paciente(
                     campoDni.Text,
                     campoNombre.Text,
                     campoApe.Text,
                     fecha.Value,
                     Convert.ToInt32(campoTelf.Text),
                     campoEmail.Text,
                     Convert.ToInt32
                     (comboCP.SelectedValue),
                     rescatarSexo(),
                     rescatarTabaco(),
                     rescatarAlcohol(),
                     campoAntecedentes.Text,
                     campoPersonal.Text,
                     DateTime.Today
                 );

                if (Conexion.RegistrarPaciente(paciente))
                {
                   MessageBox.Show("Registro realizado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error en el registro");
                }
            }
        }
    }
}

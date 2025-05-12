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

            fecha.MinDate = DateTime.Now;
            Conexion.CargarCombo(comboCP);
            campoDni.Text = Principal.DNIPaciente;
        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            if (Utilidades.Utilidades.CampoVacio(campoDni))
            {
                Utilidades.Utilidades.MostrarAlerta("El campo dni esta vacio");
            }
            else if (Utilidades.Utilidades.FormatoDNICorrecto(campoDni.Text))
            {
                Utilidades.Utilidades.MostrarAlerta("El formato del dni no es correcto");
            }
            else if (Utilidades.Utilidades.DNIValido(campoDni.Text))
            {
                Utilidades.Utilidades.MostrarAlerta("El dni no es valido");
            }
            else if (Utilidades.Utilidades.CampoVacio(campoNombre))
            {
                Utilidades.Utilidades.MostrarAlerta("El campo nombre esta vacio");
            }
            else if (Utilidades.Utilidades.CampoVacio(campoApe))
            {
                Utilidades.Utilidades.MostrarAlerta("El campo apellidos esta vacio");
            }
            else if (Utilidades.Utilidades.CampoVacio(campoTelf))
            {
                Utilidades.Utilidades.MostrarAlerta("El campo telefono esta vacio");
            }
            else if (Utilidades.Utilidades.EsEnteroValido(campoTelf))
            {
                Utilidades.Utilidades.MostrarAlerta("El campo telefono es numerico");
            }
            else if (!Utilidades.Utilidades.FormatoTelefonoFijoValido(campoTelf.Text) || !Utilidades.Utilidades.FormatoTelefonoMovilValido(campoTelf.Text))
            {
                Utilidades.Utilidades.MostrarAlerta("El formato del telefono no es valido");
            }
            else if (Utilidades.Utilidades.CampoVacio(campoEmail))
            {
                Utilidades.Utilidades.MostrarAlerta("El campo email esta vacio");
            }
            else if (Utilidades.Utilidades.compruebaCorreo(campoEmail.Text))
            {
                Utilidades.Utilidades.MostrarAlerta("El formato email no es valido");
            }
            else if (Utilidades.Utilidades.ComboNoSeleccionado(comboCP))
            {
                Utilidades.Utilidades.MostrarAlerta("El campo cp no ha sido seleccionado");
            }
            else if (Utilidades.Utilidades.CampoVacio(campoAntecedentes))
            {
                Utilidades.Utilidades.MostrarAlerta("El campo antecedentes esta vacio");
            }
            else if (Utilidades.Utilidades.CampoVacio(campoPersonal))
            {
                Utilidades.Utilidades.MostrarAlerta("El campo personal esta vacio");
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
                    Utilidades.Utilidades.MostrarAlerta("Registro realizado correctamente");
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

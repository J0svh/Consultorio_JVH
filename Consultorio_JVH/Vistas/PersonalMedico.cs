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
    public partial class PersonalMedico : Form
    {
        public PersonalMedico()
        {
            InitializeComponent();
            comboTipo.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Utilidades.Utilidades.CampoVacio(campoNumColegiado))
            {
                Utilidades.Utilidades.MostrarAlerta("Campo Número de Colegiado vacío");
                campoNumColegiado.Focus();
            }
            else if (Utilidades.Utilidades.EsEnteroValido(campoNumColegiado))
            {
                Utilidades.Utilidades.MostrarAlerta("EL Campo numero de colegiado es Numérico");
            }
            else if (Utilidades.Utilidades.CampoVacio(campoNombre))
            {
                Utilidades.Utilidades.MostrarAlerta("Campo Nombre vacío");
                campoNombre.Focus();
            }
            else if (Utilidades.Utilidades.CampoVacio(campoApe))
            {
                Utilidades.Utilidades.MostrarAlerta("Campo Apellido vacío");
                campoApe.Focus();
            }
            else if (Utilidades.Utilidades.CampoVacio(campoTelf))
            {
                Utilidades.Utilidades.MostrarAlerta("Campo Teléfono vacío");
                campoTelf.Focus();
            }
            else if (Utilidades.Utilidades.EsEnteroValido(campoTelf))
            {
                Utilidades.Utilidades.MostrarAlerta("El campo telefono es numerico");

            }
            else if (Utilidades.Utilidades.FormatoTelefonoFijoValido(campoTelf.Text) || Utilidades.Utilidades.FormatoTelefonoMovilValido(campoTelf.Text))
            {
                Utilidades.Utilidades.MostrarAlerta("El formato del teléfono no es válido");
                campoTelf.Focus();
            }
            else if (Utilidades.Utilidades.CampoVacio(campoUsu))
            {
                Utilidades.Utilidades.MostrarAlerta("Campo Usuario vacío");
                campoUsu.Focus();
            }
            else if (Utilidades.Utilidades.CampoVacio(campoPass))
            {
                Utilidades.Utilidades.MostrarAlerta("Campo Contraseña vacío");
                campoPass.Focus();
            }


            else if (Utilidades.Utilidades.ComboNoSeleccionado(comboTipo))
            {
                Utilidades.Utilidades.MostrarAlertaCombo("El combo tipo está vacio");
                comboTipo.Focus();
            }

            else
            {
                string combo = comboTipo.Text;
                Personal personal = new Personal(Convert.ToInt32(campoNumColegiado.Text),
                    campoNombre.Text, campoApe.Text, Convert.ToInt32(campoTelf.Text),
                    campoUsu.Text, campoPass.Text, comboTipo.SelectedValue.ToString());
                if (Conexion.RegistrarPersonal(personal))
                {
                    Utilidades.Utilidades.MostrarAlerta("REGISTRO REALIZADO");
                    campoNumColegiado.Text = "";
                    campoNombre.Text = "";
                    campoApe.Text = "";
                    campoTelf.Text = "";
                    campoUsu.Text = "";
                    campoPass.Text = "";
                    comboTipo.SelectedIndex = 0;
                }
                else
                {
                    Utilidades.Utilidades.MostrarAlerta("ERROR AL REGISTRAR");
                }
            }
        }
    }
}

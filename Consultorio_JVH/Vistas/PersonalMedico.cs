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
                Utilidades.Utilidades.MostrarAlerta("Número de colegiado");
                campoNumColegiado.Focus();
            }
            else if (!Utilidades.Utilidades.EnteroCorrecto(campoNumColegiado))
            {
               MessageBox.Show("EL Campo numero de colegiado Tiene que ser Numérico y de 9 Dígitos");
            }
            else if (Utilidades.Utilidades.CampoVacio(campoNombre))
            {
                Utilidades.Utilidades.MostrarAlerta("Nombre");
                campoNombre.Focus();
            }
            else if (Utilidades.Utilidades.CampoVacio(campoApe))
            {
                Utilidades.Utilidades.MostrarAlerta("Apellidos");
                campoApe.Focus();
            }
            else if (Utilidades.Utilidades.CampoVacio(campoTelf))
            {
                Utilidades.Utilidades.MostrarAlerta("Telefono");
                campoTelf.Focus();
            }
            else if (!Utilidades.Utilidades.FormatoTelefonoMovilValido(campoTelf.Text))
            {
               MessageBox.Show("El Formato del telefono , no es correcto.");

            }
            else if (Utilidades.Utilidades.CampoVacio(campoUsu))
            {
                Utilidades.Utilidades.MostrarAlerta("Usuario");
                campoUsu.Focus();
            }
            else if (Utilidades.Utilidades.CampoVacio(campoPass))
            {
                Utilidades.Utilidades.MostrarAlerta("Contaseña");
                campoPass.Focus();
            }


            else if (Utilidades.Utilidades.ComboNoSeleccionado(comboTipo))
            {
                Utilidades.Utilidades.MostrarAlertaCombo("El combo Tipo");
                comboTipo.Focus();
            }

            else
            {
                string combo = comboTipo.Text;
                Personal personal = new Personal(Convert.ToInt32(campoNumColegiado.Text),
                    campoNombre.Text, campoApe.Text, Convert.ToInt32(campoTelf.Text),
                    campoUsu.Text, campoPass.Text, comboTipo.ToString());
                if (Conexion.RegistrarPersonal(personal))
                {
                    MessageBox.Show("REGISTRO REALIZADO");
                    campoNumColegiado.Text = " ";
                    campoNombre.Text = "";
                    campoApe.Text = " ";
                    campoTelf.Text = " ";
                    campoUsu.Text = " ";
                    campoPass.Text = " ";
                    comboTipo.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("ERROR AL REGISTRAR");
                }
            }
        }
    }
}

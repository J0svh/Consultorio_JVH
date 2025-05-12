using Consultorio_JVH.bbdd;
using Consultorio_JVH.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio_JVH
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string[] Datos = new string[3];
        private void botonEntrar_Click(object sender, EventArgs e)

        {
            if (Utilidades.Utilidades.CampoVacio(campoUser))
            {
                Utilidades.Utilidades.MostrarAlerta("Campo Usuario Vacío");
                campoUser.Focus();
            }
            else if (Utilidades.Utilidades.CampoVacio(campoPass))
            {
                Utilidades.Utilidades.MostrarAlerta("El Campo Contraseña está vacío");
                campoPass.Focus();
            }
            else
            {
                if (Conexion.Acceder(campoUser.Text, Utilidades.Encriptado.Encriptar(campoPass.Text)))
                {
                    Datos = Conexion.RescataDatosUserLogado(campoUser.Text);
                    MenuPrincipal menu = new MenuPrincipal();
                    menu.Show();
                    this.Hide();


                } else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    campoUser.Clear();
                    campoPass.Clear();
                    campoUser.Focus();
                }
            }

        }
    }
}

using Consultorio_JVH.bbdd;
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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
             Application.Exit();
        }

        private void botonConsultas_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();

            principal.Show();
        }

        private void botonPacientes_Click(object sender, EventArgs e)
        {
            Paciente p = new Paciente();
            p.Show();
        }

        private void botonEnfermeria_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            p.Show();
        }

        private void botonPersonalMedico_Click(object sender, EventArgs e)
        {
            PersonalMedico pm = new PersonalMedico();
            pm.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            if (Login.Datos[2].Equals("ADMIN"))
            {
                labelfecha.Text = DateTime.Now.Day.ToString() + "-" + Mostrar(DateTime.Now.Month) + "-" + DateTime.Now.Year.ToString();
                labelfacultativo.Text = null;
                labelncolegiado.Text = "ADMINISTRADO: " + Login.Datos[1];
                botonPersonalMedico.Enabled = true;
                botonPersonalMedico.ForeColor = Color.White;

            }
            else if (Login.Datos[2].Equals("MEDICO"))
            {
                labelfecha.Text = DateTime.Now.Day.ToString() + "-" + Mostrar(DateTime.Now.Month) + "-" + DateTime.Now.Year.ToString();
                labelfacultativo.Text = "FACULTATIVO: " + Login.Datos[0];
                labelncolegiado.Text = "Nº COLEGIADO: " + Login.Datos[1];
                botonConsultas.Enabled = true;
                botonPacientes.Enabled = true;
                tablaAgenda.DataSource = Conexion.CargarCitas();

            }
            else 
            {
                labelfecha.Text = DateTime.Now.Day.ToString() + "-" + Mostrar(DateTime.Now.Month) + "-" + DateTime.Now.Year.ToString();
                labelfacultativo.Text = "FACULTATIVO: " + Login.Datos[0];
                labelncolegiado.Text = "Nº COLEGIADO: " + Login.Datos[1];
                label1.Text = " AGENDA ENFERMERÍA";
                botonEnfermeria.Enabled = true;
                botonEnfermeria.ForeColor = Color.White;
                tablaAgenda.DataSource = Conexion.CargarCitas();
            }
        }
    }
}

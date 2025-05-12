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
    public partial class Paciente : Form
    {
        public Paciente()
        {
            InitializeComponent();
            dataGridView1.DataSource = Conexion.ListadoPacientes();
            Conexion.CargarCombo(comboCp);
        }

        public Paciente(string text1, string text2, string text3, DateTime value, int v1, string text4, int v2, string v3, string v4, string v5, string text5, string text6, DateTime today)
        {
        }

        private void botonActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filas = dataGridView1.Rows[e.RowIndex];
            string[] valor = new string[5];
            for (int i = 0; i < filas.Cells.Count; i++)
            {
                valor[i] = filas.Cells[i].Value.ToString();
            }

            campoDNI.Text = valor[0];
            campoNombre.Text = valor[1];
            campoApe.Text = valor[2];
            campoTelf.Text = valor[3];

            campoNombre.Enabled = true;
            campoApe.Enabled = true;
            campoTelf.Enabled = true;
            comboCp.Enabled = true;
        }
    }
}

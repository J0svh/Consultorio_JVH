using Consultorio_JVH.bbdd;
using Consultorio_JVH.Modelo;
using Consultorio_JVH.Utilidades;
using System.Windows.Forms;
using System;

namespace Consultorio_JVH.Vistas
{
    partial class NuevaCitaEnfermeria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboCita = new System.Windows.Forms.ComboBox();
            this.comboHora = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.campoNomyAPE = new System.Windows.Forms.TextBox();
            this.campoDNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.botonRegistrar);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 326);
            this.panel1.TabIndex = 12;
            // 
            // comboCita
            // 
            this.comboCita.FormattingEnabled = true;
            this.comboCita.Items.AddRange(new object[] {
            "Seleccione",
            "Una Semana",
            "Quince dias",
            "Un mes"});
            this.comboCita.Location = new System.Drawing.Point(228, 126);
            this.comboCita.Name = "comboCita";
            this.comboCita.Size = new System.Drawing.Size(121, 24);
            this.comboCita.TabIndex = 10;
            // 
            // comboHora
            // 
            this.comboHora.FormattingEnabled = true;
            this.comboHora.Items.AddRange(new object[] {
            "Seleccione",
            "8",
            "8:30",
            "9",
            "9:30",
            "10",
            "10:30",
            "11",
            "11:30",
            "12",
            "12:30"});
            this.comboHora.Location = new System.Drawing.Point(259, 167);
            this.comboHora.Margin = new System.Windows.Forms.Padding(2);
            this.comboHora.Name = "comboHora";
            this.comboHora.Size = new System.Drawing.Size(132, 24);
            this.comboHora.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(56, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(39, 129);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cita";
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.botonRegistrar.Location = new System.Drawing.Point(197, 262);
            this.botonRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(197, 32);
            this.botonRegistrar.TabIndex = 5;
            this.botonRegistrar.Text = "Registrar";
            this.botonRegistrar.UseVisualStyleBackColor = false;
            this.botonRegistrar.Click += new System.EventHandler(this.botonRegistrar_Click);
            // 
            // campoNomyAPE
            // 
            this.campoNomyAPE.Location = new System.Drawing.Point(198, 84);
            this.campoNomyAPE.Margin = new System.Windows.Forms.Padding(2);
            this.campoNomyAPE.Name = "campoNomyAPE";
            this.campoNomyAPE.ReadOnly = true;
            this.campoNomyAPE.Size = new System.Drawing.Size(193, 22);
            this.campoNomyAPE.TabIndex = 2;
            // 
            // campoDNI
            // 
            this.campoDNI.Location = new System.Drawing.Point(167, 43);
            this.campoDNI.Margin = new System.Windows.Forms.Padding(2);
            this.campoDNI.Name = "campoDNI";
            this.campoDNI.ReadOnly = true;
            this.campoDNI.Size = new System.Drawing.Size(138, 22);
            this.campoDNI.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(22, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre y Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(22, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "DNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "NUEVA CITA ENFERMERÏA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Consultorio_JVH.Properties.Resources.logo_good;
            this.pictureBox1.Location = new System.Drawing.Point(477, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 78);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboHora);
            this.groupBox1.Controls.Add(this.comboCita);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.campoDNI);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.campoNomyAPE);
            this.groupBox1.Location = new System.Drawing.Point(45, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 199);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupCita";
            // 
            // NuevaCitaEnfermeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "NuevaCitaEnfermeria";
            this.Text = "NuevaCitaEnfermeria";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonRegistrar;
        private System.Windows.Forms.TextBox campoNomyAPE;
        private System.Windows.Forms.TextBox campoDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboCita;
        private System.Windows.Forms.ComboBox comboHora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

        public void registrarCita()
        {
            if (comboHora.SelectedItem == null || comboHora.SelectedItem.ToString() == "Seleccione")
            {
                MessageBox.Show("Por favor seleccione una hora válida");
                return;
            }

            if (!ValidarFormulario(groupBox1))
            {
                return;
            }

            int diasASumar = 0;
            switch (comboCita.SelectedIndex)
            {
                case 1: diasASumar = 7; break;
                case 2: diasASumar = 14; break;
                case 3: diasASumar = 30; break;
            }

            DateTime fechaCita = DateTime.Now.AddDays(diasASumar);
            string horaSeleccionada = comboHora.SelectedItem.ToString();
            string nombreCompleto = $"{Principal.DatosPaciente[0]} {Principal.DatosPaciente[1]}";

            try
            {
                TimeSpan hora = TimeSpan.Parse(horaSeleccionada.Replace(":", "."));
                DateTime fechaHoraCompleta = fechaCita.Date + hora;

                Cita nuevaCita = new Cita(Principal.DNIPaciente, nombreCompleto, fechaHoraCompleta, hora.TotalHours);

                if (Conexion.registrarCitaEnfermeria(nuevaCita))
                {
                    Email.enviarCorreo(nuevaCita);
                    MessageBox.Show("Cita registrada correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al registrar la cita");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato de hora inválido");
            }
        }
        private bool ValidarFormulario(GroupBox groupBox)
        {


            if (comboHora.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione una hora.");
                comboHora.Focus();
                return false;
            }

            if (comboCita.SelectedIndex == 0 )
            {
                MessageBox.Show("Seleccione una Cita en el combo.");
                comboCita.Focus();
                return false;
            }

            return true;
        }

        private GroupBox groupBox1;
    }
}
using Consultorio_JVH.bbdd;
using Consultorio_JVH.Modelo;
using Consultorio_JVH.Utilidades;
using System.Windows.Forms;
using System;

namespace Consultorio_JVH.Vistas
{
    partial class NuevaCita
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
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.comboHora = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonregistrar = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.buttonregistrar);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 110);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 302);
            this.panel1.TabIndex = 3;
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(234, 173);
            this.fecha.Margin = new System.Windows.Forms.Padding(2);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(199, 22);
            this.fecha.TabIndex = 8;
            // 
            // comboHora
            // 
            this.comboHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.comboHora.Location = new System.Drawing.Point(234, 221);
            this.comboHora.Margin = new System.Windows.Forms.Padding(2);
            this.comboHora.Name = "comboHora";
            this.comboHora.Size = new System.Drawing.Size(132, 24);
            this.comboHora.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(17, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(17, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fecha";
            // 
            // buttonregistrar
            // 
            this.buttonregistrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonregistrar.Location = new System.Drawing.Point(197, 262);
            this.buttonregistrar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonregistrar.Name = "buttonregistrar";
            this.buttonregistrar.Size = new System.Drawing.Size(197, 32);
            this.buttonregistrar.TabIndex = 5;
            this.buttonregistrar.Text = "Registrar";
            this.buttonregistrar.UseVisualStyleBackColor = false;
            this.buttonregistrar.Click += new System.EventHandler(this.buttonregistrar_Click);
            // 
            // campoNomyAPE
            // 
            this.campoNomyAPE.Location = new System.Drawing.Point(234, 99);
            this.campoNomyAPE.Margin = new System.Windows.Forms.Padding(2);
            this.campoNomyAPE.Name = "campoNomyAPE";
            this.campoNomyAPE.ReadOnly = true;
            this.campoNomyAPE.Size = new System.Drawing.Size(193, 22);
            this.campoNomyAPE.TabIndex = 2;
            // 
            // campoDNI
            // 
            this.campoDNI.Location = new System.Drawing.Point(234, 40);
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
            this.label3.Location = new System.Drawing.Point(17, 99);
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
            this.label2.Location = new System.Drawing.Point(17, 43);
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
            this.label1.Location = new System.Drawing.Point(34, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "NUEVA CITA MÉDICA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Consultorio_JVH.Properties.Resources.logo_good;
            this.pictureBox1.Location = new System.Drawing.Point(478, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 78);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboHora);
            this.groupBox1.Controls.Add(this.fecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.campoNomyAPE);
            this.groupBox1.Controls.Add(this.campoDNI);
            this.groupBox1.Location = new System.Drawing.Point(37, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 257);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // NuevaCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "NuevaCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevaCita";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonregistrar;
        private System.Windows.Forms.TextBox campoNomyAPE;
        private System.Windows.Forms.TextBox campoDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.ComboBox comboHora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;

        public void registrarCita()
        {
            if (!ValidarFormulario(groupBox1))
                return;

            DateTime fechaSeleccionada = fecha.Value.Date;
            string horaSeleccionada = comboHora.SelectedItem.ToString();
            if (!horaSeleccionada.Contains(":")) horaSeleccionada += ":00";

            if (!TimeSpan.TryParse(horaSeleccionada, out TimeSpan hora))
            {
                MessageBox.Show("Formato de hora no válido.");
                comboHora.Focus();
                return;
            }

            DateTime fechaHoraFinal = fechaSeleccionada.Add(hora);
            string nombreCompleto = Principal.DatosPaciente[0] + " " + Principal.DatosPaciente[1];

            Cita c = new Cita(campoDNI.Text, campoNomyAPE.Text, fechaHoraFinal, hora.TotalHours);



            if (Conexion.registrarCita(c))
            {
                Email.enviarCorreo(c);
                MessageBox.Show("Registro realizado correctamente");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Registro no realizado correctamente");
            }
        }

        private bool ValidarFormulario(GroupBox grupo)
        {
            foreach (Control c in grupo.Controls)
            {
                if (c is TextBox text && string.IsNullOrWhiteSpace(text.Text))
                {
                    MessageBox.Show($"Complete el campo: {text.Name}");
                    c.Focus();
                    return false;
                }
                if (c is ComboBox combo && combo.SelectedIndex == 0)
                {
                    MessageBox.Show($"Seleccione una opción en: {combo.Name}");
                    combo.Focus();
                    return false;
                }
            }
            return true;
        }

    }
}
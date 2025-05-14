namespace Consultorio_JVH.Vistas
{
    partial class MenuPrincipal
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
            this.tablaAgenda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botonConsultas = new System.Windows.Forms.Button();
            this.botonPersonalMedico = new System.Windows.Forms.Button();
            this.botonPacientes = new System.Windows.Forms.Button();
            this.botonEnfermeria = new System.Windows.Forms.Button();
            this.labelncolegiado = new System.Windows.Forms.Label();
            this.labelfacultativo = new System.Windows.Forms.Label();
            this.labelfecha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.tablaAgenda);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-3, 126);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 589);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tablaAgenda
            // 
            this.tablaAgenda.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablaAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAgenda.Location = new System.Drawing.Point(44, 188);
            this.tablaAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.tablaAgenda.Name = "tablaAgenda";
            this.tablaAgenda.ReadOnly = true;
            this.tablaAgenda.RowHeadersWidth = 51;
            this.tablaAgenda.RowTemplate.Height = 24;
            this.tablaAgenda.Size = new System.Drawing.Size(667, 338);
            this.tablaAgenda.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(41, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "AGENDA";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Consultorio_JVH.Properties.Resources.principal;
            this.pictureBox4.Location = new System.Drawing.Point(800, 188);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(409, 338);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.botonConsultas);
            this.panel2.Controls.Add(this.botonPersonalMedico);
            this.panel2.Controls.Add(this.botonPacientes);
            this.panel2.Controls.Add(this.botonEnfermeria);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1266, 114);
            this.panel2.TabIndex = 4;
            // 
            // botonConsultas
            // 
            this.botonConsultas.BackColor = System.Drawing.Color.SteelBlue;
            this.botonConsultas.Enabled = false;
            this.botonConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConsultas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonConsultas.Location = new System.Drawing.Point(46, 15);
            this.botonConsultas.Margin = new System.Windows.Forms.Padding(2);
            this.botonConsultas.Name = "botonConsultas";
            this.botonConsultas.Size = new System.Drawing.Size(193, 76);
            this.botonConsultas.TabIndex = 0;
            this.botonConsultas.Text = "CONSULTAS";
            this.botonConsultas.UseVisualStyleBackColor = false;
            this.botonConsultas.Click += new System.EventHandler(this.botonConsultas_Click);
            // 
            // botonPersonalMedico
            // 
            this.botonPersonalMedico.BackColor = System.Drawing.Color.SteelBlue;
            this.botonPersonalMedico.Enabled = false;
            this.botonPersonalMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPersonalMedico.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonPersonalMedico.Location = new System.Drawing.Point(1023, 15);
            this.botonPersonalMedico.Margin = new System.Windows.Forms.Padding(2);
            this.botonPersonalMedico.Name = "botonPersonalMedico";
            this.botonPersonalMedico.Size = new System.Drawing.Size(184, 76);
            this.botonPersonalMedico.TabIndex = 3;
            this.botonPersonalMedico.Text = "PERSONAL MEDICO";
            this.botonPersonalMedico.UseVisualStyleBackColor = false;
            this.botonPersonalMedico.Click += new System.EventHandler(this.botonPersonalMedico_Click);
            // 
            // botonPacientes
            // 
            this.botonPacientes.BackColor = System.Drawing.Color.SteelBlue;
            this.botonPacientes.Enabled = false;
            this.botonPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPacientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonPacientes.Location = new System.Drawing.Point(375, 15);
            this.botonPacientes.Margin = new System.Windows.Forms.Padding(2);
            this.botonPacientes.Name = "botonPacientes";
            this.botonPacientes.Size = new System.Drawing.Size(200, 76);
            this.botonPacientes.TabIndex = 1;
            this.botonPacientes.Text = "PACIENTES";
            this.botonPacientes.UseVisualStyleBackColor = false;
            this.botonPacientes.Click += new System.EventHandler(this.botonPacientes_Click);
            // 
            // botonEnfermeria
            // 
            this.botonEnfermeria.BackColor = System.Drawing.Color.SteelBlue;
            this.botonEnfermeria.Enabled = false;
            this.botonEnfermeria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEnfermeria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonEnfermeria.Location = new System.Drawing.Point(709, 15);
            this.botonEnfermeria.Margin = new System.Windows.Forms.Padding(2);
            this.botonEnfermeria.Name = "botonEnfermeria";
            this.botonEnfermeria.Size = new System.Drawing.Size(190, 76);
            this.botonEnfermeria.TabIndex = 2;
            this.botonEnfermeria.Text = "ENFERMERIA";
            this.botonEnfermeria.UseVisualStyleBackColor = false;
            this.botonEnfermeria.Click += new System.EventHandler(this.botonEnfermeria_Click);
            // 
            // labelncolegiado
            // 
            this.labelncolegiado.AutoSize = true;
            this.labelncolegiado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelncolegiado.ForeColor = System.Drawing.Color.Black;
            this.labelncolegiado.Location = new System.Drawing.Point(42, 98);
            this.labelncolegiado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelncolegiado.Name = "labelncolegiado";
            this.labelncolegiado.Size = new System.Drawing.Size(124, 16);
            this.labelncolegiado.TabIndex = 11;
            this.labelncolegiado.Text = "Nº  de colegiado";
            // 
            // labelfacultativo
            // 
            this.labelfacultativo.AutoSize = true;
            this.labelfacultativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfacultativo.ForeColor = System.Drawing.Color.Black;
            this.labelfacultativo.Location = new System.Drawing.Point(42, 64);
            this.labelfacultativo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelfacultativo.Name = "labelfacultativo";
            this.labelfacultativo.Size = new System.Drawing.Size(87, 16);
            this.labelfacultativo.TabIndex = 10;
            this.labelfacultativo.Text = "Facultativo:";
            // 
            // labelfecha
            // 
            this.labelfecha.AutoSize = true;
            this.labelfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfecha.ForeColor = System.Drawing.Color.Black;
            this.labelfecha.Location = new System.Drawing.Point(42, 26);
            this.labelfecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelfecha.Name = "labelfecha";
            this.labelfecha.Size = new System.Drawing.Size(40, 16);
            this.labelfecha.TabIndex = 9;
            this.labelfecha.Text = "fecha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Consultorio_JVH.Properties.Resources.logo_good;
            this.pictureBox1.Location = new System.Drawing.Point(1117, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 75);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 711);
            this.Controls.Add(this.labelncolegiado);
            this.Controls.Add(this.labelfacultativo);
            this.Controls.Add(this.labelfecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1275, 750);
            this.MinimumSize = new System.Drawing.Size(1275, 750);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tablaAgenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button botonConsultas;
        private System.Windows.Forms.Button botonPersonalMedico;
        private System.Windows.Forms.Button botonPacientes;
        private System.Windows.Forms.Button botonEnfermeria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelncolegiado;
        private System.Windows.Forms.Label labelfacultativo;
        private System.Windows.Forms.Label labelfecha;

        private string Mostrar(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";
                default:
                    return "Mes inválido";
            }
        }


    }
}





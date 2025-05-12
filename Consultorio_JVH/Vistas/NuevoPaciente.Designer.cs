namespace Consultorio_JVH.Vistas
{
    partial class NuevoPaciente
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
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.groupBoxsalud = new System.Windows.Forms.GroupBox();
            this.campoPersonal = new System.Windows.Forms.TextBox();
            this.campoAntecedentes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxdatospersonales = new System.Windows.Forms.GroupBox();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.campoDni = new System.Windows.Forms.TextBox();
            this.groupBoxconsumo = new System.Windows.Forms.GroupBox();
            this.buttonNulo = new System.Windows.Forms.RadioButton();
            this.buttonOcasional = new System.Windows.Forms.RadioButton();
            this.buttonHabitual = new System.Windows.Forms.RadioButton();
            this.groupBoxtabaquismo = new System.Windows.Forms.GroupBox();
            this.buttonNo = new System.Windows.Forms.RadioButton();
            this.buttonSi = new System.Windows.Forms.RadioButton();
            this.groupBoxsexo = new System.Windows.Forms.GroupBox();
            this.radioButtonotros = new System.Windows.Forms.RadioButton();
            this.radioButtonH = new System.Windows.Forms.RadioButton();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.campoTelf = new System.Windows.Forms.TextBox();
            this.campoApe = new System.Windows.Forms.TextBox();
            this.campoNombre = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.comboCP = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBoxsalud.SuspendLayout();
            this.groupBoxdatospersonales.SuspendLayout();
            this.groupBoxconsumo.SuspendLayout();
            this.groupBoxtabaquismo.SuspendLayout();
            this.groupBoxsexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.botonRegistrar);
            this.panel1.Controls.Add(this.groupBoxsalud);
            this.panel1.Controls.Add(this.groupBoxdatospersonales);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-2, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 534);
            this.panel1.TabIndex = 6;
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.BackColor = System.Drawing.Color.Snow;
            this.botonRegistrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegistrar.ForeColor = System.Drawing.Color.Red;
            this.botonRegistrar.Location = new System.Drawing.Point(373, 479);
            this.botonRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(189, 30);
            this.botonRegistrar.TabIndex = 15;
            this.botonRegistrar.Text = "Registrar";
            this.botonRegistrar.UseVisualStyleBackColor = false;
            this.botonRegistrar.Click += new System.EventHandler(this.botonRegistrar_Click);
            // 
            // groupBoxsalud
            // 
            this.groupBoxsalud.Controls.Add(this.campoPersonal);
            this.groupBoxsalud.Controls.Add(this.campoAntecedentes);
            this.groupBoxsalud.Controls.Add(this.label9);
            this.groupBoxsalud.Controls.Add(this.label8);
            this.groupBoxsalud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxsalud.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxsalud.Location = new System.Drawing.Point(515, 39);
            this.groupBoxsalud.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxsalud.Name = "groupBoxsalud";
            this.groupBoxsalud.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxsalud.Size = new System.Drawing.Size(414, 401);
            this.groupBoxsalud.TabIndex = 1;
            this.groupBoxsalud.TabStop = false;
            this.groupBoxsalud.Text = "Salud";
            // 
            // campoPersonal
            // 
            this.campoPersonal.Location = new System.Drawing.Point(19, 247);
            this.campoPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.campoPersonal.Multiline = true;
            this.campoPersonal.Name = "campoPersonal";
            this.campoPersonal.Size = new System.Drawing.Size(371, 143);
            this.campoPersonal.TabIndex = 11;
            // 
            // campoAntecedentes
            // 
            this.campoAntecedentes.Location = new System.Drawing.Point(19, 50);
            this.campoAntecedentes.Margin = new System.Windows.Forms.Padding(2);
            this.campoAntecedentes.Multiline = true;
            this.campoAntecedentes.Name = "campoAntecedentes";
            this.campoAntecedentes.Size = new System.Drawing.Size(371, 165);
            this.campoAntecedentes.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 219);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(265, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Personal(alergias, cirugías, enfermedades, etc)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Antecedentes familiares destacables";
            // 
            // groupBoxdatospersonales
            // 
            this.groupBoxdatospersonales.Controls.Add(this.campoEmail);
            this.groupBoxdatospersonales.Controls.Add(this.label10);
            this.groupBoxdatospersonales.Controls.Add(this.campoDni);
            this.groupBoxdatospersonales.Controls.Add(this.groupBoxconsumo);
            this.groupBoxdatospersonales.Controls.Add(this.groupBoxtabaquismo);
            this.groupBoxdatospersonales.Controls.Add(this.groupBoxsexo);
            this.groupBoxdatospersonales.Controls.Add(this.campoTelf);
            this.groupBoxdatospersonales.Controls.Add(this.campoApe);
            this.groupBoxdatospersonales.Controls.Add(this.campoNombre);
            this.groupBoxdatospersonales.Controls.Add(this.fecha);
            this.groupBoxdatospersonales.Controls.Add(this.comboCP);
            this.groupBoxdatospersonales.Controls.Add(this.label7);
            this.groupBoxdatospersonales.Controls.Add(this.label6);
            this.groupBoxdatospersonales.Controls.Add(this.label5);
            this.groupBoxdatospersonales.Controls.Add(this.label4);
            this.groupBoxdatospersonales.Controls.Add(this.label3);
            this.groupBoxdatospersonales.Controls.Add(this.label2);
            this.groupBoxdatospersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxdatospersonales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxdatospersonales.Location = new System.Drawing.Point(45, 20);
            this.groupBoxdatospersonales.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxdatospersonales.Name = "groupBoxdatospersonales";
            this.groupBoxdatospersonales.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxdatospersonales.Size = new System.Drawing.Size(413, 420);
            this.groupBoxdatospersonales.TabIndex = 0;
            this.groupBoxdatospersonales.TabStop = false;
            this.groupBoxdatospersonales.Text = "Datos Personales";
            // 
            // campoEmail
            // 
            this.campoEmail.Location = new System.Drawing.Point(190, 214);
            this.campoEmail.Margin = new System.Windows.Forms.Padding(2);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(149, 21);
            this.campoEmail.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 219);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "Email";
            // 
            // campoDni
            // 
            this.campoDni.Location = new System.Drawing.Point(190, 25);
            this.campoDni.Margin = new System.Windows.Forms.Padding(2);
            this.campoDni.Name = "campoDni";
            this.campoDni.Size = new System.Drawing.Size(107, 21);
            this.campoDni.TabIndex = 1;
            // 
            // groupBoxconsumo
            // 
            this.groupBoxconsumo.Controls.Add(this.buttonNulo);
            this.groupBoxconsumo.Controls.Add(this.buttonOcasional);
            this.groupBoxconsumo.Controls.Add(this.buttonHabitual);
            this.groupBoxconsumo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxconsumo.Location = new System.Drawing.Point(35, 349);
            this.groupBoxconsumo.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxconsumo.Name = "groupBoxconsumo";
            this.groupBoxconsumo.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxconsumo.Size = new System.Drawing.Size(342, 46);
            this.groupBoxconsumo.TabIndex = 13;
            this.groupBoxconsumo.TabStop = false;
            this.groupBoxconsumo.Text = "CONSUMO DE ALCOHOL";
            // 
            // buttonNulo
            // 
            this.buttonNulo.AutoSize = true;
            this.buttonNulo.Location = new System.Drawing.Point(240, 19);
            this.buttonNulo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNulo.Name = "buttonNulo";
            this.buttonNulo.Size = new System.Drawing.Size(59, 19);
            this.buttonNulo.TabIndex = 14;
            this.buttonNulo.TabStop = true;
            this.buttonNulo.Text = "NULO";
            this.buttonNulo.UseVisualStyleBackColor = true;
            // 
            // buttonOcasional
            // 
            this.buttonOcasional.AutoSize = true;
            this.buttonOcasional.Location = new System.Drawing.Point(139, 19);
            this.buttonOcasional.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOcasional.Name = "buttonOcasional";
            this.buttonOcasional.Size = new System.Drawing.Size(92, 19);
            this.buttonOcasional.TabIndex = 13;
            this.buttonOcasional.TabStop = true;
            this.buttonOcasional.Text = "OCASIONAL";
            this.buttonOcasional.UseVisualStyleBackColor = true;
            // 
            // buttonHabitual
            // 
            this.buttonHabitual.AutoSize = true;
            this.buttonHabitual.Location = new System.Drawing.Point(38, 19);
            this.buttonHabitual.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHabitual.Name = "buttonHabitual";
            this.buttonHabitual.Size = new System.Drawing.Size(82, 19);
            this.buttonHabitual.TabIndex = 12;
            this.buttonHabitual.TabStop = true;
            this.buttonHabitual.Text = "HABITUAL";
            this.buttonHabitual.UseVisualStyleBackColor = true;
            // 
            // groupBoxtabaquismo
            // 
            this.groupBoxtabaquismo.Controls.Add(this.buttonNo);
            this.groupBoxtabaquismo.Controls.Add(this.buttonSi);
            this.groupBoxtabaquismo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxtabaquismo.Location = new System.Drawing.Point(35, 298);
            this.groupBoxtabaquismo.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxtabaquismo.Name = "groupBoxtabaquismo";
            this.groupBoxtabaquismo.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxtabaquismo.Size = new System.Drawing.Size(342, 46);
            this.groupBoxtabaquismo.TabIndex = 12;
            this.groupBoxtabaquismo.TabStop = false;
            this.groupBoxtabaquismo.Text = "TABAQUISMO";
            // 
            // buttonNo
            // 
            this.buttonNo.AutoSize = true;
            this.buttonNo.Location = new System.Drawing.Point(191, 19);
            this.buttonNo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(43, 19);
            this.buttonNo.TabIndex = 11;
            this.buttonNo.TabStop = true;
            this.buttonNo.Text = "NO";
            this.buttonNo.UseVisualStyleBackColor = true;
            // 
            // buttonSi
            // 
            this.buttonSi.AutoSize = true;
            this.buttonSi.Location = new System.Drawing.Point(102, 19);
            this.buttonSi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSi.Name = "buttonSi";
            this.buttonSi.Size = new System.Drawing.Size(36, 19);
            this.buttonSi.TabIndex = 10;
            this.buttonSi.TabStop = true;
            this.buttonSi.Text = "SI";
            this.buttonSi.UseVisualStyleBackColor = true;
            // 
            // groupBoxsexo
            // 
            this.groupBoxsexo.Controls.Add(this.radioButtonotros);
            this.groupBoxsexo.Controls.Add(this.radioButtonH);
            this.groupBoxsexo.Controls.Add(this.radioButtonM);
            this.groupBoxsexo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxsexo.Location = new System.Drawing.Point(35, 247);
            this.groupBoxsexo.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxsexo.Name = "groupBoxsexo";
            this.groupBoxsexo.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxsexo.Size = new System.Drawing.Size(342, 46);
            this.groupBoxsexo.TabIndex = 11;
            this.groupBoxsexo.TabStop = false;
            this.groupBoxsexo.Text = "SEXO";
            // 
            // radioButtonotros
            // 
            this.radioButtonotros.AutoSize = true;
            this.radioButtonotros.Location = new System.Drawing.Point(240, 19);
            this.radioButtonotros.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonotros.Name = "radioButtonotros";
            this.radioButtonotros.Size = new System.Drawing.Size(67, 19);
            this.radioButtonotros.TabIndex = 9;
            this.radioButtonotros.TabStop = true;
            this.radioButtonotros.Text = "OTROS";
            this.radioButtonotros.UseVisualStyleBackColor = true;
            // 
            // radioButtonH
            // 
            this.radioButtonH.AutoSize = true;
            this.radioButtonH.Location = new System.Drawing.Point(147, 20);
            this.radioButtonH.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonH.Name = "radioButtonH";
            this.radioButtonH.Size = new System.Drawing.Size(34, 19);
            this.radioButtonH.TabIndex = 8;
            this.radioButtonH.TabStop = true;
            this.radioButtonH.Text = "H";
            this.radioButtonH.UseVisualStyleBackColor = true;
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(61, 19);
            this.radioButtonM.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(36, 19);
            this.radioButtonM.TabIndex = 7;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "M";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // campoTelf
            // 
            this.campoTelf.Location = new System.Drawing.Point(190, 156);
            this.campoTelf.Margin = new System.Windows.Forms.Padding(2);
            this.campoTelf.Name = "campoTelf";
            this.campoTelf.Size = new System.Drawing.Size(107, 21);
            this.campoTelf.TabIndex = 5;
            // 
            // campoApe
            // 
            this.campoApe.Location = new System.Drawing.Point(190, 84);
            this.campoApe.Margin = new System.Windows.Forms.Padding(2);
            this.campoApe.Name = "campoApe";
            this.campoApe.Size = new System.Drawing.Size(176, 21);
            this.campoApe.TabIndex = 3;
            // 
            // campoNombre
            // 
            this.campoNombre.Location = new System.Drawing.Point(190, 53);
            this.campoNombre.Margin = new System.Windows.Forms.Padding(2);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(107, 21);
            this.campoNombre.TabIndex = 2;
            // 
            // fecha
            // 
            this.fecha.CustomFormat = "yyyy-MM-dd";
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha.Location = new System.Drawing.Point(190, 121);
            this.fecha.Margin = new System.Windows.Forms.Padding(2);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(115, 21);
            this.fecha.TabIndex = 4;
            // 
            // comboCP
            // 
            this.comboCP.FormattingEnabled = true;
            this.comboCP.Location = new System.Drawing.Point(190, 184);
            this.comboCP.Margin = new System.Windows.Forms.Padding(2);
            this.comboCP.Name = "comboCP";
            this.comboCP.Size = new System.Drawing.Size(107, 23);
            this.comboCP.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 184);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "CP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "DNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "NUEVO PACIENTE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Consultorio_JVH.Properties.Resources.logo_good;
            this.pictureBox1.Location = new System.Drawing.Point(848, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 78);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // NuevoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1000, 650);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "NuevoPaciente";
            this.Text = "NuevoPaciente";
            this.panel1.ResumeLayout(false);
            this.groupBoxsalud.ResumeLayout(false);
            this.groupBoxsalud.PerformLayout();
            this.groupBoxdatospersonales.ResumeLayout(false);
            this.groupBoxdatospersonales.PerformLayout();
            this.groupBoxconsumo.ResumeLayout(false);
            this.groupBoxconsumo.PerformLayout();
            this.groupBoxtabaquismo.ResumeLayout(false);
            this.groupBoxtabaquismo.PerformLayout();
            this.groupBoxsexo.ResumeLayout(false);
            this.groupBoxsexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonRegistrar;
        private System.Windows.Forms.GroupBox groupBoxsalud;
        private System.Windows.Forms.TextBox campoPersonal;
        private System.Windows.Forms.TextBox campoAntecedentes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBoxdatospersonales;
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox campoDni;
        private System.Windows.Forms.GroupBox groupBoxconsumo;
        private System.Windows.Forms.RadioButton buttonNulo;
        private System.Windows.Forms.RadioButton buttonOcasional;
        private System.Windows.Forms.RadioButton buttonHabitual;
        private System.Windows.Forms.GroupBox groupBoxtabaquismo;
        private System.Windows.Forms.RadioButton buttonNo;
        private System.Windows.Forms.RadioButton buttonSi;
        private System.Windows.Forms.GroupBox groupBoxsexo;
        private System.Windows.Forms.RadioButton radioButtonotros;
        private System.Windows.Forms.RadioButton radioButtonH;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.TextBox campoTelf;
        private System.Windows.Forms.TextBox campoApe;
        private System.Windows.Forms.TextBox campoNombre;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.ComboBox comboCP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;

        public string rescatarTabaco()
        {
            string tabaco = null;
            if(buttonSi.Checked == true)
            {
                tabaco = "Fuma";
            }else
            {
                tabaco = "No fuma";

            }
            return tabaco;
        }
        public string rescatarSexo ()
        {
            string sexo = null;
            if (radioButtonM.Checked == true)
            {
                sexo = "Mujer";
            }
            else if (radioButtonH.Checked == true)
            {
                sexo = "Hombre";
            }
            else
            {
                sexo = "Otros";
            }
            return sexo;

           
        }
        public string rescatarAlcohol()
        {
            string alcohol = null;
            if (buttonHabitual.Checked == true)
            {
                alcohol = "Consumidor Habitualmente de alcohol";
            }
            else if (buttonOcasional.Checked == true)
            {
                alcohol = "Consumidor Ocasionalmente de alcohol";
            }
            else
            {
                alcohol = "No consume alcohol";
            }
            return alcohol;
        }
    }
}
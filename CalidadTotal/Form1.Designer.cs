
namespace CalidadTotal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtAsesorNo = new System.Windows.Forms.RadioButton();
            this.rbtAsesorSi = new System.Windows.Forms.RadioButton();
            this.Garantia = new System.Windows.Forms.GroupBox();
            this.rbtMeses24 = new System.Windows.Forms.RadioButton();
            this.rbtMeses12 = new System.Windows.Forms.RadioButton();
            this.rbtMeses6 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtMantNo = new System.Windows.Forms.RadioButton();
            this.rbtMantSi = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkWindows = new System.Windows.Forms.CheckBox();
            this.chkAdobe = new System.Windows.Forms.CheckBox();
            this.chkOffice = new System.Windows.Forms.CheckBox();
            this.chkSwitch = new System.Windows.Forms.CheckBox();
            this.chkCable = new System.Windows.Forms.CheckBox();
            this.chkRepetidores = new System.Windows.Forms.CheckBox();
            this.chkModem = new System.Windows.Forms.CheckBox();
            this.chkPedido = new System.Windows.Forms.CheckBox();
            this.chkGamer = new System.Windows.Forms.CheckBox();
            this.chkTrabajo = new System.Windows.Forms.CheckBox();
            this.chkOficina = new System.Windows.Forms.CheckBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtCotizacion = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDolares = new System.Windows.Forms.TextBox();
            this.txtEuros = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.Garantia.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellidos y Nombres  :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empresa :";
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtNombres.Location = new System.Drawing.Point(145, 39);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(227, 20);
            this.txtNombres.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtAsesorNo);
            this.groupBox1.Controls.Add(this.rbtAsesorSi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asesor";
            // 
            // rbtAsesorNo
            // 
            this.rbtAsesorNo.AutoSize = true;
            this.rbtAsesorNo.Location = new System.Drawing.Point(6, 66);
            this.rbtAsesorNo.Name = "rbtAsesorNo";
            this.rbtAsesorNo.Size = new System.Drawing.Size(43, 19);
            this.rbtAsesorNo.TabIndex = 12;
            this.rbtAsesorNo.TabStop = true;
            this.rbtAsesorNo.Text = "No";
            this.rbtAsesorNo.UseVisualStyleBackColor = true;
            this.rbtAsesorNo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtAsesorSi
            // 
            this.rbtAsesorSi.AutoSize = true;
            this.rbtAsesorSi.Location = new System.Drawing.Point(6, 28);
            this.rbtAsesorSi.Name = "rbtAsesorSi";
            this.rbtAsesorSi.Size = new System.Drawing.Size(38, 19);
            this.rbtAsesorSi.TabIndex = 0;
            this.rbtAsesorSi.TabStop = true;
            this.rbtAsesorSi.Text = "Si";
            this.rbtAsesorSi.UseVisualStyleBackColor = true;
            // 
            // Garantia
            // 
            this.Garantia.Controls.Add(this.rbtMeses24);
            this.Garantia.Controls.Add(this.rbtMeses12);
            this.Garantia.Controls.Add(this.rbtMeses6);
            this.Garantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Garantia.Location = new System.Drawing.Point(145, 140);
            this.Garantia.Name = "Garantia";
            this.Garantia.Size = new System.Drawing.Size(101, 100);
            this.Garantia.TabIndex = 5;
            this.Garantia.TabStop = false;
            this.Garantia.Text = "Garantia";
            // 
            // rbtMeses24
            // 
            this.rbtMeses24.AutoSize = true;
            this.rbtMeses24.Location = new System.Drawing.Point(6, 74);
            this.rbtMeses24.Name = "rbtMeses24";
            this.rbtMeses24.Size = new System.Drawing.Size(87, 19);
            this.rbtMeses24.TabIndex = 12;
            this.rbtMeses24.TabStop = true;
            this.rbtMeses24.Text = "24 meses";
            this.rbtMeses24.UseVisualStyleBackColor = true;
            // 
            // rbtMeses12
            // 
            this.rbtMeses12.AutoSize = true;
            this.rbtMeses12.Location = new System.Drawing.Point(6, 51);
            this.rbtMeses12.Name = "rbtMeses12";
            this.rbtMeses12.Size = new System.Drawing.Size(87, 19);
            this.rbtMeses12.TabIndex = 1;
            this.rbtMeses12.TabStop = true;
            this.rbtMeses12.Text = "12 meses";
            this.rbtMeses12.UseVisualStyleBackColor = true;
            // 
            // rbtMeses6
            // 
            this.rbtMeses6.AutoSize = true;
            this.rbtMeses6.Location = new System.Drawing.Point(6, 28);
            this.rbtMeses6.Name = "rbtMeses6";
            this.rbtMeses6.Size = new System.Drawing.Size(79, 19);
            this.rbtMeses6.TabIndex = 0;
            this.rbtMeses6.TabStop = true;
            this.rbtMeses6.Text = "6 meses";
            this.rbtMeses6.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtMantNo);
            this.groupBox3.Controls.Add(this.rbtMantSi);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(252, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(120, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mantenimiento";
            // 
            // rbtMantNo
            // 
            this.rbtMantNo.AutoSize = true;
            this.rbtMantNo.Location = new System.Drawing.Point(6, 66);
            this.rbtMantNo.Name = "rbtMantNo";
            this.rbtMantNo.Size = new System.Drawing.Size(43, 19);
            this.rbtMantNo.TabIndex = 1;
            this.rbtMantNo.Text = "No";
            this.rbtMantNo.UseVisualStyleBackColor = true;
            // 
            // rbtMantSi
            // 
            this.rbtMantSi.AutoSize = true;
            this.rbtMantSi.Location = new System.Drawing.Point(6, 28);
            this.rbtMantSi.Name = "rbtMantSi";
            this.rbtMantSi.Size = new System.Drawing.Size(38, 19);
            this.rbtMantSi.TabIndex = 0;
            this.rbtMantSi.Text = "Si";
            this.rbtMantSi.UseVisualStyleBackColor = true;
            this.rbtMantSi.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkWindows);
            this.groupBox4.Controls.Add(this.chkAdobe);
            this.groupBox4.Controls.Add(this.chkOffice);
            this.groupBox4.Controls.Add(this.chkSwitch);
            this.groupBox4.Controls.Add(this.chkCable);
            this.groupBox4.Controls.Add(this.chkRepetidores);
            this.groupBox4.Controls.Add(this.chkModem);
            this.groupBox4.Controls.Add(this.chkPedido);
            this.groupBox4.Controls.Add(this.chkGamer);
            this.groupBox4.Controls.Add(this.chkTrabajo);
            this.groupBox4.Controls.Add(this.chkOficina);
            this.groupBox4.Controls.Add(this.chkAll);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(25, 246);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(380, 137);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Articulos a adquirir";
            // 
            // chkWindows
            // 
            this.chkWindows.AutoSize = true;
            this.chkWindows.Location = new System.Drawing.Point(227, 42);
            this.chkWindows.Name = "chkWindows";
            this.chkWindows.Size = new System.Drawing.Size(153, 17);
            this.chkWindows.TabIndex = 11;
            this.chkWindows.Text = "Licencias de Windows";
            this.chkWindows.UseVisualStyleBackColor = true;
            // 
            // chkAdobe
            // 
            this.chkAdobe.AutoSize = true;
            this.chkAdobe.Location = new System.Drawing.Point(227, 19);
            this.chkAdobe.Name = "chkAdobe";
            this.chkAdobe.Size = new System.Drawing.Size(138, 17);
            this.chkAdobe.TabIndex = 10;
            this.chkAdobe.Text = "Licencias de Adobe";
            this.chkAdobe.UseVisualStyleBackColor = true;
            // 
            // chkOffice
            // 
            this.chkOffice.AutoSize = true;
            this.chkOffice.Location = new System.Drawing.Point(110, 111);
            this.chkOffice.Name = "chkOffice";
            this.chkOffice.Size = new System.Drawing.Size(155, 17);
            this.chkOffice.TabIndex = 9;
            this.chkOffice.Text = "Licencia de Office 365";
            this.chkOffice.UseVisualStyleBackColor = true;
            // 
            // chkSwitch
            // 
            this.chkSwitch.AutoSize = true;
            this.chkSwitch.Location = new System.Drawing.Point(110, 88);
            this.chkSwitch.Name = "chkSwitch";
            this.chkSwitch.Size = new System.Drawing.Size(117, 17);
            this.chkSwitch.TabIndex = 8;
            this.chkSwitch.Text = "Swtiches de red";
            this.chkSwitch.UseVisualStyleBackColor = true;
            // 
            // chkCable
            // 
            this.chkCable.AutoSize = true;
            this.chkCable.Location = new System.Drawing.Point(110, 65);
            this.chkCable.Name = "chkCable";
            this.chkCable.Size = new System.Drawing.Size(98, 17);
            this.chkCable.TabIndex = 7;
            this.chkCable.Text = "Cable de red";
            this.chkCable.UseVisualStyleBackColor = true;
            this.chkCable.CheckedChanged += new System.EventHandler(this.chkCable_CheckedChanged);
            // 
            // chkRepetidores
            // 
            this.chkRepetidores.AutoSize = true;
            this.chkRepetidores.Location = new System.Drawing.Point(110, 42);
            this.chkRepetidores.Name = "chkRepetidores";
            this.chkRepetidores.Size = new System.Drawing.Size(123, 17);
            this.chkRepetidores.TabIndex = 6;
            this.chkRepetidores.Text = "Repetidores WiFi";
            this.chkRepetidores.UseVisualStyleBackColor = true;
            // 
            // chkModem
            // 
            this.chkModem.AutoSize = true;
            this.chkModem.Location = new System.Drawing.Point(110, 19);
            this.chkModem.Name = "chkModem";
            this.chkModem.Size = new System.Drawing.Size(95, 17);
            this.chkModem.TabIndex = 5;
            this.chkModem.Text = "Modem WiFi";
            this.chkModem.UseVisualStyleBackColor = true;
            // 
            // chkPedido
            // 
            this.chkPedido.AutoSize = true;
            this.chkPedido.Location = new System.Drawing.Point(6, 111);
            this.chkPedido.Name = "chkPedido";
            this.chkPedido.Size = new System.Drawing.Size(88, 17);
            this.chkPedido.TabIndex = 4;
            this.chkPedido.Text = "PC Escolar";
            this.chkPedido.UseVisualStyleBackColor = true;
            // 
            // chkGamer
            // 
            this.chkGamer.AutoSize = true;
            this.chkGamer.Location = new System.Drawing.Point(6, 88);
            this.chkGamer.Name = "chkGamer";
            this.chkGamer.Size = new System.Drawing.Size(82, 17);
            this.chkGamer.TabIndex = 3;
            this.chkGamer.Text = "PC Gamer";
            this.chkGamer.UseVisualStyleBackColor = true;
            // 
            // chkTrabajo
            // 
            this.chkTrabajo.AutoSize = true;
            this.chkTrabajo.Location = new System.Drawing.Point(6, 65);
            this.chkTrabajo.Name = "chkTrabajo";
            this.chkTrabajo.Size = new System.Drawing.Size(89, 17);
            this.chkTrabajo.TabIndex = 2;
            this.chkTrabajo.Text = "PC Trabajo";
            this.chkTrabajo.UseVisualStyleBackColor = true;
            // 
            // chkOficina
            // 
            this.chkOficina.AutoSize = true;
            this.chkOficina.Location = new System.Drawing.Point(6, 42);
            this.chkOficina.Name = "chkOficina";
            this.chkOficina.Size = new System.Drawing.Size(86, 17);
            this.chkOficina.TabIndex = 1;
            this.chkOficina.Text = "PC Oficina";
            this.chkOficina.UseVisualStyleBackColor = true;
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(6, 19);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(99, 17);
            this.chkAll.TabIndex = 0;
            this.chkAll.Text = "PC All in one";
            this.chkAll.UseVisualStyleBackColor = true;
            // 
            // btnCotizar
            // 
            this.btnCotizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizar.Location = new System.Drawing.Point(400, 37);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(85, 23);
            this.btnCotizar.TabIndex = 8;
            this.btnCotizar.Text = "COTIZAR";
            this.btnCotizar.UseVisualStyleBackColor = true;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(491, 37);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(572, 37);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtCotizacion
            // 
            this.txtCotizacion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotizacion.Location = new System.Drawing.Point(400, 66);
            this.txtCotizacion.Multiline = true;
            this.txtCotizacion.Name = "txtCotizacion";
            this.txtCotizacion.Size = new System.Drawing.Size(385, 457);
            this.txtCotizacion.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Location = new System.Drawing.Point(88, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cotizacion en dolares:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cotizacion en euros:";
            // 
            // txtDolares
            // 
            this.txtDolares.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtDolares.Location = new System.Drawing.Point(177, 408);
            this.txtDolares.Name = "txtDolares";
            this.txtDolares.Size = new System.Drawing.Size(137, 20);
            this.txtDolares.TabIndex = 15;
            this.txtDolares.TextChanged += new System.EventHandler(this.txtDolares_TextChanged);
            // 
            // txtEuros
            // 
            this.txtEuros.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtEuros.Location = new System.Drawing.Point(166, 451);
            this.txtEuros.Name = "txtEuros";
            this.txtEuros.Size = new System.Drawing.Size(124, 20);
            this.txtEuros.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "R.U.C.:";
            // 
            // txtRUC
            // 
            this.txtRUC.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtRUC.Location = new System.Drawing.Point(80, 96);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(292, 20);
            this.txtRUC.TabIndex = 18;
            this.txtRUC.TextChanged += new System.EventHandler(this.txtRUC_TextChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(797, 535);
            this.Controls.Add(this.txtRUC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEuros);
            this.Controls.Add(this.txtDolares);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtCotizacion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Garantia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cotizar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Garantia.ResumeLayout(false);
            this.Garantia.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtAsesorSi;
        private System.Windows.Forms.GroupBox Garantia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtCotizacion;
        private System.Windows.Forms.RadioButton rbtAsesorNo;
        private System.Windows.Forms.RadioButton rbtMeses24;
        private System.Windows.Forms.RadioButton rbtMeses12;
        private System.Windows.Forms.RadioButton rbtMeses6;
        private System.Windows.Forms.RadioButton rbtMantNo;
        private System.Windows.Forms.RadioButton rbtMantSi;
        private System.Windows.Forms.CheckBox chkWindows;
        private System.Windows.Forms.CheckBox chkAdobe;
        private System.Windows.Forms.CheckBox chkOffice;
        private System.Windows.Forms.CheckBox chkSwitch;
        private System.Windows.Forms.CheckBox chkCable;
        private System.Windows.Forms.CheckBox chkRepetidores;
        private System.Windows.Forms.CheckBox chkModem;
        private System.Windows.Forms.CheckBox chkPedido;
        private System.Windows.Forms.CheckBox chkGamer;
        private System.Windows.Forms.CheckBox chkTrabajo;
        private System.Windows.Forms.CheckBox chkOficina;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDolares;
        private System.Windows.Forms.TextBox txtEuros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRUC;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}


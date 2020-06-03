namespace Vistas
{
    partial class FormModalModificarVehiculo
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
            this.label9 = new System.Windows.Forms.Label();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rbtnSi = new System.Windows.Forms.RadioButton();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPuertas = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.rbtnGps = new System.Windows.Forms.GroupBox();
            this.rbtnNoGps = new System.Windows.Forms.RadioButton();
            this.rbtnSiGps = new System.Windows.Forms.RadioButton();
            this.cmbLinea = new System.Windows.Forms.ComboBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbClaseVehiculo = new System.Windows.Forms.ComboBox();
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.rbtnGps.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 38);
            this.panel1.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(199, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 30);
            this.label9.TabIndex = 29;
            this.label9.Text = "Modificar Vehiculo";
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.BackColor = System.Drawing.Color.Transparent;
            this.rbtnNo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNo.ForeColor = System.Drawing.Color.Black;
            this.rbtnNo.Location = new System.Drawing.Point(76, 21);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(45, 21);
            this.rbtnNo.TabIndex = 53;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(119, 358);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(178, 49);
            this.btnCancelar.TabIndex = 74;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rbtnSi
            // 
            this.rbtnSi.AutoSize = true;
            this.rbtnSi.BackColor = System.Drawing.Color.Transparent;
            this.rbtnSi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSi.ForeColor = System.Drawing.Color.Black;
            this.rbtnSi.Location = new System.Drawing.Point(4, 21);
            this.rbtnSi.Name = "rbtnSi";
            this.rbtnSi.Size = new System.Drawing.Size(35, 21);
            this.rbtnSi.TabIndex = 52;
            this.rbtnSi.TabStop = true;
            this.rbtnSi.Text = "Si";
            this.rbtnSi.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnActualizar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(337, 358);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(178, 49);
            this.btnActualizar.TabIndex = 73;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtPrecio.Location = new System.Drawing.Point(339, 311);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(283, 27);
            this.txtPrecio.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(335, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 71;
            this.label7.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(335, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 21);
            this.label8.TabIndex = 69;
            this.label8.Text = "Clase de  Vehiculo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(335, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 21);
            this.label6.TabIndex = 67;
            this.label6.Text = "Tipo de Vehiculo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(335, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 66;
            this.label3.Text = "Gps";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(333, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 64;
            this.label5.Text = "Puertas";
            // 
            // txtPuertas
            // 
            this.txtPuertas.BackColor = System.Drawing.Color.White;
            this.txtPuertas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPuertas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuertas.ForeColor = System.Drawing.Color.Black;
            this.txtPuertas.Location = new System.Drawing.Point(339, 74);
            this.txtPuertas.Name = "txtPuertas";
            this.txtPuertas.Size = new System.Drawing.Size(283, 27);
            this.txtPuertas.TabIndex = 65;
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.White;
            this.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.ForeColor = System.Drawing.Color.Black;
            this.txtColor.Location = new System.Drawing.Point(14, 311);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(283, 27);
            this.txtColor.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 62;
            this.label4.Text = "Color";
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.Color.White;
            this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.ForeColor = System.Drawing.Color.Black;
            this.txtModelo.Location = new System.Drawing.Point(14, 252);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(283, 27);
            this.txtModelo.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 60;
            this.label1.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 58;
            this.label2.Text = "Linea";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.Black;
            this.lblContraseña.Location = new System.Drawing.Point(7, 108);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(62, 21);
            this.lblContraseña.TabIndex = 56;
            this.lblContraseña.Text = "Marca";
            // 
            // txtMatricula
            // 
            this.txtMatricula.BackColor = System.Drawing.Color.White;
            this.txtMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatricula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.ForeColor = System.Drawing.Color.Black;
            this.txtMatricula.Location = new System.Drawing.Point(12, 74);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(283, 27);
            this.txtMatricula.TabIndex = 55;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(8, 48);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(85, 21);
            this.lblUsuario.TabIndex = 54;
            this.lblUsuario.Text = "Matricula";
            // 
            // rbtnGps
            // 
            this.rbtnGps.Controls.Add(this.rbtnNoGps);
            this.rbtnGps.Controls.Add(this.rbtnSiGps);
            this.rbtnGps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnGps.Location = new System.Drawing.Point(339, 128);
            this.rbtnGps.Name = "rbtnGps";
            this.rbtnGps.Size = new System.Drawing.Size(283, 36);
            this.rbtnGps.TabIndex = 76;
            this.rbtnGps.TabStop = false;
            // 
            // rbtnNoGps
            // 
            this.rbtnNoGps.AutoSize = true;
            this.rbtnNoGps.BackColor = System.Drawing.Color.Transparent;
            this.rbtnNoGps.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNoGps.ForeColor = System.Drawing.Color.Black;
            this.rbtnNoGps.Location = new System.Drawing.Point(76, 10);
            this.rbtnNoGps.Name = "rbtnNoGps";
            this.rbtnNoGps.Size = new System.Drawing.Size(45, 21);
            this.rbtnNoGps.TabIndex = 1;
            this.rbtnNoGps.TabStop = true;
            this.rbtnNoGps.Text = "No";
            this.rbtnNoGps.UseVisualStyleBackColor = false;
            // 
            // rbtnSiGps
            // 
            this.rbtnSiGps.AutoSize = true;
            this.rbtnSiGps.BackColor = System.Drawing.Color.Transparent;
            this.rbtnSiGps.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSiGps.ForeColor = System.Drawing.Color.Black;
            this.rbtnSiGps.Location = new System.Drawing.Point(4, 10);
            this.rbtnSiGps.Name = "rbtnSiGps";
            this.rbtnSiGps.Size = new System.Drawing.Size(35, 21);
            this.rbtnSiGps.TabIndex = 0;
            this.rbtnSiGps.TabStop = true;
            this.rbtnSiGps.Text = "Si";
            this.rbtnSiGps.UseVisualStyleBackColor = false;
            // 
            // cmbLinea
            // 
            this.cmbLinea.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLinea.FormattingEnabled = true;
            this.cmbLinea.Location = new System.Drawing.Point(14, 189);
            this.cmbLinea.Name = "cmbLinea";
            this.cmbLinea.Size = new System.Drawing.Size(281, 28);
            this.cmbLinea.TabIndex = 78;
            // 
            // cmbMarca
            // 
            this.cmbMarca.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(12, 131);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(281, 28);
            this.cmbMarca.TabIndex = 77;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // cmbClaseVehiculo
            // 
            this.cmbClaseVehiculo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClaseVehiculo.FormattingEnabled = true;
            this.cmbClaseVehiculo.Location = new System.Drawing.Point(337, 251);
            this.cmbClaseVehiculo.Name = "cmbClaseVehiculo";
            this.cmbClaseVehiculo.Size = new System.Drawing.Size(283, 28);
            this.cmbClaseVehiculo.TabIndex = 80;
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(337, 191);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(283, 28);
            this.cmbTipoVehiculo.TabIndex = 79;
            // 
            // FormModalModificarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 422);
            this.Controls.Add(this.cmbClaseVehiculo);
            this.Controls.Add(this.cmbTipoVehiculo);
            this.Controls.Add(this.cmbLinea);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.rbtnGps);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbtnNo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.rbtnSi);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPuertas);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormModalModificarVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModalModificarVehiculo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.rbtnGps.ResumeLayout(false);
            this.rbtnGps.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rbtnSi;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        public System.Windows.Forms.TextBox txtPrecio;
        public System.Windows.Forms.TextBox txtPuertas;
        public System.Windows.Forms.TextBox txtColor;
        public System.Windows.Forms.TextBox txtModelo;
        public System.Windows.Forms.TextBox txtMatricula;
        public System.Windows.Forms.RadioButton rbtnNoGps;
        public System.Windows.Forms.RadioButton rbtnSiGps;
        public System.Windows.Forms.GroupBox rbtnGps;
        public System.Windows.Forms.ComboBox cmbLinea;
        public System.Windows.Forms.ComboBox cmbMarca;
        public System.Windows.Forms.ComboBox cmbClaseVehiculo;
        public System.Windows.Forms.ComboBox cmbTipoVehiculo;
    }
}
namespace Vistas
{
    partial class FormPrincipal
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
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.pnlMenuVertical = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.pnlSubMenuVehiculo = new System.Windows.Forms.Panel();
            this.tbnGes = new System.Windows.Forms.Button();
            this.btnGestorDeLineaYMarca = new System.Windows.Forms.Button();
            this.btnGestorVehiculo = new System.Windows.Forms.Button();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.pnlSubMenuVentas = new System.Windows.Forms.Panel();
            this.btnGestorFormaPago = new System.Windows.Forms.Button();
            this.btnGestorVentas = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.lblRol = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlMenuVertical.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnlSubMenuVehiculo.SuspendLayout();
            this.pnlSubMenuVentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(1284, 35);
            this.pnlBarraTitulo.TabIndex = 1;
            // 
            // pnlMenuVertical
            // 
            this.pnlMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnlMenuVertical.Controls.Add(this.panel6);
            this.pnlMenuVertical.Controls.Add(this.lblRol);
            this.pnlMenuVertical.Controls.Add(this.label3);
            this.pnlMenuVertical.Controls.Add(this.panel5);
            this.pnlMenuVertical.Controls.Add(this.lblNombreUsuario);
            this.pnlMenuVertical.Controls.Add(this.label1);
            this.pnlMenuVertical.Controls.Add(this.btnSalir);
            this.pnlMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuVertical.Location = new System.Drawing.Point(0, 35);
            this.pnlMenuVertical.Name = "pnlMenuVertical";
            this.pnlMenuVertical.Size = new System.Drawing.Size(220, 576);
            this.pnlMenuVertical.TabIndex = 2;
            this.pnlMenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenuVertical_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel6.Controls.Add(this.btnUsuarios);
            this.panel6.Controls.Add(this.pnlSubMenuVehiculo);
            this.panel6.Controls.Add(this.btnVehiculos);
            this.panel6.Controls.Add(this.pnlSubMenuVentas);
            this.panel6.Controls.Add(this.btnVentas);
            this.panel6.Controls.Add(this.btnClientes);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(220, 341);
            this.panel6.TabIndex = 15;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = global::Vistas.Properties.Resources.producto;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 256);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(220, 32);
            this.btnUsuarios.TabIndex = 24;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click_1);
            // 
            // pnlSubMenuVehiculo
            // 
            this.pnlSubMenuVehiculo.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlSubMenuVehiculo.Controls.Add(this.tbnGes);
            this.pnlSubMenuVehiculo.Controls.Add(this.btnGestorDeLineaYMarca);
            this.pnlSubMenuVehiculo.Controls.Add(this.btnGestorVehiculo);
            this.pnlSubMenuVehiculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuVehiculo.Location = new System.Drawing.Point(0, 160);
            this.pnlSubMenuVehiculo.Name = "pnlSubMenuVehiculo";
            this.pnlSubMenuVehiculo.Size = new System.Drawing.Size(220, 96);
            this.pnlSubMenuVehiculo.TabIndex = 22;
            // 
            // tbnGes
            // 
            this.tbnGes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbnGes.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbnGes.FlatAppearance.BorderSize = 0;
            this.tbnGes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.tbnGes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbnGes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnGes.ForeColor = System.Drawing.Color.Black;
            this.tbnGes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbnGes.Location = new System.Drawing.Point(0, 64);
            this.tbnGes.Name = "tbnGes";
            this.tbnGes.Size = new System.Drawing.Size(220, 32);
            this.tbnGes.TabIndex = 19;
            this.tbnGes.Text = "Clase y Tipo";
            this.tbnGes.UseVisualStyleBackColor = false;
            this.tbnGes.Click += new System.EventHandler(this.tbnGes_Click);
            // 
            // btnGestorDeLineaYMarca
            // 
            this.btnGestorDeLineaYMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGestorDeLineaYMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestorDeLineaYMarca.FlatAppearance.BorderSize = 0;
            this.btnGestorDeLineaYMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnGestorDeLineaYMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestorDeLineaYMarca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestorDeLineaYMarca.ForeColor = System.Drawing.Color.Black;
            this.btnGestorDeLineaYMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestorDeLineaYMarca.Location = new System.Drawing.Point(0, 32);
            this.btnGestorDeLineaYMarca.Name = "btnGestorDeLineaYMarca";
            this.btnGestorDeLineaYMarca.Size = new System.Drawing.Size(220, 32);
            this.btnGestorDeLineaYMarca.TabIndex = 18;
            this.btnGestorDeLineaYMarca.Text = "Linea y Marca";
            this.btnGestorDeLineaYMarca.UseVisualStyleBackColor = false;
            // 
            // btnGestorVehiculo
            // 
            this.btnGestorVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGestorVehiculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestorVehiculo.FlatAppearance.BorderSize = 0;
            this.btnGestorVehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnGestorVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestorVehiculo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestorVehiculo.ForeColor = System.Drawing.Color.Black;
            this.btnGestorVehiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestorVehiculo.Location = new System.Drawing.Point(0, 0);
            this.btnGestorVehiculo.Name = "btnGestorVehiculo";
            this.btnGestorVehiculo.Size = new System.Drawing.Size(220, 32);
            this.btnGestorVehiculo.TabIndex = 17;
            this.btnGestorVehiculo.Text = "Gestor de Vehiculo";
            this.btnGestorVehiculo.UseVisualStyleBackColor = false;
            this.btnGestorVehiculo.Click += new System.EventHandler(this.btnGestorVehiculo_Click);
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnVehiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehiculos.FlatAppearance.BorderSize = 0;
            this.btnVehiculos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiculos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculos.ForeColor = System.Drawing.Color.White;
            this.btnVehiculos.Image = global::Vistas.Properties.Resources.compras;
            this.btnVehiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehiculos.Location = new System.Drawing.Point(0, 128);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(220, 32);
            this.btnVehiculos.TabIndex = 20;
            this.btnVehiculos.Text = "Vehiculos";
            this.btnVehiculos.UseVisualStyleBackColor = false;
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click_1);
            // 
            // pnlSubMenuVentas
            // 
            this.pnlSubMenuVentas.BackColor = System.Drawing.Color.Lime;
            this.pnlSubMenuVentas.Controls.Add(this.btnGestorFormaPago);
            this.pnlSubMenuVentas.Controls.Add(this.btnGestorVentas);
            this.pnlSubMenuVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuVentas.Location = new System.Drawing.Point(0, 64);
            this.pnlSubMenuVentas.Name = "pnlSubMenuVentas";
            this.pnlSubMenuVentas.Size = new System.Drawing.Size(220, 64);
            this.pnlSubMenuVentas.TabIndex = 17;
            // 
            // btnGestorFormaPago
            // 
            this.btnGestorFormaPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGestorFormaPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestorFormaPago.FlatAppearance.BorderSize = 0;
            this.btnGestorFormaPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnGestorFormaPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestorFormaPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestorFormaPago.ForeColor = System.Drawing.Color.Black;
            this.btnGestorFormaPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestorFormaPago.Location = new System.Drawing.Point(0, 32);
            this.btnGestorFormaPago.Name = "btnGestorFormaPago";
            this.btnGestorFormaPago.Size = new System.Drawing.Size(220, 32);
            this.btnGestorFormaPago.TabIndex = 18;
            this.btnGestorFormaPago.Text = "Forma de Pago";
            this.btnGestorFormaPago.UseVisualStyleBackColor = false;
            this.btnGestorFormaPago.Click += new System.EventHandler(this.btnGestorFormaPago_Click);
            // 
            // btnGestorVentas
            // 
            this.btnGestorVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGestorVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestorVentas.FlatAppearance.BorderSize = 0;
            this.btnGestorVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGestorVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnGestorVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestorVentas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestorVentas.ForeColor = System.Drawing.Color.Black;
            this.btnGestorVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestorVentas.Location = new System.Drawing.Point(0, 0);
            this.btnGestorVentas.Name = "btnGestorVentas";
            this.btnGestorVentas.Size = new System.Drawing.Size(220, 32);
            this.btnGestorVentas.TabIndex = 17;
            this.btnGestorVentas.Text = "Gestor de Ventas";
            this.btnGestorVentas.UseVisualStyleBackColor = false;
            this.btnGestorVentas.Click += new System.EventHandler(this.btnGestorVentas_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Image = global::Vistas.Properties.Resources.venta;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 32);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(220, 32);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click_1);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = global::Vistas.Properties.Resources.clientes;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(220, 32);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click_1);
            // 
            // lblRol
            // 
            this.lblRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRol.AutoSize = true;
            this.lblRol.BackColor = System.Drawing.Color.Transparent;
            this.lblRol.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.White;
            this.lblRol.Location = new System.Drawing.Point(34, 522);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(13, 20);
            this.lblRol.TabIndex = 14;
            this.lblRol.Text = ".";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Rol : ";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panel5.Location = new System.Drawing.Point(0, 544);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 32);
            this.panel5.TabIndex = 12;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(66, 498);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(13, 20);
            this.lblNombreUsuario.TabIndex = 11;
            this.lblNombreUsuario.Text = ".";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Usuario : ";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(-2, 544);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(222, 32);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(220, 35);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1064, 576);
            this.pnlContenedor.TabIndex = 3;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMenuVertical);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            this.pnlMenuVertical.ResumeLayout(false);
            this.pnlMenuVertical.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.pnlSubMenuVehiculo.ResumeLayout(false);
            this.pnlSubMenuVentas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Panel pnlMenuVertical;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel pnlSubMenuVehiculo;
        private System.Windows.Forms.Button tbnGes;
        private System.Windows.Forms.Button btnGestorDeLineaYMarca;
        private System.Windows.Forms.Button btnGestorVehiculo;
        private System.Windows.Forms.Button btnVehiculos;
        private System.Windows.Forms.Panel pnlSubMenuVentas;
        private System.Windows.Forms.Button btnGestorFormaPago;
        private System.Windows.Forms.Button btnGestorVentas;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnClientes;
    }
}
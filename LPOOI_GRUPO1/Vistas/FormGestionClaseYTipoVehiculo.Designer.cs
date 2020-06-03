namespace Vistas
{
    partial class FormGestionClaseYTipoVehiculo
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
            this.btnEiminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.dgvClaseVehiculo = new System.Windows.Forms.DataGridView();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTipoVehiculo = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminarTipo = new System.Windows.Forms.Button();
            this.btnModificarTipo = new System.Windows.Forms.Button();
            this.btnAgregarTipo = new System.Windows.Forms.Button();
            this.txtDescripcionTipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClaseVehiculo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoVehiculo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEiminar
            // 
            this.btnEiminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(82)))), ((int)(((byte)(76)))));
            this.btnEiminar.FlatAppearance.BorderSize = 0;
            this.btnEiminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEiminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEiminar.ForeColor = System.Drawing.Color.White;
            this.btnEiminar.Location = new System.Drawing.Point(431, 169);
            this.btnEiminar.Name = "btnEiminar";
            this.btnEiminar.Size = new System.Drawing.Size(112, 32);
            this.btnEiminar.TabIndex = 52;
            this.btnEiminar.Text = "Eliminar";
            this.btnEiminar.UseVisualStyleBackColor = false;
            this.btnEiminar.Click += new System.EventHandler(this.btnEiminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(172)))), ((int)(((byte)(80)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(431, 121);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 32);
            this.btnModificar.TabIndex = 51;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregarVehiculo.FlatAppearance.BorderSize = 0;
            this.btnAgregarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarVehiculo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVehiculo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(431, 74);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(112, 32);
            this.btnAgregarVehiculo.TabIndex = 50;
            this.btnAgregarVehiculo.Text = "Agregar";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = false;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // dgvClaseVehiculo
            // 
            this.dgvClaseVehiculo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClaseVehiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClaseVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClaseVehiculo.Location = new System.Drawing.Point(560, 55);
            this.dgvClaseVehiculo.Name = "dgvClaseVehiculo";
            this.dgvClaseVehiculo.Size = new System.Drawing.Size(492, 222);
            this.dgvClaseVehiculo.TabIndex = 49;
            this.dgvClaseVehiculo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClaseVehiculo_CellClick);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(34, 79);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(379, 27);
            this.txtDescripcion.TabIndex = 48;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(30, 55);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(104, 21);
            this.lblUsuario.TabIndex = 47;
            this.lblUsuario.Text = "Descripcion ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 22);
            this.label1.TabIndex = 53;
            this.label1.Text = "Gestion De Clase De Vehiculo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 32);
            this.panel1.TabIndex = 54;
            // 
            // dgvTipoVehiculo
            // 
            this.dgvTipoVehiculo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTipoVehiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoVehiculo.Location = new System.Drawing.Point(560, 342);
            this.dgvTipoVehiculo.Name = "dgvTipoVehiculo";
            this.dgvTipoVehiculo.Size = new System.Drawing.Size(492, 222);
            this.dgvTipoVehiculo.TabIndex = 55;
            this.dgvTipoVehiculo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoVehiculo_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 302);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 32);
            this.panel2.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 22);
            this.label2.TabIndex = 53;
            this.label2.Text = "Gestion De Tipo De Vehiculo";
            // 
            // btnEliminarTipo
            // 
            this.btnEliminarTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(82)))), ((int)(((byte)(76)))));
            this.btnEliminarTipo.FlatAppearance.BorderSize = 0;
            this.btnEliminarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTipo.ForeColor = System.Drawing.Color.White;
            this.btnEliminarTipo.Location = new System.Drawing.Point(431, 467);
            this.btnEliminarTipo.Name = "btnEliminarTipo";
            this.btnEliminarTipo.Size = new System.Drawing.Size(112, 32);
            this.btnEliminarTipo.TabIndex = 60;
            this.btnEliminarTipo.Text = "Eliminar";
            this.btnEliminarTipo.UseVisualStyleBackColor = false;
            this.btnEliminarTipo.Click += new System.EventHandler(this.btnEliminarTipo_Click);
            // 
            // btnModificarTipo
            // 
            this.btnModificarTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(172)))), ((int)(((byte)(80)))));
            this.btnModificarTipo.FlatAppearance.BorderSize = 0;
            this.btnModificarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarTipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarTipo.ForeColor = System.Drawing.Color.White;
            this.btnModificarTipo.Location = new System.Drawing.Point(431, 419);
            this.btnModificarTipo.Name = "btnModificarTipo";
            this.btnModificarTipo.Size = new System.Drawing.Size(112, 32);
            this.btnModificarTipo.TabIndex = 59;
            this.btnModificarTipo.Text = "Modificar";
            this.btnModificarTipo.UseVisualStyleBackColor = false;
            this.btnModificarTipo.Click += new System.EventHandler(this.btnModificarTipo_Click);
            // 
            // btnAgregarTipo
            // 
            this.btnAgregarTipo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregarTipo.FlatAppearance.BorderSize = 0;
            this.btnAgregarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTipo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTipo.Location = new System.Drawing.Point(431, 372);
            this.btnAgregarTipo.Name = "btnAgregarTipo";
            this.btnAgregarTipo.Size = new System.Drawing.Size(112, 32);
            this.btnAgregarTipo.TabIndex = 58;
            this.btnAgregarTipo.Text = "Agregar";
            this.btnAgregarTipo.UseVisualStyleBackColor = false;
            this.btnAgregarTipo.Click += new System.EventHandler(this.btnAgregarTipo_Click);
            // 
            // txtDescripcionTipo
            // 
            this.txtDescripcionTipo.BackColor = System.Drawing.Color.White;
            this.txtDescripcionTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcionTipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionTipo.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcionTipo.Location = new System.Drawing.Point(34, 377);
            this.txtDescripcionTipo.Name = "txtDescripcionTipo";
            this.txtDescripcionTipo.Size = new System.Drawing.Size(379, 27);
            this.txtDescripcionTipo.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 56;
            this.label3.Text = "Descripcion ";
            // 
            // FormGestionClaseYTipoVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 576);
            this.Controls.Add(this.btnEliminarTipo);
            this.Controls.Add(this.btnModificarTipo);
            this.Controls.Add(this.btnAgregarTipo);
            this.Controls.Add(this.txtDescripcionTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvTipoVehiculo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEiminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregarVehiculo);
            this.Controls.Add(this.dgvClaseVehiculo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionClaseYTipoVehiculo";
            this.Text = "FormClaseVehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClaseVehiculo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoVehiculo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEiminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregarVehiculo;
        private System.Windows.Forms.DataGridView dgvClaseVehiculo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTipoVehiculo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminarTipo;
        private System.Windows.Forms.Button btnModificarTipo;
        private System.Windows.Forms.Button btnAgregarTipo;
        private System.Windows.Forms.TextBox txtDescripcionTipo;
        private System.Windows.Forms.Label label3;
    }
}
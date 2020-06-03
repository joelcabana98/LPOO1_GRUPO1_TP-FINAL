namespace Vistas
{
    partial class FormVehiculos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.dgwVehiculo = new System.Windows.Forms.DataGridView();
            this.btnEiminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.grBox = new System.Windows.Forms.GroupBox();
            this.rbtnLinea = new System.Windows.Forms.RadioButton();
            this.rbtnMarca = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVehiculo)).BeginInit();
            this.grBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregarVehiculo.FlatAppearance.BorderSize = 0;
            this.btnAgregarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarVehiculo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVehiculo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(206, 13);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(140, 32);
            this.btnAgregarVehiculo.TabIndex = 7;
            this.btnAgregarVehiculo.Text = "Agregar";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = false;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // dgwVehiculo
            // 
            this.dgwVehiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwVehiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwVehiculo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgwVehiculo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 11.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwVehiculo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgwVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwVehiculo.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgwVehiculo.EnableHeadersVisualStyles = false;
            this.dgwVehiculo.Location = new System.Drawing.Point(12, 62);
            this.dgwVehiculo.Name = "dgwVehiculo";
            this.dgwVehiculo.RowHeadersWidth = 18;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgwVehiculo.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgwVehiculo.RowTemplate.Height = 28;
            this.dgwVehiculo.Size = new System.Drawing.Size(1040, 502);
            this.dgwVehiculo.TabIndex = 11;
            // 
            // btnEiminar
            // 
            this.btnEiminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(82)))), ((int)(((byte)(76)))));
            this.btnEiminar.FlatAppearance.BorderSize = 0;
            this.btnEiminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEiminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEiminar.ForeColor = System.Drawing.Color.White;
            this.btnEiminar.Location = new System.Drawing.Point(518, 13);
            this.btnEiminar.Name = "btnEiminar";
            this.btnEiminar.Size = new System.Drawing.Size(140, 32);
            this.btnEiminar.TabIndex = 14;
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
            this.btnModificar.Location = new System.Drawing.Point(362, 13);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(140, 32);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // grBox
            // 
            this.grBox.Controls.Add(this.rbtnLinea);
            this.grBox.Controls.Add(this.rbtnMarca);
            this.grBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBox.Location = new System.Drawing.Point(12, 10);
            this.grBox.Name = "grBox";
            this.grBox.Size = new System.Drawing.Size(178, 34);
            this.grBox.TabIndex = 57;
            this.grBox.TabStop = false;
            this.grBox.Text = "Ordenar por";
            // 
            // rbtnLinea
            // 
            this.rbtnLinea.AutoSize = true;
            this.rbtnLinea.BackColor = System.Drawing.Color.Transparent;
            this.rbtnLinea.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnLinea.ForeColor = System.Drawing.Color.Black;
            this.rbtnLinea.Location = new System.Drawing.Point(97, 11);
            this.rbtnLinea.Name = "rbtnLinea";
            this.rbtnLinea.Size = new System.Drawing.Size(66, 24);
            this.rbtnLinea.TabIndex = 1;
            this.rbtnLinea.TabStop = true;
            this.rbtnLinea.Text = "Linea";
            this.rbtnLinea.UseVisualStyleBackColor = false;
            this.rbtnLinea.CheckedChanged += new System.EventHandler(this.rbtnLinea_CheckedChanged);
            // 
            // rbtnMarca
            // 
            this.rbtnMarca.AutoSize = true;
            this.rbtnMarca.BackColor = System.Drawing.Color.Transparent;
            this.rbtnMarca.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMarca.ForeColor = System.Drawing.Color.Black;
            this.rbtnMarca.Location = new System.Drawing.Point(7, 11);
            this.rbtnMarca.Name = "rbtnMarca";
            this.rbtnMarca.Size = new System.Drawing.Size(77, 24);
            this.rbtnMarca.TabIndex = 0;
            this.rbtnMarca.TabStop = true;
            this.rbtnMarca.Text = "Marca";
            this.rbtnMarca.UseVisualStyleBackColor = false;
            this.rbtnMarca.CheckedChanged += new System.EventHandler(this.rbtnMarca_CheckedChanged);
            // 
            // FormVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 576);
            this.Controls.Add(this.grBox);
            this.Controls.Add(this.btnEiminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgwVehiculo);
            this.Controls.Add(this.btnAgregarVehiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVehiculos";
            this.Text = "FormVehiculos";
            this.Load += new System.EventHandler(this.FormVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwVehiculo)).EndInit();
            this.grBox.ResumeLayout(false);
            this.grBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarVehiculo;
        public System.Windows.Forms.DataGridView dgwVehiculo;
        private System.Windows.Forms.Button btnEiminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox grBox;
        private System.Windows.Forms.RadioButton rbtnLinea;
        private System.Windows.Forms.RadioButton rbtnMarca;
    }
}
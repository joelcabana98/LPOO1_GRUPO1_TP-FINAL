using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FormModalAgregarUsuario : Form
    {
        public FormModalAgregarUsuario()
        {
            InitializeComponent();
        }

        private void FormModalAgregarUsuario_Load(object sender, EventArgs e)
        {
            cargar_combo_Rol();
        }

        /// <summary>
        /// carga los combo box con los roles de la base de datos
        /// </summary>
        private void cargar_combo_Rol() {
            cmbRol.DisplayMember = "rol_descripcion";
            cmbRol.ValueMember = "rol_codigo";
            cmbRol.DataSource = TrabajarUsuario.listar_roles();
            cmbRol.SelectedIndex = -1;
        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Agrega los datos de los campos a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
     

            if (ValidarTextBox() == true)
            {
                Usuario usuario = new Usuario();

                usuario.Usu_NombreUsuario = txtUsuario.Text;
                usuario.Usu_ApellidoNombre = txtApellidoNombre.Text;
                usuario.Usu_Password = Util.GetSHA256(txtContrasena.Text);
                usuario.Rol_Codigo = Convert.ToString(cmbRol.SelectedValue);
                usuario.Usu_Estado = Util.estado.ACTIVO.ToString();

                TrabajarUsuario.insertar_usuario(usuario);


                MessageBox.Show("Usuario Agregado!");
            }
            else
            {
                MessageBox.Show("Complete todo los campos");
            }

        }


        private bool ValidarTextBox()
        {
            bool b = true;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox & c.Text == String.Empty)
                {
                    b = false;
                }
            }

            return b;
        }



    }
}

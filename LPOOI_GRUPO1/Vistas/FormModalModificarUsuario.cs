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
    public partial class FormModalModificarUsuario : Form
    {
        public FormModalModificarUsuario()
        {
            InitializeComponent();

            //deshabilita el campo ID para que no se realizen modificaciones
            txtIdUsuario.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Actualizar: Se agregar los campos modificados o no,
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.Usu_Id = Convert.ToInt32(txtIdUsuario.Text);
            usuario.Usu_NombreUsuario = txtUsuario.Text;
            usuario.Usu_ApellidoNombre = txtApellidoNombre.Text;
            usuario.Usu_Password = txtContrasena.Text;
            usuario.Rol_Codigo = Convert.ToString(cmbRol.SelectedValue);

            TrabajarUsuario.actualizar_usuario(usuario);
        }

    }
}

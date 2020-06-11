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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            //mensaje de error
            lblDatosIncorrectos.Visible = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (TrabajarUsuario.validarUsuario(txtUsuario.Text, Util.GetSHA256(txtPassword.Text)) == true)
            {
                FormPrincipal frPrincipal = new FormPrincipal();
                frPrincipal.Show();
                this.Hide();
            }
            else {
                lblDatosIncorrectos.Visible = true;
            } 
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Al presionar enter se pasa el puntero al siguiente campo de texto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                txtPassword.Focus();
            }
        }

        /// <summary>
        /// Al presionar Enter se realiza las acciones del btnIngresar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                btnIngresar.PerformClick();
            }
        }
    }
}

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
    public partial class FormModalAgregarCliente : Form
    {
        public FormModalAgregarCliente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Guarda los campos en un objeto y los agrega a la base de daatos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (ValidarTextBox() == true)
            {

                Cliente cliente = new Cliente();

                cliente.Cli_Dni = txtDniCliente.Text;
                cliente.Cli_Nombre = txtNombreCliente.Text;
                cliente.Cli_Apellido = txtApellidoCliente.Text;
                cliente.Cli_Direccion = txtDireccionCliente.Text;
                cliente.Cli_Telefono = txtTelefonoCliente.Text;
                cliente.Cli_Estado = Util.estado.ACTIVO.ToString();
                TrabajarCliente.insertar_cliente(cliente);
            }
            else {
                MessageBox.Show("no puede dejar campos sin informacion");
                btnGuardar.DialogResult = DialogResult.None;
            }

        }

        /// <summary>
        /// Valida todo los campos de texto del formluario que estan vacios
        /// </summary>
        /// <returns></returns>
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

        //Metodos , al presionar ENTER se pasa el puntero al siguiente campo de texto

        private void txtDniCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                txtNombreCliente.Focus();
            }
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                txtApellidoCliente.Focus();
            }
        }

        private void txtApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                txtDireccionCliente.Focus();
            }
        }

        private void txtDireccionCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                txtTelefonoCliente.Focus();
            }
        }

        private void txtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                btnGuardar.PerformClick();
            }
            
        }
    }
}

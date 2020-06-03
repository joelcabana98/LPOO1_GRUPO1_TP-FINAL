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
    public partial class FormModalModificarCliente : Form
    {
        public FormModalModificarCliente()
        {
            InitializeComponent();
            txtDniCliente.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        /// <summary>
        /// Actualiza un Cliente , agrega todos los campos modificados o no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.Cli_Dni = txtDniCliente.Text;
            cliente.Cli_Nombre = txtNombreCliente.Text;
            cliente.Cli_Apellido = txtApellidoCliente.Text;
            cliente.Cli_Telefono = txtTelefonoCliente.Text;
            cliente.Cli_Direccion = txtDireccionCliente.Text;

            TrabajarCliente.actualizar_cliente(cliente);
        }
    }
}

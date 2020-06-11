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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

       

        private void FormClientes_Load(object sender, EventArgs e)
        {
            cargar_clientes();
        }


        private void cargar_clientes(){
            dgwClientes.DataSource = TrabajarCliente.listar_Clientes();
        
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

            using (FormModalAgregarCliente modalAgregar = new FormModalAgregarCliente() { })
            {
                //en el modal cliente el btnAgregar tiene el DialogResult.Ok al precionar 
                //se realizan las acciones del boton y se cierra el moda
                if (modalAgregar.ShowDialog() == DialogResult.OK)
                {
                    cargar_clientes();
                }

            }
        }

        private void btnEiminar_Click(object sender, EventArgs e)
        {
            
            Cliente cliente = new Cliente();
            //toma el id del usuario seleccionado de la tabla
            cliente.Cli_Dni = Convert.ToString(dgwClientes.CurrentRow.Cells["DNI"].Value);
            cliente.Cli_Estado = Util.estado.INACTIVO.ToString();
            var confirmResult = MessageBox.Show("¿Seguro que quieres eliminar?",
                                     "¿Eliminar?",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                TrabajarCliente.eliminar_cliente(cliente);
                cargar_clientes();

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (FormModalModificarCliente modalCliente = new FormModalModificarCliente() { })
            {
                pasarDatos(modalCliente);
                //en el modal Cliente el btnActualizar tiene el DialogResult.Ok al precionar 
                //se realizan las acciones del boton y se cierra el moda
                if (modalCliente.ShowDialog() == DialogResult.OK)
                {
                    cargar_clientes();
                }

            }
            
        }

        /// <summary>
        /// Pasa lo datos de la fila seleccionada en el Data Grid al Formluario
        /// Modal Modificar
        /// </summary>
        /// <param name="modalModificarCli"></param>
        private void pasarDatos(FormModalModificarCliente modalModificarCli)
        {
            modalModificarCli.txtDniCliente.Text = Convert.ToString(dgwClientes.CurrentRow.Cells["DNI"].Value);
            modalModificarCli.txtNombreCliente.Text = Convert.ToString(dgwClientes.CurrentRow.Cells["Nombre"].Value);
            modalModificarCli.txtApellidoCliente.Text = Convert.ToString(dgwClientes.CurrentRow.Cells["Apellido"].Value);
            modalModificarCli.txtDireccionCliente.Text = Convert.ToString(dgwClientes.CurrentRow.Cells["Direccion"].Value);
            modalModificarCli.txtTelefonoCliente.Text = Convert.ToString(dgwClientes.CurrentRow.Cells["Telefono"].Value);
        }

        /// <summary>
        /// Buscar cliente por DNI o APELLIDO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if ((txtBuscar.Text != "") && (txtBuscar.Text != "Apellido o Dni") )
            {
                //dgwClientes.DataSource = TrabajarCliente.buscar_clientes(txtBuscar.Text);
                dgwClientes.DataSource = TrabajarCliente.buscar_clientesSP(txtBuscar.Text);
            }
            else
            {
                cargar_clientes();
            }
        }

        //Placeholder
        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            txtBuscar.ForeColor = Color.Black;
        }
        //Placeholder
        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "") {
                txtBuscar.Text = "Apellido o Dni";
                txtBuscar.ForeColor = Color.Silver;
            }
        }

    }
}

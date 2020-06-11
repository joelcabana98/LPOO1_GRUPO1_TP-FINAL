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
    public partial class FormModalAgregarVenta : Form
    {
        public FormModalAgregarVenta()
        {
            InitializeComponent();
        }



        private void FormModalAgregarVenta_Load(object sender, EventArgs e)
        {
            cargar_combo_cliente();
            cargar_combo_vehiculo();
            cargar_combo_pago();
            txtUsuario.Enabled = false;
            txtUsuario.Text = UsuarioLogin.usu_ApellidoNombre;
        }


        /// <summary>
        /// Carga los combos box con los clientes mostrando el NOMBRE + APELLIDO + DNI
        /// </summary>
        private void cargar_combo_cliente()
        {   
            cmbCliente.DisplayMember = "cli_detalle";
            cmbCliente.ValueMember = "cli_dni";
            cmbCliente.DataSource = TrabajarCliente.listar_Clientes_sa();
            cmbCliente.SelectedIndex = -1;

        }

        /// <summary>
        /// Carga el combo box con los vehiculos mostrando MARCA + LINEA + MODELO
        /// </summary>
        private void cargar_combo_vehiculo()
        {
            cmbVehiculo.DisplayMember = "veh_detalle";
            cmbVehiculo.ValueMember = "Matricula";
            cmbVehiculo.DataSource = TrabajarVehiculo.listar_Vehiculo();
            cmbVehiculo.SelectedIndex = -1; 

        }

        /// <summary>
        /// Carga el combo box de forma de pagos
        /// </summary>
        private void cargar_combo_pago() {

            cmbFormaPago.DisplayMember = "Descripcion";
            cmbFormaPago.ValueMember = "Id";
            cmbFormaPago.DataSource = TrabajarVenta.listar_forma_pago();
            cmbFormaPago.SelectedIndex = -1;
            cmbFormaPago.Text = "--Seleccione Forma de Pago";
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Agrega el Precio del Vehiculo seleccionado al campo de PRECIO FINAL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVehiculo_SelectionChangeCommitted(object sender, EventArgs e)
        {    
            //obtiene la matricula del vehiculo seleccionado
            String matricula = Convert.ToString(cmbVehiculo.SelectedValue);
            //busca el precio del vehiculo seleccionado y lo muestra en el campo Precio Final
            txtPrecioFinal.Text = Convert.ToString(TrabajarVehiculo.precioDeVehiculoSP(matricula));
        }


        /// <summary>
        /// Agrega una venta a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {   const string estadoVenta = "CONFIRMADO";


        if (cmbVehiculo.SelectedValue == null || cmbFormaPago.SelectedValue == null || cmbCliente.SelectedValue == null || cmbCliente.SelectedValue == null)
            {

                MessageBox.Show("Complete todos los campos");
            }
            else {
                Venta venta = new Venta();

                venta.Cli_Dni = Convert.ToString(cmbCliente.SelectedValue);
                venta.Veh_Matricula = Convert.ToString(cmbVehiculo.SelectedValue);
                venta.Vta_FormaPago = Convert.ToString(cmbFormaPago.SelectedValue);
                venta.Vta_Fecha = dtFecha.Value;
                venta.Vta_PrecioFinal = Convert.ToDecimal(txtPrecioFinal.Text);
                venta.Usu_Id = UsuarioLogin.usu_Id;
                venta.Vta_Estado = estadoVenta;
                TrabajarVenta.insertar_venta(venta);
            
            }
        }

        private void cmbVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}

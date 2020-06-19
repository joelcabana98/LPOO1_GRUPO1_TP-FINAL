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
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
            btnAnularVenta.Enabled = false;
            
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            filtroDinamico();
            carga_combo_marca();
            cargar_Combo_ClientesSP();
            cargar_combo_estado_venta();



            dtDesde.Value = dtHasta.Value;
            dtDesde.Value = dtDesde.Value.AddDays(-7);
        }
        private void cargar_Combo_ClientesSP() {
            cmbCliente.DisplayMember = "cli_detalle";
            cmbCliente.ValueMember = "cli_dni";
            cmbCliente.DataSource = TrabajarCliente.listar_Clientes_SP();
            cmbCliente.SelectedIndex = -1;
        }


        /// <summary>
        /// Abre el Formulario Modal de Venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            using (FormModalAgregarVenta modalVenta = new FormModalAgregarVenta() { })
            {
                //en el modal venta el btnAgregar tiene el DialogResult.Ok al precionar 
                //se realizan las acciones del boton y se cierra el moda
                if (modalVenta.ShowDialog() == DialogResult.OK)
                {
                    //se carga la tabla nuevamente (Actualizada)
                    filtroDinamico();
                }

            }
        }



        private void carga_combo_marca() {
            cmbMarca.DisplayMember = "mar_nombre";
            cmbMarca.ValueMember = "mar_id";
            cmbMarca.DataSource = TrabajarVehiculo.listar_marca();
            cmbMarca.SelectedIndex = -1;
        }


        private void cmbCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filtroDinamico();
        }

        private void cmbMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filtroDinamico();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string estado = Convert.ToString(dataGridView1.CurrentRow.Cells["Estado"].Value);
            if (estado == "CONFIRMADO")
            {
                btnAnularVenta.Enabled = true;
            }
            else if(estado=="ANULADA")
            {
                btnAnularVenta.Enabled = false;
            }
        }

        private void btnAnularVenta_Click(object sender, EventArgs e)
        {
            int ventaId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID Venta"].Value);
            if (MessageBox.Show("¿Desea ANULAR la Venta ID: "+ventaId+"?", "Anular venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Anular venta
                TrabajarVenta.modificar_estado_venta(ventaId, "ANULADA");
                MessageBox.Show("Venta ANULADA","Mensaje");
                //Se actualiza la tabla
                filtroDinamico(); 
            }
        }

        private void dtDesde_ValueChanged(object sender, EventArgs e)
        {

            filtroDinamico();
        }

        private void dtHasta_ValueChanged(object sender, EventArgs e)
        {
            filtroDinamico();
        }

        private void filtroDinamico() {
            Console.Write("hasta: " + dtHasta.Value);
            string dni = Convert.ToString(cmbCliente.SelectedValue);
            DateTime desde = dtDesde.Value;
            DateTime hasta = dtHasta.Value;
            string idMarca = Convert.ToString(cmbMarca.SelectedValue);
            string estado = Convert.ToString(cbxEstadoVenta.SelectedValue);

            dataGridView1.DataSource = TrabajarVenta.filtrar_ventas_Dinamica(dni, idMarca, desde, hasta,estado); 
            
            //Cargar contadores
            DataTable dt = TrabajarVenta.obtener_total_cantidad_ventas_dinamica(dni, idMarca, desde, hasta);
            lblCantVentas.Text = Convert.ToString(dt.Rows[0].Field<int>("cant"));
            lblTotalVenta.Text = "$ " + Convert.ToString(dt.Rows[0][0]);
            //lblCantVentas.Text = "$ " + dt.Rows[0].Field<Decimal>("total").ToString();
            lblVentasAnuladas.Text = Convert.ToString(dt.Rows[0][2]);
            lblVentasConfirmadas.Text = Convert.ToString(dt.Rows[0][3]);
        }

        private void cargar_combo_estado_venta() {
            cbxEstadoVenta.DisplayMember = "Text";
            cbxEstadoVenta.ValueMember = "Value";
            var items = new[] {
                new { Text = "CONFIRMADO", Value = "CONFIRMADO" },
                new { Text = "ANULADA", Value = "ANULADA" }
            };

            cbxEstadoVenta.DataSource = items;
            cbxEstadoVenta.SelectedIndex = -1;
        }

        private void cbxEstadoVenta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filtroDinamico();
        }
    }
}

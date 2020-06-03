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
    public partial class FormGestionFormaPago : Form
    {
        public FormGestionFormaPago()
        {
            InitializeComponent();
            cargarTabla();
        }


        private void cargarTabla()
        {
            dgvFormaPago.DataSource = TrabajarVenta.listar_forma_pago();

        }

        private void deshabilitarBotones()
        {
            btnModificar.Enabled = false;
            btnEiminar.Enabled = false;
            btnAgregarVehiculo.Enabled = true;
        }

        private void habilitarBotones()
        {
            btnModificar.Enabled = true;
            btnEiminar.Enabled = true;
            btnAgregarVehiculo.Enabled = false;
        }
        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text;
            TrabajarVenta.insertar_forma_pago(descripcion);
            cargarTabla();
            txtDescripcion.Text = null;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text;
            int id = Convert.ToInt32(dgvFormaPago.CurrentRow.Cells["Id"].Value);
            TrabajarVenta.actualizar_forma_pago(id,descripcion);
            txtDescripcion.Text = null;
            deshabilitarBotones();
            cargarTabla();
        }

        private void dgvFormaPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDescripcion.Text = Convert.ToString(dgvFormaPago.CurrentRow.Cells["Descripcion"].Value);
            habilitarBotones();
        }

        private void btnEiminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvFormaPago.CurrentRow.Cells["Id"].Value);
            TrabajarVenta.eliminar_forma_pago(id);
            txtDescripcion.Text = null;
            cargarTabla();
        }





    }
}

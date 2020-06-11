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

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == null || txtDescripcion.Text == null)
            {
                string descripcion = txtDescripcion.Text;
                TrabajarVenta.insertar_forma_pago(descripcion);
                cargarTabla();
                txtDescripcion.Text = null;

            }
            else {
                MessageBox.Show("No puede haber campos vacios");
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           

            if (txtDescripcion.Text == null || txtDescripcion.Text == "")
            {
                MessageBox.Show("No puede haber campos vacios");
            }
            else
            {

                var confirmResult = MessageBox.Show("¿Seguro que quieres Modificar?",
                                     "¿Modificar?",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    string descripcion = txtDescripcion.Text;
                    int id = Convert.ToInt32(dgvFormaPago.CurrentRow.Cells["Id"].Value);
                    TrabajarVenta.actualizar_forma_pago(id, descripcion);
                    txtDescripcion.Text = null;
                    cargarTabla();

                }

            }
        }

        private void dgvFormaPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDescripcion.Text = Convert.ToString(dgvFormaPago.CurrentRow.Cells["Descripcion"].Value);
        }

        private void btnEiminar_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("¿Seguro que quieres eliminar?",
                                    "¿Eliminar?",
                                    MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvFormaPago.CurrentRow.Cells["Id"].Value);
                TrabajarVenta.eliminar_forma_pago(id);
                txtDescripcion.Text = null;
                cargarTabla();
            }


           
        }





    }
}

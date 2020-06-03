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
    public partial class FormGestionClaseYTipoVehiculo : Form
    {
        public FormGestionClaseYTipoVehiculo()
        {
            InitializeComponent();
            cargarTabla();
            cargarTablaTipoVehiculo();
        }


        private void cargarTabla()
        {
            dgvClaseVehiculo.DataSource = TrabajarVehiculo.listar_clase_vehiculo();

        }

        private void cargarTablaTipoVehiculo()
        {
            dgvTipoVehiculo.DataSource = TrabajarVehiculo.listar_tipo_vehiculo();

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
            if (txtDescripcion.Text == null || txtDescripcion.Text == "")
            {
                MessageBox.Show("No puede haber campos vacios");
            }
            else {
                TrabajarVehiculo.insertar_clase_Vehiculo(descripcion);
                cargarTabla();
                txtDescripcion.Text = null;
            }
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (txtDescripcion.Text == null || txtDescripcion.Text == "")
            {
                MessageBox.Show("No puede haber campos vacios");
            }
            else {

                var confirmResult = MessageBox.Show("¿Seguro que quieres Modificar?",
                                     "¿Modificar?",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    string descripcion = txtDescripcion.Text;
                    int id = Convert.ToInt32(dgvClaseVehiculo.CurrentRow.Cells["Id"].Value);
                    TrabajarVehiculo.actualizar_clase_vehiculo(id, descripcion);
                    txtDescripcion.Text = null;
                    deshabilitarBotones();
                    cargarTabla();
                }
                
            }
            
        }

        private void btnEiminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvClaseVehiculo.CurrentRow.Cells["Id"].Value);

            var confirmResult = MessageBox.Show("¿Seguro que quieres eliminar?",
                                     "¿Eliminar?",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                TrabajarVehiculo.eliminar_clase_Vehiculo(id);
                txtDescripcion.Text = null;
                cargarTabla();
            }
            
           
        }

        private void dgvClaseVehiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDescripcion.Text = Convert.ToString(dgvClaseVehiculo.CurrentRow.Cells["Descripcion"].Value);
            habilitarBotones();
        }

        private void btnAgregarTipo_Click(object sender, EventArgs e)
        {
            if (txtDescripcionTipo.Text == null || txtDescripcionTipo.Text == "")
            {
                MessageBox.Show("No puede haber campos vacios");
            }
            else
            {
                string descripcion = txtDescripcionTipo.Text;
                TrabajarVehiculo.insertar_tipo_Vehiculo(descripcion);
                cargarTablaTipoVehiculo();
                txtDescripcionTipo.Text = null;
            }
       }

        private void btnModificarTipo_Click(object sender, EventArgs e)
        {
            if (txtDescripcionTipo.Text == null || txtDescripcionTipo.Text == "")
            {
                MessageBox.Show("No puede haber campos vacios");

            }
            else {
                var confirmResult = MessageBox.Show("¿Seguro que quieres Modificar?",
                                    "¿Modificar?",
                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    string descripcion = txtDescripcionTipo.Text;
                    int id = Convert.ToInt32(dgvTipoVehiculo.CurrentRow.Cells["Id"].Value);
                    TrabajarVehiculo.actualizar_tipo_vehiculo(id, descripcion);
                    txtDescripcionTipo.Text = null;
                    cargarTablaTipoVehiculo();
                }

               
            }

           
        }

        private void btnEliminarTipo_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvTipoVehiculo.CurrentRow.Cells["Id"].Value);

            var confirmResult = MessageBox.Show("¿Seguro que quieres eliminar?",
                                     "¿Eliminar?",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                TrabajarVehiculo.eliminar_tipo_Vehiculo(id);
                txtDescripcionTipo.Text = null;
                cargarTablaTipoVehiculo();
            }
            
            
        }

        private void dgvTipoVehiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDescripcionTipo.Text = Convert.ToString(dgvTipoVehiculo.CurrentRow.Cells["Descripcion"].Value);
        }



    }
}

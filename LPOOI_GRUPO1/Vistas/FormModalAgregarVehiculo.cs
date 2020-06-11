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
    public partial class FormModalAgregarVehiculo : Form
    {
        public FormModalAgregarVehiculo()
        {
            InitializeComponent();
        }

         private void FormModalAgregarVehiculo_Load(object sender, EventArgs e)
        {
            cargar_combo_marca();
            cargar_combo_Tipo_Vehiculo();
            cargar_combo_Clase_Vehiculo();
        }

        //ELIMINAR ESTOS METODOS

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLinea_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClaseVehiculo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTipoVehiculo_TextChanged(object sender, EventArgs e)
        {

        }

        //HASTA AQUI
        private void cargar_combo_marca() {
            cmbMarca.DisplayMember = "mar_nombre";
            cmbMarca.ValueMember = "mar_id";
            cmbMarca.DataSource = TrabajarVehiculo.listar_marca();
            cmbMarca.SelectedIndex = -1;
        }

        private void cargar_combo_linea(int id_marca)
        {
            cmbLinea.DisplayMember = "lin_nombre";
            cmbLinea.ValueMember = "lin_id";
            cmbLinea.DataSource = TrabajarVehiculo.listar_linea(id_marca);
            cmbLinea.SelectedIndex = -1;
        }
        private void cargar_combo_Tipo_Vehiculo() {
            cmbTipoVehiculo.DisplayMember = "Descripcion";
            cmbTipoVehiculo.ValueMember = "Id";
            cmbTipoVehiculo.DataSource = TrabajarVehiculo.listar_tipo_vehiculo();
            cmbTipoVehiculo.SelectedIndex = -1;
        }


        private void cargar_combo_Clase_Vehiculo()
        {
            cmbClaseVehiculo.DisplayMember = "Descripcion";
            cmbClaseVehiculo.ValueMember = "Id";
            cmbClaseVehiculo.DataSource = TrabajarVehiculo.listar_clase_vehiculo();
            cmbClaseVehiculo.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Agrega los datos de los campos a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (cmbClaseVehiculo.SelectedValue == null || cmbLinea.SelectedValue == null || cmbMarca.SelectedValue == null || cmbTipoVehiculo.SelectedValue == null || txtMatricula == null)
            {

                MessageBox.Show("Complete todos los campos");


            }
            else {
                var confirmResult = MessageBox.Show("¿Seguro que quieres guardar?",
                                       "¿Guardar?",
                                       MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    Vehiculo vehiculo = new Vehiculo();
                    vehiculo.Veh_Matricula = txtMatricula.Text;
                    vehiculo.Veh_Marca = Convert.ToString(cmbMarca.SelectedValue);
                    vehiculo.Veh_Linea = Convert.ToString(cmbLinea.SelectedValue);
                    vehiculo.Veh_Modelo = txtModelo.Text;
                    vehiculo.Veh_Color = txtColor.Text;
                    vehiculo.Veh_Puertas = Convert.ToInt32(txtPuertas.Text);

                    if (rbtnSi.Checked == true)
                    {
                        vehiculo.Veh_Gps = true;
                    }
                    else
                    {
                        if (rbtnNo.Checked == true)
                        {
                            vehiculo.Veh_Gps = false;
                        }
                    }
                    vehiculo.Veh_TipoVehiculo = Convert.ToString(cmbTipoVehiculo.SelectedValue);
                    vehiculo.Veh_ClaseVehiulo = Convert.ToString(cmbClaseVehiculo.SelectedValue);
                    vehiculo.Veh_Precio = Convert.ToDecimal(txtPrecio.Text);
                    vehiculo.Veh_Estado = Util.estado.ACTIVO.ToString();

                    TrabajarVehiculo.insertar_vehiculo(vehiculo);
                }
            
            }

            
        }

 
        //METODOS, al presionar ENTER se pasa el puntero al siguiente campo de texto

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                //txtMarca.Focus();
            }
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
               // txtLinea.Focus();
            }
        }

        private void txtLinea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                txtModelo.Focus();
            }
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                txtColor.Focus();
            }
        }

        private void txtColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                txtPuertas.Focus();
            }
        }

        private void txtPuertas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                //txtTipoVehiculo.Focus();
            }
        }

        private void txtTipoVehiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                //txtClaseVehiculo.Focus();
            }
        }

        private void txtClaseVehiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                txtPrecio.Focus();
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                btnGuardar.PerformClick();
            }
        }

        private void cmbMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbMarca.SelectedValue.ToString());
            cargar_combo_linea(id);
        }

       
    }
}

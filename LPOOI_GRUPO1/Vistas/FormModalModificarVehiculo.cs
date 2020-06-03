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
    public partial class FormModalModificarVehiculo : Form
    {
        public FormModalModificarVehiculo()
        {
            InitializeComponent();
            //deshabilita el campo Matricula para que no se realizen modificaciones
            txtMatricula.Enabled = false;
        }

        /// <summary>
        /// Actualiza: agrega todos los datos de los campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Veh_Matricula = txtMatricula.Text;
            vehiculo.Veh_Marca = Convert.ToString(cmbMarca.SelectedValue);
            vehiculo.Veh_Linea = Convert.ToString(cmbLinea.SelectedValue);
            vehiculo.Veh_Modelo = txtModelo.Text;
            vehiculo.Veh_Color = txtColor.Text;
            vehiculo.Veh_Puertas = Convert.ToInt32(txtPuertas.Text);

            if (rbtnSiGps.Checked == true)
            {
                vehiculo.Veh_Gps = true;
            }
            else
            {
                if (rbtnNoGps.Checked == true)
                {
                    vehiculo.Veh_Gps = false;
                }
            }

            vehiculo.Veh_TipoVehiculo = Convert.ToString(cmbTipoVehiculo.SelectedValue);
            vehiculo.Veh_ClaseVehiulo = Convert.ToString(cmbClaseVehiculo.SelectedValue);
            vehiculo.Veh_Precio = Convert.ToDecimal(txtPrecio.Text);

            TrabajarVehiculo.actualizar_vehiculo(vehiculo);

        }

        /// <summary>
        /// Cierra el Formulario de Modificacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbMarca.SelectedValue.ToString());
            cargar_combo_linea(id);
        }

        private void cargar_combo_linea(int id_marca)
        {
            cmbLinea.DisplayMember = "lin_nombre";
            cmbLinea.ValueMember = "lin_id";
            cmbLinea.DataSource = TrabajarVehiculo.listar_linea(id_marca);
        }


    }
}

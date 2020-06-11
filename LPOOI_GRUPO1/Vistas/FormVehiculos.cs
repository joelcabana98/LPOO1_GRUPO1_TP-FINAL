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
    public partial class FormVehiculos : Form
    {
        public FormVehiculos()
        {
            InitializeComponent();
        }

        private void FormVehiculos_Load(object sender, EventArgs e)
        {
            cargar_vehiculos();
        }

        private void cargar_vehiculos() {
            dgwVehiculo.DataSource = TrabajarVehiculo.listar_VehiculoTabla();
        }


        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            
            
            using (FormModalAgregarVehiculo modalVehiculo = new FormModalAgregarVehiculo() { })
            {
                //en el modal vehiculo el btnAgregar tiene el DialogResult.Ok al precionar 
                //se realizan las acciones del boton y se cierra el moda
                if (modalVehiculo.ShowDialog() == DialogResult.OK)
                {
                    //lista los vehiculos (actualizado)
                    cargar_vehiculos();  
                }

            }
        }

        /// <summary>
        /// Eliminar un registro por su MATRICULA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEiminar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo();
            //toma la matricula de la fila seleccionada
            vehiculo.Veh_Matricula = Convert.ToString(dgwVehiculo.CurrentRow.Cells["Matricula"].Value);
            var confirmResult = MessageBox.Show("¿Seguro que quieres eliminar?",
                                     "¿Eliminar?",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)

            {
                vehiculo.Veh_Estado = Util.estado.INACTIVO.ToString();
                TrabajarVehiculo.eliminar_Vehiculo(vehiculo);
                cargar_vehiculos();

            }
        }


        /// <summary>
        /// Modificar: abre el formulario para Modificar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (FormModalModificarVehiculo modalModificarVeh = new FormModalModificarVehiculo() { })
            {
       
                pasarDatos(modalModificarVeh);
                //en el modal Vehiculo el btnAgregar tiene el DialogResult.Ok al precionar 
                //se realizan las acciones del boton y se cierra el moda
                if (modalModificarVeh.ShowDialog() == DialogResult.OK)
                {
                    cargar_vehiculos();
                }

            }
        }


       /// <summary>
       /// Pasa los datos de la fila seleccionada en el Data Grid a los campos del
       /// formulario Modal Modificar
       /// </summary>
       /// <param name="modalModificarVeh"></param>
        private void pasarDatos(FormModalModificarVehiculo modalModificarVeh)
        {

            modalModificarVeh.txtMatricula.Text = Convert.ToString(dgwVehiculo.CurrentRow.Cells["Matricula"].Value);
            
            modalModificarVeh.cmbMarca.DisplayMember = "mar_nombre";
            modalModificarVeh.cmbMarca.ValueMember = "mar_id";
            modalModificarVeh.cmbMarca.DataSource = TrabajarVehiculo.listar_marca();
            modalModificarVeh.cmbMarca.SelectedIndex = Convert.ToInt32(dgwVehiculo.CurrentRow.Cells["mar_id"].Value) - 1;

            modalModificarVeh.cmbLinea.DisplayMember = "lin_nombre";
            modalModificarVeh.cmbLinea.ValueMember = "lin_id";
            int id = Convert.ToInt32(modalModificarVeh.cmbMarca.SelectedValue.ToString());
            modalModificarVeh.cmbLinea.DataSource = TrabajarVehiculo.listar_linea(id);
           


            modalModificarVeh.txtModelo.Text = Convert.ToString(dgwVehiculo.CurrentRow.Cells["Modelo"].Value);
            modalModificarVeh.txtColor.Text = Convert.ToString(dgwVehiculo.CurrentRow.Cells["Color"].Value);
            modalModificarVeh.txtPuertas.Text = Convert.ToString(dgwVehiculo.CurrentRow.Cells["Puertas"].Value);
            if (Convert.ToBoolean(dgwVehiculo.CurrentRow.Cells["Gps"].Value) == true)
            {
                modalModificarVeh.rbtnSiGps.Checked = true;
            }
            else {
                modalModificarVeh.rbtnNoGps.Checked = true;
            }


            modalModificarVeh.cmbClaseVehiculo.DisplayMember = "Descripcion";
            modalModificarVeh.cmbClaseVehiculo.ValueMember = "Id";
            modalModificarVeh.cmbClaseVehiculo.DataSource = TrabajarVehiculo.listar_clase_vehiculo();
            modalModificarVeh.cmbClaseVehiculo.SelectedValue = Convert.ToInt32(dgwVehiculo.CurrentRow.Cells["cv_id"].Value);


            modalModificarVeh.cmbTipoVehiculo.DisplayMember = "Descripcion";
            modalModificarVeh.cmbTipoVehiculo.ValueMember = "Id";
            modalModificarVeh.cmbTipoVehiculo.DataSource = TrabajarVehiculo.listar_tipo_vehiculo();
            modalModificarVeh.cmbTipoVehiculo.SelectedValue = Convert.ToInt32(dgwVehiculo.CurrentRow.Cells["tv_id"].Value);
            modalModificarVeh.txtPrecio.Text = Convert.ToString(dgwVehiculo.CurrentRow.Cells["Precio"].Value);
        
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string campo = null;
            if (rbtnLinea.Checked == true)
            {
                campo = "Linea";
            }
            else
            {
                if (rbtnMarca.Checked == true)
                {
                    campo = "Marca";
                }
            }

           dgwVehiculo.DataSource=TrabajarVehiculo.listar_Vehiculos_OrdenSP(campo);

        }

        private void rbtnMarca_CheckedChanged(object sender, EventArgs e)
        {
            string campo = "Marca";
            dgwVehiculo.DataSource = TrabajarVehiculo.listar_Vehiculos_OrdenSP(campo);
        }

        private void rbtnLinea_CheckedChanged(object sender, EventArgs e)
        {
            string campo = "Linea";
            dgwVehiculo.DataSource = TrabajarVehiculo.listar_Vehiculos_OrdenSP(campo);
        }
      
    }
}

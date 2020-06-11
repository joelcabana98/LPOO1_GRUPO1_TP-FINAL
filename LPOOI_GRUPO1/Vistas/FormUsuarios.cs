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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
            
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            cargar_usuarios();
            btnModificar.Visible = false;
            btnEiminar.Visible = false;
        }

        private void cargar_usuarios() {
            
            dgwUsuarios.DataSource = TrabajarUsuario.listar_Usuario();
        }

    

        //evento al hacer click en una celda
        private void dgwUsuarios_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwUsuarios.CurrentCell != null) {
                btnModificar.Visible = true;
                btnEiminar.Visible = true;
            }
        }

        private void btnEiminar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            //toma el id del usuario seleccionado de la tabla
            usuario.Usu_Id = Convert.ToInt32(dgwUsuarios.CurrentRow.Cells["usu_id"].Value);
            var confirmResult = MessageBox.Show("¿Seguro que quieres eliminar?",
                                     "¿Eliminar?",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                usuario.Usu_Estado = Util.estado.INACTIVO.ToString();
                TrabajarUsuario.eliminar_usuario(usuario);
                cargar_usuarios();
 
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            
            using (FormModalModificarUsuario modalModificarUsu = new FormModalModificarUsuario() { })
            {
                pasarDatos(modalModificarUsu);
                //en el modal venta el btnActualizar tiene el DialogResult.Ok al precionar 
                //se realizan las acciones del boton y se cierra el moda
                if (modalModificarUsu.ShowDialog() == DialogResult.OK)
                {
                    cargar_usuarios();
                }

            }
            
        }

        /// <summary>
        /// Pasa los datos de una fila seleccionada en el Data Grid a los campos 
        /// del formulario Modal Modificar
        /// </summary>
        /// <param name="modalModificarUsu"></param>
        private void pasarDatos(FormModalModificarUsuario modalModificarUsu) {
            
            modalModificarUsu.txtIdUsuario.Text = Convert.ToString(dgwUsuarios.CurrentRow.Cells["usu_id"].Value);
            modalModificarUsu.txtUsuario.Text = Convert.ToString(dgwUsuarios.CurrentRow.Cells["Usuario"].Value);
            modalModificarUsu.txtContrasena.Text = Convert.ToString(dgwUsuarios.CurrentRow.Cells["Contraseña"].Value);
            modalModificarUsu.txtApellidoNombre.Text = Convert.ToString(dgwUsuarios.CurrentRow.Cells["Nombre y Apellido"].Value);

            modalModificarUsu.cmbRol.DisplayMember = "rol_descripcion";
            modalModificarUsu.cmbRol.ValueMember = "rol_codigo";
            modalModificarUsu.cmbRol.DataSource = TrabajarUsuario.listar_roles();

            modalModificarUsu.cmbRol.SelectedIndex = Convert.ToInt32(dgwUsuarios.CurrentRow.Cells["rol_codigo"].Value) - 1;
        
        }


        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            using (FormModalAgregarUsuario modalUsuario = new FormModalAgregarUsuario() { })
            {
                //en el modal Usuario el btnAgregar tiene el DialogResult.Ok al precionar 
                //se realizan las acciones del boton y se cierra el moda
                if (modalUsuario.ShowDialog() == DialogResult.OK)
                {
                    cargar_usuarios();
                }

            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if( (txtBuscar.Text != "") && (txtBuscar.Text != "Nombre de Usuario") ){
                dgwUsuarios.DataSource = TrabajarUsuario.buscar_usuarios(txtBuscar.Text);
            
            }else{
                cargar_usuarios();
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
                txtBuscar.Text = "Nombre de Usuario";
                txtBuscar.ForeColor = Color.Silver;
            }
        }     
    }
}

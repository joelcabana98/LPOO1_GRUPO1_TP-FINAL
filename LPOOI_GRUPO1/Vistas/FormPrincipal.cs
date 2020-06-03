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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            restriccionAcceso();
            personalizar();
            
        }

        private void personalizar()
        {
            pnlSubMenuVehiculo.Visible = false;
            pnlSubMenuVentas.Visible = false;
        }

        private void ocultarSubMenu() { 
           if(pnlSubMenuVentas.Visible == true){
               pnlSubMenuVentas.Visible = false;
              }
           if( pnlSubMenuVehiculo.Visible == true){
                pnlSubMenuVehiculo.Visible = false;
              }
        }

        private void mostrarSubMenu(Panel subMenu) {
            if (subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        
        
        }

    

        /// <summary>
        /// Valida el tipo de usuario para habilitar o deshabilitar
        /// </summary>
        private void restriccionAcceso()
        {
            lblNombreUsuario.Text = UsuarioLogin.usu_ApellidoNombre;
           
            //1 - Administrador
            //2 - Vendedor
            //3 - Auditor
            if (UsuarioLogin.rol_Codigo == "1")
            {
                btnClientes.Visible = false;
                btnVentas.Visible = false;

                lblRol.Text = "Administrador";
              
            }
            else {
                if (UsuarioLogin.rol_Codigo == "2")
                {
                    btnVehiculos.Visible = false;
                    btnUsuarios.Visible = false;

                    lblRol.Text = "Vendedor";
                }
                else {
                    lblRol.Text = "Auditor";
                }
            }
        }



      
        /// <summary>
        /// Abre cualquier formulario dentro del contenedor principal
        /// </summary>
        /// <param name="form"></param>
        private void abrirFormulario(object form)
        {
            if (this.pnlContenedor.Controls.Count > 0)
            {
                this.pnlContenedor.Controls.RemoveAt(0);
            }

            Form formulario = form as Form;
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(formulario);
            this.pnlContenedor.Tag = formulario;
            formulario.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        { 
            abrirFormulario(new FormClientes());
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormVehiculos());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Seguro que quieres salir?",
                                     "¿Salir?",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormUsuarios());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormVentas());
        }

        private void pnlMenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlSubMenuVentas);
        }

        private void btnGestorVentas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormVentas());
        }

        private void btnGestorFormaPago_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormGestionFormaPago());
        }

        private void btnVehiculos_Click_1(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlSubMenuVehiculo);
        }

        private void btnGestorVehiculo_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormVehiculos());
        }

        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            abrirFormulario(new FormUsuarios());
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            abrirFormulario(new FormClientes());
        }

        private void tbnGes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormGestionClaseYTipoVehiculo());
        }

        

       

        

    }
}

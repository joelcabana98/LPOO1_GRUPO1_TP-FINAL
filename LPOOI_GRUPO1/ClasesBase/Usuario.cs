using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private int usu_Id;
        private string usu_NombreUsuario;
        private string usu_Password;
        private string usu_ApellidoNombre;
        private string rol_Codigo;
        private string usu_Estado;

        public Usuario() { }
       
        
        public int Usu_Id
        {
            get { return usu_Id; }
            set { usu_Id = value; }
        }
        public string Usu_NombreUsuario
        {
            get { return usu_NombreUsuario; }
            set { usu_NombreUsuario = value; }
        }
        public string Usu_Password
        {
            get { return usu_Password; }
            set { usu_Password = value; }
        }
        public string Usu_ApellidoNombre
        {
            get { return usu_ApellidoNombre; }
            set { usu_ApellidoNombre = value; }
        }
        public string Rol_Codigo
        {
            get { return rol_Codigo; }
            set { rol_Codigo = value; }
        }

        public string Usu_Estado
        {
            get { return usu_Estado; }
            set { usu_Estado = value; }
        }





    }
}

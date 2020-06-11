using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cliente
    {
        private string cli_Dni;
        private string cli_Nombre;
        private string cli_Apellido;
        private string cli_Direccion;
        private string cli_Telefono;
        private string cli_Estado;


        public Cliente() { }
    
        public string Cli_Dni
        {
            get { return cli_Dni; }
            set { cli_Dni = value; }
        }
        public string Cli_Nombre
        {
            get { return cli_Nombre; }
            set { cli_Nombre = value; }
        }

        public string Cli_Apellido
        {
            get { return cli_Apellido; }
            set { cli_Apellido = value; }
        }
        public string Cli_Direccion
        {
            get { return cli_Direccion; }
            set { cli_Direccion = value; }
        }
        public string Cli_Telefono
        {
            get { return cli_Telefono; }
            set { cli_Telefono = value; }
        }

        public string Cli_Estado
        {
            get { return cli_Estado; }
            set { cli_Estado = value; }
        }

        public override string ToString()
        {
            return "Dni : " + cli_Dni + "  \n" +
                   "Nombre : " + cli_Nombre + "  \n" +
                   "Apellido : " + cli_Apellido + "  \n" +
                   "Direccion : " + cli_Direccion + "  \n" +
                   "Telefono : " + cli_Telefono;
        }
    }
}

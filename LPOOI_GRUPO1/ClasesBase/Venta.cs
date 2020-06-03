using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Venta
    {
        private int vta_Id;
        private string cli_Dni;
        private string veh_Matricula;
        private int usu_Id;
        private DateTime vta_Fecha;
        private string vta_FormaPago;
        private decimal vta_PrecioFinal;
        private string vta_Estado;

        public Venta() { }

        public int Vta_Id
        {
            get { return vta_Id; }
            set { vta_Id = value; }
        }
        public string Cli_Dni
        {
            get { return cli_Dni; }
            set { cli_Dni = value; }
        }
        public string Veh_Matricula
        {
            get { return veh_Matricula; }
            set { veh_Matricula = value; }
        }
        public int Usu_Id
        {
            get { return usu_Id; }
            set { usu_Id = value; }
        }
        public DateTime Vta_Fecha
        {
            get { return vta_Fecha; }
            set { vta_Fecha = value; }
        }
        public string Vta_FormaPago
        {
            get { return vta_FormaPago; }
            set { vta_FormaPago = value; }
        }
        public decimal Vta_PrecioFinal
        {
            get { return vta_PrecioFinal; }
            set { vta_PrecioFinal = value; }
        }


        public string Vta_Estado
        {
            get { return vta_Estado; }
            set { vta_Estado = value; }
        }
    }
}

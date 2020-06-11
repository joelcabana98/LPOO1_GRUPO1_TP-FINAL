using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Vehiculo
    {
        private string veh_Matricula;
        private string veh_Marca;
        private string veh_Linea;
        private string veh_Modelo;
        private string veh_Color;
        private int veh_Puertas;
        private bool veh_Gps;
        private string veh_TipoVehiculo;
        private string veh_ClaseVehiulo;
        private decimal veh_Precio;
        private string veh_Estado;

        public Vehiculo() { }


        public string Veh_Matricula
        {
            get { return veh_Matricula; }
            set { veh_Matricula = value; }
        }
        public string Veh_Marca
        {
            get { return veh_Marca; }
            set { veh_Marca = value; }
        }
        public string Veh_Linea
        {
            get { return veh_Linea; }
            set { veh_Linea = value; }
        }
        public string Veh_Modelo
        {
            get { return veh_Modelo; }
            set { veh_Modelo = value; }
        }
        public string Veh_Color
        {
            get { return veh_Color; }
            set { veh_Color = value; }
        }
        public int Veh_Puertas
        {
            get { return veh_Puertas; }
            set { veh_Puertas = value; }
        }
        public bool Veh_Gps
        {
            get { return veh_Gps; }
            set { veh_Gps = value; }
        }
        public string Veh_TipoVehiculo
        {
            get { return veh_TipoVehiculo; }
            set { veh_TipoVehiculo = value; }
        }
        public string Veh_ClaseVehiulo
        {
            get { return veh_ClaseVehiulo; }
            set { veh_ClaseVehiulo = value; }
        }
        public decimal Veh_Precio
        {
            get { return veh_Precio; }
            set { veh_Precio = value; }
        }

        public string Veh_Estado
        {
            get { return veh_Estado; }
            set { veh_Estado = value; }
        }

        public override string ToString()
        {
            return "Matricula : " + veh_Matricula + "  \n" +
                   "Marca : " + veh_Marca + "  \n" +
                   "Linea : " + veh_Linea + "  \n" +
                   "Modelo : " + veh_Modelo + "  \n" +
                   "Color : " + veh_Color + "  \n" +
                   "Puertas : " + veh_Puertas + "  \n" +
                   "Gps : " + veh_Gps + "  \n" +
                   "Tipo de Vehiculo : " + veh_TipoVehiculo + "  \n" +
                   "Clase de Vehiculo : " + veh_ClaseVehiulo + "  \n" +
                   "Precio : " + veh_Precio ;
        }
    }
}

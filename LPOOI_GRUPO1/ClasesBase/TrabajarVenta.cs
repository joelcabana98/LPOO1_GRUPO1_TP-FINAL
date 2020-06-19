using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;


namespace ClasesBase
{
    public class TrabajarVenta
    {
        /// <summary>
        /// Lista todas las Ventas con Alias
        /// </summary>
        /// <returns></returns>
        public static DataTable listar_ventas()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ListarTodasVentas";
   
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }




        /// <summary>
        /// Inserta una nueva Venta
        /// </summary>
        /// <param name="venta"></param>
        public static void insertar_venta(Venta venta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Venta (cli_dni , veh_matricula , usu_id , vta_fecha , fp_id, vta_precioFinal,vta_estado ) values(@dni,@mat,@idusu,@fecha,@pago,@precio,@estado)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", venta.Cli_Dni);
            cmd.Parameters.AddWithValue("@mat", venta.Veh_Matricula);
            cmd.Parameters.AddWithValue("@idusu", venta.Usu_Id);
            cmd.Parameters.AddWithValue("@fecha", venta.Vta_Fecha);
            cmd.Parameters.AddWithValue("@pago",  venta.Vta_FormaPago);
            cmd.Parameters.AddWithValue("@precio", venta.Vta_PrecioFinal);
            cmd.Parameters.AddWithValue("@estado", venta.Vta_Estado);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }


        public static DataTable filtrar_ventas_Dinamica(string dni,string marca,DateTime desde,DateTime hasta,string estado)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "BusquedaDinamicaVentas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@marca", marca);
            cmd.Parameters.AddWithValue("@dni", dni);
            cmd.Parameters.AddWithValue("@desde", desde);
            cmd.Parameters.AddWithValue("@hasta", hasta);
            cmd.Parameters.AddWithValue("@estado", estado);

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Console.WriteLine("resultado : "+ dt.Rows[1].Field<int>(0));
            return dt;
        }

        


       
        //////////////////////////////////////////////////////////////
        // METODOS PARA FORMA DE PAGO


        public static DataTable listar_forma_pago()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " fp_id as 'Id', ";
            cmd.CommandText += " fp_descripcion as 'Descripcion'";
            cmd.CommandText += " FROM FormaPago";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }



        public static void insertar_forma_pago(string descripcion)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO FormaPago (fp_descripcion) values(@descripcion)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@descripcion", descripcion);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        public static void eliminar_forma_pago(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM FormaPago WHERE fp_id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void actualizar_forma_pago(int id, string descripcion)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE FormaPago set fp_descripcion=@descripcion WHERE fp_id=@id";

            cmd.Parameters.AddWithValue("@descripcion", descripcion);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public static void modificar_estado_venta(int id, string estado)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Venta set vta_estado=@estadoVenta WHERE vta_id=@id";

            cmd.Parameters.AddWithValue("@estadoVenta", estado);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        
        ////// METODOS PARA MOSTRAR LAS CANTIDADES DE VENTAS

        /// <summary>
        /// Obtiene la cantidad de ventas
        /// </summary>
        /// <returns></returns>
        public static int obtener_cant_ventas() 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT COUNT(vta_id) as c";
            cmd.CommandText += " FROM Venta";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            int cantidad = dt.Rows[0].Field<int>(0);
            return cantidad;
        }

        /// <summary>
        /// Obtiene el total de las ventas
        /// </summary>
        /// <returns></returns>
        public static decimal obtener_total_ventas()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ObtenerTotalVentas";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            decimal cantidad = dt.Rows[0].Field<decimal>(0);
            return cantidad;
        }

        public static DataTable obtener_total_cantidad_ventas_dinamica(string dni, string marca, DateTime desde, DateTime hasta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            /*
            cmd.CommandText = "ContarSumarVentaDinamica";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            */
            cmd.CommandText = "SELECT SUM(Precio) as total, ";
            cmd.CommandText += "COUNT(*) as cant, ";
            cmd.CommandText += "SUM(CASE WHEN Estado = 'ANULADA' THEN 1 ELSE 0 END) as anulada, ";
            cmd.CommandText += "SUM(CASE WHEN Estado = 'CONFIRMADO' THEN 1 ELSE 0 END) as confirmado ";
            cmd.CommandText += "FROM vw_listar_ventas_clientes ";
            cmd.CommandText += "WHERE ( DNI=@dni OR @dni='') ";
            cmd.CommandText += "AND ( Id_Marca=@marca OR @marca = '') ";
            cmd.CommandText += "AND ( Fecha BETWEEN @desde AND @hasta)";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dni);
            cmd.Parameters.AddWithValue("@marca", marca);
            cmd.Parameters.AddWithValue("@desde", desde);
            cmd.Parameters.AddWithValue("@hasta", hasta);

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}

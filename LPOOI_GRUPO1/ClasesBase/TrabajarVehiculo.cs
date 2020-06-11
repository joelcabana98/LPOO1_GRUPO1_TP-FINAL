using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarVehiculo
    {
        /// <summary>
        /// Lista todos los Vehiculos con Alias
        /// </summary>
        /// <returns></returns>
        public static DataTable listar_VehiculoTabla()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ListarVehiculosSP";
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
        /// Lista todos los Vehiculos
        /// </summary>
        /// <returns></returns>
        public static DataTable listar_Vehiculo()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "ListarVehiculosSP";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            //agrega una nueva columna para la concatenacion
            dt.Columns.Add("veh_detalle", typeof(string), "Marca +' -  '+ Linea +' - '+ Modelo +' - '+ Matricula");

            return dt;
        }


        /// <summary>
        /// Busca el precio de un vehiculo buscado por la MATRICULA
        /// </summary>
        /// <param name="matricula"></param>
        /// <returns></returns>
        public static Decimal precio_vehiculo(string matricula)
        {
            Decimal preciov = 0;
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT *FROM Vehiculo WHERE veh_matricula=@mat";
            cmd.Parameters.AddWithValue("@mat", matricula);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cnn.Open();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    preciov = reader.GetDecimal(9);

                }
                cnn.Close();
                return preciov;
            }
            else
            {
                cnn.Close();
                return preciov;
            }
        }

        public static Decimal precioDeVehiculoSP(string matricula)
        {

            Decimal precio;

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "PrecioDeVehiculoSP";

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            // Parametro de Entrada
            cmd.Parameters.AddWithValue("@matricula", matricula);

            // Parametro de Salida
            cmd.Parameters.Add("@precio", SqlDbType.Decimal);
            cmd.Parameters["@precio"].Direction = ParameterDirection.Output;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            // Obtengo el valor del Parametro de Salida
            precio =  (Decimal)cmd.Parameters["@precio"].Value;

            return precio;

        }



       
    
        /// <summary>
        /// Inserta un nuevo Vehiculo
        /// </summary>
        /// <param name="vehiculo"></param>
        public static void insertar_vehiculo(Vehiculo vehiculo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);
            
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "AgregarVehiculoSP";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@matricula", vehiculo.Veh_Matricula);
            cmd.Parameters.AddWithValue("@marca", vehiculo.Veh_Marca);
            cmd.Parameters.AddWithValue("@linea", vehiculo.Veh_Linea);
            cmd.Parameters.AddWithValue("@modelo", vehiculo.Veh_Modelo);
            cmd.Parameters.AddWithValue("@color", vehiculo.Veh_Color);
            cmd.Parameters.AddWithValue("@puertas", vehiculo.Veh_Puertas);
            cmd.Parameters.AddWithValue("@gps", vehiculo.Veh_Gps);
            cmd.Parameters.AddWithValue("@tipo", vehiculo.Veh_TipoVehiculo);
            cmd.Parameters.AddWithValue("@clase", vehiculo.Veh_ClaseVehiulo);
            cmd.Parameters.AddWithValue("@precio", vehiculo.Veh_Precio);
            cmd.Parameters.AddWithValue("@estado", vehiculo.Veh_Estado);
            
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

          

        }


        /// <summary>
        /// Elimina el Vehiculo por su MATRICULA
        /// </summary>
        /// <param name="vehiculo"></param>
        public static void eliminar_Vehiculo(Vehiculo vehiculo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "EliminarVehiculoSP";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@matricula", vehiculo.Veh_Matricula);
            cmd.Parameters.AddWithValue("@estado", vehiculo.Veh_Estado);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// Actualiza el Vehiculo por su MATRICULA
        /// </summary>
        /// <param name="vehiculo"></param>
        public static void actualizar_vehiculo(Vehiculo vehiculo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ActualizarVehiculo";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@matricula", vehiculo.Veh_Matricula);
            cmd.Parameters.AddWithValue("@marca", vehiculo.Veh_Marca);
            cmd.Parameters.AddWithValue("@linea", vehiculo.Veh_Linea);
            cmd.Parameters.AddWithValue("@modelo", vehiculo.Veh_Modelo);
            cmd.Parameters.AddWithValue("@color", vehiculo.Veh_Color);
            cmd.Parameters.AddWithValue("@puertas", vehiculo.Veh_Puertas);
            cmd.Parameters.AddWithValue("@gps", vehiculo.Veh_Gps);
            cmd.Parameters.AddWithValue("@tipo", vehiculo.Veh_TipoVehiculo);
            cmd.Parameters.AddWithValue("@clase", vehiculo.Veh_ClaseVehiulo);
            cmd.Parameters.AddWithValue("@precio", vehiculo.Veh_Precio);
            

            cmd.Connection = cnn;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public static DataTable listar_marca()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Marca";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt); 
           return dt;
        }

        public static DataTable listar_linea(int marca_id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Linea WHERE mar_id=@id_marca";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id_marca", marca_id);

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public static DataTable listar_linea()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Linea";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public static DataTable listar_Vehiculos_OrdenSP(string campo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();

            da.SelectCommand.Connection = cnn;
            da.SelectCommand.CommandText = "OrdenarVehiculosSP";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter param;
            param = new SqlParameter("@campo", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = campo;
            da.SelectCommand.Parameters.Add(param);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }





        ////////////////////////////////////////////////////////////////////////////////////////////////
        // METODOS PARA TIPO DE VEHICULO

        public static DataTable listar_tipo_vehiculo()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " tv_id as 'Id', ";
            cmd.CommandText += " tv_descripcion as 'Descripcion'";
            cmd.CommandText += " FROM TipoVehiculo";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }



        public static void insertar_tipo_Vehiculo(string descripcion)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO TipoVehiculo (tv_descripcion) values(@descripcion)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@descripcion",descripcion);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        public static void eliminar_tipo_Vehiculo(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM TipoVehiculo WHERE tv_id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id",id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void actualizar_tipo_vehiculo(int id,string descripcion)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE TipoVehiculo set tv_descripcion=@descripcion WHERE tv_id=@id";

            cmd.Parameters.AddWithValue("@descripcion", descripcion);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }




        ////////////////////////////////////////////////////////////////////////////////////////////////
        // METODOS PARA CLASE DE VEHICULO

        public static DataTable listar_clase_vehiculo()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " cv_id as 'Id', ";
            cmd.CommandText += " cv_descripcion as 'Descripcion'";
            cmd.CommandText += " FROM ClaseVehiculo";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }



        public static void insertar_clase_Vehiculo(string descripcion)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO ClaseVehiculo (cv_descripcion) values(@descripcion)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@descripcion", descripcion);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        public static void eliminar_clase_Vehiculo(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM ClaseVehiculo WHERE cv_id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void actualizar_clase_vehiculo(int id, string descripcion)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE ClaseVehiculo set cv_descripcion=@descripcion WHERE cv_id=@id";

            cmd.Parameters.AddWithValue("@descripcion", descripcion);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

    }








}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarCliente
    {

        /// <summary>
        /// Lista todos los Clientes con Alias 
        /// </summary>
        /// <returns></returns>
        public static DataTable listar_Clientes()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " cli_dni as 'DNI', ";
            cmd.CommandText += " cli_nombre as 'Nombre' ,";
            cmd.CommandText += " cli_apellido as 'Apellido',";
            cmd.CommandText += " cli_direccion as 'Direccion', ";
            cmd.CommandText += " cli_telefono as 'Telefono'  ";
            cmd.CommandText += " FROM Cliente WHERE cli_estado='ACTIVO'";
            
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Lista todos los Clientes
        /// </summary>
        /// <returns></returns>
        public static DataTable listar_Clientes_sa()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Cliente WHERE cli_estado='ACTIVO'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            //agrega una nueva columna para la concatenacion
            dt.Columns.Add("cli_detalle", typeof(string), "cli_apellido +',  '+cli_nombre +' - '+cli_dni");

            return dt;
        }


        /// <summary>
        /// Inserta un nuevo Cliente 
        /// </summary>
        /// <param name="cliente"></param>
        public static void insertar_cliente(Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Cliente (cli_dni,cli_nombre,cli_apellido,cli_direccion,cli_telefono,cli_estado) values(@dni,@nombre,@apellido,@dir,@tel,@estado)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", cliente.Cli_Dni);
            cmd.Parameters.AddWithValue("@nombre", cliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@apellido", cliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@dir", cliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@tel", cliente.Cli_Telefono);
            cmd.Parameters.AddWithValue("@estado", cliente.Cli_Estado);


            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// Elimina un Cliente por su DNI
        /// </summary>
        /// <param name="cliente"></param>
        public static void eliminar_cliente(Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Cliente set cli_estado=@estado WHERE cli_dni=@dni";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", cliente.Cli_Dni);
            cmd.Parameters.AddWithValue("@estado", cliente.Cli_Estado);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// Actualiz un Cliente por su DNI
        /// </summary>
        /// <param name="cliente"></param>
        public static void actualizar_cliente(Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Cliente set cli_nombre=@nombre,cli_apellido=@apellido,cli_direccion=@dir,cli_telefono=@tel WHERE cli_dni=@dni";
           
            cmd.Parameters.AddWithValue("@nombre", cliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@apellido", cliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@dir", cliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@tel", cliente.Cli_Telefono);
            cmd.Parameters.AddWithValue("@dni", cliente.Cli_Dni);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        /// <summary>
        /// Busca los clientes por DNI o APELLIDO
        /// </summary>
        /// <param name="sPattern"></param>
        /// <returns></returns>
        public static DataTable buscar_clientes(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " cli_dni as 'DNI', ";
            cmd.CommandText += " cli_nombre as 'Nombre' ,";
            cmd.CommandText += " cli_apellido as 'Apellido',";
            cmd.CommandText += " cli_direccion as 'Direccion', ";
            cmd.CommandText += " cli_telefono as 'Telefono'  ";
            cmd.CommandText += " FROM Cliente";
            cmd.CommandText += " WHERE (cli_dni LIKE @pattern) OR (cli_apellido LIKE @pattern) AND cli_estado=@estado";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");
            cmd.Parameters.AddWithValue("@estado",Util.estado.ACTIVO.ToString());
            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable buscar_clientesSP(string sPattern) {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();

            da.SelectCommand.Connection = cnn;
            da.SelectCommand.CommandText = "BuscarClientesOrdenador";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter param;
            param = new SqlParameter("@pattern", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = "%" + sPattern + "%";
            da.SelectCommand.Parameters.Add(param);

            DataSet ds = new DataSet();
            da.Fill(ds, "Cliente");

            return ds.Tables[0]; ;
        }


        public static DataTable listar_Clientes_SP()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "ListarClientesSP";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();

           

            da.Fill(dt);

            //agrega una nueva columna para la concatenacion
            dt.Columns.Add("cli_detalle", typeof(string), "cli_apellido +',  '+cli_nombre +' - '+cli_dni");

            return dt;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarUsuario
    {
        /// <summary>
        /// Lista todos los Usuarios con Alias
        /// </summary>
        /// <returns></returns>
        public static DataTable listar_Usuario() {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " rol_descripcion as 'Rol', ";
            cmd.CommandText += " usu_nombreUsuario as 'Usuario' ,";
            cmd.CommandText += " usu_contrasena as 'Contraseña',";
            cmd.CommandText += " usu_apellidoNombre as 'Nombre y Apellido', ";
            cmd.CommandText += " usu_id , U.rol_codigo  ";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Rol as R ON (R.rol_codigo=U.rol_codigo) WHERE usu_estado=@estado";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@estado",Util.estado.ACTIVO.ToString());

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Lista todo los Roles
        /// </summary>
        /// <returns></returns>
        public static DataTable listar_roles() {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Rol";
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
        /// Inserta un nuevo Usuario
        /// </summary>
        /// <param name="usuario"></param>
        public static void insertar_usuario (Usuario usuario) {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario(usu_nombreUsuario,usu_contrasena,usu_apellidoNombre,rol_codigo,usu_estado) values(@usu,@contrasena,@nombre,@rol,@estado)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@usu",usuario.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@contrasena", usuario.Usu_Password);
            cmd.Parameters.AddWithValue("@nombre", usuario.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", usuario.Rol_Codigo);
            cmd.Parameters.AddWithValue("@estado", usuario.Usu_Estado);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        
        }

        /// <summary>
        /// Elimina un Usuario por su numero de ID
        /// </summary>
        /// <param name="usuario"></param>
        public static void eliminar_usuario(Usuario usuario) {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Usuario set usu_estado=@estado WHERE usu_id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", usuario.Usu_Id);
            cmd.Parameters.AddWithValue("@estado",usuario.Usu_Estado);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// Axtualiza un Usuario por su numero de ID
        /// </summary>
        /// <param name="usuario"></param>
        public static void actualizar_usuario(Usuario usuario) {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Usuario set usu_nombreUsuario=@usu,usu_contrasena=@contra,usu_apellidoNombre=@nombre,rol_codigo=@rol WHERE usu_id=@id";
            cmd.Parameters.AddWithValue("@usu", usuario.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@contra", usuario.Usu_Password);
            cmd.Parameters.AddWithValue("@nombre", usuario.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", usuario.Rol_Codigo);
            cmd.Parameters.AddWithValue("@id", usuario.Usu_Id);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        
        }
        /// <summary>
        /// Busca Usuarios por su NOMBRE DE USUARIO
        /// </summary>
        /// <param name="sPattern"></param>
        /// <returns></returns>
        public static DataTable buscar_usuarios(string sPattern) {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " rol_descripcion as 'Rol', ";
            cmd.CommandText += " usu_nombreUsuario as 'Usuario' ,";
            cmd.CommandText += " usu_contrasena as 'Contraseña',";
            cmd.CommandText += " usu_apellidoNombre as 'Nombre y Apellido', ";
            cmd.CommandText += " usu_id , U.rol_codigo  ";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Rol as R ON (R.rol_codigo=U.rol_codigo)";
            cmd.CommandText += " WHERE usu_nombreUsuario LIKE @pattern AND usu_estado=@estado ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%"+sPattern+"%");
            cmd.Parameters.AddWithValue("@estado",Util.estado.ACTIVO.ToString());
            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Valida si el usuario existe por NOMBRE DE USUARIO Y PASSWORD
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contra"></param>
        /// <returns></returns>
        public static bool validarUsuario(string usuario,string contra) {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaConection);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT *FROM Usuario WHERE usu_nombreUsuario=@usu AND usu_contrasena=@contra AND usu_estado=@estado";
            cmd.Parameters.AddWithValue("@usu", usuario);
            cmd.Parameters.AddWithValue("@contra",contra);
            cmd.Parameters.AddWithValue("@estado",Util.estado.ACTIVO.ToString());
           
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            
            cnn.Open();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            

            if (reader.HasRows)
            {

                while (reader.Read())
                {   //almacena los datos en una clase para mantener la sesion
                    UsuarioLogin.usu_Id = reader.GetInt32(0);
                    UsuarioLogin.usu_NombreUsuario = reader.GetString(1);
                    UsuarioLogin.usu_Password = reader.GetString(2);
                    UsuarioLogin.usu_ApellidoNombre = reader.GetString(3);
                    UsuarioLogin.rol_Codigo = reader.GetString(4);
                }
                cnn.Close();
                return true;
            }
            else {
                cnn.Close();
                return false;
            }           
        }


    }
}

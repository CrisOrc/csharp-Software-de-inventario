using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data.SqlClient;

namespace Negocios
{
    public class conUsuarios
    {
        private modUsuarios Usuarios = new modUsuarios();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = Usuarios.Mostrar_Usuarios();
            return tabla;
        }
        public void InsertarUsuarios(string username, string email, string passwordHash, string rol)
        {
            Usuarios.Insertar_Usuarios(username, email, passwordHash, rol);
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Usuarios values (@Username,@Email, @PasswordHash,@Rol)";
            comando.Parameters.AddWithValue("@Username", username);
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@PasswordHash", passwordHash);
            comando.Parameters.AddWithValue("@Rol", rol);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void EditarUsuarios(string username, string email, string passwordHash, string rol, string id)
        {
            Usuarios.Editar_Usuarios(username, email, passwordHash, rol, Convert.ToInt32(id));
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update Usuarios set Usuario = @Username, email = @Email, Password = @PasswordHash, Rol=@Rol where Id=@id";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@Username", username);
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@PasswordHash", passwordHash);
            comando.Parameters.AddWithValue("@Rol", rol);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EliminarUsuarios(string id)
        {
            Usuarios.Eliminar_Usuarios(Convert.ToInt32(id));
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from Usuarios where Id=@idpro";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


    }
}

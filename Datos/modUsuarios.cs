using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class modUsuarios
    {
        private Conexion conexion = new Conexion();

        SqlDataReader buffer;

        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar_Usuarios()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from UsuariosSistema";
            buffer = comando.ExecuteReader();
            tabla.Load(buffer);
            conexion.CerrarConexion();
            return tabla;

        }

        public Int32 contarUsuarios()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select count(*) as cuenta from UsuariosSistema";
            Int32 cont = (Int32)comando.ExecuteScalar();
            conexion.CerrarConexion();
            return cont;
        }

        public string getNombre(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select Nombre from UsuariosSistema where Id = @id";
            comando.Parameters.AddWithValue("@id", id);
            SqlDataReader data = comando.ExecuteReader();
            string nombre;
            if (data.Read())
                nombre = data["Nombre"].ToString();
            else
                nombre = "No encontrado";

            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return (nombre);
        }

        public void Insertar_Usuarios(string Username, string Email, string PasswordHash, double Rol)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into UsuariosSistema values (@username,@email,@passwordhash,@rol)";
            comando.Parameters.AddWithValue("@username", Username);
            comando.Parameters.AddWithValue("@email", Email);
            comando.Parameters.AddWithValue("@passwordHash", PasswordHash);
            comando.Parameters.AddWithValue("@rol", Rol);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Editar_Usuarios(string Username, string Email, string PasswordHash, string Rol, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into UsuariosSistema values (@username,@email,@passwordhash,@rol)";
            comando.Parameters.AddWithValue("@username", Username);
            comando.Parameters.AddWithValue("@email", Email);
            comando.Parameters.AddWithValue("@passwordHash", PasswordHash);
            comando.Parameters.AddWithValue("@rol", Rol);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    

        public void Eliminar_Usuarios(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from Productos where Id=@idpro";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@idpro", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class modCategoria
    {
        private Conexion conexion = new Conexion();

        SqlDataReader buffer;

        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar_Categoria()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from dbo.Categorias";
            buffer = comando.ExecuteReader();
            tabla.Load(buffer);
            conexion.CerrarConexion();
            return tabla;

        }
        public void Insertar_Categoria(string nombre)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Categorias values (@nombre)";
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Editar_Categoria(string nombre, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update Categorias set Nombre=@nombre where Id=@id";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Eliminar_Categoria(int idpro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from Categorias where Id=@idpro";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@idpro", idpro);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}

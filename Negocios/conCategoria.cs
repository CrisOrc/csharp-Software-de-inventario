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
    public class conCategoria
    {
        private modCategoria Productos = new modCategoria();
       
        private modCategoria CATEGORIAS = new modCategoria();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar_Categoria()
        {
            DataTable tabla = new DataTable();
            tabla = CATEGORIAS.Mostrar_Categoria();
            return tabla;
        }
        public void InsertarCategoria(string nombre, int id)
        {
            CATEGORIAS.Insertar_Categoria();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Categorias values (@nombre)";
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void EditarCategoria(string nombre, string id)
        {
            CATEGORIAS.Editar_Categoria(nombre, Convert.ToInt32(id));
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update Categorias set Nombre=@nombre";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EliminarCategoria(string id)
        {
            CATEGORIAS.Eliminar_Categoria(Convert.ToInt32(id));
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from Categorias where Id=@idpro";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        }


    }
}

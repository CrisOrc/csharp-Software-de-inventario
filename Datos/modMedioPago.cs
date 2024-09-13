using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class modMedioPago
    {
        private Conexion conexion = new Conexion();

        SqlDataReader buffer;

        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar_MediosPago()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from MediosPagp";
            buffer = comando.ExecuteReader();
            tabla.Load(buffer);
            conexion.CerrarConexion();
            return tabla;

        }
        public void Insertar_MediosPago(string Metodo, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Mediospago values (@Metodo,@id)";
            comando.Parameters.AddWithValue("@Metodo", Metodo);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Editar_MediosPago(string Metodo, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update MediosPago set Metodo=@Metodo, Id=@id";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@Metodo", Metodo);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Eliminar_MediosPago(int idpro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from MediosPago where Id=@idpro";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@idpro", idpro);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class modFactura
    {
        private Conexion conexion = new Conexion();

        SqlDataReader buffer;

        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar_Factura()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Factura";
            buffer = comando.ExecuteReader();
            tabla.Load(buffer);
            conexion.CerrarConexion();
            return tabla;

        }
        public void Insertar_Factura(DateTime fecha, int idcliente, int id, int total, int mediodepago)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Factura values (@fecha,@idcliente,@id, @total,@mediodepago )";
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@idcliente", idcliente);
            comando.Parameters.AddWithValue("@total", total);
            comando.Parameters.AddWithValue("@mediodepago", mediodepago);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Editar_Factura(DateTime fecha, int idcliente, int id, int total, int mediodepago)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update Factura set Nombre=@nombre, Id=@id, email=@email, telefono=@telefono";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@idcliente", idcliente);
            comando.Parameters.AddWithValue("@total", total);
            comando.Parameters.AddWithValue("@mediodepago", mediodepago);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Eliminar_Factura(int idpro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from Factura where Id=@idpro";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@idpro", idpro);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
   
}

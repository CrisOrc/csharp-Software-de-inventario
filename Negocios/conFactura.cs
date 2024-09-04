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
    public class conFactura
    {
        private modFactura Facturas = new modFactura();
        SqlCommand comando = new SqlCommand();


        public DataTable Mostrar_Factura()
        {
            DataTable tabla = new DataTable();
            tabla = Facturas.Mostrar_Factura();
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
            comando.Connection = conexion.AbrirConexion(fecha, id,idcliente, total, mediodepago);
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
        public void Eliminar_Factura(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from Factura where Id=@idpro";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}

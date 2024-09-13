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
    public class conMedioPago
    {
        private Conexion conexion = new Conexion();
        private modMedioPago MediosPago = new modMedioPago();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarMediosPago()
        {
            DataTable tabla = new DataTable();
            tabla = MediosPago.Mostrar_MediosPago();
            return tabla;
        }
        public void InsertarMediosPago(string metodo)
        {
            //MediosPago.Insertar_MediosPago(metodo, id);
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into MediosPago values (@metodo);";
            comando.Parameters.AddWithValue("@metodo", metodo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void EditarMediosPago(string metodo, string id)
        {
            MediosPago.Editar_MediosPago(metodo, Convert.ToInt32(id));
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update MediosPago set Metodo = @metodo where Id=@id";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@metodo", metodo);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EliminarMediosPago(string id)
        {
            MediosPago.Eliminar_MediosPago(Convert.ToInt32(id));
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from MediosPago where Id=@idpro";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

    }
}

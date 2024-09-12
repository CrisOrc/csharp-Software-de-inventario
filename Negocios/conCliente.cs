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
    public class conCliente
    {
        private Conexion conexion = new Conexion();
        private modCliente Clientes = new modCliente();
        SqlCommand comando = new SqlCommand();
<<<<<<< HEAD
        private Conexion conexion = new Conexion();
=======
>>>>>>> 2914e63593496e9aad8764326fb9ed1aa70ff47d

        public DataTable MostrarClientes()
        {
            DataTable tabla = new DataTable();
            tabla = Clientes.Mostrar_Cliente();
            return tabla;
        }
        public void InsertarClientes(string nombre, string email, int tel, int id)
        {
            Clientes.Insertar_Cliente(nombre, email, Convert.ToInt32(tel), id);
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Clientes values (@nombre,@Email,@Telefono)";
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@Telefono", tel);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void EditarClientes(string nombre, string email, int tel, string id)
        {
            Clientes.Editar_Cliente(nombre, email, Convert.ToInt32(tel), Convert.ToInt32(id));
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update Clientes set Nombre=@nombre, Email = @email, Telefono = @tel where Id=@id";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@Telefono", tel);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EliminarClientes(string id)
        {
            Clientes.Eliminar_Cliente(Convert.ToInt32(id));
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from Clientes where Id=@idp";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class modProductos
    {
        private Conexion conexion = new Conexion();

        SqlDataReader buffer;

        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar_SP()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            buffer = comando.ExecuteReader();
            tabla.Load(buffer);
            conexion.CerrarConexion();
            return tabla;                                                                                          

        }
        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Productos";            
            buffer = comando.ExecuteReader();
            tabla.Load(buffer);
            conexion.CerrarConexion();
            return tabla;

        }

        public Int32 contarProductos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select count(*) as cuenta from Productos";           
            Int32 cont = (Int32) comando.ExecuteScalar();
            conexion.CerrarConexion();
            return cont;
        }

        public string getNombre(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select Nombre from Productos where Id = @id";
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
        public void Insertar_SP(string nombre, string desc, string marca, double precio, int stock)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", precio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Insertar(string nombre, string desc, string marca, double precio, int stock)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Productos values (@nombre,@descrip,@marca,@precio,@stock)";            
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", precio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Editar_SP(string nombre, string desc, string marca, double precio, int stock, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", precio);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Editar(string nombre, string desc, string marca, double precio, int stock, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update Productos set Nombre=@nombre, Descripcion=@descrip, Marca=@marca, Precio=@precio, Stock=@stock where Id=@id";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", precio);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Eliminar_SP(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idpro", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }        
        
        public void Eliminar(int idpro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from Productos where Id=@idpro";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@idpro", idpro);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}

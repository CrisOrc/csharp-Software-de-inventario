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
    public class conProducto
    {
        private modProductos Productos = new modProductos();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = Productos.Mostrar();
            return tabla;
        }
        public void Insertar(string nombre, string desc, string marca, string precio, string stock)
        {
            Productos.Insertar(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Productos values (@nombre,@descrip,@marca,@precio,@stock)";
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", precio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear(); 
        }
        public void Editar(string nombre, string desc, string marca, string precio, string stock, string id)
        {
            Productos.Editar(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), Convert.ToInt32(id));
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
        public void Eliminar(string id)
        {
            Productos.Eliminar(Convert.ToInt32(id));
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from Productos where Id=@idpro";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
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
            return Productos.getNombre(id);
        }

        public int Contar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select count(*) as cuenta from Productos";
            Int32 cont = (Int32)comando.ExecuteScalar();
            conexion.CerrarConexion();
            return Productos.contarProductos();
        }


    }
}

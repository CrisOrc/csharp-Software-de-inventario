using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;  // Adicionar librerías
using System.Data.SqlClient; 

namespace Datos
{
    public class Conexion
    {


        private SqlConnection dbConexion = new SqlConnection("Server=sebasl;Password=123456;DataBase=inventario;Integrated Security=true");
        public SqlConnection AbrirConexion()
        {
            if (dbConexion.State == ConnectionState.Closed)
                dbConexion.Open();
            return dbConexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (dbConexion.State == ConnectionState.Open)
                dbConexion.Close();
            return dbConexion;
        }
    }
}

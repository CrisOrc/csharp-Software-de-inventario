using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace Datos
{
    public class DataAccess
    {
        public string connectionString = "Server=DESKTOP-VDP9H49\\SQLEXPRESS;DataBase=inventario2;Integrated Security=true";

        // Método para validar al usuario
        public bool ValidateUser(string username, string hashedPassword)
        {
            bool isValid = false;

            string query = "SELECT PasswordHash FROM UsuariosSistema WHERE Username = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                try
                {
                    connection.Open();
                    var result = command.ExecuteScalar();

                    if (result != null)
                    {
                        string storedPasswordHash = result.ToString();

                        // Compara el hash proporcionado con el hash almacenado
                        if (BCrypt.Net.BCrypt.Verify(hashedPassword, storedPasswordHash))
                        {
                            isValid = true; // La contraseña coincide
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return isValid; // Retorna el resultado de la validación
        }
    }
}


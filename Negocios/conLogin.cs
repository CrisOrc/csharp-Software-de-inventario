using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace Negocios
{
    internal class conLogin
    {
        private DataAccess dataAccess = new DataAccess();

        // Método para recibir datos de la presentación y comunicarse con la capa de datos
        public bool ValidarUsuario(string username, string passwordHash)
        {
            // Cifrar la contraseña antes de enviarla a la capa de datos
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(passwordHash);

            // Llamar al método de la capa de datos para validar
            return dataAccess.ValidateUser(username, hashedPassword);
        }

    }
}

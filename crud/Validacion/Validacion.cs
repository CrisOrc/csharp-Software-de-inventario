using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Presentacion.Validacion
{
    public class Validacion
    {
        public static bool CampoVacio(string texto, Label textElement)
        {
            bool esVacio = string.IsNullOrEmpty(texto);
            if (esVacio) textElement.Text = "Ingresa algo";
            return esVacio is false;
        }

        public static bool Email(string email, Label textElement)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            bool isMatch = Regex.IsMatch(email, pattern);
            bool esVacio = string.IsNullOrEmpty(email);
            if (isMatch is false) textElement.Text = "Email incorrecto";
            if (esVacio) textElement.Text = "Ingresa algo";
            return isMatch && esVacio is false;
        }
        public static bool SoloTexto(string text, Label textElement)
        {
            bool soloTexto = text.All(c => char.IsLetter(c));
            bool esVacio = string.IsNullOrEmpty(text);
            if (soloTexto is false) textElement.Text = "Debes incluir únicamente letras";
            if (esVacio) textElement.Text = "Ingresa algo";
            return soloTexto && esVacio is false;
        }
        public static bool Contraseña(string contraseña, Label textElement)
        {
            bool masDe8Caracteres = contraseña.Length >= 8;
            bool tieneMayuscula = contraseña.Any(c => char.IsUpper(c));
            bool tieneMinuscula = contraseña.Any(c => char.IsLower(c));
            bool tieneNumero = contraseña.Any(c => char.IsDigit(c));
            bool tieneCaracterEspecial = contraseña.Any(c => !char.IsLetterOrDigit(c));
            bool esVacio = string.IsNullOrEmpty(contraseña);
            if (tieneMayuscula is false) textElement.Text = "Debes incluir almenos una letra mayuscula";
            if (tieneMinuscula is false) textElement.Text = "Debes incluir almenos una letra minuscula";
            if (tieneNumero is false) textElement.Text = "Debes incluir almenos un numero";
            if (tieneCaracterEspecial is false) textElement.Text = "Debes incluir almenos un caracter especial";
            if (contraseña.Length < 8) textElement.Text = "Debe tener almenos 8 caracteres";
            if (esVacio) textElement.Text = "Ingresa algo";

            return tieneMayuscula && tieneMinuscula && tieneNumero && tieneCaracterEspecial && esVacio is false;
        }

        public static bool Entero(string texto, int longitudMaxima, Label textElement)
        {
            bool esNumero = int.TryParse(texto, out int num);
            bool rangoEsOk = texto.Length <= longitudMaxima;
            bool esVacio = string.IsNullOrEmpty(texto);
            if (esNumero is false) textElement.Text = "Solo puede tener numeros";
            if (rangoEsOk is false) textElement.Text = $"No puede contener mas de {longitudMaxima.ToString()} numeros";
            if (esVacio) textElement.Text = "Ingresa algo";
            return esNumero && rangoEsOk && esVacio is false;
        }
        public static bool Decimal(string texto, int longitudMaxima, Label textElement)
        {
            bool esNumero = decimal.TryParse(texto, out decimal numero);
            bool rangoEsOk = texto.Length <= longitudMaxima;
            bool esVacio = string.IsNullOrEmpty(texto);
            if (esNumero is false) textElement.Text = "Solo puede tener numeros";
            if (rangoEsOk is false) textElement.Text = $"No puede contener mas de {longitudMaxima.ToString()} numeros";
            if (esVacio) textElement.Text = "Ingresa algo";
            return esNumero && rangoEsOk && esVacio is false;
        }
    }
}

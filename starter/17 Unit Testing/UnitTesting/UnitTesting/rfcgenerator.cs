using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class rfcgenerator
    {
        public string ConcatenateFullNameAndBirthdate(string nombre, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento)
        {
            string shortNombre = nombre.Length >= 1 ? nombre.Substring(0, 1) : nombre;
            string shortApellidoPaterno = apellidoPaterno.Length >= 2 ? apellidoPaterno.Substring(0, 2) : apellidoPaterno;
            string shortApellidoMaterno = apellidoMaterno.Length >= 1 ? apellidoMaterno.Substring(0, 1) : apellidoMaterno;
            string formattedFechaNacimiento = fechaNacimiento.ToString("yyMMdd");
            string randomdata = GenerateRandomString();

            return $"{shortApellidoPaterno}{shortApellidoMaterno}{shortNombre}{formattedFechaNacimiento}{randomdata}".ToUpper();
        }
        private string GenerateRandomString()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[3];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new String(stringChars);
        }
    }
}

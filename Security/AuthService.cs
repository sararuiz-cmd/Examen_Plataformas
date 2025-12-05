using System;
using System.Security.Cryptography;
using System.Text;
using CollabSecure.Domain;

namespace CollabSecure.Security
{
    public class AuthService
    {
        private readonly Usuario usuarioFijo = new Usuario
        {
            Nombre = "admin",
            Contrasena = CalcularHash("1234")
        };

        public bool Login(string user, string pass)
        {
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
                return false;

            string passHasheado = CalcularHash(pass);

            return user == usuarioFijo.Nombre && passHasheado == usuarioFijo.Contrasena;
        }

        public static string CalcularHash(string texto)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(texto);
                byte[] hashBytes = sha.ComputeHash(bytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}

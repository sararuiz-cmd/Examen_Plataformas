using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using CollabSecure.Domain;

namespace CollabSecure.Security
{
    public class AuthService
    {
        private readonly string rutaUsuarios = "usuarios.txt";

        public AuthService()
        {
            // Si no existe el archivo, crear uno con el usuario "admin"
            if (!File.Exists(rutaUsuarios))
            {
                RegistrarUsuario("admin", "1234");
            }
        }

        // ================================
        //  LOGIN DE USUARIOS
        // ================================
        public bool Login(string user, string pass)
        {
            string hashPass = CalcularHash(pass);

            foreach (var usuario in CargarUsuarios())
            {
                if (usuario.Nombre == user && usuario.Contrasena == hashPass)
                    return true;
            }

            return false;
        }

        // ================================
        //  REGISTRO DE NUEVOS USUARIOS
        // ================================
        public bool RegistrarUsuario(string nombre, string contraseña)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(contraseña))
                return false;

            string hash = CalcularHash(contraseña);

            // Evitar duplicados
            foreach (var u in CargarUsuarios())
            {
                if (u.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                    return false; // Usuario ya existe
            }

            string linea = nombre + "|" + hash;
            File.AppendAllLines(rutaUsuarios, new[] { linea });

            return true;
        }

        // ================================
        //  CARGAR USUARIOS DESDE TXT
        // ================================
        private List<Usuario> CargarUsuarios()
        {
            var usuarios = new List<Usuario>();

            if (!File.Exists(rutaUsuarios))
                return usuarios;

            foreach (var linea in File.ReadAllLines(rutaUsuarios))
            {
                var partes = linea.Split('|');
                if (partes.Length == 2)
                {
                    usuarios.Add(new Usuario
                    {
                        Nombre = partes[0],
                        Contrasena = partes[1]
                    });
                }
            }

            return usuarios;
        }

        // ================================
        //  HASH SHA-256
        // ================================
        public static string CalcularHash(string texto)
        {
            using (SHA256 sha = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(texto);
                var hash = sha.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}

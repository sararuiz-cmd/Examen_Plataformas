using System.Linq;

namespace CollabSecure.Security
{
    public static class ContentFilter
    {
        // Lista de palabras prohibidas
        private static readonly string[] palabrasProhibidas =
        {
            "tonto",
            "idiota",
            "maldito",
            "estupido",
            "puto",
            "puta",
            "mierda"
        };

        // Método que detecta si un texto contiene lenguaje ofensivo
        public static bool ContieneContenidoOfensivo(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return false;

            string minus = texto.ToLower();

            return palabrasProhibidas.Any(p => minus.Contains(p));
        }
    }
}

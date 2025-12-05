namespace CollabSecure.Security
{
	public static class ValidationService
	{
		public static bool ValidarTexto(string texto)
		{
			return !string.IsNullOrWhiteSpace(texto)
				&& texto.Length <= 200;
		}
	}
}

using System;
using System.Security.Cryptography;
using System.Text;

namespace Kepler7.Core.Bridge
{

    public interface ICifrado
    {
        string Cifrar(string texto);
    }

    public class SinCifrado : ICifrado
    {
        public string Cifrar(string texto) => texto;
    }

    public class CifradoAES : ICifrado
    {
        public string Cifrar(string texto)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes("Kepler7-AES-Key!"); 
                aes.IV = new byte[16];
                byte[] datos = Encoding.UTF8.GetBytes(texto);
                return Convert.ToBase64String(aes.CreateEncryptor().TransformFinalBlock(datos, 0, datos.Length));
            }
        }
    }

 
    public class CifradoCuantico : ICifrado
    {
        private readonly Random _rng = new Random();

        public string Cifrar(string texto)
        {
            var resultado = new StringBuilder();
            foreach (char c in texto)
                resultado.Append((c ^ _rng.Next(256)).ToString("X2"));
            return resultado.ToString();
        }
    }
}

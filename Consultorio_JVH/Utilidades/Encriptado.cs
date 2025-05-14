using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio_JVH.Utilidades
{
    internal class Encriptado
    {
        static string clavePrivada = "vJMnURwFuojTiaJT";

        public static string Encriptar(string textoEncriptar)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(clavePrivada);
                aes.IV = new byte[aes.BlockSize / 8];
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using (ICryptoTransform encriptador = aes.CreateEncryptor())
                using (MemoryStream ms = new MemoryStream())
                using (CryptoStream cs = new CryptoStream(ms, encriptador, CryptoStreamMode.Write))
                {
                    byte[] bytesTextoPlano = Encoding.UTF8.GetBytes(textoEncriptar);
                    cs.Write(bytesTextoPlano, 0, bytesTextoPlano.Length);
                    cs.FlushFinalBlock();
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        public static string Desencriptar(string textoCifrado)
        {
            byte[] textoCifradoBytes = Convert.FromBase64String(textoCifrado);

            byte[] textocifradoabytes = Convert.FromBase64String(textoCifrado);

            Aes aes = Aes.Create();

            aes.Key = Encoding.UTF8.GetBytes(clavePrivada);
            aes.IV = new byte[aes.BlockSize / 8];

            ICryptoTransform desencriptador = aes.CreateDecryptor(aes.Key, aes.IV);

            MemoryStream sflujodatosmemoria = new MemoryStream(textocifradoabytes);

            CryptoStream descifradodedatos = new CryptoStream(sflujodatosmemoria, desencriptador, CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(descifradodedatos);


            return sr.ReadToEnd();
        }

    }
}

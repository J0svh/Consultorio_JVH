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

        public static String Encriptar(String textoEncriptar)
        {
            Aes aes = Aes.Create();


            aes.Key = Encoding.UTF8.GetBytes(clavePrivada);
            aes.IV = new byte[aes.BlockSize / 8];

            ICryptoTransform encriptador = aes.CreateEncryptor(aes.Key, aes.IV);

            MemoryStream flujodatosmemoria = new MemoryStream();
            CryptoStream cifradodedatos = new CryptoStream(flujodatosmemoria, encriptador, CryptoStreamMode.Write);

            byte[] bytesdeltextoPlano = UTF8Encoding.UTF8.GetBytes(textoEncriptar);
            cifradodedatos.Write(bytesdeltextoPlano, 0, bytesdeltextoPlano.Length);

            cifradodedatos.FlushFinalBlock();

            byte[] bytescifrados = flujodatosmemoria.ToArray();

            flujodatosmemoria.Close();

            return Convert.ToBase64String(bytescifrados);

        }

        public static string Desencriptar(string textoCifrado)
        {


            byte[] textoCifradoBytes = Convert.FromBase64String(textoCifrado);

            Aes aes = Aes.Create();

            aes.Key = Encoding.UTF8.GetBytes(clavePrivada);
            aes.IV = new byte[aes.BlockSize / 8];

            ICryptoTransform desencriptador = aes.CreateDecryptor(aes.Key, aes.IV);

            MemoryStream flujodatosmemoria = new MemoryStream(textoCifradoBytes);
            CryptoStream descifradodedatos = new CryptoStream(flujodatosmemoria, desencriptador, CryptoStreamMode.Read);

            StreamReader sr = new StreamReader(descifradodedatos);

            return sr.ReadToEnd();
        }

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

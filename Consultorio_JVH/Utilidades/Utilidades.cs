using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio_JVH.Utilidades
{
    internal class Utilidades
    {
        public static void MostrarAlerta(string nombreCampo)
        {
            MessageBox.Show($"El campo {nombreCampo} es obligatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool CampoVacio(TextBox campo)
        {
            return string.IsNullOrWhiteSpace(campo.Text);
        }

        public static bool ComboNoSeleccionado(ComboBox combo)
        {
            return combo.SelectedIndex <= 0;
        }

        public static bool compruebaCorreo(string correo)
        {
            string formatoCorreo = "[@]{1}";

            return Regex.IsMatch(correo, formatoCorreo);
        }

        public static void MostrarAlertaCombo(string nombreCombo)
        {
            MessageBox.Show($"Debe seleccionar un elemento en el desplegable {nombreCombo}", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Validación numérica
        public static bool EsEnteroValido(TextBox campo)
        {
            return int.TryParse(campo.Text, out _);
        }

        public static void MostrarAlertaNumerica(string nombreCampo)
        {
            MessageBox.Show($"En el campo {nombreCampo} solo se aceptan valores numéricos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Validación de DNI
        private static readonly char[] LetrasDNI = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
        private const string PatronDNI = @"^\d{8}[A-Z]$";

        public static bool FormatoDNICorrecto(string dni)
        {
            return Regex.IsMatch(dni, PatronDNI);
        }

        public static bool DNIValido(string dni)
        {
            if (!FormatoDNICorrecto(dni))
                return false;

            int numero = int.Parse(dni.Substring(0, 8));
            char letraCalculada = LetrasDNI[numero % 23];
            return dni[8] == letraCalculada;
        }

        // Validación de teléfonos
        private const string PatronMovil = @"^[6-9]\d{8}$";
        private const string PatronFijo = @"^[8-9][0-8]{2}\d{6}$";

        public static bool FormatoTelefonoMovilValido(string telefono)
        {
            return Regex.IsMatch(telefono, PatronMovil);
        }

        public static bool FormatoTelefonoFijoValido(string telefono)
        {
            return Regex.IsMatch(telefono, PatronFijo);
        }

        // Validación de email
        public static bool EmailValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Validación de código postal
        private const string PatronCP = @"^[0-5]\d{4}$";

        public static bool FormatoCPValido(string cp)
        {
            return Regex.IsMatch(cp, PatronCP);
        }

        // Validación número de colegiado
        private const string PatronNumColegiado = @"^[1-9]\d{8}$";

        public static bool NumeroColegiadoValido(string numeroColegiado)
        {
            return Regex.IsMatch(numeroColegiado, PatronNumColegiado);
        }
    }
}


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
            return combo.Items.Count == 0 || combo.SelectedIndex < 0 || string.IsNullOrWhiteSpace(combo.Text);
        }

        public static bool RadioButtonSeleccionado(GroupBox groupBox)
        {
            return groupBox.Controls.OfType<RadioButton>().Any(r => r.Checked);
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


        public static bool EnteroCorrecto(TextBox campo)
        {
            string texto = campo.Text.Trim();
            if (texto.Length == 9 && long.TryParse(texto, out long numero))
                return numero >= 100000000 && numero <= 999999999;
            return false;
        }
        public static bool Entero(TextBox campo)
        {
            int resultado;
            return int.TryParse(campo.Text.Trim(), out resultado) && resultado >= 0;
        }
       

        public static bool DoubleCorrecto(TextBox campo)
        {
            return double.TryParse(campo.Text.Trim(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double resultado) && resultado >= 0;
        }

        public static void MostrarAlertaNumerica(string nombreCampo)
        {
            MessageBox.Show($"En el campo {nombreCampo} solo se aceptan valores numéricos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        
        private static readonly char[] LetrasDNI = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
        private const string PatronDNI = @"^\d{8}[A-Z]$";

        

        public static bool DNIValido(string dni)
        {
            if (!Regex.IsMatch(dni, @"^\d{8}[A-Z]$"))
                return false;

            int numero = int.Parse(dni.Substring(0, 8));
            char letraCorrecta = "TRWAGMYFPDXBNJZSQVHLCKE"[numero % 23];
            return dni[8] == letraCorrecta;
        }



        public static bool FormatoTelefonoMovilValido(string telefono)
        {
            return Regex.IsMatch(telefono, @"^[6-7]\d{8}$");
        }

        public static bool FormatoTelefonoFijoValido(string telefono)
        {
            return Regex.IsMatch(telefono, @"^[8-9]\d{8}$");
        }


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

        

        public static bool FormatoCPValido(string cp)
        {
            string PatronCP = "^[0-5]{1}[0-9]{1}[0]{1}[0-9]{2}$";
            return Regex.IsMatch(cp, PatronCP);
        }

        

        public static bool NumeroColegiadoValido(string numeroColegiado)
        {
            string formatoCorreo = "[1-9]{1}[0-9]{8}";
            return Regex.IsMatch(numeroColegiado, formatoCorreo);
        }
    }
}


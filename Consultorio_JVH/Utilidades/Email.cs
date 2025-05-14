using Consultorio_JVH.Modelo;
using Consultorio_JVH.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio_JVH.Utilidades
{
    internal class Email
    {
        public static void enviarCorreo(Cita d)
        {
            try
            {
                string destino = Principal.DatosPaciente[3];
                string asunto = "Cita Medica";
                string mensaje = d.ToString() + Environment.NewLine + "<p><img src=https://reynaldomd.com/firmacorreo/firmacorreo.png></p>" + Environment.NewLine + "Has recibido este email porque has solictado una cita en el centro médico. Por favor, no responda a este correo\r\nelectronico: ha sido generado automáticamente.";

                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Host = "smtp.hostinger.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("consultorio@reynaldomd.com", "2024-Consultorio");
                smtp.EnableSsl = true;

                MailMessage correo = new MailMessage();
                correo.From = new MailAddress("consultorio@reynaldomd.com");
                correo.To.Add(destino);
                correo.Subject = asunto;
                correo.Body = mensaje;
                correo.IsBodyHtml = true;
                correo.Priority = MailPriority.Normal;
                smtp.Send(correo);
                correo.Dispose();
            }
            catch (SmtpException ex)
            {
                MessageBox.Show($"Error al enviar el correo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}


using Consultorio_JVH.Modelo;
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
        public static void EnvioCorreo(string pass, string enviador, string recibidor,
            string mensaje, string asunto, Cita cita)
        {
            MailMessage correo = new MailMessage();
            try
            {
                correo.From = new MailAddress(enviador);
                correo.To.Add(recibidor);
                correo.Subject = asunto;
                correo.Body = mensaje + cita.ToString();
                correo.IsBodyHtml = true;
                correo.Priority = MailPriority.Normal;

                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential(enviador, pass);
                smtp.EnableSsl = true;
                smtp.Send(correo);

                MessageBox.Show("Correo enviado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                correo.Dispose();
            }
        }
    }
}

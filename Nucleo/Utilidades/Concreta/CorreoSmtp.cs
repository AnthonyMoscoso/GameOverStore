using Nucleo.Utilidades.abstracta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Utilidades.Concreta
{
    public class CorreoSmtp : IEnviarCorreo
    {
        public static void Enviar(string dir,string codigo)
        {
            string email = "pruebasemailanthonymoscoso@gmail.com";
            string pass = "PruebasEmail1234";
            string dirigido = dir;

            SmtpClient client = new SmtpClient
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(email, pass),
                Port = 587,
                EnableSsl = true,
                Host = "smtp.gmail.com"
            };

            MailMessage mailMassage = new MailMessage();

            mailMassage.To.Add(new MailAddress(dirigido));
            mailMassage.Subject = "Recuperar Contraseña";
            mailMassage.SubjectEncoding = Encoding.UTF8;
            mailMassage.Bcc.Add(dirigido);

            mailMassage.Body = "CODIGO PARA CAMBIAR SU CONTRASEÑA : " +codigo;
            mailMassage.BodyEncoding = Encoding.UTF8;
            mailMassage.IsBodyHtml = true;
            mailMassage.From = new MailAddress(email);
            mailMassage.Priority = MailPriority.High;
            try
            {
                client.Send(mailMassage);

            }
            catch (Exception ex)
            {
                throw new Exception("No se ha podido enviar el email", ex.InnerException);
            }
            finally
            {
                client.Dispose();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace Proyecto3_Lenguajes
{
    public class CCorreo
    {
        Boolean estado = true;
        String merror;
        public CCorreo(String destinatario, String asunto, String mensaje)
        {
            MailMessage correo = new MailMessage();
            SmtpClient protocolo = new SmtpClient();

            correo.To.Add(destinatario);
            correo.From = new MailAddress("system.prub@gmail.com", "Sistema de Gestion", System.Text.Encoding.UTF8);
            correo.Subject = asunto;
            correo.SubjectEncoding = System.Text.Encoding.UTF8;
            correo.Body = mensaje;
            correo.BodyEncoding = System.Text.Encoding.UTF8;
            //correo.IsBodyHtml = false;

            protocolo.Credentials = new System.Net.NetworkCredential("system.prub@gmail.com", "claret19.");
            protocolo.Port = 587;
            protocolo.Host = "smtp.gmail.com";
            protocolo.EnableSsl = true;

            try
            {
                protocolo.Send(correo);
            }
            catch (SmtpException error)
            {
                Estado = false;
                Merror = error.Message.ToString();
            }
        }

        public bool Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public string Merror
        {
            get
            {
                return merror;
            }

            set
            {
                merror = value;
            }
        }
    }
}
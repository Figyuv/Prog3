using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Configuration;
using System.Net.Configuration;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace email
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MailMessage correo = new MailMessage();
            correo.From = new MailAddress("david.calvi.18@gmail.com", "Dewey", System.Text.Encoding.UTF8);//Correo de salida
            correo.To.Add("figubrave@gmail.com"); //Correo destino?
            correo.Subject = "Dewey Credenciales"; //Asunto
            correo.Body = "Usuario: \nPassword:"; //Mensaje del correo
            correo.IsBodyHtml = true;
            correo.Priority = MailPriority.Normal;
            SmtpClient smtp = new SmtpClient();
            smtp.UseDefaultCredentials = false;
            smtp.Host = "smtp.gmail.com"; //Host del servidor de correo
            smtp.Port = 25; //Puerto de salida
            smtp.Credentials = new System.Net.NetworkCredential("david.calvi.18@gmail.com", "18022003CAd");//Cuenta de correo
            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            smtp.EnableSsl = true;//True si el servidor de correo permite ssl
            smtp.Send(correo);
            Console.ReadKey();
        }
    }
}

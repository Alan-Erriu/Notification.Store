using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Net;
using System.Net.Mail;
using Notification.Store.Services.Services.Interfaces;
namespace Notification.Store.Services.Services.Implementations
{
    public class SendEmailService : ISendEmailService
    {
        public string? SendEmailMessage()
        {
            // Configuración del cliente SMTP
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587, // Puerto común para SMTP
                Credentials = new NetworkCredential("erriu0273@gmail.com", "qxtz nela gozr hyhe"),
                EnableSsl = true, // Asegúrate de que el servidor soporte SSL
            };

            // Configuración del mensaje de correo
            var mailMessage = new MailMessage
            {
                From = new MailAddress("erriu0273@gmail.com", "Alan"),
                Subject = "Notificacion Extrados Store",
                Body = "Hola Este es un mensaje de Extrados Store",
                IsBodyHtml = false, // Cambia a true si usas HTML en el cuerpo del correo
            };

            // Agregar destinatario(s)
            mailMessage.To.Add("info.espaciosled@gmail.com");

            try
            {
                // Enviar el correo
                smtpClient.Send(mailMessage);
                Console.WriteLine("Correo enviado con éxito.");
                return "Ok";
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error al enviar el correo: {ex.Message}");
                return null;
            }

        }

    }
}

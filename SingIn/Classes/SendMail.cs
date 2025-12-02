using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SingIn.Classes
{
    public class SendMail
    {
        public static void SendMessage(string message, string to)
        {
            var SmtpClient = new SmtpClient()
            {
                Port = 587,
                Credentials = new NetworkCredential(),
                EnableSsl = true
            };
            SmtpClient.Send("landaex@yandex.ru", to, "Проект RegIn", message);
        }
    }
}

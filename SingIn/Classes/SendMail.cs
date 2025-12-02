using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace RegIn.Classes
{
    public class SendMail
    {
        public static void SendMessage(string message, string to)
        {
            var SmtpClient = new SmtpClient("smtp.yandex.ru")
            {
                Port = 587,
                Credentials = new NetworkCredential("s0vaPix@yandex.ru", "irviolqymhplfmgu"),
                EnableSsl = true
            };
            SmtpClient.Send("s0vaPix@yandex.ru", to, "Проект RegIn", message);
        }
    }
}

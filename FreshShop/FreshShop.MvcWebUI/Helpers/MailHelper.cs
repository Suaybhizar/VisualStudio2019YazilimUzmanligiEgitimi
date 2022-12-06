using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace FreshShop.MvcWebUI.Helpers
{
    public static class MailHelper
    {
        public static void SendMail(string to,string title,string message)
        {
            MailMessage msg = new MailMessage("freshShopdb2020@gmail.com",to);
            msg.Subject = title;
            msg.Body = message;
            msg.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("freshShopdb2020@gmail.com", "Fresh45!_Shop35A");
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;


            smtp.Send(msg);
        }
    }
}

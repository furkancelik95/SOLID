using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    internal class ReportNotifier // agnostic class
    {
        //public MailSender sender { get; set; }
        private readonly ISender sender;

        public ReportNotifier(ISender sender)
        {
            this.sender = sender;
        }

        public void SendReport()
        {
            //MailSender sender = new MailSender();
            sender.Send();
        }
    }

    public interface ISender
    {
        void Send();
    }

    public class MailSender: ISender
    {
        public void Send() => Console.WriteLine("Sending email...");
    }

    public class WhatsAppSender: ISender
    {
        public void Send() => Console.WriteLine("Sending WhatsApp message...");
    }

    public class TelegramSender: ISender
    {
        public void Send() => Console.WriteLine("Sending Telegram message...");
    }
}

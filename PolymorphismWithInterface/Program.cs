using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismWithInterface
{
    public class Mail
    {
        public string Subject { get; set; }
        public string Sender { get; set; }
        public DateTime Received { get; set; }
    }

    public class Message
    {

    }

    
    public interface INotificationChannel
    {
        //void Send(Mail mail);
        void Send(Message message);
    }

    public class SMSNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending SMS...");
        }
    }
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending Email...");
        }
    }


    //This class is extended to INotificationChannel    
    //public class MailService : INotificationChannel
    //{
    //    public void Send(Message message)
    //    {
    //        Console.WriteLine("Sending email...");
    //    }
    //}


    public class Video
    {

    }

    public class VideoEnconder
    {

        private IList<INotificationChannel> _inotificationChannels;
        public VideoEnconder()
        {
            _inotificationChannels = new List<INotificationChannel>();
        }
        public void Encode(Video video)
        {
            //Video Encoding logic
            foreach (INotificationChannel notificationChannel in _inotificationChannels)
            {
                notificationChannel.Send(new Message());
            }
            
        }

        public void RegisterNotificationChannels(INotificationChannel notificationChannel)
        {
            _inotificationChannels.Add(notificationChannel);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEnconder();
            encoder.RegisterNotificationChannels(new SMSNotificationChannel());
            encoder.RegisterNotificationChannels(new MailNotificationChannel());
            encoder.Encode(new Video());
        }
    }
}

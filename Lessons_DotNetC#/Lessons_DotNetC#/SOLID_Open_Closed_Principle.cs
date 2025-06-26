namespace Lessons_DotNetC_
{
    public class NotificationService 
    {
        //public void SendEmail(string type, string message)
        //{
        //    if(type == "Email")
        //        Console.WriteLine(message);
        //    else if(type == "SMS")
        //        Console.WriteLine(message);
        //}

        public readonly INotifier _notifier;
        public NotificationService(INotifier notifier)
        {
            _notifier = notifier;
        }

        public void NotifyUser(string message)
        {
            _notifier.Send(message);
        }
    }

    public class EmailService : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class SMSService : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class WhatsAppService : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine(message);
        }
    }

    public interface INotifier
    {
        void Send(string message);
    }
}

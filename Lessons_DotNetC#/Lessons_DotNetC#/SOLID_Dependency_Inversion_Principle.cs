namespace Lessons_DotNetC_
{
    public class EmailServices
    {
        public void SendEmail()
        {
            Console.WriteLine("Message sent");
        }
    }

    // ❌ NotificationManager depends on EmailService (a low-level detail).
    // If you want to send SMS instead, you have to modify the class.
    public class NotificationManager
    {
        EmailServices services = new EmailServices();
        public void SendNotification()
        {
            services.SendEmail();
        }
    }

    public interface IMessageService
    {
        void Send(string message);
    }

    public class EmailServicesDIP : IMessageService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email: {message}");
        }
    }

    public class SmsService : IMessageService
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS: {message}");
        }
    }

    public class NotificationManagerDIP
    {
        private readonly IMessageService _messageService;

        public NotificationManagerDIP(IMessageService messageService)
        {
            _messageService = messageService; // depends on abstraction ✅
        }

        public void Notify(string message)
        {
            _messageService.Send(message);
        }

        static void Main(string[] args)
        {
            var notifier = new NotificationManagerDIP(new EmailServicesDIP());
            notifier.Notify("Welcome via Email!");

            notifier = new NotificationManagerDIP(new SmsService());
            notifier.Notify("OTP via SMS");

        }
    }
}

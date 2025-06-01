namespace Chapter_2___Absract_Classes___Interfaces
{
    #region Tightly Coupled Implementation 
    public class EmailSender
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }

    public class NotificationService
    {
        public void Send()
        {
            EmailSender sender = new EmailSender(); // 👈 Tightly Coupled
            sender.SendEmail("Welcome");
        }
    }
    #endregion

    #region Correct Implementation
    public class EmailNotifierService : INotificationServices
    {
        public void Send(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class SmsNotifierService : INotificationServices
    {
        public void Send(string message)
        {
            Console.WriteLine(message);
        }
    }
    public interface INotificationServices
    {
        void Send(string message);
    }
    public class NotificationServices
    {
        public readonly INotificationServices _notificationServices;
        public NotificationServices(INotificationServices notificationServices)
        {
            _notificationServices = notificationServices;
        }

        public void Notify(string message)
        {
            _notificationServices.Send(message);
        }

        //static void Main(string[] args)
        //{
        //    // Now we can easily swap Implementation
        //    var service = new NotificationServices(new EmailNotifierService());
        //    service.Notify("EmailNotification");

        //    service = new NotificationServices(new SmsNotifierService());
        //    service.Notify("SmsNotification");
        //}
    }
    #endregion
}

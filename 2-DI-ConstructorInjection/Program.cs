namespace _2_DI_ConstructorInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMessageService messageService = new EmailMessageService();

            NotificationSender notificationSender = new NotificationSender(messageService);
            notificationSender.Notify("İlk Nesnem");

            NotificationSender notificationSender1 = new NotificationSender(messageService);
            notificationSender1.Notify("İkinci Nesnem");


            IMessageService messageService1 = new SMSMessageService();

            NotificationSender notificationSender2 = new NotificationSender(messageService1);
            notificationSender2.Notify("Üçüncü Nesnem");
        }
    }
}

namespace _3_DI_PropertiesInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationSender sender = new NotificationSender();
            sender._messageService = new EmailMessageService();

            sender.Notify("Merhaba Dünya");
        }
    }
}

namespace _4_DI_MethodInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationSender sender = new NotificationSender();
            sender.Notify("Merhaba Dünya", new EmailMessageService());
        }
    }
}

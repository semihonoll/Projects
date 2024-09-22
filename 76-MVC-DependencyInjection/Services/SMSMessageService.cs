namespace _76_MVC_DependencyInjection.Services
{
    public class SMSMessageService : IMessageService
    {
        public string SendMessage(string message)
        {
            return $"SMS gönderildi: {message}";
        }
    }
}

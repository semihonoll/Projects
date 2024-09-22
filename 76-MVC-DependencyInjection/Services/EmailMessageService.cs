namespace _76_MVC_DependencyInjection.Services
{
    public class EmailMessageService : IMessageService
    {
        public string SendMessage(string message)
        {
            return $"Email gönderildi: {message}";
        }
    }
}

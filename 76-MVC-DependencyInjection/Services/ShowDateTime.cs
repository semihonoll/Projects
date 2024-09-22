
namespace _76_MVC_DependencyInjection.Services
{
    public class ShowDateTime : IShowDateTime
    {
        public DateTime GetDateTime { get; } = DateTime.Now;
    }
}

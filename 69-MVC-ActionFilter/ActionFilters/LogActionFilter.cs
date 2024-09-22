using Microsoft.AspNetCore.Mvc.Filters;

namespace _69_MVC_ActionFilter.ActionFilters
{
    public class LogActionFilter : IActionFilter
    {
        private readonly ILogger<LogActionFilter> _logger;

        public LogActionFilter(ILogger<LogActionFilter> logger)
        {
            _logger = logger;
        }

        //Controller Action çalıştırılmadan önce bu metot çalışır.
        public void OnActionExecuting(ActionExecutingContext context)
        {
            string cntrllName = context.RouteData.Values["controller"].ToString();
            string actionName = context.RouteData.Values["action"].ToString();
            string logMessage = $"Executing {cntrllName}.{actionName} at {DateTime.Now}";
            LogToMySystem(logMessage);
        }

        //Controller Action çalıştırıldıktan sonra bu metot çalışır.
        public void OnActionExecuted(ActionExecutedContext context)
        {
            string cntrllName = context.RouteData.Values["controller"].ToString();
            string actionName = context.RouteData.Values["action"].ToString();
            string logMessage = $"Executed {cntrllName}.{actionName} at {DateTime.Now}";
            LogToMySystem(logMessage);
        }

        private void LogToMySystem(string message)
        {
            _logger.LogInformation(message);
            //Console.WriteLine(message);
        }
    }
}

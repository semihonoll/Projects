namespace _60_MVC_Intro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //Services
            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            //Middleware

            app.UseStaticFiles();
            app.UseRouting();
            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}

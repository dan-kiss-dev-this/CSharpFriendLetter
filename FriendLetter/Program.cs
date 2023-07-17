using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace FriendLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            WebApplication app = builder.Build();

            // get to see Developer exception page through LaunchSettings.json, first profile aka dev is default
            // to run the prod profile do $dotnet watch run --launch-profile "production"
            // app.UseDeveloperExceptionPage();

            app.UseRouting();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
            );

            app.Run();
        }
    }
}
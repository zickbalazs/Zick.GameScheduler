using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Zick.GameScheduler.Database;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = new HostApplicationBuilder(args);
        
        builder.Services.AddDbContext<IdentityContext>(options =>
            options.UseNpgsql(Environment.GetEnvironmentVariable("IDENTITY_DB_CONNECTION")));
        builder.Services.AddDbContext<RaceContext<IdentityUser>>(options =>
            options.UseNpgsql(Environment.GetEnvironmentVariable("RACE_DB_CONNECTION")));


        var app = builder.Build();
        app.Run();
    }
}
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
        
        builder.Services.AddDbContext<RaceContext<IdentityUser>>(options =>
            options.UseNpgsql(Environment.GetEnvironmentVariable("RACE_DB_CONNECTION")));

        builder.Services
            .AddDefaultIdentity<IdentityUser>()
            .AddEntityFrameworkStores<RaceContext<IdentityUser>>();
        var app = builder.Build();
        app.Run();
    }
}
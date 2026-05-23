using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Zick.GameScheduler.Data;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = new HostApplicationBuilder(args: args);
        // Add .NET User Secrets for migrations
        builder.Configuration.AddUserSecrets(typeof(Program).Assembly);
        // Add PostgreSQL connection
        builder.Services.AddDbContext<SchedulerContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
        
        var app = builder.Build();
        app.Run();
    }
}
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Zick.GameScheduler.Models;

namespace Zick.GameScheduler.Data;

public class SchedulerContext(DbContextOptions options) : IdentityDbContext<IdentityUser>(options)
{
    public DbSet<Vehicle<IdentityUser>> Vehicles { get; set; }
    public DbSet<Track> Tracks { get; set; }
    public DbSet<RacingClass<IdentityUser>> RacingClasses { get; set; }
    public DbSet<League<IdentityUser>> Leagues { get; set; }
    public DbSet<Event<IdentityUser>> Events { get; set; }
    public DbSet<Race<IdentityUser>> Races { get; set; }
    public DbSet<Registration<IdentityUser>> Registrations { get; set; }
}
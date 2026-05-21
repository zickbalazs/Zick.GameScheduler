using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Zick.GameScheduler.Models;

namespace Zick.GameScheduler.Database;

public class RaceContext<TUser> : IdentityDbContext
{
    public DbSet<Track> Tracks { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<RacingClass> RacingClasses { get; set; }
    public DbSet<League>  Leagues { get; set; }
    public DbSet<LeagueEvent> LeagueEvents { get; set; }
    public DbSet<EventRace<IdentityUser>> EventRaces { get; set; }
    public DbSet<Registration<IdentityUser>> Registrations { get; set; }
}
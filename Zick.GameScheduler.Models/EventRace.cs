using System.ComponentModel.DataAnnotations;

namespace Zick.GameScheduler.Models;
/// <summary>
/// Represents a race for a league event.
/// </summary>
/// <typeparam name="TUser">A User that can be associated to a registration</typeparam>
public class EventRace<TUser>
{
    [Key]
    public Guid Id { get; set; }
    
    public DateTime StartTime { get; set; }

    public virtual LeagueEvent Event { get; set; }
    public virtual IList<Registration<TUser>> Registrations { get; } = [];
}
using System.ComponentModel.DataAnnotations;

namespace Zick.GameScheduler.Models;
/// <summary>
/// Represents races within an event.
/// </summary>
/// <typeparam name="TUser">A type that can be used to associate with racers.</typeparam>
public class Race<TUser>
{
    [Key]
    public Guid Id { get; set; }

    public DateTime StartTime { get; set; }
    
    /// <summary>
    /// Navigation property for the participants in this race.
    /// </summary>
    public virtual IList<Registration<TUser>> Registrations { get; } = [];
}
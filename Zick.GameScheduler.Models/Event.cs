using System.ComponentModel.DataAnnotations;

namespace Zick.GameScheduler.Models;
/// <summary>
/// Represents an event in a racing league. The simulation swarm uses these events to rotate AMS2 instances.
/// </summary>
/// <typeparam name="TUser">A type that can be used to associate with racers.</typeparam>
public class Event<TUser>
{
    [Key]
    public Guid Id { get; set; }

    /// <summary>
    /// The frequency to start servers in defined by minutes. By default, events start every hour.
    /// </summary>
    public int StartServerEveryMinutes { get; set; } = 60; 

    /// <summary>
    /// Used for lap-based races, if not given the <c>RaceTime</c> must be given.
    /// </summary>
    public int? Laps { get; set; }
    
    /// <summary>
    /// Used for time-based races, if not given the <c>Laps</c> must be given.
    /// </summary>
    public int? Time { get; set; }
    
    /// <summary>
    /// The date in which this event starts. By default, the value is the current time on the server.
    /// </summary>
    public DateTime FromDate { get; set; } = DateTime.Now;
    
    /// <summary>
    /// The date in which this event ends.
    /// </summary>
    /// <value>If <c>null</c> the event rotates until an end date is given, otherwise until the date specified.</value>
    public DateTime? ToDate { get; set; }
    
    /// <summary>
    /// The navigation property for the League this event is in.
    /// </summary>
    [Required]
    public virtual League<TUser> League { get; set; }
    
    /// <summary>
    /// The navigation property for the circuit used in this event.
    /// </summary>
    [Required]
    public virtual Track Circuit { get; set; }

    /// <summary>
    /// The servers allocated by the <c>StartServerEveryMinutes</c> parameter.
    /// </summary>
    public virtual IList<Race<TUser>> Races { get; } = [];
}
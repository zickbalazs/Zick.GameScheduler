using System.ComponentModel.DataAnnotations;

namespace Zick.GameScheduler.Models;

/// <summary>
/// Represents an event in a league, users can register to these events' races.
/// </summary>
public class LeagueEvent
{
    [Key]
    public Guid Id { get; set; }
    
    /// <summary>Represents the server rotation for every nth minute.</summary>
    public int RotateEveryMinutes { get; set; } = 30;
    
    /// <summary>Represents when to start the server rotation.</summary>
    public DateTime FromDate { get; set; } = DateTime.Now;

    /// <summary>Represents when to stop the server rotation (Optional).</summary>
    public DateTime ToDate { get; set; } = DateTime.Now + TimeSpan.FromDays(7);
    
    /// <summary>The Track used in this rotation</summary>
    [Required]
    public virtual Track Track { get; set; }
    /// <summary>The league that this event is in</summary>
    [Required]
    public virtual League League { get; set; }
}
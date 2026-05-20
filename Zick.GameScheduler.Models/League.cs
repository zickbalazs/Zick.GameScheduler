using System.ComponentModel.DataAnnotations;

namespace Zick.GameScheduler.Models;

/// <summary>
/// This object defines a league that rotates on the server. 
/// </summary>
public class League
{
    [Key]
    public Guid Id { get; set; }
    
    /// <summary>The title of the event. Ideally the main identifying string for the end-user.</summary>
    /// <example>Rookie Cup</example>
    [Required]
    public required string Name { get; set; }
    
    /// <summary>The amount of people an event should hold.</summary>
    public int ParticipantsPerRace { get; set; } = 18;
    
    /// <summary>Navigation property for the classes used in this league.</summary>
    public virtual IList<RacingClass> Classes { get; } = [];
    
    /// <summary>Navigation property for the events in this league</summary>
    public virtual IList<LeagueEvent> Events { get; } = [];
}
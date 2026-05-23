using System.ComponentModel.DataAnnotations;

namespace Zick.GameScheduler.Models;

/// <summary>
/// Represents a racing league that users can participate in.
/// </summary>
/// <typeparam name="TUser">A type that can be used to associate with racers.</typeparam>
public class League<TUser>
{
    [Key]
    public Guid Id { get; set; }
    
    [Required]
    public required string Name { get; set; }
    
    /// <summary>
    /// The maximum allowed participants in the league.
    /// By default, the maximum size is the smallest grid size having circuit's limit.
    /// </summary>
    public int GridSize { get; set; }
    
    /// <summary>
    /// Navigation property for racing classes in this league.
    /// </summary>
    public virtual IList<RacingClass<TUser>> RacingClasses { get; } = [];

    /// <summary>
    /// Navigation property for events in this league.
    /// </summary>
    public virtual IList<Event<TUser>> Schedule { get; } = [];
}
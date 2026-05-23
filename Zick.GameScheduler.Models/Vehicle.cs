using System.ComponentModel.DataAnnotations;

namespace Zick.GameScheduler.Models;

/// <summary>
/// Represents a vehicle that users can use in registrations.
/// </summary>
/// <seealso href="https://ams2.enum.gg/docs/id/vehicle"/>
/// <typeparam name="TUser">A user type that can be used to associate with racers.</typeparam>
public class Vehicle<TUser>
{
    [Key]
    public Guid Id { get; set; }
    
    /// <summary>
    /// The human-readable name of the vehicle
    /// </summary>
    /// <example>Alpine A110 GT4</example>
    [Required]
    public required string Name { get; set; }
    
    /// <summary>
    /// The identifier that AMS2 uses.
    /// </summary>
    [Required]
    public required string GameId { get; set; }

    /// <summary>
    /// Navigation class for the racing classes this vehicle is in.
    /// </summary>
    public virtual IList<RacingClass<TUser>> RacingClasses { get; } = [];
}
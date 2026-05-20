using System.ComponentModel.DataAnnotations;

namespace Zick.GameScheduler.Models;
/// <summary>
/// This object defines a vehicle, that can be used in Automobilista 2.
/// This object is used most commonly to define racing classes.
/// </summary>
public class Vehicle
{
    [Key]
    public Guid Id { get; set; }
    
    /// <summary>The vehicle model name.</summary>
    /// <example>Alpine A110 GT4</example>
    [Required]
    public required string Name { get; set; }
    
    /// <summary>The location for the image of the vehicle</summary>
    /// <example>$UPLOADS/img/vehicle.png</example>
    [Required]
    public required string ImageUrl { get; set; }
 
    /// <summary>The id used in game for the vehicle, the value can change with game updates.</summary>
    /// <seealso href="https://ams2.enum.gg/docs/id/vehicle"/>
    [Required]
    public required string GameId { get; set; }
}
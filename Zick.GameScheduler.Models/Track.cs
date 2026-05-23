using System.ComponentModel.DataAnnotations;

namespace Zick.GameScheduler.Models;

/// <summary>
/// Represents a racetrack in AMS2 and presents it to the user in a more readable fashion.
/// </summary>
/// <seealso href="https://ams2.enum.gg/docs/id/tracks"/>
public class Track
{
    [Key]
    public Guid Id { get; set; }
    
    /// <summary>
    /// The human-readable name of the circuit.
    /// </summary>
    /// <example>Circuit Spa Francorchamps</example>
    [Required]
    public required string Name { get; set; }
    
    /// <summary>
    /// The identifier that AMS2 uses.
    /// </summary>
    [Required]
    public required string GameId { get; set; }

    /// <summary>
    /// The maximum allowed number of participants for the circuit.
    /// </summary>
    [Required]
    public int GridSize { get; set; } = 16;
}
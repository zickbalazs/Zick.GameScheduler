using System.ComponentModel.DataAnnotations;

namespace Zick.GameScheduler.Models;
/// <summary>
/// Represents a track in Automobilista 2.
/// </summary>
public class Track
{
    public Guid Id { get; set; }
    
    /// <summary>The name of the track that is displayed for the users.</summary>
    /// <example>Road Atlanta</example>
    [Required]
    public required string Name { get; set; }
    
    /// <summary>The identifier for the track used in-game. Game updates can change this value.</summary>
    /// <seealso href="https://ams2.enum.gg/docs/id/tracks"/>
    [Required]
    public required string GameId { get; set; }
}
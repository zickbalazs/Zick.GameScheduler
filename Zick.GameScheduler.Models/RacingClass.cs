using System.ComponentModel.DataAnnotations;

namespace Zick.GameScheduler.Models;

/// <summary>
/// This object defines which vehicles fight for which positions.
/// Can also be used to create multi-class events or to simply define a single class racing event.
/// </summary>
public class RacingClass
{
    /// <summary>The class identifier. Must be given.</summary>
    /// <example>LMGTE</example>
    [Key]
    public required string ClassId { get; set; }
    /// <value>The class' identifying color. Must match a hash-based color code.</value>
    /// <example>#ae67fe</example>
    [Required]
    [RegularExpression(@"^#(?:[0-9a-fA-F]{3}){1,2}$")]
    public string ClassColor { get; set; } = "#fff";
    /// <summary>Navigation property for the vehicles used in this class.</summary>
    public virtual IList<Vehicle> ClassVehicles { get; set; } = [];
}
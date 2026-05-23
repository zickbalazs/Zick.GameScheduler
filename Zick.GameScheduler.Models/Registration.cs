using System.ComponentModel.DataAnnotations;

namespace Zick.GameScheduler.Models;

/// <summary>
/// Represents a registration for an Event in a League
/// </summary>
/// <typeparam name="TUser">A user type that can be used to associate with racers.</typeparam>
public class Registration<TUser>
{
    public Guid Id { get; set; }
    
    /// <summary>
    /// The race the user registered for.
    /// </summary>
    public virtual Race<TUser> Race { get; set; }
    
    /// <summary>
    /// The racing class the user is in.
    /// </summary>
    [Required]
    public virtual RacingClass<TUser> RacingClass { get; set; }
    
    /// <summary>
    /// Navigation property for the car used in this race.
    /// </summary>
    [Required]
    public virtual Vehicle<TUser> VehicleUsed { get; set; }
}
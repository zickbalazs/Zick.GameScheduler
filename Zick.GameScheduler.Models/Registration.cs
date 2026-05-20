using System.ComponentModel.DataAnnotations;

namespace Zick.GameScheduler.Models;
/// <summary>
/// Represents an entry for an <c>EventRace</c>
/// </summary>
/// <typeparam name="TUser">A User type that can be associated for a racer.</typeparam>
public class Registration<TUser>
{
    [Key]
    public Guid Id { get; set; }
    
    /// <summary>The <c>TUser</c>, who wants to race in this registration</summary>
    [Required]
    public virtual TUser User { get; set; }
    
    /// <summary>The race in which the user wants to race in.</summary>
    [Required]
    public virtual EventRace<TUser> EventRace { get; set; }
    
    /// <summary>The racing class that the user wants to participate in.</summary>
    [Required]
    public virtual RacingClass RacingClass { get; set; }
    
    /// <summary>The vehicle
    /// which the user wants to use.</summary>
    [Required]
    public virtual Vehicle Vehicle { get; set; }
}
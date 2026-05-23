using System.ComponentModel.DataAnnotations;

namespace Zick.GameScheduler.Models;

/// <summary>
/// Represents racing classes for leagues. Can be also used as a single-model championship if only one car is provided
/// </summary>
/// <typeparam name="TUser">A type that can be used to associate with racers.</typeparam>
public class RacingClass<TUser>
{
    /// <summary>
    /// The abbreviation of the racing class, can only contain alphanumeric characters.
    /// Values must be unique due to being used as a key.
    /// </summary>
    /// <example>GT3</example>
    [Key]
    public required string Abbreviation { get; set; }

    /// <summary>
    /// The more human-readable version of the class.
    /// If none is provided, the readable version will be the abbreviation. 
    /// </summary>
    public string? Name { get; set; }
    
    /// <summary>
    /// The Color for distinguishing classes.
    /// Value is optional, is only used for the frontend only.
    /// </summary>
    /// <example>#fffeee</example>
    public string? Color { get; set; }

    /// <summary>
    /// Navigation Property for the vehicles used in this class.
    /// </summary>
    public virtual IList<Vehicle<TUser>> Vehicles { get; } = [];
    
    /// <summary>
    /// Navigation Property for events in which this racing class is used.
    /// </summary>
    public virtual IList<Event<TUser>> Events { get; } = [];
}
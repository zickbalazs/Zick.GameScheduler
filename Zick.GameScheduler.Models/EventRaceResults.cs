using System.ComponentModel.DataAnnotations;

namespace Zick.GameScheduler.Models;

public class EventRaceResults<TUser>
{
    [Key]
    public Guid Id { get; set; }
    
    [Required]
    public virtual EventRace<TUser> Race { get; set; }
    public virtual IList<TUser> Result { get; } = [];
}
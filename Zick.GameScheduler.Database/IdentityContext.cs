using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Zick.GameScheduler.Database;

public class IdentityContext : IdentityDbContext<IdentityUser, IdentityRole, string>
{}
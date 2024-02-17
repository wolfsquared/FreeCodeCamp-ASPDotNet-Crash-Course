using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FreeCodeCamp_ASPDotNet_Crash_Course;

namespace FreeCodeCamp_ASPDotNet_Crash_Course.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

public DbSet<FreeCodeCamp_ASPDotNet_Crash_Course.Joke> Joke { get; set; } = default!;
}

using Microsoft.EntityFrameworkCore;
using Tasks.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Define your DbSets (tables) here
    public DbSet<User> Users { get; set; }
}

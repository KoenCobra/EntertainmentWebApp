using EntertainmentWebApp.Shared;
using Microsoft.EntityFrameworkCore;

namespace EntertainmentWebApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Media>? Media { get; set; }
}
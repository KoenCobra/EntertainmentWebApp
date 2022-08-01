using System.Text.Json;
using EntertainmentWebApp.Data;
using EntertainmentWebApp.Shared;
using Microsoft.EntityFrameworkCore;

namespace EntertainmentWebApp.Server;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new ApplicationDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>());

        if (context.Media != null && context.Media.Any()) return;
        var env = serviceProvider.GetRequiredService<IWebHostEnvironment>();
        var path = Path.Combine(env.ContentRootPath, "data.json");
        var jsonString = File.ReadAllText(path);
        var media = JsonSerializer.Deserialize<List<Media>>(jsonString);

        if (media != null)
        {
            context.Media.AddRange(media);
            context.SaveChanges();
        }
    }
}
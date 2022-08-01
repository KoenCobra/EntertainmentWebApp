using System.Net.Http.Json;
using EntertainmentWebApp.Data;
using EntertainmentWebApp.Shared;
using EntertainmentWepApp.Services.Abstractions;

namespace EntertainmentWepApp.Services;

public class MediaService : IMediaService
{
    private readonly ApplicationDbContext _dbContext;
    private readonly HttpClient _httpClient;

    public MediaService(HttpClient httpClient, ApplicationDbContext dbContext)
    {
        _httpClient = httpClient;
        _dbContext = dbContext;
    }

    public async Task<List<Media>?> GetMediaListAsync()
    {
        var media = await _httpClient.GetFromJsonAsync<List<Media>>("data.json");

        if (_dbContext.Media != null)
            if (media != null)
            {
                await _dbContext.Media.AddRangeAsync(media);
                await _dbContext.SaveChangesAsync();
            }

        return media;
    }
}
using System.Net.Http.Json;
using EntertainmentWebApp.Server.Abstractions;
using EntertainmentWebApp.Shared;

namespace EntertainmentWebApp.Services;

public class MediaService : IMediaService
{
    private readonly HttpClient _httpClient;

    public MediaService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Media>?> GetMediaListAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<Media>>("data.json");
    }
}
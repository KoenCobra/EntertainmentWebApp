using EntertainmentWebApp.Shared;

namespace EntertainmentWepApp.Services.Abstractions;

public interface IMediaService
{
    Task<List<Media>?> GetMediaListAsync();
}
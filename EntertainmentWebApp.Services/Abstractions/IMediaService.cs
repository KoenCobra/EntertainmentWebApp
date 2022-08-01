using EntertainmentWebApp.Shared;

namespace EntertainmentWebApp.Server.Abstractions;

public interface IMediaService
{
    Task<List<Media>?> GetMediaListAsync();
}
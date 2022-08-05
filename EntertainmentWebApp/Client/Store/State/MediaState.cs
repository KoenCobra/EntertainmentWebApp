using EntertainmentWebApp.Client.Models;

namespace EntertainmentWebApp.Client.Store.State;

public class MediaState : RootState
{
    public MediaState(bool isLoading, string? currentErrorMessage, IEnumerable<Media>? medias, Media? media) : base(
        isLoading, currentErrorMessage)
    {
        Medias = medias;
        Media = media;
    }

    public IEnumerable<Media>? Medias { get; }

    public Media? Media { get; }
}
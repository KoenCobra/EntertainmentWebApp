using EntertainmentWebApp.Shared;

namespace EntertainmentWebApp.Client.Store.State;

public class BookMarkState : RootState
{
    public BookMarkState(bool isLoading, string? currentErrorMessage, IEnumerable<Media>? medias, Media? media) : base(
        isLoading, currentErrorMessage)
    {
        Medias = medias;
        Media = media;
    }

    public IEnumerable<Media>? Medias { get; }

    public Media? Media { get; }
}
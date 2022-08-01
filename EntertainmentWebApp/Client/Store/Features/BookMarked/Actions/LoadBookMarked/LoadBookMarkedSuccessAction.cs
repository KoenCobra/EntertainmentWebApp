using EntertainmentWebApp.Shared;

namespace EntertainmentWebApp.Client.Store.Features.BookMarked.Actions.LoadBookMarked;

public class LoadBookMarkedSuccessAction
{
    public LoadBookMarkedSuccessAction(IEnumerable<Media> medias)
    {
        Media = medias;
    }

    public IEnumerable<Media> Media { get; }
}
namespace EntertainmentWebApp.Client.Store.Features.Media.Actions.LoadMedia;

public class LoadMediaSuccessAction
{
    public LoadMediaSuccessAction(IEnumerable<EntertainmentWebApp.Shared.Media> medias)
    {
        Media = medias;
    }

    public IEnumerable<EntertainmentWebApp.Shared.Media> Media { get; }
}
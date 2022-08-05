namespace EntertainmentWebApp.Client.Store.Features.Media.Actions.LoadMedia;

public class LoadMediaSuccessAction
{
    public LoadMediaSuccessAction(IEnumerable<Models.Media> medias)
    {
        Media = medias;
    }

    public IEnumerable<Models.Media> Media { get; }
}
using EntertainmentWebApp.Client.Store.State;

namespace EntertainmentWebApp.Client.Store.Features.Media;

public class MediaFeature : Feature<MediaState>
{
    public override string GetName()
    {
        return "MediaState";
    }

    protected override MediaState GetInitialState()
    {
        return new MediaState(false, null, null, null);
    }
}
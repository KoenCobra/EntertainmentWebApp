using EntertainmentWebApp.Client.Store.Features.Shared.Actions;

namespace EntertainmentWebApp.Client.Store.Features.Media.Actions.LoadMedia;

public class LoadMediaFailureAction : FailureAction
{
    public LoadMediaFailureAction(string errorMessage)
        : base(errorMessage)
    {
    }
}
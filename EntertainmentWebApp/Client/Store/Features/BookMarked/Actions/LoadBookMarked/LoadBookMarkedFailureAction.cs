using EntertainmentWebApp.Client.Store.Features.Shared.Actions;

namespace EntertainmentWebApp.Client.Store.Features.BookMarked.Actions.LoadBookMarked;

public class LoadBookMarkedFailureAction : FailureAction
{
    public LoadBookMarkedFailureAction(string errorMessage)
        : base(errorMessage)
    {
    }
}
using EntertainmentWebApp.Client.Store.Features.Media.Actions.LoadMedia;
using EntertainmentWebApp.Client.Store.State;

namespace EntertainmentWebApp.Client.Store.Features.Media.Reducers;

public class LoadMediaActionsReducer
{
    [ReducerMethod]
    public static MediaState ReduceLoadMediaAction(MediaState state, LoadMediaAction _)
    {
        return new MediaState(true, null, null, state.Media);
    }

    [ReducerMethod]
    public static MediaState ReduceLoadMediaSuccessAction(MediaState state,
        LoadMediaSuccessAction action)
    {
        return new MediaState(false, null, action.Media, state.Media);
    }

    [ReducerMethod]
    public static MediaState ReduceLoadMediaFailureAction(MediaState state,
        LoadMediaFailureAction action)
    {
        return new MediaState(false, action.ErrorMessage, null, state.Media);
    }
}
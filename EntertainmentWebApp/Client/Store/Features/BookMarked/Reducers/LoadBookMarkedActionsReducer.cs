using EntertainmentWebApp.Client.Store.Features.BookMarked.Actions.LoadBookMarked;
using EntertainmentWebApp.Client.Store.State;

namespace EntertainmentWebApp.Client.Store.Features.BookMarked.Reducers;

public class LoadBookMarkedActionsReducer
{
    [ReducerMethod]
    public static BookMarkState ReduceLoadBookMarkedAction(BookMarkState state, LoadBookMarkedAction _)
    {
        return new BookMarkState(true, null, null, state.Media);
    }

    [ReducerMethod]
    public static BookMarkState ReduceLoadBookMarkedSuccessAction(BookMarkState state,
        LoadBookMarkedSuccessAction action)
    {
        return new BookMarkState(false, null, action.Media, state.Media);
    }

    [ReducerMethod]
    public static BookMarkState ReduceLoadBookMarkedFailureAction(BookMarkState state,
        LoadBookMarkedFailureAction action)
    {
        return new BookMarkState(false, action.ErrorMessage, null, state.Media);
    }
}
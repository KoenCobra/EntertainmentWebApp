using EntertainmentWebApp.Client.Store.Features.BookMarked.Actions.LoadBookMarked;

namespace EntertainmentWebApp.Client.Store.Services;

public class StateFacade
{
    private readonly IDispatcher _dispatcher;
    private readonly ILogger<StateFacade> _logger;

    public StateFacade(ILogger<StateFacade> logger, IDispatcher dispatcher)
    {
        (_logger, _dispatcher) = (logger, dispatcher);
    }

    public void LoadBookMarked()
    {
        _logger.LogInformation("Issuing action to load bookmarked...");
        _dispatcher.Dispatch(new LoadBookMarkedAction());
    }
}
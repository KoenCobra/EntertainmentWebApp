using System.Net.Http.Json;
using EntertainmentWebApp.Client.Store.Features.BookMarked.Actions.LoadBookMarked;
using EntertainmentWebApp.Shared;

namespace EntertainmentWebApp.Client.Store.Features.BookMarked.Effects;

public class LoadBookMarkedEffect : Effect<LoadBookMarkedAction>
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<LoadBookMarkedEffect> _logger;

    public LoadBookMarkedEffect(ILogger<LoadBookMarkedEffect> logger, HttpClient httpClient)
    {
        _logger = logger;
        _httpClient = httpClient;
    }


    public override async Task HandleAsync(LoadBookMarkedAction action, IDispatcher dispatcher)
    {
        try
        {
            _logger.LogInformation("Loading Media...");

            await Task.Delay(TimeSpan.FromMilliseconds(1000));
            var response = await _httpClient.GetFromJsonAsync<IEnumerable<Media>>("data.json");

            _logger.LogInformation("Media loaded successfully!");

            if (response != null)
            {
                dispatcher.Dispatch(new LoadBookMarkedSuccessAction(response));
            }
        }
        catch (Exception e)
        {
            _logger.LogError($"Error loading Media, reason: {e.Message}");
            dispatcher.Dispatch(new LoadBookMarkedFailureAction(e.Message));
        }
    }
}
using System.Net.Http.Json;
using EntertainmentWebApp.Client.Store.Features.Media.Actions.LoadMedia;

namespace EntertainmentWebApp.Client.Store.Features.Media.Effects;

public class LoadMediaEffect : Effect<LoadMediaAction>
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<LoadMediaEffect> _logger;

    public LoadMediaEffect(ILogger<LoadMediaEffect> logger, HttpClient httpClient)
    {
        _logger = logger;
        _httpClient = httpClient;
    }


    public override async Task HandleAsync(LoadMediaAction action, IDispatcher dispatcher)
    {
        try
        {
            _logger.LogInformation("Loading Media...");

            await Task.Delay(TimeSpan.FromMilliseconds(1000));
            var response =
                await _httpClient.GetFromJsonAsync<IEnumerable<Models.Media>>("data.json");


            _logger.LogInformation("Media loaded successfully!");

            if (response != null)
            {
                dispatcher.Dispatch(new LoadMediaSuccessAction(response));
            }
        }
        catch (Exception e)
        {
            _logger.LogError($"Error loading Media, reason: {e.Message}");
            dispatcher.Dispatch(new LoadMediaFailureAction(e.Message));
        }
    }
}
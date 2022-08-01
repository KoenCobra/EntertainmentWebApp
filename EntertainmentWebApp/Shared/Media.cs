namespace EntertainmentWebApp.Shared;

public class Media
{
    public string? title { get; set; }
    public Thumbnail? thumbnail { get; set; }
    public int? year { get; set; }
    public string? category { get; set; }
    public string? rating { get; set; }
    public bool isBookmarked { get; set; }
    public bool isTrending { get; set; }
}
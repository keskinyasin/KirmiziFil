namespace KirmiziFil.Web.ViewModels;

public class HomeViewModel
{
    public HeroViewModel Hero { get; set; } = new();
    public EventsViewModel Events { get; set; } = new();

}

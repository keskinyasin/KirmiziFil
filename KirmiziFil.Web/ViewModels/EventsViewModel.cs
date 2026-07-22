namespace KirmiziFil.Web.ViewModels
{
    public class EventsViewModel
    {
        public string AllEventsUrl { get; set; } = "#";
        public List<EventItem> Events { get; set; } = new();
    }

    public class EventItem
    {
        public string Day { get; set; } = "";
        public string Month { get; set; } = "";
        public string Title { get; set; } = "";
        public string DayOfWeek { get; set; } = "";
        public string Time { get; set; } = "";
    }
}
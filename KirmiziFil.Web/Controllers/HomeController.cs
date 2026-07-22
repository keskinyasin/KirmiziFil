using KirmiziFil.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KirmiziFil.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var vm = new HomeViewModel
        {
            Hero = new HeroViewModel
            {

                TitleLine1 = "ONAR.",

                TitleLine2 = "DÖNÜŞTÜR.",

                TitleHighlight = "PAYLAŞ.",

                Description =
                    "Eşyana, doğaya ve insanlara iyi bak. Birlikte onaralım, dönüştürelim ve paylaşalım. Daha güzel bir dünya mümkün.",

                PrimaryButtonText = "Manifestoyu Oku",

                PrimaryButtonUrl = "/manifesto",

                SecondaryButtonText = "Topluluğa Katıl",

                SecondaryButtonUrl = "/community",

                Image = "/images/hero/elephant.png"
            },

            Events = new EventsViewModel
            {
                AllEventsUrl = "/etkinlikler",

                Events = new List<EventItem>
                {
                    new EventItem
                    {
                        Day = "13",
                        Month = "MAY",
                        Title = "Elektronik Onarım Atölyesi",
                        DayOfWeek = "Cuma",
                        Time = "14:00"
                    },
                    new EventItem
                    {
                        Day = "19",
                        Month = "MAY",
                        Title = "Dikiş Atölyesi",
                        DayOfWeek = "Cumartesi",
                        Time = "13:00"
                    },
                    new EventItem
                    {
                        Day = "21",
                        Month = "MAY",
                        Title = "Eski Mobilya Yenileme",
                        DayOfWeek = "Pazar",
                        Time = "14:00"
                    },
                    new EventItem
                    {
                        Day = "23",
                        Month = "MAY",
                        Title = "Kahve Demleme Atölyesi",
                        DayOfWeek = "Salı",
                        Time = "15:00"
                    }
                }
            }
        };

        return View(vm);
    }
}
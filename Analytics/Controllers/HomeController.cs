using Analytics.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Analytics.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EventDispatcher _eventDispatcher;

        public HomeController(ILogger<HomeController> logger, EventDispatcher eventDispatcher)
        {
            _logger = logger;
            _eventDispatcher = eventDispatcher;
        }

        public IActionResult Index()
        {
            var userCreatedEventData = new UserRegisteredEventData
            {
                UserName = "JohnDoe74",
                Email = "test@gmail.com"
            };

            var userCreatedEvent = new UserRegisteredEvent(userCreatedEventData);
            _eventDispatcher.Dispatch(userCreatedEvent);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

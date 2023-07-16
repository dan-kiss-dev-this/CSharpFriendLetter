using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
        // the Route is a decorator
        [Route("/hello")]
        public string Hello() { return "Hello Friend!"; }

        [Route("/goodbye")]
        public string Goodbye() { return "Goodbye Friend"; }

        [Route("/")]
        // Notice the changes below!
        public ActionResult Letter() { return View(); }
    }
}
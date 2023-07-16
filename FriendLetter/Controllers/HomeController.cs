using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
        // we extend from built in controller class
        public string Hello() { return "Hello Friend!"; }

        public string GoodBye() { return "Goodbye Friend"; }
    }
}
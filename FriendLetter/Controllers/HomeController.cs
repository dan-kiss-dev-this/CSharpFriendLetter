using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

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
        public ActionResult Letter()
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.Recipient = "Joe Smith";
            myLetterVariable.Sender = "Taylor Johnson";
            return View(myLetterVariable);
        }

        [Route("/form")]
        public ActionResult Form() { return View(); }

        [Route("/postcard")]
        public ActionResult PostCard(string recipient, string sender)
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.Recipient = recipient;
            myLetterVariable.Sender = sender;
            return View(myLetterVariable);
        }
    }
}
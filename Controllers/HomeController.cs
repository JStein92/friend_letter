using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;
namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {

    [Produces("text/html")]
    [Route("/")]
           public ActionResult Hello()
           {
             LetterVariable myLetterVariable = new LetterVariable();
             myLetterVariable.SetRecipient("BOY");
             return View(myLetterVariable);
           }
    [Produces("text/html")]
    [Route("/favorite_photos")]
    public ActionResult FavoritePhotos(){
      return View();
    }

  }
}

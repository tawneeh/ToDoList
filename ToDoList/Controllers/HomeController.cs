using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.MyFavoriteColor = "purple"; // ViewBag is a way to send temporary data from a controller to a View. Here we declare a property of the ViewBag in a route and it will be available to us in the view
      return View();
    }

    [Route("/favorite_photos")]
    public ActionResult FavoritePhotos()
    {
      return View();
    }

  }
}
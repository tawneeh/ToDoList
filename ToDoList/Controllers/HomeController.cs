using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")] // "/" means 'root route' or Homepage
    public ActionResult Index()
    {
      Item starterItem = new Item("Add first item to To Do List");
      return View(starterItem);
    }

    [Route("/items/new")] // this renders the form (CreateForm.cshtml)
    public ActionResult CreateForm()
    {
      return View();
    }

    [Route("/items")] // this tells the controller what to do when the form is submitted (make a new To Do List Item)
    public ActionResult Create(string description) // 'description' because it matches the name attribute of the form
    {
      Item myItem = new Item(description);
      return View("Index", myItem); // this renders a new Item at the "Index" view. Basically rerouting back to the Homepage
    }
  }
}
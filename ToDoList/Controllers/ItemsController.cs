using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;
using System.Linq; // LINQ is short for Language-Integrated Query

namespace ToDoList.Controllers
{
  public class ItemsController : Controller
  {
    private readonly ToDoListContext _db;

    public ItemsController(ToDoListContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Item> model = _db.Items.ToList(); // this replaces GetAll()
      return View(model);

// db is an instance of our DbContext class. It's holding a reference to our database
// Once there, it looks for an object named Items. This is the DbSet we declared in ToDoListContext.cs
// LINQ turns this DbSet into a list using the ToList() method, which comes from the System.Linq namespace
// This expression is what creates the model we'll use for the Index view
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Item item)
    {
      _db.Items.Add(item);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

  }
}
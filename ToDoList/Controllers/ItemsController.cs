using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;
using System.Linq; // LINQ is short for Language-Integrated Query
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering; // gives access to SelectList

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
      List<Item> model = _db.Items.Include(items => items.Category).ToList(); // this replaces GetAll()
      return View(model);

// db is an instance of our DbContext class. It's holding a reference to our database
// Once there, it looks for an object named Items. This is the DbSet we declared in ToDoListContext.cs
// LINQ turns this DbSet into a list using the ToList() method, which comes from the System.Linq namespace
// This expression is what creates the model we'll use for the Index view
    }

    public ActionResult Create()
    {
      ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Name"); // this enables an Item to belong to a category that already exists. 
      return View();
    }

    [HttpPost]
    public ActionResult Create(Item item)
    {
      _db.Items.Add(item);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
        Item thisItem = _db.Items.FirstOrDefault(items => items.ItemId == id);
        return View(thisItem);
    }

    public ActionResult Edit(int id)
    {
        var thisItem = _db.Items.FirstOrDefault(items => items.ItemId == id);
        ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Name"); // same idea as above. SelectList provides a dropdown menu with the database Categories listed
        return View(thisItem);
    }

    [HttpPost]
    public ActionResult Edit(Item item)
    {
        _db.Entry(item).State = EntityState.Modified; // this tells Entity that we want to modify an Item
        _db.SaveChanges(); // this changes the modifications
        return RedirectToAction("Index");
    }

    public ActionResult Delete(int id) // get the item to delete
    {
      var thisItem = _db.Items.FirstOrDefault(items => items.ItemId == id);
      return View(thisItem);
    }

    [HttpPost, ActionName("Delete")] // ActionName("Delete:") refers to the above Delete method that this Post is using. This action actually deletes the item with .Remove()
    public ActionResult DeleteConfirmed(int id)
    {
      var thisItem = _db.Items.FirstOrDefault(items => items.ItemId == id);
      _db.Items.Remove(thisItem);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

  }
}
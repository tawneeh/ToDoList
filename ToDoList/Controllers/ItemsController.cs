using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
  public class ItemsController : Controller
  {

    [HttpGet("/items/new")] // routes specifically to making a new Item
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string description)
    {
      Item myItem = new Item(description);
      return RedirectToAction("Index");
    }

    [HttpPost("/items/delete")]
    public ActionResult DeleteAll()
    {
      Item.ClearAll();
      return View();
    }

    [HttpGet("/categories/{categoryId}/items/{id}")] // the {id} placeholder uses dynamic routing. lesson 32. item needs parent categories
    public ActionResult Show(int id)
    {
    Item foundItem = Item.Find(id);
    return View(foundItem);
    }

  }
}
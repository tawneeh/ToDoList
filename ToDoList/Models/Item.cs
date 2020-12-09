using System.Collections.Generic; // needed to access Lists
namespace ToDoList.Models

{
  public class Item
  {
    public string Description { get; set; } 
    private static List<Item> _instances = new List<Item> {}; // static variable. maintains a list of all Item objects 

    public Item(string description) // constructor - pretty sure
    {
      Description = description;
      _instances.Add(this);
    }

    public static List<Item> GetAll()
    {
      return _instances;
      // Item.GetAll() this would call the GetAll() method directly on the class
    }
  }
}
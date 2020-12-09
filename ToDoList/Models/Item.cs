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
      Item.GetAll(); // does this go here? 
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}
using System.Collections.Generic; // needed to access Lists
namespace ToDoList.Models

{
  public class Item
  {
    public string Description { get; set; } 
    private static List<Item> _instances = new List<Item> {}; // static variable. maintains a list of all Item objects

    public Item(string description) // constructor
    {
      Description = description;
      _instances.Add(this);
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    // public static void Remove(Item task)
    // {
    //   _instances.Remove(task);
    // }

  }
}
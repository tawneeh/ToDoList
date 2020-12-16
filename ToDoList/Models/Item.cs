using System.Collections.Generic; // needed to access Lists
namespace ToDoList.Models

{
  public class Item
  {
    public string Description { get; set; } 
    public int Id { get; }
    private static List<Item> _instances = new List<Item> {}; // static variable. maintains a list of all Item objects

    public Item(string description) // constructor
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count; // this needs to be after _instances.Add(this) otherwise it won't have _instances to .Count
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
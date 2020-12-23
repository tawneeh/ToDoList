using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Category
  {

    public Category()
    {
        this.Items = new HashSet<Item>(); // HashSet is an unordered collection of unique elements. Like a List but can't have duplicates
    }

    public int CategoryId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Item> Items { get; set; } // ICollection is required by Entity. It outlines methods for querying and changing data which Entity needs to work its magic.

  }
}
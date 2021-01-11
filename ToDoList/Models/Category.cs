using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Category
  {
    public Category()
    {
      this.Items = new HashSet<CategoryItem>();
    }

    public int CategoryId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<CategoryItem> Items { get; set; } // CategoryItem is a 'collection navigation property' (a property on one class that references a related class). This allows us to access related Items in Controllers and Views

  }
}
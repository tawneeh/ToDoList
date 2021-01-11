using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public Item()
    {
      this.Categories = new HashSet<CategoryItem>();
    }
    public int ItemId { get; set; } // Entity knows this will be the Primary Key -- anything named ID or [ClassName]Id
    public string Description { get; set; } 
    public ICollection<CategoryItem> Categories { get; }

  }
}

// We don't need Find() or Save() because Entity will take care of it for us! 
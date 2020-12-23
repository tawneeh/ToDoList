namespace ToDoList.Models
{
  public class Item
  {
    public int ItemId { get; set; } // Entity knows this will be the Primary Key -- anything named ID or [ClassName]Id
    public string Description { get; set; } 
    public int CategoryId { get; set; } // links the Item to its specific Category by Id
    public virtual Category Category { get; set; }
  }
}

// We don't need Find() or Save() because Entity will take care of it for us! 
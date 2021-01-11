namespace ToDoList.Models
{
  public class CategoryItem
  {       
    public int CategoryItemId { get; set; }
    public int ItemId { get; set; }
    public int CategoryId { get; set; }
    public Item Item { get; set; }
    public Category Category { get; set; }
  }
}

// This class holds information about the relationship between Category and Item (join table / JOIN entity). Defining properties and including Item and Category as objects. Entity takes care of the rest
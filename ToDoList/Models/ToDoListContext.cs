using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
  public class ToDoListContext : DbContext
  {
    public virtual DbSet<Category> Categories { get; set; } // declared virtual for Lazy-Loading
    public DbSet<Item> Items { get; set; }

    public ToDoListContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // OnConfiguring enables Lazy-Loading
    {
      optionsBuilder.UseLazyLoadingProxies(); 
    }
  }
}
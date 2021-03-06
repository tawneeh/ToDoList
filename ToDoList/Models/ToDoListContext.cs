using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
  public class ToDoListContext : IdentityDbContext<ApplicationUser> // ApplicationUser is the type of IdentityDbContext inherited in this class declaration
  {
    public virtual DbSet<Category> Categories { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<CategoryItem> CategoryItem { get; set; }
    public ToDoListContext(DbContextOptions options) : base(options) { }
  }
}

// Each DbSet will become a table in our database. CategoryItem represents the join table
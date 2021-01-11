using Microsoft.AspNetCore.Identity;

namespace ToDoList.Models
{
  public class ApplicationUser : IdentityUser // extending ApplicationUser with IdentityUser allows access to necessary Identity functuinality and properties - Email, UserName, failed login attempts, etc
  {

  }
}

// ApplicationUser is a class that represents user accounts
// Identity is built to work with Entity and therefore databases
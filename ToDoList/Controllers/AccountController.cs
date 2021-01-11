using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using ToDoList.Models;
using System.Threading.Tasks; // allows use of asynchronous Tasks so we can use async and await to register new users
using ToDoList.ViewModels;

namespace ToDoList.Controllers
{
  public class AccountController : Controller
  {
    private readonly ToDoListContext _db;
    private readonly UserManager<ApplicationUser> _userManager; // this is a service that we are injecting into this constructor so that we have access when we need it
    private readonly SignInManager<ApplicationUser> _signInManager; // same as above. lesson 5 - service notes below

    public AccountController (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ToDoListContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }

    public ActionResult Index()
    {
      return View();
    }

    public IActionResult Register()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Register (RegisterViewModel model) // async Task that contains an ActionResult
    {
      var user = new ApplicationUser { UserName = model.Email };
      IdentityResult result = await _userManager.CreateAsync(user, model.Password); // CreateAsync() is a built in class method of UserManager via Identity
      if (result.Succeeded) // if CreateAsync() is successful, redirect to Index
      {
        return RedirectToAction("Index");
      }
      else // if it is not successful, return the Register View
      {
        return View();
      }
    }
  }
}

// a service is a helpful tool 

// Dependency injection is the act of providing a helpful tool (known as a service) to part of an application that needs it before it actually needs it. This ensures that the application doesn't need to worry about locating, loading, finding, or creating that service on its own
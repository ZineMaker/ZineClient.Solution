using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using ZineClient.Models;
using System.Threading.Tasks;
using ZineClient.ViewModels;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Claims;

namespace ZineClient.Controllers
{
  public class AccountController : Controller
  {
    private readonly ZineClientContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;


    public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ZineClientContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }

    public ActionResult Index()
    {
      return View();
    }
    public async Task<ActionResult> Organizations()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      // ViewBag.MyOrganizations = _db.ApplicationUserOrganization.Where(join => join.ApplicationUser == currentUser).ToList();

      return View(currentUser);
    }

    public async Task<ActionResult> Posts()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      return View(currentUser);
    }

    public async Task<ActionResult> Zines()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);

      ViewBag.MyOrganizations = _db.ApplicationUserOrganization.Where(join => join.ApplicationUser == currentUser).ToList();

      return View(currentUser);
    }

    public IActionResult Register()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Register(RegisterViewModel model)
    {
      var user = new ApplicationUser { UserName = model.Email, FirstName = model.FirstName, LastName = model.LastName };
      IdentityResult result = await _userManager.CreateAsync(user, model.Password);
      if (result.Succeeded)
      {
        return RedirectToAction("Index");
      }
      else
      {
        return View();
      }
    }

    public ActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Login(RegisterViewModel model)
    {
      Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
      if (result.Succeeded)
      {
        return RedirectToAction("Index");
      }
      else
      {
        return View();
      }
    }

    [HttpPost]
    public async Task<ActionResult> LogOff()
    {
      await _signInManager.SignOutAsync();
      return RedirectToAction("Index", "Home");
    }


  }
}
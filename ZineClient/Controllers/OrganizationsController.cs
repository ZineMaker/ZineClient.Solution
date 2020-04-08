using Microsoft.AspNetCore.Authorization;
using ZineClient.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace ZineClient.Controllers
{
  [Authorize]
  public class OrganizationsController : Controller
  {
    private readonly ZineClientContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public OrganizationsController(UserManager<ApplicationUser> userManager, ZineClientContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    [AllowAnonymous]
    public ActionResult Index()
    {
      List<Organization> model = _db.Organizations.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Create(Organization organization)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      organization.Owner = currentUser;

      _db.Organizations.Add(organization);
      _db.ApplicationUserOrganization.Add(new ApplicationUserOrganization() { ApplicationUser = currentUser, OrganizationId = organization.OrganizationId });

      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [AllowAnonymous]
    public ActionResult Details(int id)
    {
      var thisOrganization = _db.Organizations
      .Include(o => o.ApplicationUsers)
      .ThenInclude(join => join.ApplicationUser)
      .Include(o => o.Zines)
      .FirstOrDefault(o => o.OrganizationId == id);

      return View(thisOrganization);
    }

    public ActionResult Edit(int id)
    {
      var thisOrganization = _db.Organizations.FirstOrDefault(organization => organization.OrganizationId == id);

      return View(thisOrganization);
    }

    [HttpPost]
    public ActionResult Edit(Organization organization)
    {
      _db.Entry(organization).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisOrganization = _db.Organizations.FirstOrDefault(organizations => organizations.OrganizationId == id);

      return View(thisOrganization);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisOrganization = _db.Organizations.FirstOrDefault(organizations => organizations.OrganizationId == id);
      _db.Organizations.Remove(thisOrganization);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddUser(int id)
    {
      var thisOrganization = _db.Organizations.FirstOrDefault(organizations => organizations.OrganizationId == id);

      return View(thisOrganization);
    }

    [HttpPost]
    public ActionResult AddUser(Organization organization, int ApplicationUserId)
    {
      return View();
    }
  }
}
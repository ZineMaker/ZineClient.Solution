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
using System;

namespace ZineClient.Controllers
{
  [Authorize]
  public class ZinesController : Controller
  {
    private readonly ZineClientContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public ZinesController(UserManager<ApplicationUser> userManager, ZineClientContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    [AllowAnonymous]
    public ActionResult Index()
    {
      List<Zine> model = _db.Zines.ToList();
      return View(model);
    }

    public ActionResult Create(int id)
    {
      ViewBag.OrganizationId = id;
      return View();
    }

    [HttpPost]
    public ActionResult Create(Zine zine)
    {
      // var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      // var currentUser = await _userManager.FindByIdAsync(userId);
      // organization.Owner = currentUser;
      // zine.Organization = _db.Organizations.FirstOrDefault(o => o.OrganizationId == zine.OrganizationId);

      _db.Zines.Add(zine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [AllowAnonymous]
    public ActionResult Details(int id)
    {
      var thisZine = _db.Zines
      .Include(o => o.Posts)
      .ThenInclude(join => join.Post)
      .FirstOrDefault(o => o.ZineId == id);

      var thisOrganization = _db.Organizations.FirstOrDefault(organizations => organizations.OrganizationId == thisZine.OrganizationId);
      ViewBag.Name = thisOrganization.Name;
      return View(thisZine);
    }

    public ActionResult Edit(int id)
    {
      var thisZine = _db.Zines.FirstOrDefault(zines => zines.ZineId == id);
      // var thisOrganization = _db.Organizations.FirstOrDefault(organizations => organizations.OrganizationId == thisZine.OrganizationId);
      // ViewBag.Organization = thisOrganization;
      return View(thisZine);
    }

    [HttpPost]
    public ActionResult Edit(Zine zine)
    {
      _db.Entry(zine).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", "Zines", new { id = zine.ZineId });
    }
    public ActionResult Delete(int id)
    {
      var thisZine = _db.Zines.FirstOrDefault(zines => zines.ZineId == id);

      return View(thisZine);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisZine = _db.Zines.FirstOrDefault(zines => zines.ZineId == id);
      _db.Zines.Remove(thisZine);
      _db.SaveChanges();
      return RedirectToAction("Details", "Organizations", new { id = thisZine.OrganizationId });
    }
  }
}
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
  public class TagsController : Controller
  {
    private readonly ZineClientContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public TagsController(UserManager<ApplicationUser> userManager, ZineClientContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    [AllowAnonymous]
    public ActionResult Index()
    {
      List<Tag> model = _db.Tags.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      // ViewBag.PostId = new SelectList(_db.Posts, "PostId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Tag tag)
    {
      // var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      // var currentUser = await _userManager.FindByIdAsync(userId);
      // tag.ApplicationUser = currentUser;

      _db.Tags.Add(tag);
      // if (PostId != 0)
      // {
      //   _db.PostTag.Add(new PostTag() { PostId = PostId, TagId = tag.TagId });
      // }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [AllowAnonymous]
    public ActionResult Details(int id)
    {
      var thisTag = _db.Tags
      .Include(tag => tag.Posts)
      .ThenInclude(join => join.Post)
      .FirstOrDefault(o => o.TagId == id);

      return View(thisTag);
    }

    public ActionResult Edit(int id)
    {
      var thisTag = _db.Tags.FirstOrDefault(tags => tags.TagId == id);

      return View(thisTag);
    }

    [HttpPost]
    public ActionResult Edit(Tag tag)
    {
      _db.Entry(tag).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Delete(int id)
    {
      var thisTag = _db.Tags.FirstOrDefault(tags => tags.TagId == id);

      return View(thisTag);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisTag = _db.Tags.FirstOrDefault(tags => tags.TagId == id);
      _db.Tags.Remove(thisTag);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteTag(int joinId)
    {
      var joinEntry = _db.PostTag.FirstOrDefault(entry => entry.PostTagId == joinId);
      int thisPostId = joinEntry.PostId;

      _db.PostTag.Remove(joinEntry);
      _db.SaveChanges();

      return RedirectToAction("Details", "Posts", new { id = thisPostId });
    }
  }
}
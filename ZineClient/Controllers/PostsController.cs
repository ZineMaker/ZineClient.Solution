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
  public class PostsController : Controller
  {
    private readonly ZineClientContext _db;

    private readonly UserManager<ApplicationUser> _userManager;
    public PostsController(UserManager<ApplicationUser> userManager, ZineClientContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public ActionResult Index()
    {
      List<Post> model = _db.Posts.ToList();
      return View(model);
    }

    // public ActionResult Test()
    // {
    //   return View();
    // }

    public ActionResult Create()
    {
      ViewBag.ZineId = new SelectList(_db.Zines, "ZineId", "Name");
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Create(Post post, int ZineId)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      post.ApplicationUser = currentUser;
      post.Published = DateTime.Now;

      _db.Posts.Add(post);
      if (ZineId != 0)
      {
        _db.PostZine.Add(new PostZine() { ZineId = ZineId, PostId = post.PostId });
      }
      _db.SaveChanges();
      return RedirectToAction("Details", "Zines", new { id = ZineId });
    }

    [AllowAnonymous]
    public ActionResult Details(int id)
    {
      var thisPost = _db.Posts
      .Include(o => o.Zines)
      .ThenInclude(join => join.Zine)
      .Include(o => o.Tags)
      .ThenInclude(join => join.Tag)
      .FirstOrDefault(o => o.PostId == id);

      return View(thisPost);
    }

    public ActionResult Edit(int id)
    {
      var thisPost = _db.Posts.FirstOrDefault(posts => posts.PostId == id);

      return View(thisPost);
    }

    [HttpPost]
    public ActionResult Edit(Post post)
    {
      _db.Entry(post).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", "Posts", new { id = post.PostId });
    }
    // public ActionResult CheckDelete(int id)
    // {
    //   var thisOrganization = _db.Organizations.FirstOrDefault(organization => organization.OrganizationId == id);

    //   return View("Delete", thisOrganization);
    // }

    public ActionResult Delete(int id)
    {
      var thisPost = _db.Posts.FirstOrDefault(posts => posts.PostId == id);

      return View(thisPost);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisPost = _db.Posts.FirstOrDefault(posts => posts.PostId == id);
      _db.Posts.Remove(thisPost);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddZine(int id)
    {
      var thisPost = _db.Posts.FirstOrDefault(posts => posts.PostId == id);
      List<Zine> selectedZines = _db.Zines.OrderBy(x => x.Name).ToList(); // Alphabetize ALL zines
      var postZines = _db.PostZine.Where(x => x.PostId == id).ToList(); // list of PostZines that match this post

      foreach (PostZine join in postZines)
      {
        Zine thisZine = _db.Zines.Find(join.ZineId);
        selectedZines.Remove(thisZine);
      }

      ViewBag.ZineId = new SelectList(selectedZines, "ZineId", "Name");

      // ViewBag.ZineId = new SelectList(_db.Zines, "ZineId", "Name");
      return View(thisPost);
    }

    [HttpPost]
    public ActionResult AddZine(Post post, int ZineId)
    {
      if (ZineId != 0)
      {
        _db.PostZine.Add(new PostZine() { ZineId = ZineId, PostId = post.PostId });
      }
      _db.SaveChanges();
      return RedirectToAction("Details", "Posts", new { id = post.PostId });
    }

    [HttpPost]
    public ActionResult DeleteZine(int joinId)
    {
      var joinEntry = _db.PostZine.FirstOrDefault(entry => entry.PostZineId == joinId);

      //var thisPost = _db.Posts.FirstOrDefault(x => x.PostId == joinEntry.PostId);

      int thisPostId = joinEntry.PostId;

      _db.PostZine.Remove(joinEntry);
      _db.SaveChanges();

      return RedirectToAction("Details", "Posts", new { id = thisPostId });
      // return RedirectToAction("Index");
    }

    public ActionResult AddTag(int id)
    {
      var thisPost = _db.Posts.FirstOrDefault(posts => posts.PostId == id);
      List<Tag> selectedTags = _db.Tags.OrderBy(x => x.Name).ToList();
      var postTags = _db.PostTag.Where(x => x.PostId == id).ToList();

      foreach (PostTag join in postTags)
      {
        Tag thisTag = _db.Tags.Find(join.TagId);
        selectedTags.Remove(thisTag);
      }

      ViewBag.TagId = new SelectList(selectedTags, "TagId", "Name");

      return View(thisPost);
    }

    [HttpPost]
    public ActionResult AddTag(Post post, int TagId)
    {
      if (TagId != 0)
      {
        _db.PostTag.Add(new PostTag() { TagId = TagId, PostId = post.PostId });
      }
      _db.SaveChanges();
      return RedirectToAction("Details", "Posts", new { id = post.PostId });
    }
  }
}
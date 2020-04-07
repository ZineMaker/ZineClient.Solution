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
  public class PostsController : Controller
  {
    private readonly ZineClientContext _db;
    public PostsController(ZineClientContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Post> model = _db.Posts.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.ZineId = new SelectList(_db.Zines, "ZineId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Post post, int ZineId)
    {
      _db.Posts.Add(post);
      if (ZineId != 0)
      {
        _db.PostZine.Add(new PostZine() { ZineId = ZineId, PostId = post.PostId });
      }
      _db.SaveChanges();
      return RedirectToAction("Details", "Zines", new {id = ZineId});
    }

    [AllowAnonymous]
    public ActionResult Details(int id)
    {
      var thisPost = _db.Posts
      .Include(o => o.Zines)
      .ThenInclude(join => join.Zine)
      .FirstOrDefault(o => o.PostId == id);

      return View(thisPost);
    }

    // public ActionResult Edit(int id)
    // {
    //   var thisOrganization = _db.Organizations.FirstOrDefault(organization => organization.OrganizationId == id);

    //   return View(thisOrganization);
    // }

    // [HttpPost]
    // public ActionResult Edit(Organization organization)
    // {
    //   _db.Entry(organization).State = EntityState.Modified;
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
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
  }
}
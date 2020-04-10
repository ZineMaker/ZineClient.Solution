using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZineClient.Models;

namespace ZineClient.Controllers
{
  public class HomeController : Controller
  {
    private readonly ZineClientContext _db;

    public HomeController(ZineClientContext db)
    {
      _db = db;
    }
    public IActionResult Index()
    {
      ViewBag.TopFour = _db.Zines.OrderBy(z => z.PublicationDate).Take(12).ToList();
      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}

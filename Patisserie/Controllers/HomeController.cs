using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Patisserie.Models;
namespace Patisserie.Controllers
{
    public class HomeController : Controller
    {
      public readonly PatisserieContext _db;
      public HomeController(PatisserieContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        var flavours = _db.Flavours.ToList();
        var treats = _db.Treats.ToList();

        ViewBag.Flavours = flavours;
        ViewBag.Treats = treats;
        
        return View();
      } 
  }
}
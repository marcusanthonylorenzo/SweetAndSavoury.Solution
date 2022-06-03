using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Patisserie.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using System;

namespace Patisserie.Controllers
{
  [Authorize]
  public class TreatsController : Controller
  {
    private readonly PatisserieContext _db;

    public TreatsController(PatisserieContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Treat> model = _db.Treats.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Treat Treat)
    {
      _db.Treats.Add(Treat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      var thisTreat = _db.Treats
          .Include(Treat => Treat.JoinEntities)
          .ThenInclude(join => join.Treat)
          .FirstOrDefault(Treat => Treat.TreatId == id);
      return View(thisTreat);
    }
    public ActionResult Edit(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(Treat => Treat.TreatId == id);
      ViewBag.FlavourId = new SelectList(_db.Flavours, "FlavourId", "FlavourName");
      return View(thisTreat);
    }

    [HttpPost]
    public ActionResult Edit(Treat Treat)
    {
      _db.Entry(Treat).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(Treat => Treat.TreatId == id);
      return View(thisTreat);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(Treat => Treat.TreatId == id);
      _db.Treats.Remove(thisTreat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
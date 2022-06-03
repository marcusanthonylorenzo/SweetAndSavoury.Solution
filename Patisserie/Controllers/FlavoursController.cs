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
  public class FlavoursController : Controller
  {
    private readonly PatisserieContext _db;

    public FlavoursController(PatisserieContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Flavour> model = _db.Flavours.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Flavour flavour)
    {
      _db.Flavours.Add(flavour);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      var thisFlavour = _db.Flavours
          .Include(flavour => flavour.JoinEntities)
          .ThenInclude(join => join.Treat)
          .FirstOrDefault(flavour => flavour.FlavourId == id);
      return View(thisFlavour);
    }
    public ActionResult Edit(int id)
    {
      var thisFlavour = _db.Flavours.FirstOrDefault(flavour => flavour.FlavourId == id);
      ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "Name");

      return View(thisFlavour);
    }

    [HttpPost]
    public ActionResult Edit(Flavour flavour, int treatId)
    {
      _db.Entry(flavour).State = EntityState.Modified;
      _db.FlavourTreat.Add(new FlavourTreat() { TreatId = treatId, FlavourId = flavour.FlavourId });
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisFlavour = _db.Flavours.FirstOrDefault(flavour => flavour.FlavourId == id);
      return View(thisFlavour);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisFlavour = _db.Flavours.FirstOrDefault(flavour => flavour.FlavourId == id);
      _db.Flavours.Remove(thisFlavour);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
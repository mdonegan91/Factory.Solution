using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Factory.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory.Controllers
{
  public class SpecialtiesController : Controller
  {
    private readonly FactoryContext _db;

    public SpecialtiesController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Specialty> model = _db.Specialties.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Specialty specialty)
    {
      _db.Specialties.Add(specialty);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Edit(int id)
    {
      Specialty thisSpecialty = _db.Specialties.FirstOrDefault(specialty => specialty.SpecialtyId == id);
      return View(thisSpecialty);
    }

    [HttpPost]
    public ActionResult Edit(Specialty specialty)
    {
      _db.Specialties.Update(specialty);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Specialty thisSpecialty = _db.Specialties
                                .Include(specialty => specialty.JoinEntities2)
                                .ThenInclude(join => join.Engineer)
                                .FirstOrDefault(specialty => specialty.SpecialtyId == id);
      return View(thisSpecialty);
    }

    public ActionResult AddEngineer(int id)
    {
      Specialty thisSpecialty = _db.Specialties.FirstOrDefault(Specialties => Specialties.SpecialtyId == id);
      ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "EngineerName");
      return View(thisSpecialty);
    }

    [HttpPost]
    public ActionResult AddEngineer(Specialty specialty, int engineerId)
    {
  #nullable enable
      EngineerSpecialty? joinEntity = _db.EngineerSpecialties.FirstOrDefault(join => (join.EngineerId == engineerId && join.SpecialtyId == specialty.SpecialtyId));
  #nullable disable
      if (joinEntity == null && engineerId != 0)
      {
        _db.EngineerSpecialties.Add(new EngineerSpecialty() { EngineerId = engineerId, SpecialtyId = specialty.SpecialtyId });
        _db.SaveChanges();
      }
      return RedirectToAction("Details", new { id = specialty.SpecialtyId });
    }

    public ActionResult Delete(int id)
    {
      Specialty thisSpecialty = _db.Specialties.FirstOrDefault(specialty => specialty.SpecialtyId == id);
      return View(thisSpecialty);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Specialty thisSpecialty = _db.Specialties.FirstOrDefault(specialty => specialty.SpecialtyId == id);
      _db.Specialties.Remove(thisSpecialty);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
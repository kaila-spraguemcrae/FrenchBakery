using FrenchBakery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FrenchBakery.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly FrenchBakeryContext _db;
    public FlavorsController(FrenchBakeryContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Flavor> flavorList = _db.Flavors.ToList();
      return View(flavorList);
    }
  }
}
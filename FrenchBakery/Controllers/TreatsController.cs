using FrenchBakery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FrenchBakery.Controllers
{
  public class TreatsController : Controller
  {
    private readonly FrenchBakeryContext _db;
    public TreatsController(FrenchBakeryContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Treat> treatList = _db.Treats.ToList();
      return View(treatList);
    }
  }
}
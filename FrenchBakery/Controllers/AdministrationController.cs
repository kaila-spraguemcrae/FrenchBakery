using FrenchBakery.Models;
using FrenchBakery.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System;

namespace FrenchBakery.Controllers
{
  public class AdministrationContoller: Controller
  {
    private readonly RoleManager<IdentityRole> roleManager;

    public AdministrationContoller(RoleManager<IdentityRole> roleManager)
    {
      this.roleManager = roleManager;
    }
    public ActionResult Index()
    {
      return View();
    }
    public ActionResult CreateRole()
    {
      return View();
    }
  }
}
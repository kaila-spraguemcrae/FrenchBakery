using FrenchBakery.Models;
using FrenchBakery.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System;

namespace FrenchBakery.Controllers
{
  public class AdministrationController: Controller
  {
    private readonly RoleManager<IdentityRole> roleManager;
    private readonly UserManager<ApplicationUser> userManager;

    public AdministrationController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
    {
      this.roleManager = roleManager;
      this.userManager = userManager;
    }
    public IActionResult CreateRole()
    {
      return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
    {
      if(ModelState.IsValid)
      {
        IdentityRole identityRole = new IdentityRole
        {
          Name = model.RoleName
        };

        IdentityResult result = await roleManager.CreateAsync(identityRole);

        if(result.Succeeded)
        {
          return RedirectToAction("ListRoles", "Administration");
        } 
        foreach (IdentityError error in result.Errors)
        {
          ModelState.AddModelError("", error.Description);
        }
      }
      return View(model);
    }
    public IActionResult ListRoles()
    {
      var roles = roleManager.Roles;
      return View(roles);
    }

    public async Task<IActionResult> EditRole(string id)
    {
      var role = await roleManager.FindByIdAsync(id);

      // if(role == null)
      // {
      //   ViewBag.ErrorMessage = $"Role with Id = {id} cannot be found";
      //   return View("NotFound");
      // }
      var model = new EditRoleViewModel {Id = role.Id, RoleName = role.Name};
      
      foreach (var user in userManager.Users)
      {
        if(await userManager.IsInRoleAsync(user, role.Name))
        {
          model.Users.Add(user.UserName);
        }
      }
      return View(model);
    }
  }
}
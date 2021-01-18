using FrenchBakery.Models;
using FrenchBakery.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace FrenchBakery.Controllers
{
  [Authorize]
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

    [HttpPost]
    public async Task<IActionResult> EditRole(EditRoleViewModel model)
    {
      var role = await roleManager.FindByIdAsync(model.Id);
      role.Name = model.RoleName;

      var result = await roleManager.UpdateAsync(role);

      if(result.Succeeded)
      {
        return RedirectToAction("ListRoles");
      }
      return View(model);
    }

    public async Task<IActionResult> EditUsersInRole(string id)
    {
        ViewBag.roleId = id;

        var role = await roleManager.FindByIdAsync(id);

        var model = new List<UserRoleViewModel>();

        foreach (var user in userManager.Users)
        {
            var userRoleViewModel = new UserRoleViewModel
            {
                UserId = user.Id,
                UserName = user.UserName,
                IsSelected = await userManager.IsInRoleAsync(user, role.Name)
            };

            model.Add(userRoleViewModel);
        }

        return View(model);
    }

[HttpPost]
public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> model, string id)
{
    var role = await roleManager.FindByIdAsync(id);

    if (role == null)
    {
        ViewBag.ErrorMessage = $"Role with Id = {id} cannot be found";
        return View("NotFound");
    }

    for (int i = 0; i < model.Count; i++)
    {
        var user = await userManager.FindByIdAsync(model[i].UserId);

        IdentityResult result = null;

        if (model[i].IsSelected && !(await userManager.IsInRoleAsync(user, role.Name)))
        {
            result = await userManager.AddToRoleAsync(user, role.Name);
        }
        else if (!model[i].IsSelected && await userManager.IsInRoleAsync(user, role.Name))
        {
            result = await userManager.RemoveFromRoleAsync(user, role.Name);
        }
        else
        {
            continue;
        }

        if (result.Succeeded)
        {
            if (i < (model.Count - 1))
                continue;
            else
                return RedirectToAction("EditRole", new { Id = id });
        }
    }

    return RedirectToAction("EditRole", new { Id = id });
}
  }
}
using System.ComponentModel.DataAnnotations;

namespace FrenchBakery.ViewModels
{
  public class UserRoleViewModel
  {
    public string UserId { get; set; }
    public string RoleId { get; set; }
    public string UserName { get; set; }
    public bool IsSelected { get; set; }
  }
}
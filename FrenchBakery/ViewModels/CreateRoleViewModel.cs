using System.ComponentModel.DataAnnotations;

namespace FrenchBakery.ViewModels
{
  public class CreateRoleViewModel
  {
    [Required]
    public string RoleName { get; set; }
  }
}
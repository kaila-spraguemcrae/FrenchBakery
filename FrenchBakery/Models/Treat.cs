using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FrenchBakery.Models
{
  public class Treat
  {
    public Treat()
    {
      this.Flavors = new HashSet<FlavorTreat>();
    }
    public int TreatId { get; set; }
    public string Name { get; set; }
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}")]
    public float Price { get; set; }
    public ICollection<FlavorTreat> Flavors { get; }
  }
}
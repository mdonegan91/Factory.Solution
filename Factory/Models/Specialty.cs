using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Specialty
  {
    
    public int SpecialtyId { get; set; }
    public string SpecialtyName { get; set; }
    public List<EngineerSpecialty> JoinEntities2 { get; }
  }
}
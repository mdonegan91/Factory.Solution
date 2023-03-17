namespace Factory.Models
{
  public class EngineerSpecialty
  {
    public int EngineerSpecialtyId { get; set; }
    public int EngineerId { get; set; }
    public int SpecialtyId { get; set; }
    public Engineer Engineer { get; set; }
    public Specialty Specialty { get; set; }
  }
}
using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    public DbSet<Specialty> Specialties { get; set; }
    public DbSet<Engineer> Engineers { get; set; }
    public DbSet<Machine> Machines { get; set; }
    public DbSet<EngineerMachine> EngineerMachines { get; set; }
    public DbSet<EngineerSpecialty> EngineerSpecialties { get; set; }
    public FactoryContext(DbContextOptions options) : base(options) { }
  }
}
using Microsoft.EntityFrameworkCore;

namespace ASApi.Models
{
  public class ASApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }
    public ASApiContext(DbContextOptions<ASApiContext> options) : base(options)  { }
    }
  }
using Microsoft.EntityFrameworkCore;

namespace HFSapi.Models
{
  public class HFSapiContext : DbContext
  {
    public HFSapiContext(DbContextOptions<HFSapiContext> options)
        : base(options)
    {
    }
    public DbSet<Game> Games { get; set; }
    public DbSet<Player> Players { get; set; } 
  }
}
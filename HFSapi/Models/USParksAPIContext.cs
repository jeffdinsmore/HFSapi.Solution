using Microsoft.EntityFrameworkCore;

namespace HFSapi.Models
{
  public class HFSapiContext : DbContext
  {
    public HFSapiContext(DbContextOptions<HFSapiContext> options)
        : base(options)
    {
    }

    public DbSet<> s { get; set; }    
  }
}
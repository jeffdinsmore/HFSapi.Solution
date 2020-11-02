using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace HFSapi.Models
{
  public class HFSapiContextFactory : IDesignTimeDbContextFactory<HFSapiContext>
  {

    HFSapiContext IDesignTimeDbContextFactory<HFSapiContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<HFSapiContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new HFSapiContext(builder.Options);
    }
  }
}
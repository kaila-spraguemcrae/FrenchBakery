using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace FrenchBakery.Models{
  public class FrenchBakeryContextFactory : IDesignTimeDbContextFactory<FrenchBakeryContext>
  {
    FrenchBakeryContext IDesignTimeDbContextFactory<FrenchBakeryContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();
      
      var builder = new DbContextOptionsBuilder<FrenchBakeryContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new FrenchBakeryContext(builder.Options);
    }
  }
}
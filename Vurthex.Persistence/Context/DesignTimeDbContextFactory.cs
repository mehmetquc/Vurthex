using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vurthex.Persistence.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<VurthexPsqlDbContext>
    {
        public VurthexPsqlDbContext CreateDbContext(string[] args)
        {
            ConfigurationManager configurationManager = new ConfigurationManager();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/Vurthex/Server"));
            configurationManager.AddJsonFile("appsettings.json");
            var builder = new DbContextOptionsBuilder<VurthexPsqlDbContext>();
            builder.UseNpgsql(configurationManager.GetConnectionString("PostgreSql"));
            return new VurthexPsqlDbContext(builder.Options);

        }
    }
}

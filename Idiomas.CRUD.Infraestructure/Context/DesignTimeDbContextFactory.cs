
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Idiomas.CRUD.Infraestructure.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<IdiomasContext>
    {
        public IdiomasContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .Build();

            var builder = new DbContextOptionsBuilder<IdiomasContext>();
            var connectionString = config.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);
            return new IdiomasContext(builder.Options);

        }
    }
}
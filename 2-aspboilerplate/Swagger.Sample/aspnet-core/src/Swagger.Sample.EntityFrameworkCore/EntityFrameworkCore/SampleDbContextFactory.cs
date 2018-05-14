using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Swagger.Sample.Configuration;
using Swagger.Sample.Web;

namespace Swagger.Sample.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SampleDbContextFactory : IDesignTimeDbContextFactory<SampleDbContext>
    {
        public SampleDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SampleDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SampleDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SampleConsts.ConnectionStringName));

            return new SampleDbContext(builder.Options);
        }
    }
}

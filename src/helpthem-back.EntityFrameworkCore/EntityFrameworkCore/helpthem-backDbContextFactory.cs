using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using helpthem-back.Configuration;
using helpthem-back.Web;

namespace helpthem-back.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class helpthem-backDbContextFactory : IDesignTimeDbContextFactory<helpthem-backDbContext>
    {
        public helpthem-backDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<helpthem-backDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            helpthem-backDbContextConfigurer.Configure(builder, configuration.GetConnectionString(helpthem-backConsts.ConnectionStringName));

            return new helpthem-backDbContext(builder.Options);
        }
    }
}

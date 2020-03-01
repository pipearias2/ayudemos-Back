using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace helpthem-back.EntityFrameworkCore
{
    public static class helpthem-backDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<helpthem-backDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<helpthem-backDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

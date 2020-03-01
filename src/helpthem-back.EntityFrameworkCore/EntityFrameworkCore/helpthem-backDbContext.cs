using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using helpthem-back.Authorization.Roles;
using helpthem-back.Authorization.Users;
using helpthem-back.MultiTenancy;

namespace helpthem-back.EntityFrameworkCore
{
    public class helpthem-backDbContext : AbpZeroDbContext<Tenant, Role, User, helpthem-backDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public helpthem-backDbContext(DbContextOptions<helpthem-backDbContext> options)
            : base(options)
        {
        }
    }
}

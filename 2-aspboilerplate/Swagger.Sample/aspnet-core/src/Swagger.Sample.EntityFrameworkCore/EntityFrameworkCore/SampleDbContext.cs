using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Swagger.Sample.Authorization.Roles;
using Swagger.Sample.Authorization.Users;
using Swagger.Sample.MultiTenancy;

namespace Swagger.Sample.EntityFrameworkCore
{
    public class SampleDbContext : AbpZeroDbContext<Tenant, Role, User, SampleDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SampleDbContext(DbContextOptions<SampleDbContext> options)
            : base(options)
        {
        }
    }
}

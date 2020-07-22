using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Dream.EntityFrameworkCore.DbMigrations.EntityFrameworkCore
{
    public class DreamMigrationsDbContext : AbpDbContext<DreamMigrationsDbContext>
    {
        public DreamMigrationsDbContext(DbContextOptions<DreamMigrationsDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Configure();
        }
    }
}

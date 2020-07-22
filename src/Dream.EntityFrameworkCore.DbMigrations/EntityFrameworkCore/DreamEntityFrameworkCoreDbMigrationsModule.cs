using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Dream.EntityFrameworkCore.DbMigrations.EntityFrameworkCore
{
    [DependsOn(
         typeof(DreamFrameworkCoreModule)
     )]
    public class DreamEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<DreamMigrationsDbContext>();
        }
    }
}

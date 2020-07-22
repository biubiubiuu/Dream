using Dream.Domain;
using Dream.Domain.Configurations;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Caching;
using Volo.Abp.Modularity;

namespace Dream.Application.Caching
{
    [DependsOn(
        typeof(AbpCachingModule),
        typeof(DreamDomainModule)
     )]
    public class DreamApplicationCachingModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = AppSettings.Caching.RedisConnectionString;
                //options.InstanceName
                //options.ConfigurationOptions
            });
        }
    }
}

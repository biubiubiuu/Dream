using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Dream.Application
{
    [DependsOn(
        typeof(AbpIdentityApplicationModule)
    )]
    public class DreamApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {

        }
    }
}

using Dream.Application;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Dream.HttpApi
{
    [DependsOn(
        typeof(AbpIdentityHttpApiModule),
        typeof(DreamApplicationModule)
     )]
    public class DreamHttpApiModule : AbpModule
    {

    }
}

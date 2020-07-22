using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Dream.Domain.Shared
{
    [DependsOn(typeof(AbpIdentityDomainSharedModule))]
    public class DreamDomainSharedModule : AbpModule
    {
    }
}
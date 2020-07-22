
using Dream.Domain.Shared;
using Volo.Abp;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Dream.Domain
{
    [DependsOn(
        typeof(AbpIdentityDomainModule),
        typeof(DreamDomainSharedModule)
        )]
    public class DreamDomainModule : AbpModule
    {

    }
}
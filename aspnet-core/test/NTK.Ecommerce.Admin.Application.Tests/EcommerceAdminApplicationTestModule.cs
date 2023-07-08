using Volo.Abp.Modularity;

namespace NTK.Ecommerce.Admin;

[DependsOn(
    typeof(EcommerceAdminApplicationModule),
    typeof(EcommerceDomainTestModule)
    )]
public class EcommerceAdminApplicationTestModule : AbpModule
{

}

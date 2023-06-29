using NTK.Ecommerce.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace NTK.Ecommerce;

[DependsOn(
    typeof(EcommerceEntityFrameworkCoreTestModule)
    )]
public class EcommerceDomainTestModule : AbpModule
{

}

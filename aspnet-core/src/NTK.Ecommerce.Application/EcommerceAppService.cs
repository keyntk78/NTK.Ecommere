using System;
using System.Collections.Generic;
using System.Text;
using NTK.Ecommerce.Localization;
using Volo.Abp.Application.Services;

namespace NTK.Ecommerce;

/* Inherit your application services from this class.
 */
public abstract class EcommerceAppService : ApplicationService
{
    protected EcommerceAppService()
    {
        LocalizationResource = typeof(EcommerceResource);
    }
}

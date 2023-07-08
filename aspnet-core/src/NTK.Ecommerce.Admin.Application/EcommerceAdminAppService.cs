using System;
using System.Collections.Generic;
using System.Text;
using NTK.Ecommerce.Localization;
using Volo.Abp.Application.Services;

namespace NTK.Ecommerce.Admin;

/* Inherit your application services from this class.
 */
public abstract class EcommerceAdminAppService : ApplicationService
{
    protected EcommerceAdminAppService()
    {
        LocalizationResource = typeof(EcommerceResource);
    }
}

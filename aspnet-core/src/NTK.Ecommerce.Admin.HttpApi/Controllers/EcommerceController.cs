﻿using NTK.Ecommerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace NTK.Ecommerce.Admin.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class EcommerceController : AbpControllerBase
{
    protected EcommerceController()
    {
        LocalizationResource = typeof(EcommerceResource);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace NTK.Ecommerce.Products
{
    public class Tag  : Entity<string>
    {
        public string Name { get; set; } = string.Empty;
    }
}

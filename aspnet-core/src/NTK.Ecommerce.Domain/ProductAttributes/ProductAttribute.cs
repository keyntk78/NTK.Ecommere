﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace NTK.Ecommerce.ProductAttributes
{
    public class ProductAttribute : CreationAuditedAggregateRoot<Guid>
    {
        public string Code { get; set; } = string.Empty;
        public AttributeType DataType { get; set; }
        public string Label { get; set; } = string.Empty;
        public int SortOrder { get; set; }
        public bool Visibility { get; set; }
        public bool IsActive { get; set; }
        public bool IsRequired { get; set; }
        public bool IsUnique { get; set; }
        public string Note { get; set; } = string.Empty;
    }
}

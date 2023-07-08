using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace NTK.Ecommerce.Manufacturers
{
    public class Manufacturer : CreationAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string CoverPicture { get; set; } = string.Empty;
        public bool Visibility { get; set; }
        public bool IsActive { get; set; }
        public string Country { get; set; } = string.Empty;
    }
}

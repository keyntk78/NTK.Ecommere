using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace NTK.Ecommerce.Products
{
    public class ProductReview : CreationAuditedEntity<Guid>
    {
        public Guid ProductId { get; set; }
        public Guid? ParentId { get; set; }
        public string Title { get; set; } = string.Empty;
        public double Rating { get; set; }

        public DateTime? PublishedDate { get; set; }
        public string Content { get; set; } = string.Empty;
        public Guid OrderId { get; set; }
    }
}

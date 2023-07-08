using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace NTK.Ecommerce.Products
{
    public class Product : AuditedAggregateRoot<Guid>
    {
        public Guid ManufacturerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public ProductType ProductType { get; set; }
        public string SKU { get; set; } = string.Empty;
        public int SortOrder { get; set; }  
        public bool Visibility { get; set; }
        public bool IsActive { get; set; }
        public Guid CategoryId { get; set; }
        public string SeoMetaDescription { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ThumbnailPicture { get; set; } = string.Empty;
    }
}

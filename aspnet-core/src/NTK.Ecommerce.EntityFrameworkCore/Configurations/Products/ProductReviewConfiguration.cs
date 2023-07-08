using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NTK.Ecommerce.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTK.Ecommerce.Configurations.Products
{
    public class ProductReviewConfiguration : IEntityTypeConfiguration<ProductReview>
    {
        public void Configure(EntityTypeBuilder<ProductReview> builder)
        {
            builder.ToTable(EcommerceConsts.DbTablePrefix + "ProductReviews");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title)
               .HasMaxLength(250)
               .IsRequired();

        }
    }
}

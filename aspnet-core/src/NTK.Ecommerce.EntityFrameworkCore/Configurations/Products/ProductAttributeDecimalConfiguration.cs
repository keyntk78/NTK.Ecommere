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
    public class ProductAttributeDecimalConfiguration : IEntityTypeConfiguration<ProductAttributeDecimal>
    {
        public void Configure(EntityTypeBuilder<ProductAttributeDecimal> builder)
        {
            builder.ToTable(EcommerceConsts.DbTablePrefix + "ProductAttributeDecimals");
            builder.HasKey(x => x.Id);
        }
    }
}

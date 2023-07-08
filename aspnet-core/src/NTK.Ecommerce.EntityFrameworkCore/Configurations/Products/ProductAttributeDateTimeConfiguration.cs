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
    public class ProductAttributeDateTimeConfiguration : IEntityTypeConfiguration<ProductAttributeDateTime>
    {
        public void Configure(EntityTypeBuilder<ProductAttributeDateTime> builder)
        {
            builder.ToTable(EcommerceConsts.DbTablePrefix + "ProductAttributeDateTimes");
            builder.HasKey(x => x.Id);

        }
    }
}

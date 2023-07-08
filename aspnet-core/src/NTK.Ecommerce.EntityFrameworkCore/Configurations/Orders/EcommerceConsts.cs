using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NTK.Ecommerce.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTK.Ecommerce.Configurations.Orders
{
    public class OrderTransactionConfiguration : IEntityTypeConfiguration<OrderTransaction>
    {
        public void Configure(EntityTypeBuilder<OrderTransaction> builder)
        {
            builder.ToTable(EcommerceConsts.DbTablePrefix + "OrderTransactions");

            builder.Property(x => x.Code)
                 .HasMaxLength(50)
                 .IsUnicode(false)
                 .IsRequired();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace NTK.Ecommerce.Products
{
    public class ProductTag : Entity
    {
        public Guid ProductId { get; set; }
        public string TagId { get; set; } = string.Empty;

        public override object[] GetKeys()
        {
            return new object[] { ProductId, TagId };
        }
    }
}

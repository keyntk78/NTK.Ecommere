using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace NTK.Ecommerce.Orders
{
    public class OrderTransaction : CreationAuditedEntity<Guid>
    {
        public string Code { get; set; } = string.Empty;
        public Guid OrderId { get; set; }
        public Guid? UserId { get; set; }
        public TransactionType TransactionType { get; set; }
        public string Note { get; set; } = string.Empty;

    }
}

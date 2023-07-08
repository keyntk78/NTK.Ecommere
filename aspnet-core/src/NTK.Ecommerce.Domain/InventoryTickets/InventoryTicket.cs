using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace NTK.Ecommerce.InventoryTickets
{
    public class InventoryTicket : AuditedAggregateRoot<Guid>
    {
        public string Code { get; set; } = string.Empty;
        public TicketType TicketType { get; set; }
        public bool IsApproved { get; set; }
        public Guid? ApproverId { get; set; }
        public DateTime? ApprovedDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class TicketType
{
    public int TicketTypeId { get; set; }

    public string? TicketTypeName { get; set; }

    public virtual ICollection<CustomerSupportTicket> CustomerSupportTickets { get; set; } = new List<CustomerSupportTicket>();
}

using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class TicketPriority
{
    public int PriorityId { get; set; }

    public string? PriorityDesc { get; set; }

    public virtual ICollection<CustomerSupportTicket> CustomerSupportTickets { get; set; } = new List<CustomerSupportTicket>();
}

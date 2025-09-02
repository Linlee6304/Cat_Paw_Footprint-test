using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class TicketStatus
{
    public int StatusId { get; set; }

    public string? StatusDesc { get; set; }

    public virtual ICollection<CustomerSupportTicket> CustomerSupportTickets { get; set; } = new List<CustomerSupportTicket>();
}

using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class CustomerProfile
{
    public int CustomerProfilesId { get; set; }

    public int? CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? Idnumber { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? ProfileCode { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<CustomerBlacklist> CustomerBlacklists { get; set; } = new List<CustomerBlacklist>();

    public virtual ICollection<CustomerOrder> CustomerOrders { get; set; } = new List<CustomerOrder>();

    public virtual ICollection<CustomerSupportTicket> CustomerSupportTickets { get; set; } = new List<CustomerSupportTicket>();
}

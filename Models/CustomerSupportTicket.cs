using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class CustomerSupportTicket
{
    public int TicketId { get; set; }

    public int? CustomerId { get; set; }

    public int? EmployeeId { get; set; }

    public string Subject { get; set; } = null!;

    public int? TicketTypeId { get; set; }

    public string? Description { get; set; }

    public int? StatusId { get; set; }

    public int? PriorityId { get; set; }

    public DateTime? CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public virtual CustomerProfile? Customer { get; set; }

    public virtual ICollection<CustomerSupportFeedback> CustomerSupportFeedbacks { get; set; } = new List<CustomerSupportFeedback>();

    public virtual CustomerSupportMessage? CustomerSupportMessage { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual TicketPriority? Priority { get; set; }

    public virtual TicketStatus? Status { get; set; }

    public virtual TicketType? TicketType { get; set; }
}

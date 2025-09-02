using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class SupportAnalysis
{
    public int? DateId { get; set; }

    public int? TicketId { get; set; }

    public int? OpenedCount { get; set; }

    public int? ResolvedCount { get; set; }

    public int? RatingAverage { get; set; }

    public string? TopCategory { get; set; }

    public virtual DateDimension? Date { get; set; }

    public virtual CustomerSupportTicket? Ticket { get; set; }
}

using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class CustomerSupportFeedback
{
    public int FeedbackId { get; set; }

    public int? TicketId { get; set; }

    public int? CustomerId { get; set; }

    public int? FeedbackRating { get; set; }

    public string? FeedbackComment { get; set; }

    public DateTime? CreateTime { get; set; }

    public virtual CustomerSupportTicket? Ticket { get; set; }
}

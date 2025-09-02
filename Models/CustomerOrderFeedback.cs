using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class CustomerOrderFeedback
{
    public int FeedbackId { get; set; }

    public int? OrderId { get; set; }

    public int? CustomerId { get; set; }

    public int? FeedbackRating { get; set; }

    public string? FeedbackComment { get; set; }

    public DateTime? CreateTime { get; set; }

    public virtual CustomerOrder? Order { get; set; }
}

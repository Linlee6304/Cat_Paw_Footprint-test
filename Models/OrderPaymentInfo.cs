using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class OrderPaymentInfo
{
    public int PaymentId { get; set; }

    public int? OrderId { get; set; }

    public int? PaymentAmount { get; set; }

    public int? PaymentStatusId { get; set; }

    public DateTime? TransectionTime { get; set; }

    public string? Notes { get; set; }

    public virtual CustomerOrder? Order { get; set; }

    public virtual PaymentStatus? PaymentStatus { get; set; }
}

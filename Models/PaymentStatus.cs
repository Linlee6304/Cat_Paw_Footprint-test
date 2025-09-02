using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class PaymentStatus
{
    public int PayMentStatusId { get; set; }

    public string? StatusDesc { get; set; }

    public virtual ICollection<OrderPaymentInfo> OrderPaymentInfos { get; set; } = new List<OrderPaymentInfo>();
}

using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class CustomerCouponsRecord
{
    public int? CustomerId { get; set; }

    public int? CouponId { get; set; }

    public bool? IsUsed { get; set; }

    public DateTime? UsedTime { get; set; }

    public virtual Coupon? Coupon { get; set; }

    public virtual Customer? Customer { get; set; }
}

using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class CouponPic
{
    public int? CouponId { get; set; }

    public byte[]? Picture { get; set; }

    public virtual Coupon? Coupon { get; set; }
}

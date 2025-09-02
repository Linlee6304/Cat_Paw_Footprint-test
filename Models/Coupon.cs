using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class Coupon
{
    public int CouponId { get; set; }

    public string? CouponCode { get; set; }

    public string? CouponDesc { get; set; }

    public int? DiscountType { get; set; }

    public decimal? DiscountValue { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndTime { get; set; }

    public bool? IsActive { get; set; }
}

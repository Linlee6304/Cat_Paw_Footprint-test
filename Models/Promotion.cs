using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class Promotion
{
    public int PromoId { get; set; }

    public string? PromoName { get; set; }

    public string? PromoDesc { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public int? DiscountType { get; set; }

    public decimal? DiscountValue { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }
}
